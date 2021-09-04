using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Helper class used inside a 'using' statement to notify start and end of a multi-part update.
    /// </summary>
    public class DockingMultiUpdate : IDisposable
    {
        #region Instance Fields
        private IDockingElement _dockingElement;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the DockingMultiUpdate class.
        /// </summary>
        /// <param name="dockingElement">Reference to root element of docking hierarchy.</param>
        public DockingMultiUpdate(IDockingElement dockingElement)
        {
            // Must provide a valid docking element reference
            if (dockingElement == null)
                throw new ArgumentNullException("dockingElement");

            // Inform docking elements that a multi-part update is starting
            _dockingElement = dockingElement;
            _dockingElement.PropogateAction(DockingPropogateAction.StartUpdate, (string[])null);
        }

        /// <summary>
        /// Release managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            // Inform docking elements that a multi-part update has ended
            _dockingElement.PropogateAction(DockingPropogateAction.EndUpdate, (string[])null);
        }
        #endregion
    }
}
