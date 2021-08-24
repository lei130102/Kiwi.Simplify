using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Storage for palette ribbon group label text states.
    /// </summary>
    public class KiwiPaletteRibbonGroupLabelText : KiwiPaletteRibbonGroupBaseText
    {
        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiPaletteRibbonGroupLabelText class.
		/// </summary>
        /// <param name="redirect">Redirector to inherit values from.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public KiwiPaletteRibbonGroupLabelText(PaletteRedirect redirect,
                                                  NeedPaintHandler needPaint)
            : base(redirect, PaletteRibbonTextStyle.RibbonGroupLabelText, needPaint)
        {
        }
        #endregion
    }
}
