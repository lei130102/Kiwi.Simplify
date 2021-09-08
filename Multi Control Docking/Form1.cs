using Kiwi.ComponentFactory.Docking;
using Kiwi.ComponentFactory.Navigator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Multi_Control_Docking
{
    public partial class Form1 : Form
    {
        private int _count = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private KiwiPage NewInput()
        {
            return NewPage("Input ", 1, new ContentInput());
        }

        private KiwiPage NewPage(string name, int image, Control content)
        {
            // Create new page with title and image
            KiwiPage p = new KiwiPage();
            p.Text = name + _count.ToString();
            p.TextTitle = name + _count.ToString();
            p.TextDescription = name + _count.ToString();
            p.ImageSmall = imageListSmall.Images[image];

            // Add the control for display inside the page
            content.Dock = DockStyle.Fill;
            p.Controls.Add(content);

            _count++;
            return p;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add docking to the two panels and allow floating windows
            kiwiDockingManager.ManageControl("Control1", kiwiPanel2);
            kiwiDockingManager.ManageControl("Control2", kiwiPanel3);
            kiwiDockingManager.ManageFloating(this);


            // Add docking pages
            kiwiDockingManager.AddDockspace("Control1", DockingEdge.Left, new KiwiPage[] { NewInput(), NewInput() });
            kiwiDockingManager.AddDockspace("Control1", DockingEdge.Bottom, new KiwiPage[] { NewInput(), NewInput() });
            kiwiDockingManager.AddDockspace("Control2", DockingEdge.Bottom, new KiwiPage[] { NewInput(), NewInput() });
            kiwiDockingManager.AddAutoHiddenGroup("Control2", DockingEdge.Right, new KiwiPage[] { NewInput(), NewInput() });
        }
    }
}
