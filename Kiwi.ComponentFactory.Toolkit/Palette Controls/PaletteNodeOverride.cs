using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
	/// Allow some palette values to be overriden.
	/// </summary>
    public class PaletteNodeOverride : GlobalId,
                                       IPaletteTriple
    {
        #region Intance Fields
        private PaletteBackInheritNode _overrideBack;
        private PaletteBorderInheritOverride _overrideBorder;
        private PaletteContentInheritNode _overrideContent;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PaletteNodeOverride class.
        /// </summary>
        /// <param name="triple">Palette to use.</param>
        public PaletteNodeOverride(IPaletteTriple triple)
        {
            Debug.Assert(triple != null);

            // Validate incoming references
            if (triple == null) throw new ArgumentNullException("triple");

            // Create the triple override instances
            _overrideBack = new PaletteBackInheritNode(triple.PaletteBack);
            _overrideBorder = new PaletteBorderInheritOverride(triple.PaletteBorder, triple.PaletteBorder);
            _overrideContent = new PaletteContentInheritNode(triple.PaletteContent);
        }
        #endregion

        #region TreeNode
        /// <summary>
        /// Set the tree node to use for sourcing values.
        /// </summary>
        public TreeNode TreeNode
        {
            set
            {
                _overrideBack.TreeNode = value;
                _overrideContent.TreeNode = value;
            }
        }
        #endregion

        #region Palette Accessors
        /// <summary>
		/// Gets the background palette.
		/// </summary>
		public IPaletteBack PaletteBack
        {
            get { return _overrideBack; }
        }

        /// <summary>
        /// Gets the border palette.
        /// </summary>
        public IPaletteBorder PaletteBorder
        {
            get { return _overrideBorder; }
        }

        /// <summary>
        /// Gets the border palette.
        /// </summary>
        public IPaletteContent PaletteContent
        {
            get { return _overrideContent; }
        }
        #endregion
    }
}
