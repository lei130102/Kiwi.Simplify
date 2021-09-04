using Kiwi.ComponentFactory.Navigator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Event arguments for the change in auto hidden page showing state.
	/// </summary>
	public class AutoHiddenShowingStateEventArgs : EventArgs
    {
        #region Instance Fields
        private KiwiPage _page;
        private DockingAutoHiddenShowState _state;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the AutoHiddenShowingStateEventArgs class.
        /// </summary>
        /// <param name="page">Page for which state has changed.</param>
        /// <param name="state">New state of the auto hidden page.</param>
        public AutoHiddenShowingStateEventArgs(KiwiPage page, DockingAutoHiddenShowState state)
        {
            _page = page;
            _state = state;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets the page that has had the state change.
        /// </summary>
        public KiwiPage Page
        {
            get { return _page; }
        }

        /// <summary>
        /// Gets the new state of the auto hidden page.
        /// </summary>
        public DockingAutoHiddenShowState NewState
        {
            get { return _state; }
        }
        #endregion
    }
}
