﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Custom type converter so that PaletteModeManager values appear as neat text at design time.
    /// </summary>
    internal class PaletteModeManagerConverter : StringLookupConverter
    {
        #region Static Fields
        private Pair[] _pairs = new Pair[] { new Pair(PaletteModeManager.ProfessionalSystem,    "Professional - System"),
                                             new Pair(PaletteModeManager.ProfessionalOffice2003,"Professional - Office 2003"),
                                             new Pair(PaletteModeManager.Office2007Blue,        "Office 2007 - Blue"),
                                             new Pair(PaletteModeManager.Office2007Silver,      "Office 2007 - Silver"),
                                             new Pair(PaletteModeManager.Office2007Black,       "Office 2007 - Black"),
                                             new Pair(PaletteModeManager.Office2010Blue,        "Office 2010 - Blue"),
                                             new Pair(PaletteModeManager.Office2010Silver,      "Office 2010 - Silver"),
                                             new Pair(PaletteModeManager.Office2010Black,       "Office 2010 - Black"),
                                             new Pair(PaletteModeManager.SparkleBlue,           "Sparkle - Blue"),
                                             new Pair(PaletteModeManager.SparkleOrange,         "Sparkle - Orange"),
                                             new Pair(PaletteModeManager.SparklePurple,         "Sparkle - Purple")};
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PaletteModeManagerConverter clas.
        /// </summary>
        public PaletteModeManagerConverter()
            : base(typeof(PaletteModeManager))
        {
        }
        #endregion

        #region Protected
        /// <summary>
        /// Gets an array of lookup pairs.
        /// </summary>
        protected override Pair[] Pairs
        {
            get { return _pairs; }
        }
        #endregion
    }

}
