﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Navigator
{
    /// <summary>
	/// Details of an event that is fired just before a page is reordered.
	/// </summary>
    public class PageReorderEventArgs : CancelEventArgs
    {
        #region Instance Fields
        private KiwiPage _pageMoving;
        private KiwiPage _pageTarget;
        private bool _movingBefore;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PageReorderEventArgs class.
        /// </summary>
        /// <param name="pageMoving">Reference to page being moved.</param>
        /// <param name="pageTarget">Reference to target paged.</param>
        /// <param name="movingBefore">True if moving page is to be positioned before the target; otherwise after the target.</param>
        public PageReorderEventArgs(KiwiPage pageMoving,
                                    KiwiPage pageTarget,
                                    bool movingBefore)
        {
            _pageMoving = pageMoving;
            _pageTarget = pageTarget;
            _movingBefore = movingBefore;
        }
        #endregion

        #region PageMoving
        /// <summary>
        /// Gets the page that is being moved.
        /// </summary>
        public KiwiPage PageMoving
        {
            get { return _pageMoving; }
        }
        #endregion

        #region PageTarget
        /// <summary>
        /// Gets the page that is the target for the move.
        /// </summary>
        public KiwiPage PageTarget
        {
            get { return _pageTarget; }
        }
        #endregion

        #region MovingBefore
        /// <summary>
        /// Gets a value indicating if the page being moved is to be placed before the target page.
        /// </summary>
        public bool MovingBefore
        {
            get { return _movingBefore; }
        }
        #endregion
    }
}
