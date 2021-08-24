using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KiwiGroup_Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void group_MouseDown(object sender, MouseEventArgs e)
        {
            // Setup the property grid to edit this group
            propertyGrid.SelectedObject = new KiwiGroupProxy(sender as KiwiGroup);
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;

            // Setup the property grid to edit this panel parent group
            propertyGrid.SelectedObject = new KiwiGroupProxy(c.Parent as KiwiGroup);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Setup the property grid to edit this group
            propertyGrid.SelectedObject = new KiwiGroupProxy(group1Office);
        }
    }

    public class KiwiGroupProxy
    {
        private KiwiGroup _group;

        public KiwiGroupProxy(KiwiGroup group)
        {
            _group = group;
        }

        [Category("Visuals")]
        [Description("Border style.")]
        [DefaultValue(typeof(PaletteBorderStyle), "Control - Client")]
        public PaletteBorderStyle GroupBorderStyle
        {
            get { return _group.GroupBorderStyle; }
            set { _group.GroupBorderStyle = value; }
        }

        [Category("Visuals")]
        [Description("Background style.")]
        [DefaultValue(typeof(PaletteBackStyle), "Control - Client")]
        public PaletteBackStyle GroupBackStyle
        {
            get { return _group.GroupBackStyle; }
            set { _group.GroupBackStyle = value; }
        }

        [Category("Visuals")]
        [Description("Overrides for defining common group appearance that other states can override.")]
        public PaletteDoubleRedirect StateCommon
        {
            get { return _group.StateCommon; }
        }

        [Category("Visuals")]
        [Description("Overrides for defining disabled group appearance.")]
        public PaletteDouble StateDisabled
        {
            get { return _group.StateDisabled; }
        }

        [Category("Visuals")]
        [Description("Overrides for defining normal group appearance.")]
        public PaletteDouble StateNormal
        {
            get { return _group.StateNormal; }
        }

        [Category("Visuals")]
        [Description("Palette applied to drawing.")]
        [DefaultValue(typeof(PaletteMode), "Global")]
        public PaletteMode PaletteMode
        {
            get { return _group.PaletteMode; }
            set { _group.PaletteMode = value; }
        }

        [Category("Layout")]
        [Description("The size of the control is pixels.")]
        public Size Size
        {
            get { return _group.Size; }
            set { _group.Size = value; }
        }

        [Category("Layout")]
        [Description("The location of the control in pixels.")]
        public Point Location
        {
            get { return _group.Location; }
            set { _group.Location = value; }
        }
    }
}
