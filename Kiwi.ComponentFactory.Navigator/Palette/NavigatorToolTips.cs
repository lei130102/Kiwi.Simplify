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
	/// Storage for tooltip related properties.
	/// </summary>
    public class NavigatorToolTips : Storage
    {
        #region Instance Fields
        private KiwiNavigator _navigator;
        private bool _allowPageToolTips;
        private bool _allowButtonSpecToolTips;
        private MapKiwiPageText _mapText;
        private MapKiwiPageText _mapExtraText;
        private MapKiwiPageImage _mapImage;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the NavigatorPopupPage class.
		/// </summary>
        /// <param name="navigator">Reference to owning navigator instance.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public NavigatorToolTips(KiwiNavigator navigator,
                                NeedPaintHandler needPaint)
        {
            Debug.Assert(navigator != null);
            Debug.Assert(needPaint != null);

            // Remember back reference
            _navigator = navigator;

            // Store the provided paint notification delegate
            NeedPaint = needPaint;

            // Default values
            _allowPageToolTips = false;
            _allowButtonSpecToolTips = false;
            _mapImage = MapKiwiPageImage.ToolTip;
            _mapText = MapKiwiPageText.ToolTipTitle;
            _mapExtraText = MapKiwiPageText.ToolTipBody;
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
                return (!AllowPageToolTips &&
                        !AllowButtonSpecToolTips &&
                        (MapImage == MapKiwiPageImage.ToolTip) &&
                        (MapText == MapKiwiPageText.ToolTipTitle) &&
                        (MapExtraText == MapKiwiPageText.ToolTipBody));
            }
        }
        #endregion

        #region AllowPageToolTips
        /// <summary>
        /// Gets and sets a value indicating if tooltips should be displayed for page headers.
        /// </summary>
        [Category("Visuals")]
        [Description("Should tooltips be displayed for page headers.")]
        [DefaultValue(false)]
        public bool AllowPageToolTips
        {
            get { return _allowPageToolTips; }
            set { _allowPageToolTips = value; }
        }
        #endregion

        #region AllowButtonSpecToolTips
        /// <summary>
        /// Gets and sets a value indicating if tooltips should be displayed for button specs.
        /// </summary>
        [Category("Visuals")]
        [Description("Should tooltips be displayed for button specs.")]
        [DefaultValue(false)]
        public bool AllowButtonSpecToolTips
        {
            get { return _allowButtonSpecToolTips; }
            set { _allowButtonSpecToolTips = value; }
        }
        #endregion

        #region MapImage
        /// <summary>
        /// Gets and sets the mapping used for the tooltip image.
        /// </summary>
        [Localizable(true)]
        [Category("Visuals")]
        [Description("Mapping used for the tooltip image.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        [DefaultValue(typeof(MapKiwiPageImage), "ToolTip")]
        public virtual MapKiwiPageImage MapImage
        {
            get { return _mapImage; }
            set { _mapImage = value; }
        }

        /// <summary>
        /// Resets the MapImage property to its default value.
        /// </summary>
        public void ResetMapImage()
        {
            MapImage = MapKiwiPageImage.ToolTip;
        }
        #endregion

        #region MapText
        /// <summary>
        /// Gets and sets the mapping used for the tooltip text.
        /// </summary>
        [Category("Visuals")]
        [Description("Mapping used for the tooltip text.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        [DefaultValue(typeof(MapKiwiPageText), "ToolTipTitle")]
        public MapKiwiPageText MapText
        {
            get { return _mapText; }
            set { _mapText = value; }
        }

        /// <summary>
        /// Resets the MapText property to its default value.
        /// </summary>
        public void ResetMapText()
        {
            MapText = MapKiwiPageText.ToolTipTitle;
        }
        #endregion

        #region MapExtraText
        /// <summary>
        /// Gets and sets the mapping used for the tooltip description.
        /// </summary>
        [Category("Visuals")]
        [Description("Mapping used for the tooltip description.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        [DefaultValue(typeof(MapKiwiPageText), "ToolTipBody")]
        public MapKiwiPageText MapExtraText
        {
            get { return _mapExtraText; }
            set { _mapExtraText = value; }
        }

        /// <summary>
        /// Resets the MapExtraText property to its default value.
        /// </summary>
        public void ResetMapExtraText()
        {
            MapExtraText = MapKiwiPageText.ToolTipBody;
        }
        #endregion
    }
}
