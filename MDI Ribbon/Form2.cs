using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDI_Ribbon
{
    public partial class Form2 : KiwiForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Remember to unhook from static event, otherwise 
                // this object cannot be garbage collected later on
                KiwiManager.GlobalPaletteChanged -= new EventHandler(OnPaletteChanged);

                if (components != null)
                    components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Set correct initial radio button setting
            UpdateRadioButtons();

            // Hook into changes in the global palette
            KiwiManager.GlobalPaletteChanged += new EventHandler(OnPaletteChanged);
        }

        private void radioSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSystem.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
        }

        private void radioOffice2003_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOffice2003.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.ProfessionalOffice2003;
        }

        private void radio2010Blue_CheckedChanged(object sender, EventArgs e)
        {
            if (radio2010Blue.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
        }

        private void radio2010Silver_CheckedChanged(object sender, EventArgs e)
        {
            if (radio2010Silver.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2010Silver;
        }

        private void radio2010Black_CheckedChanged(object sender, EventArgs e)
        {
            if (radio2010Black.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2010Black;
        }

        private void radioBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBlue.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
        }

        private void radioSilver_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSilver.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2007Silver;
        }

        private void radioBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBlack.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2007Black;
        }

        private void radioSparkleBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSparkleBlue.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
        }

        private void radioSparkleOrange_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSparkleOrange.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.SparkleOrange;
        }

        private void radioSparklePurple_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSparklePurple.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.SparklePurple;
        }

        private void OnPaletteChanged(object sender, EventArgs e)
        {
            // Update buttons to reflect the new palette setting
            UpdateRadioButtons();
        }

        private void UpdateRadioButtons()
        {
            switch (kiwiManager.GlobalPaletteMode)
            {
                case PaletteModeManager.ProfessionalSystem:
                    radioSystem.Checked = true;
                    break;
                case PaletteModeManager.ProfessionalOffice2003:
                    radioOffice2003.Checked = true;
                    break;
                case PaletteModeManager.Office2007Blue:
                    radioBlue.Checked = true;
                    break;
                case PaletteModeManager.Office2007Silver:
                    radioSilver.Checked = true;
                    break;
                case PaletteModeManager.Office2007Black:
                    radioBlack.Checked = true;
                    break;
                case PaletteModeManager.SparkleBlue:
                    radioSparkleBlue.Checked = true;
                    break;
                case PaletteModeManager.SparkleOrange:
                    radioSparkleOrange.Checked = true;
                    break;
                case PaletteModeManager.SparklePurple:
                    radioSparklePurple.Checked = true;
                    break;
                case PaletteModeManager.Office2010Blue:
                    radio2010Blue.Checked = true;
                    break;
                case PaletteModeManager.Office2010Silver:
                    radio2010Silver.Checked = true;
                    break;
                case PaletteModeManager.Office2010Black:
                    radio2010Black.Checked = true;
                    break;
            }
        }
    }
}
