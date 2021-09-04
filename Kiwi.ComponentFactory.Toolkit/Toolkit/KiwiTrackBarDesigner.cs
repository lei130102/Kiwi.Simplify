﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Kiwi.ComponentFactory.Toolkit
{
    internal class KiwiTrackBarDesigner : ControlDesigner
    {
        #region Instance Fields
        private KiwiTrackBar _trackBar;
        #endregion

        #region Public Overrides
        /// <summary>
        /// Initializes the designer with the specified component.
        /// </summary>
        /// <param name="component">The IComponent to associate the designer with.</param>
        public override void Initialize(IComponent component)
        {
            // Let base class do standard stuff
            base.Initialize(component);
            base.AutoResizeHandles = true;

            // Cast to correct type
            _trackBar = component as KiwiTrackBar;
        }

        /// <summary>
        /// Gets the selection rules that indicate the movement capabilities of a component.
        /// </summary>
        public override SelectionRules SelectionRules
        {
            get
            {
                if (!_trackBar.AutoSize)
                    return SelectionRules.AllSizeable | SelectionRules.Moveable;
                else
                {
                    if (_trackBar.Orientation == Orientation.Horizontal)
                        return SelectionRules.RightSizeable | SelectionRules.LeftSizeable | SelectionRules.Moveable;
                    else
                        return SelectionRules.TopSizeable | SelectionRules.BottomSizeable | SelectionRules.Moveable;
                }
            }
        }

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
                actionLists.Add(new KiwiTrackBarActionList(this));

                return actionLists;
            }
        }
        #endregion
    }
}
