using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Event arguments for a DockspaceAdding/DockspaceRemoved events.
	/// </summary>
	public class DockspaceEventArgs : EventArgs
    {
        #region Instance Fields
        private KiwiDockspace _dockspace;
        private KiwiDockingDockspace _element;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the DockspaceEventArgs class.
        /// </summary>
        /// <param name="dockspace">Reference to new dockspace control instance.</param>
        /// <param name="element">Reference to docking dockspace element that is managing the dockspace control.</param>
        public DockspaceEventArgs(KiwiDockspace dockspace,
                                  KiwiDockingDockspace element)
        {
            _dockspace = dockspace;
            _element = element;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets a reference to the KiwiDockspace control.
        /// </summary>
        public KiwiDockspace DockspaceControl
        {
            get { return _dockspace; }
        }

        /// <summary>
        /// Gets a reference to the KiwiDockingDockspace that is managing the dockspace control.
        /// </summary>
        public KiwiDockingDockspace DockspaceElement
        {
            get { return _element; }
        }
        #endregion
    }
}
