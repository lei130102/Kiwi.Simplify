using Kiwi.ComponentFactory.Navigator;
using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Expanding_Pages
{
    public partial class Form1 : KiwiForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTopArrow_Click(object sender, EventArgs e)
        {
            // For the top navigator instance we will toggle the showing of 
            // the client area below the check button area. We also toggle 
            // the direction of the button spec arrow.

            if (navigatorTop.NavigatorMode == NavigatorMode.HeaderBarCheckButtonGroup)
            {
                navigatorTop.NavigatorMode = NavigatorMode.HeaderBarCheckButtonOnly;
                buttonTopArrow.TypeRestricted = PaletteNavButtonSpecStyle.ArrowDown;
            }
            else
            {
                navigatorTop.NavigatorMode = NavigatorMode.HeaderBarCheckButtonGroup;
                buttonTopArrow.TypeRestricted = PaletteNavButtonSpecStyle.ArrowUp;
            }
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            // For the left navigator instance we will toggle the showing of 
            // the client area to the right of the check button area. We also 
            // toggle the direction of the button spec arrow.

            if (navigatorLeft.NavigatorMode == NavigatorMode.HeaderBarCheckButtonGroup)
            {
                navigatorLeft.NavigatorMode = NavigatorMode.HeaderBarCheckButtonOnly;
                buttonLeft.TypeRestricted = PaletteNavButtonSpecStyle.ArrowRight;
            }
            else
            {
                navigatorLeft.NavigatorMode = NavigatorMode.HeaderBarCheckButtonGroup;
                buttonLeft.TypeRestricted = PaletteNavButtonSpecStyle.ArrowLeft;
            }
        }

        private void kiwiPaletteButtons_Click(object sender, EventArgs e)
        {
            // When the user presses one of the palette buttons we need to ensure
            // that if the containing page is showing as a popup that the popup
            // is then removed from display. So call DismissPopupPage to remove
            // the page from view. If the page is not showing as a popup then
            // the call does nothing.
            navigatorLeft.DismissPopups();
        }

        private void kiwiPalettes_CheckedButtonChanged(object sender, EventArgs e)
        {
            // Change the palette depending on the selected button
            switch (kiwiPalettes.CheckedIndex)
            {
                case 0:
                    kiwiManager1.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
                    break;
                case 1:
                    kiwiManager1.GlobalPaletteMode = PaletteModeManager.Office2007Silver;
                    break;
                case 2:
                    kiwiManager1.GlobalPaletteMode = PaletteModeManager.Office2007Black;
                    break;
                case 3:
                    kiwiManager1.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
                    break;
                case 4:
                    kiwiManager1.GlobalPaletteMode = PaletteModeManager.ProfessionalOffice2003;
                    break;
                case 5:
                    kiwiManager1.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
                    break;
                case 6:
                    kiwiManager1.GlobalPaletteMode = PaletteModeManager.Office2010Black;
                    break;
                case 7:
                    kiwiManager1.GlobalPaletteMode = PaletteModeManager.Office2010Silver;
                    break;
                case 8:
                    kiwiManager1.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
                    break;

            }
        }
    }
}
