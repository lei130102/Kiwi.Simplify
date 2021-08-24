using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Implement storage for month calendar appearance states.
    /// </summary>
    public class PaletteMonthCalendarStateRedirect : Storage
    {
        #region Instance Fields
        private PaletteTripleRedirect _paletteDay;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PaletteMonthCalendarStateRedirect class.
		/// </summary>
        public PaletteMonthCalendarStateRedirect()
            : this(null, null)
        {
        }

        /// <summary>
        /// Initialize a new instance of the PaletteMonthCalendarStateRedirect class.
        /// </summary>
        /// <param name="redirect">Inheritence redirection instance.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public PaletteMonthCalendarStateRedirect(PaletteRedirect redirect,
                                                 NeedPaintHandler needPaint)
        {
            _paletteDay = new PaletteTripleRedirect(redirect,
                                                    PaletteBackStyle.ButtonCalendarDay,
                                                    PaletteBorderStyle.ButtonCalendarDay,
                                                    PaletteContentStyle.ButtonCalendarDay,
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
                return _paletteDay.IsDefault;
            }
        }
        #endregion

        #region SetRedirector
        /// <summary>
        /// Update the redirector with new reference.
        /// </summary>
        /// <param name="redirect">Target redirector.</param>
        public void SetRedirector(PaletteRedirect redirect)
        {
            _paletteDay.SetRedirector(redirect);
        }
        #endregion

        #region Styles
        internal ButtonStyle DayStyle
        {
            set { _paletteDay.SetStyles(value); }
        }
        #endregion

        #region Day
        /// <summary>
        /// Gets access to the day appearance entries.
        /// </summary>
        [Category("Visuals")]
        [Description("Overrides for defining day appearance entries.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteTripleRedirect Day
        {
            get { return _paletteDay; }
        }

        private bool ShouldSerializeContent()
        {
            return !_paletteDay.IsDefault;
        }
        #endregion
    }
}
