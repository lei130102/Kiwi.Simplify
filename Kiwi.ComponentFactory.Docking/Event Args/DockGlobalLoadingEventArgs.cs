using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Event data for loading global docking configuration.
	/// </summary>
	public class DockGlobalLoadingEventArgs : EventArgs
    {
        #region Instance Fields
        private KiwiDockingManager _manager;
        private XmlReader _xmlReader;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the DockGlobalLoadingEventArgs class.
        /// </summary>
        /// <param name="manager">Reference to owning docking manager instance.</param>
        /// <param name="xmlReading">Xml reader for persisting custom data.</param>
        public DockGlobalLoadingEventArgs(KiwiDockingManager manager,
                                          XmlReader xmlReading)
        {
            _manager = manager;
            _xmlReader = xmlReading;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets the docking manager reference.
        /// </summary>
        public KiwiDockingManager DockingManager
        {
            get { return _manager; }
        }

        /// <summary>
        /// Gets the xml reader.
        /// </summary>
        public XmlReader XmlReader
        {
            get { return _xmlReader; }
        }
        #endregion
    }
}
