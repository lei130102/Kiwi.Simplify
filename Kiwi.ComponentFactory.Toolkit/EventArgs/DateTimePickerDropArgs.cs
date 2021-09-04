using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
	/// Details about the context menu about to be shown when clicking the drop down button on a KiwiDateTimePicker.
	/// </summary>
	public class DateTimePickerDropArgs : CancelEventArgs
    {
        #region Instance Fields
        private KiwiContextMenu _kcm;
        private KiwiContextMenuPositionH _positionH;
        private KiwiContextMenuPositionV _positionV;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the DateTimePickerDropArgs class.
        /// </summary>
        /// <param name="kcm">KiwiContextMenu that can be customized.</param>
        /// <param name="positionH">Relative horizontal position of the KiwiContextMenu.</param>
        /// <param name="positionV">Relative vertical position of the KiwiContextMenu.</param>
        public DateTimePickerDropArgs(KiwiContextMenu kcm,
                                     KiwiContextMenuPositionH positionH,
                                     KiwiContextMenuPositionV positionV)
        {
            _kcm = kcm;
            _positionH = positionH;
            _positionV = positionV;
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

        /// <summary>
        /// Gets and sets the relative horizontal position of the KiwiContextMenu.
        /// </summary>
        public KiwiContextMenuPositionH PositionH
        {
            get { return _positionH; }
            set { _positionH = value; }
        }

        /// <summary>
        /// Gets and sets the relative vertical position of the KiwiContextMenu.
        /// </summary>
        public KiwiContextMenuPositionV PositionV
        {
            get { return _positionV; }
            set { _positionV = value; }
        }
        #endregion
    }
}
