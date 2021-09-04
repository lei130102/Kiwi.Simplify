using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Event arguments for events that need to provide a store page reference.
	/// </summary>
	public class StorePageEventArgs : EventArgs
    {
        #region Instance Fields
        private KiwiStorePage _storePage;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the StorePageEventArgs class.
        /// </summary>
        /// <param name="storePage">Reference to store page that is associated with the event.</param>
        public StorePageEventArgs(KiwiStorePage storePage)
        {
            _storePage = storePage;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets a reference to store page that is associated with the event.
        /// </summary>
        public KiwiStorePage StorePage
        {
            get { return _storePage; }
        }
        #endregion
    }
}
