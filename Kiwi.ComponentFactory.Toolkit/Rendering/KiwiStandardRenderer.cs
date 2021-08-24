using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Toolkit
{
    internal class KiwiStandardRenderer : KiwiProfessionalRenderer
    {
        #region Identity
        /// <summary>
        /// Initialise a new instance of the KiwiStandardRenderer class.
        /// </summary>
        /// <param name="kct">Source for text colors.</param>
        public KiwiStandardRenderer(KiwiColorTable kct)
            : base(kct)
        {
        }
        #endregion

        #region OnRenderItemText
        /// <summary>
        /// Raises the RenderItemText event. 
        /// </summary>
        /// <param name="e">A ToolStripItemTextRenderEventArgs that contains the event data.</param>
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            if (e.ToolStrip is MenuStrip)
                e.TextColor = KCT.MenuStripText;
            else if (e.ToolStrip is StatusStrip)
                e.TextColor = KCT.StatusStripText;
            else if ((e.ToolStrip is ContextMenuStrip) ||
                     (e.ToolStrip is ToolStripDropDown))
                e.TextColor = KCT.MenuItemText;
            else if (e.ToolStrip is ToolStrip)
                e.TextColor = KCT.ToolStripText;

            base.OnRenderItemText(e);
        }
        #endregion

        #region OnRenderToolStripBackground
        /// <summary>
        /// Raises the RenderToolStripBackground event. 
        /// </summary>
        /// <param name="e">An ToolStripRenderEventArgs containing the event data.</param>
        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            // Make sure the font is current
            if ((e.ToolStrip is MenuStrip) ||
                (e.ToolStrip is ContextMenuStrip) ||
                (e.ToolStrip is ToolStripDropDown))
            {
                if (e.ToolStrip.Font != KCT.MenuStripFont)
                    e.ToolStrip.Font = KCT.MenuStripFont;
            }
            else if (e.ToolStrip is StatusStrip)
            {
                if (e.ToolStrip.Font != KCT.StatusStripFont)
                    e.ToolStrip.Font = KCT.StatusStripFont;
            }
            else if (e.ToolStrip is ToolStrip)
            {
                if (e.ToolStrip.Font != KCT.ToolStripFont)
                    e.ToolStrip.Font = KCT.ToolStripFont;
            }

            base.OnRenderToolStripBackground(e);
        }
        #endregion
    }
}
