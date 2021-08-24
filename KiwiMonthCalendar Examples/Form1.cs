using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KiwiMonthCalendar_Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbOffice2010Blue_CheckedChanged(object sender, EventArgs e)
        {
            kiwiPalette.BasePaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2010Blue;
        }

        private void rbOffice2010Silver_CheckedChanged(object sender, EventArgs e)
        {
            kiwiPalette.BasePaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2010Silver;
        }

        private void rbOffice2010Black_CheckedChanged(object sender, EventArgs e)
        {
            kiwiPalette.BasePaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2010Black;
        }

        private void rbOffice2007Blue_CheckedChanged(object sender, EventArgs e)
        {
            kiwiPalette.BasePaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2007Blue;
        }

        private void rbOffice2007Silver_CheckedChanged(object sender, EventArgs e)
        {
            kiwiPalette.BasePaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2007Silver;
        }

        private void rbOffice2007Black_CheckedChanged(object sender, EventArgs e)
        {
            kiwiPalette.BasePaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2007Black;
        }

        private void rbSparkleBlue_CheckedChanged(object sender, EventArgs e)
        {
            kiwiPalette.BasePaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.SparkleBlue;
        }

        private void rbSparkleOrange_CheckedChanged(object sender, EventArgs e)
        {
            kiwiPalette.BasePaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.SparkleOrange;
        }

        private void rbSparklePurple_CheckedChanged(object sender, EventArgs e)
        {
            kiwiPalette.BasePaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.SparklePurple;
        }

        private void rbOffice2003_CheckedChanged(object sender, EventArgs e)
        {
            kiwiPalette.BasePaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalOffice2003;
        }

        private void rbSystem_CheckedChanged(object sender, EventArgs e)
        {
            kiwiPalette.BasePaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalSystem;
        }
    }
}
