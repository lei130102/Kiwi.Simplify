using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Ribbon
{
	/// <summary>
	/// Event arguments for the drop down menu of a gallery.
	/// </summary>
	public class GalleryDropMenuEventArgs : CancelEventArgs
	{
		#region Instance Fields
		private KiwiContextMenu _contextMenu;
		#endregion

		#region Identity
		/// <summary>
		/// Initialize a new instance of the GalleryDropMenuEventArgs class.
		/// </summary>
		/// <param name="contextMenu">Context menu.</param>
		public GalleryDropMenuEventArgs(KiwiContextMenu contextMenu)
		{
			_contextMenu = contextMenu;
		}
		#endregion

		#region Public
		/// <summary>
		/// KiwiContextMenu for display.
		/// </summary>
		public KiwiContextMenu KiwiContextMenu
		{
			get { return _contextMenu; }
		}
		#endregion
	}
}
