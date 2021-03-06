using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Storage for KiwiContextMenuItem checked state values.
    /// </summary>
    public class PaletteContextMenuItemStateChecked : Storage
    {
        #region Instance Fields
        private PaletteTripleJustImage _paletteItemImage;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PaletteContextMenuItemStateChecked class.
        /// </summary>
        /// <param name="redirect">Redirector for inheriting values.</param>
        public PaletteContextMenuItemStateChecked(PaletteContextMenuRedirect redirect)
            : this(redirect.ItemImage)
        {
        }

        /// <summary>
        /// Initialize a new instance of the PaletteContextMenuItemStateChecked class.
		/// </summary>
        /// <param name="redirect">Redirector for inheriting values.</param>
        public PaletteContextMenuItemStateChecked(PaletteContextMenuItemStateRedirect redirect)
            : this(redirect.ItemImage)
        {
        }


        /// <summary>
        /// Initialize a new instance of the PaletteContextMenuItemStateChecked class.
		/// </summary>
        public PaletteContextMenuItemStateChecked(PaletteTripleJustImageRedirect redirectItemImage)
        {
            _paletteItemImage = new PaletteTripleJustImage(redirectItemImage);
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
            common.StateCommon.BackStyle = PaletteBackStyle.ContextMenuItemImage;
            common.StateCommon.BorderStyle = PaletteBorderStyle.ContextMenuItemImage;
            common.StateCommon.ContentStyle = PaletteContentStyle.ContextMenuItemImage;
            _paletteItemImage.PopulateFromBase(state);
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
                return (_paletteItemImage.IsDefault);
            }
        }
        #endregion

        #region ItemImage
        /// <summary>
        /// Gets access to the item image appearance entries.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining item image appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteTripleJustImage ItemImage
        {
            get { return _paletteItemImage; }
        }

        private bool ShouldSerializeItemImage()
        {
            return !_paletteItemImage.IsDefault;
        }
        #endregion
    }

}
