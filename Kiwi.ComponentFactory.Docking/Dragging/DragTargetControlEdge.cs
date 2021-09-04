using Kiwi.ComponentFactory.Navigator;
using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Target one of the four sides of a docking control.
    /// </summary>
    public class DragTargetControlEdge : DragTarget
    {
        #region Instance Fields
        private VisualOrientation _edge;
        private KiwiDockingControl _controlElement;
        private bool _outsideEdge;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the DragTargetControlEdge class.
        /// </summary>
        /// <param name="screenRect">Rectangle for screen area.</param>
        /// <param name="hotRect">Rectangle for hot area.</param>
        /// <param name="drawRect">Rectangle for draw area.</param>
        /// <param name="hint">Target hint which should be one of the edges.</param>
        /// <param name="controlElement">Workspace instance that contains cell.</param>
        /// <param name="allowFlags">Only drop pages that have one of these flags defined.</param>
        /// <param name="outsideEdge">Add to the outside edge (otherwise the inner edge).</param>
        public DragTargetControlEdge(Rectangle screenRect,
                                     Rectangle hotRect,
                                     Rectangle drawRect,
                                     DragTargetHint hint,
                                     KiwiDockingControl controlElement,
                                     KiwiPageFlags allowFlags,
                                     bool outsideEdge)
            : base(screenRect, hotRect, drawRect, hint, allowFlags)
        {
            _controlElement = controlElement;
            _outsideEdge = outsideEdge;

            // Find the orientation by looking for a matching hint (we need to exclude flags from the hint enum)
            switch (hint & DragTargetHint.ExcludeFlags)
            {
                case DragTargetHint.Transfer:
                case DragTargetHint.EdgeLeft:
                    _edge = VisualOrientation.Left;
                    break;
                case DragTargetHint.EdgeRight:
                    _edge = VisualOrientation.Right;
                    break;
                case DragTargetHint.EdgeTop:
                    _edge = VisualOrientation.Top;
                    break;
                case DragTargetHint.EdgeBottom:
                    _edge = VisualOrientation.Bottom;
                    break;
                default:
                    Debug.Assert(false);
                    throw new ArgumentOutOfRangeException("Hint must be an edge value.");
            }
        }

        /// <summary>
        /// Release unmanaged and optionally managed resources.
        /// </summary>
        /// <param name="disposing">Called from Dispose method.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
                _controlElement = null;

            base.Dispose(disposing);
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets the dragging edge.
        /// </summary>
        public VisualOrientation Edge
        {
            get { return _edge; }
        }

        /// <summary>
        /// Gets the target docking element.
        /// </summary>
        public KiwiDockingControl ControlElement
        {
            get { return _controlElement; }
        }

        /// <summary>
        /// Is this target a match for the provided screen position.
        /// </summary>
        /// <param name="screenPt">Position in screen coordinates.</param>
        /// <param name="dragEndData">Data to be dropped at destination.</param>
        /// <returns>True if a match; otherwise false.</returns>
        public override bool IsMatch(Point screenPt, PageDragEndData dragEndData)
        {
            return true;
        }

        /// <summary>
        /// Perform the drop action associated with the target.
        /// </summary>
        /// <param name="screenPt">Position in screen coordinates.</param>
        /// <param name="data">Data to pass to the target to process drop.</param>
        /// <returns>Drop was performed and the source can perform any removal of pages as required.</returns>
        public override bool PerformDrop(Point screenPt, PageDragEndData data)
        {
            // Find our docking edge
            KiwiDockingEdge dockingEdge = null;
            switch (Edge)
            {
                case VisualOrientation.Left:
                    dockingEdge = ControlElement["Left"] as KiwiDockingEdge;
                    break;
                case VisualOrientation.Right:
                    dockingEdge = ControlElement["Right"] as KiwiDockingEdge;
                    break;
                case VisualOrientation.Top:
                    dockingEdge = ControlElement["Top"] as KiwiDockingEdge;
                    break;
                case VisualOrientation.Bottom:
                    dockingEdge = ControlElement["Bottom"] as KiwiDockingEdge;
                    break;
            }

            if (dockingEdge != null)
            {
                // Find the docked edge
                KiwiDockingEdgeDocked dockedEdge = dockingEdge["Docked"] as KiwiDockingEdgeDocked;
                if (dockingEdge != null)
                {
                    KiwiDockingManager manager = dockedEdge.DockingManager;
                    if (manager != null)
                    {
                        // Create a list of pages that are allowed to be transferred into the dockspace
                        List<KiwiPage> transferPages = new List<KiwiPage>();
                        List<string> transferUniqueNames = new List<string>();
                        foreach (KiwiPage page in data.Pages)
                            if (page.AreFlagsSet(KiwiPageFlags.DockingAllowDocked))
                            {
                                // Use event to indicate the page is becoming docked and allow it to be cancelled
                                CancelUniqueNameEventArgs args = new CancelUniqueNameEventArgs(page.UniqueName, false);
                                manager.RaisePageDockedRequest(args);

                                if (!args.Cancel)
                                {
                                    transferPages.Add(page);
                                    transferUniqueNames.Add(page.UniqueName);
                                }
                            }

                        // Transfer valid pages into the new dockspace
                        if (transferPages.Count > 0)
                        {
                            // Convert the incoming pages into store pages for restoring later
                            manager.PropogateAction(DockingPropogateAction.StorePages, transferUniqueNames.ToArray());

                            // Create a new dockspace at the start of the list so it is closest to the control edge
                            KiwiDockingDockspace dockspace = (_outsideEdge ? dockedEdge.InsertDockspace(0) : dockedEdge.AppendDockspace());

                            // Add pages into the target
                            dockspace.Append(transferPages.ToArray());

                            return true;
                        }
                    }
                }
            }

            return false;
        }
        #endregion
    }
}
