using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Ribbon
{
    internal class KiwiRibbonActionList : DesignerActionList
    {
        #region Instance Fields
        private KiwiRibbon _ribbon;
        private IComponentChangeService _service;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiRibbonActionList class.
        /// </summary>
        /// <param name="owner">Designer that owns this action list instance.</param>
        public KiwiRibbonActionList(KiwiRibbonDesigner owner)
            : base(owner.Component)
        {
            // Remember the ribbon instance
            _ribbon = (KiwiRibbon)owner.Component;

            // Cache service used to notify when a property has changed
            _service = (IComponentChangeService)GetService(typeof(IComponentChangeService));
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets and sets use of design time helpers.
        /// </summary>
        public bool InDesignHelperMode
        {
            get { return _ribbon.InDesignHelperMode; }
            set { _ribbon.InDesignHelperMode = value; }
        }

        /// <summary>
        /// Gets and sets the palette mode.
        /// </summary>
        public PaletteMode PaletteMode
        {
            get { return _ribbon.PaletteMode; }

            set
            {
                if (_ribbon.PaletteMode != value)
                {
                    _service.OnComponentChanged(_ribbon, null, _ribbon.PaletteMode, value);
                    _ribbon.PaletteMode = value;
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
            if (_ribbon != null)
            {
                // Add the list of button specific actions
                actions.Add(new DesignerActionHeaderItem("Design"));
                actions.Add(new DesignerActionPropertyItem("InDesignHelperMode", "Design Helpers", "Design", "Show design time helpers for creating items."));
                actions.Add(new DesignerActionHeaderItem("Visuals"));
                actions.Add(new DesignerActionPropertyItem("PaletteMode", "Palette", "Visuals", "Palette applied to drawing"));
            }

            return actions;
        }
        #endregion
    }
}
