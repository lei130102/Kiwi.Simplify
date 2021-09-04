using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Event arguments for a AutoHiddenGroupAdding/AutoHiddenGroupRemoved events.
	/// </summary>
	public class AutoHiddenGroupEventArgs : EventArgs
    {
        #region Instance Fields
        private KiwiAutoHiddenGroup _autoHiddenGroup;
        private KiwiDockingAutoHiddenGroup _element;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the AutoHiddenGroupEventArgs class.
        /// </summary>
        /// <param name="control">Reference to auto hidden group control instance.</param>
        /// <param name="element">Reference to docking auto hidden group element that is managing the control.</param>
        public AutoHiddenGroupEventArgs(KiwiAutoHiddenGroup control,
                                        KiwiDockingAutoHiddenGroup element)
        {
            _autoHiddenGroup = control;
            _element = element;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets a reference to the KiwiAutoHiddenGroup control.
        /// </summary>
        public KiwiAutoHiddenGroup AutoHiddenGroupControl
        {
            get { return _autoHiddenGroup; }
        }

        /// <summary>
        /// Gets a reference to the KiwiDockingAutoHiddenGroup that is managing the group.
        /// </summary>
        public KiwiDockingAutoHiddenGroup AutoHiddenGroupElement
        {
            get { return _element; }
        }
        #endregion
    }
}
