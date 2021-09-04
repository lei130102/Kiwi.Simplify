using Kiwi.ComponentFactory.Workspace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Event arguments for a DockspaceCellAdding/DockspaceCellRemoving events.
	/// </summary>
	public class DockspaceCellEventArgs : EventArgs
    {
        #region Instance Fields
        private KiwiDockspace _dockspace;
        private KiwiDockingDockspace _element;
        private KiwiWorkspaceCell _cell;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the DockspaceCellEventArgs class.
        /// </summary>
        /// <param name="dockspace">Reference to existing dockspace control instance.</param>
        /// <param name="element">Reference to docking dockspace element that is managing the dockspace control.</param>
        /// <param name="cell">Reference to dockspace control cell instance.</param>
        public DockspaceCellEventArgs(KiwiDockspace dockspace,
                                      KiwiDockingDockspace element,
                                      KiwiWorkspaceCell cell)
        {
            _dockspace = dockspace;
            _element = element;
            _cell = cell;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets a reference to the KiwiDockspace that contains the cell.
        /// </summary>
        public KiwiDockspace DockspaceControl
        {
            get { return _dockspace; }
        }

        /// <summary>
        /// Gets a reference to the KiwiDockingDockspace that is managing the dockspace.
        /// </summary>
        public KiwiDockingDockspace DockspaceElement
        {
            get { return _element; }
        }

        /// <summary>
        /// Gets a reference to the KiwiWorkspaceCell control.
        /// </summary>
        public KiwiWorkspaceCell CellControl
        {
            get { return _cell; }
        }
        #endregion
    }
}
