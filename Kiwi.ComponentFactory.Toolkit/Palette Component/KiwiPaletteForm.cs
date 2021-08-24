using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Storage for palette form states.
    /// </summary>
    public class KiwiPaletteForm : KiwiPaletteDouble3
    {
        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiPaletteForm class.
		/// </summary>
        /// <param name="redirect">Redirector to inherit values from.</param>
        /// <param name="backStyle">Background style.</param>
        /// <param name="borderStyle">Border style.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public KiwiPaletteForm(PaletteRedirect redirect,
                                  PaletteBackStyle backStyle,
                                  PaletteBorderStyle borderStyle,
                                  NeedPaintHandler needPaint)
            : base(redirect, backStyle, borderStyle, needPaint)
        {
        }
        #endregion

        #region StateCommon
        /// <summary>
        /// Gets access to the common control appearance that other states can override.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining common control appearance that other states can override.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteDoubleRedirect StateCommon
        {
            get { return _stateCommon; }
        }

        private bool ShouldSerializeStateCommon()
        {
            return !_stateCommon.IsDefault;
        }
        #endregion

        #region StateInactive
        /// <summary>
        /// Gets access to the inactive form appearance entries.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining inactive form appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteDouble StateInactive
        {
            get { return _stateDisabled; }
        }

        private bool ShouldSerializeStateInactive()
        {
            return !_stateDisabled.IsDefault;
        }
        #endregion

        #region StateActive
        /// <summary>
        /// Gets access to the active form appearance entries.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining active form appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteDouble StateActive
        {
            get { return _stateNormal; }
        }

        private bool ShouldSerializeStateActive()
        {
            return !_stateNormal.IsDefault;
        }
        #endregion
    }
}
