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
	/// Storage for popup page related properties.
	/// </summary>
    public class NavigatorPopupPages : Storage
    {
        #region Static Fields
        private static readonly int _defaultBorder = 3;
        private static readonly int _defaultGap = 3;
        private static readonly PopupPageElement _defaultElement = PopupPageElement.Item;
        private static readonly PopupPagePosition _defaultPosition = PopupPagePosition.ModeAppropriate;
        #endregion

        #region Instance Fields
        private KiwiNavigator _navigator;
        private PopupPageAllow _allowPopupPages;
        private PopupPageElement _element;
        private PopupPagePosition _position;
        private int _border;
        private int _gap;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the NavigatorPopupPage class.
		/// </summary>
        /// <param name="navigator">Reference to owning navigator instance.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public NavigatorPopupPages(KiwiNavigator navigator,
                                  NeedPaintHandler needPaint)
        {
            Debug.Assert(navigator != null);
            Debug.Assert(needPaint != null);

            // Remember back reference
            _navigator = navigator;

            // Store the provided paint notification delegate
            NeedPaint = needPaint;

            // Default values
            _allowPopupPages = PopupPageAllow.OnlyOutlookMiniMode;
            _gap = _defaultGap;
            _border = _defaultGap;
            _element = _defaultElement;
            _position = _defaultPosition;
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
                return ((AllowPopupPages == PopupPageAllow.OnlyOutlookMiniMode) &&
                        (Border == _defaultBorder) &&
                        (Element == _defaultElement) &&
                        (Gap == _defaultGap) &&
                        (Position == _defaultPosition));
            }
        }
        #endregion

        #region AllowPopupPages
        /// <summary>
        /// Gets and sets if popup pages are displayed.
        /// </summary>
        [Category("Visuals")]
        [Description("Determines if popup pages are displayed.")]
        [DefaultValue(typeof(PopupPageAllow), "Only Outlook Mini Mode")]
        public PopupPageAllow AllowPopupPages
        {
            get { return _allowPopupPages; }
            set { _allowPopupPages = value; }
        }
        #endregion

        #region Border
        /// <summary>
        /// Gets and sets the border pixel width around the popup page.
        /// </summary>
        [Category("Visuals")]
        [Description("Pixel border width around the popup page.")]
        [DefaultValue(3)]
        public int Border
        {
            get { return _border; }
            set { _border = value; }
        }
        #endregion

        #region Element
        /// <summary>
        /// Gets and sets the relative element to use when calculating size and position of the popup page.
        /// </summary>
        [Category("Visuals")]
        [Description("The relative element to use when calculating size and position of the popup page.")]
        [DefaultValue(typeof(PopupPageElement), "Item")]
        public PopupPageElement Element
        {
            get { return _element; }
            set { _element = value; }
        }
        #endregion

        #region Gap
        /// <summary>
        /// Gets and sets the pixel gap between the source element and the popup page.
        /// </summary>
        [Category("Visuals")]
        [Description("Pixel gap between the source element and the popup page.")]
        [DefaultValue(3)]
        public int Gap
        {
            get { return _gap; }
            set { _gap = value; }
        }
        #endregion

        #region Position
        /// <summary>
        /// Gets and sets how to calculate the size and position of the popup page relative to element.
        /// </summary>
        [Category("Visuals")]
        [Description("How to calculate the size and position of the popup page.")]
        [DefaultValue(typeof(PopupPagePosition), "ModeAppropriate")]
        public PopupPagePosition Position
        {
            get { return _position; }
            set { _position = value; }
        }
        #endregion
    }
}
