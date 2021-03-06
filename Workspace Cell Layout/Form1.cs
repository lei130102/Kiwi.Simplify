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

namespace Workspace_Cell_Layout
{
    public partial class Form1 : Form
    {
        private int _count = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initial appearance is same as clicking the 'New Three Cells' button
            buttonNewThreeCells_Click(buttonNewThreeCells, e);
        }

        private void kiwiWorkspace_WorkspaceCellAdding(object sender, WorkspaceCellEventArgs e)
        {
            // Remove the context menu from the tabs bar, as it is not relevant to this sample
            e.Cell.Button.ContextButtonDisplay = ButtonDisplay.Hide;
        }

        private void buttonNewSingleCell_Click(object sender, EventArgs e)
        {
            // Remove all existing workspace content
            kiwiWorkspace.Root.Children.Clear();

            // Add a single cell that has three pages
            kiwiWorkspace.Root.Children.Add(CreateCell(6));
        }

        private void buttonNewThreeCells_Click(object sender, EventArgs e)
        {
            // Remove all existing workspace content
            kiwiWorkspace.Root.Children.Clear();

            // Add three cells that have two pages each
            kiwiWorkspace.Root.Children.Add(CreateCell(2));
            kiwiWorkspace.Root.Children.Add(CreateCell(2));
            kiwiWorkspace.Root.Children.Add(CreateCell(2));

            // We want the root cells to be layed out horizontally
            kiwiWorkspace.Root.Orientation = Orientation.Horizontal;
        }

        private void buttonNewSequences_Click(object sender, EventArgs e)
        {
            // Remove all existing workspace content
            kiwiWorkspace.Root.Children.Clear();

            // Create a horizontal sequence with two cells
            KiwiWorkspaceSequence sequence2 = new KiwiWorkspaceSequence(Orientation.Horizontal);
            sequence2.Children.Add(CreateCell());
            sequence2.Children.Add(CreateCell());
            sequence2.Children.Add(CreateCell());

            // Create a vertical sequence with two cells and the horizontal sequence
            KiwiWorkspaceSequence sequence1 = new KiwiWorkspaceSequence(Orientation.Vertical);
            sequence1.Children.Add(CreateCell(2, "25*,25*"));
            sequence1.Children.Add(CreateCell(2, "25*,25*"));
            sequence1.Children.Add(sequence2);

            // Root contains two cells and the vertical sequence
            kiwiWorkspace.Root.Children.Add(CreateCell(1, "25*,25*"));
            kiwiWorkspace.Root.Children.Add(CreateCell(1, "25*,25*"));
            kiwiWorkspace.Root.Children.Add(sequence1);

            // We want the root cells to be layed out horizontally
            kiwiWorkspace.Root.Orientation = Orientation.Horizontal;
        }

        private void buttonApplySingleCell_Click(object sender, EventArgs e)
        {
            // Move all pages into a single cell
            kiwiWorkspace.ApplySingleCell();
        }

        private void buttonApplySingleRow_Click(object sender, EventArgs e)
        {
            kiwiWorkspace.ApplyGridPages(false, Orientation.Horizontal, 1);
        }

        private void buttonApplySingleColumn_Click(object sender, EventArgs e)
        {
            kiwiWorkspace.ApplyGridPages(false, Orientation.Vertical, 1);
        }

        private void buttonApplyGrid_Click(object sender, EventArgs e)
        {
            // Create a grid with one cell per page
            kiwiWorkspace.ApplyGridPages();
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Remove everything from the workspace
            kiwiWorkspace.Root.Children.Clear();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private KiwiWorkspaceCell CreateCell()
        {
            return CreateCell(1);
        }

        private KiwiWorkspaceCell CreateCell(int numPages)
        {
            return CreateCell(numPages, string.Empty);
        }

        private KiwiWorkspaceCell CreateCell(int numPages, string starSize)
        {
            // Create new cell instance
            KiwiWorkspaceCell cell = new KiwiWorkspaceCell();

            // Do we need to set the star sizing value?
            if (!string.IsNullOrEmpty(starSize))
                cell.StarSize = starSize;

            // Add requested number of pages
            for (int i = 0; i < numPages; i++)
                cell.Pages.Add(CreatePage());

            return cell;
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a grid with one cell per page
            kiwiWorkspace.ApplyGridPages(true, Orientation.Horizontal);
        }
    }
}
