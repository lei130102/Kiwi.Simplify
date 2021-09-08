using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Expanding_HeaderGroups__Stack_
{
    public partial class Form1 : KiwiForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kiwiHeaderTop_CollapsedChanged(object sender, EventArgs e)
        {
            kiwiBorderEdgeTop.Visible = !kiwiHeaderTop.Collapsed;
        }

        private void kiwiHeaderBottom_CollapsedChanged(object sender, EventArgs e)
        {
            kiwiBorderEdgeBottom.Visible = !kiwiHeaderBottom.Collapsed;
        }

        private void toolOffice2010_Click(object sender, EventArgs e)
        {
            if (!toolOffice2010.Checked)
            {
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
                toolOffice2010.Checked = menuOffice2010.Checked = true;
                toolOffice2007.Checked = menuOffice2007.Checked = false;
                toolSparkle.Checked = menuSparkle.Checked = false;
                toolSystem.Checked = menuSystem.Checked = false;
            }
        }

        private void toolOffice2007_Click(object sender, EventArgs e)
        {
            if (!toolOffice2007.Checked)
            {
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
                toolOffice2010.Checked = menuOffice2010.Checked = false;
                toolOffice2007.Checked = menuOffice2007.Checked = true;
                toolSparkle.Checked = menuSparkle.Checked = false;
                toolSystem.Checked = menuSystem.Checked = false;
            }
        }

        private void toolSparkle_Click(object sender, EventArgs e)
        {
            if (!toolSparkle.Checked)
            {
                kiwiManager.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
                toolOffice2010.Checked = menuOffice2010.Checked = false;
                toolOffice2007.Checked = menuOffice2007.Checked = false;
                toolSparkle.Checked = menuSparkle.Checked = true;
                toolSystem.Checked = menuSystem.Checked = false;
            }
        }

        private void toolSystem_Click(object sender, EventArgs e)
        {
            if (!toolSystem.Checked)
            {
                kiwiManager.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
                toolOffice2010.Checked = menuOffice2010.Checked = false;
                toolOffice2007.Checked = menuOffice2007.Checked = false;
                toolSparkle.Checked = menuSparkle.Checked = false;
                toolSystem.Checked = menuSystem.Checked = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
