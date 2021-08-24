using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Storage for palette image settings.
    /// </summary>
    public class KiwiPaletteImages : Storage
    {
        #region Instance Fields
        private KiwiPaletteImagesCheckBox _imagesCheckBox;
        private KiwiPaletteImagesContextMenu _imagesContextMenu;
        private KiwiPaletteImagesDropDownButton _imagesDropDownButton;
        private KiwiPaletteImagesGalleryButtons _imagesGalleryButtons;
        private KiwiPaletteImagesRadioButton _imagesRadioButton;
        private KiwiPaletteImagesTreeView _imagesTreeView;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiPaletteImages class.
        /// </summary>
        /// <param name="redirector">Palette redirector for sourcing inherited values.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        internal KiwiPaletteImages(PaletteRedirect redirector,
                                      NeedPaintHandler needPaint)
        {
            Debug.Assert(redirector != null);

            // Create the different image sets
            _imagesCheckBox = new KiwiPaletteImagesCheckBox(redirector, needPaint);
            _imagesContextMenu = new KiwiPaletteImagesContextMenu(redirector, needPaint);
            _imagesDropDownButton = new KiwiPaletteImagesDropDownButton(redirector, needPaint);
            _imagesGalleryButtons = new KiwiPaletteImagesGalleryButtons(redirector, needPaint);
            _imagesRadioButton = new KiwiPaletteImagesRadioButton(redirector, needPaint);
            _imagesTreeView = new KiwiPaletteImagesTreeView(redirector, needPaint);
        }
        #endregion

        #region IsDefault
        /// <summary>
        /// Gets a value indicating if all values are default.
        /// </summary>
        public override bool IsDefault
        {
            get
            {
                return _imagesCheckBox.IsDefault &&
                       _imagesContextMenu.IsDefault &&
                       _imagesDropDownButton.IsDefault &&
                       _imagesGalleryButtons.IsDefault &&
                       _imagesRadioButton.IsDefault &&
                       _imagesTreeView.IsDefault;
            }
        }
        #endregion

        #region PopulateFromBase
        /// <summary>
        /// Populate values from the base palette.
        /// </summary>
        public void PopulateFromBase()
        {
            // Populate only the designated styles
            _imagesCheckBox.PopulateFromBase();
            _imagesContextMenu.PopulateFromBase();
            _imagesDropDownButton.PopulateFromBase();
            _imagesGalleryButtons.PopulateFromBase();
            _imagesRadioButton.PopulateFromBase();
            _imagesTreeView.PopulateFromBase();
        }
        #endregion

        #region CheckBox
        /// <summary>
        /// Gets access to the check box set of images.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining check box images.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteImagesCheckBox CheckBox
        {
            get { return _imagesCheckBox; }
        }

        private bool ShouldSerializeCheckBox()
        {
            return !_imagesCheckBox.IsDefault;
        }
        #endregion

        #region ContextMenu
        /// <summary>
        /// Gets access to the context menu set of images.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining context menu images.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteImagesContextMenu ContextMenu
        {
            get { return _imagesContextMenu; }
        }

        private bool ShouldSerializeContextMenu()
        {
            return !_imagesContextMenu.IsDefault;
        }
        #endregion

        #region DropDownButton
        /// <summary>
        /// Gets access to the drop down button set of images.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining drop down button images.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteImagesDropDownButton DropDownButton
        {
            get { return _imagesDropDownButton; }
        }

        private bool ShouldSerializeDropDownButton()
        {
            return !_imagesDropDownButton.IsDefault;
        }
        #endregion

        #region CheckBox
        /// <summary>
        /// Gets access to the gallery button images.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining gallery button images.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteImagesGalleryButtons GalleryButtons
        {
            get { return _imagesGalleryButtons; }
        }

        private bool ShouldSerializeGalleryButtons()
        {
            return !_imagesGalleryButtons.IsDefault;
        }
        #endregion

        #region RadioButton
        /// <summary>
        /// Gets access to the radio button set of images.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining radio button images.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteImagesRadioButton RadioButton
        {
            get { return _imagesRadioButton; }
        }

        private bool ShouldSerializeRadioButton()
        {
            return !_imagesRadioButton.IsDefault;
        }
        #endregion

        #region TreeView
        /// <summary>
        /// Gets access to the tree view set of images.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining tree view images.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteImagesTreeView TreeView
        {
            get { return _imagesTreeView; }
        }

        private bool ShouldSerializeTreeView()
        {
            return !_imagesTreeView.IsDefault;
        }
        #endregion
    }
}
