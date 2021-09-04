using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Navigator
{
	/// <summary>
	/// Provide a KiwiPageFlags enumeration with event details.
	/// </summary>
	public class KiwiPageFlagsEventArgs : EventArgs
	{
		#region Instance Fields
		private KiwiPageFlags _flags;
		#endregion

		#region Identity
		/// <summary>
		/// Initialize a new instance of the KiwiPageFlagsEventArgs class.
		/// </summary>
		/// <param name="flags">KiwiPageFlags enumeration.</param>
		public KiwiPageFlagsEventArgs(KiwiPageFlags flags)
		{
			// Remember parameter details
			_flags = flags;
		}
		#endregion

		#region Public
		/// <summary>
		/// Gets the KiwiPageFlags enumeration value.
		/// </summary>
		public KiwiPageFlags Flags
		{
			get { return _flags; }
		}
		#endregion
	}
}
