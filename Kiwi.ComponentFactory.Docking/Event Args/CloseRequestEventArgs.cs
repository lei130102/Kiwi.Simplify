using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Event arguments for the PageCloseRequest event.
	/// </summary>
    public class CloseRequestEventArgs : UniqueNameEventArgs
    {
        #region Instance Fields
        private DockingCloseRequest _closeRequest;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the CloseRequestEventArgs class.
        /// </summary>
        /// <param name="uniqueName">Unique name of the page associated with the event.</param>
        /// <param name="closeRequest">Initial close action to use.</param>
        public CloseRequestEventArgs(string uniqueName, DockingCloseRequest closeRequest)
            : base(uniqueName)
        {
            _closeRequest = closeRequest;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets and sets the close action to be performed.
        /// </summary>
        public DockingCloseRequest CloseRequest
        {
            get { return _closeRequest; }
            set { _closeRequest = value; }
        }
        #endregion
    }
}
