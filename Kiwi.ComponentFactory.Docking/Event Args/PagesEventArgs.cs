using Kiwi.ComponentFactory.Navigator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Event arguments for events that need to provide a colletion of pages.
	/// </summary>
	public class PagesEventArgs : EventArgs
    {
        #region Instance Fields
        private KiwiPageCollection _pages;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PagesEventArgs class.
        /// </summary>
        /// <param name="pages">Collection of pages.</param>
        public PagesEventArgs(KiwiPageCollection pages)
        {
            _pages = pages;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets access to a collection of pages.
        /// </summary>
        public KiwiPageCollection Pages
        {
            get { return _pages; }
        }
        #endregion
    }
}
