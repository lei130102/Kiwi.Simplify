using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Navigator
{
	/// <summary>
	/// Details for a close button action event.
	/// </summary>
	public class CloseActionEventArgs : KiwiPageEventArgs
	{
		#region Instance Fields
		private CloseButtonAction _action;
		#endregion

		#region Identity
		/// <summary>
		/// Initialize a new instance of the CloseActionEventArgs class.
		/// </summary>
		/// <param name="page">Page effected by event.</param>
		/// <param name="index">Index of page in the owning collection.</param>
		/// <param name="action">Close action to take.</param>
		public CloseActionEventArgs(KiwiPage page,
									int index,
									CloseButtonAction action)
			: base(page, index)
		{
			_action = action;
		}
		#endregion

		#region Action
		/// <summary>
		/// Gets and sets the close action to take.
		/// </summary>
		public CloseButtonAction Action
		{
			get { return _action; }
			set { _action = value; }
		}
		#endregion
	}
}
