using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Toolkit
{
    internal class ShortTextValue : NullContentValues
    {
        #region Instance Fields
        private string _shortText;
        #endregion

        #region Identity
        /// <summary>
        /// Gets and sets the short text value to use.
        /// </summary>
        public string ShortText
        {
            get { return _shortText; }
            set { _shortText = value; }
        }
        #endregion

        #region IContentValues
        /// <summary>
        /// Gets the content short text.
        /// </summary>
        /// <returns>String value.</returns>
        public override string GetShortText()
        {
            return _shortText;
        }
        #endregion
    }
}
