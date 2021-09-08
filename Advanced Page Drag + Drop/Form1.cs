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

namespace Advanced_Page_Drag___Drop
{
    public partial class Form1 : Form
    {
        private DragManager _dm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _dm = new DragManager();
            _dm.StateCommon.Feedback = PaletteDragFeedback.Rounded;

            // Add controls that are drop targets
            _dm.DragTargetProviders.Add(dragTreeView);
            _dm.DragTargetProviders.Add(kiwiNavigator);
            _dm.DragTargetProviders.Add(kiwiWorkspace);

            // Controls that can begin drag operations
            dragTreeView.DragPageNotify = _dm;
            kiwiNavigator.DragPageNotify = _dm;
            kiwiWorkspace.DragPageNotify = _dm;

            // Add initial pages to the navigator and workspace
            kiwiNavigator.Pages.AddRange(new KiwiPage[] { CreatePage("Canberra", 7), CreatePage("Nicosia", 8) });
            kiwiWorkspace.Root.Children.Clear();
            kiwiWorkspace.Root.Children.AddRange(new KiwiWorkspaceCell[] { CreateCell("Dublin", 9, "Oslo", 10), CreateCell("Budapest", 11, "Tokyo", 12) });
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

        private void workspaceCellAdding(object sender, WorkspaceCellEventArgs e)
        {
            // Hide the default close and context buttons, they are not relevant for this demo
            e.Cell.Button.CloseButtonAction = CloseButtonAction.None;
            e.Cell.Button.CloseButtonDisplay = ButtonDisplay.Hide;
            e.Cell.Button.ContextButtonDisplay = ButtonDisplay.Hide;
        }

        private KiwiWorkspaceCell CreateCell(string title, int imageIndex)
        {
            KiwiWorkspaceCell cell = new KiwiWorkspaceCell();
            cell.Pages.Add(CreatePage(title, imageIndex));
            return cell;
        }

        private KiwiWorkspaceCell CreateCell(string title1, int imageIndex1,
                                                string title2, int imageIndex2)
        {
            KiwiWorkspaceCell cell = new KiwiWorkspaceCell();
            cell.Pages.Add(CreatePage(title1, imageIndex1));
            cell.Pages.Add(CreatePage(title2, imageIndex2));
            return cell;
        }

        private KiwiPage CreatePage(string title, int imageIndex)
        {
            // Create a new page and give it a name and image
            KiwiPage page = new KiwiPage();
            page.Text = title;
            page.TextTitle = title + " Title";
            page.TextDescription = title + " Description";
            page.ImageSmall = imageList.Images[imageIndex];
            page.Tag = imageIndex.ToString();

            // Create a rich text box with some sample text inside
            KiwiRichTextBox rtb = new KiwiRichTextBox();
            rtb.Text = "This page (" + page.Text + ") contains a rich text box control as example content.";
            rtb.Dock = DockStyle.Fill;
            rtb.StateCommon.Border.Draw = InheritBool.False;

            // Add rich text box as the contents of the page
            page.Padding = new Padding(5);
            page.Controls.Add(rtb);

            return page;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
