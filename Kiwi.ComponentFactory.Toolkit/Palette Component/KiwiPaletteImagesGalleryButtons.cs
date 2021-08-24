using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Storage for gallery button images.
    /// </summary>
    public class KiwiPaletteImagesGalleryButtons : Storage
    {
        #region Instance Fields
        private KiwiPaletteImagesGalleryButton _up;
        private KiwiPaletteImagesGalleryButton _down;
        private KiwiPaletteImagesGalleryButton _dropDown;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiPaletteImagesGalleryButtons class.
		/// </summary>
        /// <param name="redirector">Palette redirector for sourcing inherited values.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public KiwiPaletteImagesGalleryButtons(PaletteRedirect redirector,
                                                  NeedPaintHandler needPaint)
        {
            // Store the provided paint notification delegate
            NeedPaint = needPaint;

            // Create the storage
            _up = new KiwiPaletteImagesGalleryButton(PaletteRibbonGalleryButton.Up, redirector, needPaint);
            _down = new KiwiPaletteImagesGalleryButton(PaletteRibbonGalleryButton.Down, redirector, needPaint);
            _dropDown = new KiwiPaletteImagesGalleryButton(PaletteRibbonGalleryButton.DropDown, redirector, needPaint);
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
                return _up.IsDefault &&
                       _down.IsDefault &&
                       _dropDown.IsDefault;
            }
        }
        #endregion

        #region PopulateFromBase
        /// <summary>
        /// Populate values from the base palette.
        /// </summary>
        public void PopulateFromBase()
        {
            _up.PopulateFromBase();
            _down.PopulateFromBase();
            _dropDown.PopulateFromBase();
        }
        #endregion

        #region Up
        /// <summary>
        /// Gallery up button images.
        /// </summary>
        [KiwiPersist(true)]
        [Category("Visuals")]
        [Description("Gallery up button images.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteImagesGalleryButton Up
        {
            get { return _up; }
        }
        #endregion

        #region Down
        /// <summary>
        /// Gallery down button images.
        /// </summary>
        [KiwiPersist(true)]
        [Category("Visuals")]
        [Description("Gallery down button images.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteImagesGalleryButton Down
        {
            get { return _down; }
        }
        #endregion

        #region DropDown
        /// <summary>
        /// Gallery drop down button images.
        /// </summary>
        [KiwiPersist(true)]
        [Category("Visuals")]
        [Description("Gallery drop down button images.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteImagesGalleryButton DropDown
        {
            get { return _dropDown; }
        }
        #endregion
    }
}
