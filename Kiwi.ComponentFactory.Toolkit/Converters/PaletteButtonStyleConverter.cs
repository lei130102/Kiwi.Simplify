﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Custom type converter so that PaletteButtonStyle values appear as neat text at design time.
    /// </summary>
    internal class PaletteButtonStyleConverter : StringLookupConverter
    {
        #region Static Fields
        private Pair[] _pairs = new Pair[] { new Pair(PaletteButtonStyle.Inherit,           "Inherit"),
                                             new Pair(PaletteButtonStyle.Standalone,        "Standalone"),
                                             new Pair(PaletteButtonStyle.Alternate,         "Alternate"),
                                             new Pair(PaletteButtonStyle.LowProfile,        "Low Profile"),
                                             new Pair(PaletteButtonStyle.BreadCrumb,        "BreadCrumb"),
                                             new Pair(PaletteButtonStyle.Cluster,           "Cluster"),
                                             new Pair(PaletteButtonStyle.NavigatorStack,    "Navigator Stack"),
                                             new Pair(PaletteButtonStyle.NavigatorOverflow, "Navigator Overflow"),
                                             new Pair(PaletteButtonStyle.NavigatorMini,     "Navigator Mini"),
                                             new Pair(PaletteButtonStyle.InputControl,      "Input Control"),
                                             new Pair(PaletteButtonStyle.ListItem,          "List Item"),
                                             new Pair(PaletteButtonStyle.Form,              "Form"),
                                             new Pair(PaletteButtonStyle.FormClose,         "Form Close"),
                                             new Pair(PaletteButtonStyle.ButtonSpec,        "ButtonSpec"),
                                             new Pair(PaletteButtonStyle.Command,           "Command"),
                                             new Pair(PaletteButtonStyle.Custom1,           "Custom1"),
                                             new Pair(PaletteButtonStyle.Custom2,           "Custom2"),
                                             new Pair(PaletteButtonStyle.Custom3,           "Custom3") };
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PaletteButtonStyleConverter clas.
        /// </summary>
        public PaletteButtonStyleConverter()
            : base(typeof(PaletteButtonStyle))
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
