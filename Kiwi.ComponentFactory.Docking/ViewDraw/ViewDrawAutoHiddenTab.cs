using Kiwi.ComponentFactory.Navigator;
using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
	/// View element that can draw an auto hidden tab based on a KiwiPage as the source.
	/// </summary>
    internal class ViewDrawAutoHiddenTab : ViewDrawButton,
                                           IContentValues
    {
        #region Instance Fields
        private KiwiPage _page;
        private VisualOrientation _orientation;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ViewDrawAutoHiddenTab class.
        /// </summary>
        /// <param name="page">Reference to the page this tab represents.</param>
        /// <param name="orientation">Visual orientation used for drawing the tab.</param>
        public ViewDrawAutoHiddenTab(KiwiPage page,
                                     VisualOrientation orientation)
            : base(page.StateDisabled.CheckButton,
                   page.StateNormal.CheckButton,
                   page.StateTracking.CheckButton,
                   page.StatePressed.CheckButton,
                   null, null, orientation, false)
        {
            _page = page;
            _orientation = orientation;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets access to the page associated with the view.
        /// </summary>
        public KiwiPage Page
        {
            get { return _page; }
        }
        #endregion

        #region Public IContentValues
        /// <summary>
        /// Gets the content image.
        /// </summary>
        /// <param name="state">The state for which the image is needed.</param>
        /// <returns>Image value.</returns>
        public Image GetImage(PaletteState state)
        {
            return _page.ImageSmall;
        }

        /// <summary>
        /// Gets the image color that should be transparent.
        /// </summary>
        /// <param name="state">The state for which the image is needed.</param>
        /// <returns>Color value.</returns>
        public Color GetImageTransparentColor(PaletteState state)
        {
            return Color.Empty;
        }

        /// <summary>
        /// Gets the content short text.
        /// </summary>
        /// <returns>String value.</returns>
        public string GetShortText()
        {
            return _page.Text;
        }

        /// <summary>
        /// Gets the content long text.
        /// </summary>
        /// <returns>String value.</returns>
        public string GetLongText()
        {
            return string.Empty;
        }
        #endregion
    }
}
