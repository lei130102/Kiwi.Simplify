using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Navigator
{
    /// <summary>
    /// Details for an event that provides pages associated with a page dragging event.
	/// </summary>
	public class PageDragEventArgs : EventArgs
    {
        #region Instance Fields
        private Point _screenPoint;
        private KiwiPageCollection _pages;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiPageDragEventArgs class.
        /// </summary>
        /// <param name="screenPoint">Screen point of the mouse.</param>
        /// <param name="pages">Array of event associated pages.</param>
        public PageDragEventArgs(Point screenPoint,
                                 KiwiPage[] pages)
        {
            _screenPoint = screenPoint;
            _pages = new KiwiPageCollection();

            if (pages != null)
                _pages.AddRange(pages);
        }

        /// <summary>
        /// Initialize a new instance of the KiwiPageDragEventArgs class.
        /// </summary>
        /// <param name="screenPoint">Screen point of the mouse.</param>
        /// <param name="pages">Collection of event associated pages.</param>
        public PageDragEventArgs(Point screenPoint,
                                 KiwiPageCollection pages)
        {
            _screenPoint = screenPoint;
            _pages = pages;
        }
        #endregion

        #region ScreenPoint
        /// <summary>
        /// Gets access to the associated screen point.
        /// </summary>
        public Point ScreenPoint
        {
            get { return _screenPoint; }
        }
        #endregion

        #region Pages
        /// <summary>
        /// Gets access to the collection of pages.
        /// </summary>
        public KiwiPageCollection Pages
        {
            get { return _pages; }
        }
        #endregion
    }
}
