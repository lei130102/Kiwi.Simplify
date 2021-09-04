using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Redirect back/border/content based on the incoming grid state and style.
    /// </summary>
    public class PaletteRedirectBreadCrumb : PaletteRedirect
    {
        #region Instance Fields
        private bool _left;
        private bool _right;
        private bool _topBottom;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PaletteRedirectBreadCrumb class.
        /// </summary>
        /// <param name="target">Initial palette target for redirection.</param>
        public PaletteRedirectBreadCrumb(IPalette target)
            : base(target)
        {
            _left = false;
            _right = false;
            _topBottom = true;
        }
        #endregion

        #region Left
        /// <summary>
        /// Gets and sets if the left border should be removed.
        /// </summary>
        public bool Left
        {
            get { return _left; }
            set { _left = value; }
        }
        #endregion

        #region Right
        /// <summary>
        /// Gets and sets if the right border should be removed.
        /// </summary>
        public bool Right
        {
            get { return _right; }
            set { _right = value; }
        }
        #endregion

        #region TopBottom
        /// <summary>
        /// Gets and sets if the top and bottom borders should be removed.
        /// </summary>
        public bool TopBottom
        {
            get { return _topBottom; }
            set { _topBottom = value; }
        }
        #endregion

        #region GetBorderDrawBorders
        /// <summary>
        /// Gets a value indicating which borders to draw.
        /// </summary>
        /// <param name="style">Border style.</param>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>PaletteDrawBorders value.</returns>
        public override PaletteDrawBorders GetBorderDrawBorders(PaletteBorderStyle style, PaletteState state)
        {
            PaletteDrawBorders borders = base.GetBorderDrawBorders(style, state);

            // We are only interested in bread crums buttons
            if (style == PaletteBorderStyle.ButtonBreadCrumb)
            {
                if (Left)
                    borders &= ~PaletteDrawBorders.Left;

                if (Right)
                    borders &= ~PaletteDrawBorders.Right;

                if (TopBottom)
                    borders &= ~PaletteDrawBorders.TopBottom;
            }

            return borders;
        }
        #endregion
    }
}
