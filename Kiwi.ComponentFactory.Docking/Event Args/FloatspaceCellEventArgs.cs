using Kiwi.ComponentFactory.Workspace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Event arguments for a FloatspaceCellAdding/FloatingCellRemoving events.
	/// </summary>
	public class FloatspaceCellEventArgs : EventArgs
    {
        #region Instance Fields
        private KiwiFloatspace _floatspace;
        private KiwiDockingFloatspace _element;
        private KiwiWorkspaceCell _cell;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the FloatspaceCellEventArgs class.
        /// </summary>
        /// <param name="floatspace">Reference to existing floatspace control instance.</param>
        /// <param name="element">Reference to docking floatspace element that is managing the floatspace control.</param>
        /// <param name="cell">Reference tofloatspace control cell instance.</param>
        public FloatspaceCellEventArgs(KiwiFloatspace floatspace,
                                       KiwiDockingFloatspace element,
                                       KiwiWorkspaceCell cell)
        {
            _floatspace = floatspace;
            _element = element;
            _cell = cell;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets a reference to the KiwiFloatspace control.
        /// </summary>
        public KiwiFloatspace FloatspaceControl
        {
            get { return _floatspace; }
        }

        /// <summary>
        /// Gets a reference to the KiwiDockingFloatspace that is managing the floatspace.
        /// </summary>
        public KiwiDockingFloatspace FloatspaceElement
        {
            get { return _element; }
        }

        /// <summary>
        /// Gets a reference to the KiwiWorkspaceCell control.
        /// </summary>
        public KiwiWorkspaceCell CellControl
        {
            get { return _cell; }
        }
        #endregion
    }
}
