using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Child_Control_Stack
{
    public partial class Form1 : KiwiForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxFiller.Focus();
            textBoxFiller.SelectionStart = 0;
            textBoxFiller.SelectionLength = 0;
        }

        private void kiwiCheckSet_CheckedButtonChanged(object sender, EventArgs e)
        {
            // Put the name for the checkbutton into the header
            kiwiHeader.Values.Heading = kiwiCheckSet.CheckedButton.Values.Text;
        }

        private void toolOffice2010_Click(object sender, EventArgs e)
        {
            if (!toolOffice2010.Checked)
            {
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
                toolOffice2010.Checked = menuOffice2010.Checked = true;
                toolOffice2007.Checked = menuOffice2007.Checked = false;
                toolSystem.Checked = menuSystem.Checked = false;
                toolSparkle.Checked = menuSparkle.Checked = false;
            }
        }

        private void toolOffice2007_Click(object sender, EventArgs e)
        {
            if (!toolOffice2007.Checked)
            {
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
                toolOffice2010.Checked = menuOffice2010.Checked = false;
                toolOffice2007.Checked = menuOffice2007.Checked = true;
                toolSystem.Checked = menuSystem.Checked = false;
                toolSparkle.Checked = menuSparkle.Checked = false;
            }
        }

        private void toolSystem_Click(object sender, EventArgs e)
        {
            if (!toolSystem.Checked)
            {
                kiwiManager.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
                toolOffice2010.Checked = menuOffice2010.Checked = false;
                toolOffice2007.Checked = menuOffice2007.Checked = false;
                toolSystem.Checked = menuSystem.Checked = true;
                toolSparkle.Checked = menuSparkle.Checked = false;
            }
        }

        private void toolSparkle_Click(object sender, EventArgs e)
        {
            if (!toolSparkle.Checked)
            {
                kiwiManager.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
                toolOffice2010.Checked = menuOffice2010.Checked = false;
                toolOffice2007.Checked = menuOffice2007.Checked = false;
                toolSystem.Checked = menuSystem.Checked = false;
                toolSparkle.Checked = menuSparkle.Checked = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
