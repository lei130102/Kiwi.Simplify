using Kiwi.ComponentFactory.Navigator;
using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Workspace
{
    /// <summary>
    /// Proxy class for receiving page notifications.
    /// </summary>
    public class CellPageNotify : IDragPageNotify
    {
        #region Instance Fields
        private KiwiWorkspace _workspace;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the CellPageNotify class.
        /// </summary>
        /// <param name="workspace">Reference to owning workspace.</param>
        public CellPageNotify(KiwiWorkspace workspace)
        {
            _workspace = workspace;
        }
        #endregion

        #region Public
        /// <summary>
        /// Occurs when a page drag is about to begin and allows it to be cancelled.
        /// </summary>
        /// <param name="sender">Source of the page drag; should never be null.</param>
        /// <param name="navigator">Navigator instance associated with source; can be null.</param>
        /// <param name="e">Event arguments indicating list of pages being dragged.</param>
        public void PageDragStart(object sender, KiwiNavigator navigator, PageDragCancelEventArgs e)
        {
            _workspace.InternalPageDragStart(sender, navigator, e);
        }

        /// <summary>
        /// Occurs when the mouse moves during the drag operation.
        /// </summary>
        /// <param name="sender">Source of the page drag; can be null.</param>
        /// <param name="e">Event arguments containing the new screen point of the mouse.</param>
        public void PageDragMove(object sender, PointEventArgs e)
        {
            _workspace.InternalPageDragMove(sender as KiwiNavigator, e);
        }

        /// <summary>
        /// Occurs when drag operation completes with pages being dropped.
        /// </summary>
        /// <param name="sender">Source of the page drag; can be null.</param>
        /// <param name="e">Event arguments containing the new screen point of the mouse.</param>
        /// <returns>Drop was performed and the source can perform any removal of pages as required.</returns>
        public bool PageDragEnd(object sender, PointEventArgs e)
        {
            return _workspace.InternalPageDragEnd(sender as KiwiNavigator, e);
        }

        /// <summary>
        /// Occurs when dragging pages has been cancelled.
        /// </summary>
        /// <param name="sender">Source of the page drag; can be null.</param>
        public void PageDragQuit(object sender)
        {
            _workspace.InternalPageDragQuit(sender as KiwiNavigator);
        }
        #endregion
    }
}
