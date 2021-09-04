﻿using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Navigator
{
    /// <summary>
	/// Implement redirected storage for page appearance.
	/// </summary>
    public class PalettePageRedirect : PaletteDoubleRedirect
    {
        #region Identity
        /// <summary>
        /// Initialize a new instance of the PalettePageRedirect class.
        /// </summary>
        /// <param name="redirect">Inheritence redirection instance.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public PalettePageRedirect(PaletteRedirect redirect,
                                   NeedPaintHandler needPaint)
            : base(redirect, PaletteBackStyle.ControlClient,
                             PaletteBorderStyle.ControlClient, needPaint)
        {
        }
        #endregion

        #region Border
        /// <summary>
        /// Gets access to the border palette details.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override PaletteBorder Border
        {
            get { return base.Border; }
        }

        /// <summary>
        /// Gets the border palette.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override IPaletteBorder PaletteBorder
        {
            get { return base.PaletteBorder; }
        }
        #endregion
    }
}
