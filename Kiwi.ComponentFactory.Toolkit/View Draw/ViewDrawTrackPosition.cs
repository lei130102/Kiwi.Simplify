using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Draw the track for the track bar.
    /// </summary>
    public class ViewDrawTrackPosition : ViewLeaf
    {
        #region Instance Fields
        private ViewDrawTrackBar _drawTrackBar;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ViewDrawTrackPosition class.
		/// </summary>
        /// <param name="drawTrackBar">Reference to owning track bar.</param>
        public ViewDrawTrackPosition(ViewDrawTrackBar drawTrackBar)
        {
            _drawTrackBar = drawTrackBar;
        }

        /// <summary>
        /// Obtains the String representation of this instance.
        /// </summary>
        /// <returns>User readable name of the instance.</returns>
        public override string ToString()
        {
            // Return the class name and instance identifier
            return "ViewDrawTrackPosition:" + Id;
        }
        #endregion

        #region Layout
        /// <summary>
        /// Discover the preferred size of the element.
        /// </summary>
        /// <param name="context">Layout context.</param>
        public override Size GetPreferredSize(ViewLayoutContext context)
        {
            Debug.Assert(context != null);
            return _drawTrackBar.PositionSize;
        }

        /// <summary>
        /// Perform a layout of the elements.
        /// </summary>
        /// <param name="context">Layout context.</param>
        public override void Layout(ViewLayoutContext context)
        {
            Debug.Assert(context != null);

            // Validate incoming reference
            if (context == null) throw new ArgumentNullException("context");

            // We take on all the available display area
            ClientRectangle = context.DisplayRectangle;
        }
        #endregion

        #region Paint
        /// <summary>
        /// Perform rendering before child elements are rendered.
        /// </summary>
        /// <param name="context">Rendering context.</param>
        public override void RenderBefore(RenderContext context)
        {
            IPaletteElementColor elementColors = null;

            switch (State)
            {
                default:
                case PaletteState.Normal:
                    elementColors = _drawTrackBar.StateNormal.Position;
                    break;
                case PaletteState.Disabled:
                    elementColors = _drawTrackBar.StateDisabled.Position;
                    break;
                case PaletteState.Tracking:
                    elementColors = _drawTrackBar.StateTracking.Position;
                    break;
                case PaletteState.Pressed:
                    elementColors = _drawTrackBar.StatePressed.Position;
                    break;
            }

            context.Renderer.RenderGlyph.DrawTrackPositionGlyph(context, State, elementColors, ClientRectangle,
                                                                _drawTrackBar.Orientation,
                                                                _drawTrackBar.TickStyle);
        }
        #endregion
    }
}
