using Kiwi.ComponentFactory.Navigator;
using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Event arguments for events that need a page and context menu.
	/// </summary>
	public class ContextPageEventArgs : CancelEventArgs
    {
        #region Instance Fields
        private KiwiPage _page;
        private KiwiContextMenu _contextMenu;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ContextPageEventArgs class.
        /// </summary>
        /// <param name="page">Page associated with the context menu.</param>
        /// <param name="contextMenu">Context menu that can be customized.</param>
        /// <param name="cancel">Initial value for the cancel property.</param>
        public ContextPageEventArgs(KiwiPage page,
                                    KiwiContextMenu contextMenu,
                                    bool cancel)
            : base(cancel)
        {
            _page = page;
            _contextMenu = contextMenu;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets access to page associated with the context menu.
        /// </summary>
        public KiwiPage Page
        {
            get { return _page; }
        }

        /// <summary>
        /// Gets access to context menu that can be customized.
        /// </summary>
        public KiwiContextMenu KiwiContextMenu
        {
            get { return _contextMenu; }
        }
        #endregion
    }
}
