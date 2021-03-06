using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Toolkit
{
    internal class KiwiGroupActionList : DesignerActionList
    {
        #region Instance Fields
        private KiwiGroup _group;
        private IComponentChangeService _service;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiGroupActionList class.
        /// </summary>
        /// <param name="owner">Designer that owns this action list instance.</param>
        public KiwiGroupActionList(KiwiGroupDesigner owner)
            : base(owner.Component)
        {
            // Remember the group instance
            _group = owner.Component as KiwiGroup;

            // Cache service used to notify when a property has changed
            _service = (IComponentChangeService)GetService(typeof(IComponentChangeService));
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets and sets the group background style.
        /// </summary>
        public PaletteBackStyle GroupBackStyle
        {
            get { return _group.GroupBackStyle; }

            set
            {
                if (_group.GroupBackStyle != value)
                {
                    _service.OnComponentChanged(_group, null, _group.GroupBackStyle, value);
                    _group.GroupBackStyle = value;
                }
            }
        }

        /// <summary>
        /// Gets and sets the group border style.
        /// </summary>
        public PaletteBorderStyle GroupBorderStyle
        {
            get { return _group.GroupBorderStyle; }

            set
            {
                if (_group.GroupBorderStyle != value)
                {
                    _service.OnComponentChanged(_group, null, _group.GroupBorderStyle, value);
                    _group.GroupBorderStyle = value;
                }
            }
        }

        /// <summary>
        /// Gets and sets the palette mode.
        /// </summary>
        public PaletteMode PaletteMode
        {
            get { return _group.PaletteMode; }

            set
            {
                if (_group.PaletteMode != value)
                {
                    _service.OnComponentChanged(_group, null, _group.PaletteMode, value);
                    _group.PaletteMode = value;
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
            if (_group != null)
            {
                // Add the list of panel specific actions
                actions.Add(new DesignerActionHeaderItem("Appearance"));
                actions.Add(new DesignerActionPropertyItem("GroupBackStyle", "Back style", "Appearance", "Background style"));
                actions.Add(new DesignerActionPropertyItem("GroupBorderStyle", "Border style", "Appearance", "Border style"));
                actions.Add(new DesignerActionHeaderItem("Visuals"));
                actions.Add(new DesignerActionPropertyItem("PaletteMode", "Palette", "Visuals", "Palette applied to drawing"));
            }

            return actions;
        }
        #endregion
    }
}
