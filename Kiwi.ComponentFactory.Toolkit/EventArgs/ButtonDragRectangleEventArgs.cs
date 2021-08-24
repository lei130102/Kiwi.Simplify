using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Details for an event that discovers the rectangle that the mouse has to leave to begin dragging.
    /// </summary>
    public class ButtonDragRectangleEventArgs : EventArgs
    {
        #region Instance Fields
        private Point _point;
        private Rectangle _dragRect;
        private bool _preDragOffset;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ButtonDragRectangleEventArgs class.
        /// </summary>
        /// <param name="point">Left mouse down point.</param>
        public ButtonDragRectangleEventArgs(Point point)
        {
            _point = point;
            _dragRect = new Rectangle(_point, Size.Empty);
            _dragRect.Inflate(SystemInformation.DragSize);
            _preDragOffset = true;
        }
        #endregion

        #region Point
        /// <summary>
        /// Gets access to the left mouse down point.
        /// </summary>
        public Point Point
        {
            get { return _point; }
        }
        #endregion

        #region DragRect
        /// <summary>
        /// Gets access to the drag rectangle area.
        /// </summary>
        public Rectangle DragRect
        {
            get { return _dragRect; }
            set { _dragRect = value; }
        }
        #endregion

        #region PreDragOffset
        /// <summary>
        /// Gets and sets the need for pre drag offset events.
        /// </summary>
        public bool PreDragOffset
        {
            get { return _preDragOffset; }
            set { _preDragOffset = value; }
        }
        #endregion
    }
}
