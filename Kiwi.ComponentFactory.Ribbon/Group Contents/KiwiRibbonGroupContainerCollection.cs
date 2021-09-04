using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Ribbon
{
    /// <summary>
    /// Manage the items that can be added to the top level of a ribbon group instance.
    /// </summary>
    public class KiwiRibbonGroupContainerCollection : TypedRestrictCollection<KiwiRibbonGroupContainer>
    {
        #region Static Fields
        private static readonly Type[] _types = new Type[] { typeof(KiwiRibbonGroupLines),
                                                             typeof(KiwiRibbonGroupTriple),
                                                             typeof(KiwiRibbonGroupSeparator),
                                                             typeof(KiwiRibbonGroupGallery)};
        #endregion

        #region Restrict
        /// <summary>
        /// Gets an array of types that the collection is restricted to contain.
        /// </summary>
        public override Type[] RestrictTypes
        {
            get { return _types; }
        }
        #endregion
    }
}
