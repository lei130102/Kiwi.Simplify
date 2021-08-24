using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
	/// <summary>
	/// Details for an cancellable event that provides a Point value.
	/// </summary>
	public class PointEventCancelArgs : CancelEventArgs
	{
		#region Instance Fields
		private Point _point;
		#endregion

		#region Identity
		/// <summary>
		/// Initialize a new instance of the PointEventCancelArgs class.
		/// </summary>
		/// <param name="point">Point associated with event.</param>
		public PointEventCancelArgs(Point point)
		{
			_point = point;
		}
		#endregion

		#region Point
		/// <summary>
		/// Gets and sets the point.
		/// </summary>
		public Point Point
		{
			get { return _point; }
			set { _point = value; }
		}
		#endregion
	}
}
