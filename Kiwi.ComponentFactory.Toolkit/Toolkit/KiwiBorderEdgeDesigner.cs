using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Windows.Forms.Design;

namespace Kiwi.ComponentFactory.Toolkit
{
    internal class KiwiBorderEdgeDesigner : ControlDesigner
    {
        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiBorderEdgeDesigner class.
        /// </summary>
        public KiwiBorderEdgeDesigner()
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

                // Add the button specific list
                actionLists.Add(new KiwiBorderEdgeActionList(this));

                return actionLists;
            }
        }
        #endregion
    }
}
