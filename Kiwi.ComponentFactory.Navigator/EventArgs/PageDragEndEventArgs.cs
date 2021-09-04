using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Navigator
{
    /// <summary>
    /// Details for an event that provides pages associated with a page dragging event.
	/// </summary>
	public class PageDragEndEventArgs : EventArgs
    {
        #region Instance Fields
        private bool _dropped;
        private KiwiPageCollection _pages;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PageDragEndEventArgs class.
        /// </summary>
        /// <param name="dropped">True if a drop was performed; otherwise false.</param>
        /// <param name="pages">Array of event associated pages.</param>
        public PageDragEndEventArgs(bool dropped,
                                    KiwiPage[] pages)
        {
            _dropped = dropped;
            _pages = new KiwiPageCollection();

            if (pages != null)
                _pages.AddRange(pages);
        }
        #endregion

        #region Dropped
        /// <summary>
        /// Gets a value indicating if the drop was performed.
        /// </summary>
        public bool Dropped
        {
            get { return _dropped; }
        }
        #endregion

        #region Pages
        /// <summary>
        /// Gets access to the collection of pages.
        /// </summary>
        public KiwiPageCollection Pages
        {
            get { return _pages; }
        }
        #endregion
    }
}
