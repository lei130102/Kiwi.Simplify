using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Navigator
{
    /// <summary>
    /// Custom type converter so that BarItemSizing values appear as neat text at design time.
    /// </summary>
    public class BarItemSizingConverter : StringLookupConverter
    {
        #region Static Fields
        private Pair[] _pairs = new Pair[] { new Pair(BarItemSizing.Individual,           "Individual Sizing"),
                                             new Pair(BarItemSizing.SameHeight,           "All Same Height"),
                                             new Pair(BarItemSizing.SameWidth,            "All Same Width"),
                                             new Pair(BarItemSizing.SameWidthAndHeight,   "All Same Width & Height") };
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the BarItemSizingConverter clas.
        /// </summary>
        public BarItemSizingConverter()
            : base(typeof(BarItemSizing))
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
