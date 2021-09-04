using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Navigator
{
    /// <summary>
	/// Storage for outlook mini mode related properties.
	/// </summary>
    public class NavigatorOutlookMini : Storage
    {
        #region Instance Fields
        private KiwiNavigator _navigator;
        private ButtonStyle _miniButtonStyle;
        private MapKiwiPageText _miniMapText;
        private MapKiwiPageText _miniMapExtraText;
        private MapKiwiPageImage _miniMapImage;
        private MapKiwiPageText _stackMapText;
        private MapKiwiPageText _stackMapExtraText;
        private MapKiwiPageImage _stackMapImage;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the NavigatorOutlookMini class.
		/// </summary>
        /// <param name="navigator">Reference to owning navigator instance.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public NavigatorOutlookMini(KiwiNavigator navigator,
                                    NeedPaintHandler needPaint)
        {
            Debug.Assert(navigator != null);

            // Remember back reference
            _navigator = navigator;

            // Store the provided paint notification delegate
            NeedPaint = needPaint;

            // Default values
            _miniButtonStyle = ButtonStyle.NavigatorMini;
            _miniMapImage = MapKiwiPageImage.None;
            _miniMapText = MapKiwiPageText.TextTitle;
            _miniMapExtraText = MapKiwiPageText.None;
            _stackMapImage = MapKiwiPageImage.MediumSmall;
            _stackMapText = MapKiwiPageText.None;
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
                return ((MiniButtonStyle == ButtonStyle.NavigatorMini) &&
                        (MiniMapImage == MapKiwiPageImage.None) &&
                        (MiniMapText == MapKiwiPageText.TextTitle) &&
                        (MiniMapExtraText == MapKiwiPageText.None) &&
                        (StackMapImage == MapKiwiPageImage.MediumSmall) &&
                        (StackMapText == MapKiwiPageText.None) &&
                        (StackMapExtraText == MapKiwiPageText.None));

            }
        }
        #endregion

        #region MiniButtonStyle
        /// <summary>
        /// Gets and sets the mini button style.
        /// </summary>
        [Category("Visuals")]
        [Description("Mini button style.")]
        [DefaultValue(typeof(ButtonStyle), "NavigatorMini")]
        public ButtonStyle MiniButtonStyle
        {
            get { return _miniButtonStyle; }

            set
            {
                if (_miniButtonStyle != value)
                {
                    _miniButtonStyle = value;
                    _navigator.OnViewBuilderPropertyChanged("MiniButtonStyleOutlook");
                }
            }
        }
        #endregion

        #region MiniMapImage
        /// <summary>
        /// Gets and sets the mapping used for the mini button item image.
        /// </summary>
        [Localizable(true)]
        [Category("Visuals")]
        [Description("Mapping used for the mini button item image.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        [DefaultValue(typeof(MapKiwiPageImage), "None (Null image)")]
        public virtual MapKiwiPageImage MiniMapImage
        {
            get { return _miniMapImage; }

            set
            {
                if (_miniMapImage != value)
                {
                    _miniMapImage = value;
                    PerformNeedPaint(true);
                }
            }
        }

        /// <summary>
        /// Resets the MiniMapImage property to its default value.
        /// </summary>
        public void ResetMiniMapImage()
        {
            MiniMapImage = MapKiwiPageImage.None;
        }
        #endregion

        #region MiniMapText
        /// <summary>
        /// Gets and sets the mapping used for the mini button item text.
        /// </summary>
        [Category("Visuals")]
        [Description("Mapping used for the mini button item text.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        [DefaultValue(typeof(MapKiwiPageText), "Text - Title")]
        public MapKiwiPageText MiniMapText
        {
            get { return _miniMapText; }

            set
            {
                if (_miniMapText != value)
                {
                    _miniMapText = value;
                    PerformNeedPaint(true);
                }
            }
        }

        /// <summary>
        /// Resets the MiniMapText property to its default value.
        /// </summary>
        public void ResetMiniMapText()
        {
            MiniMapText = MapKiwiPageText.TextTitle;
        }
        #endregion

        #region MiniMapExtraText
        /// <summary>
        /// Gets and sets the mapping used for the mini button item description.
        /// </summary>
        [Category("Visuals")]
        [Description("Mapping used for the mini button item description.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        [DefaultValue(typeof(MapKiwiPageText), "None (Empty string)")]
        public MapKiwiPageText MiniMapExtraText
        {
            get { return _miniMapExtraText; }

            set
            {
                if (_miniMapExtraText != value)
                {
                    _miniMapExtraText = value;
                    PerformNeedPaint(true);
                }
            }
        }

        /// <summary>
        /// Resets the MiniMapExtraText property to its default value.
        /// </summary>
        public void ResetMiniMapExtraText()
        {
            MiniMapExtraText = MapKiwiPageText.None;
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
        [DefaultValue(typeof(MapKiwiPageImage), "MediumSmall")]
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
            StackMapImage = MapKiwiPageImage.MediumSmall;
        }
        #endregion

        #region StackMapText
        /// <summary>
        /// Gets and sets the mapping used for the stack item text.
        /// </summary>
        [Category("Visuals")]
        [Description("Mapping used for the stack item text.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        [DefaultValue(typeof(MapKiwiPageText), "None (Empty string)")]
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
            StackMapText = MapKiwiPageText.None;
        }
        #endregion

        #region StackMapExtraText
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
