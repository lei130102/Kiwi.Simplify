using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Toolkit
{
    internal class KiwiWrapLabelActionList : DesignerActionList
    {
        #region Instance Fields
        private KiwiWrapLabel _wrapLabel;
        private IComponentChangeService _service;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiWrapLabelActionList class.
        /// </summary>
        /// <param name="owner">Designer that owns this action list instance.</param>
        public KiwiWrapLabelActionList(KiwiWrapLabelDesigner owner)
            : base(owner.Component)
        {
            // Remember the label instance
            _wrapLabel = owner.Component as KiwiWrapLabel;

            // Cache service used to notify when a property has changed
            _service = (IComponentChangeService)GetService(typeof(IComponentChangeService));
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets and sets the label style.
        /// </summary>
        public LabelStyle LabelStyle
        {
            get { return _wrapLabel.LabelStyle; }

            set
            {
                if (_wrapLabel.LabelStyle != value)
                {
                    _service.OnComponentChanged(_wrapLabel, null, _wrapLabel.LabelStyle, value);
                    _wrapLabel.LabelStyle = value;
                }
            }
        }

        /// <summary>
        /// Gets and sets the palette mode.
        /// </summary>
        public PaletteMode PaletteMode
        {
            get { return _wrapLabel.PaletteMode; }

            set
            {
                if (_wrapLabel.PaletteMode != value)
                {
                    _service.OnComponentChanged(_wrapLabel, null, _wrapLabel.PaletteMode, value);
                    _wrapLabel.PaletteMode = value;
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
            if (_wrapLabel != null)
            {
                actions.Add(new DesignerActionHeaderItem("Appearance"));
                actions.Add(new DesignerActionPropertyItem("LabelStyle", "Style", "Appearance", "Label style"));
                actions.Add(new DesignerActionHeaderItem("Visuals"));
                actions.Add(new DesignerActionPropertyItem("PaletteMode", "Palette", "Visuals", "Palette applied to drawing"));
            }

            return actions;
        }
        #endregion
    }
}
