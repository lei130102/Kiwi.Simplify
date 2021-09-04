﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Implement storage for back, border and tree node triple.
	/// </summary>
    public class PaletteTreeStateRedirect : PaletteDoubleRedirect

    {
        #region Instance Fields
        private PaletteRedirect _redirect;
        private PaletteTripleRedirect _nodeRedirect;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PaletteTreeStateRedirect class.
        /// </summary>
        /// <param name="redirect">Inheritence redirection instance.</param>
        /// <param name="back">Storage for back values.</param>
        /// <param name="backInherit">Inheritence for back values.</param>
        /// <param name="border">Storage for border values.</param>
        /// <param name="borderInherit">Inheritence for border values.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public PaletteTreeStateRedirect(PaletteRedirect redirect,
                                        PaletteBack back,
                                        PaletteBackInheritRedirect backInherit,
                                        PaletteBorder border,
                                        PaletteBorderInheritRedirect borderInherit,
                                        NeedPaintHandler needPaint)
            : base(redirect, back, backInherit, border, borderInherit, needPaint)
        {
            Debug.Assert(redirect != null);

            // Remember the redirect reference
            _redirect = redirect;

            // Create the item redirector
            _nodeRedirect = new PaletteTripleRedirect(redirect,
                                                      PaletteBackStyle.ButtonListItem,
                                                      PaletteBorderStyle.ButtonListItem,
                                                      PaletteContentStyle.ButtonListItem,
                                                      needPaint);
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
                return (base.IsDefault && _nodeRedirect.IsDefault);
            }
        }
        #endregion

        #region Node
        /// <summary>
        /// Gets the node appearance overrides.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining node appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteTripleRedirect Node
        {
            get { return _nodeRedirect; }
        }

        private bool ShouldSerializeItem()
        {
            return !_nodeRedirect.IsDefault;
        }
        #endregion
    }
}
