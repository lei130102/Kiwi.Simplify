using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
	/// Provides a movement rectangle that will be used to limit separator movement.
	/// </summary>
	public class SplitterMoveRectMenuArgs : EventArgs
    {
        #region Instance Fields
        private Rectangle _moveRect;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the SplitterMoveRectMenuArgs class.
        /// </summary>
        /// <param name="moveRect">Initial movement rectangle that limits separator movements.</param>
        public SplitterMoveRectMenuArgs(Rectangle moveRect)
        {
            _moveRect = moveRect;
        }
        #endregion

        #region Public
        /// <summary>
		/// Gets and sets the movement box for a separator.
		/// </summary>
        public Rectangle MoveRect
        {
            get { return _moveRect; }
            set { _moveRect = value; }
        }
        #endregion
    }
}
