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

namespace Ribbon_Gallery
{
    public partial class Form1 : KiwiForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void galleryCustom_GalleryDropMenu(object sender, GalleryDropMenuEventArgs e)
        {
            KiwiContextMenuHeading h = new KiwiContextMenuHeading();
            h.Text = "Customize Drop Menu";

            KiwiContextMenuItems items1 = new KiwiContextMenuItems();
            KiwiContextMenuItem item1 = new KiwiContextMenuItem();
            item1.Text = "Custom Entry 1";
            KiwiContextMenuItem item2 = new KiwiContextMenuItem();
            item2.Text = "Custom Entry 2";
            item2.Checked = true;
            items1.Items.Add(item1);
            items1.Items.Add(item2);

            KiwiContextMenuItems items2 = new KiwiContextMenuItems();
            KiwiContextMenuItem item3 = new KiwiContextMenuItem();
            item3.Text = "Custom Entry 3";
            KiwiContextMenuItem item4 = new KiwiContextMenuItem();
            item4.Text = "Custom Entry 4";
            item4.CheckState = CheckState.Indeterminate;
            items2.Items.Add(item3);
            items2.Items.Add(item4);

            e.KiwiContextMenu.Items.Insert(0, new KiwiContextMenuSeparator());
            e.KiwiContextMenu.Items.Insert(0, items1);
            e.KiwiContextMenu.Items.Insert(0, h);
            e.KiwiContextMenu.Items.Add(new KiwiContextMenuSeparator());
            e.KiwiContextMenu.Items.Add(items2);
        }

        private void kiwiRibbonGroupButton1_Click(object sender, EventArgs e)
        {
            if (kiwiRibbonGroupButton1.Checked)
            {
                kiwiManager1.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
                kiwiRibbonGroupButton2.Checked = false;
                kiwiRibbonGroupButton3.Checked = false;
            }
        }

        private void kiwiRibbonGroupButton2_Click(object sender, EventArgs e)
        {
            if (kiwiRibbonGroupButton2.Checked)
            {
                kiwiManager1.GlobalPaletteMode = PaletteModeManager.Office2007Silver;
                kiwiRibbonGroupButton1.Checked = false;
                kiwiRibbonGroupButton3.Checked = false;
            }
        }

        private void kiwiRibbonGroupButton3_Click(object sender, EventArgs e)
        {
            if (kiwiRibbonGroupButton3.Checked)
            {
                kiwiManager1.GlobalPaletteMode = PaletteModeManager.SparkleOrange;
                kiwiRibbonGroupButton1.Checked = false;
                kiwiRibbonGroupButton2.Checked = false;
            }
        }

        private void kiwiContextMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
