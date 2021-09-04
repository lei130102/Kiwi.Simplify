using Kiwi.ComponentFactory.Navigator;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Windows.Forms.Design;

namespace Kiwi.ComponentFactory.Workspace
{
    internal class KiwiWorkspaceCellDesigner : KiwiNavigatorDesigner
    {
        #region Public
        /// <summary>
        /// Gets the selection rules that indicate the movement capabilities of a component.
        /// </summary>
        public override SelectionRules SelectionRules
        {
            get { return SelectionRules.None; }
        }
        #endregion

        #region Implementation
        /// <summary>
        /// Occurs when the component is being removed from the designer.
        /// </summary>
        /// <param name="sender">Source of the event.</param>
        /// <param name="e">A ComponentEventArgs containing event data.</param>
        protected override void OnComponentRemoving(object sender, ComponentEventArgs e)
        {
            // If our control is being removed
            if (e.Component == Navigator)
            {
                // If this workspace cell is inside a parent
                KiwiWorkspaceCell cell = (KiwiWorkspaceCell)Navigator;
                if (cell.WorkspaceParent != null)
                {
                    // Cell an only be inside a workspace sequence
                    KiwiWorkspaceSequence sequence = (KiwiWorkspaceSequence)cell.WorkspaceParent;
                    if (sequence != null)
                    {
                        // Remove the cell from the parent
                        sequence.Children.Remove(cell);
                    }
                }
            }

            base.OnComponentRemoving(sender, e);
        }
        #endregion
    }
}
