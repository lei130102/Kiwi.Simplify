﻿using Kiwi.ComponentFactory.Navigator;
using Kiwi.ComponentFactory.Workspace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Provides docking functionality within a floating window using a KiwiFloatspace.
    /// </summary>
    [ToolboxItem(false)]
    [DesignerCategory("code")]
    [DesignTimeVisible(false)]
    public class KiwiDockingFloatspace : KiwiDockingSpace
    {
        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiDockingFloatspace class.
        /// </summary>
        /// <param name="name">Initial name of the element.</param>
        public KiwiDockingFloatspace(string name)
            : base(name, "Floating")
        {
            // Create a new floatspace that will be a host for docking pages
            SpaceControl = new KiwiFloatspace();
            FloatspaceControl.Dock = DockStyle.Fill;
            FloatspaceControl.CellPageInserting += new EventHandler<KiwiPageEventArgs>(OnSpaceCellPageInserting);
            FloatspaceControl.PageCloseClicked += new EventHandler<UniqueNameEventArgs>(OnFloatspacePageCloseClicked);
            FloatspaceControl.PagesDoubleClicked += new EventHandler<UniqueNamesEventArgs>(OnFloatspacePagesDoubleClicked);
            FloatspaceControl.PageDropDownClicked += new EventHandler<CancelDropDownEventArgs>(OnFloatspaceDropDownClicked);
            FloatspaceControl.BeforePageDrag += new EventHandler<PageDragCancelEventArgs>(OnFloatspaceBeforePageDrag);
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets the control this element is managing.
        /// </summary>
        public KiwiFloatspace FloatspaceControl
        {
            get { return (KiwiFloatspace)SpaceControl; }
        }

        /// <summary>
        /// Propogates a request for drag targets down the hierarchy of docking elements.
        /// </summary>
        /// <param name="floatingWindow">Reference to window being dragged.</param>
        /// <param name="dragData">Set of pages being dragged.</param>
        /// <param name="targets">Collection of drag targets.</param>
        public override void PropogateDragTargets(KiwiFloatingWindow floatingWindow,
                                                  PageDragEndData dragData,
                                                  DragTargetList targets)
        {
            if (FloatspaceControl.CellVisibleCount > 0)
            {
                // Create list of the pages that are allowed to be dropped into this floatspace
                KiwiPageCollection pages = new KiwiPageCollection();
                foreach (KiwiPage page in dragData.Pages)
                    if (page.AreFlagsSet(KiwiPageFlags.DockingAllowFloating))
                        pages.Add(page);

                // Do we have any pages left for dragging?
                if (pages.Count > 0)
                {
                    DragTargetList floatspaceTargets = FloatspaceControl.GenerateDragTargets(new PageDragEndData(this, pages), KiwiPageFlags.DockingAllowFloating);
                    targets.AddRange(floatspaceTargets.ToArray());
                }
            }
        }

        /// <summary>
        /// Find the docking location of the named page.
        /// </summary>
        /// <param name="uniqueName">Unique name of the page.</param>
        /// <returns>Enumeration value indicating docking location.</returns>
        public override DockingLocation FindPageLocation(string uniqueName)
        {
            KiwiPage page = FloatspaceControl.PageForUniqueName(uniqueName);
            if ((page != null) && !(page is KiwiStorePage))
                return DockingLocation.Floating;
            else
                return DockingLocation.None;
        }

        /// <summary>
        /// Find the docking element that contains the named page.
        /// </summary>
        /// <param name="uniqueName">Unique name of the page.</param>
        /// <returns>IDockingElement reference if page is found; otherwise null.</returns>
        public override IDockingElement FindPageElement(string uniqueName)
        {
            KiwiPage page = FloatspaceControl.PageForUniqueName(uniqueName);
            if ((page != null) && !(page is KiwiStorePage))
                return this;
            else
                return null;
        }

        /// <summary>
        /// Find the docking element that contains the location specific store page for the named page.
        /// </summary>
        /// <param name="location">Location to be searched.</param>
        /// <param name="uniqueName">Unique name of the page to be found.</param>
        /// <returns>IDockingElement reference if store page is found; otherwise null.</returns>
        public override IDockingElement FindStorePageElement(DockingLocation location, string uniqueName)
        {
            if (location == DockingLocation.Floating)
            {
                KiwiPage page = FloatspaceControl.PageForUniqueName(uniqueName);
                if ((page != null) && (page is KiwiStorePage))
                    return this;
            }

            return null;
        }
        #endregion

        #region Protected
        /// <summary>
        /// Gets the proprogate action used to clear a store page for this implementation.
        /// </summary>
        protected override DockingPropogateAction ClearStoreAction
        {
            get { return DockingPropogateAction.ClearFloatingStoredPages; }
        }

        /// <summary>
        /// Occurs when a page is added to a cell in the workspace.
        /// </summary>
        /// <param name="sender">Source of the event.</param>
        /// <param name="e">A KiwiPageEventArgs containing the event data.</param>
        protected override void OnSpaceCellPageInserting(object sender, KiwiPageEventArgs e)
        {
            // Remove any store page for the unique name of this page being added. In either case of adding a store
            // page or a regular page we want to ensure there does not exist a store page for that same unique name.
            KiwiDockingManager dockingManager = DockingManager;
            if (dockingManager != null)
            {
                if (e.Item is KiwiStorePage)
                {
                    KiwiFloatspace floatspace = sender as KiwiFloatspace;
                    if ((floatspace != null) && (floatspace.CellForPage(e.Item) != null))
                    {
                        // Prevent this existing store page from being removed due to the Propogate action below. This can
                        // occur because a cell with pages is added in one go and so insert events are generated for the
                        // existing pages inside the cell to ensure that the event is always fired consistently.
                        IgnoreStorePage = (KiwiStorePage)e.Item;
                    }
                }

                dockingManager.PropogateAction(ClearStoreAction, new string[] { e.Item.UniqueName });
                IgnoreStorePage = null;
            }
        }

        /// <summary>
        /// Raises the type specific space control removed event determinated by the derived class.
        /// </summary>
        protected override void RaiseRemoved()
        {
            // Generate event so the any floatspace customization can be reversed.
            KiwiDockingManager dockingManager = DockingManager;
            if (dockingManager != null)
            {
                FloatspaceEventArgs args = new FloatspaceEventArgs(FloatspaceControl, this);
                dockingManager.RaiseFloatspaceRemoved(args);
            }

            // Generate event so interested parties know this element and associated control have been removed
            Dispose();
        }

        /// <summary>
        /// Raises the type specific cell adding event determinated by the derived class.
        /// </summary>
        /// <param name="cell">Referecence to new cell being added.</param>
        protected override void RaiseCellAdding(KiwiWorkspaceCell cell)
        {
            // Generate event so the floatspace cell customization can be performed.
            KiwiDockingManager dockingManager = DockingManager;
            if (dockingManager != null)
            {
                FloatspaceCellEventArgs args = new FloatspaceCellEventArgs(FloatspaceControl, this, cell);
                dockingManager.RaiseFloatspaceCellAdding(args);
            }
        }

        /// <summary>
        /// Raises the type specific cell removed event determinated by the derived class.
        /// </summary>
        /// <param name="cell">Referecence to an existing cell being removed.</param>
        protected override void RaiseCellRemoved(KiwiWorkspaceCell cell)
        {
            // Generate event so the floatspace cell customization can be reversed.
            KiwiDockingManager dockingManager = DockingManager;
            if (dockingManager != null)
            {
                FloatspaceCellEventArgs args = new FloatspaceCellEventArgs(FloatspaceControl, this, cell);
                dockingManager.RaiseFloatspaceCellRemoved(args);
            }
        }

        /// <summary>
        /// Occurs when a page is dropped on the control.
        /// </summary>
        /// <param name="sender">Source of the event.</param>
        /// <param name="e">A PageDropEventArgs containing the event data.</param>
        protected override void RaiseSpacePageDrop(object sender, PageDropEventArgs e)
        {
            // Use event to indicate the page is moving to a workspace and allow it to be cancelled
            KiwiDockingManager dockingManager = DockingManager;
            if (dockingManager != null)
            {
                CancelUniqueNameEventArgs args = new CancelUniqueNameEventArgs(e.Page.UniqueName, false);
                dockingManager.RaisePageFloatingRequest(args);

                // Pass back the result of the event
                e.Cancel = args.Cancel;
            }
        }

        /// <summary>
        /// Gets the xml element name to use when saving.
        /// </summary>
        protected override string XmlElementName
        {
            get { return "DF"; }
        }

        /// <summary>
        /// Loads docking configuration information using a provider xml reader.
        /// </summary>
        /// <param name="xmlReader">Xml reader object.</param>
        /// <param name="pages">Collection of available pages for adding.</param>
        public override void LoadElementFromXml(XmlReader xmlReader, KiwiPageCollection pages)
        {
            // Let base class load the pages into the floatspace
            base.LoadElementFromXml(xmlReader, pages);

            // If loading did not create any pages then kill ourself as not needed
            if (FloatspaceControl.PageCount == 0)
                FloatspaceControl.Dispose();
        }
        #endregion

        #region Implementation
        private void OnFloatspacePageCloseClicked(object sender, UniqueNameEventArgs e)
        {
            // Generate event so that the close action is handled for the named page
            KiwiDockingManager dockingManager = DockingManager;
            if (dockingManager != null)
                dockingManager.CloseRequest(new string[] { e.UniqueName });
        }

        private void OnFloatspacePagesDoubleClicked(object sender, UniqueNamesEventArgs e)
        {
            // If the number of pages to be converted into a separate floating window is less than the
            // total number of visible pages then we allow the change to occur. Otherwise it would cause
            // all pages to be removed into another window which would be pointless.
            if (e.UniqueNames.Length < FloatspaceControl.PageVisibleCount)
            {
                KiwiDockingManager dockingManager = DockingManager;
                if (dockingManager != null)
                    dockingManager.SwitchFloatingToFloatingWindowRequest(e.UniqueNames);
            }
        }

        private void OnFloatspaceDropDownClicked(object sender, CancelDropDownEventArgs e)
        {
            // Generate event so that the appropriate context menu options are preseted and actioned
            KiwiDockingManager dockingManager = DockingManager;
            if (dockingManager != null)
                e.Cancel = !dockingManager.ShowPageContextMenuRequest(e.Page, e.KiwiContextMenu);
        }

        private void OnFloatspaceBeforePageDrag(object sender, PageDragCancelEventArgs e)
        {
            // Validate the list of names to those that are still present in the floatspace
            List<KiwiPage> pages = new List<KiwiPage>();
            foreach (KiwiPage page in e.Pages)
                if (!(page is KiwiStorePage) && (FloatspaceControl.CellForPage(page) != null))
                    pages.Add(page);

            // Only need to start docking dragging if we have some valid pages
            if (pages.Count != 0)
            {
                KiwiDockingManager dockingManager = DockingManager;
                if (dockingManager != null)
                {
                    // If there is just a single visible cell
                    if (FloatspaceControl.CellVisibleCount == 1)
                    {
                        // And that visible cell has all the pages being dragged
                        KiwiWorkspaceCell cell = FloatspaceControl.FirstVisibleCell();
                        if (cell.Pages.VisibleCount == pages.Count)
                        {
                            // Get the owning floating window element
                            KiwiDockingFloatingWindow window = GetParentType(typeof(KiwiDockingFloatingWindow)) as KiwiDockingFloatingWindow;
                            if (window != null)
                            {
                                // Drag the entire floating window
                                dockingManager.DoDragDrop(e.ScreenPoint, e.ElementOffset, e.Control, window);

                                // Always take over docking
                                e.Cancel = true;
                                return;
                            }
                        }
                    }

                    // Add a placeholder for the cell that contains the dragged page, so the cell is not removed during dragging
                    KiwiWorkspaceCell firstCell = FloatspaceControl.CellForPage(e.Pages[0]);
                    if (firstCell != null)
                        firstCell.Pages.Add(new KiwiStorePage("TemporaryPage", "Floating"));

                    // Ask the docking manager for a IDragPageNotify implementation to handle the dragging operation
                    dockingManager.DoDragDrop(e.ScreenPoint, e.ElementOffset, e.Control, e.Pages);
                }
            }

            // Always take over docking
            e.Cancel = true;
        }
        #endregion
    }
}
