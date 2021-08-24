using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Custom type converter so that InputControl values appear as neat text at design time.
    /// </summary>
    internal class InputControlStyleConverter : StringLookupConverter
    {
        #region Static Fields
        private Pair[] _pairs = new Pair[] { new Pair(InputControlStyle.Standalone, "Standalone"),
                                             new Pair(InputControlStyle.Ribbon,     "Ribbon"),
                                             new Pair(InputControlStyle.Custom1,    "Custom1"),
 };
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the InputControlStyleConverter clas.
        /// </summary>
        public InputControlStyleConverter()
            : base(typeof(InputControlStyle))
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
