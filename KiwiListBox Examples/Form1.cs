using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KiwiListBox_Examples
{
    public partial class Form1 : Form
    {
        private int _next = 1;
        private Random _rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            propertyGrid.SelectedObject = kiwiListBox;

            // Add some initial entries
            kiwiListBox.Items.Add(CreateNewItem());
            kiwiListBox.Items.Add(CreateNewItem());
            kiwiListBox.Items.Add(CreateNewItem());
            kiwiListBox.Items.Add(CreateNewItem());
            kiwiListBox.Items.Add(CreateNewItem());

            // Select the first entry
            kiwiListBox.SelectedIndex = 0;
        }

        private object CreateNewItem()
        {
            KiwiListItem item = new KiwiListItem();
            item.ShortText = "Item " + (_next++).ToString();
            item.LongText = "(" + _rand.Next(Int32.MaxValue).ToString() + ")";
            item.Image = imageList.Images[_rand.Next(imageList.Images.Count - 1)];
            return item;
        }

        private void kiwiListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonInsert.Enabled = (kiwiListBox.SelectedIndex >= 0);
            buttonRemove.Enabled = (kiwiListBox.SelectedIndex >= 0);
        }

        private void buttonAppend_Click(object sender, EventArgs e)
        {
            kiwiListBox.Items.Add(CreateNewItem());

            // If nothing currently selected, then select the new one
            if (kiwiListBox.SelectedIndex == -1)
                kiwiListBox.SelectedIndex = 0;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            // Can only insert if something is already selected
            if (kiwiListBox.SelectedIndex >= 0)
                kiwiListBox.Items.Insert(kiwiListBox.SelectedIndex, CreateNewItem());
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            // Can only remove if something is selected
            if (kiwiListBox.SelectedIndex >= 0)
            {
                // Find the new index to select
                int index = kiwiListBox.SelectedIndex;
                if (index == (kiwiListBox.Items.Count - 1))
                    index--;

                // Remove entry
                kiwiListBox.Items.RemoveAt(kiwiListBox.SelectedIndex);

                // Select the new item
                if (index < kiwiListBox.Items.Count)
                    kiwiListBox.SelectedIndex = index;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            kiwiListBox.Items.Clear();
        }

        private void kiwiCheckSet_CheckedButtonChanged(object sender, EventArgs e)
        {
            if (kiwiCheckSet.CheckedButton == check2007Blue)
                kiwiManager1.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
            else if (kiwiCheckSet.CheckedButton == check2010Blue)
                kiwiManager1.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
            else if (kiwiCheckSet.CheckedButton == checkSparkle)
                kiwiManager1.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
            else if (kiwiCheckSet.CheckedButton == checkSystem)
                kiwiManager1.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
