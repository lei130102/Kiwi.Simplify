using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Navigator
{
	/// <summary>
	/// Details for control tabbing events.
	/// </summary>
	public class CtrlTabCancelEventArgs : CancelEventArgs
	{
		#region Instance Fields
		private bool _forward;
		#endregion

		#region Identity
		/// <summary>
		/// Initialize a new instance of the CtrlTabCancelEventArgs class.
		/// </summary>
		/// <param name="forward">Tabbing in forward or backwards direction.</param>
		public CtrlTabCancelEventArgs(bool forward)
		{
			_forward = forward;
		}
		#endregion

		#region Forward
		/// <summary>
		/// Gets a value indicating if control tabbing forward.
		/// </summary>
		public bool Forward
		{
			get { return _forward; }
		}
		#endregion
	}
}
