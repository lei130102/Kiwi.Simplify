using Kiwi.ComponentFactory.Navigator;
using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Outlook_Mockup
{
    public partial class Form1 : KiwiForm
    {
        // Cache the full expanded size of the outlook navigator
        private int _widthLeftRight;

        // Set of fake notes entries
        private object[] _notes = new object[]{ new string[] { "Bug Reports v1.2", "Featuer Requests v1.3", "Wish List" },
                                                new string[] { "Xmas List", "Birthday Dates" },
                                                new string[] { "Season Schedule", "Party Invites", "Jokes", "Diary" } };


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Populate the different data table
            dtDrafts.Rows.Add("Ray Clemence", "Need to improve handling", "Mon 02/09/2006", "10 KB");
            dtDrafts.Rows.Add("Garth Crooks", "Excellent team performance", "Tue 03/09/2006", "5 KB");
            dtDrafts.Rows.Add("Peter Shilten", "Good defence is important", "Wed 04/09/2006", "21 KB");
            dtDrafts.Rows.Add("Steve McClaren", "Nice work, keep it going", "Tue 05/09/2006", "11 KB");
            dtFamily.Rows.Add("John Smith", "Did you get my new pics?", "Mon 02/09/2006", "11 KB");
            dtFamily.Rows.Add("Mike Smith", "Remember to get Emma a present", "Mon 02/09/2006", "17 KB");
            dtFamily.Rows.Add("Susan Smith", "What did you get Emma?", "Tue 03/09/2006", "10 KB");
            dtFamily.Rows.Add("Emma Smith", "RE: Happy Birthday!", "Wed 04/09/2006", "6 KB");
            dtFamily.Rows.Add("Emma Smith", "Have you seen Dad recently?", "Thu 05/09/2006", "32 KB");
            dtFamily.Rows.Add("Percy Smith", "Great holiday, see you soon", "Thu 05/09/2006", "2 KB");
            dtFriends.Rows.Add("Dirk Huber", "Arsenal 0 - Liverpool 3 Nice!!", "Tue 03/09/2006", "2 KB");
            dtFriends.Rows.Add("Jimmy Jones", "Are you going to the big game?", "Wed 04/09/2006", "32 KB");
            dtFriends.Rows.Add("Nick Robinson", "Just noticed you have a blog", "Thu 05/09/2006", "2 KB");
            dtWork.Rows.Add("Your Boss", "Take the week off", "Wed 04/09/2006", "2 KB");
            dtOutbox.Rows.Add("Wayne Rooney", "Need to control your emotions", "Thu 01/09/2006", "17 KB");
            dtSentItems.Rows.Add("Sven Ericcson", "Poor managing performance", "Fri 07/09/2006", "5 KB");
            dtSentItems.Rows.Add("David Beckham", "You have been dropped", "Thu 05/09/2006", "12 KB");

            // Set the initial main and detail pages
            kiwiNavigatorMain.SelectedIndex = 0;
            kiwiNavigatorDetails.SelectedIndex = 0;

            // Start with all folders expanded
            treeViewMailFolders.ExpandAll();

            // Set initial focus to the tree view for mail
            treeViewMailFolders.Focus();
            treeViewMailFolders.SelectedNode = treeViewMailFolders.Nodes[2].Nodes[0];

            // Set the initial set of notes entries
            radioNotes_CheckedChanged(radioProject, EventArgs.Empty);
        }

        private void buttonSpecExpandCollapse_Click(object sender, EventArgs e)
        {
            kiwiSplitContainerMain.SuspendLayout();
            kiwiNavigatorMain.SuspendLayout();

            // Is the navigator currently in full mode?
            if (kiwiNavigatorMain.NavigatorMode == NavigatorMode.OutlookFull)
            {
                // Make the left panel of the splitter fixed in size
                kiwiSplitContainerMain.FixedPanel = FixedPanel.Panel1;
                kiwiSplitContainerMain.IsSplitterFixed = true;

                // Remember the current height of the header group
                _widthLeftRight = kiwiNavigatorMain.Width;

                // Switch to the mini mode
                kiwiNavigatorMain.NavigatorMode = NavigatorMode.OutlookMini;

                // Discover the new width required to display the mini mode
                int newWidth = kiwiNavigatorMain.PreferredSize.Width;

                // Make the header group fixed just as the new height
                kiwiSplitContainerMain.Panel1MinSize = newWidth;
                kiwiSplitContainerMain.SplitterDistance = newWidth;

                // Switch the arrow to point the opposite way
                buttonSpecExpandCollapse.TypeRestricted = PaletteNavButtonSpecStyle.ArrowRight;
            }
            else
            {
                // Switch to the full mode
                kiwiNavigatorMain.NavigatorMode = NavigatorMode.OutlookFull;

                // Make the bottom panel not-fixed in size anymore
                kiwiSplitContainerMain.FixedPanel = FixedPanel.None;
                kiwiSplitContainerMain.IsSplitterFixed = false;

                // Put back the minimum size to the original
                kiwiSplitContainerMain.Panel1MinSize = 100;

                // Calculate the correct splitter we want to put back
                kiwiSplitContainerMain.SplitterDistance = _widthLeftRight;

                // Switch the arrow to point the opposite way
                buttonSpecExpandCollapse.TypeRestricted = PaletteNavButtonSpecStyle.ArrowLeft;
            }

            kiwiSplitContainerMain.ResumeLayout();
            kiwiNavigatorMain.ResumeLayout();
        }


        private void kiwiNavigatorMain_SelectedPageChanged(object sender, EventArgs e)
        {
            // Update the details page to match the main pages
            kiwiNavigatorDetails.SelectedIndex = kiwiNavigatorMain.SelectedIndex;
        }

        private void treeViewMail_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Remove selection from the other tree
            if (sender == treeViewMailFavs)
                treeViewMailFolders.SelectedNode = null;
            else
                treeViewMailFavs.SelectedNode = null;

            // Cast event source to the correct type
            TreeView tv = (TreeView)sender;

            // Update the mail heading entries
            if (tv.SelectedNode != null)
            {
                // Update the title to match the folder
                kiwiPageMailDetails.TextTitle = tv.SelectedNode.Text;

                // Set the data grid to show details from this table
                kiwiDataGridView1.DataSource = dataSet.Tables[tv.SelectedNode.Text];
            }
            else
            {
                // Update the title to a generic title
                kiwiPageMailDetails.TextTitle = "Mail";

                // Nothing selected so remove any source from the data grid
                kiwiDataGridView1.DataSource = null;
            }
        }

        private void radioNotes_CheckedChanged(object sender, EventArgs e)
        {
            int index = 0;

            // Find index of note names
            if (radioFamily.Checked)
                index = 1;
            else if (radioFriends.Checked)
                index = 2;

            // Remove all existing notes
            listViewNotes.Items.Clear();

            // Get the set of strings that contain the note names
            string[] group = (string[])_notes[index];

            // Add each mail entry as an item
            foreach (string entry in group)
                listViewNotes.Items.Add(new ListViewItem(entry, 0));
        }

        private void radioOffice2010Blue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOffice2010Blue.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
        }

        private void radioOffice2010Silver_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOffice2010Silver.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2010Silver;
        }

        private void radioOffice2010Black_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOffice2010Black.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2010Black;
        }

        private void radioOffice2007Blue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOffice2007Blue.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
        }

        private void radioOffice2007Silver_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOffice2007Silver.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2007Silver;
        }

        private void radioOffice2007Black_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOffice2007Black.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2007Black;
        }

        private void radioOffice2003_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOffice2003.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.ProfessionalOffice2003;
        }

        private void radioSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSystem.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
        }

        private void radioSparkle_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSparkle.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
        }
    }
}
