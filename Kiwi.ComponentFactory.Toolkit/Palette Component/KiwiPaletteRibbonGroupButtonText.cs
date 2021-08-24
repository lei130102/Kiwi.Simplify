using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Storage for palette ribbon group button text states.
    /// </summary>
    public class KiwiPaletteRibbonGroupButtonText : KiwiPaletteRibbonGroupBaseText
    {
        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiPaletteRibbonGroupButtonText class.
		/// </summary>
        /// <param name="redirect">Redirector to inherit values from.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public KiwiPaletteRibbonGroupButtonText(PaletteRedirect redirect,
                                                   NeedPaintHandler needPaint)
            : base(redirect, PaletteRibbonTextStyle.RibbonGroupButtonText, needPaint)
        {
        }
        #endregion
    }
}
