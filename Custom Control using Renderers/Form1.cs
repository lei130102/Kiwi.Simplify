using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Custom_Control_using_Renderers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kiwiCheckSet_CheckedButtonChanged(object sender, EventArgs e)
        {
            // Switch to using a different global palette
            switch (kiwiCheckSet.CheckedIndex)
            {
                case 0:
                    kiwiManager.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
                    break;
                case 1:
                    kiwiManager.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
                    break;
                case 2:
                    kiwiManager.GlobalPalette = kiwiPaletteCustom;
                    break;
                case 3:
                    kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
                    break;
                case 4:
                    kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
                    break;
            }
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            // Update orientation of the MyUserControl to match radio buttons
            if (radioTop.Checked)
                myUserControl1.Orientation = VisualOrientation.Top;
            else if (radioBottom.Checked)
                myUserControl1.Orientation = VisualOrientation.Bottom;
            else if (radioLeft.Checked)
                myUserControl1.Orientation = VisualOrientation.Left;
            else if (radioRight.Checked)
                myUserControl1.Orientation = VisualOrientation.Right;
        }

        private void checkBoxEnabled_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle the enabled state of the custom control instance
            myUserControl1.Enabled = !myUserControl1.Enabled;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
