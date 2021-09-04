using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Extends the KiwiWorkspace to work within the docking edge of a control.
    /// </summary>
    [ToolboxItem(false)]
    [DesignerCategory("code")]
    [DesignTimeVisible(false)]
    public class KiwiDockspace : KiwiSpace
    {
        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiDockspace class.
        /// </summary>
        public KiwiDockspace()
            : base("Docked")
        {
            // Define a sensible default minimum size
            MinimumSize = new Size(22, 22);
        }

        /// <summary>
        /// Gets a string representation of the class.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "KiwiDockspace " + Dock.ToString();
        }
        #endregion
    }
}
