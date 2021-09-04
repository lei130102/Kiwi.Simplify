using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Ribbon
{
    /// <summary>
    /// Map group item tooltip values to content values.
    /// </summary>
    internal class GroupItemToolTipToContent : IContentValues
    {
        #region Instance Fields
        private KiwiRibbonGroupItem _groupItem;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the GroupItemToolTipToContent class.
        /// </summary>
        /// <param name="groupItem">Source ribbon group item.</param>
        public GroupItemToolTipToContent(KiwiRibbonGroupItem groupItem)
        {
            Debug.Assert(groupItem != null);
            _groupItem = groupItem;
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
            return _groupItem.InternalToolTipImage;
        }

        /// <summary>
        /// Gets the image color that should be transparent.
        /// </summary>
        /// <param name="state">The state for which the image is needed.</param>
        /// <returns>Color value.</returns>
        public Color GetImageTransparentColor(PaletteState state)
        {
            return _groupItem.InternalToolTipImageTransparentColor;
        }

        /// <summary>
        /// Gets the content short text.
        /// </summary>
        /// <returns>String value.</returns>
        public string GetShortText()
        {
            return _groupItem.InternalToolTipTitle;
        }

        /// <summary>
        /// Gets the content long text.
        /// </summary>
        /// <returns>String value.</returns>
        public string GetLongText()
        {
            return _groupItem.InternalToolTipBody;
        }
        #endregion
    }
}
