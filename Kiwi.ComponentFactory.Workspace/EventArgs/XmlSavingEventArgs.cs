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
	public class XmlSavingEventArgs : EventArgs
    {
        #region Instance Fields
        private KiwiWorkspace _workspace;
        private XmlWriter _xmlWriter;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the XmlSavingEventArgs class.
        /// </summary>
        /// <param name="workspace">Reference to owning workspace control.</param>
        /// <param name="xmlWriter">Xml writer for persisting custom data.</param>
        public XmlSavingEventArgs(KiwiWorkspace workspace,
                                  XmlWriter xmlWriter)
        {
            _workspace = workspace;
            _xmlWriter = xmlWriter;
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
        /// Gets the xml writer.
        /// </summary>
        public XmlWriter XmlWriter
        {
            get { return _xmlWriter; }
        }
        #endregion
    }
}
