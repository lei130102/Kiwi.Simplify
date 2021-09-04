using Kiwi.ComponentFactory.Navigator;
using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Event arguments for a AutoHiddenSeparatorResize event.
	/// </summary>
    public class AutoHiddenSeparatorResizeEventArgs : EventArgs
    {
        #region Instance Fields
        private KiwiSeparator _separator;
        private KiwiDockspace _dockspace;
        private KiwiPage _page;
        private Rectangle _resizeRect;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the AutoHiddenSeparatorResizeEventArgs class.
        /// </summary>
        /// <param name="separator">Reference to separator control instance.</param>
        /// <param name="dockspace">Reference to dockspace control instance.</param>
        /// <param name="page">Reference to page contained in the dockspace.</param>
        /// <param name="resizeRect">Initial resizing rectangle.</param>
        public AutoHiddenSeparatorResizeEventArgs(KiwiSeparator separator,
                                                  KiwiDockspace dockspace,
                                                  KiwiPage page,
                                                  Rectangle resizeRect)
        {
            _separator = separator;
            _dockspace = dockspace;
            _page = page;
            _resizeRect = resizeRect;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets a reference to the KiwiSeparator control.
        /// </summary>
        public KiwiSeparator SeparatorControl
        {
            get { return _separator; }
        }

        /// <summary>
        /// Gets a reference to the KiwiDockspace control.
        /// </summary>
        public KiwiDockspace DockspaceControl
        {
            get { return _dockspace; }
        }

        /// <summary>
        /// Gets a reference to the KiwiPage instance.
        /// </summary>
        public KiwiPage Page
        {
            get { return _page; }
        }

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
