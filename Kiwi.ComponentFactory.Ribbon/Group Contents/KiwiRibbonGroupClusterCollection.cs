using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Ribbon
{
    /// <summary>
    /// Manage the items that can be added to a ribbon group button cluster container.
    /// </summary>
    public class KiwiRibbonGroupClusterCollection : TypedRestrictCollection<KiwiRibbonGroupItem>
    {
        #region Static Fields
        private static readonly Type[] _types = new Type[] { typeof(KiwiRibbonGroupClusterButton),
                                                             typeof(KiwiRibbonGroupClusterColorButton)};
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
