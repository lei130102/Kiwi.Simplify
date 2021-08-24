﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Enforce mutual exclusive for a group of KiwiCheckButton controls.
    /// </summary>
    [ClassInterface(ClassInterfaceType.AutoDispatch)]
    [ComVisible(true)]
    [ToolboxItem(true)]
    [DefaultProperty("CheckButtons")]
    [Designer("Kiwi.ComponentFactory.Toolkit.KiwiCheckSetDesigner, Kiwi.ComponentFactory.Toolkit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=360f304a9e10e704")]
    //
    [ToolboxBitmap(typeof(KiwiCheckSet), "ToolboxBitmaps.KiwiCheckSet.bmp")]
    [DefaultEvent("CheckedButtonChanged")]
    [DesignerCategory("code")]
    [Description("Provide exclusive checked logic for a set of KiwiCheckButton controls.")]
    public class KiwiCheckSet : Component,
                                   ISupportInitialize
    {
        #region Type Definitions
        /// <summary>
        /// Manages a collection of KiwiCheckButton references.
        /// </summary>
        public class KiwiCheckButtonCollection : CollectionBase
        {
            #region Instance Fields
            private KiwiCheckSet _owner;
            #endregion

            #region Identity
            /// <summary>
            /// Initialize a new instance of the KiwiCheckButtonCollection class.
            /// </summary>
            /// <param name="owner">Owning component</param>
            public KiwiCheckButtonCollection(KiwiCheckSet owner)
            {
                Debug.Assert(owner != null);
                _owner = owner;
            }
            #endregion

            #region Public
            /// <summary>
            /// Adds the specifies KiwiCheckButton to the collection.
            /// </summary>
            /// <param name="checkButton">The KiwiCheckButton object to add to the collection.</param>
            /// <returns>The index of the new entry.</returns>
            public int Add(KiwiCheckButton checkButton)
            {
                Debug.Assert(checkButton != null);

                if (checkButton == null)
                    throw new ArgumentNullException("checkButton");

                if (Contains(checkButton))
                    throw new ArgumentException("Reference already exists in the collection");

                base.List.Add(checkButton);

                return base.List.Count - 1;
            }

            /// <summary>
            /// Determines whether a KiwiCheckButton is in the collection.
            /// </summary>
            /// <param name="checkButton">The KiwiCheckButton to locate in the collection.</param>
            /// <returns>True if found in collection; otherwise false.</returns>
            public bool Contains(KiwiCheckButton checkButton)
            {
                return base.List.Contains(checkButton);
            }

            /// <summary>
            /// Returns the index of the KiwiCheckButton reference.
            /// </summary>
            /// <param name="checkButton">The KiwiCheckButton to locate.</param>
            /// <returns>Index of reference; otherwise -1.</returns>
            public int IndexOf(KiwiCheckButton checkButton)
            {
                return base.List.IndexOf(checkButton);
            }

            /// <summary>
            /// Inserts a KiwiCheckButton reference into the collection at the specified location.
            /// </summary>
            /// <param name="index">Index of position to insert.</param>
            /// <param name="checkButton">The KiwiCheckButton reference to insert.</param>
            public void Insert(int index, KiwiCheckButton checkButton)
            {
                Debug.Assert(checkButton != null);

                if (checkButton == null)
                    throw new ArgumentNullException("checkButton");

                if ((index < 0) || (index > Count))
                    throw new ArgumentOutOfRangeException("index");

                if (Contains(checkButton))
                    throw new ArgumentException("Reference already in collection");

                base.List.Insert(index, checkButton);
            }

            /// <summary>
            /// Removes a KiwiCheckButton from the collection.
            /// </summary>
            /// <param name="checkButton">The KiwiCheckButton to remove.</param>
            public void Remove(KiwiCheckButton checkButton)
            {
                Debug.Assert(checkButton != null);

                if (checkButton == null)
                    throw new ArgumentNullException("checkButton");

                if (!Contains(checkButton))
                    throw new ArgumentException("No matching reference to remove");

                base.List.Remove(checkButton);
            }

            /// <summary>
            /// Gets the KiwiCheckButton at the specified index.
            /// </summary>
            /// <param name="index">Index of entry to return.</param>
            /// <returns>Reference of KiwiCheckButton instance.</returns>
            public KiwiCheckButton this[int index]
            {
                get
                {
                    if ((index < 0) || (index > Count))
                        throw new ArgumentOutOfRangeException("index");

                    return (KiwiCheckButton)base.List[index];
                }
            }
            #endregion

            #region Protected
            /// <summary>
            /// Occurs when the collection is about to be cleared.
            /// </summary>
            protected override void OnClear()
            {
                foreach (KiwiCheckButton checkButton in base.List)
                    _owner.CheckButtonRemoved(checkButton);

                base.OnClear();
            }

            /// <summary>
            /// Occurs when a new entry has been added to the collection.
            /// </summary>
            /// <param name="index">Index of new entry.</param>
            /// <param name="value">Value at the new index.</param>
            protected override void OnInsertComplete(int index, object value)
            {
                _owner.CheckButtonAdded(value as KiwiCheckButton);
                base.OnInsertComplete(index, value);
            }

            /// <summary>
            /// Occurs when an entry has been removed from the collection.
            /// </summary>
            /// <param name="index">Index of the removed entry.</param>
            /// <param name="value">Value at the removed entry.</param>
            protected override void OnRemoveComplete(int index, object value)
            {
                _owner.CheckButtonRemoved(value as KiwiCheckButton);
                base.OnRemoveComplete(index, value);
            }

            /// <summary>
            /// Occurs when a index has a value replaced.
            /// </summary>
            /// <param name="index">Index of the change in value.</param>
            /// <param name="oldValue">Value being replaced.</param>
            /// <param name="newValue">Value to be used.</param>
            protected override void OnSetComplete(int index, object oldValue, object newValue)
            {
                _owner.CheckButtonRemoved(oldValue as KiwiCheckButton);
                _owner.CheckButtonAdded(newValue as KiwiCheckButton);
                base.OnSetComplete(index, oldValue, newValue);
            }
            #endregion
        }
        #endregion

        #region Instance Fields
        private bool _initializing;
        private bool _checkedChanged;
        private bool _ignoreEvents;
        private bool _allowUncheck;
        private KiwiCheckButton _checkedButton;
        private KiwiCheckButtonCollection _checkButtons;
        #endregion

        #region Events
        /// <summary>
        /// Occurs when the value of the CheckedButton property has changed.
        /// </summary>
        [Category("Property Changed")]
        [Description("Occurs whenever the CheckedButton property has changed.")]
        public event EventHandler CheckedButtonChanged;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiCheckSet class.
        /// </summary>
        public KiwiCheckSet()
        {
            _checkButtons = new KiwiCheckButtonCollection(this);
        }

        /// <summary>
        /// Initialize a new instance of the KiwiCheckSet class.
        /// </summary>
        /// <param name="container">Container that owns the component.</param>
        public KiwiCheckSet(IContainer container)
            : this()
        {
            Debug.Assert(container != null);

            // Validate reference parameter
            if (container == null) throw new ArgumentNullException("container");

            container.Add(this);
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }

            base.Dispose(disposing);
        }
        #endregion

        #region Public
        /// <summary>
        /// Signals the object that initialization is starting.
        /// </summary>
        public void BeginInit()
        {
            _checkedChanged = false;
            _initializing = true;
        }

        /// <summary>
        /// Signals the object that initialization is complete.
        /// </summary>
        public void EndInit()
        {
            _initializing = false;

            if (_checkedChanged)
                OnCheckedButtonChanged(EventArgs.Empty);
        }

        /// <summary>
        /// Gets and sets a value indicating if the checked button is allowed to be unchecked.
        /// </summary>
        [Category("Behavior")]
        [Description("Is the current checked button allowed to be unchecked.")]
        [DefaultValue(false)]
        public bool AllowUncheck
        {
            get { return _allowUncheck; }
            set { _allowUncheck = value; }
        }

        /// <summary>
        /// Gets and sets the currently checked button in the set.
        /// </summary>
        [Bindable(true)]
        [Category("Appearance")]
        [Description("Determine which of the associated buttons is checked.")]
        [RefreshProperties(RefreshProperties.All)]
        [TypeConverter(typeof(KiwiCheckedButtonConverter))]
        [DefaultValue(null)]
        public KiwiCheckButton CheckedButton
        {
            get { return _checkedButton; }

            set
            {
                if (_checkedButton != value)
                {
                    // Check the new target is associated with us already
                    if ((value != null) && !CheckButtons.Contains(value))
                        throw new ArgumentOutOfRangeException("value", "Provided value is not a KiwiCheckButton associated with this set.");

                    // Prevent processing events caused by ourself
                    _ignoreEvents = true;

                    if (_checkedButton != null)
                        _checkedButton.Checked = false;

                    _checkedButton = value;

                    if (_checkedButton != null)
                        _checkedButton.Checked = true;

                    _ignoreEvents = false;

                    // Generate event to show the value has changed
                    OnCheckedButtonChanged(EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Gets and sets the index of the checked button.
        /// </summary>
        [Bindable(true)]
        [Category("Appearance")]
        [Description("Determine the index of the checked button.")]
        [RefreshProperties(RefreshProperties.All)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [DefaultValue(-1)]
        public int CheckedIndex
        {
            get
            {
                if (CheckedButton == null)
                    return -1;
                else
                    return CheckButtons.IndexOf(CheckedButton);
            }

            set
            {
                // Check for a value outside of limits
                if ((value < -1) || (value >= CheckButtons.Count))
                    throw new ArgumentOutOfRangeException("value");

                // Special case the value of -1 as requesting nothing checked
                if (value == -1)
                    CheckedButton = null;
                else
                    CheckedButton = CheckButtons[value];
            }
        }

        /// <summary>
        /// Gets access to the collection of KiwiCheckButton referencs.
        /// </summary>
        [Category("Behavior")]
        [Description("Determine which of the associated buttons is checked.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("Kiwi.ComponentFactory.Toolkit.KiwiCheckButtonCollectionEditor, Kiwi.ComponentFactory.Toolkit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=360f304a9e10e704", typeof(UITypeEditor))]
        [RefreshProperties(RefreshProperties.All)]
        public KiwiCheckButtonCollection CheckButtons
        {
            get { return _checkButtons; }
        }
        #endregion

        #region Protected Virtual
        /// <summary>
        /// Raises the CheckedButtonChanged event.
        /// </summary>
        /// <param name="e">An EventArgs containing the event data.</param>
        protected virtual void OnCheckedButtonChanged(EventArgs e)
        {
            if (!_initializing)
            {
                if (CheckedButtonChanged != null)
                    CheckedButtonChanged(this, e);
            }
            else
                _checkedChanged = true;
        }
        #endregion

        #region Implementation
        private void CheckButtonAdded(KiwiCheckButton checkButton)
        {
            // If the incoming button is already checked
            if (checkButton.Checked)
            {
                // If we already have a button checked
                if (_checkedButton != null)
                {
                    // Then uncheck the incoming button
                    checkButton.Checked = false;
                }
                else
                {
                    // Remember this as the currently checked instance
                    _checkedButton = checkButton;

                    // Generate event to show the value has changed
                    OnCheckedButtonChanged(EventArgs.Empty);
                }
            }

            // Need to monitor and control the change of checked state
            checkButton.CheckedChanging += new CancelEventHandler(OnCheckedChanging);
            checkButton.CheckedChanged += new EventHandler(OnCheckedChanged);
        }

        private void CheckButtonRemoved(KiwiCheckButton checkButton)
        {
            // Unhook from monitoring events
            checkButton.CheckedChanging -= new CancelEventHandler(OnCheckedChanging);
            checkButton.CheckedChanged -= new EventHandler(OnCheckedChanged);

            // If the removed button is the currently checked one
            if (_checkedButton == checkButton)
            {
                // Then we no longer have a currently checked button
                _checkedButton = null;

                // Generate event to show the value has changed
                OnCheckedButtonChanged(EventArgs.Empty);
            }
        }

        private void OnCheckedChanging(object sender, CancelEventArgs e)
        {
            // Are we allowed to process the event?
            if (!_ignoreEvents)
            {
                // Cast to the correct type
                KiwiCheckButton checkedButton = (KiwiCheckButton)sender;

                // Prevent the checked button becoming unchecked unless AllowUncheck is defined
                e.Cancel = checkedButton.Checked && !AllowUncheck;
            }
        }

        private void OnCheckedChanged(object sender, EventArgs e)
        {
            // Are we allowed to process the event?
            if (!_ignoreEvents)
            {
                // Cast to the correct type
                KiwiCheckButton checkedButton = (KiwiCheckButton)sender;

                if (checkedButton.Checked)
                {
                    // Uncheck the currently checked button
                    if (_checkedButton != null)
                    {
                        // Prevent processing events caused by ourself
                        _ignoreEvents = true;
                        _checkedButton.Checked = false;
                        _ignoreEvents = false;
                    }

                    // Remember the newly checked button
                    _checkedButton = checkedButton;
                }
                else
                {
                    // No check button is checked anymore
                    _checkedButton = null;
                }

                // Generate event to show the value has changed
                OnCheckedButtonChanged(EventArgs.Empty);
            }
        }
        #endregion
    }
}
