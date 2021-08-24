using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Implementation for the fixed navigator buttons.
    /// </summary>
    [TypeConverter(typeof(ButtonSpecFormFixedConverter))]
    public abstract class ButtonSpecFormFixed : ButtonSpec
    {
        #region Instance Fields
        private KiwiForm _form;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ButtonSpecFormFixed class.
        /// </summary>
        /// <param name="form">Reference to owning kiwi form.</param>
        /// <param name="fixedStyle">Fixed style to use.</param>
        public ButtonSpecFormFixed(KiwiForm form,
                                   PaletteButtonSpecStyle fixedStyle)
        {
            Debug.Assert(form != null);

            // Remember back reference to owning navigator.
            _form = form;

            // Fix the type
            ProtectedType = fixedStyle;
        }
        #endregion

        #region AllowComponent
        /// <summary>
        /// Can a component be associated with the view.
        /// </summary>
        public override bool AllowComponent
        {
            get { return false; }
        }
        #endregion

        #region KiwiForm
        /// <summary>
        /// Gets access to the owning kiwi form.
        /// </summary>
        protected KiwiForm KiwiForm
        {
            get { return _form; }
        }
        #endregion

        #region ButtonSpecType
        /// <summary>
        /// Gets and sets the actual type of the button.
        /// </summary>
        public virtual PaletteButtonSpecStyle ButtonSpecType
        {
            get { return ProtectedType; }
            set { ProtectedType = value; }
        }
        #endregion
    }
}
