using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Ribbon
{
    /// <summary>
    /// Represents a single context definition.
    /// </summary>
    //
    [ToolboxItem(false)]
    [DefaultProperty("ContextName")]
    [DesignerCategory("code")]
    [DesignTimeVisible(false)]
    //
    [ToolboxBitmap(typeof(KiwiRibbonContext), "ToolboxBitmaps.KiwiRibbonContext.bmp")]
    public class KiwiRibbonContext : Component
    {
        #region Instance Fields
        private string _contextName;
        private string _contextTitle;
        private Color _contextColor;
        private object _tag;
        #endregion

        #region Events
        /// <summary>
        /// Occurs after the value of a property has changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Identity
        /// <summary>
        /// Initialise a new instance of the KiwiRibbonContext class.
        /// </summary>
        public KiwiRibbonContext()
        {
            // Default fields
            _contextName = "Context";
            _contextTitle = "Context Tools";
            _contextColor = Color.Red;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets and sets the unique name of the context.
        /// </summary>
        [Category("Appearance")]
        [Description("Unique name of the context.")]
        [DefaultValue("Context")]
        public string ContextName
        {
            get { return _contextName; }

            set
            {
                // We never allow an empty text value
                if (string.IsNullOrEmpty(value))
                    value = "Context";

                if (value != _contextName)
                {
                    _contextName = value;
                    OnPropertyChanged("ContextName");
                }
            }
        }

        /// <summary>
        /// Gets and sets the display title for associated contextual tabs.
        /// </summary>
        [Bindable(true)]
        [Localizable(true)]
        [Category("Appearance")]
        [Description("Display title for associated contextual tabs.")]
        [DefaultValue("Context")]
        public string ContextTitle
        {
            get { return _contextTitle; }

            set
            {
                // We never allow an empty text value
                if (string.IsNullOrEmpty(value))
                    value = "Context Tools";

                if (value != _contextTitle)
                {
                    _contextTitle = value;
                    OnPropertyChanged("ContextTitle");
                }
            }
        }

        /// <summary>
        /// Gets and sets the display color for associated contextual tabs.
        /// </summary>
        [Bindable(true)]
        [Localizable(true)]
        [Category("Appearance")]
        [Description("Display color for associated contextual tabs.")]
        [DefaultValue(typeof(Color), "Red")]
        public Color ContextColor
        {
            get { return _contextColor; }

            set
            {
                // We never allow a null or transparent color
                if ((value == null) || (value == Color.Transparent))
                    value = Color.Red;

                if (value != _contextColor)
                {
                    _contextColor = value;
                    OnPropertyChanged("ContextColor");
                }
            }
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
    }
}
