using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Toolkit
{
	/// <summary>
	/// Details for close reason event handlers.
	/// </summary>
	public class CloseReasonEventArgs : CancelEventArgs
	{
		#region Instance Fields
		private ToolStripDropDownCloseReason _closeReason;
		#endregion

		#region Identity
		/// <summary>
		/// Initialize a new instance of the CloseReasonEventArgs class.
		/// </summary>
		/// <param name="closeReason">Reason for the close action occuring.</param>
		public CloseReasonEventArgs(ToolStripDropDownCloseReason closeReason)
		{
			_closeReason = closeReason;
		}
		#endregion

		#region Public
		/// <summary>
		/// Gets access to the reason for the context menu closing.
		/// </summary>
		public ToolStripDropDownCloseReason CloseReason
		{
			get { return _closeReason; }
		}
		#endregion
	}

}
