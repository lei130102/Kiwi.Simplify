using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Event arguments for a DockableWorkspaceRemoved event.
	/// </summary>
	public class DockableWorkspaceEventArgs : EventArgs
    {
        #region Instance Fields
        private KiwiDockableWorkspace _workspace;
        private KiwiDockingWorkspace _element;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the DockableWorkspaceEventArgs class.
        /// </summary>
        /// <param name="workspace">Reference to dockable workspace control instance.</param>
        /// <param name="element">Reference to docking workspace element that is managing the dockable workspace control.</param>
        public DockableWorkspaceEventArgs(KiwiDockableWorkspace workspace,
                                          KiwiDockingWorkspace element)
        {
            _workspace = workspace;
            _element = element;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets a reference to the KiwiDockableWorkspace control.
        /// </summary>
        public KiwiDockableWorkspace DockableWorkspaceControl
        {
            get { return _workspace; }
        }

        /// <summary>
        /// Gets a reference to the KiwiDockingWorkspace that is managing the dockable workspace control.
        /// </summary>
        public KiwiDockingWorkspace DockingWorkspaceElement
        {
            get { return _element; }
        }
        #endregion
    }
}
