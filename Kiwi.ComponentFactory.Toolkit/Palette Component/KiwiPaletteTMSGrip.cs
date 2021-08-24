using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Storage for grip entries of the professional color table.
    /// </summary>
    public class KiwiPaletteTMSGrip : KiwiPaletteTMSBase
    {
        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiPaletteTMSGrip class.
		/// </summary>
        /// <param name="internalKCT">Reference to inherited values.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        internal KiwiPaletteTMSGrip(KiwiInternalKCT internalKCT,
                                       NeedPaintHandler needPaint)
            : base(internalKCT, needPaint)
        {
        }
        #endregion

        #region IsDefault
        /// <summary>
        /// Gets a value indicating if all values are default.
        /// </summary>
        [Browsable(false)]
        public override bool IsDefault
        {
            get
            {
                return (InternalKCT.InternalGripDark == Color.Empty) &&
                       (InternalKCT.InternalGripLight == Color.Empty);
            }
        }
        #endregion

        #region PopulateFromBase
        /// <summary>
        /// Populate values from the base palette.
        /// </summary>
        public void PopulateFromBase()
        {
            GripDark = InternalKCT.GripDark;
            GripLight = InternalKCT.GripLight;
        }
        #endregion

        #region GripDark
        /// <summary>
        /// Gets and sets the color to use for shadow effects on the grip (move handle).
        /// </summary>
        [KiwiPersist(false)]
        [Category("ToolMenuStatus")]
        [Description("Color to use for shadow effects on the grip (move handle).")]
        [KiwiDefaultColorAttribute()]
        public Color GripDark
        {
            get { return InternalKCT.InternalGripDark; }

            set
            {
                InternalKCT.InternalGripDark = value;
                PerformNeedPaint(false);
            }
        }

        /// <summary>
        /// esets the GripDark property to its default value.
        /// </summary>
        public void ResetGripDark()
        {
            GripDark = Color.Empty;
        }
        #endregion

        #region GripLight
        /// <summary>
        /// Gets and sets the color to use for highlight effects on the grip (move handle).
        /// </summary>
        [KiwiPersist(false)]
        [Category("ToolMenuStatus")]
        [Description("Color to use for highlight effects on the grip (move handle).")]
        [KiwiDefaultColorAttribute()]
        public Color GripLight
        {
            get { return InternalKCT.InternalGripLight; }

            set
            {
                InternalKCT.InternalGripLight = value;
                PerformNeedPaint(false);
            }
        }

        /// <summary>
        /// esets the GripLight property to its default value.
        /// </summary>
        public void ResetGripLight()
        {
            GripLight = Color.Empty;
        }
        #endregion
    }
}
