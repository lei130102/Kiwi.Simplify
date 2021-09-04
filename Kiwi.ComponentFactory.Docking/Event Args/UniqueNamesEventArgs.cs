using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Event arguments for events that need to provide a set of unique names.
	/// </summary>
	public class UniqueNamesEventArgs : EventArgs
    {
        #region Instance Fields
        private string[] _uniqueNames;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the UniqueNamesEventArgs class.
        /// </summary>
        /// <param name="uniqueNames">Array of unique names.</param>
        public UniqueNamesEventArgs(string[] uniqueNames)
        {
            _uniqueNames = uniqueNames;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets the array of unique names associated with the event.
        /// </summary>
        public string[] UniqueNames
        {
            get { return _uniqueNames; }
        }
        #endregion
    }
}
