using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Contains a global identifier that is unique among objects.
    /// </summary>
    public class GlobalId
    {
        #region Instance Fields
        private int _id;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the GlobalId class.
        /// </summary>
        [System.Diagnostics.DebuggerStepThrough]
        public GlobalId()
        {
            // Assign the next global identifier
            _id = CommonHelper.NextId;
        }
        #endregion

        #region Id
        /// <summary>
        /// Gets the unique identifier of the object.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Id
        {
            get { return _id; }
        }
        #endregion
    }

}
