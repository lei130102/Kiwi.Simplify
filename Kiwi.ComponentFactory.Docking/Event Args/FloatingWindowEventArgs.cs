using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Event arguments for a FloatingWindowAdding/FloatingWindowRemoved event.
	/// </summary>
	public class FloatingWindowEventArgs : EventArgs
    {
        #region Instance Fields
        private KiwiFloatingWindow _floatingWindow;
        private KiwiDockingFloatingWindow _element;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the FloatingWindowEventArgs class.
        /// </summary>
        /// <param name="floatingWindow">Reference to floating window instance.</param>
        /// <param name="element">Reference to docking floating winodw element that is managing the floating window.</param>
        public FloatingWindowEventArgs(KiwiFloatingWindow floatingWindow,
                                       KiwiDockingFloatingWindow element)
        {
            _floatingWindow = floatingWindow;
            _element = element;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets a reference to the KiwiFloatingWindow control.
        /// </summary>
        public KiwiFloatingWindow FloatingWindow
        {
            get { return _floatingWindow; }
        }

        /// <summary>
        /// Gets a reference to the KiwiDockingFloatingWindow that is managing the dockspace.
        /// </summary>
        public KiwiDockingFloatingWindow FloatingWindowElement
        {
            get { return _element; }
        }
        #endregion
    }
}
