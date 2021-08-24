using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Details for an event that provides a button drag offset value.
    /// </summary>
    public class ButtonDragOffsetEventArgs : EventArgs
    {
        #region Instance Fields
        private Point _offset;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ButtonDragOffsetEventArgs class.
        /// </summary>
        /// <param name="offset">Mouse offset for button dragging.</param>
        public ButtonDragOffsetEventArgs(Point offset)
        {
            _offset = offset;
        }
        #endregion

        #region Point
        /// <summary>
        /// Gets access to the left mouse dragging offer.
        /// </summary>
        public Point PointOffset
        {
            get { return _offset; }
        }
        #endregion
    }
}
