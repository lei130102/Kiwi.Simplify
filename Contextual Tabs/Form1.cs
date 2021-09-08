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

namespace Contextual_Tabs
{
    public partial class Form1 : KiwiForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSelectedApply_Click(object sender, EventArgs e)
        {
            // Update ribbon with new context value
            kiwiRibbon.SelectedContext = textBoxSelectedContexts.Text;
        }

        private void textBoxSelectedContexts_KeyDown(object sender, KeyEventArgs e)
        {
            // Pressing enter in text box is same as pressing the apply button
            if (e.KeyCode == Keys.Enter)
                buttonSelectedApply_Click(buttonSelectedApply, EventArgs.Empty);
        }

        private void buttonEditColor_Click(object sender, EventArgs e)
        {
            // Let user change the color definition
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Update the displayed color feedback
                panelContextColor.StateCommon.Color1 = colorDialog.Color;
            }
        }

        private void buttonAddContext_Click(object sender, EventArgs e)
        {
            // Create a new context that uses the information specified
            KiwiRibbonContext newContext = new KiwiRibbonContext();
            newContext.ContextName = textBoxContextName.Text;
            newContext.ContextTitle = textBoxContextTitle.Text;
            newContext.ContextColor = panelContextColor.StateCommon.Color1;
            kiwiRibbon.RibbonContexts.Add(newContext);

            // Create a new ribbon page that specifies the new context name
            KiwiRibbonTab newTab = new KiwiRibbonTab();
            newTab.ContextName = newContext.ContextName;
            kiwiRibbon.RibbonTabs.Add(newTab);

            // Update the selected context name on the form and control so it shows
            string newSelectedContext = textBoxSelectedContexts.Text;
            if (newSelectedContext.Length > 0)
                newSelectedContext += ",";
            newSelectedContext += newContext.ContextName;
            textBoxSelectedContexts.Text = newSelectedContext;
            kiwiRibbon.SelectedContext = newSelectedContext;
        }

        private void radioOffice2010Blue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOffice2010Blue.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
        }

        private void radioOffice2010Silver_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOffice2010Silver.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2010Silver;
        }

        private void radioOffice2010Black_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOffice2010Black.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2010Black;
        }

        private void radioOffice2007Blue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOffice2007Blue.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
        }

        private void radioOffice2007Silver_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOffice2007Silver.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2007Silver;
        }

        private void radioOffice2007Black_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOffice2007Black.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2007Black;
        }

        private void radioOffice2003_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOffice2003.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.ProfessionalOffice2003;
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

        private void radioSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSystem.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
        }

        private void appMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
