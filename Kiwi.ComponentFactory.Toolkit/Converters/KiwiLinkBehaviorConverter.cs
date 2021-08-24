using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Custom type converter so that KiwiLinkBehavior values appear as neat text at design time.
    /// </summary>
    internal class KiwiLinkBehaviorConverter : StringLookupConverter
    {
        #region Static Fields
        private Pair[] _pairs = new Pair[] { new Pair(KiwiLinkBehavior.AlwaysUnderline,  "Always Underline"),
                                             new Pair(KiwiLinkBehavior.HoverUnderline,   "Hover Underline"),
                                             new Pair(KiwiLinkBehavior.NeverUnderline,   "Never Underline") };
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiLinkBehaviorConverter clas.
        /// </summary>
        public KiwiLinkBehaviorConverter()
            : base(typeof(KiwiLinkBehavior))
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
