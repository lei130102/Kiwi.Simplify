using Kiwi.ComponentFactory.Navigator;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Workspace
{
    /// <summary>
    /// Target within the workspace.
    /// </summary>
    public abstract class DragTargetWorkspace : DragTarget
    {
        #region Instance Fields
        private KiwiWorkspace _workspace;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the DragTargetWorkspace class.
        /// </summary>
        /// <param name="screenRect">Rectangle for screen area.</param>
        /// <param name="hotRect">Rectangle for hot area.</param>
        /// <param name="drawRect">Rectangle for draw area.</param>
        /// <param name="hint">Target hint which should be one of the edges.</param>
        /// <param name="workspace">Control instance for drop.</param>
        /// <param name="allowFlags">Only drop pages that have one of these flags defined.</param>
        public DragTargetWorkspace(Rectangle screenRect,
                                   Rectangle hotRect,
                                   Rectangle drawRect,
                                   DragTargetHint hint,
                                   KiwiWorkspace workspace,
                                   KiwiPageFlags allowFlags)
            : base(screenRect, hotRect, drawRect, hint, allowFlags)
        {
            _workspace = workspace;
        }

        /// <summary>
        /// Release unmanaged and optionally managed resources.
        /// </summary>
        /// <param name="disposing">Called from Dispose method.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
                _workspace = null;

            base.Dispose(disposing);
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets the target workspace control.
        /// </summary>
        public KiwiWorkspace Workspace
        {
            get { return _workspace; }
        }
        #endregion

        #region Protected
        /// <summary>
        /// Process the drag pages in the context of a target navigator.
        /// </summary>
        /// <param name="workspace">Target workspace instance.</param>
        /// <param name="target">Target workspace cell instance.</param>
        /// <param name="data">Dragged page data.</param>
        /// <returns>Last page to be transferred.</returns>
        protected KiwiPage ProcessDragEndData(KiwiWorkspace workspace,
                                                 KiwiWorkspaceCell target,
                                                 PageDragEndData data)
        {
            KiwiPage ret = null;

            // Add each source page to the target
            foreach (KiwiPage page in data.Pages)
            {
                // Only add the page if one of the allow flags is set
                if ((page.Flags & (int)AllowFlags) != 0)
                {
                    // Use event to allow decision on if the page should be dropped
                    // (or even swap the page for a different page to be dropped)
                    PageDropEventArgs e = new PageDropEventArgs(page);
                    workspace.OnPageDrop(e);

                    if (!e.Cancel && (e.Page != null))
                    {
                        target.Pages.Add(e.Page);
                        ret = e.Page;
                    }
                }
            }

            return ret;
        }
        #endregion
    }
}
