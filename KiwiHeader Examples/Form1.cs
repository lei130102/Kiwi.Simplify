using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KiwiHeader_Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Setup the property grid to edit this header
            propertyGrid.SelectedObject = new KiwiHeaderProxy(office1);
        }

        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            // Setup the property grid to edit this header
            propertyGrid.SelectedObject = new KiwiHeaderProxy(sender as KiwiHeader);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public class KiwiHeaderProxy
    {
        private KiwiHeader _header;

        public KiwiHeaderProxy(KiwiHeader header)
        {
            _header = header;
        }

        [Category("Visuals")]
        [Description("Should tooltips be displayed for button specs.")]
        [DefaultValue(false)]
        public bool AllowButtonSpecToolTips
        {
            get { return _header.AllowButtonSpecToolTips; }
            set { _header.AllowButtonSpecToolTips = value; }
        }

        [Category("Visuals")]
        [Description("Header style.")]
        [DefaultValue(typeof(HeaderStyle), "Primary")]
        public HeaderStyle HeaderStyle
        {
            get { return _header.HeaderStyle; }
            set { _header.HeaderStyle = value; }
        }

        [Category("Visuals")]
        [Description("Header values")]
        public HeaderValues Values
        {
            get { return _header.Values; }
        }

        [Category("Visuals")]
        [Description("Overrides for defining common header appearance that other states can override.")]
        public PaletteTripleRedirect StateCommon
        {
            get { return _header.StateCommon; }
        }

        [Category("Visuals")]
        [Description("Overrides for defining disabled header appearance.")]
        public PaletteTriple StateDisabled
        {
            get { return _header.StateDisabled; }
        }

        [Category("Visuals")]
        [Description("Overrides for defining normal header appearance.")]
        public PaletteTriple StateNormal
        {
            get { return _header.StateNormal; }
        }

        [Category("Visuals")]
        [Description("Collection of button specifications.")]
        public KiwiHeader.HeaderButtonSpecCollection ButtonSpecs
        {
            get { return _header.ButtonSpecs; }
        }

        [Category("Visuals")]
        [Description("Visual orientation of the control.")]
        [DefaultValue(typeof(VisualOrientation), "Top")]
        public VisualOrientation Orientation
        {
            get { return _header.Orientation; }
            set { _header.Orientation = value; }
        }

        [Category("Visuals")]
        [Description("Palette applied to drawing.")]
        [DefaultValue(typeof(PaletteMode), "Global")]
        public PaletteMode PaletteMode
        {
            get { return _header.PaletteMode; }
            set { _header.PaletteMode = value; }
        }

        [Category("Layout")]
        [Description("Specifies whether a control will automatically size itself to fit its contents.")]
        [DefaultValue(false)]
        public bool AutoSize
        {
            get { return _header.AutoSize; }
            set { _header.AutoSize = value; }
        }

        [Category("Layout")]
        [Description("Specifies if the control grows and shrinks to fit the contents exactly.")]
        [DefaultValue(typeof(AutoSizeMode), "GrowOnly")]
        public AutoSizeMode AutoSizeMode
        {
            get { return _header.AutoSizeMode; }
            set { _header.AutoSizeMode = value; }
        }

        [Category("Layout")]
        [Description("The size of the control is pixels.")]
        public Size Size
        {
            get { return _header.Size; }
            set { _header.Size = value; }
        }

        [Category("Layout")]
        [Description("The location of the control in pixels.")]
        public Point Location
        {
            get { return _header.Location; }
            set { _header.Location = value; }
        }

        [Category("Behavior")]
        [Description("Indicates whether the control is enabled.")]
        public bool Enabled
        {
            get { return _header.Enabled; }
            set { _header.Enabled = value; }
        }
    }
}
