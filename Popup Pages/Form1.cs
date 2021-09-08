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

namespace Popup_Pages
{
    public partial class Form1 : Form
    {
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
            // Update mode control
            radioBarTabOnly.Checked = (kiwiNavigator.NavigatorMode == NavigatorMode.BarTabOnly);
            radioBarRibbonTabOnly.Checked = (kiwiNavigator.NavigatorMode == NavigatorMode.BarRibbonTabOnly);
            radioBarCheckButtonGroupOnly.Checked = (kiwiNavigator.NavigatorMode == NavigatorMode.BarCheckButtonGroupOnly);
            radioBarCheckButtonOnly.Checked = (kiwiNavigator.NavigatorMode == NavigatorMode.BarCheckButtonOnly);
            radioHeaderBarCheckButtonOnly.Checked = (kiwiNavigator.NavigatorMode == NavigatorMode.HeaderBarCheckButtonOnly);
            radioOutlookMini.Checked = (kiwiNavigator.NavigatorMode == NavigatorMode.OutlookMini);

            // Update bar orientation controls
            radioOrientationTop.Checked = (kiwiNavigator.Bar.BarOrientation == VisualOrientation.Top);
            radioOrientationBottom.Checked = (kiwiNavigator.Bar.BarOrientation == VisualOrientation.Bottom);
            radioOrientationLeft.Checked = (kiwiNavigator.Bar.BarOrientation == VisualOrientation.Left);
            radioOrientationRight.Checked = (kiwiNavigator.Bar.BarOrientation == VisualOrientation.Right);

            // Update popup page controls
            numericBorder.Value = kiwiNavigator.PopupPages.Border;
            numericGap.Value = kiwiNavigator.PopupPages.Gap;
            comboBoxElement.Text = kiwiNavigator.PopupPages.Element.ToString();
            comboBoxPosition.Text = kiwiNavigator.PopupPages.Position.ToString();
        }

        private void radioBarTabOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBarTabOnly.Checked)
            {
                kiwiNavigator.NavigatorMode = NavigatorMode.BarTabOnly;
                UpdateControlsFromNavigator();
            }
        }

        private void radioBarRibbonTabOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBarRibbonTabOnly.Checked)
            {
                kiwiNavigator.NavigatorMode = NavigatorMode.BarRibbonTabOnly;
                UpdateControlsFromNavigator();
            }
        }

        private void radioBarCheckButtonGroupOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBarCheckButtonGroupOnly.Checked)
            {
                kiwiNavigator.NavigatorMode = NavigatorMode.BarCheckButtonGroupOnly;
                UpdateControlsFromNavigator();
            }
        }

        private void radioBarCheckButtonOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBarCheckButtonOnly.Checked)
            {
                kiwiNavigator.NavigatorMode = NavigatorMode.BarCheckButtonOnly;
                UpdateControlsFromNavigator();
            }
        }

        private void radioHeaderBarCheckButtonOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (radioHeaderBarCheckButtonOnly.Checked)
            {
                kiwiNavigator.NavigatorMode = NavigatorMode.HeaderBarCheckButtonOnly;
                UpdateControlsFromNavigator();
            }
        }

        private void radioOutlookMini_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOutlookMini.Checked)
            {
                kiwiNavigator.NavigatorMode = NavigatorMode.OutlookMini;
                UpdateControlsFromNavigator();
            }
        }

        private void radioOrientationTop_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOrientationTop.Checked)
            {
                kiwiNavigator.Bar.BarOrientation = VisualOrientation.Top;
                kiwiNavigator.Header.HeaderPositionBar = VisualOrientation.Top;
                kiwiNavigator.Dock = DockStyle.Top;
                UpdateControlsFromNavigator();
            }
        }

        private void radioOrientationBottom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOrientationBottom.Checked)
            {
                kiwiNavigator.Bar.BarOrientation = VisualOrientation.Bottom;
                kiwiNavigator.Header.HeaderPositionBar = VisualOrientation.Bottom;
                kiwiNavigator.Dock = DockStyle.Bottom;
                UpdateControlsFromNavigator();
            }
        }

        private void radioOrientationLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOrientationLeft.Checked)
            {
                kiwiNavigator.Bar.BarOrientation = VisualOrientation.Left;
                kiwiNavigator.Header.HeaderPositionBar = VisualOrientation.Left;
                kiwiNavigator.Dock = DockStyle.Left;
                UpdateControlsFromNavigator();
            }
        }

        private void radioOrientationRight_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOrientationRight.Checked)
            {
                kiwiNavigator.Bar.BarOrientation = VisualOrientation.Right;
                kiwiNavigator.Header.HeaderPositionBar = VisualOrientation.Right;
                kiwiNavigator.Dock = DockStyle.Right;
                UpdateControlsFromNavigator();
            }
        }

        private void numericBorder_ValueChanged(object sender, EventArgs e)
        {
            kiwiNavigator.PopupPages.Border = Convert.ToInt32(numericBorder.Value);
            UpdateControlsFromNavigator();
        }

        private void numericGap_ValueChanged(object sender, EventArgs e)
        {
            kiwiNavigator.PopupPages.Gap = Convert.ToInt32(numericGap.Value);
            UpdateControlsFromNavigator();
        }

        private void comboBoxElement_SelectedIndexChanged(object sender, EventArgs e)
        {
            kiwiNavigator.PopupPages.Element = (PopupPageElement)Enum.Parse(typeof(PopupPageElement), comboBoxElement.Text);
            UpdateControlsFromNavigator();
        }

        private void comboBoxPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            kiwiNavigator.PopupPages.Position = (PopupPagePosition)Enum.Parse(typeof(PopupPagePosition), comboBoxPosition.Text);
            UpdateControlsFromNavigator();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
