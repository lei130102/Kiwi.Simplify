using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Standard_Docking
{
    public partial class ContentDocument : UserControl
    {
        public ContentDocument()
        {
            InitializeComponent();
        }

        private void ContentDocument_Load(object sender, EventArgs e)
        {
            Console.WriteLine("ContentDocument_Load");
        }
    }
}
