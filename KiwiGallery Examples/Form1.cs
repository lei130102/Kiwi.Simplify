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

namespace KiwiGallery_Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioSmallList_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSmallList.Checked)
                kiwiGallery1.ImageList = imageListSmall;
        }

        private void radioMediumList_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMediumList.Checked)
                kiwiGallery1.ImageList = imageListMedium;
        }

        private void radioLargeList_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLargeList.Checked)
                kiwiGallery1.ImageList = imageListLarge;
        }

        private void numericWidth_ValueChanged(object sender, EventArgs e)
        {
            kiwiGallery1.PreferredItemSize = new Size(Convert.ToInt32(numericWidth.Value), kiwiGallery1.PreferredItemSize.Height);
        }

        private void numericHeight_ValueChanged(object sender, EventArgs e)
        {
            kiwiGallery1.PreferredItemSize = new Size(kiwiGallery1.PreferredItemSize.Width, Convert.ToInt32(numericHeight.Value));
        }

        private void checkBoxGroupImages_CheckedChanged(object sender, EventArgs e)
        {
            kiwiGallery1.DropButtonRanges.Clear();
            if (checkBoxGroupImages.Checked)
            {
                kiwiGallery1.DropButtonRanges.Add(kiwiGalleryRange1);
                kiwiGallery1.DropButtonRanges.Add(kiwiGalleryRange2);
                kiwiGallery1.DropButtonRanges.Add(kiwiGalleryRange3);
            }
        }

        private void kiwiGallery1_GalleryDropMenu(object sender, GalleryDropMenuEventArgs e)
        {
            if (checkBoxAddCustomItems.Checked)
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
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
