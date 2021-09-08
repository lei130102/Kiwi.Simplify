using Kiwi.ComponentFactory.Navigator;
using Kiwi.ComponentFactory.Toolkit;
using Kiwi.ComponentFactory.Workspace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Workspace_Cell_Modes
{
    public partial class Form1 : Form
    {
        private int _count = 1;
        private NavigatorMode _mode = NavigatorMode.BarTabGroup;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create three cells that each contain two pages
            KiwiWorkspaceCell cell1 = new KiwiWorkspaceCell();
            KiwiWorkspaceCell cell2 = new KiwiWorkspaceCell();
            KiwiWorkspaceCell cell3 = new KiwiWorkspaceCell();
            cell1.Pages.AddRange(new KiwiPage[] { CreatePage(), CreatePage() });
            cell2.Pages.AddRange(new KiwiPage[] { CreatePage(), CreatePage() });
            cell3.Pages.AddRange(new KiwiPage[] { CreatePage(), CreatePage() });

            // Create a vertical sequence that contains two of the pages
            KiwiWorkspaceSequence sequence = new KiwiWorkspaceSequence(Orientation.Vertical);
            sequence.Children.AddRange(new KiwiWorkspaceCell[] { cell2, cell3 });

            // Remove starting contents and add a cell with a sequence
            kiwiWorkspace.Root.Children.Clear();
            kiwiWorkspace.Root.Children.Add(cell1);
            kiwiWorkspace.Root.Children.Add(sequence);
        }

        private void radioMode_CheckedChanged(object sender, EventArgs e)
        {
            NavigatorMode mode = _mode;

            // Work out the new mode we want
            if (radioBarTabGroup.Checked)
                mode = NavigatorMode.BarTabGroup;
            else if (radioBarRibbonTabGroup.Checked)
                mode = NavigatorMode.BarRibbonTabGroup;
            else if (radioBarCheckButtonGroupInside.Checked)
                mode = NavigatorMode.BarCheckButtonGroupInside;
            else if (radioBarCheckButtonGroupOutside.Checked)
                mode = NavigatorMode.BarCheckButtonGroupOutside;
            else if (radioHeaderBarCheckButtonGroup.Checked)
                mode = NavigatorMode.HeaderBarCheckButtonGroup;
            else if (radioHeaderBarCheckButtonHeaderGroup.Checked)
                mode = NavigatorMode.HeaderBarCheckButtonHeaderGroup;
            else if (radioStackCheckButtonGroup.Checked)
                mode = NavigatorMode.StackCheckButtonGroup;
            else if (radioStackCheckButtonHeaderGroup.Checked)
                mode = NavigatorMode.StackCheckButtonHeaderGroup;
            else if (radioOutlookFull.Checked)
                mode = NavigatorMode.OutlookFull;
            else if (radioOutlookMini.Checked)
                mode = NavigatorMode.OutlookMini;
            else if (radioHeaderGroup.Checked)
                mode = NavigatorMode.HeaderGroup;
            else if (radioGroup.Checked)
                mode = NavigatorMode.Group;
            else if (radioPanel.Checked)
                mode = NavigatorMode.Panel;

            UpdateCellMode(mode);
        }

        private void UpdateCellMode(NavigatorMode mode)
        {
            // Cache new mode
            _mode = mode;

            // Update all existing cells with new mode
            KiwiWorkspaceCell cell = kiwiWorkspace.FirstCell();
            while (cell != null)
            {
                cell.NavigatorMode = _mode;
                cell = kiwiWorkspace.NextCell(cell);
            }
        }

        private void kiwiWorkspace_WorkspaceCellAdding(object sender, WorkspaceCellEventArgs e)
        {
            // Set the initial mode to match the radio button selection
            e.Cell.NavigatorMode = _mode;
        }

        private void buttonAddPage_Click(object sender, EventArgs e)
        {
            // Add page to the currently active cell
            if (kiwiWorkspace.ActiveCell != null)
            {
                kiwiWorkspace.ActiveCell.Pages.Add(CreatePage());
                kiwiWorkspace.ActiveCell.SelectedIndex = kiwiWorkspace.ActiveCell.Pages.Count - 1;
            }
        }

        private void buttonClearPages_Click(object sender, EventArgs e)
        {
            kiwiWorkspace.Root.Children.Clear();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private KiwiPage CreatePage()
        {
            // Give each page a unique number
            string pageNumber = (_count++).ToString();

            // Create a new page and give it a name and image
            KiwiPage page = new KiwiPage();
            page.Text = "P" + pageNumber;
            page.TextTitle = "P" + pageNumber + " Title";
            page.TextDescription = "P" + pageNumber + " Description";
            page.ImageSmall = imageList.Images[_count % imageList.Images.Count];
            page.MinimumSize = new Size(200, 250);

            // Create a rich text box with some sample text inside
            KiwiRichTextBox rtb = new KiwiRichTextBox();
            rtb.Text = "This page (" + page.Text + ") contains a rich text box control as example content. Your application could place anything you like here such as data entry controls, charts, data grids etc.\n\nTry dragging the page headers in order to rearrange the workspace layout.";
            rtb.Dock = DockStyle.Fill;
            rtb.StateCommon.Border.Draw = InheritBool.False;

            // Add rich text box as the contents of the page
            page.Padding = new Padding(5);
            page.Controls.Add(rtb);

            return page;
        }
    }
}
