using Kiwi.ComponentFactory.Ribbon;
using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeyTips___Keyboard_Access
{
    public partial class Form1 : KiwiForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkSetPalette.CheckedButton = this.buttonOffice2007Black;
        }

        private void checkSetPalette_CheckedButtonChanged(object sender, EventArgs e)
        {
            if (checkSetPalette.CheckedButton == buttonOffice2007Blue)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
            else if (checkSetPalette.CheckedButton == buttonOffice2007Silver)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2007Silver;
            else if (checkSetPalette.CheckedButton == buttonOffice2007Black)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2007Black;
            else if (checkSetPalette.CheckedButton == buttonProfessional2003)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.ProfessionalOffice2003;
            else if (checkSetPalette.CheckedButton == buttonProfessionalSystem)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
            else if (checkSetPalette.CheckedButton == buttonSparkleBlue)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
            else if (checkSetPalette.CheckedButton == buttonSparkleOrange)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.SparkleOrange;
            else if (checkSetPalette.CheckedButton == buttonSparklePurple)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.SparklePurple;
            else if (checkSetPalette.CheckedButton == buttonOffice2010Blue)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
            else if (checkSetPalette.CheckedButton == buttonOffice2010Silver)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2010Silver;
            else if (checkSetPalette.CheckedButton == buttonOffice2010Black)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2010Black;
        }

        private void OnDialogBoxLauncherClick(object sender, EventArgs e)
        {
            KiwiRibbonGroup group = (KiwiRibbonGroup)sender;

            MessageBox.Show(this,
                            "You selected the '" + group.TextLine1 + "' group dialog box launcher.",
                            "Dialog Box Launcher");
        }

        private void OnQATButtonClick(object sender, EventArgs e)
        {
            KiwiRibbonQATButton button = (KiwiRibbonQATButton)sender;

            MessageBox.Show(this,
                            "You selected the '" + button.Text + "' quick access toolbar button.",
                            "QAT Button");
        }

        private void OnGroupButtonClick(object sender, EventArgs e)
        {
            KiwiRibbonGroupButton button = (KiwiRibbonGroupButton)sender;

            string text = button.TextLine1;
            if (!string.IsNullOrEmpty(button.TextLine2))
                text += " " + button.TextLine2;

            MessageBox.Show(this,
                            "You selected the '" + text + "' button.",
                            "Button");
        }

        private void OnGroupClusterButtonClick(object sender, EventArgs e)
        {
            KiwiRibbonGroupClusterButton button = (KiwiRibbonGroupClusterButton)sender;

            MessageBox.Show(this,
                            "You selected the '" + button.TextLine + "' button.",
                            "Button");
        }

        private void appMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
