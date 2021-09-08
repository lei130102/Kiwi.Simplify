using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Three_Pane_Application__Basic_
{
    public partial class Form1 : KiwiForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kiwiOffice2010Blue_CheckedChanged(object sender, EventArgs e)
        {
            if (kiwiOffice2010Blue.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
        }

        private void kiwiOffice2010Silver_CheckedChanged(object sender, EventArgs e)
        {
            if (kiwiOffice2010Silver.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2010Silver;
        }

        private void kiwiOffice2010Black_CheckedChanged(object sender, EventArgs e)
        {
            if (kiwiOffice2010Black.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2010Black;
        }

        private void kiwiOffice2007Blue_CheckedChanged(object sender, EventArgs e)
        {
            if (kiwiOffice2007Blue.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
        }

        private void kiwiOffice2007Silver_CheckedChanged(object sender, EventArgs e)
        {
            if (kiwiOffice2007Silver.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2007Silver;
        }

        private void kiwiOffice2007Black_CheckedChanged(object sender, EventArgs e)
        {
            if (kiwiOffice2007Black.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2007Black;
        }

        private void kiwiOffice2003_CheckedChanged(object sender, EventArgs e)
        {
            if (kiwiOffice2003.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.ProfessionalOffice2003;
        }

        private void kiwiSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (kiwiSystem.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
        }

        private void kiwiSparkleBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (kiwiSparkleBlue.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
        }

        private void kiwiSparkleOrange_CheckedChanged(object sender, EventArgs e)
        {
            if (kiwiSparkleOrange.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.SparkleOrange;
        }

        private void kiwiSparklePurple_CheckedChanged(object sender, EventArgs e)
        {
            if (kiwiSparklePurple.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.SparklePurple;
        }

        private void kiwiCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (kiwiCustom.Checked)
                kiwiManager.GlobalPalette = kiwiPaletteCustom;
        }
    }
}
