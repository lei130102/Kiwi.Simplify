using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
	/// <summary>
	/// CollectionEditor used for a KiwiContextMenuItemCollection instance.
	/// </summary>
	public class KiwiContextMenuItemCollectionEditor : CollectionEditor
	{
		/// <summary>
		/// Initialize a new instance of the KiwiContextMenuItemCollectionEditor class.
		/// </summary>
		public KiwiContextMenuItemCollectionEditor()
			: base(typeof(KiwiContextMenuItemCollection))
		{
		}

		/// <summary>
		/// Gets the data types that this collection editor can contain. 
		/// </summary>
		/// <returns>An array of data types that this collection can contain.</returns>
		protected override Type[] CreateNewItemTypes()
		{
			return new Type[] { typeof(KiwiContextMenuItem),
								typeof(KiwiContextMenuSeparator),
								typeof(KiwiContextMenuHeading) };
		}
	}
}
