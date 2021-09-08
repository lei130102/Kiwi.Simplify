using Kiwi.ComponentFactory.Navigator;
using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Per_Tab_Buttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addContext_Click(this, EventArgs.Empty);
            kiwiNavigator.SelectedIndex = 1;
            addArrow_Click(this, EventArgs.Empty);
            kiwiNavigator.SelectedIndex = 2;
            addText_Click(this, EventArgs.Empty);
            kiwiNavigator.SelectedIndex = 0;

            UpdateControlsFromNavigator();
        }

        private void UpdateControlsFromNavigator()
        {
            // Update Mode
            radioModeTabs.Checked = (kiwiNavigator.NavigatorMode == NavigatorMode.BarTabGroup);
            radioModeRibbonTabs.Checked = (kiwiNavigator.NavigatorMode == NavigatorMode.BarRibbonTabGroup);
            radioModesCheckButton.Checked = (kiwiNavigator.NavigatorMode == NavigatorMode.BarCheckButtonGroupOutside);
            radioModesStack.Checked = (kiwiNavigator.NavigatorMode == NavigatorMode.StackCheckButtonGroup);
            radioModesOutlook.Checked = (kiwiNavigator.NavigatorMode == NavigatorMode.OutlookFull);

            // Set mode specific properties
            switch (kiwiNavigator.NavigatorMode)
            {
                case NavigatorMode.BarRibbonTabGroup:
                case NavigatorMode.BarRibbonTabOnly:
                    kiwiNavigator.PageBackStyle = PaletteBackStyle.ControlRibbon;
                    kiwiNavigator.Group.GroupBackStyle = PaletteBackStyle.ControlRibbon;
                    kiwiNavigator.Group.GroupBorderStyle = PaletteBorderStyle.ControlRibbon;
                    break;
                default:
                    kiwiNavigator.PageBackStyle = PaletteBackStyle.ControlClient;
                    kiwiNavigator.Group.GroupBackStyle = PaletteBackStyle.ControlClient;
                    kiwiNavigator.Group.GroupBorderStyle = PaletteBorderStyle.ControlClient;
                    break;
            }
        }

        private void radioModeTabs_CheckedChanged(object sender, EventArgs e)
        {
            if (radioModeTabs.Checked)
            {
                kiwiNavigator.NavigatorMode = NavigatorMode.BarTabGroup;
                UpdateControlsFromNavigator();
            }
        }

        private void radioModeRibbonTabs_CheckedChanged(object sender, EventArgs e)
        {
            if (radioModeRibbonTabs.Checked)
            {
                kiwiNavigator.NavigatorMode = NavigatorMode.BarRibbonTabGroup;
                UpdateControlsFromNavigator();
            }
        }

        private void radioModesCheckButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioModesCheckButton.Checked)
            {
                kiwiNavigator.NavigatorMode = NavigatorMode.BarCheckButtonGroupOutside;
                UpdateControlsFromNavigator();
            }
        }

        private void radioModesStack_CheckedChanged(object sender, EventArgs e)
        {
            if (radioModesStack.Checked)
            {
                kiwiNavigator.NavigatorMode = NavigatorMode.StackCheckButtonGroup;
                UpdateControlsFromNavigator();
            }
        }

        private void radioModesOutlook_CheckedChanged(object sender, EventArgs e)
        {
            if (radioModesOutlook.Checked)
            {
                kiwiNavigator.NavigatorMode = NavigatorMode.OutlookFull;
                UpdateControlsFromNavigator();
            }
        }

        private void addContext_Click(object sender, EventArgs e)
        {
            if (kiwiNavigator.SelectedPage != null)
            {
                ButtonSpecAny bsa = new ButtonSpecAny();
                bsa.Type = PaletteButtonSpecStyle.Context;
                bsa.Style = PaletteButtonStyle.Standalone;
                bsa.KiwiContextMenu = kiwiContextMenu;
                bsa.Tag = kiwiNavigator.SelectedPage;
                kiwiNavigator.SelectedPage.ButtonSpecs.Add(bsa);
            }
        }

        private void addText_Click(object sender, EventArgs e)
        {
            if (kiwiNavigator.SelectedPage != null)
            {
                ButtonSpecAny bsa = new ButtonSpecAny();
                bsa.Style = PaletteButtonStyle.Standalone;
                bsa.Text = DateTime.Now.Millisecond.ToString();
                bsa.Tag = kiwiNavigator.SelectedPage;
                kiwiNavigator.SelectedPage.ButtonSpecs.Add(bsa);
            }
        }

        private void addArrow_Click(object sender, EventArgs e)
        {
            if (kiwiNavigator.SelectedPage != null)
            {
                ButtonSpecAny bsa = new ButtonSpecAny();
                bsa.Style = PaletteButtonStyle.Alternate;
                bsa.Type = PaletteButtonSpecStyle.ArrowRight;
                bsa.Tag = kiwiNavigator.SelectedPage;
                kiwiNavigator.SelectedPage.ButtonSpecs.Add(bsa);
            }
        }

        private void clearButtons_Click(object sender, EventArgs e)
        {
            if (kiwiNavigator.SelectedPage != null)
                kiwiNavigator.SelectedPage.ButtonSpecs.Clear();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
