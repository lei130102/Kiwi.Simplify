using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Navigator
{
    internal partial class KiwiPageFormEditFlags : Form
    {
        #region Instance Fields
        private KiwiPage _page;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiPageFormEditFlags class.
        /// </summary>
        public KiwiPageFormEditFlags()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialize a new instance of the KiwiPageFormEditFlags class.
        /// </summary>
        /// <param name="page">Reference to page to display flags for.</param>
        public KiwiPageFormEditFlags(KiwiPage page)
        {
            _page = page;
            InitializeComponent();
        }
        #endregion

        #region Implementation
        private void OnLoad(object sender, EventArgs e)
        {
            checkBoxPageInOverflowBarForOutlookMode.Checked = _page.AreFlagsSet(KiwiPageFlags.PageInOverflowBarForOutlookMode);
            checkBoxAllowPageDrag.Checked = _page.AreFlagsSet(KiwiPageFlags.AllowPageDrag);
            checkBoxAllowPageReorder.Checked = _page.AreFlagsSet(KiwiPageFlags.AllowPageReorder);
            checkBoxAllowConfigSave.Checked = _page.AreFlagsSet(KiwiPageFlags.AllowConfigSave);
            checkBoxDockingAllowClose.Checked = _page.AreFlagsSet(KiwiPageFlags.DockingAllowClose);
            checkBoxDockingAllowDropDown.Checked = _page.AreFlagsSet(KiwiPageFlags.DockingAllowDropDown);
            checkBoxDockingAllowAutoHidden.Checked = _page.AreFlagsSet(KiwiPageFlags.DockingAllowAutoHidden);
            checkBoxDockingAllowDocked.Checked = _page.AreFlagsSet(KiwiPageFlags.DockingAllowDocked);
            checkBoxDockingAllowFloating.Checked = _page.AreFlagsSet(KiwiPageFlags.DockingAllowFloating);
            checkBoxDockingAllowWorkspace.Checked = _page.AreFlagsSet(KiwiPageFlags.DockingAllowWorkspace);
            checkBoxDockingAllowNavigator.Checked = _page.AreFlagsSet(KiwiPageFlags.DockingAllowNavigator);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (checkBoxPageInOverflowBarForOutlookMode.Checked)
                _page.SetFlags(KiwiPageFlags.PageInOverflowBarForOutlookMode);
            else
                _page.ClearFlags(KiwiPageFlags.PageInOverflowBarForOutlookMode);

            if (checkBoxAllowPageDrag.Checked)
                _page.SetFlags(KiwiPageFlags.AllowPageDrag);
            else
                _page.ClearFlags(KiwiPageFlags.AllowPageDrag);

            if (checkBoxAllowPageReorder.Checked)
                _page.SetFlags(KiwiPageFlags.AllowPageReorder);
            else
                _page.ClearFlags(KiwiPageFlags.AllowPageReorder);

            if (checkBoxAllowConfigSave.Checked)
                _page.SetFlags(KiwiPageFlags.AllowConfigSave);
            else
                _page.ClearFlags(KiwiPageFlags.AllowConfigSave);

            if (checkBoxDockingAllowClose.Checked)
                _page.SetFlags(KiwiPageFlags.DockingAllowClose);
            else
                _page.ClearFlags(KiwiPageFlags.DockingAllowClose);

            if (checkBoxDockingAllowDropDown.Checked)
                _page.SetFlags(KiwiPageFlags.DockingAllowDropDown);
            else
                _page.ClearFlags(KiwiPageFlags.DockingAllowDropDown);

            if (checkBoxDockingAllowAutoHidden.Checked)
                _page.SetFlags(KiwiPageFlags.DockingAllowAutoHidden);
            else
                _page.ClearFlags(KiwiPageFlags.DockingAllowAutoHidden);

            if (checkBoxDockingAllowDocked.Checked)
                _page.SetFlags(KiwiPageFlags.DockingAllowDocked);
            else
                _page.ClearFlags(KiwiPageFlags.DockingAllowDocked);

            if (checkBoxDockingAllowFloating.Checked)
                _page.SetFlags(KiwiPageFlags.DockingAllowFloating);
            else
                _page.ClearFlags(KiwiPageFlags.DockingAllowFloating);

            if (checkBoxDockingAllowWorkspace.Checked)
                _page.SetFlags(KiwiPageFlags.DockingAllowWorkspace);
            else
                _page.ClearFlags(KiwiPageFlags.DockingAllowWorkspace);

            if (checkBoxDockingAllowNavigator.Checked)
                _page.SetFlags(KiwiPageFlags.DockingAllowNavigator);
            else
                _page.ClearFlags(KiwiPageFlags.DockingAllowNavigator);
        }
        #endregion
    }
}
