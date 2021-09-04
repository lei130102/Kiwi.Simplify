using Kiwi.ComponentFactory.Navigator;
using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Extends the KiwiNavigator to work within the docking framework.
    /// </summary>
    [ToolboxBitmap(typeof(KiwiDockableNavigator), "ToolboxBitmaps.KiwiDockableNavigator.bmp")]
    public class KiwiDockableNavigator : KiwiNavigator
    {
        #region Events
        /// <summary>
        /// Occurs when a page is being inserted into the navigator.
        /// </summary>
        [Category("DockableNavigator")]
        [Description("Occurs when a page is added to a workspace cell.")]
        public event EventHandler<KiwiPageEventArgs> CellPageInserting;

        /// <summary>
        /// Occurs when a page requests that a drop down menu be shown.
        /// </summary>
        [Category("DockableNavigator")]
        [Description("Occurs when a page requests that a drop down menu be shown.")]
        public event EventHandler<CancelDropDownEventArgs> PageDropDownClicked;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiDockableNavigator class.
        /// </summary>
        public KiwiDockableNavigator()
        {
            // Hook into cell specific events
            ShowContextMenu += new EventHandler<ShowContextMenuArgs>(OnShowContextMenu);
            Pages.Inserting += new TypedHandler<KiwiPage>(OnPagesInserting);
        }
        #endregion

        #region Protected
        /// <summary>
        /// Raises the CellPageInserting event.
        /// </summary>
        /// <param name="e">An KiwiPageEventArgs containing the event data.</param>
        protected virtual void OnCellPageInserting(KiwiPageEventArgs e)
        {
            if (CellPageInserting != null)
                CellPageInserting(this, e);
        }

        /// <summary>
        /// Raises the PageDropDownClicked event.
        /// </summary>
        /// <param name="e">An CancelDropDownEventArgs containing the event data.</param>
        protected virtual void OnPageDropDownClicked(CancelDropDownEventArgs e)
        {
            if (PageDropDownClicked != null)
                PageDropDownClicked(this, e);
        }
        #endregion

        #region Private
        private void OnPagesInserting(object sender, TypedCollectionEventArgs<KiwiPage> e)
        {
            // Generate event so the docking element can decide on extra actions to be taken
            OnCellPageInserting(new KiwiPageEventArgs(e.Item, e.Index));
        }

        private void OnShowContextMenu(object sender, ShowContextMenuArgs e)
        {
            // Make sure we have a menu for displaying
            if (e.KiwiContextMenu == null)
                e.KiwiContextMenu = new KiwiContextMenu();

            // Use event to allow customization of the context menu
            CancelDropDownEventArgs args = new CancelDropDownEventArgs(e.KiwiContextMenu, e.Item);
            args.Cancel = e.Cancel;
            OnPageDropDownClicked(args);
            e.Cancel = args.Cancel;
        }
        #endregion
    }
}
