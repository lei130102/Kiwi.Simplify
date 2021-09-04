using Kiwi.ComponentFactory.Workspace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Event arguments for a DockableWorkspaceCellAdding/DockableWorkspaceCellRemoving events.
	/// </summary>
	public class DockableWorkspaceCellEventArgs : EventArgs
    {
        #region Instance Fields
        private KiwiDockableWorkspace _workspace;
        private KiwiDockingWorkspace _element;
        private KiwiWorkspaceCell _cell;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the DockableWorkspaceCellEventArgs class.
        /// </summary>
        /// <param name="workspace">Reference to existing dockable workspace control instance.</param>
        /// <param name="element">Reference to docking workspace element that is managing the dockable workspace control.</param>
        /// <param name="cell">Reference to workspace control cell instance.</param>
        public DockableWorkspaceCellEventArgs(KiwiDockableWorkspace workspace,
                                              KiwiDockingWorkspace element,
                                              KiwiWorkspaceCell cell)
        {
            _workspace = workspace;
            _element = element;
            _cell = cell;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets a reference to the KiwiDockableWorkspace that contains the cell.
        /// </summary>
        public KiwiDockableWorkspace DockableWorkspaceControl
        {
            get { return _workspace; }
        }

        /// <summary>
        /// Gets a reference to the KiwiDockingWorkspace that is managing the dockable workspace.
        /// </summary>
        public KiwiDockingWorkspace WorkspaceElement
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
