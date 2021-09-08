using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KiwiTreeView_Examples
{
    public partial class Form1 : Form
    {
        private int _next = 1;
        private Random _rand = new Random();

        public Form1()
        {
            InitializeComponent();

            buttonAppend_Click(null, EventArgs.Empty);
            buttonInsert_Click(null, EventArgs.Empty);
            buttonInsert_Click(null, EventArgs.Empty);
            buttonInsert_Click(null, EventArgs.Empty);
            kiwiTreeView.SelectedNode = null;
            buttonAppend_Click(null, EventArgs.Empty);
            buttonInsert_Click(null, EventArgs.Empty);
            buttonInsert_Click(null, EventArgs.Empty);
            kiwiTreeView.SelectedNode = null;
            buttonAppend_Click(null, EventArgs.Empty);
            buttonInsert_Click(null, EventArgs.Empty);
            kiwiTreeView.SelectedNode = null;
            buttonAppend_Click(null, EventArgs.Empty);
            buttonAppend_Click(null, EventArgs.Empty);
        }

        private KiwiTreeNode CreateNewItem()
        {
            KiwiTreeNode item = new KiwiTreeNode();
            item.Text = "Item " + (_next++).ToString();
            item.ImageIndex = _rand.Next(imageList.Images.Count - 1);
            item.SelectedImageIndex = item.ImageIndex;
            return item;
        }

        private void buttonAppend_Click(object sender, EventArgs e)
        {
            TreeNode node = CreateNewItem();
            kiwiTreeView.Nodes.Add(node);

            // If nothing currently selected, then select the new one
            if (kiwiTreeView.SelectedNode == null)
                kiwiTreeView.SelectedNode = node;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            // Can only insert if something is already selected
            if (kiwiTreeView.SelectedNode != null)
            {
                kiwiTreeView.SelectedNode.Nodes.Add(CreateNewItem());
                kiwiTreeView.SelectedNode.Expand();
            }
            else
                buttonAppend_Click(null, EventArgs.Empty);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            // Can only remove if something is selected
            if (kiwiTreeView.SelectedNode != null)
            {
                if (kiwiTreeView.SelectedNode.Parent != null)
                    kiwiTreeView.SelectedNode.Parent.Nodes.Remove(kiwiTreeView.SelectedNode);
                else
                    kiwiTreeView.Nodes.Remove(kiwiTreeView.SelectedNode);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            kiwiTreeView.Nodes.Clear();
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
