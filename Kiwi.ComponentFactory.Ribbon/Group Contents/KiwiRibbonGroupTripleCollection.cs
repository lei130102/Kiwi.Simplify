using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Ribbon
{
    /// <summary>
    /// Manage the items that can be added to a ribbon group triple container.
    /// </summary>
    public class KiwiRibbonGroupTripleCollection : TypedRestrictCollection<KiwiRibbonGroupItem>
    {
        #region Static Fields
        private static readonly Type[] _types = new Type[] { typeof(KiwiRibbonGroupButton),
                                                             typeof(KiwiRibbonGroupColorButton),
                                                             typeof(KiwiRibbonGroupCheckBox),
                                                             typeof(KiwiRibbonGroupComboBox),
                                                             typeof(KiwiRibbonGroupCustomControl),
                                                             typeof(KiwiRibbonGroupDateTimePicker),
                                                             typeof(KiwiRibbonGroupDomainUpDown),
                                                             typeof(KiwiRibbonGroupLabel),
                                                             typeof(KiwiRibbonGroupNumericUpDown),
                                                             typeof(KiwiRibbonGroupRadioButton),
                                                             typeof(KiwiRibbonGroupRichTextBox),
                                                             typeof(KiwiRibbonGroupTextBox),
                                                             typeof(KiwiRibbonGroupTrackBar),
                                                             typeof(KiwiRibbonGroupMaskedTextBox)
                                                           };
        #endregion

        #region Restrict
        /// <summary>
        /// Gets an array of types that the collection is restricted to contain.
        /// </summary>
        public override Type[] RestrictTypes
        {
            get { return _types; }
        }
        #endregion

        #region IList
        /// <summary>
        /// Append an item to the collection.
        /// </summary>
        /// <param name="value">Object reference.</param>
        /// <returns>The position into which the new item was inserted.</returns>
        public override int Add(object value)
        {
            // Restrict contents to three items max
            if (Count == 3)
                throw new ArgumentException("Collection can only contain 3 entries.");

            return base.Add(value);
        }

        /// <summary>
        /// Inserts an item to the collection at the specified index.
        /// </summary>
        /// <param name="index">Insert index.</param>
        /// <param name="value">Object reference.</param>
        public override void Insert(int index, object value)
        {
            // Restrict contents to three items max
            if (Count == 3)
                throw new ArgumentException("Collection can only contain 3 entries.");

            base.Insert(index, value);
        }
        #endregion

        #region IList<KiwiRibbonGroupItem>
        /// <summary>
        /// Inserts an item to the collection at the specified index.
        /// </summary>
        /// <param name="index">Insert index.</param>
        /// <param name="item">Item reference.</param>
        public override void Insert(int index, KiwiRibbonGroupItem item)
        {
            // Restrict contents to three items max
            if (Count == 3)
                throw new ArgumentException("Collection can only contain 3 entries.");

            base.Insert(index, item);
        }
        #endregion

        #region ICollection<KiwiRibbonGroupItem>
        /// <summary>
        /// Append an item to the collection.
        /// </summary>
        /// <param name="item">Item reference.</param>
        public override void Add(KiwiRibbonGroupItem item)
        {
            // Restrict contents to three items max
            if (Count == 3)
                throw new ArgumentException("Collection can only contain 3 entries.");

            base.Add(item);
        }
        #endregion
    }
}
