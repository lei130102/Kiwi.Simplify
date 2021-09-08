using Kiwi.ComponentFactory.Navigator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Navigator_Context_Menus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kiwiNavigator1_ShowContextMenu(object sender, ShowContextMenuArgs e)
        {
            // Yes we want to show a context menu
            e.Cancel = false;

            // Provide the navigator specific menu
            e.KiwiContextMenu = kcmNavigator;

            // Only enable the appropriate options
            kcmFirst.Enabled = (kiwiNavigator1.SelectedIndex > 0);
            kcmPrevious.Enabled = (kiwiNavigator1.SelectedIndex > 0);
            kcmNext.Enabled = (kiwiNavigator1.SelectedIndex < (kiwiNavigator1.Pages.Count - 1));
            kcmLast.Enabled = (kiwiNavigator1.SelectedIndex < (kiwiNavigator1.Pages.Count - 1));
        }

        private void kcmFirst_Click(object sender, EventArgs e)
        {
            // Move the selected page to the start of the page list
            KiwiPage kp = kiwiNavigator1.SelectedPage;
            kiwiNavigator1.Pages.Remove(kp);
            kiwiNavigator1.Pages.Insert(0, kp);
            kiwiNavigator1.SelectedPage = kp;
        }

        private void kcmPrevious_Click(object sender, EventArgs e)
        {
            // Move the selected page to the previous place in the page list
            KiwiPage kp = kiwiNavigator1.SelectedPage;
            int index = kiwiNavigator1.SelectedIndex;
            kiwiNavigator1.Pages.Remove(kp);
            kiwiNavigator1.Pages.Insert(index - 1, kp);
            kiwiNavigator1.SelectedPage = kp;
        }

        private void kcmNext_Click(object sender, EventArgs e)
        {
            // Move the selected page to the next place in the list
            KiwiPage kp = kiwiNavigator1.SelectedPage;
            int index = kiwiNavigator1.SelectedIndex;
            kiwiNavigator1.Pages.Remove(kp);
            kiwiNavigator1.Pages.Insert(index + 1, kp);
            kiwiNavigator1.SelectedPage = kp;
        }

        private void kcmLast_Click(object sender, EventArgs e)
        {
            // Move the selected page to the end of the page list
            KiwiPage kp = kiwiNavigator1.SelectedPage;
            int index = kiwiNavigator1.SelectedIndex;
            kiwiNavigator1.Pages.Remove(kp);
            kiwiNavigator1.Pages.Add(kp);
            kiwiNavigator1.SelectedPage = kp;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
