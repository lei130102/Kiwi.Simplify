﻿using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Ribbon
{
    /// <summary>
    /// Represents a ribbon group track bar.
    /// </summary>
    //
    [ToolboxItem(false)]
    [Designer("Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupTrackBarDesigner, Kiwi.ComponentFactory.Ribbon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=360f304a9e10e704")]
    [DesignerCategory("code")]
    [DesignTimeVisible(false)]
    [DefaultEvent("ValueChanged")]
    [DefaultProperty("Value")]
    //
    [ToolboxBitmap(typeof(KiwiRibbonGroupTrackBar), "ToolboxBitmaps.KiwiRibbonGroupTrackBar.bmp")]
    public class KiwiRibbonGroupTrackBar : KiwiRibbonGroupItem
    {
        #region Instance Fields
        private bool _visible;
        private bool _enabled;
        private string _keyTip;
        private int _minimumLength;
        private int _maximumLength;
        private GroupItemSize _itemSizeCurrent;
        private NeedPaintHandler _viewPaintDelegate;
        private KiwiTrackBar _trackBar;
        private KiwiTrackBar _lastTrackBar;
        private IKiwiDesignObject _designer;
        private Control _lastParentControl;
        private ViewBase _trackBarView;
        #endregion

        #region Events
        /// <summary>
        /// Occurs when the control receives focus.
        /// </summary>
        [Browsable(false)]
        public event EventHandler GotFocus;

        /// <summary>
        /// Occurs when the control loses focus.
        /// </summary>
        [Browsable(false)]
        public event EventHandler LostFocus;

        /// <summary>
        /// Occurs when the value of the Value property changes.
        /// </summary>
        [Category("Action")]
        [Description("Occurs when the value of the Value property changes.")]
        public event EventHandler ValueChanged;

        /// <summary>
        /// Occurs after the value of a property has changed.
        /// </summary>
        [Category("Ribbon")]
        [Description("Occurs after the value of a property has changed.")]
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Occurs when the design time context menu is requested.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        public event MouseEventHandler DesignTimeContextMenu;

        internal event EventHandler MouseEnterControl;
        internal event EventHandler MouseLeaveControl;
        #endregion

        #region Identity
        /// <summary>
        /// Initialise a new instance of the KiwiRibbonGroupTrackBar class.
        /// </summary>
        public KiwiRibbonGroupTrackBar()
        {
            // Default fields
            _visible = true;
            _enabled = true;
            _itemSizeCurrent = GroupItemSize.Medium;
            _keyTip = "T";
            _minimumLength = 55;
            _maximumLength = 55;

            // Create the actual track barcontrol and set initial settings
            _trackBar = new KiwiTrackBar();
            _trackBar.DrawBackground = false;
            _trackBar.TickStyle = TickStyle.None;
            _trackBar.MinimumSize = new Size(_minimumLength, 0);
            _trackBar.MaximumSize = new Size(_maximumLength, 0);
            _trackBar.TabStop = false;

            // Hook into events to expose via this container
            _trackBar.GotFocus += new EventHandler(OnTrackBarGotFocus);
            _trackBar.LostFocus += new EventHandler(OnTrackBarLostFocus);
            _trackBar.ValueChanged += new EventHandler(OnTrackBarValueChanged);

            // Ensure we can track mouse events on the track bar
            MonitorControl(_trackBar);
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_trackBar != null)
                {
                    UnmonitorControl(_trackBar);
                    _trackBar.Dispose();
                    _trackBar = null;
                }
            }

            base.Dispose(disposing);
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets access to the owning ribbon control.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override KiwiRibbon Ribbon
        {
            set
            {
                base.Ribbon = value;

                if (value != null)
                {
                    // Use the same palette in the track bar as the ribbon, plus we need
                    // to know when the ribbon palette changes so we can reflect that change
                    _trackBar.Palette = Ribbon.GetResolvedPalette();
                    Ribbon.PaletteChanged += new EventHandler(OnRibbonPaletteChanged);
                }
            }
        }

        /// <summary>
        /// Access to the actual embedded KiwiTrackBar instance.
        /// </summary>
        [Description("Access to the actual embedded KiwiTrackBar instance.")]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public KiwiTrackBar TrackBar
        {
            get { return _trackBar; }
        }

        /// <summary>
        /// Gets and sets the key tip for the ribbon group track bar.
        /// </summary>
        [Bindable(true)]
        [Localizable(true)]
        [Category("Appearance")]
        [Description("Ribbon group track bar key tip.")]
        [DefaultValue("T")]
        public string KeyTip
        {
            get { return _keyTip; }

            set
            {
                if (string.IsNullOrEmpty(value))
                    value = "T";

                _keyTip = value.ToUpper();
            }
        }

        /// <summary>
        /// Gets and sets the visible state of the track bar.
        /// </summary>
        [Bindable(true)]
        [Category("Behavior")]
        [Description("Determines whether the track bar is visible or hidden.")]
        [DefaultValue(true)]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override bool Visible
        {
            get { return _visible; }

            set
            {
                if (value != _visible)
                {
                    _visible = value;
                    OnPropertyChanged("Visible");
                }
            }
        }

        /// <summary>
        /// Make the ribbon group track bar visible.
        /// </summary>
        public void Show()
        {
            Visible = true;
        }

        /// <summary>
        /// Make the ribbon group track bar hidden.
        /// </summary>
        public void Hide()
        {
            Visible = false;
        }

        /// <summary>
        /// Gets and sets the enabled state of the group track bar.
        /// </summary>
        [Bindable(true)]
        [Category("Behavior")]
        [Description("Determines whether the group track bar is enabled.")]
        [DefaultValue(true)]
        public bool Enabled
        {
            get { return _enabled; }

            set
            {
                if (_enabled != value)
                {
                    _enabled = value;
                    OnPropertyChanged("Enabled");
                }
            }
        }

        /// <summary>
        /// Gets or sets the minimum length of the control.
        /// </summary>
        [Category("Layout")]
        [Description("Specifies the minimum length of the control.")]
        [DefaultValue("55")]
        public int MinimumLength
        {
            get { return _minimumLength; }

            set
            {
                _minimumLength = value;
                if (Orientation == Orientation.Horizontal)
                    _trackBar.MinimumSize = new Size(_minimumLength, 0);
                else
                    _trackBar.MinimumSize = new Size(0, _minimumLength);
            }
        }

        /// <summary>
        /// Gets or sets the maximum length of the control.
        /// </summary>
        [Category("Layout")]
        [Description("Specifies the maximum length of the control.")]
        [DefaultValue("50")]
        public int MaximumLength
        {
            get { return _maximumLength; }

            set
            {
                _maximumLength = value;
                if (Orientation == Orientation.Horizontal)
                    _trackBar.MaximumSize = new Size(_maximumLength, 0);
                else
                    _trackBar.MaximumSize = new Size(0, _maximumLength);
            }
        }

        /// <summary>
        /// Gets and sets the associated context menu strip.
        /// </summary>
        [Category("Behavior")]
        [Description("The shortcut to display when the user right-clicks the control.")]
        [DefaultValue(null)]
        public ContextMenuStrip ContextMenuStrip
        {
            get { return _trackBar.ContextMenuStrip; }
            set { _trackBar.ContextMenuStrip = value; }
        }

        /// <summary>
        /// Gets and sets the KiwiContextMenu for showing when the text box is right clicked.
        /// </summary>
        [Category("Behavior")]
        [Description("KiwiContextMenu to be shown when the text box is right clicked.")]
        [DefaultValue(null)]
        public KiwiContextMenu KiwiContextMenu
        {
            get { return _trackBar.KiwiContextMenu; }
            set { _trackBar.KiwiContextMenu = value; }
        }

        /// <summary>
        /// Gets and sets the size of the track bar elements.
        /// </summary>
        [Category("Appearance")]
        [Description("Determines size of the track bar elements.")]
        [DefaultValue(typeof(PaletteTrackBarSize), "Medium")]
        public PaletteTrackBarSize TrackBarSize
        {
            get { return _trackBar.TrackBarSize; }
            set { _trackBar.TrackBarSize = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating how to display the tick marks on the track bar.
        /// </summary>
        [Category("Appearance")]
        [Description("Determines where tick marks are displayed.")]
        [DefaultValue(typeof(TickStyle), "None")]
        [RefreshProperties(RefreshProperties.All)]
        public TickStyle TickStyle
        {
            get { return _trackBar.TickStyle; }
            set { _trackBar.TickStyle = value; }
        }

        /// <summary>
        /// Gets or sets a value that specifies the delta between ticks drawn on the control.
        /// </summary>
        [Category("Appearance")]
        [Description("Determines the frequency of tick marks.")]
        [DefaultValue(1)]
        public int TickFrequency
        {
            get { return _trackBar.TickFrequency; }
            set { _trackBar.TickFrequency = value; }
        }

        /// <summary>
        /// Gets and sets if the control displays like a volume control.
        /// </summary>
        [Category("Appearance")]
        [Description("Determines if the control display like a volume control.")]
        [DefaultValue(false)]
        public bool VolumeControl
        {
            get { return _trackBar.VolumeControl; }
            set { _trackBar.VolumeControl = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating the horizontal or vertical orientation of the track bar.
        /// </summary>
        [Category("Appearance")]
        [Description("Background style.")]
        [DefaultValue(typeof(Orientation), "Horizontal")]
        [RefreshProperties(RefreshProperties.All)]
        public Orientation Orientation
        {
            get { return _trackBar.Orientation; }

            set
            {
                if (value != _trackBar.Orientation)
                {
                    _trackBar.Orientation = value;

                    if (Orientation == Orientation.Horizontal)
                    {
                        _trackBar.MinimumSize = new Size(_minimumLength, 0);
                        _trackBar.MaximumSize = new Size(_maximumLength, 0);
                    }
                    else
                    {
                        _trackBar.MinimumSize = new Size(0, _minimumLength);
                        _trackBar.MaximumSize = new Size(0, _maximumLength);
                    }
                }
            }
        }

        /// <summary>
        /// Gets or sets the upper limit of the range this trackbar is working with.
        /// </summary>
        [Category("Behavior")]
        [Description("Upper limit of the trackbar range.")]
        [RefreshProperties(RefreshProperties.All)]
        [DefaultValue(10)]
        public int Maximum
        {
            get { return _trackBar.Maximum; }
            set { _trackBar.Maximum = value; }
        }

        /// <summary>
        /// Gets or sets the lower limit of the range this trackbar is working with.
        /// </summary>
        [Category("Behavior")]
        [Description("Lower limit of the trackbar range.")]
        [RefreshProperties(RefreshProperties.All)]
        [DefaultValue(0)]
        public int Minimum
        {
            get { return _trackBar.Minimum; }
            set { _trackBar.Minimum = value; }
        }

        /// <summary>
        /// Gets or sets a numeric value that represents the current position of the scroll box on the track bar.
        /// </summary>
        [Category("Behavior")]
        [Description("Current position of the indicator within the trackbar.")]
        [DefaultValue(0)]
        public int Value
        {
            get { return _trackBar.Value; }
            set { _trackBar.Value = value; }
        }

        /// <summary>
        /// Gets or sets the value added to or subtracted from the Value property when the scroll box is moved a small distance.
        /// </summary>
        [Category("Behavior")]
        [Description("Change to apply when a small change occurs.")]
        [DefaultValue(1)]
        public int SmallChange
        {
            get { return _trackBar.SmallChange; }
            set { _trackBar.SmallChange = value; }
        }

        /// <summary>
        /// Gets or sets a value to be added to or subtracted from the Value property when the scroll box is moved a large distance.
        /// </summary>
        [Category("Behavior")]
        [Description("Change to apply when a large change occurs.")]
        [DefaultValue(5)]
        public int LargeChange
        {
            get { return _trackBar.LargeChange; }
            set { _trackBar.LargeChange = value; }
        }

        /// <summary>
        /// Sets the minimum and maximum values for a TrackBar.
        /// </summary>
        /// <param name="minValue">The lower limit of the range of the track bar.</param>
        /// <param name="maxValue">The upper limit of the range of the track bar.</param>
        public void SetRange(int minValue, int maxValue)
        {
            _trackBar.SetRange(minValue, maxValue);
        }

        /// <summary>
        /// Gets and sets the maximum allowed size of the item.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override GroupItemSize ItemSizeMaximum
        {
            get { return GroupItemSize.Large; }
            set { }
        }

        /// <summary>
        /// Gets and sets the minimum allowed size of the item.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override GroupItemSize ItemSizeMinimum
        {
            get { return GroupItemSize.Small; }
            set { }
        }

        /// <summary>
        /// Gets and sets the current item size.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override GroupItemSize ItemSizeCurrent
        {
            get { return _itemSizeCurrent; }

            set
            {
                if (_itemSizeCurrent != value)
                {
                    _itemSizeCurrent = value;
                    OnPropertyChanged("ItemSizeCurrent");
                }
            }
        }

        /// <summary>
        /// Creates an appropriate view element for this item.
        /// </summary>
        /// <param name="ribbon">Reference to the owning ribbon control.</param>
        /// <param name="needPaint">Delegate for notifying changes in display.</param>
        /// <returns>ViewBase derived instance.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override ViewBase CreateView(KiwiRibbon ribbon,
                                            NeedPaintHandler needPaint)
        {
            return new ViewDrawRibbonGroupTrackBar(ribbon, this, needPaint);
        }

        /// <summary>
        /// Gets and sets the associated designer.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        public IKiwiDesignObject TrackBarDesigner
        {
            get { return _designer; }
            set { _designer = value; }
        }

        /// <summary>
        /// Internal design time properties.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        public ViewBase TrackBarView
        {
            get { return _trackBarView; }
            set { _trackBarView = value; }
        }
        #endregion

        #region Protected Virtual
        /// <summary>
        /// Raises the GotFocus event.
        /// </summary>
        /// <param name="e">An EventArgs containing the event data.</param>
        protected virtual void OnGotFocus(EventArgs e)
        {
            if (GotFocus != null)
                GotFocus(this, e);
        }

        /// <summary>
        /// Raises the LostFocus event.
        /// </summary>
        /// <param name="e">An EventArgs containing the event data.</param>
        protected virtual void OnLostFocus(EventArgs e)
        {
            if (LostFocus != null)
                LostFocus(this, e);
        }

        /// <summary>
        /// Raises the PropertyChanged event.
        /// </summary>
        /// <param name="propertyName">Name of property that has changed.</param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Internal
        internal Control LastParentControl
        {
            get { return _lastParentControl; }
            set { _lastParentControl = value; }
        }

        internal KiwiTrackBar LastTrackBar
        {
            get { return _lastTrackBar; }
            set { _lastTrackBar = value; }
        }

        internal NeedPaintHandler ViewPaintDelegate
        {
            get { return _viewPaintDelegate; }
            set { _viewPaintDelegate = value; }
        }

        internal void OnDesignTimeContextMenu(MouseEventArgs e)
        {
            if (DesignTimeContextMenu != null)
                DesignTimeContextMenu(this, e);
        }

        internal override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return false;
        }
        #endregion

        #region Implementation
        private void MonitorControl(KiwiTrackBar c)
        {
            c.MouseEnter += new EventHandler(OnControlEnter);
            c.MouseLeave += new EventHandler(OnControlLeave);
        }

        private void UnmonitorControl(KiwiTrackBar c)
        {
            c.MouseEnter -= new EventHandler(OnControlEnter);
            c.MouseLeave -= new EventHandler(OnControlLeave);
        }

        private void OnControlEnter(object sender, EventArgs e)
        {
            if (MouseEnterControl != null)
                MouseEnterControl(this, e);
        }

        private void OnControlLeave(object sender, EventArgs e)
        {
            if (MouseLeaveControl != null)
                MouseLeaveControl(this, e);
        }

        private void OnPaletteNeedPaint(object sender, NeedLayoutEventArgs e)
        {
            // Pass request onto the view provided paint delegate
            if (_viewPaintDelegate != null)
                _viewPaintDelegate(this, e);
        }

        private void OnTrackBarGotFocus(object sender, EventArgs e)
        {
            OnGotFocus(e);
        }

        private void OnTrackBarLostFocus(object sender, EventArgs e)
        {
            OnLostFocus(e);
        }

        private void OnTrackBarValueChanged(object sender, EventArgs e)
        {
            if (ValueChanged != null)
                ValueChanged(this, e);
        }

        private void OnRibbonPaletteChanged(object sender, EventArgs e)
        {
            _trackBar.Palette = Ribbon.GetResolvedPalette();
        }
        #endregion
    }
}
