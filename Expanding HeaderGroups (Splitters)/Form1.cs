using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Expanding_HeaderGroups__Splitters_
{
    public partial class Form1 : KiwiForm
    {
        private int _heightUpDown;
        private int _widthLeftRight;

        public Form1()
        {
            InitializeComponent();

            // Hook into the click events on the header buttons
            kiwiHeaderGroupRightBottom.ButtonSpecs[0].Click += new EventHandler(OnUpDown);
            kiwiHeaderGroupLeft.ButtonSpecs[0].Click += new EventHandler(OnLeftRight);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set position of caret in the text boxes, so it looks nicer at runtime!
            textBoxLeft.SelectionStart = textBoxRightTop.SelectionStart = textBoxRightBottom.SelectionStart = 0;
            textBoxLeft.SelectionLength = textBoxRightTop.SelectionLength = textBoxRightBottom.SelectionLength = 0;
        }

        private void OnUpDown(object sender, EventArgs e)
        {
            // Suspend layout changes until all splitter properties have been updated
            kiwiSplitContainerVertical.SuspendLayout();

            // Is the bottom right header group currently expanded?
            if (kiwiSplitContainerVertical.FixedPanel == FixedPanel.None)
            {
                // Make the bottom panel of the splitter fixed in size
                kiwiSplitContainerVertical.FixedPanel = FixedPanel.Panel2;
                kiwiSplitContainerVertical.IsSplitterFixed = true;

                // Remember the current height of the header group (to restore later)
                _heightUpDown = kiwiHeaderGroupRightBottom.Height;

                // Find the new height to use for the header group
                int newHeight = kiwiHeaderGroupRightBottom.PreferredSize.Height;

                // Make the header group fixed to the new height
                kiwiSplitContainerVertical.Panel2MinSize = newHeight;
                kiwiSplitContainerVertical.SplitterDistance = kiwiSplitContainerVertical.Height;
            }
            else
            {
                // Make the bottom panel not-fixed in size anymore
                kiwiSplitContainerVertical.FixedPanel = FixedPanel.None;
                kiwiSplitContainerVertical.IsSplitterFixed = false;

                // Put back the minimise size to the original
                kiwiSplitContainerVertical.Panel2MinSize = 100;

                // Calculate the correct splitter we want to put back
                kiwiSplitContainerVertical.SplitterDistance = kiwiSplitContainerVertical.Height - _heightUpDown - kiwiSplitContainerVertical.SplitterWidth;
            }

            kiwiSplitContainerVertical.ResumeLayout();
        }

        private void OnLeftRight(object sender, EventArgs e)
        {
            // Suspend layout changes until all splitter properties have been updated
            kiwiSplitContainerHorizontal.SuspendLayout();

            // Is the left header group currently expanded?
            if (kiwiSplitContainerHorizontal.FixedPanel == FixedPanel.None)
            {
                // Make the left panel of the splitter fixed in size
                kiwiSplitContainerHorizontal.FixedPanel = FixedPanel.Panel1;
                kiwiSplitContainerHorizontal.IsSplitterFixed = true;

                // Remember the current height of the header group
                _widthLeftRight = kiwiHeaderGroupLeft.Width;

                // We have not changed the orientation of the header yet, so the width of 
                // the splitter panel is going to be the height of the collapsed header group
                int newWidth = kiwiHeaderGroupLeft.PreferredSize.Height;

                // Make the header group fixed just as the new height
                kiwiSplitContainerHorizontal.Panel1MinSize = newWidth;
                kiwiSplitContainerHorizontal.SplitterDistance = newWidth;

                // Change header to be vertical and button to near edge
                kiwiHeaderGroupLeft.HeaderPositionPrimary = VisualOrientation.Right;
                kiwiHeaderGroupLeft.ButtonSpecs[0].Edge = PaletteRelativeEdgeAlign.Near;
            }
            else
            {
                // Make the bottom panel not-fixed in size anymore
                kiwiSplitContainerHorizontal.FixedPanel = FixedPanel.None;
                kiwiSplitContainerHorizontal.IsSplitterFixed = false;

                // Put back the minimise size to the original
                kiwiSplitContainerHorizontal.Panel1MinSize = 100;

                // Calculate the correct splitter we want to put back
                kiwiSplitContainerHorizontal.SplitterDistance = _widthLeftRight;

                // Change header to be horizontal and button to far edge
                kiwiHeaderGroupLeft.HeaderPositionPrimary = VisualOrientation.Top;
                kiwiHeaderGroupLeft.ButtonSpecs[0].Edge = PaletteRelativeEdgeAlign.Far;
            }

            kiwiSplitContainerHorizontal.ResumeLayout();
        }

        private void UpdateCollapsedSizing()
        {
            // Is the bottom right header group currently collapsed?
            if (kiwiSplitContainerVertical.FixedPanel == FixedPanel.Panel2)
            {
                // Suspend layout changes until all splitter properties have been updated
                kiwiSplitContainerHorizontal.SuspendLayout();

                // Get the new preferred height of the header group and apply it
                int newHeight = kiwiHeaderGroupRightBottom.PreferredSize.Height;
                kiwiSplitContainerVertical.Panel2MinSize = newHeight;
                kiwiSplitContainerVertical.SplitterDistance = kiwiSplitContainerVertical.Height;

                kiwiSplitContainerHorizontal.ResumeLayout();
            }

            // Is the left header group currently collapsed?
            if (kiwiSplitContainerHorizontal.FixedPanel == FixedPanel.Panel1)
            {
                // Suspend layout changes until all splitter properties have been updated
                kiwiSplitContainerVertical.SuspendLayout();

                // Get the new preferred width of the header group and apply it
                int newWidth = kiwiHeaderGroupLeft.PreferredSize.Width;
                kiwiSplitContainerHorizontal.Panel1MinSize = newWidth;
                kiwiSplitContainerHorizontal.SplitterDistance = newWidth;

                kiwiSplitContainerVertical.ResumeLayout();
            }
        }

        private void toolOffice2010_Click(object sender, EventArgs e)
        {
            if (!toolOffice2010.Checked)
            {
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
                toolOffice2010.Checked = menuOffice2010.Checked = true;
                toolOffice2007.Checked = menuOffice2007.Checked = false;
                toolSystem.Checked = menuSystem.Checked = false;
                toolSparkle.Checked = menuSparkle.Checked = false;
                UpdateCollapsedSizing();
            }
        }

        private void toolOffice2007_Click(object sender, EventArgs e)
        {
            if (!toolOffice2007.Checked)
            {
                kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
                toolOffice2010.Checked = menuOffice2010.Checked = false;
                toolOffice2007.Checked = menuOffice2007.Checked = true;
                toolSystem.Checked = menuSystem.Checked = false;
                toolSparkle.Checked = menuSparkle.Checked = false;
                UpdateCollapsedSizing();
            }
        }

        private void toolSystem_Click(object sender, EventArgs e)
        {
            if (!toolSystem.Checked)
            {
                kiwiManager.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
                toolOffice2010.Checked = menuOffice2010.Checked = false;
                toolOffice2007.Checked = menuOffice2007.Checked = false;
                toolSystem.Checked = menuSystem.Checked = true;
                toolSparkle.Checked = menuSparkle.Checked = false;
                UpdateCollapsedSizing();
            }
        }

        private void toolSparkle_Click(object sender, EventArgs e)
        {
            if (!toolSparkle.Checked)
            {
                kiwiManager.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
                toolOffice2010.Checked = menuOffice2010.Checked = false;
                toolOffice2007.Checked = menuOffice2007.Checked = false;
                toolSystem.Checked = menuSystem.Checked = false;
                toolSparkle.Checked = menuSparkle.Checked = true;
                UpdateCollapsedSizing();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
