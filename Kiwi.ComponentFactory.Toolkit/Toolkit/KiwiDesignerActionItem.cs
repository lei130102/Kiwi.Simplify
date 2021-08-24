using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Action item that presents as a method call but calls a property.
    /// </summary>
    public class KiwiDesignerActionItem : DesignerActionMethodItem
    {
        #region Instance Fields
        private DesignerVerb _verb;
        private string _category;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KrpytonDesignerActionVerbItem class.
        /// </summary>
        /// <param name="verb">Verb instance to wrap.</param>
        /// <param name="category">Name of the category the action belongs to.</param>
        public KiwiDesignerActionItem(DesignerVerb verb, string category)
            : base(null, null, null)
        {
            Debug.Assert(verb != null);
            Debug.Assert(category != null);

            // Validate parameters
            if (verb == null) throw new ArgumentNullException("verb");
            if (category == null) throw new ArgumentNullException("category");

            // Remember details
            _verb = verb;
            _category = category;
        }
        #endregion

        #region Public Overrides
        /// <summary>
        ///  Programmatically executes the method associated with the item.
        /// </summary>
        public override void Invoke()
        {
            _verb.Invoke();
        }

        /// <summary>
        /// Gets the group name for an item.
        /// </summary>
        public override string Category
        {
            get { return _category; }
        }

        /// <summary>
        /// Gets the supplemental text for the item.
        /// </summary>
        public override string Description
        {
            get { return _verb.Description; }
        }

        /// <summary>
        /// Gets the text for this item.
        /// </summary>
        public override string DisplayName
        {
            get { return _verb.Text; }
        }

        /// <summary>
        /// Gets a value that indicates the item should appear in other user interface contexts.
        /// </summary>
        public override bool IncludeAsDesignerVerb
        {
            get { return false; }
        }

        /// <summary>
        /// Gets the name of the method that this item is associated with.
        /// </summary>
        public override string MemberName
        {
            get { return null; }
        }
        #endregion
    }
}
