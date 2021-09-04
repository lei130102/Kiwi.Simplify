using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Navigator
{
    /// <summary>
    /// Custom type converter so that MapKiwiPageText values appear as neat text at design time.
    /// </summary>
    public class MapKiwiPageTextConverter : StringLookupConverter
    {
        #region Static Fields
        private Pair[] _pairs = new Pair[] { new Pair(MapKiwiPageText.None,                          "None (Empty string)"),
                                             new Pair(MapKiwiPageText.Text,                          "Text"),
                                             new Pair(MapKiwiPageText.TextTitle,                     "Text - Title"),
                                             new Pair(MapKiwiPageText.TextTitleDescription,          "Text - Title - Description"),
                                             new Pair(MapKiwiPageText.TextDescription,               "Text - Description"),
                                             new Pair(MapKiwiPageText.Title,                         "Title"),
                                             new Pair(MapKiwiPageText.TitleText,                     "Title - Text"),
                                             new Pair(MapKiwiPageText.TitleDescription,              "Title - Description"),
                                             new Pair(MapKiwiPageText.Description,                   "Description"),
                                             new Pair(MapKiwiPageText.DescriptionText,               "Description - Text"),
                                             new Pair(MapKiwiPageText.DescriptionTitle,              "Description - Title"),
                                             new Pair(MapKiwiPageText.DescriptionTitleText,          "Description - Title - Text"),
                                             new Pair(MapKiwiPageText.ToolTipTitle,                  "ToolTipTitle"),
                                             new Pair(MapKiwiPageText.ToolTipBody,                   "ToolTipBody"),
        };
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the MapKiwiPageTextConverter clas.
        /// </summary>
        public MapKiwiPageTextConverter()
            : base(typeof(MapKiwiPageText))
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
