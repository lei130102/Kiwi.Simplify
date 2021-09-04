using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Ribbon
{
    /// <summary>
    /// Represents the base class for all ribbon group containers.
    /// </summary>
    [ToolboxItem(false)]
    [DesignerCategory("code")]
    [DesignTimeVisible(false)]
    public abstract class KiwiRibbonGroupContainer : KiwiRibbonGroupItem,
                                                        IRibbonGroupContainer
    {
        #region Instance Fields
        private KiwiRibbonGroup _ribbonGroup;
        #endregion

        #region Identity
        /// <summary>
        /// Initialise a new instance of the KiwiRibbonGroupContainer class.
        /// </summary>
        public KiwiRibbonGroupContainer()
        {
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets access to the parent group instance.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual KiwiRibbonGroup RibbonGroup
        {
            get { return _ribbonGroup; }
            set { _ribbonGroup = value; }
        }

        /// <summary>
        /// Gets an array of all the contained components.
        /// </summary>
        /// <returns>Array of child components.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual Component[] GetChildComponents()
        {
            return new Component[] { };
        }
        #endregion
    }
}
