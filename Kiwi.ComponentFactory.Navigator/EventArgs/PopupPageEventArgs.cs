using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Navigator
{
	/// <summary>
	/// Details for a popup page event.
	/// </summary>
	public class PopupPageEventArgs : KiwiPageCancelEventArgs
	{
		#region Instance Fields
		private Rectangle _screenRect;
		#endregion

		#region Identity
		/// <summary>
		/// Initialize a new instance of the PopupPageEventArgs class.
		/// </summary>
		/// <param name="page">Page effected by event.</param>
		/// <param name="index">Index of page in the owning collection.</param>
		/// <param name="screenRect">Screen rectangle for showing the popup.</param>
		public PopupPageEventArgs(KiwiPage page,
								  int index,
								  Rectangle screenRect)
			: base(page, index)
		{
			_screenRect = screenRect;
		}
		#endregion

		#region ScreenRect
		/// <summary>
		/// Gets and sets the screen rectangle for showing the popup page.
		/// </summary>
		public Rectangle ScreenRect
		{
			get { return _screenRect; }
			set { _screenRect = value; }
		}
		#endregion
	}
}
