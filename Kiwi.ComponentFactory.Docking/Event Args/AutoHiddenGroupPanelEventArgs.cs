using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Event arguments for a AutoHiddenGroupPanelAdding/AutoHiddenGroupPanelRemoved events.
	/// </summary>
	public class AutoHiddenGroupPanelEventArgs : EventArgs
    {
        #region Instance Fields
        private KiwiAutoHiddenPanel _autoHiddenPanel;
        private KiwiDockingEdgeAutoHidden _element;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the AutoHiddenGroupPanelEventArgs class.
        /// </summary>
        /// <param name="autoHiddenPanel">Reference to auto hidden panel control instance.</param>
        /// <param name="element">Reference to docking auto hidden edge element that is managing the panel.</param>
        public AutoHiddenGroupPanelEventArgs(KiwiAutoHiddenPanel autoHiddenPanel,
                                             KiwiDockingEdgeAutoHidden element)
        {
            _autoHiddenPanel = autoHiddenPanel;
            _element = element;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets a reference to the KiwiAutoHiddenPanel control.
        /// </summary>
        public KiwiAutoHiddenPanel AutoHiddenPanelControl
        {
            get { return _autoHiddenPanel; }
        }

        /// <summary>
        /// Gets a reference to the KiwiDockingEdgeAutoHidden that is managing the edge.
        /// </summary>
        public KiwiDockingEdgeAutoHidden EdgeAutoHiddenElement
        {
            get { return _element; }
        }
        #endregion
    }
}
