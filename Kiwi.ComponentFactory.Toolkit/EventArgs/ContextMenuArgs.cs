using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
	/// Details for context menu related events.
	/// </summary>
	public class ContextMenuArgs : CancelEventArgs
    {
        #region Instance Fields
        private ContextMenuStrip _cms;
        private KiwiContextMenu _kcm;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ContextMenuArgs class.
        /// </summary>
        public ContextMenuArgs()
            : this(null, null)
        {
        }

        /// <summary>
        /// Initialize a new instance of the ContextMenuArgs class.
		/// </summary>
        /// <param name="cms">Context menu strip that can be customized.</param>
        public ContextMenuArgs(ContextMenuStrip cms)
            : this(cms, null)
        {
        }

        /// <summary>
        /// Initialize a new instance of the ContextMenuArgs class.
        /// </summary>
        /// <param name="kcm">KiwiContextMenu that can be customized.</param>
        public ContextMenuArgs(KiwiContextMenu kcm)
            : this(null, kcm)
        {
        }

        /// <summary>
        /// Initialize a new instance of the ContextMenuArgs class.
        /// </summary>
        /// <param name="cms">Context menu strip that can be customized.</param>
        /// <param name="kcm">KiwiContextMenu that can be customized.</param>
        public ContextMenuArgs(ContextMenuStrip cms,
                               KiwiContextMenu kcm)
        {
            _cms = cms;
            _kcm = kcm;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets access to the context menu strip instance.
        /// </summary>
        public ContextMenuStrip ContextMenuStrip
        {
            get { return _cms; }
        }

        /// <summary>
        /// Gets access to the KiwiContextMenu instance.
        /// </summary>
        public KiwiContextMenu KiwiContextMenu
        {
            get { return _kcm; }
        }
        #endregion
    }
}
