using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Navigator
{
    /// <summary>
    /// Custom type converter so that MapKiwiPageImage values appear as neat text at design time.
    /// </summary>
    public class MapKiwiPageImageConverter : StringLookupConverter
    {
        #region Static Fields
        private Pair[] _pairs = new Pair[] { new Pair(MapKiwiPageImage.None,             "None (Null image)"),
                                             new Pair(MapKiwiPageImage.Small,            "Small"),
                                             new Pair(MapKiwiPageImage.SmallMedium,      "Small - Medium"),
                                             new Pair(MapKiwiPageImage.SmallMediumLarge, "Small - Medium - Large"),
                                             new Pair(MapKiwiPageImage.Medium,           "Medium"),
                                             new Pair(MapKiwiPageImage.MediumSmall,      "Medium - Small"),
                                             new Pair(MapKiwiPageImage.MediumLarge,      "Medium - Large"),
                                             new Pair(MapKiwiPageImage.Large,            "Large"),
                                             new Pair(MapKiwiPageImage.LargeMedium,      "Large - Medium"),
                                             new Pair(MapKiwiPageImage.LargeMediumSmall, "Large - Medium - Small"),
                                             new Pair(MapKiwiPageImage.ToolTip,          "ToolTip") };
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the MapKiwiPageImageConverter clas.
        /// </summary>
        public MapKiwiPageImageConverter()
            : base(typeof(MapKiwiPageImage))
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
