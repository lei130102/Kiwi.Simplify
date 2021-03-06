using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Navigator
{
    /// <summary>
	/// View element that positions the provided page in the requested position.
	/// </summary>
    internal class ViewLayoutPopupPage : ViewLayoutNull
    {
        #region Instance Fields
        private KiwiNavigator _navigator;
        private KiwiPage _page;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ViewLayoutPopupPage class.
        /// </summary>
        /// <param name="navigator">Reference to owning navigator control.</param>
        /// <param name="page">Page to the positioned.</param>
        public ViewLayoutPopupPage(KiwiNavigator navigator,
                                   KiwiPage page)
        {
            Debug.Assert(navigator != null);
            Debug.Assert(page != null);

            _navigator = navigator;
            _page = page;
        }

        /// <summary>
        /// Obtains the String representation of this instance.
        /// </summary>
        /// <returns>User readable name of the instance.</returns>
        public override string ToString()
        {
            // Return the class name and instance identifier
            return "ViewLayoutPopupPage:" + Id;
        }
        #endregion

        #region Layout
        /// <summary>
        /// Discover the preferred size of the element.
        /// </summary>
        /// <param name="context">Layout context.</param>
        public override Size GetPreferredSize(ViewLayoutContext context)
        {
            Debug.Assert(context != null);
            return _page.GetPreferredSize(context.DisplayRectangle.Size);
        }

        /// <summary>
        /// Perform a layout of the elements.
        /// </summary>
        /// <param name="context">Layout context.</param>
        public override void Layout(ViewLayoutContext context)
        {
            Debug.Assert(context != null);

            // We take on all the available display area
            ClientRectangle = context.DisplayRectangle;

            // Are we allowed to layout child controls?
            if (!context.ViewManager.DoNotLayoutControls)
            {
                // Are we allowed to actually layout the pages?
                if (_navigator.InternalCanLayout)
                {
                    // Update position of page if not already in correct position
                    if ((_page.Location != Point.Empty) ||
                        (_page.Width != ClientWidth) ||
                        (_page.Height != ClientHeight))
                    {
                        _page.SetBounds(0, 0, ClientWidth, ClientHeight);
                    }

                    // Update position of child panel if not already in correct position
                    if ((_navigator.ChildPanel.Location != ClientLocation) ||
                        (_navigator.ChildPanel.Width != ClientWidth) ||
                        (_navigator.ChildPanel.Height != ClientHeight))
                    {
                        // Position the child panel for showing page
                        _navigator.ChildPanel.SetBounds(ClientLocation.X,
                                                        ClientLocation.Y,
                                                        ClientWidth,
                                                        ClientHeight);
                    }
                }
            }
        }
        #endregion
    }
}
