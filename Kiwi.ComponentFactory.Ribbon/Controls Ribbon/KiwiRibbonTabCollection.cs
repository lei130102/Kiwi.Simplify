using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Ribbon
{
    /// <summary>
    /// Specialise the generic collection with type specific rules for tab item accessor.
    /// </summary>
    public class KiwiRibbonTabCollection : TypedCollection<KiwiRibbonTab>
    {
        #region Public
        /// <summary>
        /// Gets the item with the provided unique name.
        /// </summary>
        /// <param name="name">Name of the ribbon tab instance.</param>
        /// <returns>Item at specified index.</returns>
        public override KiwiRibbonTab this[string name]
        {
            get
            {
                // Search for a tab with the same text as that requested.
                foreach (KiwiRibbonTab tab in this)
                    if (tab.Text == name)
                        return tab;

                // Let base class perform standard processing
                return base[name];
            }
        }
        #endregion
    }
}
