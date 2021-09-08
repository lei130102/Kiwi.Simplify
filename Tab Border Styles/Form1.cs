using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tab_Border_Styles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabBorderStyles_CheckedChanged(object sender, EventArgs e)
        {
            // Cast to correct type
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                TabBorderStyle enumVal = (TabBorderStyle)Enum.Parse(typeof(TabBorderStyle), rb.Tag.ToString());
                kiwiNavigator.Bar.TabBorderStyle = enumVal;
            }
        }

        private void tabStyles_CheckedChanged(object sender, EventArgs e)
        {
            // Cast to correct type
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                TabStyle enumVal = (TabStyle)Enum.Parse(typeof(TabStyle), rb.Tag.ToString());
                kiwiNavigator.Bar.TabStyle = enumVal;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
