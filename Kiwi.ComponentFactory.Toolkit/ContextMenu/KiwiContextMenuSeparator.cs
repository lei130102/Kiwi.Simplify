using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Provide a context menu separator.
    /// </summary>
    [ToolboxItem(false)]
    //
    [ToolboxBitmap(typeof(KiwiContextMenuSeparator), "ToolboxBitmaps.KiwiContextMenuSeparator.bmp")]
    [DefaultProperty("Horizontal")]
    [DesignerCategory("code")]
    [DesignTimeVisible(false)]
    public class KiwiContextMenuSeparator : KiwiContextMenuItemBase
    {
        #region Instance Fields
        private bool _horizontal;
        private PaletteDoubleRedirect _stateNormal;
        private PaletteRedirectDouble _redirectSeparator;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiContextMenuSeparator class.
        /// </summary>
        public KiwiContextMenuSeparator()
        {
            // Default fields
            _horizontal = true;

            // Create the redirector that can get values from the kiwi context menu
            _redirectSeparator = new PaletteRedirectDouble();

            // Create the separator storage for overriding specific values
            _stateNormal = new PaletteDoubleRedirect(_redirectSeparator,
                                                     PaletteBackStyle.ContextMenuSeparator,
                                                     PaletteBorderStyle.ContextMenuSeparator);
        }

        /// <summary>
        /// Returns a description of the instance.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return "(Separator)";
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
            if (Horizontal && (parent is KiwiContextMenuItemCollection))
            {
                // Create a stack of horizontal items inside the item
                ViewLayoutDocker docker = new ViewLayoutDocker();

                // Take up same space as the image column, so separator starts close to actual text
                ViewDrawContent imageContent = new ViewDrawContent(provider.ProviderStateCommon.ItemImage.Content, new FixedContentValue(null, null, null, Color.Empty), VisualOrientation.Top);
                ViewDrawMenuImageCanvas imageCanvas = new ViewDrawMenuImageCanvas(provider.ProviderStateCommon.ItemImage.Back, provider.ProviderStateCommon.ItemImage.Border, 0, true);
                imageCanvas.Add(imageContent);
                docker.Add(new ViewLayoutCenter(imageCanvas), ViewDockStyle.Left);
                docker.Add(new ViewLayoutSeparator(1, 0), ViewDockStyle.Left);

                // Gap that matches left padding of text/extra text
                docker.Add(new ViewLayoutMenuSepGap(provider.ProviderStateCommon, standardStyle), ViewDockStyle.Left);

                // Separator Display
                ViewLayoutStack separatorStack = new ViewLayoutStack(false);
                separatorStack.Add(new ViewLayoutSeparator(1, 1));
                separatorStack.Add(new ViewDrawMenuSeparator(this, provider.ProviderStateCommon.Separator));
                separatorStack.Add(new ViewLayoutSeparator(1, 1));
                docker.Add(separatorStack, ViewDockStyle.Fill);

                return docker;
            }
            else
                return new ViewDrawMenuSeparator(this, provider.ProviderStateCommon.Separator);
        }

        /// <summary>
        /// Gets and sets if the separator is a horizontal or vertical break.
        /// </summary>
        [KiwiPersist]
        [Category("Behavior")]
        [Description("Is this a horizontal or vertical break in the menu.")]
        [DefaultValue(true)]
        public bool Horizontal
        {
            get { return _horizontal; }

            set
            {
                if (_horizontal != value)
                {
                    _horizontal = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Horizontal"));
                }
            }
        }

        /// <summary>
        /// Gets access to the separator instance specific appearance values.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining separator instance specific appearance values.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteDoubleRedirect StateNormal
        {
            get { return _stateNormal; }
        }

        private bool ShouldSerializeStateNormal()
        {
            return !_stateNormal.IsDefault;
        }
        #endregion

        #region Internal
        internal void SetPaletteRedirect(PaletteDoubleRedirect redirector)
        {
            _redirectSeparator.SetRedirectStates(redirector, redirector);
        }
        #endregion
    }

}
