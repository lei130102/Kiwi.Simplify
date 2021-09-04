using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Event arguments for events that need a screen point and element offset.
	/// </summary>
	public class ScreenAndOffsetEventArgs : EventArgs
    {
        #region Instance Fields
        private Point _screenPoint;
        private Point _elementOffset;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ScreenAndOffsetEventArgs class.
        /// </summary>
        /// <param name="screenPoint">Screen point.</param>
        /// <param name="elementOffset">Element offset.</param>
        public ScreenAndOffsetEventArgs(Point screenPoint, Point elementOffset)
        {
            _screenPoint = screenPoint;
            _elementOffset = elementOffset;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets the screen point.
        /// </summary>
        public Point ScreenPoint
        {
            get { return _screenPoint; }
        }

        /// <summary>
        /// Gets the element offset.
        /// </summary>
        public Point ElementOffset
        {
            get { return _elementOffset; }
        }
        #endregion
    }
}
