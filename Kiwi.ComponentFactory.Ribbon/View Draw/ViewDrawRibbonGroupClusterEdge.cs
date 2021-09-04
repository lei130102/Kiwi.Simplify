using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Ribbon
{
    /// <summary>
	/// Draws a border edge but with a lighter inside area.
	/// </summary>
    internal class ViewDrawRibbonGroupClusterEdge : ViewDrawBorderEdge
    {
        #region Instance Fields
        private KiwiRibbon _ribbon;
        private PaletteBorderEdge _palette;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ViewDrawRibbonGroupClusterEdge class.
        /// </summary>
        /// <param name="ribbon">Reference to owning ribbon..</param>
        /// <param name="palette">Palette source for drawing details.</param>
        public ViewDrawRibbonGroupClusterEdge(KiwiRibbon ribbon,
                                              PaletteBorderEdge palette)
            : base(palette, Orientation.Vertical)
        {
            Debug.Assert(ribbon != null);
            Debug.Assert(palette != null);

            _ribbon = ribbon;
            _palette = palette;
        }
        #endregion

        #region Paint
        /// <summary>
        /// Perform rendering before child elements are rendered.
        /// </summary>
        /// <param name="context">Rendering context.</param>
        public override void RenderBefore(RenderContext context)
        {
            // Let base class perform standard drawing first
            base.RenderBefore(context);

            Rectangle drawRect = new Rectangle(ClientLocation.X,
                                               ClientLocation.Y + ClientWidth,
                                               ClientWidth,
                                               ClientHeight - (ClientWidth * 2));

            context.Renderer.RenderRibbon.DrawRibbonClusterEdge(_ribbon.RibbonShape, context, drawRect, _palette, State);
        }
        #endregion
    }
}
