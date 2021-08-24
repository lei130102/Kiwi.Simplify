using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KiwiPalette_Examples
{
    public partial class Form1 : KiwiForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kiwiManager.GlobalPalette = kiwiPaletteOffice2010Blue;

            propertyGrid.SelectedObject = kiwiPaletteOffice2010Blue;
        }

        private void buttonOffice2010Blue_Click(object sender, EventArgs e)
        {
            kiwiManager.GlobalPalette = kiwiPaletteOffice2010Blue;

            propertyGrid.SelectedObject = kiwiPaletteOffice2010Blue;
        }

        private void buttonOffice2010Silver_Click(object sender, EventArgs e)
        {
            kiwiManager.GlobalPalette = kiwiPaletteOffice2010Silver;

            propertyGrid.SelectedObject = kiwiPaletteOffice2010Silver;
        }

        private void buttonOffice2010Black_Click(object sender, EventArgs e)
        {
            kiwiManager.GlobalPalette = kiwiPaletteOffice2010Black;

            propertyGrid.SelectedObject = kiwiPaletteOffice2010Black;
        }

        private void buttonOffice2007Blue_Click(object sender, EventArgs e)
        {
            kiwiManager.GlobalPalette = kiwiPaletteOffice2007Blue;

            propertyGrid.SelectedObject = kiwiPaletteOffice2007Blue;
        }

        private void buttonOffice2007Silver_Click(object sender, EventArgs e)
        {
            kiwiManager.GlobalPalette = kiwiPaletteOffice2007Silver;

            propertyGrid.SelectedObject = kiwiPaletteOffice2007Silver;
        }

        private void buttonOffice2007Black_Click(object sender, EventArgs e)
        {
            kiwiManager.GlobalPalette = kiwiPaletteOffice2007Black;

            propertyGrid.SelectedObject = kiwiPaletteOffice2007Black;
        }

        private void buttonOffice2003_Click(object sender, EventArgs e)
        {
            kiwiManager.GlobalPalette = kiwiPaletteOffice2003;

            propertyGrid.SelectedObject = kiwiPaletteOffice2003;
        }

        private void buttonSparkleBlue_Click(object sender, EventArgs e)
        {
            kiwiManager.GlobalPalette = kiwiPaletteSparkleBlue;

            propertyGrid.SelectedObject = kiwiPaletteSparkleBlue;
        }

        private void buttonSparkleOrange_Click(object sender, EventArgs e)
        {
            kiwiManager.GlobalPalette = kiwiPaletteSparkleOrange;

            propertyGrid.SelectedObject = kiwiPaletteSparkleOrange;
        }

        private void buttonSparklePurple_Click(object sender, EventArgs e)
        {
            kiwiManager.GlobalPalette = kiwiPaletteSparklePurple;

            propertyGrid.SelectedObject = kiwiPaletteSparklePurple;
        }

        private void buttonSystem_Click(object sender, EventArgs e)
        {
            kiwiManager.GlobalPalette = kiwiPaletteSystem;

            propertyGrid.SelectedObject = kiwiPaletteSystem;
        }

        private void buttonCustom_Click(object sender, EventArgs e)
        {
            kiwiManager.GlobalPalette = kiwiPaletteCustom;

            propertyGrid.SelectedObject = kiwiPaletteCustom;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
