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

namespace External_Drag_To_Docking
{
    public partial class Form1 : KiwiForm
    {
        private int _count = 1;

        public Form1()
        {
            InitializeComponent();
        }

        public KiwiPage NewDocument()
        {
            return NewPage("Document ", 0, new ContentDocument());
        }

        public KiwiPage NewInput()
        {
            return NewPage("Input ", 1, new ContentInput());
        }

        public KiwiPage NewPropertyGrid()
        {
            return NewPage("Properties ", 2, new ContentPropertyGrid());
        }

        public KiwiPage NewTreeView()
        {
            return NewPage("TreeView ", 3, new ContentTreeView(this));
        }

        public KiwiPage NewPage(string name, int image, Control content)
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

        public KiwiDockingManager DockingManager
        {
            get { return kiwiDockingManager; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Setup docking functionality
            KiwiDockingWorkspace w = kiwiDockingManager.ManageWorkspace(kiwiDockableWorkspace);
            kiwiDockingManager.ManageControl(kiwiPanel, w);
            kiwiDockingManager.ManageFloating(this);

            // Add initial docking pages
            kiwiDockingManager.AddDockspace("Control", DockingEdge.Left, new KiwiPage[] { NewTreeView() });
            kiwiDockingManager.AddToWorkspace("Workspace", new KiwiPage[] { NewDocument() });
        }
    }
}
