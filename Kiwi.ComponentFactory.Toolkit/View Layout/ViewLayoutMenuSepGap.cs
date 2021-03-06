using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Positions a separator to take up space without drawing.
    /// </summary>
    public class ViewLayoutMenuSepGap : ViewLayoutSeparator
    {
        #region Instance Fields
        private PaletteContextMenuRedirect _stateCommon;
        private bool _standardStyle;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ViewLayoutMenuSepGap class.
		/// </summary>
        /// <param name="stateCommon">Source of palette values.</param>
        /// <param name="standardStyle">Draw items with standard or alternate style.</param>
        public ViewLayoutMenuSepGap(PaletteContextMenuRedirect stateCommon,
                                    bool standardStyle)
            : base(0)
        {
            _stateCommon = stateCommon;
            _standardStyle = standardStyle;
        }

        /// <summary>
		/// Obtains the String representation of this instance.
		/// </summary>
		/// <returns>User readable name of the instance.</returns>
		public override string ToString()
        {
            // Return the class name and instance identifier
            return "ViewLayoutMenuSepGap:" + Id;
        }
        #endregion

        #region Layout
        /// <summary>
        /// Discover the preferred size of the element.
        /// </summary>
        /// <param name="context">Layout context.</param>
        public override Size GetPreferredSize(ViewLayoutContext context)
        {
            Padding paddingText = Padding.Empty;

            // Grab the padding used for the text/extra content of a menu item
            if (_standardStyle)
                paddingText = _stateCommon.ItemTextStandard.GetContentPadding(PaletteState.Normal);
            else
                paddingText = _stateCommon.ItemTextAlternate.GetContentPadding(PaletteState.Normal);

            // Get padding needed for the left edge of the item highlight
            Padding paddingHighlight = context.Renderer.RenderStandardBorder.GetBorderDisplayPadding(_stateCommon.ItemHighlight.Border, PaletteState.Normal, VisualOrientation.Top);

            // Our separator size is the left padding values added together
            SeparatorSize = new Size(paddingHighlight.Left + paddingText.Left, 0);

            return base.GetPreferredSize(context);
        }
        #endregion
    }
}
