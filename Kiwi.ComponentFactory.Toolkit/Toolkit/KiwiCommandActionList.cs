using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
    internal class KiwiCommandActionList : DesignerActionList
    {
        #region Instance Fields
        private KiwiCommand _command;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiCommandActionList class.
        /// </summary>
        /// <param name="owner">Designer that owns this action list instance.</param>
        public KiwiCommandActionList(KiwiCommandDesigner owner)
            : base(owner.Component)
        {
            // Remember the panel instance
            _command = owner.Component as KiwiCommand;
        }
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

            // This can be null when deleting a component instance at design time
            if (_command != null)
            {
            }

            return actions;
        }
        #endregion
    }

}
