using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KiwiCheckedListBox_Examples
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
            propertyGrid.SelectedObject = kiwiCheckedListBox;

            // Add some initial entries
            kiwiCheckedListBox.Items.Add(CreateNewItem());
            kiwiCheckedListBox.Items.Add(CreateNewItem());
            kiwiCheckedListBox.Items.Add(CreateNewItem());
            kiwiCheckedListBox.Items.Add(CreateNewItem());
            kiwiCheckedListBox.Items.Add(CreateNewItem());

            // Select the first entry
            kiwiCheckedListBox.SelectedIndex = 0;
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
            buttonInsert.Enabled = (kiwiCheckedListBox.SelectedIndex >= 0);
            buttonRemove.Enabled = (kiwiCheckedListBox.SelectedIndex >= 0);
        }

        private void buttonAppend_Click(object sender, EventArgs e)
        {
            kiwiCheckedListBox.Items.Add(CreateNewItem());

            // If nothing currently selected, then select the new one
            if (kiwiCheckedListBox.SelectedIndex == -1)
                kiwiCheckedListBox.SelectedIndex = 0;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            // Can only insert if something is already selected
            if (kiwiCheckedListBox.SelectedIndex >= 0)
                kiwiCheckedListBox.Items.Insert(kiwiCheckedListBox.SelectedIndex, CreateNewItem());
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            // Can only remove if something is selected
            if (kiwiCheckedListBox.SelectedIndex >= 0)
            {
                // Find the new index to select
                int index = kiwiCheckedListBox.SelectedIndex;
                if (index == (kiwiCheckedListBox.Items.Count - 1))
                    index--;

                // Remove entry
                kiwiCheckedListBox.Items.RemoveAt(kiwiCheckedListBox.SelectedIndex);

                // Select the new item
                if (index < kiwiCheckedListBox.Items.Count)
                    kiwiCheckedListBox.SelectedIndex = index;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            kiwiCheckedListBox.Items.Clear();
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
