using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Custom type converter so that PaletteImageStyle values appear as neat text at design time.
    /// </summary>
    internal class PaletteImageStyleConverter : StringLookupConverter
    {
        #region Static Fields
        private Pair[] _pairs = new Pair[] { new Pair(PaletteImageStyle.Inherit,        "Inherit"),
                                             new Pair(PaletteImageStyle.Stretch,        "Stretch"),
                                             new Pair(PaletteImageStyle.Tile,           "Tile"),
                                             new Pair(PaletteImageStyle.TileFlipX,      "TileFlip - X"),
                                             new Pair(PaletteImageStyle.TileFlipY,      "TileFlip - Y"),
                                             new Pair(PaletteImageStyle.TileFlipXY,     "TileFlip - XY"),
                                             new Pair(PaletteImageStyle.TopLeft,        "Top - Left"),
                                             new Pair(PaletteImageStyle.TopMiddle,      "Top - Middle"),
                                             new Pair(PaletteImageStyle.TopRight,       "Top - Right"),
                                             new Pair(PaletteImageStyle.CenterLeft,     "Center - Left"),
                                             new Pair(PaletteImageStyle.CenterMiddle,   "Center - Middle"),
                                             new Pair(PaletteImageStyle.CenterRight,    "Center - Right"),
                                             new Pair(PaletteImageStyle.BottomLeft,     "Bottom - Left"),
                                             new Pair(PaletteImageStyle.BottomMiddle,   "Bottom - Middle"),
                                             new Pair(PaletteImageStyle.BottomRight,    "Bottom - Right") };
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PaletteImageStyleConverter clas.
        /// </summary>
        public PaletteImageStyleConverter()
            : base(typeof(PaletteImageStyle))
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
