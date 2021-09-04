using Kiwi.ComponentFactory.Navigator;
using Kiwi.ComponentFactory.Toolkit;
using Kiwi.ComponentFactory.Workspace;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Extends the KiwiWorkspace to work within the docking framework.
    /// </summary>
    [ToolboxBitmap(typeof(KiwiDockableWorkspace), "ToolboxBitmaps.KiwiDockableWorkspace.bmp")]
    public class KiwiDockableWorkspace : KiwiSpace
    {
        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiDockableWorkspace class.
        /// </summary>
        public KiwiDockableWorkspace()
            : base("Workspace")
        {
            // Override the base class and allow the workspace context menu for the tab to be shown
            ContextMenus.ShowContextMenu = true;
        }

        /// <summary>
        /// Gets a string representation of the instance.
        /// </summary>
        /// <returns>String.</returns>
        public override string ToString()
        {
            return "KiwiDockableWorkspace " + Dock.ToString();
        }
        #endregion

        #region Protected
        /// <summary>
        /// Gets a value indicating if docking specific appearance should be applied.
        /// </summary>
        protected override bool ApplyDockingAppearance
        {
            get { return false; }
        }

        /// <summary>
        /// Gets a value indicating if docking specific close action should be applied.
        /// </summary>
        protected override bool ApplyDockingCloseAction
        {
            get { return false; }
        }

        /// <summary>
        /// Gets a value indicating if docking specific pin actions should be applied.
        /// </summary>
        protected override bool ApplyDockingPinAction
        {
            get { return false; }
        }

        /// <summary>
        /// Gets a value indicating if docking specific drop down actions should be applied.
        /// </summary>
        protected override bool ApplyDockingDropDownAction
        {
            get { return false; }
        }

        /// <summary>
        /// Initialize a new cell.
        /// </summary>
        /// <param name="cell">Cell being added to the control.</param>
        protected override void NewCellInitialize(KiwiWorkspaceCell cell)
        {
            // Let base class perform event hooking and customizations
            base.NewCellInitialize(cell);

            // By default the new cell does not have focus and so should have standard looking tabs
            cell.Bar.TabStyle = TabStyle.StandardProfile;
            cell.CloseAction += new EventHandler<CloseActionEventArgs>(OnCellCloseAction);
        }

        /// <summary>
        /// Raises the ActiveCellChanged event.
        /// </summary>
        /// <param name="e">An ActiveCellChangedEventArgs containing the event data.</param>
        protected override void OnActiveCellChanged(ActiveCellChangedEventArgs e)
        {
            // Ensure all but the newly selected cell have a lower profile appearance
            KiwiWorkspaceCell cell = FirstCell();
            while (cell != null)
            {
                if (e.NewCell != cell)
                    cell.Bar.TabStyle = TabStyle.StandardProfile;
                cell = NextCell(cell);
            }

            // Ensure the newly selected cell has a higher profile appearance
            if (e.NewCell != null)
                e.NewCell.Bar.TabStyle = TabStyle.HighProfile;

            base.OnActiveCellChanged(e);
        }
        #endregion   

        #region Implementation
        private void OnCellCloseAction(object sender, CloseActionEventArgs e)
        {
            OnPageCloseClicked(new UniqueNameEventArgs(e.Item.UniqueName));
        }
        #endregion
    }
}
