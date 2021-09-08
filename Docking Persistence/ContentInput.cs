using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Docking_Persistence
{
    public partial class ContentInput : UserControl
    {
        public ContentInput()
        {
            InitializeComponent();
        }

        private void kiwiPanel_MouseDown(object sender, MouseEventArgs e)
        {
            // Only interested in left mouse down
            if (e.Button == MouseButtons.Left)
            {
                // If the content does not have the focus then give it focus now
                if (!ContainsFocus)
                    kiwiPanel.SelectNextControl(this, true, true, true, false);
            }
        }
    }
}
