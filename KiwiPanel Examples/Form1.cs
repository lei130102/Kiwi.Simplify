using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KiwiPanel_Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Setup the property grid to edit this panel
            propertyGrid.SelectedObject = new KiwiPanelProxy(panel1Office);
        }

        private void kiwiPanel_MouseDown(object sender, MouseEventArgs e)
        {
            // Setup the property grid to edit this panel
            propertyGrid.SelectedObject = new KiwiPanelProxy(sender as KiwiPanel);
        }
    }

    public class KiwiPanelProxy
    {
        private KiwiPanel _panel;

        public KiwiPanelProxy(KiwiPanel panel)
        {
            _panel = panel;
        }

        [Category("Visuals")]
        [Description("Panel style.")]
        [DefaultValue(typeof(PaletteBackStyle), "PanelClient")]
        public PaletteBackStyle PanelBackStyle
        {
            get { return _panel.PanelBackStyle; }
            set { _panel.PanelBackStyle = value; }
        }

        [Category("Visuals")]
        [Description("Overrides for defining common panel appearance that other states can override.")]
        public PaletteBack StateCommon
        {
            get { return _panel.StateCommon; }
        }

        [Category("Visuals")]
        [Description("Overrides for defining disabled panel appearance.")]
        public PaletteBack StateDisabled
        {
            get { return _panel.StateDisabled; }
        }

        [Category("Visuals")]
        [Description("Overrides for defining normal panel appearance.")]
        public PaletteBack StateNormal
        {
            get { return _panel.StateNormal; }
        }

        [Category("Visuals")]
        [Description("Palette applied to drawing.")]
        [DefaultValue(typeof(PaletteMode), "Global")]
        public PaletteMode PaletteMode
        {
            get { return _panel.PaletteMode; }
            set { _panel.PaletteMode = value; }
        }

        [Category("Layout")]
        [Description("The size of the control is pixels.")]
        public Size Size
        {
            get { return _panel.Size; }
            set { _panel.Size = value; }
        }

        [Category("Layout")]
        [Description("The location of the control in pixels.")]
        public Point Location
        {
            get { return _panel.Location; }
            set { _panel.Location = value; }
        }
    }

}
