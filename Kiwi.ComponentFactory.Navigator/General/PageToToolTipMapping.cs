using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Navigator
{
    /// <summary>
    /// Map tooltip values from a source page.
    /// </summary>
    internal class PageToToolTipMapping : IContentValues
    {
        #region Instance Fields
        private KiwiPage _page;
        private MapKiwiPageImage _mapImage;
        private MapKiwiPageText _mapText;
        private MapKiwiPageText _mapExtraText;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PageToToolTipMapping class.
        /// </summary>
        /// <param name="page">Page to source values from.</param>
        /// <param name="mapImage">How to map the image from the page to the tooltip.</param>
        /// <param name="mapText">How to map the text from the page to the tooltip.</param>
        /// <param name="mapExtraText">How to map the extra text from the page to the tooltip.</param>
        public PageToToolTipMapping(KiwiPage page,
                                    MapKiwiPageImage mapImage,
                                    MapKiwiPageText mapText,
                                    MapKiwiPageText mapExtraText)
        {
            Debug.Assert(page != null);

            _page = page;
            _mapImage = mapImage;
            _mapText = mapText;
            _mapExtraText = mapExtraText;
        }
        #endregion

        #region HasContent
        /// <summary>
        /// Gets a value indicating if the mapping produces any content.
        /// </summary>
        public bool HasContent
        {
            get
            {
                return (GetImage(PaletteState.Normal) != null) ||
                        !string.IsNullOrEmpty(GetShortText()) ||
                        !string.IsNullOrEmpty(GetLongText());
            }
        }
        #endregion

        #region IContentValues
        /// <summary>
        /// Gets the content image.
        /// </summary>
        /// <param name="state">The state for which the image is needed.</param>
        /// <returns>Image value.</returns>
        public Image GetImage(PaletteState state)
        {
            return _page.GetImageMapping(_mapImage);
        }

        /// <summary>
        /// Gets the image color that should be transparent.
        /// </summary>
        /// <param name="state">The state for which the image is needed.</param>
        /// <returns>Color value.</returns>
        public Color GetImageTransparentColor(PaletteState state)
        {
            return _page.ToolTipImageTransparentColor;
        }

        /// <summary>
        /// Gets the content short text.
        /// </summary>
        /// <returns>String value.</returns>
        public string GetShortText()
        {
            return _page.GetTextMapping(_mapText);
        }

        /// <summary>
        /// Gets the content long text.
        /// </summary>
        /// <returns>String value.</returns>
        public string GetLongText()
        {
            return _page.GetTextMapping(_mapExtraText);
        }
        #endregion
    }
}
