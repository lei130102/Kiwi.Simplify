using Kiwi.ComponentFactory.Ribbon;
using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quick_Access_Toolbar
{
    public partial class Form1 : KiwiForm
    {
        private int _count = 0;

        private Image[] _images = new Image[]{  global::Quick_Access_Toolbar.Properties.Resources.flag_australia,
                                                global::Quick_Access_Toolbar.Properties.Resources.flag_cameroon,
                                                global::Quick_Access_Toolbar.Properties.Resources.flag_canada,
                                                global::Quick_Access_Toolbar.Properties.Resources.flag_czech_republic,
                                                global::Quick_Access_Toolbar.Properties.Resources.flag_egypt,
                                                global::Quick_Access_Toolbar.Properties.Resources.flag_france,
                                                global::Quick_Access_Toolbar.Properties.Resources.flag_hong_kong,
                                                global::Quick_Access_Toolbar.Properties.Resources.flag_italy,
                                                global::Quick_Access_Toolbar.Properties.Resources.flag_lithuania,
                                                global::Quick_Access_Toolbar.Properties.Resources.flag_new_zealand,
                                                global::Quick_Access_Toolbar.Properties.Resources.flag_peru,
                                                global::Quick_Access_Toolbar.Properties.Resources.flag_wales  };

        private string[] _names = new string[]{ "Australia", "Cameroon", "Canada",
                                                "Czech Republic", "Egypt", "France",
                                                "Hong Kong", "Italy", "Lithuania",
                                                "New Zealand", "Peru", "Wales" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonAdd_Click(this, EventArgs.Empty);
            buttonAdd_Click(this, EventArgs.Empty);
            buttonAdd_Click(this, EventArgs.Empty);
        }

        private void checkSetQATPosition_CheckedButtonChanged(object sender, EventArgs e)
        {
            if (checkSetQATPosition.CheckedButton == checkButtonAbove)
                kiwiRibbon.QATLocation = QATLocation.Above;
            else if (checkSetQATPosition.CheckedButton == checkButtonBelow)
                kiwiRibbon.QATLocation = QATLocation.Below;
            else if (checkSetQATPosition.CheckedButton == checkButtonHidden)
                kiwiRibbon.QATLocation = QATLocation.Hidden;
        }

        private void checkSetQATUserChange_CheckedButtonChanged(object sender, EventArgs e)
        {
            if (checkSetQATUserChange.CheckedButton == checkButtonAllowUserChanges)
                kiwiRibbon.QATUserChange = true;
            else if (checkSetQATUserChange.CheckedButton == checkButtonDisallowUserChanges)
                kiwiRibbon.QATUserChange = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            KiwiRibbonQATButton qatButton = new KiwiRibbonQATButton();
            qatButton.Text = _names[_count];
            qatButton.Image = _images[_count];
            _count = (++_count % 12);
            kiwiRibbon.QATButtons.Add(qatButton);

            UpdateButtons();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (kiwiRibbon.QATButtons.Count > 0)
                kiwiRibbon.QATButtons.RemoveAt(0);

            UpdateButtons();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            kiwiRibbon.QATButtons.Clear();
            UpdateButtons();
        }

        private void UpdateButtons()
        {
            bool enable = (kiwiRibbon.QATButtons.Count > 0);
            buttonRemove.Enabled = enable;
            buttonClear.Enabled = enable;
        }

        private void appMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
