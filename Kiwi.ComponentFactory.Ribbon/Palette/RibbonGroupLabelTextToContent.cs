﻿using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Ribbon
{
    internal class RibbonGroupLabelTextToContent : RibbonToContent
    {
        #region Instance Fields
        private IPaletteRibbonText _ribbonGroupTextNormal;
        private IPaletteRibbonText _ribbonGroupTextDisabled;
        private IPaletteRibbonText _ribbonLabelTextNormal;
        private IPaletteRibbonText _ribbonLabelTextDisabled;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the RibbonGroupLabelTextToContent class.
        /// </summary>
        /// <param name="ribbonGeneral">Source for general ribbon settings.</param>
        /// <param name="ribbonGroupTextNormal">Source for ribbon group button normal settings.</param>
        /// <param name="ribbonGroupTextDisabled">Source for ribbon group button disabled settings.</param>
        /// <param name="ribbonLabelTextNormal">Source for ribbon group label normal settings.</param>
        /// <param name="ribbonLabelTextDisabled">Source for ribbon group label disabled settings.</param>
        public RibbonGroupLabelTextToContent(PaletteRibbonGeneral ribbonGeneral,
                                             IPaletteRibbonText ribbonGroupTextNormal,
                                             IPaletteRibbonText ribbonGroupTextDisabled,
                                             IPaletteRibbonText ribbonLabelTextNormal,
                                             IPaletteRibbonText ribbonLabelTextDisabled)

            : base(ribbonGeneral)
        {
            Debug.Assert(ribbonGroupTextNormal != null);
            Debug.Assert(ribbonGroupTextDisabled != null);
            Debug.Assert(ribbonLabelTextNormal != null);
            Debug.Assert(ribbonLabelTextDisabled != null);

            _ribbonGroupTextNormal = ribbonGroupTextNormal;
            _ribbonGroupTextDisabled = ribbonGroupTextDisabled;
            _ribbonLabelTextNormal = ribbonLabelTextNormal;
            _ribbonLabelTextDisabled = ribbonLabelTextDisabled;
        }
        #endregion

        #region IPaletteContent
        /// <summary>
        /// Gets the first back color for the short text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Color value.</returns>
        public override Color GetContentShortTextColor1(PaletteState state)
        {
            return GetTextColor(state);
        }

        /// <summary>
        /// Gets the second back color for the short text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Color value.</returns>
        public override Color GetContentShortTextColor2(PaletteState state)
        {
            return GetTextColor(state);
        }

        /// <summary>
        /// Gets the first back color for the long text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Color value.</returns>
        public override Color GetContentLongTextColor1(PaletteState state)
        {
            return GetTextColor(state);
        }

        /// <summary>
        /// Gets the second back color for the long text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Color value.</returns>
        public override Color GetContentLongTextColor2(PaletteState state)
        {
            return GetTextColor(state);
        }
        #endregion

        #region Implementation
        private Color GetTextColor(PaletteState state)
        {
            Color retColor = Color.Empty;

            if (state == PaletteState.Disabled)
            {
                retColor = _ribbonLabelTextDisabled.GetRibbonTextColor(state);

                if (retColor == Color.Empty)
                    retColor = _ribbonGroupTextDisabled.GetRibbonTextColor(state);
            }
            else
            {
                retColor = _ribbonLabelTextNormal.GetRibbonTextColor(state);

                if (retColor == Color.Empty)
                    retColor = _ribbonGroupTextNormal.GetRibbonTextColor(state);
            }

            return retColor;
        }
        #endregion
    }
}
