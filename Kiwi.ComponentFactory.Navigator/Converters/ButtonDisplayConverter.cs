using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Navigator
{
    /// <summary>
    /// Custom type converter so that ButtonDisplay values appear as neat text at design time.
    /// </summary>
    public class ButtonDisplayConverter : StringLookupConverter
    {
        #region Static Fields
        private Pair[] _pairs = new Pair[] { new Pair(ButtonDisplay.Hide,           "Hide"),
                                             new Pair(ButtonDisplay.ShowDisabled,   "Show Disabled"),
                                             new Pair(ButtonDisplay.ShowEnabled,    "Show Enabled"),
                                             new Pair(ButtonDisplay.Logic,          "Logic") };
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ButtonDisplayConverter clas.
        /// </summary>
        public ButtonDisplayConverter()
            : base(typeof(ButtonDisplay))
        {
        }
        #endregion

        #region Protected
        /// <summary>
        /// Gets an array of lookup pairs.
        /// </summary>
        protected override Pair[] Pairs
        {
            get { return _pairs; }
        }
        #endregion
    }
}
