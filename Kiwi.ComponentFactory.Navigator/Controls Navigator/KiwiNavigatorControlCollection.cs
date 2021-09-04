using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Navigator
{
	/// <summary>
	/// Represents a collection of child controls for the navigator.
	/// </summary>
	public class KiwiNavigatorControlCollection : KiwiControlCollection
	{
		#region Instance Fields
		private KiwiNavigator _owner;
		#endregion

		#region Identity
		/// <summary>
		/// Initialize a new instance of the KiwiNavigatorControlCollection class.
		/// </summary>
		/// <param name="owner">Control containing this collection.</param>
		public KiwiNavigatorControlCollection(KiwiNavigator owner)
			: base(owner)
		{
			Debug.Assert(owner != null);

			// Remember the collection owner
			_owner = owner;
		}
		#endregion

		#region Public Overrides
		/// <summary>
		/// Adds the specified control to the control collection.
		/// </summary>
		/// <param name="value">The KiwiPage to add to the control collection.</param>
		public override void Add(Control value)
		{
			Debug.Assert(value != null);

			// Cast to correct type
			KiwiPage page = (KiwiPage)value;

			// We only allow KiwiPage controls to be added
			if (page == null)
				throw new ArgumentException("Only KiwiPage controls can be added.", "value");

			// Let base class perform actual add
			base.Add(value);
		}
		#endregion
	}
}
