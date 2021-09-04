using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Extends the KiwiSeparator so work between dockspace entries on a control edge.
    /// </summary>
    [ToolboxItem(false)]
    [DesignerCategory("code")]
    [DesignTimeVisible(false)]
    public class KiwiDockspaceSeparator : KiwiSeparator
    {
        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiDockspaceSeparator class.
        /// </summary>
        /// <param name="edge">Docking edge the separator is against.</param>
        /// <param name="opposite">Should the separator be docked against the opposite edge.</param>
        public KiwiDockspaceSeparator(DockingEdge edge, bool opposite)
        {
            // Setup docking specific settings for the separator
            Dock = DockingHelper.DockStyleFromDockEdge(edge, opposite);
            Orientation = DockingHelper.OrientationFromDockEdge(edge);
            SeparatorStyle = SeparatorStyle.LowProfile;
        }

        /// <summary>
        /// Gets a string representation of the class.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "KiwiDockspaceSeparator " + Dock.ToString() + " " + Orientation.ToString();
        }
        #endregion
    }
}
