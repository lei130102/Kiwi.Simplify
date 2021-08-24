using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Manages a collection of 31 boolean flags.
    /// </summary>
    public struct BoolFlags31
    {
        #region Instance Fields
        private int _flags;
        #endregion

        #region Public
        /// <summary>
        /// Gets and sets the entire flags value.
        /// </summary>
        public int Flags
        {
            get { return _flags; }
            set { _flags = value; }
        }

        /// <summary>
        /// Set all the provided flags to true.
        /// </summary>
        /// <param name="flags">Flags to set.</param>
        /// <return>Set of flags that have changed in value.</return>
        public int SetFlags(int flags)
        {
            int before = _flags;

            // Set all the provided flags
            _flags |= flags;

            // Return set of flags that have changed value
            return (before ^ _flags);
        }

        /// <summary>
        /// Clear all the provided flags to false.
        /// </summary>
        /// <param name="flags">Flags to clear.</param>
        /// <return>Set of flags that have changed in value.</return>
        public int ClearFlags(int flags)
        {
            int before = _flags;

            // Clear all the provided flags
            _flags &= ~flags;

            // Return set of flags that have changed value
            return (before ^ _flags);
        }

        /// <summary>
        /// Are all the provided flags set to true.
        /// </summary>
        /// <param name="flags">Flags to test.</param>
        /// <returns>True if all flags are set; otherwise false.</returns>
        public bool AreFlagsSet(int flags)
        {
            return ((_flags & flags) == flags);
        }
        #endregion
    }

}
