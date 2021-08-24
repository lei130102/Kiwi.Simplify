using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KiwiContextMenu_Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxH.SelectedIndex = 2;
            comboBoxV.SelectedIndex = 1;
        }

        private void buttonShowHeadings_Click(object sender, EventArgs e)
        {
            ShowMenu(buttonShowHeadings, kcmHeadings);
        }

        private void buttonShowSeparators_Click(object sender, EventArgs e)
        {
            ShowMenu(buttonShowSeparators, kcmSeparators);
        }

        private void buttonShowAlternateStyle_Click(object sender, EventArgs e)
        {
            ShowMenu(buttonShowAlternateStyle, kcmAlternateStyle);
        }

        private void buttonSubMenus_Click(object sender, EventArgs e)
        {
            ShowMenu(buttonSubMenus, kcmSubMenus);
        }

        private void buttonControls_Click(object sender, EventArgs e)
        {
            ShowMenu(buttonControls, kcmControls);
        }

        private void buttonColors_Click(object sender, EventArgs e)
        {
            ShowMenu(buttonColors, kcmColors);
        }

        private void buttonImageSelect_Click(object sender, EventArgs e)
        {
            ShowMenu(buttonImageSelect, kcmImageSelect);
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            ShowMenu(buttonCalendar, kcmCalendar);
        }

        private void buttonShowEverything_Click(object sender, EventArgs e)
        {
            ShowMenu(buttonShowEverything, kcmEverything);
        }

        private void ShowMenu(Control c, KiwiContextMenu kcm)
        {
            kcm.Show(c.RectangleToScreen(c.ClientRectangle),
                (KiwiContextMenuPositionH)Enum.Parse(typeof(KiwiContextMenuPositionH), (string)comboBoxH.SelectedItem),
                (KiwiContextMenuPositionV)Enum.Parse(typeof(KiwiContextMenuPositionV), (string)comboBoxV.SelectedItem));
        }

        private void radioOffice2010Blue_CheckedChanged(object sender, EventArgs e)
        {
            kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
        }

        private void radioOffice2007Blue_CheckedChanged(object sender, EventArgs e)
        {
            kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
        }

        private void radioOffice2007Silver_CheckedChanged(object sender, EventArgs e)
        {
            kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2007Silver;
        }

        private void radioOffice2003_CheckedChanged(object sender, EventArgs e)
        {
            kiwiManager.GlobalPaletteMode = PaletteModeManager.ProfessionalOffice2003;
        }

        private void radioSparkleBlue_CheckedChanged(object sender, EventArgs e)
        {
            kiwiManager.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
        }

        private void radioSparkleOrange_CheckedChanged(object sender, EventArgs e)
        {
            kiwiManager.GlobalPaletteMode = PaletteModeManager.SparkleOrange;
        }

        private void radioSparklePurple_CheckedChanged(object sender, EventArgs e)
        {
            kiwiManager.GlobalPaletteMode = PaletteModeManager.SparklePurple;
        }

        private void radioSystem_CheckedChanged(object sender, EventArgs e)
        {
            kiwiManager.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
        }

        private void radioCustom_CheckedChanged(object sender, EventArgs e)
        {
            //GlobalPalette
            kiwiManager.GlobalPalette = kiwiPaletteCustom;
        }
    }
}
