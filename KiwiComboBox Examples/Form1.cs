using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KiwiComboBox_Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Setup the property grid to edit this combo box
            propertyGrid.SelectedObject = new KiwiComboBoxProxy(kiwiComboBox1Blue);
        }

        private void kiwiComboBox1Blue_Enter(object sender, EventArgs e)
        {
            // Setup the property grid to edit this combo box
            propertyGrid.SelectedObject = new KiwiComboBoxProxy(sender as KiwiComboBox);
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            kiwiComboBox2Blue.Text = string.Empty;
            kiwiComboBox2Blue.ComboBox.Focus();
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            kiwiComboBox5System.Text = string.Empty;
            kiwiComboBox5System.ComboBox.Focus();
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            if (kiwiComboBox8Custom.SelectedIndex > 0)
            {
                kiwiComboBox8Custom.SelectedIndex -= 1;
                kiwiComboBox8Custom.ComboBox.Focus();
            }
        }

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            if (kiwiComboBox8Custom.SelectedIndex < (kiwiComboBox8Custom.Items.Count - 1))
            {
                kiwiComboBox8Custom.SelectedIndex += 1;
                kiwiComboBox8Custom.ComboBox.Focus();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public class KiwiComboBoxProxy
    {
        private KiwiComboBox _comboBox;

        public KiwiComboBoxProxy(KiwiComboBox comboBox)
        {
            _comboBox = comboBox;
        }

        [Category("Appearance")]
        [Description("Text for display inside the control.")]
        public string Text
        {
            get { return _comboBox.Text; }
            set { _comboBox.Text = value; }
        }

        [Category("Visuals")]
        [Description("Determines if the control is always active or only when the mouse is over the control or has focus.")]
        public bool AlwaysActive
        {
            get { return _comboBox.AlwaysActive; }
            set { _comboBox.AlwaysActive = value; }
        }

        [Category("Appearance")]
        [Description("Controls the appearance and functionality of the KiwiComboBox.")]
        public ComboBoxStyle DropDownStyle
        {
            get { return _comboBox.DropDownStyle; }
            set { _comboBox.DropDownStyle = value; }
        }

        [Category("Behavior")]
        [Description("The height, in pixels, of the drop down box in a KiwiComboBox.")]
        public int DropDownHeight
        {
            get { return _comboBox.DropDownHeight; }
            set { _comboBox.DropDownHeight = value; }
        }

        [Category("Behavior")]
        [Description("The width, in pixels, of the drop down box in a KiwiComboBox.")]
        public int DropDownWidth
        {
            get { return _comboBox.DropDownWidth; }
            set { _comboBox.DropDownWidth = value; }
        }

        [Category("Behavior")]
        [Description("The height, in pixels, of items in an owner-draw KryptomComboBox.")]
        public int ItemHeight
        {
            get { return _comboBox.ItemHeight; }
            set { _comboBox.ItemHeight = value; }
        }

        [Category("Behavior")]
        [Description("The maximum number of entries to display in the drop-down list.")]
        public int MaxDropDownItems
        {
            get { return _comboBox.MaxDropDownItems; }
            set { _comboBox.MaxDropDownItems = value; }
        }

        [Category("Behavior")]
        [Description("Specifies the maximum number of characters that can be entered into the edit control.")]
        public int MaxLength
        {
            get { return _comboBox.MaxLength; }
            set { _comboBox.MaxLength = value; }
        }

        [Category("Behavior")]
        [Description("Specifies whether the items in the list portion of the KiwiComboBox are sorted.")]
        public bool Sorted
        {
            get { return _comboBox.Sorted; }
            set { _comboBox.Sorted = value; }
        }

        [Category("Data")]
        [Description("The items in the KiwiComboBox.")]
        public ComboBox.ObjectCollection Items
        {
            get { return _comboBox.Items; }
        }

        [Category("Visuals")]
        [Description("Input control style.")]
        public InputControlStyle InputControlStyle
        {
            get { return _comboBox.InputControlStyle; }
            set { _comboBox.InputControlStyle = value; }
        }

        [Category("Visuals")]
        [Description("DropButton style.")]
        public ButtonStyle DropButtonStyle
        {
            get { return _comboBox.DropButtonStyle; }
            set { _comboBox.DropButtonStyle = value; }
        }

        [Category("Visuals")]
        [Description("Should tooltips be displayed for button specs.")]
        public bool AllowButtonSpecToolTips
        {
            get { return _comboBox.AllowButtonSpecToolTips; }
            set { _comboBox.AllowButtonSpecToolTips = value; }
        }

        [Category("Visuals")]
        [Description("Collection of button specifications.")]
        public KiwiComboBox.ComboBoxButtonSpecCollection ButtonSpecs
        {
            get { return _comboBox.ButtonSpecs; }
        }

        [Category("Visuals")]
        [Description("Overrides for defining common combobox appearance that other states can override.")]
        public PaletteComboBoxRedirect StateCommon
        {
            get { return _comboBox.StateCommon; }
        }

        [Category("Visuals")]
        [Description("Overrides for defining disabled combobox appearance.")]
        public PaletteComboBoxStates StateDisabled
        {
            get { return _comboBox.StateDisabled; }
        }

        [Category("Visuals")]
        [Description("Overrides for defining normal combobox appearance.")]
        public PaletteComboBoxStates StateNormal
        {
            get { return _comboBox.StateNormal; }
        }

        [Category("Visuals")]
        [Description("Overrides for defining active combobox appearance.")]
        public PaletteComboBoxJustComboStates StateActive
        {
            get { return _comboBox.StateActive; }
        }

        [Category("Layout")]
        [Description("The size of the control is pixels.")]
        public Size Size
        {
            get { return _comboBox.Size; }
            set { _comboBox.Size = value; }
        }

        [Category("Layout")]
        [Description("The location of the control in pixels.")]
        public Point Location
        {
            get { return _comboBox.Location; }
            set { _comboBox.Location = value; }
        }
    }
}
