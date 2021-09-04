﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Toolkit
{
    internal class KiwiDomainUpDownColumnDesigner : ComponentDesigner
    {
        #region Instance Fields
        private KiwiDataGridViewDomainUpDownColumn _domainUpDown;
        private IComponentChangeService _changeService;
        #endregion

        #region Public Overrides
        /// <summary>
        /// Initializes the designer with the specified component.
        /// </summary>
        /// <param name="component">The IComponent to associate the designer with.</param>
        public override void Initialize(IComponent component)
        {
            // Let base class do standard stuff
            base.Initialize(component);

            // Cast to correct type
            _domainUpDown = component as KiwiDataGridViewDomainUpDownColumn;

            // Get access to the design services
            _changeService = (IComponentChangeService)GetService(typeof(IComponentChangeService));
        }

        /// <summary>
        /// Gets the collection of components associated with the component managed by the designer.
        /// </summary>
        public override ICollection AssociatedComponents
        {
            get
            {
                if (_domainUpDown != null)
                    return _domainUpDown.ButtonSpecs;
                else
                    return base.AssociatedComponents;
            }
        }
        #endregion

        #region Private
        private void OnComponentRemoving(object sender, ComponentEventArgs e)
        {
            // If our control is being removed
            if ((_domainUpDown != null) && (e.Component == _domainUpDown))
            {
                // Need access to host in order to delete a component
                IDesignerHost host = (IDesignerHost)GetService(typeof(IDesignerHost));

                // We need to remove all the button spec instances
                for (int i = _domainUpDown.ButtonSpecs.Count - 1; i >= 0; i--)
                {
                    // Get access to the indexed button spec
                    ButtonSpec spec = _domainUpDown.ButtonSpecs[i];

                    // Must wrap button spec removal in change notifications
                    _changeService.OnComponentChanging(_domainUpDown, null);

                    // Perform actual removal of button spec from textbox
                    _domainUpDown.ButtonSpecs.Remove(spec);

                    // Get host to remove it from design time
                    host.DestroyComponent(spec);

                    // Must wrap button spec removal in change notifications
                    _changeService.OnComponentChanged(_domainUpDown, null, null, null);
                }
            }
        }
        #endregion
    }
}
