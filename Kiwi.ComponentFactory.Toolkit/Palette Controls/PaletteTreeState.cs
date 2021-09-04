using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Implement storage for background, border and node triple.
	/// </summary>
    public class PaletteTreeState : PaletteDouble
    {
        #region Instance Fields
        private PaletteTriple _nodeTriple;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PaletteTreeState class.
        /// </summary>
        /// <param name="inherit">Source for inheriting values.</param>
        /// <param name="back">Reference to back storage.</param>
        /// <param name="border">Reference to border storage.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public PaletteTreeState(PaletteTreeStateRedirect inherit,
                                PaletteBack back,
                                PaletteBorder border,
                                NeedPaintHandler needPaint)
            : base(inherit, back, border, needPaint)
        {
            _nodeTriple = new PaletteTriple(inherit.Node, needPaint);
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
                return (base.IsDefault && _nodeTriple.IsDefault);
            }
        }
        #endregion

        #region PopulateFromBase
        /// <summary>
        /// Populate values from the base palette.
        /// </summary>
        /// <param name="state">Which state to populate from.</param>
        public override void PopulateFromBase(PaletteState state)
        {
            base.PopulateFromBase(state);
            _nodeTriple.PopulateFromBase(state);
        }
        #endregion

        #region Node
        /// <summary>
		/// Gets the node appearance overrides.
		/// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining node appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteTriple Node
        {
            get { return _nodeTriple; }
        }

        private bool ShouldSerializeItem()
        {
            return !_nodeTriple.IsDefault;
        }
        #endregion
    }
}
