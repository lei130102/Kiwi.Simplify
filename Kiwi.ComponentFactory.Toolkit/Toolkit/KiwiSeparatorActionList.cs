using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Toolkit
{
    internal class KiwiSeparatorActionList : DesignerActionList
    {
        #region Instance Fields
        private KiwiSeparator _separator;
        private IComponentChangeService _service;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiSeparatorActionList class.
        /// </summary>
        /// <param name="owner">Designer that owns this action list instance.</param>
        public KiwiSeparatorActionList(KiwiSeparatorDesigner owner)
            : base(owner.Component)
        {
            // Remember the link label instance
            _separator = owner.Component as KiwiSeparator;

            // Cache service used to notify when a property has changed
            _service = (IComponentChangeService)GetService(typeof(IComponentChangeService));
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets and sets the separator style.
        /// </summary>
        public SeparatorStyle SeparatorStyle
        {
            get { return _separator.SeparatorStyle; }

            set
            {
                if (_separator.SeparatorStyle != value)
                {
                    _service.OnComponentChanged(_separator, null, _separator.SeparatorStyle, value);
                    _separator.SeparatorStyle = value;
                }
            }
        }

        /// <summary>
        /// Gets and sets the visual orientation.
        /// </summary>
        public Orientation Orientation
        {
            get { return _separator.Orientation; }

            set
            {
                if (_separator.Orientation != value)
                {
                    _service.OnComponentChanged(_separator, null, _separator.Orientation, value);
                    _separator.Orientation = value;
                }
            }
        }

        /// <summary>
        /// Gets and sets the palette mode.
        /// </summary>
        public PaletteMode PaletteMode
        {
            get { return _separator.PaletteMode; }

            set
            {
                if (_separator.PaletteMode != value)
                {
                    _service.OnComponentChanged(_separator, null, _separator.PaletteMode, value);
                    _separator.PaletteMode = value;
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
            if (_separator != null)
            {
                // Add the list of label specific actions
                actions.Add(new DesignerActionHeaderItem("Appearance"));
                actions.Add(new DesignerActionPropertyItem("SeparatorStyle", "Style", "Appearance", "Separator style"));
                actions.Add(new DesignerActionPropertyItem("Orientation", "Orientation", "Appearance", "Visual orientation"));
                actions.Add(new DesignerActionHeaderItem("Visuals"));
                actions.Add(new DesignerActionPropertyItem("PaletteMode", "Palette", "Visuals", "Palette applied to drawing"));
            }

            return actions;
        }
        #endregion   
    }
}
