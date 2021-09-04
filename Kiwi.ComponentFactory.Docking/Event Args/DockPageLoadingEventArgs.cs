using Kiwi.ComponentFactory.Navigator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Event data for loading docking page configuration.
	/// </summary>
    public class DockPageLoadingEventArgs : DockGlobalLoadingEventArgs
    {
        #region Instance Fields
        private KiwiPage _page;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the DockPageLoadingEventArgs class.
        /// </summary>
        /// <param name="manager">Reference to owning docking manager instance.</param>
        /// <param name="xmlReading">Xml reader for persisting custom data.</param>
        /// <param name="page">Reference to page being loaded.</param>
        public DockPageLoadingEventArgs(KiwiDockingManager manager,
                                        XmlReader xmlReading,
                                        KiwiPage page)
            : base(manager, xmlReading)
        {
            _page = page;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets the loading page reference.
        /// </summary>
        public KiwiPage Page
        {
            get { return _page; }
        }
        #endregion
    }
}
