using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Event data for saving global docking configuration.
	/// </summary>
	public class DockGlobalSavingEventArgs : EventArgs
    {
        #region Instance Fields
        private KiwiDockingManager _manager;
        private XmlWriter _xmlWriter;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the DockGlobalSavingEventArgs class.
        /// </summary>
        /// <param name="manager">Reference to owning docking manager instance.</param>
        /// <param name="xmlWriter">Xml writer for persisting custom data.</param>
        public DockGlobalSavingEventArgs(KiwiDockingManager manager,
                                         XmlWriter xmlWriter)
        {
            _manager = manager;
            _xmlWriter = xmlWriter;
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
        /// Gets the xml writer.
        /// </summary>
        public XmlWriter XmlWriter
        {
            get { return _xmlWriter; }
        }
        #endregion
    }
}
