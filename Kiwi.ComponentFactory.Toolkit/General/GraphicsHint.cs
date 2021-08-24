using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
	/// <summary>
	/// Apply a requested smoothing mode to a graphics instance.
	/// </summary>
	public class GraphicsHint : GlobalId,
								IDisposable
	{
		#region Instance Fields
		private Graphics _graphics;
		private SmoothingMode _smoothingMode;
		#endregion

		#region Identity
		/// <summary>
		/// Initialize a new instance of the GraphicsHint class.
		/// </summary>
		/// <param name="graphics">Graphics context.</param>
		/// <param name="hint">Temporary hint mode to apply.</param>
		public GraphicsHint(Graphics graphics, PaletteGraphicsHint hint)
		{
			// Cache graphics instance
			_graphics = graphics;

			// Remember current smoothing mode
			_smoothingMode = _graphics.SmoothingMode;

			// Apply new hint
			switch (hint)
			{
				case PaletteGraphicsHint.None:
					_graphics.SmoothingMode = SmoothingMode.None;
					break;
				case PaletteGraphicsHint.AntiAlias:
					_graphics.SmoothingMode = SmoothingMode.AntiAlias;
					break;
				default:
					// Should never happen!
					Debug.Assert(false);
					break;
			}
		}

		/// <summary>
		/// Reverse the smoothing mode change.
		/// </summary>
		public void Dispose()
		{
			if (_graphics != null)
			{
				try
				{
					// Put back to the original smoothing mode
					_graphics.SmoothingMode = _smoothingMode;
				}
				catch { }
			}
		}
		#endregion
	}
}
