using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Workspace
{
    internal class KiwiWorkspaceSequenceDesigner : ComponentDesigner
    {
        #region Instance Fields
        private KiwiWorkspaceSequence _sequence;
        private IComponentChangeService _changeService;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiWorkspaceSequenceDesigner class.
		/// </summary>
        public KiwiWorkspaceSequenceDesigner()
        {
        }
        #endregion

        #region Public
        /// <summary>
        /// Initializes the designer with the specified component.
        /// </summary>
        /// <param name="component">The IComponent to associate the designer with.</param>
        public override void Initialize(IComponent component)
        {
            Debug.Assert(component != null);

            // Validate the parameter reference
            if (component == null) throw new ArgumentNullException("component");

            // Let base class do standard stuff
            base.Initialize(component);

            // Cast to correct type
            _sequence = (KiwiWorkspaceSequence)component;

            // Get access to the services
            _changeService = (IComponentChangeService)GetService(typeof(IComponentChangeService));

            // We need to know when we are being removed/changed
            _changeService.ComponentRemoving += new ComponentEventHandler(OnComponentRemoving);
        }

        /// <summary>
        /// Gets the collection of components associated with the component managed by the designer.
        /// </summary>
        public override ICollection AssociatedComponents
        {
            get
            {
                // Create a new compound array
                ArrayList compound = new ArrayList();

                // Add the list of collection items
                compound.AddRange(_sequence.Children);

                return compound;
            }
        }
        #endregion

        #region Protected
        /// <summary>
        /// Releases all resources used by the component. 
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing)
                {
                    _changeService.ComponentRemoving -= new ComponentEventHandler(OnComponentRemoving);
                }
            }
            finally
            {
                // Must let base class do standard stuff
                base.Dispose(disposing);
            }
        }
        #endregion

        #region Implementation
        private void OnComponentRemoving(object sender, ComponentEventArgs e)
        {
            // If our sequence is being removed
            if (e.Component == _sequence)
            {
                // Need access to host in order to delete a component
                IDesignerHost host = (IDesignerHost)GetService(typeof(IDesignerHost));

                // Climb the workspace item tree to get the top most sequence
                KiwiWorkspace workspace = null;
                IWorkspaceItem workspaceItem = _sequence;
                while (workspaceItem.WorkspaceParent != null)
                    workspaceItem = workspaceItem.WorkspaceParent;

                // Grab the workspace control that contains the top most sequence
                if ((workspaceItem != null) && (workspaceItem is KiwiWorkspaceSequence))
                {
                    KiwiWorkspaceSequence sequence = (KiwiWorkspaceSequence)workspaceItem;
                    workspace = sequence.WorkspaceControl;
                }

                // We need to remove all children from the sequence
                for (int j = _sequence.Children.Count - 1; j >= 0; j--)
                {
                    Component comp = _sequence.Children[j] as Component;

                    // If the component is a control...
                    if ((comp is Control) && (workspace != null))
                    {
                        // We need to manually remove it from the workspace controls collection
                        KiwiReadOnlyControls readOnlyControls = (KiwiReadOnlyControls)workspace.Controls;
                        readOnlyControls.RemoveInternal(comp as Control);
                    }

                    host.DestroyComponent(comp);

                    // Must remove the child after it has been destroyed otherwise the component destroy method 
                    // will not be able to climb the sequence chain to find the parent workspace instance
                    _sequence.Children.Remove(comp);
                }
            }
        }
        #endregion
    }
}
