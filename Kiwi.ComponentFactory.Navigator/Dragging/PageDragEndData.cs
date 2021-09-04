using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Navigator
{
    /// <summary>
    /// Details for an event that provides pages and cell associated with a page dragging event.
	/// </summary>
    public class PageDragEndData
    {
        #region Instance Fields
        private object _source;
        private KiwiNavigator _navigator;
        private KiwiPageCollection _pages;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PageDragEndData class.
        /// </summary>
        /// <param name="source">Source object for the drag data..</param>
        /// <param name="pages">Collection of pages.</param>
        public PageDragEndData(object source,
                               KiwiPageCollection pages)
            : this(source, null, pages)
        {
        }

        /// <summary>
        /// Initialize a new instance of the PageDragEndData class.
        /// </summary>
        /// <param name="source">Source object for the drag data..</param>
        /// <param name="navigator">Navigator associated with pages.</param>
        /// <param name="pages">Collection of pages.</param>
        public PageDragEndData(object source,
                               KiwiNavigator navigator,
                               KiwiPageCollection pages)
        {
            _source = source;
            _navigator = navigator;
            _pages = pages;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets access to the source of the drag data.
        /// </summary>
        public object Source
        {
            get { return _source; }
        }

        /// <summary>
        /// Gets access to any associated KiwiNavigator instance.
        /// </summary>
        public KiwiNavigator Navigator
        {
            get { return _navigator; }
        }

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
