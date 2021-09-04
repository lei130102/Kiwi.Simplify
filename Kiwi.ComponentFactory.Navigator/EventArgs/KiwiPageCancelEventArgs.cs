using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Navigator
{
	/// <summary>
	/// Details for page related events that can be cancelled.
	/// </summary>
	public class KiwiPageCancelEventArgs : KiwiPageEventArgs
	{
		#region Instance Fields
		private bool _cancel;
		#endregion

		#region Identity
		/// <summary>
		/// Initialize a new instance of the KiwiCancelPageEventArgs class.
		/// </summary>
		/// <param name="page">Page effected by event.</param>
		/// <param name="index">Index of page in the owning collection.</param>
		public KiwiPageCancelEventArgs(KiwiPage page, int index)
			: base(page, index)
		{
		}
		#endregion

		#region Cancel
		/// <summary>
		/// Gets the page associated with the event.
		/// </summary>
		public bool Cancel
		{
			get { return _cancel; }
			set { _cancel = value; }
		}
		#endregion
	}
}
