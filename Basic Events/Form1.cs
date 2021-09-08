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

namespace Basic_Events
{
    public partial class Form1 : Form
    {
        private int _count = 3;

        public Form1()
        {
            InitializeComponent();

            // Monitor changes in the pages collection
            kiwiNavigator1.Pages.Inserted += new TypedHandler<KiwiPage>(OnPageInsertRemove);
            kiwiNavigator1.Pages.Removed += new TypedHandler<KiwiPage>(OnPageInsertRemove);
            kiwiNavigator1.Pages.Cleared += new EventHandler(OnPagesCleared);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set initial state of the buttons
            UpdateButtonState();
        }

        private void kiwiButtonAdd_Click(object sender, EventArgs e)
        {
            // Create a new kiwi page
            KiwiPage newPage = new KiwiPage();

            // Populate with text and image
            newPage.Text = "Page " + _count.ToString();
            newPage.TextTitle = "Page " + _count.ToString() + " Title";
            newPage.TextDescription = "Page " + _count.ToString() + " Description";
            newPage.ImageSmall = imageList1.Images[_count % imageList1.Images.Count];
            _count++;

            // Append to end of the pages collection
            kiwiNavigator1.Pages.Add(newPage);

            // Select the new page
            kiwiNavigator1.SelectedPage = newPage;
        }

        private void kiwiButtonRemove_Click(object sender, EventArgs e)
        {
            kiwiNavigator1.Pages.Remove(kiwiNavigator1.SelectedPage);
        }

        private void kiwiButtonClear_Click(object sender, EventArgs e)
        {
            kiwiNavigator1.Pages.Clear();
        }

        private void kiwiButtonEnable_Click(object sender, EventArgs e)
        {
            kiwiNavigator1.SelectedPage.Enabled = !kiwiNavigator1.SelectedPage.Enabled;
            UpdateButtonState();
        }

        void OnPagesCleared(object sender, EventArgs e)
        {
            UpdateButtonState();
        }

        void OnPageInsertRemove(object sender, TypedCollectionEventArgs<KiwiPage> e)
        {
            UpdateButtonState();
        }

        private void UpdateButtonState()
        {
            // Can only remove if a page is selected
            kiwiButtonRemove.Enabled = (kiwiNavigator1.SelectedPage != null);

            // Can only clear if there is at least one page in collection
            kiwiButtonClear.Enabled = (kiwiNavigator1.Pages.Count > 0);

            // Can only change enabled state if a button is selected
            kiwiButtonEnable.Enabled = (kiwiNavigator1.SelectedPage != null);

            // Only update the enabled button text if the button is itself enabled
            if (kiwiButtonEnable.Enabled)
            {
                // Give text to indicate the enabled state will be toggled
                if (kiwiNavigator1.SelectedPage.Enabled)
                    kiwiButtonEnable.Text = "Disable";
                else
                    kiwiButtonEnable.Text = "Enable";
            }
        }

        private void kiwiNavigator1_Deselected(object sender, KiwiPageEventArgs e)
        {
            AddOutput("Deselected \t\t '" + e.Item.Text + "'");
        }

        private void kiwiNavigator1_Deselecting(object sender, KiwiPageCancelEventArgs e)
        {
            AddOutput("Deselecting \t\t '" + e.Item.Text + "'");
        }

        private void kiwiNavigator1_Selected(object sender, KiwiPageEventArgs e)
        {
            AddOutput("Selected \t\t '" + e.Item.Text + "'");
        }

        private void kiwiNavigator1_Selecting(object sender, KiwiPageCancelEventArgs e)
        {
            AddOutput("Selecting \t\t '" + e.Item.Text + "'");
        }

        private void kiwiNavigator1_SelectedPageChanged(object sender, EventArgs e)
        {
            if (kiwiNavigator1.SelectedPage == null)
                AddOutput("SelectedPageChanged \t (null)");
            else
                AddOutput("SelectedPageChanged \t '" + kiwiNavigator1.SelectedPage.Text + "'");

            UpdateButtonState();
        }

        private void kiwiNavigator1_CloseAction(object sender, CloseActionEventArgs e)
        {
            AddOutput("CloseAction");
        }

        private void kiwiNavigator1_ContextAction(object sender, ContextActionEventArgs e)
        {
            AddOutput("ContextAction");
        }

        private void kiwiNavigator1_NextAction(object sender, DirectionActionEventArgs e)
        {
            AddOutput("NextAction");
        }

        private void kiwiNavigator1_PreviousAction(object sender, DirectionActionEventArgs e)
        {
            AddOutput("PreviousAction");
        }

        private void buttonClearEventList_Click(object sender, EventArgs e)
        {
            listBoxEvents.Items.Clear();
        }

        private void AddOutput(string output)
        {
            listBoxEvents.Items.Add(output);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
