﻿using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Ribbon
{
    /// <summary>
	/// Process mouse events for a ribbon group combobox.
	/// </summary>
    internal class ComboBoxController : GlobalId,
                                        ISourceController,
                                        IKeyController,
                                        IRibbonKeyTipTarget
    {
        #region Instance Fields
        private KiwiRibbon _ribbon;
        private KiwiRibbonGroupComboBox _comboBox;
        private ViewDrawRibbonGroupComboBox _target;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ComboBoxController class.
        /// </summary>
        /// <param name="ribbon">Reference to owning ribbon instance.</param>
        /// <param name="comboBox">Source definition.</param>
        /// <param name="target">Target view element.</param>
        public ComboBoxController(KiwiRibbon ribbon,
                                  KiwiRibbonGroupComboBox comboBox,
                                  ViewDrawRibbonGroupComboBox target)
        {
            Debug.Assert(ribbon != null);
            Debug.Assert(comboBox != null);
            Debug.Assert(target != null);

            _ribbon = ribbon;
            _comboBox = comboBox;
            _target = target;
        }
        #endregion

        #region Focus Notifications
        /// <summary>
        /// Source control has got the focus.
        /// </summary>
        /// <param name="c">Reference to the source control instance.</param>
        public void GotFocus(Control c)
        {
            if ((_comboBox.LastComboBox != null) &&
                (_comboBox.LastComboBox.ComboBox != null) &&
                (_comboBox.LastComboBox.ComboBox.CanFocus))
            {
                _ribbon.LostFocusLosesKeyboard = false;
                _comboBox.LastComboBox.ComboBox.Focus();
            }
        }

        /// <summary>
        /// Source control has lost the focus.
        /// </summary>
        /// <param name="c">Reference to the source control instance.</param>
        public void LostFocus(Control c)
        {
        }
        #endregion

        #region Key Notifications
        /// <summary>
        /// Key has been pressed down.
        /// </summary>
        /// <param name="c">Reference to the source control instance.</param>
        /// <param name="e">A KeyEventArgs that contains the event data.</param>
        public void KeyDown(Control c, KeyEventArgs e)
        {
            // Get the root control that owns the provided control
            c = _ribbon.GetControllerControl(c);

            if (c is KiwiRibbon)
                KeyDownRibbon(c as KiwiRibbon, e);
            else if (c is VisualPopupGroup)
                KeyDownPopupGroup(c as VisualPopupGroup, e);
            else if (c is VisualPopupMinimized)
                KeyDownPopupMinimized(c as VisualPopupMinimized, e);
        }

        /// <summary>
        /// Key has been pressed.
        /// </summary>
        /// <param name="c">Reference to the source control instance.</param>
        /// <param name="e">A KeyPressEventArgs that contains the event data.</param>
        public void KeyPress(Control c, KeyPressEventArgs e)
        {
        }

        /// <summary>
        /// Key has been released.
        /// </summary>
        /// <param name="c">Reference to the source control instance.</param>
        /// <param name="e">A KeyEventArgs that contains the event data.</param>
        /// <returns>True if capturing input; otherwise false.</returns>
        public bool KeyUp(Control c, KeyEventArgs e)
        {
            return false;
        }
        #endregion

        #region KeyTipSelect
        /// <summary>
        /// Perform actual selection of the item.
        /// </summary>
        /// <param name="ribbon">Reference to owning ribbon instance.</param>
        public void KeyTipSelect(KiwiRibbon ribbon)
        {
            // Can the combobox take the focus
            if (_comboBox.LastComboBox.CanFocus)
            {
                // Prevent the ribbon from killing keyboard mode when it loses the focus,
                // as this causes the tracking windows to be killed and we want them kept
                ribbon.LostFocusLosesKeyboard = false;

                // Prevent the restore of focus when we fill the keyboard mode, as the focus
                // has been placed on the textbox and so focus is allowed to change
                ribbon.IgnoreRestoreFocus = true;

                // Exit the use of keyboard mode
                ribbon.KillKeyboardMode();

                // Push focus to the specified target control
                _comboBox.LastComboBox.ComboBox.Focus();

                // If the textbox is inside a popup window
                if (_comboBox.LastParentControl is VisualPopupGroup)
                {
                    // Ensure that the previous ribbon focus is restored when the popup window is dismissed
                    VisualPopupGroup popupGroup = (VisualPopupGroup)_comboBox.LastParentControl;
                    popupGroup.RestorePreviousFocus = true;
                }
            }
        }
        #endregion

        #region Implementation
        private void KeyDownRibbon(KiwiRibbon ribbon, KeyEventArgs e)
        {
            ViewBase newView = null;

            switch (e.KeyData)
            {
                case Keys.Tab | Keys.Shift:
                case Keys.Left:
                    // Get the previous focus item for the currently selected page
                    newView = ribbon.GroupsArea.ViewGroups.GetPreviousFocusItem(_target);

                    // Got to the actual tab header
                    if (newView == null)
                        newView = ribbon.TabsArea.LayoutTabs.GetViewForRibbonTab(ribbon.SelectedTab);
                    break;
                case Keys.Tab:
                case Keys.Right:
                    // Get the next focus item for the currently selected page
                    newView = ribbon.GroupsArea.ViewGroups.GetNextFocusItem(_target);

                    // Move across to any far defined buttons
                    if (newView == null)
                        newView = ribbon.TabsArea.ButtonSpecManager.GetFirstVisibleViewButton(PaletteRelativeEdgeAlign.Far);

                    // Move across to any inherit defined buttons
                    if (newView == null)
                        newView = ribbon.TabsArea.ButtonSpecManager.GetFirstVisibleViewButton(PaletteRelativeEdgeAlign.Inherit);

                    // Rotate around to application button
                    if (newView == null)
                    {
                        if (ribbon.TabsArea.LayoutAppButton.Visible)
                            newView = ribbon.TabsArea.LayoutAppButton.AppButton;
                        else if (ribbon.TabsArea.LayoutAppTab.Visible)
                            newView = ribbon.TabsArea.LayoutAppTab.AppTab;
                    }
                    break;
            }

            // If we have a new view to focus and it is not ourself...
            if ((newView != null) && (newView != _target))
            {
                // If the new view is a tab then select that tab unless in minimized mode
                if ((newView is ViewDrawRibbonTab) && !ribbon.RealMinimizedMode)
                    ribbon.SelectedTab = ((ViewDrawRibbonTab)newView).RibbonTab;

                // Finally we switch focus to new view
                ribbon.FocusView = newView;
            }
        }

        private void KeyDownPopupGroup(VisualPopupGroup popupGroup, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Tab | Keys.Shift:
                case Keys.Left:
                    popupGroup.SetPreviousFocusItem();
                    break;
                case Keys.Tab:
                case Keys.Right:
                    popupGroup.SetNextFocusItem();
                    break;
            }
        }

        private void KeyDownPopupMinimized(VisualPopupMinimized popupMinimized, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Tab | Keys.Shift:
                case Keys.Left:
                    popupMinimized.SetPreviousFocusItem();
                    break;
                case Keys.Tab:
                case Keys.Right:
                    popupMinimized.SetNextFocusItem();
                    break;
            }
        }
        #endregion
    }
}
