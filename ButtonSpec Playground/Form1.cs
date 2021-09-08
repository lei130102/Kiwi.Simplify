using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ButtonSpec_Playground
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

        private void kiwiButtonAdd_Click(object sender, EventArgs e)
        {
            // Create a new button spec entry
            ButtonSpecHeaderGroup spec = new ButtonSpecHeaderGroup();
            spec.Type = PaletteButtonSpecStyle.Close;

            // Need to know when button is selected
            spec.Click += new EventHandler(OnButtonSelected);

            // Add to end of the collection of button specs
            kiwiHeaderGroup1.ButtonSpecs.Add(spec);

            // Make it the selected button spec
            propertyGrid.SelectedObject = spec;

            UpdateActionButtons();
        }

        private void kiwiButtonRemove_Click(object sender, EventArgs e)
        {
            // Get access to the selected button spec
            ButtonSpecHeaderGroup spec = (ButtonSpecHeaderGroup)propertyGrid.SelectedObject;

            // Remove just the selected button spec
            kiwiHeaderGroup1.ButtonSpecs.Remove(spec);

            // Nothing selected in the property grid
            propertyGrid.SelectedObject = null;

            UpdateActionButtons();
        }

        private void kiwiButtonClear_Click(object sender, EventArgs e)
        {
            // Remove all the button specifications
            kiwiHeaderGroup1.ButtonSpecs.Clear();

            // Nothing selected in the property grid
            propertyGrid.SelectedObject = null;

            UpdateActionButtons();
        }

        private void kiwiButtonTopP_Click(object sender, EventArgs e)
        {
            kiwiHeaderGroup1.HeaderPositionPrimary = VisualOrientation.Top;
        }

        private void kiwiButtonLeftP_Click(object sender, EventArgs e)
        {
            kiwiHeaderGroup1.HeaderPositionPrimary = VisualOrientation.Left;
        }

        private void kiwiButtonRightP_Click(object sender, EventArgs e)
        {
            kiwiHeaderGroup1.HeaderPositionPrimary = VisualOrientation.Right;
        }

        private void kiwiButtonBottomP_Click(object sender, EventArgs e)
        {
            kiwiHeaderGroup1.HeaderPositionPrimary = VisualOrientation.Bottom;
        }

        private void kiwiButtonTopS_Click(object sender, EventArgs e)
        {
            kiwiHeaderGroup1.HeaderPositionSecondary = VisualOrientation.Top;
        }

        private void kiwiButtonLeftS_Click(object sender, EventArgs e)
        {
            kiwiHeaderGroup1.HeaderPositionSecondary = VisualOrientation.Left;
        }

        private void kiwiButtonRightS_Click(object sender, EventArgs e)
        {
            kiwiHeaderGroup1.HeaderPositionSecondary = VisualOrientation.Right;
        }

        private void kiwiButtonBottomS_Click(object sender, EventArgs e)
        {
            kiwiHeaderGroup1.HeaderPositionSecondary = VisualOrientation.Bottom;
        }

        private void OnButtonSelected(object sender, EventArgs e)
        {
            // Cast to correct type
            ButtonSpecHeaderGroup spec = (ButtonSpecHeaderGroup)sender;

            // Make it the selected button spec
            propertyGrid.SelectedObject = spec;

            UpdateActionButtons();
        }

        private void UpdateActionButtons()
        {
            kiwiButtonRemove.Enabled = (propertyGrid.SelectedObject != null);
            kiwiButtonClear.Enabled = (kiwiHeaderGroup1.ButtonSpecs.Count > 0);
        }
    }
}
