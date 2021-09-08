using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KiwiMessageBox_Examples
{
    public partial class Form1 : Form
    {
        private MessageBoxIcon _mbIcon = MessageBoxIcon.Warning;
        private MessageBoxButtons _mbButtons = MessageBoxButtons.OKCancel;

        public Form1()
        {
            InitializeComponent();
        }

        private void palette_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOffice2010Blue.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
            else if (radioButtonOffice2010Silver.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2010Silver;
            else if (radioButtonOffice2010Black.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2010Black;
            else if (radioButtonOffice2007Blue.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
            else if (radioButtonOffice2007Silver.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2007Silver;
            else if (radioButtonOffice2007Black.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2007Black;
            else if (radioButtonSparkleBlue.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
            else if (radioButtonSparkleOrange.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.SparkleOrange;
            else if (radioButtonSparklePurple.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.SparklePurple;
            else if (radioButtonOffice2003.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.ProfessionalOffice2003;
            else if (radioButtonSystem.Checked)
                kiwiManager.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
        }

        private void icon_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNone.Checked)
                _mbIcon = MessageBoxIcon.None;
            else if (radioButtonError.Checked)
                _mbIcon = MessageBoxIcon.Error;
            else if (radioButtonQuestion.Checked)
                _mbIcon = MessageBoxIcon.Question;
            else if (radioButtonWarning.Checked)
                _mbIcon = MessageBoxIcon.Warning;
            else if (radioButtonInformation.Checked)
                _mbIcon = MessageBoxIcon.Information;
        }

        private void buttons_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOK.Checked)
                _mbButtons = MessageBoxButtons.OK;
            else if (radioButtonOKCancel.Checked)
                _mbButtons = MessageBoxButtons.OKCancel;
            else if (radioButtonRetryCancel.Checked)
                _mbButtons = MessageBoxButtons.RetryCancel;
            else if (radioButtonAbortRetryIgnore.Checked)
                _mbButtons = MessageBoxButtons.AbortRetryIgnore;
            else if (radioButtonYesNo.Checked)
                _mbButtons = MessageBoxButtons.YesNo;
            else if (radioButtonYesNoCancel.Checked)
                _mbButtons = MessageBoxButtons.YesNoCancel;
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            KiwiMessageBox.Show(textBoxMessage.Text, textBoxCaption.Text, _mbButtons, _mbIcon);
        }
    }
}
