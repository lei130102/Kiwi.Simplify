using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Navigator
{
    /// <summary>
	/// Handle a button by ensuring that contained button specs are not treated as part of the button itself.
	/// </summary>
    public class PageButtonController : ButtonController
    {
        #region Identity
        /// <summary>
        /// Initialize a new instance of the PageButtonController class.
        /// </summary>
        /// <param name="target">Target for state changes.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public PageButtonController(ViewBase target, NeedPaintHandler needPaint)
            : base(target, needPaint)
        {
        }
        #endregion

        #region Protected
        /// <summary>
        /// Discovers if the provided view is part of the button.
        /// </summary>
        /// <param name="next">View to investigate.</param>
        /// <returns>True is part of button; otherwise false.</returns>
        protected override bool ViewIsPartOfButton(ViewBase next)
        {
            // Do we need to investigate if the 'next' view might be a contained button?
            if ((next != null) && (Target != next))
            {
                // Climb the view chain and stop when we get to the target itself
                while ((next != null) && (next != Target))
                {
                    // Search for a layout docker as that is always the top of any button
                    if (next is ViewLayoutDocker)
                    {
                        // If this is a button then we return 'false' cause the mouse is no longer in the target button
                        ViewLayoutDocker docker = (ViewLayoutDocker)next;
                        if ((docker.Tag != null) && (docker.Tag is ViewDrawButton))
                            return false;
                    }


                    next = next.Parent;
                }
            }

            return base.ViewIsPartOfButton(next);
        }
        #endregion
    }
}
