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
	/// Storage for outlook full mode related properties.
	/// </summary>
    public class NavigatorOutlookFull : Storage
    {
        #region Instance Fields
        private KiwiNavigator _navigator;
        private MapKiwiPageText _overflowMapText;
        private MapKiwiPageText _overflowMapExtraText;
        private MapKiwiPageImage _overflowMapImage;
        private MapKiwiPageText _stackMapText;
        private MapKiwiPageText _stackMapExtraText;
        private MapKiwiPageImage _stackMapImage;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the NavigatorOutlookFull class.
		/// </summary>
        /// <param name="navigator">Reference to owning navigator instance.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public NavigatorOutlookFull(KiwiNavigator navigator,
                                    NeedPaintHandler needPaint)
        {
            Debug.Assert(navigator != null);

            // Remember back reference
            _navigator = navigator;

            // Store the provided paint notification delegate
            NeedPaint = needPaint;

            // Default values
            _overflowMapImage = MapKiwiPageImage.Small;
            _overflowMapText = MapKiwiPageText.None;
            _overflowMapExtraText = MapKiwiPageText.None;
            _stackMapImage = MapKiwiPageImage.MediumSmall;
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
                return ((OverflowMapImage == MapKiwiPageImage.Small) &&
                        (OverflowMapText == MapKiwiPageText.None) &&
                        (OverflowMapExtraText == MapKiwiPageText.None) &&
                        (StackMapImage == MapKiwiPageImage.MediumSmall) &&
                        (StackMapText == MapKiwiPageText.TextTitle) &&
                        (StackMapExtraText == MapKiwiPageText.None));

            }
        }
        #endregion

        #region OverflowMapImage
        /// <summary>
        /// Gets and sets the mapping used for the overflow item image.
        /// </summary>
        [Localizable(true)]
        [Category("Visuals")]
        [Description("Mapping used for the overflow item image.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        [DefaultValue(typeof(MapKiwiPageImage), "Small")]
        public virtual MapKiwiPageImage OverflowMapImage
        {
            get { return _overflowMapImage; }

            set
            {
                if (_overflowMapImage != value)
                {
                    _overflowMapImage = value;
                    PerformNeedPaint(true);
                }
            }
        }

        /// <summary>
        /// Resets the OverflowMapImage property to its default value.
        /// </summary>
        public void ResetOverflowMapImage()
        {
            OverflowMapImage = MapKiwiPageImage.Small;
        }
        #endregion

        #region OverflowMapText
        /// <summary>
        /// Gets and sets the mapping used for the overflow item text.
        /// </summary>
        [Category("Visuals")]
        [Description("Mapping used for the overflow item text.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        [DefaultValue(typeof(MapKiwiPageText), "None (Empty string)")]
        public MapKiwiPageText OverflowMapText
        {
            get { return _overflowMapText; }

            set
            {
                if (_overflowMapText != value)
                {
                    _overflowMapText = value;
                    PerformNeedPaint(true);
                }
            }
        }

        /// <summary>
        /// Resets the OverflowMapText property to its default value.
        /// </summary>
        public void ResetOverflowMapText()
        {
            OverflowMapText = MapKiwiPageText.None;
        }
        #endregion

        #region OverflowMapExtraText
        /// <summary>
        /// Gets and sets the mapping used for the overflow item description.
        /// </summary>
        [Category("Visuals")]
        [Description("Mapping used for the overflow item description.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        [DefaultValue(typeof(MapKiwiPageText), "None (Empty string)")]
        public MapKiwiPageText OverflowMapExtraText
        {
            get { return _overflowMapExtraText; }

            set
            {
                if (_overflowMapExtraText != value)
                {
                    _overflowMapExtraText = value;
                    PerformNeedPaint(true);
                }
            }
        }

        /// <summary>
        /// Resets the OverflowMapExtraText property to its default value.
        /// </summary>
        public void ResetOverflowMapExtraText()
        {
            OverflowMapExtraText = MapKiwiPageText.None;
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
