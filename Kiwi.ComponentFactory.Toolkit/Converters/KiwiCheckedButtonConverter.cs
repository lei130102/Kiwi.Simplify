using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Toolkit
{
    internal class KiwiCheckedButtonConverter : ReferenceConverter
    {
        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiCheckedButtonConverter class.
        /// </summary>
        public KiwiCheckedButtonConverter()
            : base(typeof(KiwiCheckButton))
        {
        }
        #endregion

        #region Protected Overrides
        /// <summary>
        /// Returns a value indicating whether a particular value can be added to the standard values collection.
        /// </summary>
        /// <param name="context">An ITypeDescriptorContext that provides an additional context.</param>
        /// <param name="value">The value to check.</param>
        /// <returns></returns>
        protected override bool IsValueAllowed(ITypeDescriptorContext context, object value)
        {
            // Get access to the check set component that owns the property
            KiwiCheckSet checkSet = context.Instance as KiwiCheckSet;

            // Just in case the converter is used on a different type of component
            if (checkSet != null)
            {
                // We only allow check buttons inside the check set definition
                return checkSet.CheckButtons.Contains(value as KiwiCheckButton);
            }
            else
                return false;
        }
        #endregion
    }
}
