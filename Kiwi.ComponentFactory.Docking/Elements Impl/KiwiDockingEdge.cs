using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Provides docking functionality for a specific edge of a control.
    /// </summary>
    [ToolboxItem(false)]
    [DesignerCategory("code")]
    [DesignTimeVisible(false)]
    public class KiwiDockingEdge : DockingElementClosedCollection
    {
        #region Instance Fields
        private Control _control;
        private DockingEdge _edge;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiDockingEdge class.
        /// </summary>
        /// <param name="name">Initial name of the element.</param>
        /// <param name="control">Reference to control that is being managed.</param>
        /// <param name="edge">Docking edge being managed.</param>
        public KiwiDockingEdge(string name, Control control, DockingEdge edge)
            : base(name)
        {
            if (control == null)
                throw new ArgumentNullException("control");

            _control = control;
            _edge = edge;

            // Auto create elements for handling standard docked content and auto hidden content
            InternalAdd(new KiwiDockingEdgeAutoHidden("AutoHidden", control, edge));
            InternalAdd(new KiwiDockingEdgeDocked("Docked", control, edge));
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets the control this element is managing.
        /// </summary>
        public Control Control
        {
            get { return _control; }
        }

        /// <summary>
        /// Gets the docking edge this element is managing.
        /// </summary>
        public DockingEdge Edge
        {
            get { return _edge; }
        }
        #endregion

        #region Protected
        /// <summary>
        /// Gets the xml element name to use when saving.
        /// </summary>
        protected override string XmlElementName
        {
            get { return "DE"; }
        }
        #endregion
    }
}
