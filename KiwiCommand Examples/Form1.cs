using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KiwiCommand_Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAttach_Click(object sender, EventArgs e)
        {
            AssignCommand(kiwiCommand);
        }

        private void buttonUnattach_Click(object sender, EventArgs e)
        {
            AssignCommand(null);
        }

        private void AssignCommand(KiwiCommand command)
        {
            buttonSpecAny1.KiwiCommand = command;
            kiwiButton1.KiwiCommand = command;
            kiwiCheckButton1.KiwiCommand = command;
            kiwiDropButton1.KiwiCommand = command;
            kiwiColorButton1.KiwiCommand = command;
            kiwiLabel1.KiwiCommand = command;
            kiwiLinkLabel1.KiwiCommand = command;
            kiwiCheckBox1.KiwiCommand = command;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
