using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Ribbon
{
    /// <summary>
    /// Manage the items that can be added to a ribbon group lines container.
    /// </summary>
    public class KiwiRibbonGroupLinesCollection : TypedRestrictCollection<KiwiRibbonGroupItem>
    {
        #region Static Fields
        private static readonly Type[] _types = new Type[] { typeof(KiwiRibbonGroupButton),
                                                             typeof(KiwiRibbonGroupColorButton),
                                                             typeof(KiwiRibbonGroupCheckBox),
                                                             typeof(KiwiRibbonGroupComboBox),
                                                             typeof(KiwiRibbonGroupCluster),
                                                             typeof(KiwiRibbonGroupCustomControl),
                                                             typeof(KiwiRibbonGroupDateTimePicker),
                                                             typeof(KiwiRibbonGroupDomainUpDown),
                                                             typeof(KiwiRibbonGroupLabel),
                                                             typeof(KiwiRibbonGroupNumericUpDown),
                                                             typeof(KiwiRibbonGroupRadioButton),
                                                             typeof(KiwiRibbonGroupRichTextBox),
                                                             typeof(KiwiRibbonGroupTextBox),
                                                             typeof(KiwiRibbonGroupTrackBar),
                                                             typeof(KiwiRibbonGroupMaskedTextBox),
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
    }
}
