using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Navigator
{
    /// <summary>
    /// Dictionary lookup from unique name to the KiwiPage.
    /// </summary>
    public class UniqueNameToPage : Dictionary<string, KiwiPage> { };

    /// <summary>
    /// Specialise the generic collection event args with specific type.
    /// </summary>
    public class KiwiPageEventArgs : TypedCollectionEventArgs<KiwiPage>
    {
        #region Public
        /// <summary>
        /// Initialize a new instance of the KiwiPageEventArgs class.
        /// </summary>
        /// <param name="item">Page effected by event.</param>
        /// <param name="index">Index of page in the owning collection.</param>
        public KiwiPageEventArgs(KiwiPage item, int index)
            : base(item, index)
        {
        }
        #endregion
    }

    /// <summary>
    /// Specialise the generic collection with type specific rules for item accessor.
    /// </summary>
    public class KiwiPageCollection : TypedCollection<KiwiPage>
    {
        #region Public
        /// <summary>
        /// Gets the item with the provided unique name.
        /// </summary>
        /// <param name="name">Name of the ribbon tab instance.</param>
        /// <returns>Item at specified index.</returns>
        public override KiwiPage this[string name]
        {
            get
            {
                // First priority is the UniqueName
                foreach (KiwiPage page in this)
                    if (page.UniqueName == name)
                        return page;

                // Second priority is the design time Name
                foreach (KiwiPage page in this)
                    if (page.Name == name)
                        return page;

                // Third priority is the Text of the page
                foreach (KiwiPage page in this)
                    if (page.Text == name)
                        return page;

                // Let base class perform standard processing
                return base[name];
            }
        }

        /// <summary>
        /// Gets the number of visible pages in the collection.
        /// </summary>
        public int VisibleCount
        {
            get
            {
                int visibleCount = 0;

                // Count the number of pages that are visible
                foreach (KiwiPage page in this)
                    if (page.LastVisibleSet)
                        visibleCount++;

                return visibleCount;
            }
        }
        #endregion
    }
}
