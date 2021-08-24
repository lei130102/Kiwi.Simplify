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
    /// Colors associated with menus and tool strip.
    /// </summary>
    public class KiwiPaletteTMS : Storage
    {
        #region Instance Fields
        private KiwiInternalKCT _internalKCT;
        private KiwiPaletteTMSButton _paletteButton;
        private KiwiPaletteTMSGrip _paletteGrip;
        private KiwiPaletteTMSMenu _paletteMenu;
        private KiwiPaletteTMSMenuStrip _paletteMenuStrip;
        private KiwiPaletteTMSRafting _paletteRafting;
        private KiwiPaletteTMSSeparator _paletteSeparator;
        private KiwiPaletteTMSStatusStrip _paletteStatusStrip;
        private KiwiPaletteTMSToolStrip _paletteToolStrip;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiPaletteTMS class.
        /// </summary>
        /// <param name="palette">Associated palettte instance.</param>
        /// <param name="baseKCT">Initial base KCT to inherit values from.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        internal KiwiPaletteTMS(IPalette palette,
                                   KiwiColorTable baseKCT,
                                   NeedPaintHandler needPaint)
        {
            Debug.Assert(baseKCT != null);

            // Create actual KCT for storage
            _internalKCT = new KiwiInternalKCT(baseKCT, palette);

            // Create the set of sub objects that expose the palette properties
            _paletteButton = new KiwiPaletteTMSButton(_internalKCT, needPaint);
            _paletteGrip = new KiwiPaletteTMSGrip(_internalKCT, needPaint);
            _paletteMenu = new KiwiPaletteTMSMenu(_internalKCT, needPaint);
            _paletteMenuStrip = new KiwiPaletteTMSMenuStrip(_internalKCT, needPaint);
            _paletteRafting = new KiwiPaletteTMSRafting(_internalKCT, needPaint);
            _paletteSeparator = new KiwiPaletteTMSSeparator(_internalKCT, needPaint);
            _paletteStatusStrip = new KiwiPaletteTMSStatusStrip(_internalKCT, needPaint);
            _paletteToolStrip = new KiwiPaletteTMSToolStrip(_internalKCT, needPaint);
        }

        /// <summary>
        /// Gets a value indicating if all values are default.
        /// </summary>
        public override bool IsDefault
        {
            get
            {
                return _internalKCT.IsDefault &&
                       _paletteButton.IsDefault &&
                       _paletteGrip.IsDefault &&
                       _paletteMenu.IsDefault &&
                       _paletteRafting.IsDefault &&
                       _paletteMenuStrip.IsDefault &&
                       _paletteSeparator.IsDefault &&
                       _paletteStatusStrip.IsDefault &&
                       _paletteToolStrip.IsDefault;
            }
        }
        #endregion

        #region PopulateFromBase
        /// <summary>
        /// Populate values from the base palette.
        /// </summary>
        public void PopulateFromBase()
        {
            Button.PopulateFromBase();
            Grip.PopulateFromBase();
            Menu.PopulateFromBase();
            Rafting.PopulateFromBase();
            MenuStrip.PopulateFromBase();
            Separator.PopulateFromBase();
            StatusStrip.PopulateFromBase();
            ToolStrip.PopulateFromBase();
            UseRoundedEdges = InternalKCT.UseRoundedEdges;
        }
        #endregion

        #region Button
        /// <summary>
        /// Get access to the button colors.
        /// </summary>
        [KiwiPersist]
        [Category("ToolMenuStatus")]
        [Description("Button specific colors.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteTMSButton Button
        {
            get { return _paletteButton; }
        }

        private bool ShouldSerializeButton()
        {
            return !_paletteButton.IsDefault;
        }
        #endregion

        #region Grip
        /// <summary>
        /// Get access to the grip colors.
        /// </summary>
        [KiwiPersist]
        [Category("ToolMenuStatus")]
        [Description("Grip specific colors.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteTMSGrip Grip
        {
            get { return _paletteGrip; }
        }

        private bool ShouldSerializeGrip()
        {
            return !_paletteGrip.IsDefault;
        }
        #endregion

        #region Menu
        /// <summary>
        /// Get access to the menu colors.
        /// </summary>
        [KiwiPersist]
        [Category("ToolMenuStatus")]
        [Description("Menu specific colors.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteTMSMenu Menu
        {
            get { return _paletteMenu; }
        }

        private bool ShouldSerializeMenu()
        {
            return !_paletteMenu.IsDefault;
        }
        #endregion

        #region Rafting
        /// <summary>
        /// Get access to the rafting colors.
        /// </summary>
        [KiwiPersist]
        [Category("ToolMenuStatus")]
        [Description("Rafting specific colors.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteTMSRafting Rafting
        {
            get { return _paletteRafting; }
        }

        private bool ShouldSerializeRafting()
        {
            return !_paletteRafting.IsDefault;
        }
        #endregion

        #region MenuStrip
        /// <summary>
        /// Get access to the menu strip colors.
        /// </summary>
        [KiwiPersist]
        [Category("ToolMenuStatus")]
        [Description("MenuStrip specific colors.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteTMSMenuStrip MenuStrip
        {
            get { return _paletteMenuStrip; }
        }

        private bool ShouldSerializeMenuStrip()
        {
            return !_paletteMenuStrip.IsDefault;
        }
        #endregion

        #region Separator
        /// <summary>
        /// Get access to the separator colors.
        /// </summary>
        [KiwiPersist]
        [Category("ToolMenuStatus")]
        [Description("Separator specific colors.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteTMSSeparator Separator
        {
            get { return _paletteSeparator; }
        }

        private bool ShouldSerializeSeparator()
        {
            return !_paletteSeparator.IsDefault;
        }
        #endregion

        #region StatusStrip
        /// <summary>
        /// Get access to the status strip colors.
        /// </summary>
        [KiwiPersist]
        [Category("ToolMenuStatus")]
        [Description("StatusStrip specific colors.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteTMSStatusStrip StatusStrip
        {
            get { return _paletteStatusStrip; }
        }

        private bool ShouldSerializeStatusStrip()
        {
            return !_paletteStatusStrip.IsDefault;
        }
        #endregion

        #region ToolStrip
        /// <summary>
        /// Get access to the tool strip colors.
        /// </summary>
        [KiwiPersist]
        [Category("ToolMenuStatus")]
        [Description("ToolStrip specific colors.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteTMSToolStrip ToolStrip
        {
            get { return _paletteToolStrip; }
        }

        private bool ShouldSerializeToolStrip()
        {
            return !_paletteToolStrip.IsDefault;
        }
        #endregion

        #region UseRoundedEdges
        /// <summary>
        /// Gets and sets the use of rounded or square edges when rendering.
        /// </summary>
        [KiwiPersist(false)]
        [Category("ToolMenuStatus")]
        [Description("Should rendering use rounded or square edges.")]
        [DefaultValue(typeof(InheritBool), "Inherit")]
        public InheritBool UseRoundedEdges
        {
            get { return InternalKCT.InternalUseRoundedEdges; }

            set
            {
                InternalKCT.InternalUseRoundedEdges = value;
                PerformNeedPaint(false);
            }
        }

        /// <summary>
        /// esets the UseRoundedEdges property to its default value.
        /// </summary>
        public void ResetUseRoundedEdges()
        {
            UseRoundedEdges = InheritBool.Inherit;
        }
        #endregion

        #region Internal
        internal KiwiColorTable BaseKCT
        {
            get { return InternalKCT.BaseKCT; }
            set { InternalKCT.BaseKCT = value; }
        }

        internal KiwiInternalKCT InternalKCT
        {
            get { return _internalKCT; }
        }
        #endregion
    }
}
