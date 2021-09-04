using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Ribbon
{
    /// <summary>
    /// Delegate used for hooking into a KiwiRibbonContext typed collection.
    /// </summary>
    public delegate void RibbonContextHandler(object sender, TypedCollectionEventArgs<KiwiRibbonContext> e);

    /// <summary>
    /// Specialise the generic collection with type specific rules for context item accessor.
    /// </summary>
    public class KiwiRibbonContextCollection : TypedCollection<KiwiRibbonContext>
    {
        #region Public
        /// <summary>
        /// Gets the item with the provided unique name.
        /// </summary>
        /// <param name="name">Name of the ribbon context instance.</param>
        /// <returns>Item at specified index.</returns>
        public override KiwiRibbonContext this[string name]
        {
            get
            {
                // Search for a context with the same name as that requested.
                foreach (KiwiRibbonContext context in this)
                    if (context.ContextName == name)
                        return context;

                // Let base class perform standard processing
                return base[name];
            }
        }
        #endregion
    }
}
