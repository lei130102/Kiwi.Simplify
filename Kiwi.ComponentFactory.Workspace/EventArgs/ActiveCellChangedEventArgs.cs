using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Workspace
{
    /// <summary>
	/// Data associated with a change in the active cell.
	/// </summary>
	public class ActiveCellChangedEventArgs : EventArgs
    {
        #region Instance Fields
        private KiwiWorkspaceCell _oldCell;
        private KiwiWorkspaceCell _newCell;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ActiveCellChangedEventArgs class.
        /// </summary>
        /// <param name="oldCell">Previous active cell value.</param>
        /// <param name="newCell">New active cell value.</param>
        public ActiveCellChangedEventArgs(KiwiWorkspaceCell oldCell,
                                          KiwiWorkspaceCell newCell)
        {
            _oldCell = oldCell;
            _newCell = newCell;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets the old cell reference.
        /// </summary>
        public KiwiWorkspaceCell OldCell
        {
            get { return _oldCell; }
        }

        /// <summary>
        /// Gets the new cell reference.
        /// </summary>
        public KiwiWorkspaceCell NewCell
        {
            get { return _newCell; }
        }
        #endregion
    }
}
