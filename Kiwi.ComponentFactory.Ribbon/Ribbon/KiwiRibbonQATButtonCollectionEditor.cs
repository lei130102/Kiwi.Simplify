using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Ribbon
{
	internal class KiwiRibbonQATButtonCollectionEditor : CollectionEditor
	{
		/// <summary>
		/// Initialize a new instance of the KiwiRibbonQATButtonCollectionEditor class.
		/// </summary>
		public KiwiRibbonQATButtonCollectionEditor()
			: base(typeof(KiwiRibbonQATButtonCollection))
		{
		}

		/// <summary>
		/// Gets the data types that this collection editor can contain. 
		/// </summary>
		/// <returns>An array of data types that this collection can contain.</returns>
		protected override Type[] CreateNewItemTypes()
		{
			return new Type[] { typeof(KiwiRibbonQATButton) };
		}

		/// <summary>
		/// Sets the specified array as the items of the collection.
		/// </summary>
		/// <param name="editValue">The collection to edit.</param>
		/// <param name="value">An array of objects to set as the collection items.</param>
		/// <returns>The newly created collection object.</returns>
		protected override object SetItems(object editValue, object[] value)
		{
			// Cast the context into the expected control type
			KiwiRibbon ribbon = (KiwiRibbon)Context.Instance;

			// Suspend changes until collection has been updated
			if (ribbon != null)
				ribbon.SuspendLayout();

			// Let base class update the collection
			object ret = base.SetItems(editValue, value);

			if (ribbon != null)
				ribbon.ResumeLayout(true);

			return ret;
		}
	}
}
