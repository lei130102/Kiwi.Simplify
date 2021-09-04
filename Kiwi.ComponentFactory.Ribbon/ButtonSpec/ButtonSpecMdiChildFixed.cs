using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Ribbon
{
    /// <summary>
    /// Implementation for the fixed mdi child pendant buttons.
    /// </summary>
    public abstract class ButtonSpecMdiChildFixed : ButtonSpec
    {
        #region Instance Fields
        private Form _mdiChild;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ButtonSpecMdiChildFixed class.
        /// </summary>
        /// <param name="fixedStyle">Fixed style to use.</param>
        public ButtonSpecMdiChildFixed(PaletteButtonSpecStyle fixedStyle)
        {
            // Fix the type
            ProtectedType = fixedStyle;
        }
        #endregion

        #region AllowComponent
        /// <summary>
        /// Gets a value indicating if the component is allowed to be selected at design time.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool AllowComponent
        {
            get { return false; }
        }
        #endregion

        #region MdiChild
        /// <summary>
        /// Gets access to the owning kiwi form.
        /// </summary>
        public Form MdiChild
        {
            get { return _mdiChild; }
            set { _mdiChild = value; }
        }
        #endregion

        #region ButtonSpecStype
        /// <summary>
        /// Gets and sets the actual type of the button.
        /// </summary>
        public PaletteButtonSpecStyle ButtonSpecType
        {
            get { return ProtectedType; }
            set { ProtectedType = value; }
        }
        #endregion

        #region IButtonSpecValues
        /// <summary>
        /// Gets the button style.
        /// </summary>
        /// <param name="palette">Palette to use for inheriting values.</param>
        /// <returns>Button style.</returns>
        public override ButtonStyle GetStyle(IPalette palette)
        {
            return ButtonStyle.ButtonSpec;
        }
        #endregion
    }
}
