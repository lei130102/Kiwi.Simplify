using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
	/// Creates and layout individual crumbs.
	/// </summary>
    public class ViewLayoutCrumbs : ViewComposite, IContentValues
    {
        #region Type Definitions
        private class CrumbToButton : Dictionary<KiwiBreadCrumbItem, ViewDrawButton> { };
        private class ButtonToCrumb : Dictionary<ViewDrawButton, KiwiBreadCrumbItem> { };
        private class MenuItemToCrumb : Dictionary<KiwiContextMenuItem, KiwiBreadCrumbItem> { };
        #endregion

        #region Instance Fields
        private KiwiBreadCrumb _kiwiBreadCrumb;
        private NeedPaintHandler _needPaintDelegate;
        private ButtonController _pressedButtonController;
        private CrumbToButton _crumbToButton;
        private ButtonToCrumb _buttonToCrumb;
        private MenuItemToCrumb _menuItemToCrumb;
        private ViewDrawButton _overflowButton;
        private bool _showingContextMenu;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ViewLayoutCrumbs class.
		/// </summary>
        /// <param name="kiwiBreadCrumb">Reference to owning bread crumb control.</param>
        /// <param name="needPaintDelegate">Delegate used to request repainting..</param>
        public ViewLayoutCrumbs(KiwiBreadCrumb kiwiBreadCrumb,
                                NeedPaintHandler needPaintDelegate)
        {
            _kiwiBreadCrumb = kiwiBreadCrumb;
            _needPaintDelegate = needPaintDelegate;
            _crumbToButton = new CrumbToButton();
            _buttonToCrumb = new ButtonToCrumb();
            _showingContextMenu = false;

            CreateOverflowButton();
        }

        /// <summary>
        /// Release unmanaged and optionally managed resources.
        /// </summary>
        /// <param name="disposing">Called from Dispose method.</param>
        protected override void Dispose(bool disposing)
        {
            // Remove actual children to prevent disposal happening twice
            Clear();

            // Release each cached child control just once
            foreach (ViewBase child in _crumbToButton.Values)
                child.Dispose();

            // Prevent another call to dispose from trying to dispose them again
            _crumbToButton.Clear();
            _buttonToCrumb.Clear();
        }

        /// <summary>
		/// Obtains the String representation of this instance.
		/// </summary>
		/// <returns>User readable name of the instance.</returns>
		public override string ToString()
        {
            // Return the class name and instance identifier
            return "ViewLayoutCrumbs:" + Id;
        }
        #endregion

        #region Layout
        /// <summary>
        /// Discover the preferred size of the element.
        /// </summary>
        /// <param name="context">Layout context.</param>
        public override Size GetPreferredSize(ViewLayoutContext context)
        {
            // Create/delete child elements to match the current selected bread crumb path
            SyncBreadCrumbs();

            // We need to update the redirector for drawing each crumb
            PaletteRedirectBreadCrumb redirect = _kiwiBreadCrumb.GetRedirector() as PaletteRedirectBreadCrumb;

            Size preferredSize = Size.Empty;
            for (int i = 1; i < Count; i++)
            {
                // Do not show the left border on the first crumb
                redirect.Left = (i == 0);

                // Find size of the child
                Size childSize = this[i].GetPreferredSize(context);

                // Accumulate in width
                preferredSize.Width += childSize.Width;

                // Find maximum height
                preferredSize.Height = Math.Max(preferredSize.Height, childSize.Height);
            }

            // Add on the control level padding
            preferredSize.Width += _kiwiBreadCrumb.Padding.Horizontal;
            preferredSize.Height += _kiwiBreadCrumb.Padding.Vertical;

            return preferredSize;
        }

        /// <summary>
        /// Perform a layout of the elements.
        /// </summary>
        /// <param name="context">Layout context.</param>
        public override void Layout(ViewLayoutContext context)
        {
            Debug.Assert(context != null);

            // We need to update the redirector for drawing each crumb
            PaletteRedirectBreadCrumb redirect = _kiwiBreadCrumb.GetRedirector() as PaletteRedirectBreadCrumb;

            // We take on all the available display area
            ClientRectangle = context.DisplayRectangle;

            // Create/delete child elements to match the current selected bread crumb path
            SyncBreadCrumbs();

            // Positioning rectangle is our client rectangle reduced by control padding
            Rectangle layoutRect = new Rectangle(ClientLocation.X + _kiwiBreadCrumb.Padding.Left,
                                                 ClientLocation.Y + _kiwiBreadCrumb.Padding.Top,
                                                 ClientWidth - _kiwiBreadCrumb.Padding.Horizontal,
                                                 ClientHeight - _kiwiBreadCrumb.Padding.Vertical);

            // Position from left to right all items except the overflow button
            int offset = layoutRect.X;
            for (int i = 1; i < Count; i++)
            {
                // Do not show the left border on the first crumb
                redirect.Left = (i == 1);

                // Find size of the child
                Size childSize = this[i].GetPreferredSize(context);
                context.DisplayRectangle = new Rectangle(offset, layoutRect.Y, childSize.Width, layoutRect.Height);

                // Position the child
                this[i].Layout(context);
                this[i].Visible = true;

                // Move across
                offset += childSize.Width;
            }

            // If we overflowed then we need to use the overflow button
            if (offset > ClientWidth)
            {
                // Overflow button must be visible
                this[0].Visible = true;

                // How much space do we need to save?
                int overflowed = offset - ClientWidth;

                // Position overflow button and only the last items to fit space
                offset = layoutRect.X;
                for (int i = 0; i < Count; i++)
                {
                    // Decide if the crumb (not the overflow button) can be visible
                    if (i > 0)
                        this[i].Visible = (overflowed <= 0);

                    if (this[i].Visible)
                    {
                        // Do not show the left border on the first crumb
                        redirect.Left = (i == 0);

                        // Recover the already calculated size
                        Size childSize = this[i].GetPreferredSize(context);
                        context.DisplayRectangle = new Rectangle(offset, layoutRect.Y, childSize.Width, layoutRect.Height);

                        // Position the child
                        this[i].Layout(context);

                        // Move across
                        offset += childSize.Width;
                    }

                    // Adjust overflow space depending on if we are positioning crumb or overflow
                    if (i != 0)
                        overflowed -= this[i].ClientWidth;
                    else
                        overflowed += this[i].ClientWidth;
                }
            }
            else
            {
                // No overflow then no need for the overflow button
                this[0].Visible = false;
            }

            // Must restore the display rectangle to the same size as when it entered
            context.DisplayRectangle = ClientRectangle;
        }
        #endregion

        #region Paint
        /// <summary>
        /// Perform rendering before child elements are rendered.
        /// </summary>
        /// <param name="context">Rendering context.</param>
        public override void RenderBefore(RenderContext context)
        {
            foreach (ViewBase child in this)
            {
                // Only interested in updating view buttons
                if (child is ViewDrawButton)
                {
                    // Cast to correct type
                    ViewDrawButton crumbButton = child as ViewDrawButton;

                    // That are associated with crumb items
                    KiwiBreadCrumbItem crumbItem;
                    if (_buttonToCrumb.TryGetValue(crumbButton, out crumbItem))
                    {
                        // If the button is pressed then point button downwards, 
                        // otherwise we point in the direction the buttons layed out.
                        if (crumbButton.ElementState == PaletteState.Pressed)
                            crumbButton.DropDownOrientation = VisualOrientation.Top;
                        else
                            crumbButton.DropDownOrientation = VisualOrientation.Left;
                    }
                }
            }

            base.RenderBefore(context);
        }

        /// <summary>
        /// Perform a render of the elements.
        /// </summary>
        /// <param name="context">Rendering context.</param>
        public override void Render(RenderContext context)
        {
            Debug.Assert(context != null);

            // Perform rendering before any children
            RenderBefore(context);

            // We need to update the redirector for drawing each crumb
            PaletteRedirectBreadCrumb redirect = _kiwiBreadCrumb.GetRedirector() as PaletteRedirectBreadCrumb;

            bool first = true;
            for (int i = 0; i < Count; i++)
            {
                if (this[i].Visible)
                {
                    // Do not show the left border on the first crumb
                    if (first)
                    {
                        redirect.Left = true;
                        first = false;
                    }
                    else
                        redirect.Left = false;

                    this[i].Render(context);
                }
            }

            // Perform rendering after that of children
            RenderAfter(context);
        }
        #endregion

        #region IContentValues
        /// <summary>
        /// Gets the content image.
        /// </summary>
        /// <param name="state">The state for which the image is needed.</param>
        /// <returns>Image value.</returns>
        public Image GetImage(PaletteState state)
        {
            return _kiwiBreadCrumb.GetRedirector().GetButtonSpecImage(PaletteButtonSpecStyle.ArrowLeft, state);
        }

        /// <summary>
        /// Gets the image color that should be transparent.
        /// </summary>
        /// <param name="state">The state for which the image is needed.</param>
        /// <returns>Color value.</returns>
        public Color GetImageTransparentColor(PaletteState state)
        {
            return _kiwiBreadCrumb.GetRedirector().GetButtonSpecImageTransparentColor(PaletteButtonSpecStyle.ArrowLeft);
        }

        /// <summary>
        /// Gets the content short text.
        /// </summary>
        /// <returns>String value.</returns>
        public string GetShortText()
        {
            return string.Empty;
        }

        /// <summary>
        /// Gets the content long text.
        /// </summary>
        /// <returns>String value.</returns>
        public string GetLongText()
        {
            return string.Empty;
        }
        #endregion

        #region Private
        private void CreateOverflowButton()
        {
            // Create a button used when we overflow the available area
            _overflowButton = new ViewDrawButton(_kiwiBreadCrumb.StateDisabled.BreadCrumb,
                                                 _kiwiBreadCrumb.StateNormal.BreadCrumb,
                                                 _kiwiBreadCrumb.StateTracking.BreadCrumb,
                                                 _kiwiBreadCrumb.StatePressed.BreadCrumb,
                                                 _kiwiBreadCrumb.GetStateCommon(),
                                                 this, VisualOrientation.Top, false);

            _overflowButton.Splitter = true;
            _overflowButton.TestForFocusCues = true;
            _overflowButton.DropDownPalette = _kiwiBreadCrumb.GetRedirector();

            // Create controller for operating the button
            ButtonController crumbButtonController = new ButtonController(_overflowButton, _needPaintDelegate);
            crumbButtonController.Tag = this;
            crumbButtonController.BecomesFixed = true;
            crumbButtonController.Click += new MouseEventHandler(OnOverflowButtonClick);
            _overflowButton.MouseController = crumbButtonController;
        }

        private void SyncBreadCrumbs()
        {
            // Remove all existing children
            Clear();

            // Walk up the bread crumb trail
            KiwiBreadCrumbItem item = _kiwiBreadCrumb.SelectedItem;
            while (item != null)
            {
                ViewDrawButton crumbButton;

                // If we do not have a button to represent this crumb...
                if (!_crumbToButton.TryGetValue(item, out crumbButton))
                {
                    // Setup the button for drawing as a drop down button if required
                    crumbButton = new ViewDrawButton(_kiwiBreadCrumb.StateDisabled.BreadCrumb,
                                                     _kiwiBreadCrumb.StateNormal.BreadCrumb,
                                                     _kiwiBreadCrumb.StateTracking.BreadCrumb,
                                                     _kiwiBreadCrumb.StatePressed.BreadCrumb,
                                                     _kiwiBreadCrumb.GetStateCommon(),
                                                     item, VisualOrientation.Top, false);

                    crumbButton.Splitter = true;
                    crumbButton.TestForFocusCues = true;
                    crumbButton.DropDownPalette = _kiwiBreadCrumb.GetRedirector();

                    // Create controller for operating the button
                    ButtonController crumbButtonController = new ButtonController(crumbButton, _needPaintDelegate);
                    crumbButtonController.Tag = item;
                    crumbButtonController.BecomesFixed = true;
                    crumbButtonController.Click += new MouseEventHandler(OnButtonClick);
                    crumbButton.MouseController = crumbButtonController;

                    // Add to cache for future use
                    _crumbToButton.Add(item, crumbButton);
                    _buttonToCrumb.Add(crumbButton, item);
                }

                // Only show a drop down button if we have some children to choose from
                crumbButton.DropDown = _kiwiBreadCrumb.DropDownNavigation && (item.Items.Count > 0);

                // Add crumb to end of child collection
                Insert(0, crumbButton);

                // Move up another level
                item = item.Parent;
            }

            // Always add the overflow to the first item
            Insert(0, _overflowButton);
        }

        private void OnButtonClick(object sender, MouseEventArgs e)
        {
            // Only allow a single context menu at a time
            if (!_showingContextMenu)
            {
                // Get access to the controller, view and crumb item
                ViewDrawButton viewButton = sender as ViewDrawButton;
                ButtonController controller = viewButton.MouseController as ButtonController;
                KiwiBreadCrumbItem breadCrumb = controller.Tag as KiwiBreadCrumbItem;

                // Do we need to show a drop down menu?
                if (viewButton.DropDown && viewButton.SplitRectangle.Contains(e.Location))
                {
                    // Create a context menu with a items collection
                    KiwiContextMenu kcm = new KiwiContextMenu();

                    // Use same palette settings for context menu as the main control
                    kcm.Palette = _kiwiBreadCrumb.Palette;
                    if (kcm.Palette == null)
                        kcm.PaletteMode = _kiwiBreadCrumb.PaletteMode;

                    // Add an items collection as the root item of the context menu
                    KiwiContextMenuItems items = new KiwiContextMenuItems();
                    kcm.Items.Add(items);

                    // Store lookup between each menu item and the crumb it represents. Prevents
                    // needing to use the menu item tag for remembering association. Leaving the
                    // tag free for use by the user.
                    _menuItemToCrumb = new MenuItemToCrumb();

                    // Create a new menu item to represent each child crumb
                    foreach (KiwiBreadCrumbItem childCrumb in breadCrumb.Items)
                    {
                        KiwiContextMenuItem childMenu = new KiwiContextMenuItem();

                        // Store 1-to-1 association
                        _menuItemToCrumb.Add(childMenu, childCrumb);

                        // Copy across the display details of the child crumb item
                        childMenu.Text = childCrumb.ShortText;
                        childMenu.ExtraText = childCrumb.LongText;
                        childMenu.Image = childCrumb.Image;
                        childMenu.ImageTransparentColor = childCrumb.ImageTransparentColor;
                        childMenu.Click += new EventHandler(OnChildCrumbClick);

                        items.Items.Add(childMenu);
                    }

                    // Allow the user a chance to alter the menu contents or cancel it entirely
                    BreadCrumbMenuArgs bcma = new BreadCrumbMenuArgs(breadCrumb, kcm, KiwiContextMenuPositionH.Left, KiwiContextMenuPositionV.Below);
                    _kiwiBreadCrumb.OnCrumbDropDown(bcma);

                    // Is there still the need to show a menu that is not empty?
                    if (!bcma.Cancel &&
                        (bcma.KiwiContextMenu != null) &&
                        CommonHelper.ValidKiwiContextMenu(bcma.KiwiContextMenu))
                    {
                        // Cache the controller for use in menu close processing, prevents the need to 
                        // store anything in the KiwiContextMenu tag and so free up its use to the user.
                        _pressedButtonController = controller;

                        // Show the context menu so user can select the next item for selection
                        bcma.KiwiContextMenu.Closed += new ToolStripDropDownClosedEventHandler(OnKiwiContextMenuClosed);
                        bcma.KiwiContextMenu.Show(_kiwiBreadCrumb, _kiwiBreadCrumb.RectangleToScreen(new Rectangle(viewButton.SplitRectangle.X - viewButton.SplitRectangle.Width,
                                                                                                                            viewButton.SplitRectangle.Y,
                                                                                                                            viewButton.SplitRectangle.Width * 2,
                                                                                                                            viewButton.SplitRectangle.Height)),
                                                     bcma.PositionH,
                                                     bcma.PositionV);

                        // do not show another context menu whilst this one is visible
                        _showingContextMenu = true;
                    }
                    else
                    {
                        // Button gives a fixed appearance when pressed, without a context menu that is not necessary
                        controller.RemoveFixed();
                    }
                }
                else
                {
                    // Button gives a fixed appearance when pressed, without a context menu that is not necessary
                    controller.RemoveFixed();

                    // Clicking item makes it become the selected crumb
                    _kiwiBreadCrumb.SelectedItem = breadCrumb;
                }
            }
        }

        private void OnKiwiContextMenuClosed(object sender, EventArgs e)
        {
            // Cast to correct type
            KiwiContextMenu kcm = (KiwiContextMenu)sender;

            // Unhook from context menu and dipose of it, we only use each menu instance once
            kcm.Closed -= new ToolStripDropDownClosedEventHandler(OnKiwiContextMenuClosed);
            kcm.Dispose();

            // Remove the fixed appearnce of the view button
            _pressedButtonController.RemoveFixed();
            _pressedButtonController = null;

            // No longer showing context menu, so safe to show another one
            _showingContextMenu = false;
        }

        private void OnChildCrumbClick(object sender, EventArgs e)
        {
            // Make the clicked child crumb the newly selected item
            KiwiContextMenuItem childItem = sender as KiwiContextMenuItem;
            _kiwiBreadCrumb.SelectedItem = _menuItemToCrumb[childItem];
        }

        private void OnOverflowButtonClick(object sender, MouseEventArgs e)
        {
            // Only allow a single context menu at a time
            if (!_showingContextMenu)
            {
                // Get access to the controller, view and crumb item
                ViewDrawButton viewButton = sender as ViewDrawButton;
                ButtonController controller = viewButton.MouseController as ButtonController;

                // Create a context menu with a items collection
                KiwiContextMenu kcm = new KiwiContextMenu();

                // Use same palette settings for context menu as the main control
                kcm.Palette = _kiwiBreadCrumb.Palette;
                if (kcm.Palette == null)
                    kcm.PaletteMode = _kiwiBreadCrumb.PaletteMode;

                // Add an items collection as the root item of the context menu
                KiwiContextMenuItems items = new KiwiContextMenuItems();
                kcm.Items.Add(items);

                // Store lookup between each menu item and the crumb it represents. Prevents
                // needing to use the menu item tag for remembering association. Leaving the
                // tag free for use by the user.
                _menuItemToCrumb = new MenuItemToCrumb();

                // Create a new menu item to represent each of the invisible crumbs not children of the root
                // (item 0=overflow button, 1=root; 2=child of root, so we start at index 3)
                for (int i = 3; i < Count; i++)
                {
                    if (!this[i].Visible)
                    {
                        KiwiBreadCrumbItem childCrumb = _buttonToCrumb[(ViewDrawButton)this[i]];
                        KiwiContextMenuItem childMenu = new KiwiContextMenuItem();

                        // Store 1-to-1 association
                        _menuItemToCrumb.Add(childMenu, childCrumb);

                        // Copy across the display details of the child crumb item
                        childMenu.Text = childCrumb.ShortText;
                        childMenu.ExtraText = childCrumb.LongText;
                        childMenu.Image = childCrumb.Image;
                        childMenu.ImageTransparentColor = childCrumb.ImageTransparentColor;
                        childMenu.Click += new EventHandler(OnChildCrumbClick);

                        items.Items.Add(childMenu);
                    }
                }

                // Create a new menu item to represent each of the roots children
                bool firstRoot = true;
                foreach (KiwiBreadCrumbItem childCrumb in _kiwiBreadCrumb.RootItem.Items)
                {
                    // The first time we add an entry
                    if (firstRoot)
                    {
                        // Add a separator if entries already exist
                        if (items.Items.Count > 0)
                            items.Items.Add(new KiwiContextMenuSeparator());

                        firstRoot = false;
                    }

                    KiwiContextMenuItem childMenu = new KiwiContextMenuItem();

                    // Store 1-to-1 association
                    _menuItemToCrumb.Add(childMenu, childCrumb);

                    // Copy across the display details of the child crumb item
                    childMenu.Text = childCrumb.ShortText;
                    childMenu.ExtraText = childCrumb.LongText;
                    childMenu.Image = childCrumb.Image;
                    childMenu.ImageTransparentColor = childCrumb.ImageTransparentColor;
                    childMenu.Click += new EventHandler(OnChildCrumbClick);

                    items.Items.Add(childMenu);
                }

                // Allow the user a chance to alter the menu contents or cancel it entirely
                ContextPositionMenuArgs cpma = new ContextPositionMenuArgs(kcm, KiwiContextMenuPositionH.Left, KiwiContextMenuPositionV.Below);
                _kiwiBreadCrumb.OnOverflowDropDown(cpma);

                // Is there still the need to show a menu that is not empty?
                if (!cpma.Cancel &&
                    (cpma.KiwiContextMenu != null) &&
                    CommonHelper.ValidKiwiContextMenu(cpma.KiwiContextMenu))
                {
                    // Cache the controller for use in menu close processing, prevents the need to 
                    // store anything in the KiwiContextMenu tag and so free up its use to the user.
                    _pressedButtonController = controller;

                    // Show the context menu so user can select the next item for selection
                    cpma.KiwiContextMenu.Closed += new ToolStripDropDownClosedEventHandler(OnKiwiContextMenuClosed);
                    cpma.KiwiContextMenu.Show(_kiwiBreadCrumb, _kiwiBreadCrumb.RectangleToScreen(new Rectangle(viewButton.ClientRectangle.X,
                                                                                                                        viewButton.ClientRectangle.Y,
                                                                                                                        viewButton.ClientRectangle.Width * 2,
                                                                                                                        viewButton.ClientRectangle.Height)),
                                                 cpma.PositionH,
                                                 cpma.PositionV);

                    // do not show another context menu whilst this one is visible
                    _showingContextMenu = true;
                }
                else
                {
                    // Button gives a fixed appearance when pressed, without a context menu that is not necessary
                    controller.RemoveFixed();

                    // Clicking item makes it become the selected crumb
                    _kiwiBreadCrumb.SelectedItem = _kiwiBreadCrumb.RootItem;
                }
            }
        }
        #endregion
    }
}
