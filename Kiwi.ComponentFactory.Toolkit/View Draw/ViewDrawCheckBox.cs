using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Draws a check box using the provided renderer.
    /// </summary>
    public class ViewDrawCheckBox : ViewLeaf
    {
        #region Instance Fields
        private IPalette _palette;
        private CheckState _checkState;
        private bool _tracking;
        private bool _pressed;
        private bool _forceTracking;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ViewDrawCheckBox class.
		/// </summary>
        /// <param name="palette">Palette for source of drawing values.</param>
        public ViewDrawCheckBox(IPalette palette)
        {
            Debug.Assert(palette != null);
            _palette = palette;
        }

        /// <summary>
        /// Obtains the String representation of this instance.
        /// </summary>
        /// <returns>User readable name of the instance.</returns>
        public override string ToString()
        {
            // Return the class name and instance identifier
            return "ViewDrawCheckBox:" + Id;
        }
        #endregion

        #region CheckState
        /// <summary>
        /// Gets and sets the check state of the check box.
        /// </summary>
        public CheckState CheckState
        {
            get { return _checkState; }
            set { _checkState = value; }
        }
        #endregion

        #region Tracking
        /// <summary>
        /// Gets and sets the tracking state of the check box.
        /// </summary>
        public bool Tracking
        {
            get { return (_forceTracking || _tracking); }
            set { _tracking = value; }
        }
        #endregion

        #region ForcedTracking
        /// <summary>
        /// Gets and sets the forced tracking state of the checkbox.
        /// </summary>
        public bool ForcedTracking
        {
            get { return _forceTracking; }
            set { _forceTracking = value; }
        }
        #endregion

        #region Pressed
        /// <summary>
        /// Gets and sets the pressed state of the check box.
        /// </summary>
        public bool Pressed
        {
            get { return _pressed; }
            set { _pressed = value; }
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

            // Ask the renderer for the required size of the check box
            return context.Renderer.RenderGlyph.GetCheckBoxPreferredSize(context, _palette,
                                                                         Enabled, _checkState,
                                                                         Tracking, _pressed);
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
            context.Renderer.RenderGlyph.DrawCheckBox(context, ClientRectangle,
                                                      _palette, Enabled,
                                                      _checkState, Tracking,
                                                      _pressed);
        }
        #endregion
    }
}
