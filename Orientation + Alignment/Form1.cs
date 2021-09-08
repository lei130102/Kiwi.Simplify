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

namespace Orientation___Alignment
{
    public partial class Form1 : Form
    {
        private bool _updating;

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
            _updating = true;

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

            // Update Item Sizing
            radioSizingIndividual.Checked = (kiwiNavigator1.Bar.ItemSizing == BarItemSizing.Individual);
            radioSizingSameHeight.Checked = (kiwiNavigator1.Bar.ItemSizing == BarItemSizing.SameHeight);
            radioSizingSameWidth.Checked = (kiwiNavigator1.Bar.ItemSizing == BarItemSizing.SameWidth);
            radioSizingSameWidthHeight.Checked = (kiwiNavigator1.Bar.ItemSizing == BarItemSizing.SameWidthAndHeight);

            // Update sizing values
            numericUpDownBarFirstItemInset.Value = kiwiNavigator1.Bar.BarFirstItemInset;
            numericUpDownBarMinHeight.Value = kiwiNavigator1.Bar.BarMinimumHeight;
            numericUpDownMinItemSizeX.Value = kiwiNavigator1.Bar.ItemMinimumSize.Width;
            numericUpDownMinItemSizeY.Value = kiwiNavigator1.Bar.ItemMinimumSize.Height;
            numericUpDownMaxItemSizeX.Value = kiwiNavigator1.Bar.ItemMaximumSize.Width;
            numericUpDownMaxItemSizeY.Value = kiwiNavigator1.Bar.ItemMaximumSize.Height;

            // Set mode specific properties
            switch (kiwiNavigator1.NavigatorMode)
            {
                case NavigatorMode.BarRibbonTabGroup:
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

            _updating = false;
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

        private void radioSizingIndividual_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSizingIndividual.Checked)
            {
                kiwiNavigator1.Bar.ItemSizing = BarItemSizing.Individual;
                UpdateControlsFromNavigator();
            }
        }

        private void radioSizingSameHeight_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSizingSameHeight.Checked)
            {
                kiwiNavigator1.Bar.ItemSizing = BarItemSizing.SameHeight;
                UpdateControlsFromNavigator();
            }
        }

        private void radioSizingSameWidth_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSizingSameWidth.Checked)
            {
                kiwiNavigator1.Bar.ItemSizing = BarItemSizing.SameWidth;
                UpdateControlsFromNavigator();
            }
        }

        private void radioSizingSameWidthHeight_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSizingSameWidthHeight.Checked)
            {
                kiwiNavigator1.Bar.ItemSizing = BarItemSizing.SameWidthAndHeight;
                UpdateControlsFromNavigator();
            }
        }

        private void numericUpDownBarMinHeight_ValueChanged(object sender, EventArgs e)
        {
            if (!_updating)
                kiwiNavigator1.Bar.BarMinimumHeight = Convert.ToInt32(numericUpDownBarMinHeight.Value);
        }

        private void numericUpDownMinItemSize(object sender, EventArgs e)
        {
            if (!_updating)
                kiwiNavigator1.Bar.ItemMinimumSize = new Size(Convert.ToInt32(numericUpDownMinItemSizeX.Value),
                                                                 Convert.ToInt32(numericUpDownMinItemSizeY.Value));
        }

        private void numericUpDownMaxItemSize(object sender, EventArgs e)
        {
            if (!_updating)
                kiwiNavigator1.Bar.ItemMaximumSize = new Size(Convert.ToInt32(numericUpDownMaxItemSizeX.Value),
                                                                 Convert.ToInt32(numericUpDownMaxItemSizeY.Value));
        }

        private void numericUpDownBarFirstItemInset_ValueChanged(object sender, EventArgs e)
        {
            if (!_updating)
                kiwiNavigator1.Bar.BarFirstItemInset = Convert.ToInt32(numericUpDownBarFirstItemInset.Value);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
