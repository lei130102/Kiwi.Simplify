﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Storage for status strip entries of the professional color table.
    /// </summary>
    public class KiwiPaletteTMSStatusStrip : KiwiPaletteTMSBase
    {
        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiPaletteTMSStatusStrip class.
		/// </summary>
        /// <param name="internalKCT">Reference to inherited values.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        internal KiwiPaletteTMSStatusStrip(KiwiInternalKCT internalKCT,
                                              NeedPaintHandler needPaint)
            : base(internalKCT, needPaint)
        {
        }
        #endregion

        #region IsDefault
        /// <summary>
        /// Gets a value indicating if all values are default.
        /// </summary>
        [Browsable(false)]
        public override bool IsDefault
        {
            get
            {
                return (InternalKCT.InternalStatusStripText == Color.Empty) &&
                       (InternalKCT.InternalStatusStripFont == null) &&
                       (InternalKCT.InternalStatusStripGradientBegin == Color.Empty) &&
                       (InternalKCT.InternalStatusStripGradientEnd == Color.Empty);

            }
        }
        #endregion

        #region PopulateFromBase
        /// <summary>
        /// Populate values from the base palette.
        /// </summary>
        public void PopulateFromBase()
        {
            StatusStripText = InternalKCT.StatusStripText;
            StatusStripFont = InternalKCT.StatusStripFont;
            StatusStripGradientBegin = InternalKCT.StatusStripGradientBegin;
            StatusStripGradientEnd = InternalKCT.StatusStripGradientEnd;
        }
        #endregion

        #region StatusStripText
        /// <summary>
        /// Gets and sets the color to draw text on the status strip.
        /// </summary>
        [KiwiPersist(false)]
        [Category("ToolMenuStatus")]
        [Description("Color to draw text on the StatusStrip.")]
        [KiwiDefaultColorAttribute()]
        public Color StatusStripText
        {
            get { return InternalKCT.InternalStatusStripText; }

            set
            {
                InternalKCT.InternalStatusStripText = value;
                PerformNeedPaint(false);
            }
        }

        /// <summary>
        /// Resets the StatusStripText property to its default value.
        /// </summary>
        public void ResetStatusStripText()
        {
            StatusStripText = Color.Empty;
        }
        #endregion

        #region StatusStripFont
        /// <summary>
        /// Gets and sets the font to draw text on the status strip.
        /// </summary>
        [KiwiPersist(false)]
        [Category("ToolMenuStatus")]
        [Description("Font to draw text on the StatusStrip.")]
        [DefaultValue(null)]
        public Font StatusStripFont
        {
            get { return InternalKCT.InternalStatusStripFont; }

            set
            {
                InternalKCT.InternalStatusStripFont = value;
                PerformNeedPaint(false);
            }
        }

        /// <summary>
        /// Resets the StatusStripFont property to its default value.
        /// </summary>
        public void ResetStatusStripFont()
        {
            StatusStripText = Color.Empty;
        }
        #endregion

        #region StatusStripGradientBegin
        /// <summary>
        /// Gets and sets the starting color of the gradient used on the StatusStrip.
        /// </summary>
        [KiwiPersist(false)]
        [Category("ToolMenuStatus")]
        [Description("Starting color of the gradient used on the StatusStrip.")]
        [KiwiDefaultColorAttribute()]
        public Color StatusStripGradientBegin
        {
            get { return InternalKCT.InternalStatusStripGradientBegin; }

            set
            {
                InternalKCT.InternalStatusStripGradientBegin = value;
                PerformNeedPaint(false);
            }
        }

        /// <summary>
        /// Resets the StatusStripGradientBegin property to its default value.
        /// </summary>
        public void ResetStatusStripGradientBegin()
        {
            StatusStripGradientBegin = Color.Empty;
        }
        #endregion

        #region StatusStripGradientEnd
        /// <summary>
        /// Gets and sets the ending color of the gradient used on the StatusStrip.
        /// </summary>
        [KiwiPersist(false)]
        [Category("ToolMenuStatus")]
        [Description("Ending color of the gradient used on the StatusStrip.")]
        [KiwiDefaultColorAttribute()]
        public Color StatusStripGradientEnd
        {
            get { return InternalKCT.InternalStatusStripGradientEnd; }

            set
            {
                InternalKCT.InternalStatusStripGradientEnd = value;
                PerformNeedPaint(false);
            }
        }

        /// <summary>
        /// Resets the StatusStripGradientEnd property to its default value.
        /// </summary>
        public void ResetStatusStripGradientEnd()
        {
            StatusStripGradientEnd = Color.Empty;
        }
        #endregion
    }
}
