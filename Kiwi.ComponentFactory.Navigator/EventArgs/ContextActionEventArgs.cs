using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Navigator
{
	/// <summary>
	/// Details for a context button action event.
	/// </summary>
	public class ContextActionEventArgs : KiwiContextMenuEventArgs
	{
		#region Instance Fields
		private ContextButtonAction _action;
		#endregion

		#region Identity
		/// <summary>
		/// Initialize a new instance of the ContextActionEventArgs class.
		/// </summary>
		/// <param name="page">Page effected by event.</param>
		/// <param name="index">Index of page in the owning collection.</param>
		/// <param name="action">Close action to take.</param>
		/// <param name="contextMenu">Prepopulated context menu ready for display.</param>
		public ContextActionEventArgs(KiwiPage page,
									  int index,
									  ContextButtonAction action,
									  KiwiContextMenu contextMenu)
			: base(page, index, contextMenu)
		{
			_action = action;
		}
		#endregion

		#region Action
		/// <summary>
		/// Gets and sets the close action to take.
		/// </summary>
		public ContextButtonAction Action
		{
			get { return _action; }
			set { _action = value; }
		}
		#endregion
	}
}
