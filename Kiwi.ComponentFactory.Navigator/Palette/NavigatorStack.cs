using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Navigator
{
    /// <summary>
	/// Storage for stack related properties.
	/// </summary>
    public class NavigatorStack : Storage
    {
        #region Instance Fields
        private KiwiNavigator _navigator;
        private ButtonStyle _checkButtonStyle;
        private PaletteBorderStyle _borderEdgeStyle;
        private bool _stackAnimation;
        private Orientation _stackOrientation;
        private RelativePositionAlign _stackAlignment;
        private ButtonOrientation _itemOrientation;
        private MapKiwiPageText _stackMapText;
        private MapKiwiPageText _stackMapExtraText;
        private MapKiwiPageImage _stackMapImage;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the NavigatorStack class.
		/// </summary>
        /// <param name="navigator">Reference to owning navigator instance.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public NavigatorStack(KiwiNavigator navigator,
                              NeedPaintHandler needPaint)
        {
            Debug.Assert(navigator != null);

            // Remember back reference
            _navigator = navigator;

            // Store the provided paint notification delegate
            NeedPaint = needPaint;

            // Default values
            _checkButtonStyle = ButtonStyle.NavigatorStack;
            _borderEdgeStyle = PaletteBorderStyle.ControlClient;
            _stackAnimation = true;
            _stackOrientation = Orientation.Vertical;
            _stackAlignment = RelativePositionAlign.Center;
            _itemOrientation = ButtonOrientation.Auto;
            _stackMapImage = MapKiwiPageImage.Small;
            _stackMapText = MapKiwiPageText.TextTitle;
            _stackMapExtraText = MapKiwiPageText.None;
        }
        #endregion

        #region IsDefault
        /// <summary>
        /// Gets a value indicating if all values are default.
        /// </summary>
        [Browsable(false)]
        public override bool IsDefault
        {
            get
            {
                return ((CheckButtonStyle == ButtonStyle.NavigatorStack) &&
                        (BorderEdgeStyle == PaletteBorderStyle.ControlClient) &&
                        (StackAnimation == true) &&
                        (StackOrientation == Orientation.Vertical) &&
                        (StackAlignment == RelativePositionAlign.Center) &&
                        (ItemOrientation == ButtonOrientation.Auto) &&
                        (StackMapImage == MapKiwiPageImage.Small) &&
                        (StackMapText == MapKiwiPageText.TextTitle) &&
                        (StackMapExtraText == MapKiwiPageText.None));
            }
        }
        #endregion

        #region CheckButtonStyle
        /// <summary>
        /// Gets and sets the check button style.
        /// </summary>
        [Category("Visuals")]
        [Description("Check button style.")]
        [DefaultValue(typeof(ButtonStyle), "NavigatorStack")]
        public ButtonStyle CheckButtonStyle
        {
            get { return _checkButtonStyle; }

            set
            {
                if (_checkButtonStyle != value)
                {
                    _checkButtonStyle = value;
                    _navigator.OnViewBuilderPropertyChanged("CheckButtonStyleStack");
                }
            }
        }
        #endregion

        #region BorderEdgeStyle
        /// <summary>
        /// Gets and sets the border edge style.
        /// </summary>
        [Category("Visuals")]
        [Description("Check button style.")]
        [DefaultValue(typeof(PaletteBorderStyle), "ControlClient")]
        public PaletteBorderStyle BorderEdgeStyle
        {
            get { return _borderEdgeStyle; }

            set
            {
                if (_borderEdgeStyle != value)
                {
                    _borderEdgeStyle = value;
                    _navigator.OnViewBuilderPropertyChanged("BorderEdgeStyleStack");
                }
            }
        }
        #endregion

        #region StackAnimation
        /// <summary>
        /// Gets and sets if animation should be used on the stack.
        /// </summary>
        [Category("Visuals")]
        [Description("Should animation effects be used on the stack.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        [DefaultValue(true)]
        public bool StackAnimation
        {
            get { return _stackAnimation; }

            set
            {
                if (_stackAnimation != value)
                {
                    _stackAnimation = value;
                    _navigator.OnViewBuilderPropertyChanged("StackAnimation");
                }
            }
        }

        /// <summary>
        /// Resets the StackAnimation property to its default value.
        /// </summary>
        public void ResetStackAnimation()
        {
            StackAnimation = true;
        }
        #endregion

        #region StackOrientation
        /// <summary>
        /// Gets and sets the orientation for positioning stack items.
        /// </summary>
        [Category("Visuals")]
        [Description("Orientation for positioning stack items.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        [DefaultValue(typeof(Orientation), "Vertical")]
        public Orientation StackOrientation
        {
            get { return _stackOrientation; }

            set
            {
                if (_stackOrientation != value)
                {
                    _stackOrientation = value;
                    _navigator.OnViewBuilderPropertyChanged("StackOrientation");
                }
            }
        }

        /// <summary>
        /// Resets the StackOrientation property to its default value.
        /// </summary>
        public void ResetStackOrientation()
        {
            StackOrientation = Orientation.Vertical;
        }
        #endregion

        #region StackAlignment
        /// <summary>
        /// Gets and sets the alignment of the stack relative to the displayed page.
        /// </summary>
        [Category("Visuals")]
        [Description("Alignment of the stack relative to the displayed page.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        [DefaultValue(typeof(RelativePositionAlign), "Center")]
        public RelativePositionAlign StackAlignment
        {
            get { return _stackAlignment; }

            set
            {
                if (_stackAlignment != value)
                {
                    _stackAlignment = value;
                    _navigator.OnViewBuilderPropertyChanged("StackAlignment");
                }
            }
        }

        /// <summary>
        /// Resets the StackAlignment property to its default value.
        /// </summary>
        public void ResetStackAlignment()
        {
            StackAlignment = RelativePositionAlign.Center;
        }
        #endregion

        #region ItemOrientation
        /// <summary>
        /// Gets and sets the orientation for positioning items in the stack.
        /// </summary>
        [Category("Visuals")]
        [Description("Orientation for positioning items in the stack.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        [DefaultValue(typeof(ButtonOrientation), "Auto")]
        public ButtonOrientation ItemOrientation
        {
            get { return _itemOrientation; }

            set
            {
                if (_itemOrientation != value)
                {
                    _itemOrientation = value;
                    _navigator.OnViewBuilderPropertyChanged("ItemOrientationStack");
                }
            }
        }

        /// <summary>
        /// Resets the ItemOrientation property to its default value.
        /// </summary>
        public void ResetItemOrientation()
        {
            ItemOrientation = ButtonOrientation.Auto;
        }
        #endregion

        #region StackMapImage
        /// <summary>
        /// Gets and sets the mapping used for the stack item image.
        /// </summary>
        [Localizable(true)]
        [Category("Visuals")]
        [Description("Mapping used for the stack item image.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        [DefaultValue(typeof(MapKiwiPageImage), "Small")]
        public virtual MapKiwiPageImage StackMapImage
        {
            get { return _stackMapImage; }

            set
            {
                if (_stackMapImage != value)
                {
                    _stackMapImage = value;
                    PerformNeedPaint(true);
                }
            }
        }

        /// <summary>
        /// Resets the StackMapImage property to its default value.
        /// </summary>
        public void ResetStackMapImage()
        {
            StackMapImage = MapKiwiPageImage.Small;
        }
        #endregion

        #region StackMapText
        /// <summary>
        /// Gets and sets the mapping used for the stack item text.
        /// </summary>
        [Category("Visuals")]
        [Description("Mapping used for the stack item text.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        [DefaultValue(typeof(MapKiwiPageText), "Text - Title")]
        public MapKiwiPageText StackMapText
        {
            get { return _stackMapText; }

            set
            {
                if (_stackMapText != value)
                {
                    _stackMapText = value;
                    PerformNeedPaint(true);
                }
            }
        }

        /// <summary>
        /// Resets the StackMapText property to its default value.
        /// </summary>
        public void ResetStackMapText()
        {
            StackMapText = MapKiwiPageText.TextTitle;
        }
        #endregion

        #region MapExtraText
        /// <summary>
        /// Gets and sets the mapping used for the stack item description.
        /// </summary>
        [Category("Visuals")]
        [Description("Mapping used for the stack item description.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        [DefaultValue(typeof(MapKiwiPageText), "None (Empty string)")]
        public MapKiwiPageText StackMapExtraText
        {
            get { return _stackMapExtraText; }

            set
            {
                if (_stackMapExtraText != value)
                {
                    _stackMapExtraText = value;
                    PerformNeedPaint(true);
                }
            }
        }

        /// <summary>
        /// Resets the StackMapExtraText property to its default value.
        /// </summary>
        public void ResetStackMapExtraText()
        {
            StackMapExtraText = MapKiwiPageText.None;
        }
        #endregion
    }
}
