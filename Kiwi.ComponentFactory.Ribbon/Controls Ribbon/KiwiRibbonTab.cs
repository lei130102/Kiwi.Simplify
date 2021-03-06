using Kiwi.ComponentFactory.Toolkit;
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
    /// Represents a single ribbon tab.
    /// </summary>
    //
    [ToolboxItem(false)]
    [Designer("Kiwi.ComponentFactory.Ribbon.KiwiRibbonTabDesigner, Kiwi.ComponentFactory.Ribbon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=360f304a9e10e704")]
    [DefaultProperty("Text")]
    [DesignerCategory("code")]
    [DesignTimeVisible(false)]
    //
    [ToolboxBitmap(typeof(KiwiRibbonTab), "ToolboxBitmaps.KiwiRibbonTab.bmp")]
    public class KiwiRibbonTab : Component
    {
        #region Instance Fields
        private object _tag;
        private string _text;
        private string _keyTip;
        private string _contextName;
        private bool _visible;
        private KiwiRibbon _ribbon;
        private KiwiRibbonGroupCollection _ribbonGroups;
        private ViewBase _tabView;
        #endregion

        #region Events
        /// <summary>
        /// Occurs after the value of a property has changed.
        /// </summary>
        [Category("Ribbon")]
        [Description("Occurs after the value of a property has changed.")]
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Occurs when the design time wants to add a group.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        public event EventHandler DesignTimeAddGroup;

        /// <summary>
        /// Occurs when the design time context menu is requested.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        public event MouseEventHandler DesignTimeContextMenu;
        #endregion

        #region Identity
        /// <summary>
        /// Initialise a new instance of the KiwiRibbonTab class.
        /// </summary>
        public KiwiRibbonTab()
        {
            // Default fields
            _text = "Tab";
            _keyTip = "T";
            _contextName = string.Empty;
            _visible = true;

            // Create the collection for defining groups
            _ribbonGroups = new KiwiRibbonGroupCollection();
            _ribbonGroups.Clearing += new EventHandler(OnRibbonGroupsClearing);
            _ribbonGroups.Cleared += new EventHandler(OnRibbonGroupsCleared);
            _ribbonGroups.Inserted += new TypedHandler<KiwiRibbonGroup>(OnRibbonGroupsInserted);
            _ribbonGroups.Removed += new TypedHandler<KiwiRibbonGroup>(OnRibbonGroupsRemoved);
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Dispose of per-group resources
                foreach (KiwiRibbonGroup group in Groups)
                    group.Dispose();
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
        public KiwiRibbon Ribbon
        {
            get { return _ribbon; }

            internal set
            {
                _ribbon = value;

                // Forward the reference to all children (just in case the children
                // are added before the group is added to the tab, in which case the
                // reference will not be set as yet)
                foreach (KiwiRibbonGroup group in _ribbonGroups)
                    group.Ribbon = value;
            }
        }

        /// <summary>
        /// Gets and sets the display text for the ribbon tab.
        /// </summary>
        [Bindable(true)]
        [Localizable(true)]
        [Category("Appearance")]
        [Description("Ribbon tab display text.")]
        [DefaultValue("Tab")]
        public string Text
        {
            get { return _text; }

            set
            {
                // We never allow an empty text value
                if (string.IsNullOrEmpty(value))
                    value = "Tab";

                if (value != _text)
                {
                    _text = value;
                    OnPropertyChanged("Text");

                    // Only need to update display if this tab is visible
                    if ((_ribbon != null) && Visible)
                        _ribbon.PerformNeedPaint(true);
                }
            }
        }

        /// <summary>
        /// Gets and sets the key tip for the ribbon tab.
        /// </summary>
        [Bindable(true)]
        [Localizable(true)]
        [Category("Appearance")]
        [Description("Ribbon tab key tip.")]
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
        /// Gets and sets the name of the context this tab is associated with.
        /// </summary>
        [Bindable(true)]
        [Localizable(true)]
        [Category("Appearance")]
        [Description("Only display tab when this context is active.")]
        [DefaultValue("")]
        public string ContextName
        {
            get { return _contextName; }

            set
            {
                // Always maintain a value reference
                if (value == null)
                    value = string.Empty;

                if (value != _contextName)
                {
                    _contextName = value;
                    OnPropertyChanged("ContextName");

                    // Only need to update display if this tab is visible
                    if ((_ribbon != null) && Visible)
                        _ribbon.PerformNeedPaint(true);
                }
            }
        }

        private bool ShouldSerializeContextName()
        {
            return !string.IsNullOrEmpty(_contextName);
        }

        /// <summary>
        /// Reset the ContextName to the default value.
        /// </summary>
        private void ResetContextName()
        {
            ContextName = string.Empty;
        }

        /// <summary>
        /// Gets and sets the visible state of the ribbon tab.
        /// </summary>
        [Bindable(true)]
        [Category("Behavior")]
        [Description("Determines whether the ribbon tab is visible or hidden.")]
        [DefaultValue(true)]
        public bool Visible
        {
            get { return _visible; }

            set
            {
                if (value != _visible)
                {
                    _visible = value;
                    OnPropertyChanged("Visible");

                    // Must try and layout to show change
                    if (_ribbon != null)
                    {
                        // If selected, find another tab to select
                        if (_ribbon.SelectedTab == this)
                            _ribbon.ResetSelectedTab();

                        _ribbon.PerformNeedPaint(true);
                    }
                }
            }
        }

        /// <summary>
        /// Make the ribbon tab visible.
        /// </summary>
        public void Show()
        {
            Visible = true;
        }

        /// <summary>
        /// Make the ribbon tab hidden.
        /// </summary>
        public void Hide()
        {
            Visible = false;
        }

        /// <summary>
        /// Gets the collection of ribbon tab groups.
        /// </summary>
        [Category("Visuals")]
        [Description("Collection of ribbon tab groups.")]
        [MergableProperty(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiRibbonGroupCollection Groups
        {
            get { return _ribbonGroups; }
        }

        /// <summary>
        /// Gets and sets user-defined data associated with the object.
        /// </summary>
        [Category("Data")]
        [Description("User-defined data associated with the object.")]
        [TypeConverter(typeof(StringConverter))]
        [Bindable(true)]
        public object Tag
        {
            get { return _tag; }

            set
            {
                if (value != _tag)
                {
                    _tag = value;
                    OnPropertyChanged("Tag");
                }
            }
        }

        private bool ShouldSerializeTag()
        {
            return (Tag != null);
        }

        private void ResetTag()
        {
            Tag = null;
        }

        /// <summary>
        /// Internal design time properties.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        public ViewBase TabView
        {
            get { return _tabView; }
            set { _tabView = value; }
        }
        #endregion

        #region Protected
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
        internal void OnDesignTimeContextMenu(MouseEventArgs e)
        {
            if (DesignTimeContextMenu != null)
                DesignTimeContextMenu(this, e);
        }

        internal void OnDesignTimeAddGroup()
        {
            if (DesignTimeAddGroup != null)
                DesignTimeAddGroup(this, EventArgs.Empty);
        }

        internal bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Ask the groups to check for command key processing
            foreach (KiwiRibbonGroup group in Groups)
                if (group.Visible && group.ProcessCmdKey(ref msg, keyData))
                    return true;

            return false;
        }
        #endregion

        #region Private
        private void OnRibbonGroupsClearing(object sender, EventArgs e)
        {
            // Remove the back references
            foreach (KiwiRibbonGroup group in _ribbonGroups)
            {
                group.Ribbon = null;
                group.RibbonTab = null;
            }
        }

        private void OnRibbonGroupsCleared(object sender, EventArgs e)
        {
            // Only need to update display if this tab is selected
            if ((_ribbon != null) && (_ribbon.SelectedTab == this))
                _ribbon.PerformNeedPaint(true);
        }

        private void OnRibbonGroupsInserted(object sender, TypedCollectionEventArgs<KiwiRibbonGroup> e)
        {
            // Setup the back references
            e.Item.Ribbon = _ribbon;
            e.Item.RibbonTab = this;

            // Only need to update display if this tab is selected and the group is visible
            if ((_ribbon != null) && (_ribbon.SelectedTab == this) && Visible)
                _ribbon.PerformNeedPaint(true);
        }

        private void OnRibbonGroupsRemoved(object sender, TypedCollectionEventArgs<KiwiRibbonGroup> e)
        {
            // Remove the back references
            e.Item.Ribbon = null;
            e.Item.RibbonTab = null;

            // Only need to update display if this tab is selected and the group was visible
            if ((_ribbon != null) && (_ribbon.SelectedTab == this) && Visible)
                _ribbon.PerformNeedPaint(true);
        }
        #endregion
    }
}
