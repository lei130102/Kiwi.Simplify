using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Docking
{
    internal class ObscureControl : Control
    {
        #region Protected
        /// <summary>
        /// Raises the PaintBackground event.
        /// </summary>
        /// <param name="e">An PaintEventArgs containing the event data.</param>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // We do nothing, so the area underneath shows through
        }

        /// <summary>
        /// Raises the Paint event.
        /// </summary>
        /// <param name="e">An PaintEventArgs containing the event data.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            // We do nothing, so the area underneath shows through
        }
        #endregion
    }
}
