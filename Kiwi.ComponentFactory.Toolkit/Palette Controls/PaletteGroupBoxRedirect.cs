﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Redirect storage for GroupBox states.
	/// </summary>
	public class PaletteGroupBoxRedirect : PaletteDoubleRedirect
    {
        #region Instance Fields
        private PaletteContent _content;
        private PaletteContentInheritRedirect _contentInherit;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PaletteGroupBoxRedirect class.
        /// </summary>
        /// <param name="redirect">Inheritence redirection instance.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public PaletteGroupBoxRedirect(PaletteRedirect redirect,
                                       NeedPaintHandler needPaint)
            : this(redirect, redirect, needPaint)
        {
        }

        /// <summary>
        /// Initialize a new instance of the PaletteGroupBoxRedirect class.
		/// </summary>
        /// <param name="redirectDouble">Inheritence redirection for group border/background.</param>
        /// <param name="redirectContent">Inheritence redirection for group header.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public PaletteGroupBoxRedirect(PaletteRedirect redirectDouble,
                                       PaletteRedirect redirectContent,
                                       NeedPaintHandler needPaint)
            : base(redirectDouble, PaletteBackStyle.ControlGroupBox, PaletteBorderStyle.ControlGroupBox, needPaint)
        {
            Debug.Assert(redirectDouble != null);
            Debug.Assert(redirectContent != null);

            _contentInherit = new PaletteContentInheritRedirect(redirectContent, PaletteContentStyle.LabelGroupBoxCaption);
            _content = new PaletteContent(_contentInherit, needPaint);
        }
        #endregion

        #region IsDefault
        /// <summary>
        /// Gets a value indicating if all values are default.
        /// </summary>
        [Browsable(false)]
        public override bool IsDefault
        {
            get { return (base.IsDefault && _content.IsDefault); }
        }
        #endregion

        #region Content
        /// <summary>
        /// Gets access to the content palette details.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining content appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteContent Content
        {
            get { return _content; }
        }

        private bool ShouldSerializeContent()
        {
            return !_content.IsDefault;
        }

        /// <summary>
        /// Gets the content palette.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IPaletteContent PaletteContent
        {
            get { return Content; }
        }

        /// <summary>
        /// Gets and sets the content palette style.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PaletteContentStyle ContentStyle
        {
            get { return _contentInherit.Style; }
            set { _contentInherit.Style = value; }
        }
        #endregion
    }
}
