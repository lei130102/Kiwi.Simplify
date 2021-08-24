using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Toolkit
{
    internal class KiwiPanelActionList : DesignerActionList
    {
        #region Instance Fields
        private KiwiPanel _panel;
        private IComponentChangeService _service;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiPanelActionList class.
        /// </summary>
        /// <param name="owner">Designer that owns this action list instance.</param>
        public KiwiPanelActionList(KiwiPanelDesigner owner)
            : base(owner.Component)
        {
            // Remember the panel instance
            _panel = owner.Component as KiwiPanel;

            // Cache service used to notify when a property has changed
            _service = (IComponentChangeService)GetService(typeof(IComponentChangeService));
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets and sets the panel background style.
        /// </summary>
        public PaletteBackStyle PanelBackStyle
        {
            get { return _panel.PanelBackStyle; }

            set
            {
                if (_panel.PanelBackStyle != value)
                {
                    _service.OnComponentChanged(_panel, null, _panel.PanelBackStyle, value);
                    _panel.PanelBackStyle = value;
                }
            }
        }

        /// <summary>
        /// Gets and sets the palette mode.
        /// </summary>
        public PaletteMode PaletteMode
        {
            get { return _panel.PaletteMode; }

            set
            {
                if (_panel.PaletteMode != value)
                {
                    _service.OnComponentChanged(_panel, null, _panel.PaletteMode, value);
                    _panel.PaletteMode = value;
                }
            }
        }
        #endregion

        #region Public Override
        /// <summary>
        /// Returns the collection of DesignerActionItem objects contained in the list.
        /// </summary>
        /// <returns>A DesignerActionItem array that contains the items in this list.</returns>
        public override DesignerActionItemCollection GetSortedActionItems()
        {
            // Create a new collection for holding the single item we want to create
            DesignerActionItemCollection actions = new DesignerActionItemCollection();

            // This can be null when deleting a control instance at design time
            if (_panel != null)
            {
                // Add the list of panel specific actions
                actions.Add(new DesignerActionHeaderItem("Appearance"));
                actions.Add(new DesignerActionPropertyItem("PanelBackStyle", "Back style", "Appearance", "Background style"));
                actions.Add(new DesignerActionHeaderItem("Visuals"));
                actions.Add(new DesignerActionPropertyItem("PaletteMode", "Palette", "Visuals", "Palette applied to drawing"));
            }

            return actions;
        }
        #endregion
    }
}
