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
    /// Settings associated with ribbon control.
    /// </summary>
    public class KiwiPaletteRibbon : Storage
    {
        #region Instance Fields
        private PaletteRedirect _redirect;
        private PaletteRibbonBackInheritRedirect _ribbonAppMenuOuterInherit;
        private PaletteRibbonBackInheritRedirect _ribbonAppMenuInnerInherit;
        private PaletteRibbonBackInheritRedirect _ribbonAppMenuDocsInherit;
        private PaletteRibbonTextInheritRedirect _ribbonAppMenuDocsTitleInherit;
        private PaletteRibbonTextInheritRedirect _ribbonAppMenuDocsEntryInherit;
        private PaletteRibbonGeneralInheritRedirect _ribbonGeneralRedirect;
        private PaletteRibbonBackInheritRedirect _ribbonQATFullRedirect;
        private PaletteRibbonBackInheritRedirect _ribbonQATOverRedirect;
        private PaletteRibbonBackInheritRedirect _ribbonGalleryBackRedirect;
        private PaletteRibbonBackInheritRedirect _ribbonGalleryBorderRedirect;

        private PaletteRibbonGeneral _ribbonGeneral;
        private KiwiPaletteRibbonAppButton _ribbonAppButton;
        private KiwiPaletteRibbonGroupArea _ribbonGroupArea;
        private KiwiPaletteRibbonGroupButtonText _ribbonGroupButtonText;
        private KiwiPaletteRibbonGroupCheckBoxText _ribbonGroupCheckBoxText;
        private KiwiPaletteRibbonGroupNormalBorder _ribbonGroupNormalBorder;
        private KiwiPaletteRibbonGroupNormalTitle _ribbonGroupNormalTitle;
        private KiwiPaletteRibbonGroupCollapsedBorder _ribbonGroupCollapsedBorder;
        private KiwiPaletteRibbonGroupCollapsedBack _ribbonGroupCollapsedBack;
        private KiwiPaletteRibbonGroupCollapsedFrameBorder _ribbonGroupCollapsedFrameBorder;
        private KiwiPaletteRibbonGroupCollapsedFrameBack _ribbonGroupCollapsedFrameBack;
        private KiwiPaletteRibbonGroupCollapsedText _ribbonGroupCollapsedText;
        private KiwiPaletteRibbonGroupRadioButtonText _ribbonGroupRadioButtonText;
        private KiwiPaletteRibbonGroupLabelText _ribbonGroupLabelText;
        private PaletteRibbonBack _ribbonQATFullbar;
        private KiwiPaletteRibbonQATMinibar _ribbonQATMinibar;
        private PaletteRibbonBack _ribbonQATOverflow;
        private KiwiPaletteRibbonTab _ribbonTab;
        private PaletteRibbonBack _ribbonAppMenuInner;
        private PaletteRibbonBack _ribbonAppMenuOuter;
        private PaletteRibbonBack _ribbonAppMenuDocs;
        private PaletteRibbonText _ribbonAppMenuDocsTitle;
        private PaletteRibbonText _ribbonAppMenuDocsEntry;
        private PaletteRibbonBack _ribbonGalleryBack;
        private PaletteRibbonBack _ribbonGalleryBorder;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiPaletteRibbon class.
        /// </summary>
        /// <param name="redirect">Redirector to inherit values from.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        internal KiwiPaletteRibbon(PaletteRedirect redirect,
                                      NeedPaintHandler needPaint)
        {
            Debug.Assert(redirect != null);

            // Store incoming reference
            _redirect = redirect;

            // Create redirectors
            _ribbonGeneralRedirect = new PaletteRibbonGeneralInheritRedirect(redirect);
            _ribbonAppMenuInnerInherit = new PaletteRibbonBackInheritRedirect(redirect, PaletteRibbonBackStyle.RibbonAppMenuInner);
            _ribbonAppMenuOuterInherit = new PaletteRibbonBackInheritRedirect(redirect, PaletteRibbonBackStyle.RibbonAppMenuOuter);
            _ribbonAppMenuDocsInherit = new PaletteRibbonBackInheritRedirect(redirect, PaletteRibbonBackStyle.RibbonAppMenuDocs);
            _ribbonAppMenuDocsTitleInherit = new PaletteRibbonTextInheritRedirect(redirect, PaletteRibbonTextStyle.RibbonAppMenuDocsTitle);
            _ribbonAppMenuDocsEntryInherit = new PaletteRibbonTextInheritRedirect(redirect, PaletteRibbonTextStyle.RibbonAppMenuDocsEntry);
            _ribbonQATFullRedirect = new PaletteRibbonBackInheritRedirect(redirect, PaletteRibbonBackStyle.RibbonQATFullbar);
            _ribbonQATOverRedirect = new PaletteRibbonBackInheritRedirect(redirect, PaletteRibbonBackStyle.RibbonQATOverflow);
            _ribbonGalleryBackRedirect = new PaletteRibbonBackInheritRedirect(redirect, PaletteRibbonBackStyle.RibbonGalleryBack);
            _ribbonGalleryBorderRedirect = new PaletteRibbonBackInheritRedirect(redirect, PaletteRibbonBackStyle.RibbonGalleryBorder);

            // Create palettes
            _ribbonGeneral = new PaletteRibbonGeneral(_ribbonGeneralRedirect, needPaint);
            _ribbonAppButton = new KiwiPaletteRibbonAppButton(redirect, needPaint);
            _ribbonAppMenuInner = new PaletteRibbonBack(_ribbonAppMenuInnerInherit, needPaint);
            _ribbonAppMenuOuter = new PaletteRibbonBack(_ribbonAppMenuOuterInherit, needPaint);
            _ribbonAppMenuDocs = new PaletteRibbonBack(_ribbonAppMenuDocsInherit, needPaint);
            _ribbonAppMenuDocsTitle = new PaletteRibbonText(_ribbonAppMenuDocsTitleInherit, needPaint);
            _ribbonAppMenuDocsEntry = new PaletteRibbonText(_ribbonAppMenuDocsEntryInherit, needPaint);
            _ribbonGroupArea = new KiwiPaletteRibbonGroupArea(redirect, needPaint);
            _ribbonGroupButtonText = new KiwiPaletteRibbonGroupButtonText(redirect, needPaint);
            _ribbonGroupCheckBoxText = new KiwiPaletteRibbonGroupCheckBoxText(redirect, needPaint);
            _ribbonGroupNormalBorder = new KiwiPaletteRibbonGroupNormalBorder(redirect, needPaint);
            _ribbonGroupNormalTitle = new KiwiPaletteRibbonGroupNormalTitle(redirect, needPaint);
            _ribbonGroupCollapsedBorder = new KiwiPaletteRibbonGroupCollapsedBorder(redirect, needPaint);
            _ribbonGroupCollapsedBack = new KiwiPaletteRibbonGroupCollapsedBack(redirect, needPaint);
            _ribbonGroupCollapsedFrameBorder = new KiwiPaletteRibbonGroupCollapsedFrameBorder(redirect, needPaint);
            _ribbonGroupCollapsedFrameBack = new KiwiPaletteRibbonGroupCollapsedFrameBack(redirect, needPaint);
            _ribbonGroupCollapsedText = new KiwiPaletteRibbonGroupCollapsedText(redirect, needPaint);
            _ribbonGroupRadioButtonText = new KiwiPaletteRibbonGroupRadioButtonText(redirect, needPaint);
            _ribbonGroupLabelText = new KiwiPaletteRibbonGroupLabelText(redirect, needPaint);
            _ribbonQATFullbar = new PaletteRibbonBack(_ribbonQATFullRedirect, needPaint);
            _ribbonQATMinibar = new KiwiPaletteRibbonQATMinibar(redirect, needPaint);
            _ribbonQATOverflow = new PaletteRibbonBack(_ribbonQATOverRedirect, needPaint);
            _ribbonTab = new KiwiPaletteRibbonTab(redirect, needPaint);
            _ribbonGalleryBack = new PaletteRibbonBack(_ribbonGalleryBackRedirect, needPaint);
            _ribbonGalleryBorder = new PaletteRibbonBack(_ribbonGalleryBorderRedirect, needPaint);
        }

        /// <summary>
        /// Gets a value indicating if all values are default.
        /// </summary>
        public override bool IsDefault
        {
            get
            {
                return RibbonAppButton.IsDefault &&
                       RibbonAppMenuOuter.IsDefault &&
                       RibbonAppMenuInner.IsDefault &&
                       RibbonAppMenuDocs.IsDefault &&
                       RibbonAppMenuDocsTitle.IsDefault &&
                       RibbonAppMenuDocsEntry.IsDefault &&
                       RibbonGeneral.IsDefault &&
                       RibbonGroupArea.IsDefault &&
                       RibbonGroupButtonText.IsDefault &&
                       RibbonGroupCheckBoxText.IsDefault &&
                       RibbonGroupNormalBorder.IsDefault &&
                       RibbonGroupNormalTitle.IsDefault &&
                       RibbonGroupCollapsedBorder.IsDefault &&
                       RibbonGroupCollapsedBack.IsDefault &&
                       RibbonGroupCollapsedFrameBorder.IsDefault &&
                       RibbonGroupCollapsedFrameBack.IsDefault &&
                       RibbonGroupCollapsedText.IsDefault &&
                       RibbonGroupLabelText.IsDefault &&
                       RibbonGroupRadioButtonText.IsDefault &&
                       RibbonQATFullbar.IsDefault &&
                       RibbonQATMinibar.IsDefault &&
                       RibbonTab.IsDefault &&
                       RibbonGalleryBack.IsDefault &&
                       RibbonGalleryBorder.IsDefault;
            }
        }
        #endregion

        #region PopulateFromBase
        /// <summary>
        /// Populate values from the base palette.
        /// </summary>
        public void PopulateFromBase()
        {
            RibbonAppButton.PopulateFromBase();
            RibbonAppMenuOuter.PopulateFromBase(PaletteState.Normal);
            RibbonAppMenuInner.PopulateFromBase(PaletteState.Normal);
            RibbonAppMenuDocs.PopulateFromBase(PaletteState.Normal);
            RibbonAppMenuDocsTitle.PopulateFromBase(PaletteState.Normal);
            RibbonAppMenuDocsEntry.PopulateFromBase(PaletteState.Normal);
            RibbonGeneral.PopulateFromBase();
            RibbonGroupArea.PopulateFromBase();
            RibbonGroupButtonText.PopulateFromBase();
            RibbonGroupCheckBoxText.PopulateFromBase();
            RibbonGroupNormalBorder.PopulateFromBase();
            RibbonGroupNormalTitle.PopulateFromBase();
            RibbonGroupCollapsedBack.PopulateFromBase();
            RibbonGroupCollapsedBorder.PopulateFromBase();
            RibbonGroupCollapsedFrameBorder.PopulateFromBase();
            RibbonGroupCollapsedFrameBack.PopulateFromBase();
            RibbonGroupCollapsedText.PopulateFromBase();
            RibbonGroupRadioButtonText.PopulateFromBase();
            RibbonGroupLabelText.PopulateFromBase();
            RibbonQATFullbar.PopulateFromBase(PaletteState.Normal);
            RibbonQATMinibar.PopulateFromBase();
            RibbonQATOverflow.PopulateFromBase(PaletteState.Normal);
            RibbonTab.PopulateFromBase();
            RibbonGalleryBack.PopulateFromBase(PaletteState.Normal);
            RibbonGalleryBorder.PopulateFromBase(PaletteState.Normal);
        }
        #endregion

        #region RibbonAppButton
        /// <summary>
        /// Get access to the application button tab settings.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Ribbon application button specific settings.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteRibbonAppButton RibbonAppButton
        {
            get { return _ribbonAppButton; }
        }

        private bool ShouldSerializeRibbonAppButton()
        {
            return !_ribbonAppButton.IsDefault;
        }
        #endregion

        #region RibbonAppMenuOuter
        /// <summary>
        /// Gets access to the application button menu outer palette details.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining application button menu outer appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public virtual PaletteRibbonBack RibbonAppMenuOuter
        {
            get { return _ribbonAppMenuOuter; }
        }

        private bool ShouldSerializeRibbonAppMenuOuter()
        {
            return !_ribbonAppMenuOuter.IsDefault;
        }
        #endregion

        #region RibbonAppMenuInner
        /// <summary>
        /// Gets access to the application button menu inner palette details.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining application button menu inner appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public virtual PaletteRibbonBack RibbonAppMenuInner
        {
            get { return _ribbonAppMenuInner; }
        }

        private bool ShouldSerializeRibbonAppMenuInner()
        {
            return !_ribbonAppMenuInner.IsDefault;
        }
        #endregion

        #region RibbonAppMenuDocs
        /// <summary>
        /// Gets access to the application button menu recent docs palette details.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining application button menu recent docs appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public virtual PaletteRibbonBack RibbonAppMenuDocs
        {
            get { return _ribbonAppMenuDocs; }
        }

        private bool ShouldSerializeRibbonAppMenuDocs()
        {
            return !_ribbonAppMenuDocs.IsDefault;
        }
        #endregion

        #region RibbonAppMenuDocsTitle
        /// <summary>
        /// Gets access to the application button menu recent documents title.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining application button menu recent documents title.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public virtual PaletteRibbonText RibbonAppMenuDocsTitle
        {
            get { return _ribbonAppMenuDocsTitle; }
        }

        private bool ShouldSerializeRibbonAppMenuDocsTitle()
        {
            return !_ribbonAppMenuDocsTitle.IsDefault;
        }
        #endregion

        #region RibbonAppMenuDocsEntry
        /// <summary>
        /// Gets access to the application button menu recent documents entry.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining application button menu recent documents entry.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public virtual PaletteRibbonText RibbonAppMenuDocsEntry
        {
            get { return _ribbonAppMenuDocsEntry; }
        }

        private bool ShouldSerializeRibbonAppMenuDocsEntry()
        {
            return !_ribbonAppMenuDocsEntry.IsDefault;
        }
        #endregion

        #region RibbonGeneral
        /// <summary>
        /// Get access to the general ribbon settings.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Ribbon general settings.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteRibbonGeneral RibbonGeneral
        {
            get { return _ribbonGeneral; }
        }

        private bool ShouldSerializeRibbonGeneral()
        {
            return !_ribbonGeneral.IsDefault;
        }
        #endregion

        #region RibbonGroupArea
        /// <summary>
        /// Get access to the ribbon group area settings.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Ribbon group area specific settings.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteRibbonGroupArea RibbonGroupArea
        {
            get { return _ribbonGroupArea; }
        }

        private bool ShouldSerializeRibbonGroupArea()
        {
            return !_ribbonGroupArea.IsDefault;
        }
        #endregion

        #region RibbonGroupButtonText
        /// <summary>
        /// Get access to the ribbon group button text settings.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Ribbon group button text specific settings.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteRibbonGroupButtonText RibbonGroupButtonText
        {
            get { return _ribbonGroupButtonText; }
        }

        private bool ShouldSerializeRibbonGroupButtonText()
        {
            return !_ribbonGroupButtonText.IsDefault;
        }
        #endregion

        #region RibbonGroupCheckBoxText
        /// <summary>
        /// Get access to the ribbon group check box text settings.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Ribbon group check box text specific settings.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteRibbonGroupCheckBoxText RibbonGroupCheckBoxText
        {
            get { return _ribbonGroupCheckBoxText; }
        }

        private bool ShouldSerializeRibbonGroupCheckBoxText()
        {
            return !_ribbonGroupCheckBoxText.IsDefault;
        }
        #endregion

        #region RibbonGroupNormalBorder
        /// <summary>
        /// Get access to the ribbon group normal border settings.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Ribbon group normal border specific settings.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteRibbonGroupNormalBorder RibbonGroupNormalBorder
        {
            get { return _ribbonGroupNormalBorder; }
        }

        private bool ShouldSerializeRibbonGroupNormalBorder()
        {
            return !_ribbonGroupNormalBorder.IsDefault;
        }
        #endregion

        #region RibbonGroupNormalTitle
        /// <summary>
        /// Get access to the ribbon group normal title settings.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Ribbon group normal title specific settings.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteRibbonGroupNormalTitle RibbonGroupNormalTitle
        {
            get { return _ribbonGroupNormalTitle; }
        }

        private bool ShouldSerializeRibbonGroupNormalTitle()
        {
            return !_ribbonGroupNormalTitle.IsDefault;
        }
        #endregion

        #region RibbonGroupCollapsedBorder
        /// <summary>
        /// Get access to the ribbon group collapsed border settings.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Ribbon group collapsed border specific settings.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteRibbonGroupCollapsedBorder RibbonGroupCollapsedBorder
        {
            get { return _ribbonGroupCollapsedBorder; }
        }

        private bool ShouldSerializeRibbonGroupCollapsedBorder()
        {
            return !_ribbonGroupCollapsedBorder.IsDefault;
        }
        #endregion

        #region RibbonGroupCollapsedBack
        /// <summary>
        /// Get access to the ribbon group collapsed background settings.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Ribbon group collapsed background specific settings.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteRibbonGroupCollapsedBack RibbonGroupCollapsedBack
        {
            get { return _ribbonGroupCollapsedBack; }
        }

        private bool ShouldSerializeRibbonGroupCollapsedBack()
        {
            return !_ribbonGroupCollapsedBack.IsDefault;
        }
        #endregion

        #region RibbonGroupCollapsedFrameBorder
        /// <summary>
        /// Get access to the ribbon group collapsed frame border settings.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Ribbon group collapsed frame border specific settings.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteRibbonGroupCollapsedFrameBorder RibbonGroupCollapsedFrameBorder
        {
            get { return _ribbonGroupCollapsedFrameBorder; }
        }

        private bool ShouldSerializeRibbonGroupCollapsedFrameBorder()
        {
            return !_ribbonGroupCollapsedFrameBorder.IsDefault;
        }
        #endregion

        #region RibbonGroupCollapsedFrameBack
        /// <summary>
        /// Get access to the ribbon group collapsed frame background settings.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Ribbon group collapsed frame background specific settings.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteRibbonGroupCollapsedFrameBack RibbonGroupCollapsedFrameBack
        {
            get { return _ribbonGroupCollapsedFrameBack; }
        }

        private bool ShouldSerializeRibbonGroupCollapsedFrameBack()
        {
            return !_ribbonGroupCollapsedFrameBack.IsDefault;
        }
        #endregion

        #region RibbonGroupCollapsedText
        /// <summary>
        /// Get access to the ribbon group collapsed text settings.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Ribbon group collapsed text specific settings.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteRibbonGroupCollapsedText RibbonGroupCollapsedText
        {
            get { return _ribbonGroupCollapsedText; }
        }

        private bool ShouldSerializeRibbonGroupCollapsedText()
        {
            return !_ribbonGroupCollapsedText.IsDefault;
        }
        #endregion

        #region RibbonGroupLabelText
        /// <summary>
        /// Get access to the ribbon group label text settings.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Ribbon group label text specific settings.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteRibbonGroupLabelText RibbonGroupLabelText
        {
            get { return _ribbonGroupLabelText; }
        }

        private bool ShouldSerializeRibbonGroupLabelText()
        {
            return !_ribbonGroupLabelText.IsDefault;
        }
        #endregion

        #region RibbonGroupRadioButtonText
        /// <summary>
        /// Get access to the ribbon radio button box text settings.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Ribbon group radio button text specific settings.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteRibbonGroupRadioButtonText RibbonGroupRadioButtonText
        {
            get { return _ribbonGroupRadioButtonText; }
        }

        private bool ShouldSerializeRibbonGroupRadioButtonText()
        {
            return !_ribbonGroupRadioButtonText.IsDefault;
        }
        #endregion

        #region RibbonQATFullbar
        /// <summary>
        /// Get access to the quick access toolbar full settings.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Ribbon quick access toolbar full settings.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteRibbonBack RibbonQATFullbar
        {
            get { return _ribbonQATFullbar; }
        }

        private bool ShouldSerializeRibbonQATFullbar()
        {
            return !_ribbonQATFullbar.IsDefault;
        }
        #endregion

        #region RibbonQATMinibar
        /// <summary>
        /// Get access to the quick access toolbar mini settings.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Ribbon quick access toolbar mini settings.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteRibbonQATMinibar RibbonQATMinibar
        {
            get { return _ribbonQATMinibar; }
        }

        private bool ShouldSerializeRibbonQATMinibar()
        {
            return !_ribbonQATMinibar.IsDefault;
        }
        #endregion

        #region RibbonQATOverflow
        /// <summary>
        /// Get access to the quick access toolbar overflow settings.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Ribbon quick access toolbar overflow settings.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteRibbonBack RibbonQATOverflow
        {
            get { return _ribbonQATOverflow; }
        }

        private bool ShouldSerializeRibbonQATOverflow()
        {
            return !_ribbonQATOverflow.IsDefault;
        }
        #endregion

        #region RibbonTab
        /// <summary>
        /// Get access to the ribbon tab settings.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Ribbon tab specific settings.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteRibbonTab RibbonTab
        {
            get { return _ribbonTab; }
        }

        private bool ShouldSerializeRibbonTab()
        {
            return !_ribbonTab.IsDefault;
        }
        #endregion

        #region RibbonGalleryBack
        /// <summary>
        /// Gets access to the ribbon gallery background palette details.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining ribbon gallery background appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public virtual PaletteRibbonBack RibbonGalleryBack
        {
            get { return _ribbonGalleryBack; }
        }

        private bool ShouldSerializeRibbonGalleryBack()
        {
            return !_ribbonGalleryBack.IsDefault;
        }
        #endregion

        #region RibbonGalleryBorder
        /// <summary>
        /// Gets access to the ribbon gallery border palette details.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining ribbon gallery border appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public virtual PaletteRibbonBack RibbonGalleryBorder
        {
            get { return _ribbonGalleryBorder; }
        }

        private bool ShouldSerializeRibbonGalleryBorder()
        {
            return !_ribbonGalleryBorder.IsDefault;
        }
        #endregion
    }
}
