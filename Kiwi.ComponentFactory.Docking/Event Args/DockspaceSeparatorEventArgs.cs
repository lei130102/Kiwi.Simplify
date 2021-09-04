using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Event arguments for a DockspaceSeparatorAdding/DockspaceSeparatorRemoved event.
	/// </summary>
	public class DockspaceSeparatorEventArgs : EventArgs
    {
        #region Instance Fields
        private KiwiSeparator _separator;
        private KiwiDockingDockspace _element;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the DockspaceSeparatorEventArgs class.
        /// </summary>
        /// <param name="separator">Reference to separator control instance.</param>
        /// <param name="element">Reference to dockspace docking element that is managing the separator.</param>
        public DockspaceSeparatorEventArgs(KiwiSeparator separator,
                                           KiwiDockingDockspace element)
        {
            _separator = separator;
            _element = element;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets a reference to the KiwiSeparator control..
        /// </summary>
        public KiwiSeparator SeparatorControl
        {
            get { return _separator; }
        }

        /// <summary>
        /// Gets a reference to the KiwiDockingDockspace that is managing the dockspace.
        /// </summary>
        public KiwiDockingDockspace DockspaceElement
        {
            get { return _element; }
        }
        #endregion
    }
}
