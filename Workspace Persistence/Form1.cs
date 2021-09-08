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

namespace Workspace_Persistence
{
    public partial class Form1 : Form
    {
        private int _count = 1;
        private byte[] _byteArray;

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

        private void bSaveToArray_Click(object sender, EventArgs e)
        {
            _byteArray = kiwiWorkspace.SaveLayoutToArray();
            bLoadFromArray.Enabled = true;
        }

        private void bLoadFromArray_Click(object sender, EventArgs e)
        {
            kiwiWorkspace.LoadLayoutFromArray(_byteArray);
        }

        private void bSaveToFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                kiwiWorkspace.SaveLayoutToFile(saveFileDialog.FileName);
        }

        private void bLoadFromFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    kiwiWorkspace.LoadLayoutFromFile(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Loading from File");
                }
            }
        }

        private void kiwiWorkspace_PageSaving(object sender, PageSavingEventArgs e)
        {
            // Get access to the text box inside the page
            KiwiRichTextBox rtb = (KiwiRichTextBox)e.Page.Controls[0];

            // Save the text in the textbox into the per-page storage
            e.XmlWriter.WriteCData(rtb.Text);
        }

        private void kiwiWorkspace_PageLoading(object sender, PageLoadingEventArgs e)
        {
            KiwiRichTextBox rtb;

            // If a new page then it does not have any children...
            if (e.Page.Controls.Count == 0)
            {
                // Add a rich text box as the child of the page
                rtb = new KiwiRichTextBox();
                rtb.Dock = DockStyle.Fill;
                rtb.StateCommon.Border.Draw = InheritBool.False;
                e.Page.Controls.Add(rtb);
                e.Page.Padding = new Padding(5);
            }
            else
                rtb = (KiwiRichTextBox)e.Page.Controls[0];

            // Move past the current xml element to the child CData
            e.XmlReader.Read();

            // Read in the stored text and use it in the rich text box
            rtb.Text = e.XmlReader.ReadContentAsString();
        }

        private void kiwiWorkspace_RecreateLoadingPage(object sender, RecreateLoadingPageEventArgs e)
        {
            e.Page = new KiwiPage();
        }

        private void kiwiWorkspace_PagesUnmatched(object sender, PagesUnmatchedEventArgs e)
        {
            foreach (KiwiPage page in e.Unmatched)
                Console.WriteLine("Unmatched Page {0}", page.Text);
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
            rtb.Text = "This page (" + page.Text + ") contains a rich text box control as example content.\n\nTry saving the layout and then dragging the page headers in order to rearrange the workspace layout. Once altered you can use the load button to get back to the original state.";
            rtb.Dock = DockStyle.Fill;
            rtb.StateCommon.Border.Draw = InheritBool.False;

            // Add rich text box as the contents of the page
            page.Padding = new Padding(5);
            page.Controls.Add(rtb);

            return page;
        }
    }
}
