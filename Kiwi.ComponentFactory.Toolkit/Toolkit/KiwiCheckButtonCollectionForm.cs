using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Toolkit
{
    internal partial class KiwiCheckButtonCollectionForm : Form
    {
        #region Type Definitions
        private class ListEntry
        {
            #region Instance Fields
            private KiwiCheckButton _checkButton;
            #endregion

            #region Identity
            /// <summary>
            /// Initialize a new instance of the ListEntry class.
            /// </summary>
            /// <param name="checkButton">CheckButton to encapsulate.</param>
            public ListEntry(KiwiCheckButton checkButton)
            {
                Debug.Assert(checkButton != null);
                _checkButton = checkButton;
            }

            /// <summary>
            /// Gets a string representation of the encapsulated check button.
            /// </summary>
            /// <returns>String instance.</returns>
            public override string ToString()
            {
                return _checkButton.Site.Name + "  (Text: " + _checkButton.Text + ")";
            }
            #endregion

            #region Public
            /// <summary>
            /// Gets access to the encapsulated check button instance.
            /// </summary>
            public KiwiCheckButton CheckButton
            {
                get { return _checkButton; }
            }
            #endregion
        }
        #endregion

        #region Instance Fields
        private KiwiCheckSet _checkSet;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiCheckButtonCollectionForm class.
        /// </summary>
        public KiwiCheckButtonCollectionForm()
            : this(null)
        {
        }

        /// <summary>
        /// Initialize a new instance of the KiwiCheckButtonCollectionForm class.
        /// </summary>
        public KiwiCheckButtonCollectionForm(KiwiCheckSet checkSet)
        {
            // Remember the owning control
            _checkSet = checkSet;

            InitializeComponent();
        }
        #endregion

        #region Implementation
        private void KiwiCheckButtonCollectionForm_Load(object sender, EventArgs e)
        {
            // Get access to the container of the check set
            IContainer container = _checkSet.Container;

            // Assuming we manage to find a container
            if (container != null)
            {
                // Find all the check buttons inside the container
                foreach (object obj in container.Components)
                {
                    // We are only interested in check buttons
                    if (obj is KiwiCheckButton)
                    {
                        // Cast to the correct type
                        KiwiCheckButton checkButton = (KiwiCheckButton)obj;

                        // Add a new entry to the list box but only check it if 
                        // it is already present in the check buttons collection
                        checkedListBox.Items.Add(new ListEntry(checkButton),
                                                 _checkSet.CheckButtons.Contains(checkButton));
                    }
                }
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // Create a copy of the current check set buttons
            List<KiwiCheckButton> copy = new List<KiwiCheckButton>();
            foreach (KiwiCheckButton checkButton in _checkSet.CheckButtons)
                copy.Add(checkButton);

            // Process each of the list entries in turn
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                // Get access to the encapsulated list box entry
                ListEntry entry = (ListEntry)checkedListBox.Items[i];

                // Is this entry checked in the list box?
                if (checkedListBox.GetItemChecked(i))
                {
                    // Make sure the check button is in the check set
                    if (!_checkSet.CheckButtons.Contains(entry.CheckButton))
                        _checkSet.CheckButtons.Add(entry.CheckButton);
                    else
                        copy.Remove(entry.CheckButton);
                }
                else
                {
                    // Make sure the check button is not in the check set
                    if (_checkSet.CheckButtons.Contains(entry.CheckButton))
                    {
                        _checkSet.CheckButtons.Remove(entry.CheckButton);
                        copy.Remove(entry.CheckButton);
                    }
                }
            }

            // If there are any dangling references in the checkset that are
            // not in the component list from the list box then remove them
            foreach (KiwiCheckButton checkButton in copy)
                _checkSet.CheckButtons.Remove(checkButton);
        }
        #endregion
    }
}
