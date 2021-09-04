using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Event arguments for a DockableNavigatorEventArgs event.
	/// </summary>
	public class DockableNavigatorEventArgs : EventArgs
    {
        #region Instance Fields
        private KiwiDockableNavigator _navigator;
        private KiwiDockingNavigator _element;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the DockableNavigatorEventArgs class.
        /// </summary>
        /// <param name="navigator">Reference to dockable navigator control instance.</param>
        /// <param name="element">Reference to docking navigator element that is managing the dockable workspace control.</param>
        public DockableNavigatorEventArgs(KiwiDockableNavigator navigator,
                                          KiwiDockingNavigator element)
        {
            _navigator = navigator;
            _element = element;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets a reference to the KiwiDockableNavigator control.
        /// </summary>
        public KiwiDockableNavigator DockableNavigatorControl
        {
            get { return _navigator; }
        }

        /// <summary>
        /// Gets a reference to the KiwiDockingNavigator that is managing the dockable workspace control.
        /// </summary>
        public KiwiDockingNavigator DockingNavigatorElement
        {
            get { return _element; }
        }
        #endregion
    }
}
