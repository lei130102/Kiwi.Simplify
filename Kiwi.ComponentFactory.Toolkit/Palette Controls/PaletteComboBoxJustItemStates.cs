using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
	/// Implement storage for just the item part of a combo box state.
	/// </summary>
	public class PaletteComboBoxJustItemStates : Storage
    {
        #region Instance Fields
        private PaletteTriple _itemState;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PaletteComboBoxJustItemStates class.
        /// </summary>
        /// <param name="inheritItem">Source for inheriting item values.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public PaletteComboBoxJustItemStates(IPaletteTriple inheritItem,
                                             NeedPaintHandler needPaint)
        {
            Debug.Assert(inheritItem != null);

            // Store the provided paint notification delegate
            NeedPaint = needPaint;

            // Create storage that maps onto the inherit instances
            _itemState = new PaletteTriple(inheritItem, needPaint);
        }
        #endregion

        #region IsDefault
        /// <summary>
        /// Gets a value indicating if all values are default.
        /// </summary>
        [Browsable(false)]
        public override bool IsDefault
        {
            get
            {
                return Item.IsDefault;
            }
        }
        #endregion

        #region SetInherit
        /// <summary>
        /// Sets the inheritence parent.
        /// </summary>
        /// <param name="inheritItem">Source for inheriting item values.</param>
        public void SetInherit(IPaletteTriple inheritItem)
        {
            _itemState.SetInherit(inheritItem);
        }
        #endregion

        #region PopulateFromBase
        /// <summary>
        /// Populate values from the base palette.
        /// </summary>
        /// <param name="state">Palette state to use when populating.</param>
        public void PopulateFromBase(PaletteState state)
        {
            _itemState.PopulateFromBase(state);
        }
        #endregion

        #region Item
        /// <summary>
        /// Gets access to the item appearance.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining item appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteTriple Item
        {
            get { return _itemState; }
        }

        private bool ShouldSerializeItem()
        {
            return !_itemState.IsDefault;
        }
        #endregion

        #region Implementation
        /// <summary>
        /// Handle a change event from palette source.
        /// </summary>
        /// <param name="sender">Source of the event.</param>
        /// <param name="needLayout">True if a layout is also needed.</param>
        protected void OnNeedPaint(object sender, bool needLayout)
        {
            // Pass request from child to our own handler
            PerformNeedPaint(needLayout);
        }
        #endregion
    }
}
