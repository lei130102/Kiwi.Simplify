using Kiwi.ComponentFactory.Navigator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Workspace
{
    /// <summary>
	/// Data associated with a change in the active page.
	/// </summary>
	public class ActivePageChangedEventArgs : EventArgs
    {
        #region Instance Fields
        private KiwiPage _oldPage;
        private KiwiPage _newPage;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ActivePageChangedEventArgs class.
        /// </summary>
        /// <param name="oldPage">Previous active page value.</param>
        /// <param name="newPage">New active page value.</param>
        public ActivePageChangedEventArgs(KiwiPage oldPage,
                                          KiwiPage newPage)
        {
            _oldPage = oldPage;
            _newPage = newPage;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets the old page reference.
        /// </summary>
        public KiwiPage OldPage
        {
            get { return _oldPage; }
        }

        /// <summary>
        /// Gets the new page reference.
        /// </summary>
        public KiwiPage NewPage
        {
            get { return _newPage; }
        }
        #endregion
    }
}
