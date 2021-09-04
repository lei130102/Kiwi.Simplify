using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
	/// Details of the context menu showing related to a bread crumb.
	/// </summary>
    public class BreadCrumbMenuArgs : ContextPositionMenuArgs
    {
        #region Instance Fields
        private KiwiBreadCrumbItem _crumb;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ContextMenuArgs class.
        /// </summary>
        /// <param name="crumb">Reference to related crumb.</param>
        /// <param name="kcm">KiwiContextMenu that can be customized.</param>
        /// <param name="positionH">Relative horizontal position of the KiwiContextMenu.</param>
        /// <param name="positionV">Relative vertical position of the KiwiContextMenu.</param>
        public BreadCrumbMenuArgs(KiwiBreadCrumbItem crumb,
                                  KiwiContextMenu kcm,
                                  KiwiContextMenuPositionH positionH,
                                  KiwiContextMenuPositionV positionV)
            : base(null, kcm, positionH, positionV)
        {
            _crumb = crumb;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets and sets the crumb related to the event.
        /// </summary>
        public KiwiBreadCrumbItem Crumb
        {
            get { return _crumb; }
            set { _crumb = value; }
        }
        #endregion
    }
}
