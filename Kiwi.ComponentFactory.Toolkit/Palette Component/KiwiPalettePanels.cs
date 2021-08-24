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
    /// Storage for panel palette settings.
    /// </summary>
    public class KiwiPalettePanels : Storage
    {
        #region Instance Fields
        private KiwiPalettePanel _panelCommon;
        private KiwiPalettePanel _panelClient;
        private KiwiPalettePanel _panelAlternate;
        private KiwiPalettePanel _panelRibbonInactive;
        private KiwiPalettePanel _panelCustom1;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiPalettePanels class.
        /// </summary>
        /// <param name="redirector">Palette redirector for sourcing inherited values.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        internal KiwiPalettePanels(PaletteRedirect redirector,
                                      NeedPaintHandler needPaint)
        {
            Debug.Assert(redirector != null);

            // Create the button style specific and common palettes
            _panelCommon = new KiwiPalettePanel(redirector, PaletteBackStyle.PanelClient, needPaint);
            _panelClient = new KiwiPalettePanel(redirector, PaletteBackStyle.PanelClient, needPaint);
            _panelAlternate = new KiwiPalettePanel(redirector, PaletteBackStyle.PanelAlternate, needPaint);
            _panelRibbonInactive = new KiwiPalettePanel(redirector, PaletteBackStyle.PanelRibbonInactive, needPaint);
            _panelCustom1 = new KiwiPalettePanel(redirector, PaletteBackStyle.PanelCustom1, needPaint);

            // Create redirectors for inheriting from style specific to style common
            PaletteRedirectBack redirectCommon = new PaletteRedirectBack(redirector, _panelCommon.StateDisabled, _panelCommon.StateNormal);

            // Inform the button style to use the new redirector
            _panelClient.SetRedirector(redirectCommon);
            _panelAlternate.SetRedirector(redirectCommon);
            _panelRibbonInactive.SetRedirector(redirectCommon);
            _panelCustom1.SetRedirector(redirectCommon);
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
                return _panelCommon.IsDefault &&
                       _panelClient.IsDefault &&
                       _panelAlternate.IsDefault &&
                       _panelRibbonInactive.IsDefault &&
                       _panelCustom1.IsDefault;
            }
        }
        #endregion

        #region PopulateFromBase
        /// <summary>
        /// Populate values from the base palette.
        /// </summary>
        /// <param name="common">Reference to common settings.</param>
        public void PopulateFromBase(KiwiPaletteCommon common)
        {
            // Populate only the designated styles
            common.StateCommon.BackStyle = PaletteBackStyle.PanelClient;
            _panelClient.PopulateFromBase();
            common.StateCommon.BackStyle = PaletteBackStyle.PanelAlternate;
            _panelAlternate.PopulateFromBase();
            common.StateCommon.BackStyle = PaletteBackStyle.PanelRibbonInactive;
            _panelRibbonInactive.PopulateFromBase();
        }
        #endregion

        #region PanelCommon
        /// <summary>
        /// Gets access to the common panel appearance.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining common panel appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPalettePanel PanelCommon
        {
            get { return _panelCommon; }
        }

        private bool ShouldSerializePanelCommon()
        {
            return !_panelCommon.IsDefault;
        }
        #endregion

        #region PanelClient
        /// <summary>
        /// Gets access to the client panel appearance.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining a client panel appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPalettePanel PanelClient
        {
            get { return _panelClient; }
        }

        private bool ShouldSerializePanelClient()
        {
            return !_panelClient.IsDefault;
        }
        #endregion

        #region PanelAlternate
        /// <summary>
        /// Gets access to the alternate panel appearance.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining alternate panel appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPalettePanel PanelAlternate
        {
            get { return _panelAlternate; }
        }

        private bool ShouldSerializePanelAlternate()
        {
            return !_panelAlternate.IsDefault;
        }
        #endregion

        #region PanelRibbonInactive
        /// <summary>
        /// Gets access to the ribbon inactive panel appearance.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining ribbon inactive panel appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPalettePanel PanelRibbonInactive
        {
            get { return _panelRibbonInactive; }
        }

        private bool ShouldSerializePanelRibbonInactive()
        {
            return !_panelRibbonInactive.IsDefault;
        }
        #endregion

        #region PanelCustom1
        /// <summary>
        /// Gets access to the first custom panel appearance.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining the first custom panel appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPalettePanel PanelCustom1
        {
            get { return _panelCustom1; }
        }

        private bool ShouldSerializePanelCustom1()
        {
            return !_panelCustom1.IsDefault;
        }
        #endregion
    }
}
