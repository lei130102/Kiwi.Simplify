using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Ribbon
{
    /// <summary>
	/// Extends the ViewLayoutDocker by drawing the ribbon application button recent docs background.
	/// </summary>
    internal class ViewDrawRibbonAppMenuDocs : ViewLayoutDocker
    {
        #region Instance Fields
        private KiwiRibbon _ribbon;
        private IDisposable _memento;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ViewDrawRibbonAppMenuDocs class.
        /// </summary>
        /// <param name="ribbon">Reference to owning ribbon instance.</param>
        public ViewDrawRibbonAppMenuDocs(KiwiRibbon ribbon)
        {
            _ribbon = ribbon;
        }

        /// <summary>
        /// Obtains the String representation of this instance.
        /// </summary>
        /// <returns>User readable name of the instance.</returns>
        public override string ToString()
        {
            // Return the class name and instance identifier
            return "ViewDrawRibbonAppMenuRecentDocs:" + Id;
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_memento != null)
                {
                    _memento.Dispose();
                    _memento = null;
                }
            }

            base.Dispose(disposing);
        }
        #endregion

        #region Paint
        /// <summary>
        /// Perform rendering before child elements are rendered.
        /// </summary>
        /// <param name="context">Rendering context.</param>
        public override void RenderBefore(RenderContext context)
        {
            // Draw the application menu outer background
            _memento = context.Renderer.RenderRibbon.DrawRibbonBack(_ribbon.RibbonShape, context, ClientRectangle, State,
                                                                    _ribbon.StateCommon.RibbonAppMenuDocs,
                                                                    VisualOrientation.Top, false, _memento);

        }
        #endregion
    }
}
