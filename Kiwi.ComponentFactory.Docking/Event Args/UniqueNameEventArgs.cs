using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Event arguments for events that need to provide a unique name.
	/// </summary>
	public class UniqueNameEventArgs : EventArgs
    {
        #region Instance Fields
        private string _uniqueName;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the UniqueNameEventArgs class.
        /// </summary>
        /// <param name="uniqueName">Unique name of page.</param>
        public UniqueNameEventArgs(string uniqueName)
        {
            _uniqueName = uniqueName;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets the unique name of a page.
        /// </summary>
        public string UniqueName
        {
            get { return _uniqueName; }
        }
        #endregion
    }
}
