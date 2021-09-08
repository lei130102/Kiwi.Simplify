using Kiwi.ComponentFactory.Docking;
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

namespace Navigator___FloatingWindows
{
    public partial class Form1 : KiwiForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int _count = 1;
        private KiwiPage NewPage(string name, int image, Control content)
        {
            // Create new page with title and image
            KiwiPage p = new KiwiPage();
            p.Text = name + _count.ToString();
            p.TextTitle = name + _count.ToString();
            p.TextDescription = name + _count.ToString();
            p.UniqueName = p.Text;
            p.ImageSmall = imageListSmall.Images[image];

            // Add the control for display inside the page
            content.Dock = DockStyle.Fill;
            p.Controls.Add(content);

            _count++;
            return p;
        }

        private KiwiPage NewDocument()
        {
            KiwiPage page = NewPage("Document ", 0, new ContentDocument());

            // Do not allow the document pages to be closed or made auto hidden/docked
            page.ClearFlags(KiwiPageFlags.DockingAllowAutoHidden |
                            KiwiPageFlags.DockingAllowDocked |
                            KiwiPageFlags.DockingAllowClose);

            return page;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Setup docking functionality
            KiwiDockingNavigator n = kiwiDockingManager.ManageNavigator(kiwiDockableNavigator);
            kiwiDockingManager.ManageFloating(this);

            // Add initial floating window and navigator documents
            kiwiDockingManager.AddFloatingWindow("Floating", new KiwiPage[] { NewDocument(), NewDocument() });
            kiwiDockingManager.AddToNavigator("Navigator", new KiwiPage[] { NewDocument(), NewDocument(), NewDocument() });
        }
    }
}
