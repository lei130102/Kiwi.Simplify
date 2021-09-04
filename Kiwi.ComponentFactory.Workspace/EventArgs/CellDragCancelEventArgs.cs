using Kiwi.ComponentFactory.Navigator;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Workspace
{
    /// <summary>
	/// Details for an cancellable event that provides pages and cell associated with a page dragging event.
	/// </summary>
    public class CellDragCancelEventArgs : PageDragCancelEventArgs
    {
        #region Instance Fields
        private KiwiWorkspaceCell _cell;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the CellDragCancelEventArgs class.
        /// </summary>
        /// <param name="screenPoint">Screen point of the mouse.</param>
        /// <param name="screenOffset">Screen offset of the mouse to the source element.</param>
        /// <param name="c">Control that started the drag operation.</param>
        /// <param name="pages">Array of event associated pages.</param>
        /// <param name="cell">Workspace cell associated with pages.</param>
        public CellDragCancelEventArgs(Point screenPoint,
                                       Point screenOffset,
                                       Control c,
                                       KiwiPage[] pages,
                                       KiwiWorkspaceCell cell)
            : base(screenPoint, screenOffset, c, pages)
        {
            _cell = cell;
        }

        /// <summary>
        /// Initialize a new instance of the CellDragCancelEventArgs class.
        /// </summary>
        /// <param name="e">Event to upgrade to this event.</param>
        /// <param name="cell">Workspace cell associated with pages.</param>
        public CellDragCancelEventArgs(PageDragCancelEventArgs e,
                                       KiwiWorkspaceCell cell)
            : base(e.ScreenPoint, e.ElementOffset, e.Control, e.Pages)
        {
            _cell = cell;
        }
        #endregion

        #region Cell
        /// <summary>
        /// Gets access to associated workspace cell.
        /// </summary>
        public KiwiWorkspaceCell Cell
        {
            get { return _cell; }
        }
        #endregion
    }
}
