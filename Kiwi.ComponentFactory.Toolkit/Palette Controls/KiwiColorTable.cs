using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Extend the ProfessionalColorTable with some Kiwi specific properties.
    /// </summary>
    public class KiwiColorTable : ProfessionalColorTable
    {
        #region Instance Fields
        private IPalette _palette;
        #endregion

        #region Identity
        /// <summary>
        /// Creates a new instance of the KiwiColorTable class.
        /// </summary>
        /// <param name="palette">Reference to associated palette.</param>
        public KiwiColorTable(IPalette palette)
        {
            _palette = palette;
        }
        #endregion

        #region Palette
        /// <summary>
        /// Gets the associated palette instance.
        /// </summary>
        public IPalette Palette
        {
            get { return _palette; }
        }
        #endregion

        #region RoundedEdges
        /// <summary>
        /// Gets a value indicating if rounded egdes are required.
        /// </summary>
        public virtual InheritBool UseRoundedEdges
        {
            get { return InheritBool.True; }
        }
        #endregion

        #region MenuItemText
        /// <summary>
        /// Gets the text color used on the menu items.
        /// </summary>
        public virtual Color MenuItemText
        {
            get { return SystemColors.MenuText; }
        }
        #endregion

        #region MenuStripText
        /// <summary>
        /// Gets the text color used on the menu strip.
        /// </summary>
        public virtual Color MenuStripText
        {
            get { return SystemColors.MenuText; }
        }
        #endregion

        #region ToolStripText
        /// <summary>
        /// Gets the text color used on the tool strip.
        /// </summary>
        public virtual Color ToolStripText
        {
            get { return SystemColors.MenuText; }
        }
        #endregion

        #region StatusStripText
        /// <summary>
        /// Gets the text color used on the status strip.
        /// </summary>
        public virtual Color StatusStripText
        {
            get { return SystemColors.MenuText; }
        }
        #endregion

        #region MenuStripFont
        /// <summary>
        /// Gets the font used on the menu strip.
        /// </summary>
        public virtual Font MenuStripFont
        {
            get { return SystemInformation.MenuFont; }
        }
        #endregion

        #region ToolStripFont
        /// <summary>
        /// Gets the font used on the tool strip.
        /// </summary>
        public virtual Font ToolStripFont
        {
            get { return SystemInformation.MenuFont; }
        }
        #endregion

        #region StatusStripFont
        /// <summary>
        /// Gets the font used on the status strip.
        /// </summary>
        public virtual Font StatusStripFont
        {
            get { return SystemInformation.MenuFont; }
        }
        #endregion
    }

}
