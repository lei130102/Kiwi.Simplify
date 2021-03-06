using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Ribbon
{
	internal class KiwiRibbonRecentDocCollectionEditor : CollectionEditor
	{
		/// <summary>
		/// Initialize a new instance of the KiwiRibbonRecentDocCollectionEditor class.
		/// </summary>
		public KiwiRibbonRecentDocCollectionEditor()
			: base(typeof(KiwiRibbonRecentDocCollection))
		{
		}

		/// <summary>
		/// Gets the data types that this collection editor can contain. 
		/// </summary>
		/// <returns>An array of data types that this collection can contain.</returns>
		protected override Type[] CreateNewItemTypes()
		{
			return new Type[] { typeof(KiwiRibbonRecentDoc) };
		}
	}
}
