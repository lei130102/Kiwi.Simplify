using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
	/// <summary>
	/// Color event data.
	/// </summary>
	public class ColorEventArgs : EventArgs
	{
		#region Instance Fields
		private Color _color;
		#endregion

		#region Identity
		/// <summary>
		/// Initialize a new instance of the ColorEventArgs class.
		/// </summary>
		/// <param name="color">Color associated with the event.</param>
		public ColorEventArgs(Color color)
		{
			_color = color;
		}
		#endregion

		#region Public
		/// <summary>
		/// Gets the color.
		/// </summary>
		public Color Color
		{
			get { return _color; }
		}
		#endregion
	}
}
