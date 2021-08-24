﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
	/// <summary>
	/// Details for a tooltip related event.
	/// </summary>
	public class ToolTipEventArgs : EventArgs
	{
		#region Instance Fields
		private ViewBase _target;
		private Point _screenPt;
		#endregion

		#region Identity
		/// <summary>
		/// Initialize a new instance of the ButtonSpecEventArgs class.
		/// </summary>
		/// <param name="target">Reference to view element that requires tooltip.</param>
		/// <param name="screenPt">Screen location of mouse when tooltip was required.</param>
		public ToolTipEventArgs(ViewBase target, Point screenPt)
		{
			Debug.Assert(target != null);

			// Remember parameter details
			_target = target;
			_screenPt = screenPt;
		}
		#endregion

		#region Public
		/// <summary>
		/// Gets the view element that is related to the tooltip.
		/// </summary>
		public ViewBase Target
		{
			get { return _target; }
		}

		/// <summary>
		/// Gets the screen point of the mouse where tooltip is required.
		/// </summary>
		public Point ScreenPt
		{
			get { return _screenPt; }
		}
		#endregion
	}
}
