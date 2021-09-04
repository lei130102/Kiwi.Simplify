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
    /// Details for an cancellable event that provides a position, offset and control value.
    /// </summary>
    public class DragStartEventCancelArgs : PointEventCancelArgs
    {
        #region Instance Fields
        private Point _offset;
        private Control _c;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the DragStartEventCancelArgs class.
        /// </summary>
        /// <param name="point">Point associated with event.</param>
        /// <param name="offset">Offset associated with event.</param>
        /// <param name="c">Control that is generating the drag start.</param>
        public DragStartEventCancelArgs(Point point, Point offset, Control c)
            : base(point)
        {
            _offset = offset;
            _c = c;
        }
        #endregion

        #region Point
        /// <summary>
        /// Gets and sets the offset.
        /// </summary>
        public Point Offset
        {
            get { return _offset; }
            set { _offset = value; }
        }
        #endregion

        #region Point
        /// <summary>
        /// Gets the control starting the drag.
        /// </summary>
        public Control Control
        {
            get { return _c; }
        }
        #endregion
    }
}
