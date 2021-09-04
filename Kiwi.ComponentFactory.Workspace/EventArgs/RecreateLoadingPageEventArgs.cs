using Kiwi.ComponentFactory.Navigator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Workspace
{
    /// <summary>
    /// Event arguments for events that need to request a KiwiPage from a provided unique name.
	/// </summary>
	public class RecreateLoadingPageEventArgs : CancelEventArgs
    {
        #region Instance Fields
        private KiwiPage _page;
        private string _uniqueName;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the RecreateLoadingPageEventArgs class.
        /// </summary>
        /// <param name="uniqueName">Unique name of the page that needs creating.</param>
        public RecreateLoadingPageEventArgs(string uniqueName)
            : base(false)
        {
            _uniqueName = uniqueName;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets and sets the page to be used for the requested unique name.
        /// </summary>
        public KiwiPage Page
        {
            get { return _page; }
            set { _page = value; }
        }

        /// <summary>
        /// Gets the unique name of the page requested to be recreated.
        /// </summary>
        public string UniqueName
        {
            get { return _uniqueName; }
        }
        #endregion
    }
}
