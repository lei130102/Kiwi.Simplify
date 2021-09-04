using Kiwi.ComponentFactory.Navigator;
using Kiwi.ComponentFactory.Workspace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Extends the KiwiWorkspace to work within the docking edge of a control.
    /// </summary>
    [ToolboxItem(false)]
    [DesignerCategory("code")]
    [DesignTimeVisible(false)]
    public class KiwiDockspaceSlide : KiwiDockspace
    {
        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiDockspaceSlide class.
        /// </summary>
        public KiwiDockspaceSlide()
        {
            // Cannot drag pages inside the sliding dockspace
            AllowPageDrag = false;
        }
        #endregion

        #region Protectect
        /// <summary>
        /// Initialize a new cell.
        /// </summary>
        /// <param name="cell">Cell being added to the control.</param>
        protected override void NewCellInitialize(KiwiWorkspaceCell cell)
        {
            // Let base class perform event hooking and customizations
            base.NewCellInitialize(cell);

            // We only ever show a single page in the dockspace, so remove default 
            // tabbed appearance and instead use a header group mode instead
            cell.NavigatorMode = NavigatorMode.HeaderGroup;
        }
        #endregion
    }
}
