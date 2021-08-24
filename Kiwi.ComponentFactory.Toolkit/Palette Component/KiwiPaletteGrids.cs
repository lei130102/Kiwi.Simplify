﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Storage for grids palette settings.
    /// </summary>
    public class KiwiPaletteGrids : Storage
    {
        #region Instance Fields
        private KiwiPaletteGrid _gridCommon;
        private KiwiPaletteGrid _gridList;
        private KiwiPaletteGrid _gridSheet;
        private KiwiPaletteGrid _gridCustom1;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiPaletteGrids class.
        /// </summary>
        /// <param name="redirector">Palette redirector for sourcing inherited values.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        internal KiwiPaletteGrids(PaletteRedirect redirector,
                                     NeedPaintHandler needPaint)
        {
            Debug.Assert(redirector != null);

            _gridCommon = new KiwiPaletteGrid(redirector, GridStyle.List, needPaint);
            _gridList = new KiwiPaletteGrid(redirector, GridStyle.List, needPaint);
            _gridSheet = new KiwiPaletteGrid(redirector, GridStyle.Sheet, needPaint);
            _gridCustom1 = new KiwiPaletteGrid(redirector, GridStyle.Custom1, needPaint);

            // Create redirectors for inheriting from style specific to style common
            PaletteRedirectGrids redirectCommon = new PaletteRedirectGrids(redirector, _gridCommon);

            // Ensure the specific styles inherit to the common grid style
            _gridList.SetRedirector(redirectCommon);
            _gridSheet.SetRedirector(redirectCommon);
            _gridCustom1.SetRedirector(redirectCommon);
        }
        #endregion

        #region IsDefault
        /// <summary>
        /// Gets a value indicating if all values are default.
        /// </summary>
        public override bool IsDefault
        {
            get
            {
                return _gridCommon.IsDefault &&
                       _gridList.IsDefault &&
                       _gridSheet.IsDefault &&
                       _gridCustom1.IsDefault;
            }
        }
        #endregion

        #region PopulateFromBase
        /// <summary>
        /// Populate values from the base palette.
        /// </summary>
        /// <param name="common">Reference to common settings.</param>
        public void PopulateFromBase(KiwiPaletteCommon common)
        {
            // Populate only the designated styles
            _gridList.PopulateFromBase(common, GridStyle.List);
            _gridSheet.PopulateFromBase(common, GridStyle.Sheet);
        }
        #endregion

        #region GridCommon
        /// <summary>
        /// Gets access to the common grid appearance entries.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining common grid appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteGrid GridCommon
        {
            get { return _gridCommon; }
        }

        private bool ShouldSerializeGridCommon()
        {
            return !_gridCommon.IsDefault;
        }
        #endregion

        #region GridList
        /// <summary>
        /// Gets access to the list grid appearance entries.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining list grid appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteGrid GridList
        {
            get { return _gridList; }
        }

        private bool ShouldSerializeGridList()
        {
            return !_gridList.IsDefault;
        }
        #endregion

        #region GridSheet
        /// <summary>
        /// Gets access to the sheet grid appearance entries.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining sheet grid appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteGrid GridSheet
        {
            get { return _gridSheet; }
        }

        private bool ShouldSerializeGridSheet()
        {
            return !_gridSheet.IsDefault;
        }
        #endregion

        #region GridCustom1
        /// <summary>
        /// Gets access to the first custom grid appearance entries.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining the first custom grid appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KiwiPaletteGrid GridCustom1
        {
            get { return _gridCustom1; }
        }

        private bool ShouldSerializeGridCustom1()
        {
            return !_gridCustom1.IsDefault;
        }
        #endregion
    }
}
