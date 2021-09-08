using Kiwi.ComponentFactory.Navigator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Navigator_ToolTips
{
    public partial class Form1 : Form
    {
        private MapKiwiPageTextConverter _textConv = new MapKiwiPageTextConverter();
        private MapKiwiPageImageConverter _imageConv = new MapKiwiPageImageConverter();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new MapKiwiPageImageConverter();

            // Populate the text/extra text mapping combo boxes
            foreach (MapKiwiPageText value in Enum.GetValues(typeof(MapKiwiPageText)))
            {
                comboMapText.Items.Add(_textConv.ConvertToInvariantString(value));
                comboMapExtraText.Items.Add(_textConv.ConvertToInvariantString(value));
            }

            // Populate the image mapping combo box
            foreach (MapKiwiPageImage value in Enum.GetValues(typeof(MapKiwiPageImage)))
                comboMapImage.Items.Add(_imageConv.ConvertToInvariantString(value));

            // Update with current navigator settings
            checkAllowPageTooltips.Checked = kiwiNavigator.ToolTips.AllowPageToolTips;
            checkAllowButtonSpecTooltips.Checked = kiwiNavigator.ToolTips.AllowButtonSpecToolTips;
            comboMapText.Text = _textConv.ConvertToInvariantString(kiwiNavigator.ToolTips.MapText);
            comboMapExtraText.Text = _textConv.ConvertToInvariantString(kiwiNavigator.ToolTips.MapExtraText);
            comboMapImage.Text = _imageConv.ConvertToInvariantString(kiwiNavigator.ToolTips.MapImage);
        }

        private void checkAllowPageTooltips_CheckedChanged(object sender, EventArgs e)
        {
            kiwiNavigator.ToolTips.AllowPageToolTips = checkAllowPageTooltips.Checked;
        }

        private void checkAllowButtonSpecTooltips_CheckedChanged(object sender, EventArgs e)
        {
            kiwiNavigator.ToolTips.AllowButtonSpecToolTips = checkAllowButtonSpecTooltips.Checked;
        }

        private void comboMapText_SelectedIndexChanged(object sender, EventArgs e)
        {
            kiwiNavigator.ToolTips.MapText = (MapKiwiPageText)_textConv.ConvertFromInvariantString(comboMapText.Text);
        }

        private void comboMapExtraText_SelectedIndexChanged(object sender, EventArgs e)
        {
            kiwiNavigator.ToolTips.MapExtraText = (MapKiwiPageText)_textConv.ConvertFromInvariantString(comboMapExtraText.Text);
        }

        private void comboMapImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            kiwiNavigator.ToolTips.MapImage = (MapKiwiPageImage)_imageConv.ConvertFromInvariantString(comboMapImage.Text);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
