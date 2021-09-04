using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Navigator
{
    /// <summary>
    /// Details for an event that indicates a page is being dropped.
	/// </summary>
	public class PageDropEventArgs : CancelEventArgs
    {
        #region Instance Fields
        private KiwiPage _page;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PageDropEventArgs class.
        /// </summary>
        /// <param name="page">Page that is being dropped.</param>
        public PageDropEventArgs(KiwiPage page)
        {
            _page = page;
        }
        #endregion

        #region Page
        /// <summary>
        /// Gets and sets the page to be dropped.
        /// </summary>
        public KiwiPage Page
        {
            get { return _page; }
            set { _page = Page; }
        }
        #endregion
    }
}
