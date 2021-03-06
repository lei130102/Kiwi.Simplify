using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Ribbon
{
    internal class ApplicationTabToContent : RibbonToContent
    {
        #region Instance Fields
        private KiwiRibbon _ribbon;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ApplicationTabToContent class.
        /// </summary>
        /// <param name="ribbon">Reference to owning ribbon control..</param>
        /// <param name="ribbonGeneral">Source for general ribbon settings.</param>
        public ApplicationTabToContent(KiwiRibbon ribbon,
                                       PaletteRibbonGeneral ribbonGeneral)
            : base(ribbonGeneral)
        {
            _ribbon = ribbon;
        }
        #endregion

        #region IPaletteContent
        /// <summary>
        /// Gets the first color for the short text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Color value.</returns>
        public override Color GetContentShortTextColor1(PaletteState state)
        {
            return _ribbon.RibbonAppButton.AppButtonTextColor;
        }

        /// <summary>
        /// Gets the second color for the short text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Color value.</returns>
        public override Color GetContentShortTextColor2(PaletteState state)
        {
            return _ribbon.RibbonAppButton.AppButtonTextColor;
        }

        /// <summary>
        /// Gets the first color for the long text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Color value.</returns>
        public override Color GetContentLongTextColor1(PaletteState state)
        {
            return _ribbon.RibbonAppButton.AppButtonTextColor;
        }

        /// <summary>
        /// Gets the second color for the long text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Color value.</returns>
        public override Color GetContentLongTextColor2(PaletteState state)
        {
            return _ribbon.RibbonAppButton.AppButtonTextColor;
        }
        #endregion
    }
}
