using Kiwi.ComponentFactory.Navigator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Event data for saving docking page configuration.
	/// </summary>
    public class DockPageSavingEventArgs : DockGlobalSavingEventArgs
    {
        #region Instance Fields
        private KiwiPage _page;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the DockPageSavingEventArgs class.
        /// </summary>
        /// <param name="manager">Reference to owning docking manager instance.</param>
        /// <param name="xmlWriter">Xml writer for persisting custom data.</param>
        /// <param name="page">Reference to page being saved.</param>
        public DockPageSavingEventArgs(KiwiDockingManager manager,
                                       XmlWriter xmlWriter,
                                       KiwiPage page)
            : base(manager, xmlWriter)
        {
            _page = page;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets the saving page reference.
        /// </summary>
        public KiwiPage Page
        {
            get { return _page; }
        }
        #endregion
    }
}
