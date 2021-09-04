using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
	/// Details for context menu related events that have a requested relative position.
	/// </summary>
    public class ContextPositionMenuArgs : ContextMenuArgs
    {
        #region Instance Fields
        private KiwiContextMenuPositionH _positionH;
        private KiwiContextMenuPositionV _positionV;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ContextMenuArgs class.
        /// </summary>
        public ContextPositionMenuArgs()
            : this(null, null, KiwiContextMenuPositionH.Left, KiwiContextMenuPositionV.Below)
        {
        }

        /// <summary>
        /// Initialize a new instance of the ContextMenuArgs class.
		/// </summary>
        /// <param name="cms">Context menu strip that can be customized.</param>
        public ContextPositionMenuArgs(ContextMenuStrip cms)
            : this(cms, null, KiwiContextMenuPositionH.Left, KiwiContextMenuPositionV.Below)
        {
        }

        /// <summary>
        /// Initialize a new instance of the ContextMenuArgs class.
        /// </summary>
        /// <param name="kcm">KiwiContextMenu that can be customized.</param>
        /// <param name="positionH">Relative horizontal position of the KiwiContextMenu.</param>
        /// <param name="positionV">Relative vertical position of the KiwiContextMenu.</param>
        public ContextPositionMenuArgs(KiwiContextMenu kcm,
                                       KiwiContextMenuPositionH positionH,
                                       KiwiContextMenuPositionV positionV)
            : this(null, kcm, positionH, positionV)
        {
        }

        /// <summary>
        /// Initialize a new instance of the ContextMenuArgs class.
        /// </summary>
        /// <param name="cms">Context menu strip that can be customized.</param>
        /// <param name="kcm">KiwiContextMenu that can be customized.</param>
        /// <param name="positionH">Relative horizontal position of the KiwiContextMenu.</param>
        /// <param name="positionV">Relative vertical position of the KiwiContextMenu.</param>
        public ContextPositionMenuArgs(ContextMenuStrip cms,
                                       KiwiContextMenu kcm,
                                       KiwiContextMenuPositionH positionH,
                                       KiwiContextMenuPositionV positionV)
            : base(cms, kcm)
        {
            _positionH = positionH;
            _positionV = positionV;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets and sets the relative horizontal position of the KiwiContextMenu.
        /// </summary>
        public KiwiContextMenuPositionH PositionH
        {
            get { return _positionH; }
            set { _positionH = value; }
        }

        /// <summary>
        /// Gets and sets the relative vertical position of the KiwiContextMenu.
        /// </summary>
        public KiwiContextMenuPositionV PositionV
        {
            get { return _positionV; }
            set { _positionV = value; }
        }
        #endregion
    }
}
