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
    /// Overrides for defining button specifications.
    /// </summary>
    public class KiwiPaletteButtonSpecs : Storage
    {
        #region Instance Fields
        private KiwiPaletteButtonSpecTyped _common;
        private KiwiPaletteButtonSpecTyped _close;
        private KiwiPaletteButtonSpecTyped _context;
        private KiwiPaletteButtonSpecTyped _next;
        private KiwiPaletteButtonSpecTyped _previous;
        private KiwiPaletteButtonSpecTyped _generic;
        private KiwiPaletteButtonSpecTyped _arrowLeft;
        private KiwiPaletteButtonSpecTyped _arrowRight;
        private KiwiPaletteButtonSpecTyped _arrowUp;
        private KiwiPaletteButtonSpecTyped _arrowDown;
        private KiwiPaletteButtonSpecTyped _dropDown;
        private KiwiPaletteButtonSpecTyped _pinVertical;
        private KiwiPaletteButtonSpecTyped _pinHorizontal;
        private KiwiPaletteButtonSpecTyped _formClose;
        private KiwiPaletteButtonSpecTyped _formMax;
        private KiwiPaletteButtonSpecTyped _formMin;
        private KiwiPaletteButtonSpecTyped _formRestore;
        private KiwiPaletteButtonSpecTyped _pendantClose;
        private KiwiPaletteButtonSpecTyped _pendantMin;
        private KiwiPaletteButtonSpecTyped _pendantRestore;
        private KiwiPaletteButtonSpecTyped _workspaceMaximize;
        private KiwiPaletteButtonSpecTyped _workspaceRestore;
        private KiwiPaletteButtonSpecTyped _ribbonMinimize;
        private KiwiPaletteButtonSpecTyped _ribbonExpand;
        #endregion

        #region Events
        /// <summary>
        /// Occurs when a button spec change occurs.
        /// </summary>
        public event EventHandler ButtonSpecChanged;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiPaletteButtonSpecs class.
        /// </summary>
        /// <param name="redirector">Palette redirector for sourcing inherited values.</param>
        internal KiwiPaletteButtonSpecs(PaletteRedirect redirector)
        {
            Debug.Assert(redirector != null);

            // Create exposed button specifications
            _common = new KiwiPaletteButtonSpecTyped(redirector);
            _generic = new KiwiPaletteButtonSpecTyped(redirector);
            _close = new KiwiPaletteButtonSpecTyped(redirector);
            _context = new KiwiPaletteButtonSpecTyped(redirector);
            _next = new KiwiPaletteButtonSpecTyped(redirector);
            _previous = new KiwiPaletteButtonSpecTyped(redirector);
            _arrowLeft = new KiwiPaletteButtonSpecTyped(redirector);
            _arrowRight = new KiwiPaletteButtonSpecTyped(redirector);
            _arrowUp = new KiwiPaletteButtonSpecTyped(redirector);
            _arrowDown = new KiwiPaletteButtonSpecTyped(redirector);
            _dropDown = new KiwiPaletteButtonSpecTyped(redirector);
            _pinVertical = new KiwiPaletteButtonSpecTyped(redirector);
            _pinHorizontal = new KiwiPaletteButtonSpecTyped(redirector);
            _formClose = new KiwiPaletteButtonSpecTyped(redirector);
            _formMax = new KiwiPaletteButtonSpecTyped(redirector);
            _formMin = new KiwiPaletteButtonSpecTyped(redirector);
            _formRestore = new KiwiPaletteButtonSpecTyped(redirector);
            _pendantClose = new KiwiPaletteButtonSpecTyped(redirector);
            _pendantMin = new KiwiPaletteButtonSpecTyped(redirector);
            _pendantRestore = new KiwiPaletteButtonSpecTyped(redirector);
            _workspaceMaximize = new KiwiPaletteButtonSpecTyped(redirector);
            _workspaceRestore = new KiwiPaletteButtonSpecTyped(redirector);
            _ribbonMinimize = new KiwiPaletteButtonSpecTyped(redirector);
            _ribbonExpand = new KiwiPaletteButtonSpecTyped(redirector);

            // Create redirector for inheriting from style specific to style common
            PaletteRedirectButtonSpec redirectCommon = new PaletteRedirectButtonSpec(redirector, _common);

            // Inform the button spec to use the new redirector
            _generic.SetRedirector(redirectCommon);
            _close.SetRedirector(redirectCommon);
            _context.SetRedirector(redirectCommon);
            _next.SetRedirector(redirectCommon);
            _previous.SetRedirector(redirectCommon);
            _arrowLeft.SetRedirector(redirectCommon);
            _arrowRight.SetRedirector(redirectCommon);
            _arrowUp.SetRedirector(redirectCommon);
            _arrowDown.SetRedirector(redirectCommon);
            _dropDown.SetRedirector(redirectCommon);
            _pinVertical.SetRedirector(redirectCommon);
            _pinHorizontal.SetRedirector(redirectCommon);
            _formClose.SetRedirector(redirectCommon);
            _formMax.SetRedirector(redirectCommon);
            _formMin.SetRedirector(redirectCommon);
            _formRestore.SetRedirector(redirectCommon);
            _pendantClose.SetRedirector(redirectCommon);
            _pendantMin.SetRedirector(redirectCommon);
            _pendantRestore.SetRedirector(redirectCommon);
            _workspaceMaximize.SetRedirector(redirectCommon);
            _workspaceRestore.SetRedirector(redirectCommon);
            _ribbonMinimize.SetRedirector(redirectCommon);
            _ribbonExpand.SetRedirector(redirectCommon);

            // Hook into the storage change events
            _common.ButtonSpecChanged += new EventHandler(OnButtonSpecChanged);
            _generic.ButtonSpecChanged += new EventHandler(OnButtonSpecChanged);
            _close.ButtonSpecChanged += new EventHandler(OnButtonSpecChanged);
            _context.ButtonSpecChanged += new EventHandler(OnButtonSpecChanged);
            _next.ButtonSpecChanged += new EventHandler(OnButtonSpecChanged);
            _previous.ButtonSpecChanged += new EventHandler(OnButtonSpecChanged);
            _arrowLeft.ButtonSpecChanged += new EventHandler(OnButtonSpecChanged);
            _arrowRight.ButtonSpecChanged += new EventHandler(OnButtonSpecChanged);
            _arrowUp.ButtonSpecChanged += new EventHandler(OnButtonSpecChanged);
            _arrowDown.ButtonSpecChanged += new EventHandler(OnButtonSpecChanged);
            _dropDown.ButtonSpecChanged += new EventHandler(OnButtonSpecChanged);
            _pinVertical.ButtonSpecChanged += new EventHandler(OnButtonSpecChanged);
            _pinHorizontal.ButtonSpecChanged += new EventHandler(OnButtonSpecChanged);
            _formClose.ButtonSpecChanged += new EventHandler(OnButtonSpecChanged);
            _formMax.ButtonSpecChanged += new EventHandler(OnButtonSpecChanged);
            _formMin.ButtonSpecChanged += new EventHandler(OnButtonSpecChanged);
            _formRestore.ButtonSpecChanged += new EventHandler(OnButtonSpecChanged);
            _pendantClose.ButtonSpecChanged += new EventHandler(OnButtonSpecChanged);
            _pendantMin.ButtonSpecChanged += new EventHandler(OnButtonSpecChanged);
            _pendantRestore.ButtonSpecChanged += new EventHandler(OnButtonSpecChanged);
            _workspaceMaximize.ButtonSpecChanged += new EventHandler(OnButtonSpecChanged);
            _workspaceRestore.ButtonSpecChanged += new EventHandler(OnButtonSpecChanged);
            _ribbonMinimize.ButtonSpecChanged += new EventHandler(OnButtonSpecChanged);
            _ribbonExpand.ButtonSpecChanged += new EventHandler(OnButtonSpecChanged);
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
                return _common.IsDefault &&
                       _generic.IsDefault &&
                       _close.IsDefault &&
                       _context.IsDefault &&
                       _next.IsDefault &&
                       _previous.IsDefault &&
                       _arrowLeft.IsDefault &&
                       _arrowRight.IsDefault &&
                       _arrowUp.IsDefault &&
                       _arrowDown.IsDefault &&
                       _dropDown.IsDefault &&
                       _pinVertical.IsDefault &&
                       _pinHorizontal.IsDefault &&
                       _formClose.IsDefault &&
                       _formMax.IsDefault &&
                       _formMin.IsDefault &&
                       _formRestore.IsDefault &&
                       _pendantClose.IsDefault &&
                       _pendantMin.IsDefault &&
                       _pendantRestore.IsDefault &&
                       _workspaceMaximize.IsDefault &&
                       _workspaceRestore.IsDefault &&
                       _ribbonMinimize.IsDefault &&
                       _ribbonExpand.IsDefault;
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
            _generic.PopulateFromBase(PaletteButtonSpecStyle.Generic);
            _close.PopulateFromBase(PaletteButtonSpecStyle.Close);
            _context.PopulateFromBase(PaletteButtonSpecStyle.Context);
            _next.PopulateFromBase(PaletteButtonSpecStyle.Next);
            _previous.PopulateFromBase(PaletteButtonSpecStyle.Previous);
            _arrowLeft.PopulateFromBase(PaletteButtonSpecStyle.ArrowLeft);
            _arrowRight.PopulateFromBase(PaletteButtonSpecStyle.ArrowRight);
            _arrowUp.PopulateFromBase(PaletteButtonSpecStyle.ArrowUp);
            _arrowDown.PopulateFromBase(PaletteButtonSpecStyle.ArrowDown);
            _dropDown.PopulateFromBase(PaletteButtonSpecStyle.DropDown);
            _pinVertical.PopulateFromBase(PaletteButtonSpecStyle.PinVertical);
            _pinHorizontal.PopulateFromBase(PaletteButtonSpecStyle.PinHorizontal);
            _formClose.PopulateFromBase(PaletteButtonSpecStyle.FormClose);
            _formMax.PopulateFromBase(PaletteButtonSpecStyle.FormMax);
            _formMin.PopulateFromBase(PaletteButtonSpecStyle.FormMin);
            _formRestore.PopulateFromBase(PaletteButtonSpecStyle.FormRestore);
            _pendantClose.PopulateFromBase(PaletteButtonSpecStyle.PendantClose);
            _pendantRestore.PopulateFromBase(PaletteButtonSpecStyle.PendantRestore);
            _pendantMin.PopulateFromBase(PaletteButtonSpecStyle.PendantMin);
            _pendantRestore.PopulateFromBase(PaletteButtonSpecStyle.PendantRestore);
            _workspaceMaximize.PopulateFromBase(PaletteButtonSpecStyle.WorkspaceMaximize);
            _workspaceRestore.PopulateFromBase(PaletteButtonSpecStyle.WorkspaceRestore);
            _ribbonMinimize.PopulateFromBase(PaletteButtonSpecStyle.RibbonMinimize);
            _ribbonExpand.PopulateFromBase(PaletteButtonSpecStyle.RibbonExpand);
        }
        #endregion

        #region Common
        /// <summary>
        /// Gets access to the common button specification.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining common button specifications.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteButtonSpecTyped Common
        {
            get { return _common; }
        }

        private bool ShouldSerializeCommon()
        {
            return !_common.IsDefault;
        }
        #endregion

        #region Generic
        /// <summary>
        /// Gets access to the generic button specification.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining generic button specifications.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteButtonSpecTyped Generic
        {
            get { return _generic; }
        }

        private bool ShouldSerializeGeneric()
        {
            return !_generic.IsDefault;
        }
        #endregion

        #region Close
        /// <summary>
        /// Gets access to the close button specification.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining close button specifications.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteButtonSpecTyped Close
        {
            get { return _close; }
        }

        private bool ShouldSerializeClose()
        {
            return !_close.IsDefault;
        }
        #endregion

        #region Context
        /// <summary>
        /// Gets access to the context button specification.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining context button specifications.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteButtonSpecTyped Context
        {
            get { return _context; }
        }

        private bool ShouldSerializeContext()
        {
            return !_context.IsDefault;
        }
        #endregion

        #region Next
        /// <summary>
        /// Gets access to the next button specification.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining next button specifications.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteButtonSpecTyped Next
        {
            get { return _next; }
        }

        private bool ShouldSerializeNext()
        {
            return !_next.IsDefault;
        }
        #endregion

        #region Previous
        /// <summary>
        /// Gets access to the previous button specification.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining previous button specifications.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteButtonSpecTyped Previous
        {
            get { return _previous; }
        }

        private bool ShouldSerializePrevious()
        {
            return !_previous.IsDefault;
        }
        #endregion

        #region ArrowLeft
        /// <summary>
        /// Gets access to the left arrow button specification.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining left arrow button specifications.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteButtonSpecTyped ArrowLeft
        {
            get { return _arrowLeft; }
        }

        private bool ShouldSerializeArrowLeft()
        {
            return !_arrowLeft.IsDefault;
        }
        #endregion

        #region ArrowRight
        /// <summary>
        /// Gets access to the right arrow button specification.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining right arrow button specifications.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteButtonSpecTyped ArrowRight
        {
            get { return _arrowRight; }
        }

        private bool ShouldSerializeArrowRight()
        {
            return !_arrowRight.IsDefault;
        }
        #endregion

        #region ArrowUp
        /// <summary>
        /// Gets access to the right up button specification.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining up arrow button specifications.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteButtonSpecTyped ArrowUp
        {
            get { return _arrowUp; }
        }

        private bool ShouldSerializeArrowUp()
        {
            return !_arrowUp.IsDefault;
        }
        #endregion

        #region ArrowDown
        /// <summary>
        /// Gets access to the right up button specification.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining up arrow button specifications.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteButtonSpecTyped ArrowDown
        {
            get { return _arrowDown; }
        }

        private bool ShouldSerializeArrowDown()
        {
            return !_arrowDown.IsDefault;
        }
        #endregion

        #region DropDown
        /// <summary>
        /// Gets access to the drop down button specification.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining drop down button specifications.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteButtonSpecTyped DropDown
        {
            get { return _dropDown; }
        }

        private bool ShouldSerializeDropDown()
        {
            return !_dropDown.IsDefault;
        }
        #endregion

        #region PinVertical
        /// <summary>
        /// Gets access to the pin vertical button specification.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining pin vertical button specifications.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteButtonSpecTyped PinVertical
        {
            get { return _pinVertical; }
        }

        private bool ShouldSerializePinVertical()
        {
            return !_pinVertical.IsDefault;
        }
        #endregion

        #region PinHorizontal
        /// <summary>
        /// Gets access to the pin horizontal button specification.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining pin horizontal button specifications.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteButtonSpecTyped PinHorizontal
        {
            get { return _pinHorizontal; }
        }

        private bool ShouldSerializePinHorizontal()
        {
            return !_pinHorizontal.IsDefault;
        }
        #endregion

        #region FormClose
        /// <summary>
        /// Gets access to the form close button specification.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining form close button specifications.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteButtonSpecTyped FormClose
        {
            get { return _formClose; }
        }

        private bool ShouldSerializeFormClose()
        {
            return !_formClose.IsDefault;
        }
        #endregion

        #region FormMin
        /// <summary>
        /// Gets access to the form minimize button specification.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining form minimize button specifications.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteButtonSpecTyped FormMin
        {
            get { return _formMin; }
        }

        private bool ShouldSerializeFormMin()
        {
            return !_formMin.IsDefault;
        }
        #endregion

        #region FormMax
        /// <summary>
        /// Gets access to the form maximize button specification.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining form maximize button specifications.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteButtonSpecTyped FormMax
        {
            get { return _formMax; }
        }

        private bool ShouldSerializeFormMax()
        {
            return !_formMax.IsDefault;
        }
        #endregion

        #region FormRestore
        /// <summary>
        /// Gets access to the form restore button specification.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining form restore button specifications.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteButtonSpecTyped FormRestore
        {
            get { return _formRestore; }
        }

        private bool ShouldSerializeFormRestore()
        {
            return !_formRestore.IsDefault;
        }
        #endregion

        #region PendantClose
        /// <summary>
        /// Gets access to the pendant close button specification.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining pendant close button specifications.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteButtonSpecTyped PendantClose
        {
            get { return _pendantClose; }
        }

        private bool ShouldSerializePendantClose()
        {
            return !_pendantClose.IsDefault;
        }
        #endregion

        #region PendantMin
        /// <summary>
        /// Gets access to the pendant minimize button specification.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining pendant minimize button specifications.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteButtonSpecTyped PendantMin
        {
            get { return _pendantMin; }
        }

        private bool ShouldSerializePendantMin()
        {
            return !_pendantMin.IsDefault;
        }
        #endregion

        #region PendantRestore
        /// <summary>
        /// Gets access to the pendant restore button specification.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining pendant restore button specifications.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteButtonSpecTyped PendantRestore
        {
            get { return _pendantRestore; }
        }

        private bool ShouldSerializePendantRestore()
        {
            return !_pendantRestore.IsDefault;
        }
        #endregion

        #region WorkspaceMaximize
        /// <summary>
        /// Gets access to the workspace maximize button specification.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining workspace maximize button specifications.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteButtonSpecTyped WorkspaceMaximize
        {
            get { return _workspaceMaximize; }
        }

        private bool ShouldSerializeWorkspaceMaximize()
        {
            return !_workspaceMaximize.IsDefault;
        }
        #endregion

        #region WorkspaceRestore
        /// <summary>
        /// Gets access to the workspace restore button specification.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining workspace restore button specifications.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteButtonSpecTyped WorkspaceRestore
        {
            get { return _workspaceRestore; }
        }

        private bool ShouldSerializeWorkspaceRestore()
        {
            return !_workspaceRestore.IsDefault;
        }
        #endregion

        #region RibbonMinimize
        /// <summary>
        /// Gets access to the ribbon minimize button specification.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining ribbon minimize button specifications.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteButtonSpecTyped RibbonMinimize
        {
            get { return _ribbonMinimize; }
        }

        private bool ShouldSerializeRibbonMinimize()
        {
            return !_ribbonMinimize.IsDefault;
        }
        #endregion

        #region RibbonExpand
        /// <summary>
        /// Gets access to the ribbon expand button specification.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining ribbon expand button specifications.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteButtonSpecTyped RibbonExpand
        {
            get { return _ribbonExpand; }
        }

        private bool ShouldSerializeRibbonExpand()
        {
            return !_ribbonExpand.IsDefault;
        }
        #endregion

        #region OnButtonSpecChanged
        /// <summary>
        /// Raises the ButtonSpecChanged event.
        /// </summary>
        /// <param name="sender">Source of the event.</param>
        /// <param name="e">An EventArgs containing event data.</param>
        protected virtual void OnButtonSpecChanged(object sender, EventArgs e)
        {
            if (ButtonSpecChanged != null)
                ButtonSpecChanged(this, e);
        }
        #endregion
    }
}
