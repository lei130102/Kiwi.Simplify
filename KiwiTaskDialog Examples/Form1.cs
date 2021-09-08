using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KiwiTaskDialog_Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxIcon.Text = "Information";
            comboBoxFooterIcon.Text = "Warning";
        }

        private void palette2010Blue_CheckedChanged(object sender, EventArgs e)
        {
            kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
        }

        private void palette2010Silver_CheckedChanged(object sender, EventArgs e)
        {
            kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2010Silver;
        }

        private void palette2010Black_CheckedChanged(object sender, EventArgs e)
        {
            kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2010Black;
        }

        private void palette2007Blue_CheckedChanged(object sender, EventArgs e)
        {
            kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
        }

        private void paletteSparkleOrange_CheckedChanged(object sender, EventArgs e)
        {
            kiwiManager.GlobalPaletteMode = PaletteModeManager.SparkleOrange;
        }

        private void paletteProfessional_CheckedChanged(object sender, EventArgs e)
        {
            kiwiManager.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
        }

        private void buttonShowTaskDialog_Click(object sender, EventArgs e)
        {
            TaskDialogButtons commonButtons = TaskDialogButtons.None;
            if (checkBoxOK.Checked) commonButtons |= TaskDialogButtons.OK;
            if (checkBoxYes.Checked) commonButtons |= TaskDialogButtons.Yes;
            if (checkBoxNo.Checked) commonButtons |= TaskDialogButtons.No;
            if (checkBoxCancel.Checked) commonButtons |= TaskDialogButtons.Cancel;
            if (checkBoxClose.Checked) commonButtons |= TaskDialogButtons.Close;
            if (checkBoxRetry.Checked) commonButtons |= TaskDialogButtons.Retry;

            kiwiTaskDialog.RadioButtons.Clear();
            if (checkBoxRadioButtons.Checked)
                kiwiTaskDialog.RadioButtons.AddRange(new KiwiTaskDialogCommand[] { kiwiTaskDialogCommand1, kiwiTaskDialogCommand2, kiwiTaskDialogCommand3 });

            kiwiTaskDialog.CommandButtons.Clear();
            if (checkBoxCommandButtons.Checked)
                kiwiTaskDialog.CommandButtons.AddRange(new KiwiTaskDialogCommand[] { kiwiTaskDialogCommand4, kiwiTaskDialogCommand5, kiwiTaskDialogCommand6 });

            kiwiTaskDialog.WindowTitle = textBoxCaption.Text;
            kiwiTaskDialog.MainInstruction = textBoxMainInstructions.Text;
            kiwiTaskDialog.Content = textBoxContent.Text;
            kiwiTaskDialog.Icon = (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), comboBoxIcon.Text);
            kiwiTaskDialog.CommonButtons = commonButtons;
            kiwiTaskDialog.CheckboxText = textBoxCheckBoxText.Text;
            kiwiTaskDialog.CheckboxState = checkBoxInitialState.Checked;
            kiwiTaskDialog.FooterText = textBoxFooterText.Text;
            kiwiTaskDialog.FooterHyperlink = textBoxFooterHyperlink.Text;
            kiwiTaskDialog.FooterIcon = (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), comboBoxFooterIcon.Text);
            kiwiTaskDialog.ShowDialog(this);
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            var s = "The quick brown fox jumps over the lazy dog";
            var e1 = new Random().Next(50, 400);
            var sb = new StringBuilder().Append(s);
            for (var i = 0; i < e1; ++i)
            {
                sb.AppendFormat("\r\n\r\n{0}", s);
                if (i % 10 == 0)
                {
                    var e2 = new Random().Next(1, 10);
                    for (var j = 0; j < e2; ++j)
                        sb.AppendFormat(". {0}", s);
                    sb.Append("\r\n");
                }
            }
            textBoxContent.Text = sb.ToString();
        }
    }
}
