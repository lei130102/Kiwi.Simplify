﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Implement storage for palette border edge details.
    /// </summary>
    public class PaletteBorderEdge : PaletteBack
    {
        #region Instance Fields
        private PaletteBorderEdgeRedirect _inherit;
        private int _borderWidth;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PaletteBorderEdge class.
        /// </summary>
        /// <param name="inherit">Source for inheriting defaulted values.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public PaletteBorderEdge(PaletteBorderEdgeRedirect inherit,
                                 NeedPaintHandler needPaint)
            : base(inherit, needPaint)
        {
            Debug.Assert(inherit != null);

            // Remember inheritance
            _inherit = inherit;

            // Default properties
            _borderWidth = -1;
        }
        #endregion

        #region IsDefault
        /// <summary>
        /// Gets a value indicating if all values are default.
        /// </summary>
        [Browsable(false)]
        public override bool IsDefault
        {
            get { return (_borderWidth == -1) && base.IsDefault; }
        }
        #endregion

        #region Width
        /// <summary>
        /// Gets and sets the border width.
        /// </summary>
        [KiwiPersist(false)]
        [Category("Visuals")]
        [Description("Border width.")]
        [DefaultValue(-1)]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public int Width
        {
            get { return _borderWidth; }

            set
            {
                if (value != _borderWidth)
                {
                    _borderWidth = value;
                    PerformNeedPaint(true);
                }
            }
        }

        /// <summary>
        /// Gets the border width.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Border width.</returns>
        public int GetBorderWidth(PaletteState state)
        {
            if (Width != -1)
                return Width;
            else
                return _inherit.GetBorderWidth(state);
        }
        #endregion
    }
}
