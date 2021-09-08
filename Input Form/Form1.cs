using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Input_Form
{
    public partial class Form1 : KiwiForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void office2010_Click(object sender, EventArgs e)
        {
            kiwiManager1.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
            toolStripOffice2010.Checked = true;
            toolStripOffice2007.Checked = false;
            toolStripSystem.Checked = false;
            toolStripSparkle.Checked = false;
            office2010MenuItem.Checked = true;
            office2007MenuItem.Checked = false;
            systemMenuItem.Checked = false;
            sparkleMenuItem.Checked = false;
        }

        private void office2007_Click(object sender, EventArgs e)
        {
            kiwiManager1.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
            toolStripOffice2010.Checked = false;
            toolStripOffice2007.Checked = true;
            toolStripSystem.Checked = false;
            toolStripSparkle.Checked = false;
            office2010MenuItem.Checked = false;
            office2007MenuItem.Checked = true;
            systemMenuItem.Checked = false;
            sparkleMenuItem.Checked = false;
        }

        private void sparkle_Click(object sender, EventArgs e)
        {
            kiwiManager1.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
            toolStripOffice2010.Checked = false;
            toolStripOffice2007.Checked = false;
            toolStripSystem.Checked = false;
            toolStripSparkle.Checked = true;
            office2010MenuItem.Checked = false;
            office2007MenuItem.Checked = false;
            systemMenuItem.Checked = false;
            sparkleMenuItem.Checked = true;
        }

        private void system_Click(object sender, EventArgs e)
        {
            kiwiManager1.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
            toolStripOffice2010.Checked = false;
            toolStripOffice2007.Checked = false;
            toolStripSystem.Checked = true;
            toolStripSparkle.Checked = false;
            office2010MenuItem.Checked = false;
            office2007MenuItem.Checked = false;
            systemMenuItem.Checked = true;
            sparkleMenuItem.Checked = false;
        }

        private void clearTelephone_Click(object sender, EventArgs e)
        {
            maskedTextBoxTelephone.Text = string.Empty;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
