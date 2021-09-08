using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace External_Drag_To_Docking
{
    public partial class ContentPropertyGrid : UserControl
    {
        public ContentPropertyGrid()
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            // Unhook from events so this control can be garbage collected
            KiwiManager.GlobalPaletteChanged -= new EventHandler(OnGlobalPaletteChanged);

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void ContentPropertyGrid_Load(object sender, EventArgs e)
        {
            // Hook into global palette changes
            KiwiManager.GlobalPaletteChanged += new EventHandler(OnGlobalPaletteChanged);

            // Set correct initial font for the property grid
            OnGlobalPaletteChanged(null, EventArgs.Empty);
        }

        private void OnGlobalPaletteChanged(object sender, EventArgs e)
        {
            // Use the current font from the global palette
            IPalette palette = KiwiManager.CurrentGlobalPalette;
            Font font = palette.GetContentShortTextFont(PaletteContentStyle.LabelNormalControl, PaletteState.Normal);
            propertyGrid1.Font = font;
        }
    }
}
