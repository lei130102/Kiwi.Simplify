using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
	/// <summary>
	/// Details for an event that provides a Point value.
	/// </summary>
	public class PointEventArgs : EventArgs
	{
		#region Instance Fields
		private Point _point;
		#endregion

		#region Identity
		/// <summary>
		/// Initialize a new instance of the PointEventArgs class.
		/// </summary>
		/// <param name="point">Point associated with event.</param>
		public PointEventArgs(Point point)
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
