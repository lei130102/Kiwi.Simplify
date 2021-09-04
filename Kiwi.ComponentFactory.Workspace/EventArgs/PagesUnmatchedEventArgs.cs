using Kiwi.ComponentFactory.Navigator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Workspace
{
    /// <summary>
	/// Event data for listing pages unmatched during the load process.
	/// </summary>
	public class PagesUnmatchedEventArgs : EventArgs
    {
        #region Instance Fields
        private KiwiWorkspace _workspace;
        private List<KiwiPage> _unmatched;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PagesUnmatchedEventArgs class.
        /// </summary>
        /// <param name="workspace">Reference to owning workspace control.</param>
        /// <param name="unmatched">List of pages unmatched during the load process.</param>
        public PagesUnmatchedEventArgs(KiwiWorkspace workspace,
                                       List<KiwiPage> unmatched)
        {
            _workspace = workspace;
            _unmatched = unmatched;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets the workspace reference.
        /// </summary>
        public KiwiWorkspace Workspace
        {
            get { return _workspace; }
        }

        /// <summary>
        /// Gets the xml reader.
        /// </summary>
        public List<KiwiPage> Unmatched
        {
            get { return _unmatched; }
        }
        #endregion
    }
}
