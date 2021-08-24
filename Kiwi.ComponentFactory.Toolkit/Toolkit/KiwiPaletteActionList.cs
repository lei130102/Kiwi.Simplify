using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Toolkit
{
    internal class KiwiPaletteActionList : DesignerActionList
    {
        #region Instance Fields
        private KiwiPalette _palette;
        private IComponentChangeService _service;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiPaletteActionList class.
        /// </summary>
        /// <param name="owner">Designer that owns this action list instance.</param>
        public KiwiPaletteActionList(KiwiPaletteDesigner owner)
            : base(owner.Component)
        {
            // Remember the panel instance
            _palette = owner.Component as KiwiPalette;

            // Cache service used to notify when a property has changed
            _service = (IComponentChangeService)GetService(typeof(IComponentChangeService));
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

            // This can be null when deleting a component instance at design time
            if (_palette != null)
            {
                // Add the list of panel specific actions
                actions.Add(new KiwiDesignerActionItem(new DesignerVerb("Reset to Defaults", new EventHandler(OnResetClick)), "Actions"));
                actions.Add(new KiwiDesignerActionItem(new DesignerVerb("Populate from Base", new EventHandler(OnPopulateClick)), "Actions"));
                actions.Add(new KiwiDesignerActionItem(new DesignerVerb("Import from Xml file...", new EventHandler(OnImportClick)), "Actions"));
                actions.Add(new KiwiDesignerActionItem(new DesignerVerb("Export to Xml file...", new EventHandler(OnExportClick)), "Actions"));
            }

            return actions;
        }
        #endregion

        #region Implementation
        private void OnResetClick(object sender, EventArgs e)
        {
            if (_palette != null)
            {
                if (MessageBox.Show("Are you sure you want to reset the palette?",
                                    "Palette Reset",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _palette.ResetToDefaults(false);
                    _service.OnComponentChanged(_palette, null, null, null);
                }
            }
        }

        private void OnPopulateClick(object sender, EventArgs e)
        {
            if (_palette != null)
            {
                if (MessageBox.Show("Are you sure you want to populate from the base?",
                                    "Populate From Base",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _palette.PopulateFromBase(false);
                    _service.OnComponentChanged(_palette, null, null, null);
                }
            }
        }

        private void OnImportClick(object sender, EventArgs e)
        {
            if (_palette != null)
            {
                _palette.Import();
                _service.OnComponentChanged(_palette, null, null, null);
            }
        }

        private void OnExportClick(object sender, EventArgs e)
        {
            if (_palette != null)
                _palette.Export();
        }
        #endregion
    }
}
