using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Storage for KiwiContextMenuItem highlight state values.
    /// </summary>
    public class PaletteContextMenuItemStateHighlight : Storage
    {
        #region Instance Fields
        private PaletteDoubleMetric _paletteItemHighlight;
        private PaletteDouble _paletteItemSplit;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PaletteContextMenuItemStateHighlight class.
        /// </summary>
        /// <param name="redirect">Redirector for inheriting values.</param>
        public PaletteContextMenuItemStateHighlight(PaletteContextMenuRedirect redirect)
            : this(redirect.ItemHighlight, redirect.ItemSplit)
        {
        }

        /// <summary>
        /// Initialize a new instance of the PaletteContextMenuItemStateHighlight class.
		/// </summary>
        /// <param name="redirect">Redirector for inheriting values.</param>
        public PaletteContextMenuItemStateHighlight(PaletteContextMenuItemStateRedirect redirect)
            : this(redirect.ItemHighlight, redirect.ItemSplit)
        {
        }

        /// <summary>
        /// Initialize a new instance of the PaletteContextMenuItemStateHighlight class.
		/// </summary>
        /// <param name="redirectItemHighlight">Redirector for the ItemHighlight.</param>
        /// <param name="redirectItemSplit">Redirector for the ItemSplit.</param>
        public PaletteContextMenuItemStateHighlight(PaletteDoubleMetricRedirect redirectItemHighlight,
                                                    PaletteDoubleRedirect redirectItemSplit)
        {
            _paletteItemHighlight = new PaletteDoubleMetric(redirectItemHighlight);
            _paletteItemSplit = new PaletteDouble(redirectItemSplit);
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
                return _paletteItemHighlight.IsDefault &&
                       _paletteItemSplit.IsDefault;
            }
        }
        #endregion

        #region PopulateFromBase
        /// <summary>
        /// Populate values from the base palette.
        /// </summary>
        /// <param name="common">Reference to common settings.</param>
        /// <param name="state">State to inherit.</param>
        public void PopulateFromBase(KiwiPaletteCommon common,
                                     PaletteState state)
        {
            common.StateCommon.BackStyle = PaletteBackStyle.ContextMenuItemHighlight;
            common.StateCommon.BorderStyle = PaletteBorderStyle.ContextMenuItemHighlight;
            _paletteItemHighlight.PopulateFromBase(state);
            common.StateCommon.BackStyle = PaletteBackStyle.ContextMenuSeparator;
            common.StateCommon.BorderStyle = PaletteBorderStyle.ContextMenuSeparator;
            _paletteItemSplit.PopulateFromBase(state);
        }
        #endregion

        #region ItemHighlight
        /// <summary>
        /// Gets access to the item highlight appearance entries.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining item highlight appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteDoubleMetric ItemHighlight
        {
            get { return _paletteItemHighlight; }
        }

        private bool ShouldSerializeItemHighlight()
        {
            return !_paletteItemHighlight.IsDefault;
        }
        #endregion

        #region ItemSplit
        /// <summary>
        /// Gets access to the item split appearance entries.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining item split appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteDouble ItemSplit
        {
            get { return _paletteItemSplit; }
        }

        private bool ShouldSerializeItemSplit()
        {
            return !_paletteItemSplit.IsDefault;
        }
        #endregion
    }

}
