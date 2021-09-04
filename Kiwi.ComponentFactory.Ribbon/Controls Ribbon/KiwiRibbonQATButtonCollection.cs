using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Ribbon
{
    /// <summary>
    /// Quick access toolbar can contain any component that implements the IQuickAccessToolbarEntry
    /// </summary>
    public class KiwiRibbonQATButtonCollection : TypedRestrictCollection<Component>
    {
        #region Static Fields
        private static readonly Type[] _types = new Type[] { typeof(IQuickAccessToolbarButton) };
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
