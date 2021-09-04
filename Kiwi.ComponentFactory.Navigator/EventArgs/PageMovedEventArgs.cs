using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Navigator
{
    /// <summary>
    /// Details for an event that provides a new index position for a specified page.
	/// </summary>
	public class TabMovedEventArgs : EventArgs
    {
        #region Instance Fields
        private KiwiPage _page;
        private int _index;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the TabMovedEventArgs class.
        /// </summary>
        /// <param name="page">Reference to page that has been moved.</param>
        /// <param name="index">New index of the page within the page collection.</param>
        public TabMovedEventArgs(KiwiPage page, int index)
        {
            _page = page;
            _index = index;
        }
        #endregion

        #region Dropped
        /// <summary>
        /// Gets a reference to the page that has been moved.
        /// </summary>
        public KiwiPage Page
        {
            get { return _page; }
        }
        #endregion

        #region Pages
        /// <summary>
        /// Gets the new index of the page within the page collection.
        /// </summary>
        public int Index
        {
            get { return _index; }
        }
        #endregion
    }
}
