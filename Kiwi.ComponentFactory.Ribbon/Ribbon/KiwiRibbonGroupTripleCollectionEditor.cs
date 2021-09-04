using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Ribbon
{
    internal class KiwiRibbonGroupTripleCollectionEditor : CollectionEditor
    {
        /// <summary>
        /// Initialize a new instance of the KiwiRibbonGroupTripleCollectionEditor class.
        /// </summary>
        public KiwiRibbonGroupTripleCollectionEditor()
            : base(typeof(KiwiRibbonGroupTripleCollection))
        {
        }

        /// <summary>
        /// Gets the data types that this collection editor can contain. 
        /// </summary>
        /// <returns>An array of data types that this collection can contain.</returns>
        protected override Type[] CreateNewItemTypes()
        {
            return new Type[] { typeof(KiwiRibbonGroupButton),
                                typeof(KiwiRibbonGroupColorButton),
                                typeof(KiwiRibbonGroupCheckBox),
                                typeof(KiwiRibbonGroupComboBox),
                                typeof(KiwiRibbonGroupCustomControl),
                                typeof(KiwiRibbonGroupDateTimePicker),
                                typeof(KiwiRibbonGroupLabel),
                                typeof(KiwiRibbonGroupRadioButton),
                                typeof(KiwiRibbonGroupRichTextBox),
                                typeof(KiwiRibbonGroupTextBox),
                                typeof(KiwiRibbonGroupMaskedTextBox)};
        }
    }
}
