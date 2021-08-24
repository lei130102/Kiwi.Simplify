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
    public class KiwiPaletteRibbonGroupCheckBoxText : KiwiPaletteRibbonGroupBaseText
    {
        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiPaletteRibbonGroupCheckBoxText class.
		/// </summary>
        /// <param name="redirect">Redirector to inherit values from.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public KiwiPaletteRibbonGroupCheckBoxText(PaletteRedirect redirect,
                                                     NeedPaintHandler needPaint)
            : base(redirect, PaletteRibbonTextStyle.RibbonGroupCheckBoxText, needPaint)
        {
        }
        #endregion
    }
}
