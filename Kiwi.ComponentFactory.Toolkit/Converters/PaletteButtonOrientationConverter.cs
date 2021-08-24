using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Custom type converter so that PaletteButtonOrientation values appear as neat text at design time.
    /// </summary>
    internal class PaletteButtonOrientationConverter : StringLookupConverter
    {
        #region Static Fields
        private Pair[] _pairs = new Pair[] { new Pair(PaletteButtonOrientation.Inherit,     "Inherit"),
                                             new Pair(PaletteButtonOrientation.Auto,        "Auto"),
                                             new Pair(PaletteButtonOrientation.FixedTop,    "Fixed Top"),
                                             new Pair(PaletteButtonOrientation.FixedBottom, "Fixed Bottom"),
                                             new Pair(PaletteButtonOrientation.FixedLeft,   "Fixed Left"),
                                             new Pair(PaletteButtonOrientation.FixedRight,  "Fixed Right") };
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PaletteButtonOrientation clas.
        /// </summary>
        public PaletteButtonOrientationConverter()
            : base(typeof(PaletteButtonOrientation))
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
