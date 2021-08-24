using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
	/// <summary>
	/// Details for button specification related events.
	/// </summary>
	public class ButtonSpecEventArgs : EventArgs
	{
		#region Instance Fields
		private ButtonSpec _spec;
		private int _index;
		#endregion

		#region Identity
		/// <summary>
		/// Initialize a new instance of the ButtonSpecEventArgs class.
		/// </summary>
		/// <param name="spec">Button spec effected by event.</param>
		/// <param name="index">Index of page in the owning collection.</param>
		public ButtonSpecEventArgs(ButtonSpec spec, int index)
		{
			Debug.Assert(spec != null);
			Debug.Assert(index >= 0);

			// Remember parameter details
			_spec = spec;
			_index = index;
		}
		#endregion

		#region Public
		/// <summary>
		/// Gets the navigator button spec associated with the event.
		/// </summary>
		public ButtonSpec ButtonSpec
		{
			get { return _spec; }
		}

		/// <summary>
		/// Gets the index of ButtonSpec associated with the event.
		/// </summary>
		public int Index
		{
			get { return _index; }
		}
		#endregion
	}
}
