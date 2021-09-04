using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
	/// Details for context menu related events.
	/// </summary>
	public class ViewControlHitTestArgs : CancelEventArgs
    {
        #region Instance Fields
        private Point _pt;
        private IntPtr _result;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ViewControlHitTestArgs class.
        /// </summary>
        /// <param name="pt">Point associated with hit test message.</param>
        public ViewControlHitTestArgs(Point pt)
            : base(true)
        {
            _pt = pt;
            _result = IntPtr.Zero;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets access to the point.
        /// </summary>
        public Point Point
        {
            get { return _pt; }
        }

        /// <summary>
        /// Gets and sets the result.
        /// </summary>
        public IntPtr Result
        {
            get { return _result; }
            set { _result = value; }
        }
        #endregion
    }
}
