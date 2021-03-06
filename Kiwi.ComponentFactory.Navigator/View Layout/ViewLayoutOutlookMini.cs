using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Navigator
{
    /// <summary>
    /// View element that knows how to enforce the visible state of the stacked items.
    /// </summary>
    internal class ViewLayoutOutlookMini : ViewLayoutDocker
    {
        #region Instance Fields
        private ViewBuilderOutlookBase _viewBuilder;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ViewLayoutOutlookMini class.
        /// </summary>
        /// <param name="viewBuilder">View builder reference.</param>
        public ViewLayoutOutlookMini(ViewBuilderOutlookBase viewBuilder)
        {
            Debug.Assert(viewBuilder != null);
            _viewBuilder = viewBuilder;
        }

        /// <summary>
        /// Obtains the String representation of this instance.
        /// </summary>
        /// <returns>User readable name of the instance.</returns>
        public override string ToString()
        {
            // Return the class name and instance identifier
            return "ViewLayoutOutlookMini:" + Id;
        }
        #endregion

        #region ViewBuilder
        /// <summary>
        /// Gets access to the associated view builder.
        /// </summary>
        public ViewBuilderOutlookBase ViewBuilder
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return _viewBuilder; }
        }
        #endregion

        #region Layout
        /// <summary>
        /// Perform a layout of the elements.
        /// </summary>
        /// <param name="context">Layout context.</param>
        public override void Layout(ViewLayoutContext context)
        {
            // Make all stacking items that should be visible are visible
            ViewBuilder.UnshrinkAppropriatePages();

            // Let base class continue with standard layout
            base.Layout(context);
        }
        #endregion
    }
}
