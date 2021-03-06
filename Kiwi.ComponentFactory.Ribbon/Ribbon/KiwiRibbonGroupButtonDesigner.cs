using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Ribbon
{
    internal class KiwiRibbonGroupButtonDesigner : ComponentDesigner
    {
        #region Instance Fields
        private IDesignerHost _designerHost;
        private IComponentChangeService _changeService;
        private KiwiRibbonGroupButton _ribbonButton;
        private DesignerVerbCollection _verbs;
        private DesignerVerb _toggleHelpersVerb;
        private DesignerVerb _moveFirstVerb;
        private DesignerVerb _movePrevVerb;
        private DesignerVerb _moveNextVerb;
        private DesignerVerb _moveLastVerb;
        private DesignerVerb _deleteButtonVerb;
        private ContextMenuStrip _cms;
        private ToolStripMenuItem _toggleHelpersMenu;
        private ToolStripMenuItem _visibleMenu;
        private ToolStripMenuItem _enabledMenu;
        private ToolStripMenuItem _checkedMenu;
        private ToolStripMenuItem _typeMenu;
        private ToolStripMenuItem _typePushMenu;
        private ToolStripMenuItem _typeCheckMenu;
        private ToolStripMenuItem _typeDropDownMenu;
        private ToolStripMenuItem _typeSplitMenu;
        private ToolStripMenuItem _moveFirstMenu;
        private ToolStripMenuItem _movePreviousMenu;
        private ToolStripMenuItem _moveNextMenu;
        private ToolStripMenuItem _moveLastMenu;
        private ToolStripMenuItem _deleteButtonMenu;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiRibbonGroupButtonDesigner class.
        /// </summary>
        public KiwiRibbonGroupButtonDesigner()
        {
        }
        #endregion

        #region Public
        /// <summary>
        /// Initializes the designer with the specified component.
        /// </summary>
        /// <param name="component">The IComponent to associate the designer with.</param>
        public override void Initialize(IComponent component)
        {
            Debug.Assert(component != null);

            // Validate the parameter reference
            if (component == null) throw new ArgumentNullException("component");

            // Let base class do standard stuff
            base.Initialize(component);

            // Cast to correct type
            _ribbonButton = (KiwiRibbonGroupButton)component;
            _ribbonButton.DesignTimeContextMenu += new MouseEventHandler(OnContextMenu);

            // Get access to the services
            _designerHost = (IDesignerHost)GetService(typeof(IDesignerHost));
            _changeService = (IComponentChangeService)GetService(typeof(IComponentChangeService));

            // We need to know when we are being removed/changed
            _changeService.ComponentChanged += new ComponentChangedEventHandler(OnComponentChanged);
        }

        /// <summary>
        /// Gets the design-time verbs supported by the component that is associated with the designer.
        /// </summary>
        public override DesignerVerbCollection Verbs
        {
            get
            {
                UpdateVerbStatus();
                return _verbs;
            }
        }
        #endregion

        #region Protected
        /// <summary>
        /// Releases all resources used by the component. 
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing)
                {
                    // Unhook from events
                    _ribbonButton.DesignTimeContextMenu -= new MouseEventHandler(OnContextMenu);
                    _changeService.ComponentChanged -= new ComponentChangedEventHandler(OnComponentChanged);
                }
            }
            finally
            {
                // Must let base class do standard stuff
                base.Dispose(disposing);
            }
        }
        #endregion

        #region Implementation
        private void UpdateVerbStatus()
        {
            // Create verbs first time around
            if (_verbs == null)
            {
                _verbs = new DesignerVerbCollection();
                _toggleHelpersVerb = new DesignerVerb("Toggle Helpers", new EventHandler(OnToggleHelpers));
                _moveFirstVerb = new DesignerVerb("Move Button First", new EventHandler(OnMoveFirst));
                _movePrevVerb = new DesignerVerb("Move Button Previous", new EventHandler(OnMovePrevious));
                _moveNextVerb = new DesignerVerb("Move Button Next", new EventHandler(OnMoveNext));
                _moveLastVerb = new DesignerVerb("Move Button Last", new EventHandler(OnMoveLast));
                _deleteButtonVerb = new DesignerVerb("Delete Button", new EventHandler(OnDeleteButton));
                _verbs.AddRange(new DesignerVerb[] { _toggleHelpersVerb, _moveFirstVerb, _movePrevVerb,
                                                         _moveNextVerb, _moveLastVerb, _deleteButtonVerb });
            }

            bool moveFirst = false;
            bool movePrev = false;
            bool moveNext = false;
            bool moveLast = false;

            if ((_ribbonButton != null) && (_ribbonButton.Ribbon != null))
            {
                TypedRestrictCollection<KiwiRibbonGroupItem> items = ParentItems;
                moveFirst = (items.IndexOf(_ribbonButton) > 0);
                movePrev = (items.IndexOf(_ribbonButton) > 0);
                moveNext = (items.IndexOf(_ribbonButton) < (items.Count - 1));
                moveLast = (items.IndexOf(_ribbonButton) < (items.Count - 1));
            }

            _moveFirstVerb.Enabled = moveFirst;
            _movePrevVerb.Enabled = movePrev;
            _moveNextVerb.Enabled = moveNext;
            _moveLastVerb.Enabled = moveLast;
        }

        private void OnToggleHelpers(object sender, EventArgs e)
        {
            // Invert the current toggle helper mode
            if ((_ribbonButton != null) && (_ribbonButton.Ribbon != null))
                _ribbonButton.Ribbon.InDesignHelperMode = !_ribbonButton.Ribbon.InDesignHelperMode;
        }

        private void OnMoveFirst(object sender, EventArgs e)
        {
            if ((_ribbonButton != null) && (_ribbonButton.Ribbon != null))
            {
                // Get access to the parent collection of items
                TypedRestrictCollection<KiwiRibbonGroupItem> items = ParentItems;

                // Use a transaction to support undo/redo actions
                DesignerTransaction transaction = _designerHost.CreateTransaction("KiwiRibbonGroupButton MoveFirst");

                try
                {
                    // Get access to the Items property
                    MemberDescriptor propertyItems = TypeDescriptor.GetProperties(_ribbonButton.RibbonContainer)["Items"];

                    RaiseComponentChanging(propertyItems);

                    // Move position of the button
                    items.Remove(_ribbonButton);
                    items.Insert(0, _ribbonButton);
                    UpdateVerbStatus();

                    RaiseComponentChanged(propertyItems, null, null);
                }
                finally
                {
                    // If we managed to create the transaction, then do it
                    if (transaction != null)
                        transaction.Commit();
                }
            }
        }

        private void OnMovePrevious(object sender, EventArgs e)
        {
            if ((_ribbonButton != null) && (_ribbonButton.Ribbon != null))
            {
                // Get access to the parent collection of items
                TypedRestrictCollection<KiwiRibbonGroupItem> items = ParentItems;

                // Use a transaction to support undo/redo actions
                DesignerTransaction transaction = _designerHost.CreateTransaction("KiwiRibbonGroupButton MovePrevious");

                try
                {
                    // Get access to the Items property
                    MemberDescriptor propertyItems = TypeDescriptor.GetProperties(_ribbonButton.RibbonContainer)["Items"];

                    RaiseComponentChanging(propertyItems);

                    // Move position of the triple
                    int index = items.IndexOf(_ribbonButton) - 1;
                    index = Math.Max(index, 0);
                    items.Remove(_ribbonButton);
                    items.Insert(index, _ribbonButton);
                    UpdateVerbStatus();

                    RaiseComponentChanged(propertyItems, null, null);
                }
                finally
                {
                    // If we managed to create the transaction, then do it
                    if (transaction != null)
                        transaction.Commit();
                }
            }
        }

        private void OnMoveNext(object sender, EventArgs e)
        {
            if ((_ribbonButton != null) && (_ribbonButton.Ribbon != null))
            {
                // Get access to the parent collection of items
                TypedRestrictCollection<KiwiRibbonGroupItem> items = ParentItems;

                // Use a transaction to support undo/redo actions
                DesignerTransaction transaction = _designerHost.CreateTransaction("KiwiRibbonGroupButton MoveNext");

                try
                {
                    // Get access to the Items property
                    MemberDescriptor propertyItems = TypeDescriptor.GetProperties(_ribbonButton.RibbonContainer)["Items"];

                    RaiseComponentChanging(propertyItems);

                    // Move position of the triple
                    int index = items.IndexOf(_ribbonButton) + 1;
                    index = Math.Min(index, items.Count - 1);
                    items.Remove(_ribbonButton);
                    items.Insert(index, _ribbonButton);
                    UpdateVerbStatus();

                    RaiseComponentChanged(propertyItems, null, null);
                }
                finally
                {
                    // If we managed to create the transaction, then do it
                    if (transaction != null)
                        transaction.Commit();
                }
            }
        }

        private void OnMoveLast(object sender, EventArgs e)
        {
            if ((_ribbonButton != null) && (_ribbonButton.Ribbon != null))
            {
                // Get access to the parent collection of items
                TypedRestrictCollection<KiwiRibbonGroupItem> items = ParentItems;

                // Use a transaction to support undo/redo actions
                DesignerTransaction transaction = _designerHost.CreateTransaction("KiwiRibbonGroupButton MoveLast");

                try
                {
                    // Get access to the Items property
                    MemberDescriptor propertyItems = TypeDescriptor.GetProperties(_ribbonButton.RibbonContainer)["Items"];

                    RaiseComponentChanging(propertyItems);

                    // Move position of the triple
                    items.Remove(_ribbonButton);
                    items.Insert(items.Count, _ribbonButton);
                    UpdateVerbStatus();

                    RaiseComponentChanged(propertyItems, null, null);
                }
                finally
                {
                    // If we managed to create the transaction, then do it
                    if (transaction != null)
                        transaction.Commit();
                }
            }
        }

        private void OnDeleteButton(object sender, EventArgs e)
        {
            if ((_ribbonButton != null) && (_ribbonButton.Ribbon != null))
            {
                // Get access to the parent collection of items
                TypedRestrictCollection<KiwiRibbonGroupItem> items = ParentItems;

                // Use a transaction to support undo/redo actions
                DesignerTransaction transaction = _designerHost.CreateTransaction("KiwiRibbonGroupButton DeleteButton");

                try
                {
                    // Get access to the Items property
                    MemberDescriptor propertyItems = TypeDescriptor.GetProperties(_ribbonButton.RibbonContainer)["Items"];

                    // Remove the ribbon group from the ribbon tab
                    RaiseComponentChanging(null);
                    RaiseComponentChanging(propertyItems);

                    // Remove the button from the group
                    items.Remove(_ribbonButton);

                    // Get designer to destroy it
                    _designerHost.DestroyComponent(_ribbonButton);

                    RaiseComponentChanged(propertyItems, null, null);
                    RaiseComponentChanged(null, null, null);
                }
                finally
                {
                    // If we managed to create the transaction, then do it
                    if (transaction != null)
                        transaction.Commit();
                }
            }
        }

        private void OnVisible(object sender, EventArgs e)
        {
            if ((_ribbonButton != null) && (_ribbonButton.Ribbon != null))
            {
                _changeService.OnComponentChanged(_ribbonButton, null, _ribbonButton.Visible, !_ribbonButton.Visible);
                _ribbonButton.Visible = !_ribbonButton.Visible;
            }
        }

        private void OnEnabled(object sender, EventArgs e)
        {
            if ((_ribbonButton != null) && (_ribbonButton.Ribbon != null))
            {
                _changeService.OnComponentChanged(_ribbonButton, null, _ribbonButton.Enabled, !_ribbonButton.Enabled);
                _ribbonButton.Enabled = !_ribbonButton.Enabled;
            }
        }

        private void OnChecked(object sender, EventArgs e)
        {
            if ((_ribbonButton != null) && (_ribbonButton.Ribbon != null))
            {
                _changeService.OnComponentChanged(_ribbonButton, null, _ribbonButton.Checked, !_ribbonButton.Checked);
                _ribbonButton.Checked = !_ribbonButton.Checked;
            }
        }

        private void OnTypePush(object sender, EventArgs e)
        {
            if ((_ribbonButton != null) && (_ribbonButton.Ribbon != null))
            {
                _changeService.OnComponentChanged(_ribbonButton, null, _ribbonButton.ButtonType, GroupButtonType.Push);
                _ribbonButton.ButtonType = GroupButtonType.Push;
            }
        }

        private void OnTypeCheck(object sender, EventArgs e)
        {
            if ((_ribbonButton != null) && (_ribbonButton.Ribbon != null))
            {
                _changeService.OnComponentChanged(_ribbonButton, null, _ribbonButton.ButtonType, GroupButtonType.Check);
                _ribbonButton.ButtonType = GroupButtonType.Check;
            }
        }

        private void OnTypeDropDown(object sender, EventArgs e)
        {
            if ((_ribbonButton != null) && (_ribbonButton.Ribbon != null))
            {
                _changeService.OnComponentChanged(_ribbonButton, null, _ribbonButton.ButtonType, GroupButtonType.DropDown);
                _ribbonButton.ButtonType = GroupButtonType.DropDown;
            }
        }

        private void OnTypeSplit(object sender, EventArgs e)
        {
            if ((_ribbonButton != null) && (_ribbonButton.Ribbon != null))
            {
                _changeService.OnComponentChanged(_ribbonButton, null, _ribbonButton.ButtonType, GroupButtonType.Split);
                _ribbonButton.ButtonType = GroupButtonType.Split;
            }
        }

        private void OnComponentChanged(object sender, ComponentChangedEventArgs e)
        {
            UpdateVerbStatus();
        }

        private void OnContextMenu(object sender, MouseEventArgs e)
        {
            if ((_ribbonButton != null) && (_ribbonButton.Ribbon != null))
            {
                // Create the menu strip the first time around
                if (_cms == null)
                {
                    _cms = new ContextMenuStrip();
                    _toggleHelpersMenu = new ToolStripMenuItem("Design Helpers", null, new EventHandler(OnToggleHelpers));
                    _visibleMenu = new ToolStripMenuItem("Visible", null, new EventHandler(OnVisible));
                    _enabledMenu = new ToolStripMenuItem("Enabled", null, new EventHandler(OnEnabled));
                    _checkedMenu = new ToolStripMenuItem("Checked", null, new EventHandler(OnChecked));
                    _typePushMenu = new ToolStripMenuItem("Push", null, new EventHandler(OnTypePush));
                    _typeCheckMenu = new ToolStripMenuItem("Check", null, new EventHandler(OnTypeCheck));
                    _typeDropDownMenu = new ToolStripMenuItem("DropDown", null, new EventHandler(OnTypeDropDown));
                    _typeSplitMenu = new ToolStripMenuItem("Split", null, new EventHandler(OnTypeSplit));
                    _typeMenu = new ToolStripMenuItem("Type");
                    _typeMenu.DropDownItems.AddRange(new ToolStripItem[] { _typePushMenu, _typeCheckMenu, _typeDropDownMenu, _typeSplitMenu });
                    _moveFirstMenu = new ToolStripMenuItem("Move Button First", Properties.Resources.MoveFirst, new EventHandler(OnMoveFirst));
                    _movePreviousMenu = new ToolStripMenuItem("Move Button Previous", Properties.Resources.MovePrevious, new EventHandler(OnMovePrevious));
                    _moveNextMenu = new ToolStripMenuItem("Move Button Next", Properties.Resources.MoveNext, new EventHandler(OnMoveNext));
                    _moveLastMenu = new ToolStripMenuItem("Move Button Last", Properties.Resources.MoveLast, new EventHandler(OnMoveLast));
                    _deleteButtonMenu = new ToolStripMenuItem("Delete Button", Properties.Resources.delete2, new EventHandler(OnDeleteButton));
                    _cms.Items.AddRange(new ToolStripItem[] { _toggleHelpersMenu, new ToolStripSeparator(),
                                                              _visibleMenu, _enabledMenu, _checkedMenu, _typeMenu, new ToolStripSeparator(),
                                                              _moveFirstMenu, _movePreviousMenu, _moveNextMenu, _moveLastMenu, new ToolStripSeparator(),
                                                              _deleteButtonMenu });
                }

                // Update verbs to work out correct enable states
                UpdateVerbStatus();

                // Update menu items state from versb
                _toggleHelpersMenu.Checked = _ribbonButton.Ribbon.InDesignHelperMode;
                _visibleMenu.Checked = _ribbonButton.Visible;
                _enabledMenu.Checked = _ribbonButton.Enabled;
                _checkedMenu.Checked = _ribbonButton.Checked;
                _typePushMenu.Checked = (_ribbonButton.ButtonType == GroupButtonType.Push);
                _typeCheckMenu.Checked = (_ribbonButton.ButtonType == GroupButtonType.Check);
                _typeDropDownMenu.Checked = (_ribbonButton.ButtonType == GroupButtonType.DropDown);
                _typeSplitMenu.Checked = (_ribbonButton.ButtonType == GroupButtonType.Split);
                _moveFirstMenu.Enabled = _moveFirstVerb.Enabled;
                _movePreviousMenu.Enabled = _movePrevVerb.Enabled;
                _moveNextMenu.Enabled = _moveNextVerb.Enabled;
                _moveLastMenu.Enabled = _moveLastVerb.Enabled;

                // Show the context menu
                if (CommonHelper.ValidContextMenuStrip(_cms))
                {
                    Point screenPt = _ribbonButton.Ribbon.ViewRectangleToPoint(_ribbonButton.ButtonView);
                    VisualPopupManager.Singleton.ShowContextMenuStrip(_cms, screenPt);
                }
            }
        }

        private TypedRestrictCollection<KiwiRibbonGroupItem> ParentItems
        {
            get
            {
                if (_ribbonButton.RibbonContainer is KiwiRibbonGroupTriple)
                {
                    KiwiRibbonGroupTriple triple = (KiwiRibbonGroupTriple)_ribbonButton.RibbonContainer;
                    return triple.Items;
                }
                else if (_ribbonButton.RibbonContainer is KiwiRibbonGroupLines)
                {
                    KiwiRibbonGroupLines lines = (KiwiRibbonGroupLines)_ribbonButton.RibbonContainer;
                    return lines.Items;
                }
                else
                {
                    // Should never happen!
                    Debug.Assert(false);
                    return null;
                }
            }
        }
        #endregion
    }
}
