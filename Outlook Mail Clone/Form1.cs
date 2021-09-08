using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Outlook_Mail_Clone
{
    public partial class Form1 : KiwiForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void formatPlainText_Click(object sender, EventArgs e)
        {
            // If it has become checked, then ensure other options are no
            // longer in the checked state. If we are clicked to make unchecked
            // then override that behavior by forcing outself back to checked.
            if (formatPlainText.Checked)
            {
                formatHTML.Checked = false;
                formatRichText.Checked = false;
            }
            else
                formatPlainText.Checked = true;
        }

        private void formatHTML_Click(object sender, EventArgs e)
        {
            // If it has become checked, then ensure other options are no
            // longer in the checked state. If we are clicked to make unchecked
            // then override that behavior by forcing outself back to checked.
            if (formatHTML.Checked)
            {
                formatPlainText.Checked = false;
                formatRichText.Checked = false;
            }
            else
                formatHTML.Checked = true;
        }

        private void formatRichText_Click(object sender, EventArgs e)
        {
            // If it has become checked, then ensure other options are no
            // longer in the checked state. If we are clicked to make unchecked
            // then override that behavior by forcing outself back to checked.
            if (formatRichText.Checked)
            {
                formatPlainText.Checked = false;
                formatHTML.Checked = false;
            }
            else
                formatRichText.Checked = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
