using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Kiwi.ComponentFactory.Workspace
{
    /// <summary>
	/// Event data for persisting extra data for a workspace.
	/// </summary>
	public class XmlLoadingEventArgs : EventArgs
    {
        #region Instance Fields
        private KiwiWorkspace _workspace;
        private XmlReader _xmlReader;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the XmlLoadingEventArgs class.
        /// </summary>
        /// <param name="workspace">Reference to owning workspace control.</param>
        /// <param name="xmlReading">Xml reader for persisting custom data.</param>
        public XmlLoadingEventArgs(KiwiWorkspace workspace,
                                   XmlReader xmlReading)
        {
            _workspace = workspace;
            _xmlReader = xmlReading;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets the workspace reference.
        /// </summary>
        public KiwiWorkspace Workspace
        {
            get { return _workspace; }
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
