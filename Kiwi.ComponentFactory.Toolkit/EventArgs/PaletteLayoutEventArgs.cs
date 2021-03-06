using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Details for palette layout events.
    /// </summary>
    public class PaletteLayoutEventArgs : NeedLayoutEventArgs
    {
        #region Instance Fields
        private bool _needColorTable;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PaletteLayoutEventArgs class.
        /// </summary>
        /// <param name="needLayout">Does the layout need regenerating.</param>
        /// <param name="needColorTable">Have the color table values changed?</param>
        public PaletteLayoutEventArgs(bool needLayout, bool needColorTable)
            : base(needLayout)
        {
            _needColorTable = needColorTable;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets a value indicating if the color table needs to be reprocessed.
        /// </summary>
        public bool NeedColorTable
        {
            get { return _needColorTable; }
        }
        #endregion
    }
}
