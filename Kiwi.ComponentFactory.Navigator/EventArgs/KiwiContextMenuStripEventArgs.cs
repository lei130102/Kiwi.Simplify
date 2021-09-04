using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Navigator
{
    /// <summary>
	/// Details providing a KiwiContextMenu instance.
	/// </summary>
    public class KiwiContextMenuEventArgs : KiwiPageEventArgs
    {
        #region Instance Fields
        private KiwiContextMenu _contextMenu;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiContextMenuEventArgs class.
        /// </summary>
        /// <param name="page">Page effected by event.</param>
        /// <param name="index">Index of page in the owning collection.</param>
        /// <param name="contextMenu">Prepopulated context menu ready for display.</param>
        public KiwiContextMenuEventArgs(KiwiPage page,
                                           int index,
                                           KiwiContextMenu contextMenu)
            : base(page, index)
        {
            _contextMenu = contextMenu;
        }
        #endregion

        #region KiwiContextMenu
        /// <summary>
        /// Gets access to the KiwiContextMenu that is to be shown.
        /// </summary>
        public KiwiContextMenu KiwiContextMenu
        {
            get { return _contextMenu; }
        }
        #endregion
    }
}
