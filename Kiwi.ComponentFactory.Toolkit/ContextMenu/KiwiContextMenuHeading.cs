using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Provide a context menu heading.
    /// </summary>
    [ToolboxItem(false)]
    //
    [ToolboxBitmap(typeof(KiwiContextMenuHeading), "ToolboxBitmaps.KiwiContextMenuHeading.bmp")]
    [DefaultProperty("Text")]
    [DesignerCategory("code")]
    [DesignTimeVisible(false)]
    public class KiwiContextMenuHeading : KiwiContextMenuItemBase
    {
        #region Instance Fields
        private string _text;
        private string _extraText;
        private Image _image;
        private Color _imageTransparentColor;
        private PaletteTripleRedirect _stateNormal;
        private PaletteRedirectTriple _redirectHeading;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiContextMenuHeading class.
        /// </summary>
        public KiwiContextMenuHeading()
            : this("Heading")
        {
        }

        /// <summary>
        /// Initialize a new instance of the KiwiContextMenuHeading class.
        /// </summary>
        /// <param name="initialText">Initial text for display.</param>
        public KiwiContextMenuHeading(string initialText)
        {
            // Default fields
            _text = initialText;
            _extraText = string.Empty;
            _image = null;
            _imageTransparentColor = Color.Empty;

            // Create the redirector that can get values from the kiwi context menu
            _redirectHeading = new PaletteRedirectTriple();

            // Create the header storage for overriding specific values
            _stateNormal = new PaletteTripleRedirect(_redirectHeading,
                                                     PaletteBackStyle.ContextMenuHeading,
                                                     PaletteBorderStyle.ContextMenuHeading,
                                                     PaletteContentStyle.ContextMenuHeading);
        }

        /// <summary>
        /// Returns a description of the instance.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return Text;
        }
        #endregion

        #region Public
        /// <summary>
        /// Returns the number of child menu items.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int ItemChildCount
        {
            get { return 0; }
        }

        /// <summary>
        /// Returns the indexed child menu item.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override KiwiContextMenuItemBase this[int index]
        {
            get { return null; }
        }

        /// <summary>
        /// Test for the provided shortcut and perform relevant action if a match is found.
        /// </summary>
        /// <param name="keyData">Key data to check against shorcut definitions.</param>
        /// <returns>True if shortcut was handled, otherwise false.</returns>
        public override bool ProcessShortcut(Keys keyData)
        {
            return false;
        }

        /// <summary>
        /// Returns a view appropriate for this item based on the object it is inside.
        /// </summary>
        /// <param name="provider">Provider of context menu information.</param>
        /// <param name="parent">Owning object reference.</param>
        /// <param name="columns">Containing columns.</param>
        /// <param name="standardStyle">Draw items with standard or alternate style.</param>
        /// <param name="imageColumn">Draw an image background for the item images.</param>
        /// <returns>ViewBase that is the root of the view hierachy being added.</returns>
        public override ViewBase GenerateView(IContextMenuProvider provider,
                                              object parent,
                                              ViewLayoutStack columns,
                                              bool standardStyle,
                                              bool imageColumn)
        {
            return new ViewDrawMenuHeading(this, provider.ProviderStateCommon.Heading);
        }

        /// <summary>
        /// Gets and sets the heading menu item text.
        /// </summary>
        [KiwiPersist]
        [Category("Appearance")]
        [Description("Heading menu item text.")]
        [Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [DefaultValue("Heading")]
        public string Text
        {
            get { return _text; }

            set
            {
                if (_text != value)
                {
                    _text = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Text"));
                }
            }
        }

        /// <summary>
        /// Gets and sets the heading menu item extra text.
        /// </summary>
        [KiwiPersist]
        [Category("Appearance")]
        [Description("Heading menu item extra text.")]
        [Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [DefaultValue(null)]
        public string ExtraText
        {
            get { return _extraText; }

            set
            {
                if (_extraText != value)
                {
                    _extraText = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("ExtraText"));
                }
            }
        }

        /// <summary>
        /// Gets and sets the heading menu item image.
        /// </summary>
        [KiwiPersist]
        [Category("Appearance")]
        [Description("Heading menu item image.")]
        [Localizable(true)]
        [DefaultValue(null)]
        public Image Image
        {
            get { return _image; }

            set
            {
                if (_image != value)
                {
                    _image = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Image"));
                }
            }
        }

        /// <summary>
        /// Gets and sets the heading image color to make transparent.
        /// </summary>
        [KiwiPersist]
        [Category("Appearance")]
        [Description("Heading image color to make transparent.")]
        [Localizable(true)]
        public Color ImageTransparentColor
        {
            get { return _imageTransparentColor; }

            set
            {
                if (_imageTransparentColor != value)
                {
                    _imageTransparentColor = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("ImageTransparentColor"));
                }
            }
        }

        private bool ShouldSerializeImageTransparentColor()
        {
            return (_imageTransparentColor == null) || !_imageTransparentColor.Equals(Color.Empty);
        }

        /// <summary>
        /// Gets access to the header instance specific appearance values.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining header instance specific appearance values.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteTripleRedirect StateNormal
        {
            get { return _stateNormal; }
        }

        private bool ShouldSerializeStateNormal()
        {
            return !_stateNormal.IsDefault;
        }
        #endregion

        #region Internal
        internal void SetPaletteRedirect(PaletteTripleRedirect redirector)
        {
            _redirectHeading.SetRedirectStates(redirector, redirector);
        }
        #endregion
    }

}
