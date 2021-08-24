using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Custom type converter so that PaletteTextTrim values appear as neat text at design time.
    /// </summary>
    internal class PaletteTextTrimConverter : StringLookupConverter
    {
        #region Static Fields
        private Pair[] _pairs = new Pair[] { new Pair(PaletteTextTrim.Inherit,              "Inherit"),
                                             new Pair(PaletteTextTrim.Hide,                 "Hide"),
                                             new Pair(PaletteTextTrim.Character,            "Character"),
                                             new Pair(PaletteTextTrim.Word,                 "Word"),
                                             new Pair(PaletteTextTrim.EllipsisCharacter,    "Ellipsis Character"),
                                             new Pair(PaletteTextTrim.EllipsisWord,         "Ellipsis Word"),
                                             new Pair(PaletteTextTrim.EllipsisPath,         "Ellipsis Path") };
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PaletteTextTrimConverter clas.
        /// </summary>
        public PaletteTextTrimConverter()
            : base(typeof(PaletteTextTrim))
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
