using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Ribbon
{
	internal class KiwiRibbonGroupContainerCollectionEditor : CollectionEditor
	{
		/// <summary>
		/// Initialize a new instance of the KiwiRibbonGroupTopCollectionEditor class.
		/// </summary>
		public KiwiRibbonGroupContainerCollectionEditor()
			: base(typeof(KiwiRibbonGroupContainerCollection))
		{
		}

		/// <summary>
		/// Gets the data types that this collection editor can contain. 
		/// </summary>
		/// <returns>An array of data types that this collection can contain.</returns>
		protected override Type[] CreateNewItemTypes()
		{
			return new Type[] { typeof(KiwiRibbonGroupLines),
								typeof(KiwiRibbonGroupTriple),
								typeof(KiwiRibbonGroupSeparator) };
		}
	}
}
