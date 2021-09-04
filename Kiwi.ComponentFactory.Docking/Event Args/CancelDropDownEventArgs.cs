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
    /// Event arguments for cancellable events that need to provide a unique name and context menu.
	/// </summary>
    public class CancelDropDownEventArgs : CancelEventArgs
    {
        #region Instance Fields
        private KiwiContextMenu _contextMenu;
        private KiwiPage _page;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the CancelDropDownEventArgs class.
        /// </summary>
        /// <param name="contextMenu">Reference to associated context menu.</param>
        /// <param name="page">Reference to the associated page.</param>
        public CancelDropDownEventArgs(KiwiContextMenu contextMenu, KiwiPage page)
            : base(false)
        {
            _contextMenu = contextMenu;
            _page = page;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets a reference to the context menu.
        /// </summary>
        public KiwiContextMenu KiwiContextMenu
        {
            get { return _contextMenu; }
        }

        /// <summary>
        /// Gets a reference to the page.
        /// </summary>
        public KiwiPage Page
        {
            get { return _page; }
        }
        #endregion
    }
}
