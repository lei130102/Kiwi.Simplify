using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Application_Menu
{
    public partial class Form1 : KiwiForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBoxShowRecentDocs.Checked = kiwiRibbon1.RibbonAppButton.AppButtonShowRecentDocs;
            textBoxDocsTitle.Text = kiwiRibbon1.RibbonStrings.RecentDocuments;
            textBoxMinWidth.Text = kiwiRibbon1.RibbonAppButton.AppButtonMinRecentSize.Width.ToString();
            textBoxMinHeight.Text = kiwiRibbon1.RibbonAppButton.AppButtonMinRecentSize.Height.ToString();
        }

        private void kiwiRibbon1_AppButtonMenuOpening(object sender, CancelEventArgs e)
        {
            kiwiRibbon1.RibbonAppButton.AppButtonShowRecentDocs = checkBoxShowRecentDocs.Checked;
            kiwiRibbon1.RibbonStrings.RecentDocuments = textBoxDocsTitle.Text;

            int minWidth = int.Parse(textBoxMinWidth.Text);
            int minHeight = int.Parse(textBoxMinHeight.Text);
            kiwiRibbon1.RibbonAppButton.AppButtonMinRecentSize = new Size(minWidth, minHeight);
        }

        private void button2010Blue_Click(object sender, EventArgs e)
        {
            button2010Blue.Checked = true;
            button2010Silver.Checked = false;
            button2010Black.Checked = false;
            buttonBlue.Checked = false;
            buttonSilver.Checked = false;
            buttonBlack.Checked = false;
            button2003.Checked = false;
            buttonSparkleBlue.Checked = false;
            buttonSparkleOrange.Checked = false;
            buttonSparklePurple.Checked = false;
            buttonSystem.Checked = false;
            kiwiManager1.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
        }

        private void button2010Silver_Click(object sender, EventArgs e)
        {
            button2010Blue.Checked = false;
            button2010Silver.Checked = true;
            button2010Black.Checked = false;
            buttonBlue.Checked = false;
            buttonSilver.Checked = false;
            buttonBlack.Checked = false;
            button2003.Checked = false;
            buttonSparkleBlue.Checked = false;
            buttonSparkleOrange.Checked = false;
            buttonSparklePurple.Checked = false;
            buttonSystem.Checked = false;
            kiwiManager1.GlobalPaletteMode = PaletteModeManager.Office2010Silver;
        }

        private void button2010Black_Click(object sender, EventArgs e)
        {
            button2010Blue.Checked = false;
            button2010Silver.Checked = false;
            button2010Black.Checked = true;
            buttonBlue.Checked = false;
            buttonSilver.Checked = false;
            buttonBlack.Checked = false;
            button2003.Checked = false;
            buttonSparkleBlue.Checked = false;
            buttonSparkleOrange.Checked = false;
            buttonSparklePurple.Checked = false;
            buttonSystem.Checked = false;
            kiwiManager1.GlobalPaletteMode = PaletteModeManager.Office2010Black;
        }


        private void buttonBlue_Click(object sender, EventArgs e)
        {
            button2010Blue.Checked = false;
            button2010Silver.Checked = false;
            button2010Black.Checked = false;
            buttonBlue.Checked = true;
            buttonSilver.Checked = false;
            buttonBlack.Checked = false;
            button2003.Checked = false;
            buttonSparkleBlue.Checked = false;
            buttonSparkleOrange.Checked = false;
            buttonSparklePurple.Checked = false;
            buttonSystem.Checked = false;
            kiwiManager1.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
        }

        private void buttonSilver_Click(object sender, EventArgs e)
        {
            button2010Blue.Checked = false;
            button2010Silver.Checked = false;
            button2010Black.Checked = false;
            buttonBlue.Checked = false;
            buttonSilver.Checked = true;
            buttonBlack.Checked = false;
            button2003.Checked = false;
            buttonSparkleBlue.Checked = false;
            buttonSparkleOrange.Checked = false;
            buttonSparklePurple.Checked = false;
            buttonSystem.Checked = false;
            kiwiManager1.GlobalPaletteMode = PaletteModeManager.Office2007Silver;
        }

        private void buttonBlack_Click(object sender, EventArgs e)
        {
            button2010Blue.Checked = false;
            button2010Silver.Checked = false;
            button2010Black.Checked = false;
            buttonBlue.Checked = false;
            buttonSilver.Checked = false;
            buttonBlack.Checked = true;
            button2003.Checked = false;
            buttonSparkleBlue.Checked = false;
            buttonSparkleOrange.Checked = false;
            buttonSparklePurple.Checked = false;
            buttonSystem.Checked = false;
            kiwiManager1.GlobalPaletteMode = PaletteModeManager.Office2007Black;
        }

        private void button2003_Click(object sender, EventArgs e)
        {
            button2010Blue.Checked = false;
            button2010Silver.Checked = false;
            button2010Black.Checked = false;
            buttonBlue.Checked = false;
            buttonSilver.Checked = false;
            buttonBlack.Checked = false;
            button2003.Checked = true;
            buttonSparkleBlue.Checked = false;
            buttonSparkleOrange.Checked = false;
            buttonSparklePurple.Checked = false;
            buttonSystem.Checked = false;
            kiwiManager1.GlobalPaletteMode = PaletteModeManager.ProfessionalOffice2003;
        }

        private void buttonSparkleBlue_Click(object sender, EventArgs e)
        {
            button2010Blue.Checked = false;
            button2010Silver.Checked = false;
            button2010Black.Checked = false;
            buttonBlue.Checked = false;
            buttonSilver.Checked = false;
            buttonBlack.Checked = false;
            button2003.Checked = false;
            buttonSparkleBlue.Checked = true;
            buttonSparkleOrange.Checked = false;
            buttonSparklePurple.Checked = false;
            buttonSystem.Checked = false;
            kiwiManager1.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
        }

        private void buttonSparkleOrange_Click(object sender, EventArgs e)
        {
            button2010Blue.Checked = false;
            button2010Silver.Checked = false;
            button2010Black.Checked = false;
            buttonBlue.Checked = false;
            buttonSilver.Checked = false;
            buttonBlack.Checked = false;
            button2003.Checked = false;
            buttonSparkleBlue.Checked = false;
            buttonSparkleOrange.Checked = true;
            buttonSparklePurple.Checked = false;
            buttonSystem.Checked = false;
            kiwiManager1.GlobalPaletteMode = PaletteModeManager.SparkleOrange;
        }

        private void buttonSparklePurple_Click(object sender, EventArgs e)
        {
            button2010Blue.Checked = false;
            button2010Silver.Checked = false;
            button2010Black.Checked = false;
            buttonBlue.Checked = false;
            buttonSilver.Checked = false;
            buttonBlack.Checked = false;
            button2003.Checked = false;
            buttonSparkleBlue.Checked = false;
            buttonSparkleOrange.Checked = false;
            buttonSparklePurple.Checked = true;
            buttonSystem.Checked = false;
            kiwiManager1.GlobalPaletteMode = PaletteModeManager.SparklePurple;
        }

        private void buttonSystem_Click(object sender, EventArgs e)
        {
            buttonBlue.Checked = false;
            buttonSilver.Checked = false;
            buttonBlack.Checked = false;
            button2003.Checked = false;
            buttonSparkleBlue.Checked = false;
            buttonSparkleOrange.Checked = false;
            buttonSparklePurple.Checked = false;
            buttonSystem.Checked = true;
            kiwiManager1.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
        }
    }
}
