using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Kiwi.ComponentFactory.Toolkit
{
    internal class KiwiPanelDesigner : ScrollableControlDesigner
    {
        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiPanelDesigner class.
        /// </summary>
        public KiwiPanelDesigner()
        {
            // The resizing handles around the control need to change depending on the
            // value of the AutoSize and AutoSizeMode properties. When in AutoSize you
            // do not get the resizing handles, otherwise you do.
            AutoResizeHandles = true;
        }
        #endregion

        #region Public Overrides
        /// <summary>
        ///  Gets the design-time action lists supported by the component associated with the designer.
        /// </summary>
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                // Create a collection of action lists
                DesignerActionListCollection actionLists = new DesignerActionListCollection();

                // Add the panel specific list
                actionLists.Add(new KiwiPanelActionList(this));

                return actionLists;
            }
        }
        #endregion

        #region Protected
        /// <summary>
        /// Receives a call when the control that the designer is managing has painted its surface so the designer can paint any additional adornments on top of the control.
        /// </summary>
        /// <param name="pe">A PaintEventArgs the designer can use to draw on the control.</param>
        protected override void OnPaintAdornments(PaintEventArgs pe)
        {
            // Let base class paint first
            base.OnPaintAdornments(pe);

            // Always draw a border around the panel
            DrawBorder(pe.Graphics);
        }
        #endregion

        #region Implementation
        private void DrawBorder(Graphics graphics)
        {
            // Create a pen for drawing
            using (Pen borderPen = new Pen(SystemColors.ControlDarkDark))
            {
                // Always draw the border dashed
                borderPen.DashStyle = DashStyle.Dash;

                // Get the client rectangle
                Rectangle clientRect = Control.ClientRectangle;

                // Reduce by 1 in width and height
                clientRect.Width--;
                clientRect.Height--;

                // Perform actual draw
                graphics.DrawRectangle(borderPen, clientRect);
            }
        }
        #endregion
    }
}
