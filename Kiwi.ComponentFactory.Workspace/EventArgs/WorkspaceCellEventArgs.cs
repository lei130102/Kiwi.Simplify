using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Workspace
{
	/// <summary>
	/// Workspace cell event data.
	/// </summary>
	public class WorkspaceCellEventArgs : EventArgs
	{
		#region Instance Fields
		private KiwiWorkspaceCell _cell;
		#endregion

		#region Identity
		/// <summary>
		/// Initialize a new instance of the WorkspaceCellEventArgs class.
		/// </summary>
		/// <param name="cell">Workspace cell associated with the event.</param>
		public WorkspaceCellEventArgs(KiwiWorkspaceCell cell)
		{
			_cell = cell;
		}
		#endregion

		#region Public
		/// <summary>
		/// Gets the cell reference.
		/// </summary>
		public KiwiWorkspaceCell Cell
		{
			get { return _cell; }
		}
		#endregion
	}
}
