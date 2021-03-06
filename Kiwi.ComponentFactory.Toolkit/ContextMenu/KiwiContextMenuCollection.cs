using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Manage the items that can be added to a top level context menu collection.
    /// </summary>
    [Editor("Kiwi.ComponentFactory.Toolkit.KiwiContextMenuCollectionEditor, Kiwi.ComponentFactory.Toolkit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=360f304a9e10e704", typeof(UITypeEditor))]
    public class KiwiContextMenuCollection : TypedRestrictCollection<KiwiContextMenuItemBase>
    {
        #region Static Fields
        private static readonly Type[] _types = new Type[] { typeof(KiwiContextMenuItems),
                                                             typeof(KiwiContextMenuSeparator),
                                                             typeof(KiwiContextMenuHeading),
                                                             typeof(KiwiContextMenuLinkLabel),
                                                             typeof(KiwiContextMenuCheckBox),
                                                             typeof(KiwiContextMenuCheckButton),
                                                             typeof(KiwiContextMenuRadioButton),
                                                             typeof(KiwiContextMenuColorColumns),
                                                             typeof(KiwiContextMenuMonthCalendar),
                                                             typeof(KiwiContextMenuImageSelect)};
        #endregion

        #region Restrict
        /// <summary>
        /// Gets an array of types that the collection is restricted to contain.
        /// </summary>
        public override Type[] RestrictTypes
        {
            get { return _types; }
        }
        #endregion

        #region ProcessShortcut
        /// <summary>
        /// Test for the provided shortcut and perform relevant action if a match is found.
        /// </summary>
        /// <param name="keyData">Key data to check against shorcut definitions.</param>
        /// <returns>True if shortcut was handled, otherwise false.</returns>
        public bool ProcessShortcut(Keys keyData)
        {
            // Ask each individual item if it has a shortcut to be processed
            foreach (KiwiContextMenuItemBase item in this)
                if (item.ProcessShortcut(keyData))
                    return true;

            return false;
        }
        #endregion

        #region Internal
        /// <summary>
        /// Create view elements appropriate for the collection items.
        /// </summary>
        /// <param name="provider">Context menu information provider.</param>
        /// <param name="parent">Parent object.</param>
        /// <param name="columns">Collection of columns to create view inside.</param>
        /// <param name="standardStyle">Should the standard style be applied.</param>
        /// <param name="imageColumn">Should the imgea column be applied.</param>
        public void GenerateView(IContextMenuProvider provider,
                                 object parent,
                                 ViewLayoutStack columns,
                                 bool standardStyle,
                                 bool imageColumn)
        {
            // Create the initial column
            ViewLayoutStack column = AddColumn(columns);

            // Process each item in the collection in turn
            foreach (KiwiContextMenuItemBase item in this)
            {
                if (item.Visible)
                {
                    // Special handling of separator items
                    if (item is KiwiContextMenuSeparator)
                    {
                        // Cast to correct type
                        KiwiContextMenuSeparator separator = (KiwiContextMenuSeparator)item;

                        // If vertical break....
                        if (!separator.Horizontal)
                        {
                            // Add separator as next column view element
                            provider.ProviderViewColumns.Add(separator.GenerateView(provider, this, columns, standardStyle, imageColumn));

                            // Start new column for subsequent child items
                            column = AddColumn(columns);
                        }
                        else
                        {
                            // Add separator view into the current column
                            column.Add(separator.GenerateView(provider, this, columns, standardStyle, imageColumn));
                        }
                    }
                    else
                    {
                        // All other items we just ask them for the view to add
                        column.Add(item.GenerateView(provider, this, columns, standardStyle, imageColumn));
                    }
                }
            }
        }
        #endregion

        #region Protected
        /// <summary>
        /// Raises the Inserted event.
        /// </summary>
        /// <param name="e">A TypedCollectionEventArgs instance containing event data.</param>
        protected override void OnInserted(TypedCollectionEventArgs<KiwiContextMenuItemBase> e)
        {
            base.OnInserted(e);

            // We monitor changes to the checked state of radio buttons
            KiwiContextMenuRadioButton radioButton = e.Item as KiwiContextMenuRadioButton;
            if (radioButton != null)
                radioButton.CheckedChanged += new EventHandler(OnRadioButtonCheckedChanged);
        }

        /// <summary>
        /// Raises the Removing event.
        /// </summary>
        /// <param name="e">A TypedCollectionEventArgs instance containing event data.</param>
        protected override void OnRemoving(TypedCollectionEventArgs<KiwiContextMenuItemBase> e)
        {
            // Must unhook from the change event to prevent memory leak
            KiwiContextMenuRadioButton radioButton = e.Item as KiwiContextMenuRadioButton;
            if (radioButton != null)
                radioButton.CheckedChanged -= new EventHandler(OnRadioButtonCheckedChanged);

            base.OnRemoving(e);
        }
        #endregion

        #region Private
        private void OnRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            KiwiContextMenuRadioButton radioButton = sender as KiwiContextMenuRadioButton;

            // Only interested if the button has become checked
            if (radioButton.Checked)
            {
                // Find the position of this element in the collection
                int index = IndexOf(radioButton);

                // Scan upwards for other radio button instances
                UncheckRadioButtons(index - 1, 0, -1);

                // Scan downwards for other radio button instances
                UncheckRadioButtons(index + 1, Count - 1, 1);
            }
        }

        private void UncheckRadioButtons(int start, int end, int change)
        {
            // Check that the start index is valid
            if ((start >= 0) && (start < Count))
            {
                do
                {
                    KiwiContextMenuRadioButton radioButton = this[start] as KiwiContextMenuRadioButton;

                    // Exit as soon as a non-radio button is encountered
                    if (radioButton == null)
                        break;

                    // Set the radio button to unchecked
                    if (radioButton.Checked)
                        radioButton.Checked = false;

                    // Keep going until we reach the end item
                    if (start == end)
                        break;

                    // Moved to next index
                    start += change;

                } while (true);
            }
        }

        private ViewLayoutStack AddColumn(ViewLayoutStack columns)
        {
            ViewLayoutStack column = new ViewLayoutStack(false);
            columns.Add(column);
            return column;
        }
        #endregion
    }

    /// <summary>
    /// Manage the items that can be added to a standard menu item collection.
    /// </summary>
    public class KiwiContextMenuItemCollection : TypedRestrictCollection<KiwiContextMenuItemBase>
    {
        #region Static Fields
        private static readonly Type[] _types = new Type[] { typeof(KiwiContextMenuItem),
                                                             typeof(KiwiContextMenuSeparator),
                                                             typeof(KiwiContextMenuHeading) };
        #endregion

        #region Restrict
        /// <summary>
        /// Gets an array of types that the collection is restricted to contain.
        /// </summary>
        public override Type[] RestrictTypes
        {
            get { return _types; }
        }
        #endregion

        #region ProcessShortcut
        /// <summary>
        /// Test for the provided shortcut and perform relevant action if a match is found.
        /// </summary>
        /// <param name="keyData">Key data to check against shorcut definitions.</param>
        /// <returns>True if shortcut was handled, otherwise false.</returns>
        public bool ProcessShortcut(Keys keyData)
        {
            // Ask each individual item if it has a shortcut to be processed
            foreach (KiwiContextMenuItemBase item in this)
                if (item.ProcessShortcut(keyData))
                    return true;

            return false;
        }
        #endregion

        #region Internal
        internal void GenerateView(IContextMenuProvider provider,
                                   KiwiContextMenuItems items,
                                   object parent,
                                   ViewLayoutStack columns,
                                   bool standardStyle,
                                   bool imageColumn)
        {
            // Create the initial column
            ViewBase column = AddColumn(provider, items, columns, standardStyle, imageColumn);

            // Process each item in the collection in turn
            foreach (KiwiContextMenuItemBase item in this)
            {
                if (item.Visible)
                {
                    // Special handling of separator items
                    if (item is KiwiContextMenuSeparator)
                    {
                        // Cast to correct type
                        KiwiContextMenuSeparator separator = (KiwiContextMenuSeparator)item;

                        // If vertical break....
                        if (!separator.Horizontal)
                        {
                            // Add separator as next column view element
                            columns.Add(separator.GenerateView(provider, this, columns, standardStyle, imageColumn));

                            // Start new column for subsequent child items
                            column = AddColumn(provider, items, columns, standardStyle, imageColumn);
                        }
                        else
                        {
                            // Add separator view into the current column
                            column.Add(separator.GenerateView(provider, this, columns, standardStyle, imageColumn));
                        }
                    }
                    else
                    {
                        // All other items we just ask them for the view to add
                        column.Add(item.GenerateView(provider, this, columns, standardStyle, imageColumn));
                    }
                }
            }
        }
        #endregion

        #region Private
        private ViewBase AddColumn(IContextMenuProvider provider,
                                   KiwiContextMenuItems items,
                                   ViewLayoutStack columns,
                                   bool standardStyle,
                                   bool imageColumn)
        {
            // Create a pile specific to organising menu items
            ViewLayoutMenuItemsPile menuItemPile = new ViewLayoutMenuItemsPile(provider, items, standardStyle, imageColumn);

            // The pile is the root item for the new column
            columns.Add(menuItemPile);

            // Child items are placed inside the column stack
            return menuItemPile.ItemStack;
        }
        #endregion
    }
}
