using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
	/// Details about the context menu that has been closed up on a KiwiDateTimePicker.
	/// </summary>
	public class DateTimePickerCloseArgs : EventArgs
    {
        #region Instance Fields
        private KiwiContextMenu _kcm;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the DateTimePickerCloseArgs class.
        /// </summary>
        /// <param name="kcm">KiwiContextMenu that can be examined.</param>
        public DateTimePickerCloseArgs(KiwiContextMenu kcm)
        {
            _kcm = kcm;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets access to the KiwiContextMenu instance.
        /// </summary>
        public KiwiContextMenu KiwiContextMenu
        {
            get { return _kcm; }
        }
        #endregion
    }
}
