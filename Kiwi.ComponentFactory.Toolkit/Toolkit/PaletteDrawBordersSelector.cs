using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Toolkit
{
    [ToolboxItem(false)]
    internal partial class PaletteDrawBordersSelector : UserControl
    {
        /// <summary>
        /// Initialize a new instance of the PaletteDrawBordersSelector class.
        /// </summary>
        public PaletteDrawBordersSelector()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets and sets the value being edited.
        /// </summary>
        public PaletteDrawBorders Value
        {
            get
            {
                PaletteDrawBorders ret = PaletteDrawBorders.None;

                if (checkBoxInherit.Checked)
                    ret = PaletteDrawBorders.Inherit;
                else
                {
                    if (checkBoxTop.Checked)
                        ret |= PaletteDrawBorders.Top;

                    if (checkBoxBottom.Checked)
                        ret |= PaletteDrawBorders.Bottom;

                    if (checkBoxLeft.Checked)
                        ret |= PaletteDrawBorders.Left;

                    if (checkBoxRight.Checked)
                        ret |= PaletteDrawBorders.Right;
                }

                return ret;
            }

            set
            {
                if ((value & PaletteDrawBorders.Inherit) == PaletteDrawBorders.Inherit)
                    checkBoxInherit.Checked = true;
                else
                {
                    if ((value & PaletteDrawBorders.Top) == PaletteDrawBorders.Top)
                        checkBoxTop.Checked = true;

                    if ((value & PaletteDrawBorders.Bottom) == PaletteDrawBorders.Bottom)
                        checkBoxBottom.Checked = true;

                    if ((value & PaletteDrawBorders.Left) == PaletteDrawBorders.Left)
                        checkBoxLeft.Checked = true;

                    if ((value & PaletteDrawBorders.Right) == PaletteDrawBorders.Right)
                        checkBoxRight.Checked = true;
                }
            }
        }

        private void checkBoxInherit_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxTop.Enabled = checkBoxBottom.Enabled = !checkBoxInherit.Checked;
            checkBoxLeft.Enabled = checkBoxRight.Enabled = !checkBoxInherit.Checked;
        }
    }
}
