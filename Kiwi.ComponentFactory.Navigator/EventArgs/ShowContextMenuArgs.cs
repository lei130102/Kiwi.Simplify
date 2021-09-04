using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Navigator
{
    /// <summary>
	/// Details for a close button action event.
	/// </summary>
    public class ShowContextMenuArgs : KiwiPageCancelEventArgs
    {
        #region Instance Fields
        private ContextMenuStrip _cms;
        private KiwiContextMenu _kcm;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ShowContextMenuArgs class.
        /// </summary>
        /// <param name="page">Page effected by event.</param>
        /// <param name="index">Index of page in the owning collection.</param>
        public ShowContextMenuArgs(KiwiPage page, int index)
            : base(page, index)
        {
            _cms = page.ContextMenuStrip;
            _kcm = page.KiwiContextMenu;
        }
        #endregion

        #region ContextMenuStrip
        /// <summary>
        /// Gets and sets the context menu strip.
        /// </summary>
        public ContextMenuStrip ContextMenuStrip
        {
            get { return _cms; }
            set { _cms = value; }
        }
        #endregion

        #region KiwiContextMenu
        /// <summary>
        /// Gets and sets the context menu strip.
        /// </summary>
        public KiwiContextMenu KiwiContextMenu
        {
            get { return _kcm; }
            set { _kcm = value; }
        }
        #endregion
    }
}
