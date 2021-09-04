using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Event arguments for events that need to provide a unique name but can be cancelled.
	/// </summary>
    public class CancelUniqueNameEventArgs : UniqueNameEventArgs
    {
        #region Instance Fields
        private bool _cancel;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the CancelUniqueNameEventArgs class.
        /// </summary>
        /// <param name="uniqueName">Unique name of page.</param>
        /// <param name="cancel">Initial value for the cancel property.</param>
        public CancelUniqueNameEventArgs(string uniqueName, bool cancel)
            : base(uniqueName)
        {
            _cancel = cancel;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets and sets a value indicating if the event action should be cancelled.
        /// </summary>
        public bool Cancel
        {
            get { return _cancel; }
            set { _cancel = value; }
        }
        #endregion
    }
}
