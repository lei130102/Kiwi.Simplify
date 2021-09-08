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

namespace Singleline___Multiline
{
    public partial class Form1 : Form
    {
        int _newPage = 7;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateControlsFromNavigator();
        }

        private void UpdateControlsFromNavigator()
        {
            // We only show the next/prev buttons when in singleline/expandline modes
            if ((kiwiNavigator1.Bar.BarMultiline == BarMultiline.Singleline) ||
                (kiwiNavigator1.Bar.BarMultiline == BarMultiline.Expandline))
                kiwiNavigator1.Button.ButtonDisplayLogic = ButtonDisplayLogic.NextPrevious;
            else
                kiwiNavigator1.Button.ButtonDisplayLogic = ButtonDisplayLogic.Context;

            // Update BarMultiline setting
            radioSingleline.Checked = (kiwiNavigator1.Bar.BarMultiline == BarMultiline.Singleline);
            radioMultiline.Checked = (kiwiNavigator1.Bar.BarMultiline == BarMultiline.Multiline);
            radioExactline.Checked = (kiwiNavigator1.Bar.BarMultiline == BarMultiline.Exactline);
            radioShrinkline.Checked = (kiwiNavigator1.Bar.BarMultiline == BarMultiline.Shrinkline);
            radioExpandline.Checked = (kiwiNavigator1.Bar.BarMultiline == BarMultiline.Expandline);

            // Update Mode
            radioModeTabs.Checked = (kiwiNavigator1.NavigatorMode == NavigatorMode.BarTabGroup);
            radioModeRibbonTabs.Checked = (kiwiNavigator1.NavigatorMode == NavigatorMode.BarRibbonTabGroup);
            radioModesCheckButton.Checked = (kiwiNavigator1.NavigatorMode == NavigatorMode.BarCheckButtonGroupOutside);

            // Update Bar Orientation
            radioOrientationTop.Checked = (kiwiNavigator1.Bar.BarOrientation == VisualOrientation.Top);
            radioOrientationBottom.Checked = (kiwiNavigator1.Bar.BarOrientation == VisualOrientation.Bottom);
            radioOrientationLeft.Checked = (kiwiNavigator1.Bar.BarOrientation == VisualOrientation.Left);
            radioOrientationRight.Checked = (kiwiNavigator1.Bar.BarOrientation == VisualOrientation.Right);

            // Update Item Orientation
            radioItemAuto.Checked = (kiwiNavigator1.Bar.ItemOrientation == ButtonOrientation.Auto);
            radioItemFixedTop.Checked = (kiwiNavigator1.Bar.ItemOrientation == ButtonOrientation.FixedTop);
            radioItemFixedBottom.Checked = (kiwiNavigator1.Bar.ItemOrientation == ButtonOrientation.FixedBottom);
            radioItemFixedLeft.Checked = (kiwiNavigator1.Bar.ItemOrientation == ButtonOrientation.FixedLeft);
            radioItemFixedRight.Checked = (kiwiNavigator1.Bar.ItemOrientation == ButtonOrientation.FixedRight);

            // Update Item Alignment
            radioItemNear.Checked = (kiwiNavigator1.Bar.ItemAlignment == RelativePositionAlign.Near);
            radioItemCenter.Checked = (kiwiNavigator1.Bar.ItemAlignment == RelativePositionAlign.Center);
            radioItemFar.Checked = (kiwiNavigator1.Bar.ItemAlignment == RelativePositionAlign.Far);

            // Set mode specific properties
            switch (kiwiNavigator1.NavigatorMode)
            {
                case NavigatorMode.BarRibbonTabGroup:
                case NavigatorMode.BarRibbonTabOnly:
                    kiwiNavigator1.PageBackStyle = PaletteBackStyle.ControlRibbon;
                    kiwiNavigator1.Group.GroupBackStyle = PaletteBackStyle.ControlRibbon;
                    kiwiNavigator1.Group.GroupBorderStyle = PaletteBorderStyle.ControlRibbon;
                    break;
                default:
                    kiwiNavigator1.PageBackStyle = PaletteBackStyle.ControlClient;
                    kiwiNavigator1.Group.GroupBackStyle = PaletteBackStyle.ControlClient;
                    kiwiNavigator1.Group.GroupBorderStyle = PaletteBorderStyle.ControlClient;
                    break;
            }
        }

        private void radioSingleline_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSingleline.Checked)
            {
                kiwiNavigator1.Bar.BarMultiline = BarMultiline.Singleline;
                UpdateControlsFromNavigator();
            }
        }

        private void radioMultiline_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMultiline.Checked)
            {
                kiwiNavigator1.Bar.BarMultiline = BarMultiline.Multiline;
                UpdateControlsFromNavigator();
            }
        }

        private void radioExactline_CheckedChanged(object sender, EventArgs e)
        {
            if (radioExactline.Checked)
            {
                kiwiNavigator1.Bar.BarMultiline = BarMultiline.Exactline;
                UpdateControlsFromNavigator();
            }
        }

        private void radioShrinkline_CheckedChanged(object sender, EventArgs e)
        {
            if (radioShrinkline.Checked)
            {
                kiwiNavigator1.Bar.BarMultiline = BarMultiline.Shrinkline;
                UpdateControlsFromNavigator();
            }
        }

        private void radioExpandline_CheckedChanged(object sender, EventArgs e)
        {
            if (radioExpandline.Checked)
            {
                kiwiNavigator1.Bar.BarMultiline = BarMultiline.Expandline;
                UpdateControlsFromNavigator();
            }
        }

        private void radioModeTabs_CheckedChanged(object sender, EventArgs e)
        {
            if (radioModeTabs.Checked)
            {
                kiwiNavigator1.NavigatorMode = NavigatorMode.BarTabGroup;
                UpdateControlsFromNavigator();
            }
        }

        private void radioModeRibbonTabs_CheckedChanged(object sender, EventArgs e)
        {
            if (radioModeRibbonTabs.Checked)
            {
                kiwiNavigator1.NavigatorMode = NavigatorMode.BarRibbonTabGroup;
                UpdateControlsFromNavigator();
            }
        }

        private void radioModesCheckButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioModesCheckButton.Checked)
            {
                kiwiNavigator1.NavigatorMode = NavigatorMode.BarCheckButtonGroupOutside;
                UpdateControlsFromNavigator();
            }
        }

        private void radioOrientationTop_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOrientationTop.Checked)
            {
                kiwiNavigator1.Bar.BarOrientation = VisualOrientation.Top;
                UpdateControlsFromNavigator();
            }
        }

        private void radioOrientationBottom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOrientationBottom.Checked)
            {
                kiwiNavigator1.Bar.BarOrientation = VisualOrientation.Bottom;
                UpdateControlsFromNavigator();
            }
        }

        private void radioOrientationLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOrientationLeft.Checked)
            {
                kiwiNavigator1.Bar.BarOrientation = VisualOrientation.Left;
                UpdateControlsFromNavigator();
            }
        }

        private void radioOrientationRight_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOrientationRight.Checked)
            {
                kiwiNavigator1.Bar.BarOrientation = VisualOrientation.Right;
                UpdateControlsFromNavigator();
            }
        }

        private void radioItemAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (radioItemAuto.Checked)
            {
                kiwiNavigator1.Bar.ItemOrientation = ButtonOrientation.Auto;
                UpdateControlsFromNavigator();
            }
        }

        private void radioItemFixedTop_CheckedChanged(object sender, EventArgs e)
        {
            if (radioItemFixedTop.Checked)
            {
                kiwiNavigator1.Bar.ItemOrientation = ButtonOrientation.FixedTop;
                UpdateControlsFromNavigator();
            }
        }

        private void radioItemFixedBottom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioItemFixedBottom.Checked)
            {
                kiwiNavigator1.Bar.ItemOrientation = ButtonOrientation.FixedBottom;
                UpdateControlsFromNavigator();
            }
        }

        private void radioItemFixedLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (radioItemFixedLeft.Checked)
            {
                kiwiNavigator1.Bar.ItemOrientation = ButtonOrientation.FixedLeft;
                UpdateControlsFromNavigator();
            }
        }

        private void radioItemFixedRight_CheckedChanged(object sender, EventArgs e)
        {
            if (radioItemFixedRight.Checked)
            {
                kiwiNavigator1.Bar.ItemOrientation = ButtonOrientation.FixedRight;
                UpdateControlsFromNavigator();
            }
        }

        private void radioItemNear_CheckedChanged(object sender, EventArgs e)
        {
            if (radioItemNear.Checked)
            {
                kiwiNavigator1.Bar.ItemAlignment = RelativePositionAlign.Near;
                UpdateControlsFromNavigator();
            }
        }

        private void radioItemCenter_CheckedChanged(object sender, EventArgs e)
        {
            if (radioItemCenter.Checked)
            {
                kiwiNavigator1.Bar.ItemAlignment = RelativePositionAlign.Center;
                UpdateControlsFromNavigator();
            }
        }

        private void radioItemFar_CheckedChanged(object sender, EventArgs e)
        {
            if (radioItemFar.Checked)
            {
                kiwiNavigator1.Bar.ItemAlignment = RelativePositionAlign.Far;
                UpdateControlsFromNavigator();
            }
        }

        private void buttonAddPage_Click(object sender, EventArgs e)
        {
            KiwiPage newPage = new KiwiPage();
            newPage.Text = "Page " + _newPage.ToString();
            newPage.ImageSmall = imageList1.Images[_newPage++ % imageList1.Images.Count];
            kiwiNavigator1.Pages.Add(newPage);
        }

        private void buttonClearAllPages_Click(object sender, EventArgs e)
        {
            kiwiNavigator1.Pages.Clear();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
