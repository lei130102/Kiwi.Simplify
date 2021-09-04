using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Navigator
{
	internal class NavigatorPageCollectionEditor : CollectionEditor
	{
		/// <summary>
		/// Initialize a new instance of the NavigatorPageCollectionEditor class.
		/// </summary>
		public NavigatorPageCollectionEditor()
			: base(typeof(KiwiPageCollection))
		{
		}

		/// <summary>
		/// Gets the data types that this collection editor can contain. 
		/// </summary>
		/// <returns>An array of data types that this collection can contain.</returns>
		protected override Type[] CreateNewItemTypes()
		{
			return new Type[] { typeof(KiwiPage) };
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
			KiwiNavigator navigator = (KiwiNavigator)Context.Instance;

			// Suspend changes until collection has been updated
			if (navigator != null)
				navigator.SuspendLayout();

			// Let base class update the collection
			object ret = base.SetItems(editValue, value);

			if (navigator != null)
				navigator.ResumeLayout(true);

			return ret;
		}
	}
}
