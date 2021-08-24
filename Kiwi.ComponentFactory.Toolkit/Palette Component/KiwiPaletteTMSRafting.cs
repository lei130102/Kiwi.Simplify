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
    /// Storage for rafting entries of the professional color table.
    /// </summary>
    public class KiwiPaletteTMSRafting : KiwiPaletteTMSBase
    {
        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiPaletteTMSRafting class.
		/// </summary>
        /// <param name="internalKCT">Reference to inherited values.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        internal KiwiPaletteTMSRafting(KiwiInternalKCT internalKCT,
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
                return (InternalKCT.InternalRaftingContainerGradientBegin == Color.Empty) &&
                       (InternalKCT.InternalRaftingContainerGradientEnd == Color.Empty);
            }
        }
        #endregion

        #region PopulateFromBase
        /// <summary>
        /// Populate values from the base palette.
        /// </summary>
        public void PopulateFromBase()
        {
            RaftingContainerGradientBegin = InternalKCT.RaftingContainerGradientBegin;
            RaftingContainerGradientEnd = InternalKCT.RaftingContainerGradientEnd;
        }
        #endregion

        #region RaftingContainerGradientBegin
        /// <summary>
        /// Gets and sets the starting color of the gradient used in the ToolStripContainer.
        /// </summary>
        [KiwiPersist(false)]
        [Category("ToolMenuStatus")]
        [Description("Starting color of the gradient used in the ToolStripContainer.")]
        [KiwiDefaultColorAttribute()]
        public Color RaftingContainerGradientBegin
        {
            get { return InternalKCT.InternalRaftingContainerGradientBegin; }

            set
            {
                InternalKCT.InternalRaftingContainerGradientBegin = value;
                PerformNeedPaint(false);
            }
        }

        /// <summary>
        /// esets the RaftingContainerGradientBegin property to its default value.
        /// </summary>
        public void ResetRaftingContainerGradientBegin()
        {
            RaftingContainerGradientBegin = Color.Empty;
        }
        #endregion

        #region RaftingContainerGradientEnd
        /// <summary>
        /// Gets and sets the ending color of the gradient used in the ToolStripContainer.
        /// </summary>
        [KiwiPersist(false)]
        [Category("ToolMenuStatus")]
        [Description("Ending color of the gradient used in the ToolStripContainer.")]
        [KiwiDefaultColorAttribute()]
        public Color RaftingContainerGradientEnd
        {
            get { return InternalKCT.InternalRaftingContainerGradientEnd; }

            set
            {
                InternalKCT.InternalRaftingContainerGradientEnd = value;
                PerformNeedPaint(false);
            }
        }

        /// <summary>
        /// esets the RaftingContainerGradientEnd property to its default value.
        /// </summary>
        public void ResetRaftingContainerGradientEnd()
        {
            RaftingContainerGradientEnd = Color.Empty;
        }
        #endregion
    }
}
