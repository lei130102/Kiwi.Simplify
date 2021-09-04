using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Event arguments for a DockspaceSeparatorResize event.
	/// </summary>
    public class DockspaceSeparatorResizeEventArgs : DockspaceSeparatorEventArgs
    {
        #region Instance Fields
        private Rectangle _resizeRect;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the DockspaceSeparatorResizeEventArgs class.
        /// </summary>
        /// <param name="separator">Reference to separator control instance.</param>
        /// <param name="element">Reference to dockspace docking element that is managing the separator.</param>
        /// <param name="resizeRect">Initial resizing rectangle.</param>
        public DockspaceSeparatorResizeEventArgs(KiwiSeparator separator,
                                                 KiwiDockingDockspace element,
                                                 Rectangle resizeRect)
            : base(separator, element)
        {
            _resizeRect = resizeRect;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets and sets the rectangle that limits resizing of the dockspace using the separator.
        /// </summary>
        public Rectangle ResizeRect
        {
            get { return _resizeRect; }
            set { _resizeRect = value; }
        }
        #endregion
    }
}
