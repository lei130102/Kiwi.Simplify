using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Toolkit
{
    internal class KiwiComboBoxActionList : DesignerActionList
    {
        #region Instance Fields
        private KiwiComboBox _comboBox;
        private IComponentChangeService _service;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiComboBoxActionList class.
        /// </summary>
        /// <param name="owner">Designer that owns this action list instance.</param>
        public KiwiComboBoxActionList(KiwiComboBoxDesigner owner)
            : base(owner.Component)
        {
            // Remember the combo box instance
            _comboBox = owner.Component as KiwiComboBox;

            // Cache service used to notify when a property has changed
            _service = (IComponentChangeService)GetService(typeof(IComponentChangeService));
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets and sets the palette mode.
        /// </summary>
        public PaletteMode PaletteMode
        {
            get { return _comboBox.PaletteMode; }

            set
            {
                if (_comboBox.PaletteMode != value)
                {
                    _service.OnComponentChanged(_comboBox, null, _comboBox.PaletteMode, value);
                    _comboBox.PaletteMode = value;
                }
            }
        }

        /// <summary>
        /// Gets and sets the input control style.
        /// </summary>
        public InputControlStyle InputControlStyle
        {
            get { return _comboBox.InputControlStyle; }

            set
            {
                if (_comboBox.InputControlStyle != value)
                {
                    _service.OnComponentChanged(_comboBox, null, _comboBox.InputControlStyle, value);
                    _comboBox.InputControlStyle = value;
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
            if (_comboBox != null)
            {
                // Add the list of label specific actions
                actions.Add(new DesignerActionHeaderItem("Appearance"));
                actions.Add(new DesignerActionPropertyItem("InputControlStyle", "Style", "Appearance", "ComboBox display style."));
                actions.Add(new DesignerActionHeaderItem("Visuals"));
                actions.Add(new DesignerActionPropertyItem("PaletteMode", "Palette", "Visuals", "Palette applied to drawing"));
            }

            return actions;
        }
        #endregion
    }
}
