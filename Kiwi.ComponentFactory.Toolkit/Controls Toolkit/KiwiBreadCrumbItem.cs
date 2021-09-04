using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Kiwi object used to represent nodes in a hierarchical bread crumb data structure.
    /// </summary>
    [ToolboxItem(false)]
    [ToolboxBitmap(typeof(KiwiBreadCrumbItem), "ToolboxBitmaps.KiwiBreadCrumbItem.bmp")]
    [DesignTimeVisible(false)]
    [Designer("Kiwi.ComponentFactory.Toolkit.KiwiBreadCrumbItemDesigner, Kiwi.ComponentFactory.Toolkit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=360f304a9e10e704")]
    public class KiwiBreadCrumbItem : KiwiListItem
    {
        #region Type Definitons
        /// <summary>
        /// Manages a collection of KiwiBreadCrumbItems
        /// </summary>
        [Editor("Kiwi.ComponentFactory.Toolkit.KiwiBreadCrumbItemsEditor, Kiwi.ComponentFactory.Toolkit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=360f304a9e10e704", typeof(UITypeEditor))]
        public class BreadCrumbItems : TypedCollection<KiwiBreadCrumbItem>
        {
            #region Instance Fields
            private KiwiBreadCrumbItem _owner;
            #endregion

            #region Identity
            /// <summary>
            /// Initialize a new instance of the BreadCrumbItems class.
            /// </summary>
            /// <param name="owner">Reference to owning item.</param>
            internal BreadCrumbItems(KiwiBreadCrumbItem owner)
            {
                _owner = owner;
            }
            #endregion

            #region Public
            /// <summary>
            /// Gets the item with the provided unique name.
            /// </summary>
            /// <param name="name">Name of the ribbon tab instance.</param>
            /// <returns>Item at specified index.</returns>
            public override KiwiBreadCrumbItem this[string name]
            {
                get
                {
                    if (!string.IsNullOrEmpty(name))
                    {
                        foreach (KiwiBreadCrumbItem item in this)
                        {
                            string text = item.ShortText;
                            if (!string.IsNullOrEmpty(text) && (text == name))
                                return item;

                            text = item.LongText;
                            if (!string.IsNullOrEmpty(text) && (text == name))
                                return item;
                        }
                    }

                    return null;
                }
            }
            #endregion

            #region Protected
            /// <summary>
            /// Raises the Inserting event.
            /// </summary>
            /// <param name="e">A KiwiRibbonTabEventArgs instance containing event data.</param>
            protected override void OnInserting(TypedCollectionEventArgs<KiwiBreadCrumbItem> e)
            {
                // Setup parent relationship
                e.Item.Parent = _owner;

                base.OnInserting(e);
            }

            /// <summary>
            /// Raises the Inserted event.
            /// </summary>
            /// <param name="e">A TypedCollectionEventArgs instance containing event data.</param>
            protected override void OnInserted(TypedCollectionEventArgs<KiwiBreadCrumbItem> e)
            {
                base.OnInserted(e);

                // Notify a change in the owners items property
                _owner.OnPropertyChanged(new PropertyChangedEventArgs("Items"));
            }

            /// <summary>
            /// Raises the Removed event.
            /// </summary>
            /// <param name="e">A TypedCollectionEventArgs instance containing event data.</param>
            protected override void OnRemoved(TypedCollectionEventArgs<KiwiBreadCrumbItem> e)
            {
                base.OnRemoved(e);

                // Clear down parent relationship
                e.Item.Parent = null;

                // Notify a change in the owners items property
                _owner.OnPropertyChanged(new PropertyChangedEventArgs("Items"));
            }

            /// <summary>
            /// Raises the Clearing event.
            /// </summary>
            /// <param name="e">An EventArgs instance containing event data.</param>
            protected override void OnClearing(EventArgs e)
            {
                // Clear down parent relationship
                foreach (KiwiBreadCrumbItem child in this)
                    child.Parent = null;

                base.OnClearing(e);
            }

            /// <summary>
            /// Raises the Cleared event.
            /// </summary>
            /// <param name="e">An EventArgs instance containing event data.</param>
            protected override void OnCleared(EventArgs e)
            {
                base.OnCleared(e);

                // Notify a change in the owners items property
                _owner.OnPropertyChanged(new PropertyChangedEventArgs("Items"));
            }
            #endregion
        };
        #endregion

        #region Instance Fields
        private KiwiBreadCrumbItem _parent;
        private BreadCrumbItems _items;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiBreadCrumbItem class.
        /// </summary>
        public KiwiBreadCrumbItem()
            : this("ListItem", null, null, Color.Empty)
        {
        }

        /// <summary>
        /// Initialize a new instance of the KiwiBreadCrumbItem class.
        /// </summary>
        /// <param name="shortText">Initial short text value.</param>
        public KiwiBreadCrumbItem(string shortText)
            : this(shortText, null, null, Color.Empty)
        {
        }

        /// <summary>
        /// Initialize a new instance of the KiwiBreadCrumbItem class.
        /// </summary>
        /// <param name="shortText">Initial short text value.</param>
        /// <param name="longText">Initial long text value.</param>
        public KiwiBreadCrumbItem(string shortText, string longText)
            : this(shortText, longText, null, Color.Empty)
        {
        }

        /// <summary>
        /// Initialize a new instance of the KiwiBreadCrumbItem class.
        /// </summary>
        /// <param name="shortText">Initial short text value.</param>
        /// <param name="longText">Initial long text value.</param>
        /// <param name="image">Initial image value.</param>
        public KiwiBreadCrumbItem(string shortText,
                                     string longText,
                                     Image image)
            : this(shortText, longText, image, Color.Empty)
        {
        }

        /// <summary>
        /// Initialize a new instance of the KiwiBreadCrumbItem class.
        /// </summary>
        /// <param name="shortText">Initial short text value.</param>
        /// <param name="longText">Initial long text value.</param>
        /// <param name="image">Initial image value.</param>
        /// <param name="imageTransparentColor">Initial transparent image color.</param>
        public KiwiBreadCrumbItem(string shortText,
                                     string longText,
                                     Image image,
                                     Color imageTransparentColor)
            : base(shortText, longText, image, imageTransparentColor)
        {
            // Create child collection
            _items = new BreadCrumbItems(this);
        }

        /// <summary>
        /// Gets the string representation of the object.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "(" + _items.Count.ToString() + ") " + ShortText;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets access to the colletion of child items.
        /// </summary>
        [Category("Data")]
        [Description("Collection of child items.")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [RefreshProperties(RefreshProperties.All)]
        [Browsable(true)]
        public BreadCrumbItems Items
        {
            get { return _items; }
        }

        /// <summary>
        /// Gets access to the Parent item in the hierarchy.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public KiwiBreadCrumbItem Parent
        {
            get { return _parent; }
            internal set { _parent = value; }
        }
        #endregion

        #region Protected
        /// <summary>
        /// Raises the PropertyChanged event.
        /// </summary>
        /// <param name="e">A PropertyChangedEventArgs containing the event data.</param>
        protected override void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            // Raise event via the base class
            base.OnPropertyChanged(e);

            // If we have a parent instance
            KiwiBreadCrumbItem parent = Parent;
            if (parent != null)
            {
                // Find the root instance
                while (parent.Parent != null)
                    parent = parent.Parent;

                // Raise event in the root
                parent.OnPropertyChanged(e);
            }
        }
        #endregion     
    }
}
