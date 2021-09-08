using Kiwi.ComponentFactory.Navigator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Docking_Flags
{
    public partial class ContentFlags : UserControl
    {
        private KiwiPage _page;

        public ContentFlags()
            : this(null)
        {
        }

        public ContentFlags(KiwiPage page)
        {
            _page = page;
            InitializeComponent();
        }

        private void kiwiPanel_MouseDown(object sender, MouseEventArgs e)
        {
            // Only interested in left mouse down
            if (e.Button == MouseButtons.Left)
            {
                // If the content does not have the focus then give it focus now
                if (!ContainsFocus)
                    kiwiPanel.SelectNextControl(this, true, true, true, false);
            }
        }

        private void ContentFlags_Load(object sender, EventArgs e)
        {
            // Set checkbox controls to reflect current page flag settings
            cbDocked.Checked = _page.AreFlagsSet(KiwiPageFlags.DockingAllowDocked);
            cbAutoHidden.Checked = _page.AreFlagsSet(KiwiPageFlags.DockingAllowAutoHidden);
            cbFloating.Checked = _page.AreFlagsSet(KiwiPageFlags.DockingAllowFloating);
            cbWorkspace.Checked = _page.AreFlagsSet(KiwiPageFlags.DockingAllowWorkspace);
            cbNavigator.Checked = _page.AreFlagsSet(KiwiPageFlags.DockingAllowNavigator);
            cbDropDown.Checked = _page.AreFlagsSet(KiwiPageFlags.DockingAllowDropDown);
            cbClose.Checked = _page.AreFlagsSet(KiwiPageFlags.DockingAllowClose);
        }

        private void cbDocked_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDocked.Checked)
                _page.SetFlags(KiwiPageFlags.DockingAllowDocked);
            else
                _page.ClearFlags(KiwiPageFlags.DockingAllowDocked);
        }

        private void cbAutoHidden_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAutoHidden.Checked)
                _page.SetFlags(KiwiPageFlags.DockingAllowAutoHidden);
            else
                _page.ClearFlags(KiwiPageFlags.DockingAllowAutoHidden);
        }

        private void cbFloating_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFloating.Checked)
                _page.SetFlags(KiwiPageFlags.DockingAllowFloating);
            else
                _page.ClearFlags(KiwiPageFlags.DockingAllowFloating);
        }

        private void cbWorkspace_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWorkspace.Checked)
                _page.SetFlags(KiwiPageFlags.DockingAllowWorkspace);
            else
                _page.ClearFlags(KiwiPageFlags.DockingAllowWorkspace);
        }

        private void cbNavigator_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNavigator.Checked)
                _page.SetFlags(KiwiPageFlags.DockingAllowNavigator);
            else
                _page.ClearFlags(KiwiPageFlags.DockingAllowNavigator);
        }

        private void cbDropDown_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDropDown.Checked)
                _page.SetFlags(KiwiPageFlags.DockingAllowDropDown);
            else
                _page.ClearFlags(KiwiPageFlags.DockingAllowDropDown);
        }

        private void cbClose_CheckedChanged(object sender, EventArgs e)
        {
            if (cbClose.Checked)
                _page.SetFlags(KiwiPageFlags.DockingAllowClose);
            else
                _page.ClearFlags(KiwiPageFlags.DockingAllowClose);
        }
    }
}
