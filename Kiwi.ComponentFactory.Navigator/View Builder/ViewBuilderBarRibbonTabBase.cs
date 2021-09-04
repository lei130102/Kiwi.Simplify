﻿using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Navigator
{
    /// <summary>
    /// Base class for implementation of 'Bar - RibbonTab' modes.
	/// </summary>
    internal abstract class ViewBuilderBarRibbonTabBase : ViewBuilderBarItemBase
    {
        #region Protected
        /// <summary>
        /// Create a new check item with initial settings.
        /// </summary>
        /// <param name="page">Page for which the check button is to be created.</param>
        /// <param name="orientation">Initial orientation of the check button.</param>
        protected override INavCheckItem CreateCheckItem(KiwiPage page,
                                                         VisualOrientation orientation)
        {
            // Create a check button view element
            ViewDrawNavRibbonTab ribbonTab = new ViewDrawNavRibbonTab(Navigator, page);

            // Convert the button orientation to the appropriate visual orientations
            VisualOrientation orientBackBorder = ConvertButtonBorderBackOrientation();
            VisualOrientation orientContent = ConvertButtonContentOrientation();

            // Set the correct initial orientation of the button
            ribbonTab.SetOrientation(orientBackBorder, orientContent);

            return ribbonTab;
        }

        /// <summary>
        /// Gets the visual orientation of the check buttton.
        /// </summary>
        /// <returns>Visual orientation.</returns>
        protected override VisualOrientation ConvertButtonBorderBackOrientation()
        {
            switch (Navigator.Bar.BarOrientation)
            {
                case VisualOrientation.Top:
                    return VisualOrientation.Top;
                case VisualOrientation.Bottom:
                    return VisualOrientation.Bottom;
                case VisualOrientation.Left:
                    if (CommonHelper.GetRightToLeftLayout(Navigator) &&
                        (Navigator.RightToLeft == RightToLeft.Yes))
                        return VisualOrientation.Right;
                    else
                        return VisualOrientation.Left;
                case VisualOrientation.Right:
                    if (CommonHelper.GetRightToLeftLayout(Navigator) &&
                        (Navigator.RightToLeft == RightToLeft.Yes))
                        return VisualOrientation.Left;
                    else
                        return VisualOrientation.Right;
                default:
                    // Should never happen!
                    Debug.Assert(false);
                    return VisualOrientation.Top;
            }
        }

        /// <summary>
        /// Gets the visual orientation of the check butttons content.
        /// </summary>
        /// <returns>Visual orientation.</returns>
        protected override VisualOrientation ConvertButtonContentOrientation()
        {
            return ResolveButtonContentOrientation(Navigator.Bar.BarOrientation);
        }
        #endregion
    }
}
