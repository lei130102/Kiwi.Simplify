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

namespace Basic_Page_Drag___Drop
{
    public partial class Form1 : Form
    {
        private int _count;
        private DragManager _dm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _dm = new DragManager();
            _dm.StateCommon.Feedback = PaletteDragFeedback.Rounded;

            // Both navigators and workspaces are drag targets
            _dm.DragTargetProviders.Add(kiwiNavigator1);
            _dm.DragTargetProviders.Add(kiwiNavigator2);
            _dm.DragTargetProviders.Add(kiwiWorkspace1);
            _dm.DragTargetProviders.Add(kiwiWorkspace2);

            // Both navigators and workspaces can begin drag operations
            kiwiNavigator1.DragPageNotify = _dm;
            kiwiNavigator2.DragPageNotify = _dm;
            kiwiWorkspace1.DragPageNotify = _dm;
            kiwiWorkspace2.DragPageNotify = _dm;

            // Add initial pages to the navigators and workspaces
            kiwiNavigator1.Pages.AddRange(new KiwiPage[] { CreatePage(), CreatePage(), CreatePage() });
            kiwiNavigator2.Pages.AddRange(new KiwiPage[] { CreatePage(), CreatePage(), CreatePage() });
            kiwiWorkspace1.Root.Children.AddRange(new KiwiWorkspaceCell[] { CreateCell(2), CreateCell(2) });
            kiwiWorkspace2.Root.Children.AddRange(new KiwiWorkspaceCell[] { CreateCell(2), CreateCell(2) });
        }

        private void kiwiWorkspace1_WorkspaceCellAdding(object sender, WorkspaceCellEventArgs e)
        {
            // Hide the buttons we do not need for this sample
            e.Cell.Button.CloseButtonDisplay = ButtonDisplay.Hide;
            e.Cell.Button.ContextButtonDisplay = ButtonDisplay.Hide;
        }

        private void kiwiWorkspace2_WorkspaceCellAdding(object sender, WorkspaceCellEventArgs e)
        {
            // Hide the buttons we do not need for this sample
            e.Cell.Button.CloseButtonDisplay = ButtonDisplay.Hide;
            e.Cell.Button.ContextButtonDisplay = ButtonDisplay.Hide;

            // We want to provide header groups for the second workspace
            e.Cell.NavigatorMode = NavigatorMode.HeaderBarCheckButtonHeaderGroup;
            e.Cell.Header.HeaderVisibleSecondary = false;
        }

        private void radioBlock_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBlock.Checked)
                _dm.StateCommon.Feedback = PaletteDragFeedback.Block;
        }

        private void radioSquares_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSquares.Checked)
                _dm.StateCommon.Feedback = PaletteDragFeedback.Square;
        }

        private void radioRounded_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRounded.Checked)
                _dm.StateCommon.Feedback = PaletteDragFeedback.Rounded;
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

            // Create a rich text box with some sample text inside
            KiwiRichTextBox rtb = new KiwiRichTextBox();
            rtb.Text = "This page (" + page.Text + ") contains a rich text box control as example content. Your application could place anything you like here such as data entry controls, charts, data grids etc.";
            rtb.Dock = DockStyle.Fill;
            rtb.StateCommon.Border.Draw = InheritBool.False;

            // Add rich text box as the contents of the page
            page.Padding = new Padding(5);
            page.Controls.Add(rtb);

            return page;
        }
    }
}
