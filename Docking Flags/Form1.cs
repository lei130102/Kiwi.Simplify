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

namespace Docking_Flags
{
    public partial class Form1 : KiwiForm
    {
        private int _count = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private KiwiPage NewDocument()
        {
            // Create new page with title and image
            KiwiPage p = new KiwiPage();
            p.Text = "Document " + _count.ToString();
            p.TextTitle = p.Text;
            p.TextDescription = p.Text;
            p.UniqueName = p.Text;
            p.ImageSmall = imageListSmall.Images[0];

            // Add the control for display inside the page
            ContentDocument contentDoc = new ContentDocument();
            contentDoc.Dock = DockStyle.Fill;
            p.Controls.Add(contentDoc);

            _count++;
            return p;
        }

        private KiwiPage NewFlags()
        {
            // Create new page with title and image
            KiwiPage p = new KiwiPage();
            p.Text = "Flags " + _count.ToString();
            p.TextTitle = p.Text;
            p.TextDescription = p.Text;
            p.UniqueName = p.Text;
            p.ImageSmall = imageListSmall.Images[1];

            // Add the control for display inside the page
            ContentFlags contentFlags = new ContentFlags(p);
            contentFlags.Dock = DockStyle.Fill;
            p.Controls.Add(contentFlags);

            _count++;
            return p;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Setup docking functionality
            KiwiDockingWorkspace w = kiwiDockingManager.ManageWorkspace(kiwiDockableWorkspace);
            kiwiDockingManager.ManageControl(kiwiPanel, w);
            kiwiDockingManager.ManageFloating(this);

            // Add docking pages
            kiwiDockingManager.AddDockspace("Control", DockingEdge.Left, new KiwiPage[] { NewFlags(), NewFlags() });
            kiwiDockingManager.AddDockspace("Control", DockingEdge.Bottom, new KiwiPage[] { NewDocument() });
            kiwiDockingManager.AddToWorkspace("Workspace", new KiwiPage[] { NewFlags(), NewFlags() });
        }
    }
}
