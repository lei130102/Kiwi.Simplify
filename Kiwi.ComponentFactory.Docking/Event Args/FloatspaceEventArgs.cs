using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Event arguments for a FloatspaceAdding/FloatspaceRemoved event.
	/// </summary>
	public class FloatspaceEventArgs : EventArgs
    {
        #region Instance Fields
        private KiwiFloatspace _floatspace;
        private KiwiDockingFloatspace _element;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the FloatspaceEventArgs class.
        /// </summary>
        /// <param name="floatspace">Reference to new floatspace control instance.</param>
        /// <param name="element">Reference to docking floatspace element that is managing the floatspace control.</param>
        public FloatspaceEventArgs(KiwiFloatspace floatspace,
                                   KiwiDockingFloatspace element)
        {
            _floatspace = floatspace;
            _element = element;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets a reference to the KiwiFloatspace control..
        /// </summary>
        public KiwiFloatspace FloatspaceControl
        {
            get { return _floatspace; }
        }

        /// <summary>
        /// Gets a reference to the KiwiDockingFloatspace that is managing the space control.
        /// </summary>
        public KiwiDockingFloatspace FloatspaceElement
        {
            get { return _element; }
        }
        #endregion
    }
}
