using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Navigator
{
	/// <summary>
	/// Details for a direction button (next/previous) action event.
	/// </summary>
	public class DirectionActionEventArgs : KiwiPageEventArgs
	{
		#region Instance Fields
		private DirectionButtonAction _action;
		#endregion

		#region Identity
		/// <summary>
		/// Initialize a new instance of the DirectionActionEventArgs class.
		/// </summary>
		/// <param name="page">Page effected by event.</param>
		/// <param name="index">Index of page in the owning collection.</param>
		/// <param name="action">Previous/Next action to take.</param>
		public DirectionActionEventArgs(KiwiPage page,
										int index,
										DirectionButtonAction action)
			: base(page, index)
		{
			_action = action;
		}
		#endregion

		#region Action
		/// <summary>
		/// Gets and sets the next/previous action to take.
		/// </summary>
		public DirectionButtonAction Action
		{
			get { return _action; }
			set { _action = value; }
		}
		#endregion
	}
}
