using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Toolkit
{
    internal class KiwiCheckSetActionList : DesignerActionList
    {
        #region Instance Fields
        private KiwiCheckSet _set;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiCheckSetActionList class.
        /// </summary>
        /// <param name="owner">Designer that owns this action list instance.</param>
        public KiwiCheckSetActionList(KiwiCheckSetDesigner owner)
            : base(owner.Component)
        {
            // Remember the check set component instance
            _set = owner.Component as KiwiCheckSet;
        }
        #endregion

        #region Public
        #endregion

        #region Public Override
        /// <summary>
        /// Returns the collection of DesignerActionItem objects contained in the list.
        /// </summary>
        /// <returns>A DesignerActionItem array that contains the items in this list.</returns>
        public override DesignerActionItemCollection GetSortedActionItems()
        {
            // Create a new collection for holding the single item we want to create
            DesignerActionItemCollection actions = new DesignerActionItemCollection();

            // This can be null when deleting a control instance at design time
            if (_set != null)
            {
                // Add the list of check set specific actions
            }

            return actions;
        }
        #endregion
    }
}
