using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Extends the ViewDrawDocker by adding status strip merging into the border.
    /// </summary>
    public class ViewDrawForm : ViewDrawDocker
    {
        #region Instance Fields
        private StatusStrip _renderStrip;
        private StatusStrip _statusStrip;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ViewDrawForm class.
        /// </summary>
        /// <param name="paletteBack">Palette source for the background.</param>		
        /// <param name="paletteBorder">Palette source for the border.</param>
        public ViewDrawForm(IPaletteBack paletteBack,
                            IPaletteBorder paletteBorder)
            : base(paletteBack, paletteBorder)
        {
            // Create a status strip we can position for rendering
            _renderStrip = new StatusStrip();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_renderStrip != null)
                {
                    _renderStrip.Dispose();
                    _renderStrip = null;
                }
            }

            base.Dispose(disposing);
        }

        /// <summary>
        /// Obtains the String representation of this instance.
        /// </summary>
        /// <returns>User readable name of the instance.</returns>
        public override string ToString()
        {
            // Return the class name and instance identifier
            return "ViewDrawForm:" + Id;
        }
        #endregion

        #region StatusStrip
        /// <summary>
        /// Gets and sets the status strip to render.
        /// </summary>
        public StatusStrip StatusStrip
        {
            get { return _statusStrip; }
            set { _statusStrip = value; }
        }
        #endregion

        #region Paint
        /// <summary>
		/// Perform rendering after child elements are rendered.
		/// </summary>
		/// <param name="context">Rendering context.</param>
		public override void RenderAfter(RenderContext context)
        {
            // Do we have a status strip to try and merge?
            if (_statusStrip != null)
            {
                // Is the status strip using the global renderer?
                if (_statusStrip.RenderMode == ToolStripRenderMode.ManagerRenderMode)
                {
                    // Cast to correct type
                    KiwiForm form = context.Control as KiwiForm;

                    if (form != null)
                    {
                        // Find the size of the borders around the form
                        Padding borders = form.RealWindowBorders;

                        // Grab the global renderer to use for painting
                        ToolStripRenderer renderer = ToolStripManager.Renderer;

                        // Size the render strip to the apparent size when merged into borders
                        _renderStrip.Width = form.Width;
                        _renderStrip.Height = _statusStrip.Height + borders.Bottom;

                        // Find vertical start of the status strip
                        int y = _statusStrip.Top + borders.Top;

                        try
                        {
                            // We need to transform downwards from drawing at 0,0 to actual required position
                            context.Graphics.TranslateTransform(0, y);

                            // Use the tool strip renderer to draw the correct status strip border/background
                            renderer.DrawToolStripBorder(new ToolStripRenderEventArgs(context.Graphics, _renderStrip));
                            renderer.DrawToolStripBackground(new ToolStripRenderEventArgs(context.Graphics, _renderStrip));
                        }
                        finally
                        {
                            // Make sure that even a crash in the renderer does not prevent the transform reversal
                            context.Graphics.TranslateTransform(0, -y);
                        }
                    }
                }
            }

            // Finally we let the border be drawn
            base.RenderAfter(context);
        }
        #endregion
    }
}
