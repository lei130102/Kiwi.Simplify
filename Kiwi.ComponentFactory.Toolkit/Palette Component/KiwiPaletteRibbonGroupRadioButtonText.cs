using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Storage for palette ribbon group radio button text states.
    /// </summary>
    public class KiwiPaletteRibbonGroupRadioButtonText : KiwiPaletteRibbonGroupBaseText
    {
        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiPaletteRibbonGroupRadioButtonText class.
		/// </summary>
        /// <param name="redirect">Redirector to inherit values from.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public KiwiPaletteRibbonGroupRadioButtonText(PaletteRedirect redirect,
                                                        NeedPaintHandler needPaint)
            : base(redirect, PaletteRibbonTextStyle.RibbonGroupRadioButtonText, needPaint)
        {
        }
        #endregion
    }
}
