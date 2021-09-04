using Kiwi.ComponentFactory.Navigator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Kiwi.ComponentFactory.Workspace
{
	/// <summary>
	/// Event data for persisting extra data for a workspace cell page.
	/// </summary>
	public class PageLoadingEventArgs : XmlLoadingEventArgs
	{
		#region Instance Fields
		private KiwiPage _page;
		#endregion

		#region Identity
		/// <summary>
		/// Initialize a new instance of the PageLoadingEventArgs class.
		/// </summary>
		/// <param name="workspace">Reference to owning workspace control.</param>
		/// <param name="page">Reference to owning workspace cell page.</param>
		/// <param name="xmlReader">Xml reader for persisting custom data.</param>
		public PageLoadingEventArgs(KiwiWorkspace workspace,
									KiwiPage page,
									XmlReader xmlReader)
			: base(workspace, xmlReader)
		{
			_page = page;
		}
		#endregion

		#region Public
		/// <summary>
		/// Gets the workspace cell page reference.
		/// </summary>
		public KiwiPage Page
		{
			get { return _page; }
			set { _page = value; }
		}
		#endregion
	}
}
