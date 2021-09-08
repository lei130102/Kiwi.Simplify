using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Custom_Control_using_Palettes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kryptonCheckSet_CheckedButtonChanged(object sender, EventArgs e)
        {
            // Switch to using a different global palette
            switch (kryptonCheckSet.CheckedIndex)
            {
                case 0:
                    kryptonManager.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
                    break;
                case 1:
                    kryptonManager.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
                    break;
                case 2:
                    kryptonManager.GlobalPalette = kiwiPaletteCustom;
                    break;
                case 3:
                    kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
                    break;
                case 4:
                    kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
                    break;
            }
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
