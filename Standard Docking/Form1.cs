using Kiwi.ComponentFactory.Docking;
using Kiwi.ComponentFactory.Navigator;
using Kiwi.ComponentFactory.Toolkit;
using Kiwi.ComponentFactory.Workspace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Standard_Docking
{
    public partial class Form1 : KiwiForm
    {
        private int _count = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private KiwiPage NewDocument()
        {
            KiwiPage page = NewPage("Document ", 0, new ContentDocument());

            // Document pages cannot be docked or auto hidden
            page.ClearFlags(KiwiPageFlags.DockingAllowAutoHidden | KiwiPageFlags.DockingAllowDocked);

            return page;
        }

        private KiwiPage NewInput()
        {
            return NewPage("Input ", 1, new ContentInput());
        }

        private KiwiPage NewPropertyGrid()
        {
            return NewPage("Properties ", 2, new ContentPropertyGrid());
        }

        private KiwiPage NewPage(string name, int image, Control content)
        {
            // Create new page with title and image
            KiwiPage p = new KiwiPage();
            p.Text = name + _count.ToString();
            p.TextTitle = name + _count.ToString();
            p.TextDescription = name + _count.ToString();
            p.ImageSmall = imageListSmall.Images[image];

            // Add the control for display inside the page
            content.Dock = DockStyle.Fill;
            p.Controls.Add(content);

            _count++;
            return p;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Setup docking functionality
            KiwiDockingWorkspace w = kiwiDockingManager.ManageWorkspace(kiwiDockableWorkspace);
            kiwiDockingManager.ManageControl(kiwiPanel, w);
            kiwiDockingManager.ManageFloating(this);

            // Add initial docking pages
            kiwiDockingManager.AddToWorkspace("Workspace", new KiwiPage[] { NewDocument(), NewDocument() });
            kiwiDockingManager.AddDockspace("Control", DockingEdge.Right, new KiwiPage[] { NewPropertyGrid(), NewInput() });
            kiwiDockingManager.AddDockspace("Control", DockingEdge.Bottom, new KiwiPage[] { NewInput(), NewPropertyGrid() });

            // Set correct initial ribbon palette buttons
            UpdatePaletteButtons();
        }

        private void buttonDocumentSingle_Click(object sender, EventArgs e)
        {
            // Get access to current active cell or create new cell if none are present
            KiwiWorkspaceCell cell = kiwiDockableWorkspace.ActiveCell;
            if (cell == null)
            {
                cell = new KiwiWorkspaceCell();
                kiwiDockableWorkspace.Root.Children.Add(cell);
            }

            // Create new document to be added into workspace
            KiwiPage page = NewDocument();
            cell.Pages.Add(page);

            // Make the new page the selected page
            cell.SelectedPage = page;
        }

        private void buttonDocumentTabbed_Click(object sender, EventArgs e)
        {
            // Add a new cell with three pages into the root sequence of the workspace
            KiwiWorkspaceCell cell = new KiwiWorkspaceCell();
            cell.Pages.AddRange(new KiwiPage[] { NewDocument(), NewDocument(), NewDocument() });
            kiwiDockableWorkspace.Root.Children.Add(cell);
        }

        private void buttonFloatingSingle_Click(object sender, EventArgs e)
        {
            // Add a new floating window with a single page
            kiwiDockingManager.AddFloatingWindow("Floating", new KiwiPage[] { NewInput() });
        }

        private void buttonFloatingTabbed_Click(object sender, EventArgs e)
        {
            // Add a new floating window with two pages
            kiwiDockingManager.AddFloatingWindow("Floating", new KiwiPage[] { NewPropertyGrid(), NewDocument() });
        }

        private void buttonFloatingComplex_Click(object sender, EventArgs e)
        {
            // Add single page to a new floating window
            KiwiDockingFloatingWindow window = kiwiDockingManager.AddFloatingWindow("Floating",
                                                                                          new KiwiPage[] { NewInput() },
                                                                                          new Size(500, 400));

            // Create a sequence that contains two cells, with a page in each cell
            KiwiWorkspaceSequence seq = new KiwiWorkspaceSequence(Orientation.Vertical);
            KiwiWorkspaceCell cell1 = new KiwiWorkspaceCell();
            KiwiWorkspaceCell cell2 = new KiwiWorkspaceCell();
            seq.Children.AddRange(new Component[] { cell1, cell2 });
            cell1.Pages.Add(NewPropertyGrid());
            cell2.Pages.Add(NewDocument());

            // Add new sequence into the floating window
            window.FloatspaceElement.FloatspaceControl.Root.Children.Add(seq);
        }

        private void buttonLeftAutoHidden_Click(object sender, EventArgs e)
        {
            // Add new auto hidden group to left edge of the panel
            kiwiDockingManager.AddAutoHiddenGroup("Control",
                                                     DockingEdge.Left,
                                                     new KiwiPage[] { NewInput(), NewPropertyGrid() });
        }

        private void buttonRightAutoHidden_Click(object sender, EventArgs e)
        {
            // Add new auto hidden group to right edge of the panel
            kiwiDockingManager.AddAutoHiddenGroup("Control",
                                                     DockingEdge.Right,
                                                     new KiwiPage[] { NewInput(), NewPropertyGrid() });
        }

        private void buttonBottomAutoHidden_Click(object sender, EventArgs e)
        {
            // Add new auto hidden group to bottom edge of the panel
            kiwiDockingManager.AddAutoHiddenGroup("Control",
                                                     DockingEdge.Bottom,
                                                     new KiwiPage[] { NewInput(), NewPropertyGrid(), NewDocument() });
        }

        private void buttonLeftDockedSingle_Click(object sender, EventArgs e)
        {
            // Add page to left edge of the panel
            kiwiDockingManager.AddDockspace("Control",
                                               DockingEdge.Left,
                                               new KiwiPage[] { NewInput() });
        }

        private void buttonLeftDockedTabbed_Click(object sender, EventArgs e)
        {
            // Add three tabbed pages to left edge of the panel
            kiwiDockingManager.AddDockspace("Control",
                                               DockingEdge.Left,
                                               new KiwiPage[] { NewInput(), NewPropertyGrid(), NewDocument() });
        }

        private void buttonLeftDockedStack_Click(object sender, EventArgs e)
        {
            // Add three vertical-stacked pages to left edge of the panel
            kiwiDockingManager.AddDockspace("Control",
                                               DockingEdge.Left,
                                               new KiwiPage[] { NewDocument() },
                                               new KiwiPage[] { NewDocument() },
                                               new KiwiPage[] { NewDocument() });
        }

        private void buttonRightDockedSingle_Click(object sender, EventArgs e)
        {
            // Add page to right edge of the panel
            kiwiDockingManager.AddDockspace("Control",
                                               DockingEdge.Right,
                                               new KiwiPage[] { NewInput() });
        }

        private void buttonTopDockedTabbed_Click(object sender, EventArgs e)
        {
            // Add three tabbed pages to top edge of the panel
            kiwiDockingManager.AddDockspace("Control",
                                               DockingEdge.Top,
                                               new KiwiPage[] { NewInput(), NewPropertyGrid(), NewDocument() });
        }

        private void buttonBottomDockedStack_Click(object sender, EventArgs e)
        {
            // Add three horizontal-stacked pages to bottom edge of the panel
            kiwiDockingManager.AddDockspace("Control",
                                               DockingEdge.Bottom,
                                               new KiwiPage[] { NewDocument() },
                                               new KiwiPage[] { NewDocument() },
                                               new KiwiPage[] { NewDocument() });
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            kiwiDockingManager.RemoveAllPages(true);
            kiwiDockingManager.ClearAllStoredPages();
        }

        private void buttonDeleteDocked_Click(object sender, EventArgs e)
        {
            KiwiPage[] pages = kiwiDockingManager.PagesDocked;
            kiwiDockingManager.RemovePages(pages, true);
            kiwiDockingManager.ClearStoredPages(pages);
        }

        private void buttonDeleteAutoHidden_Click(object sender, EventArgs e)
        {
            KiwiPage[] pages = kiwiDockingManager.PagesAutoHidden;
            kiwiDockingManager.RemovePages(pages, true);
            kiwiDockingManager.ClearStoredPages(pages);
        }

        private void buttonDeleteFloating_Click(object sender, EventArgs e)
        {
            KiwiPage[] pages = kiwiDockingManager.PagesFloating;
            kiwiDockingManager.RemovePages(pages, true);
            kiwiDockingManager.ClearStoredPages(pages);
        }

        private void buttonHideAll_Click(object sender, EventArgs e)
        {
            kiwiDockingManager.HideAllPages();
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            kiwiDockingManager.ShowAllPages();
            kiwiDockableWorkspace.ShowAllPages();
        }

        private void button2010Blue_Click(object sender, EventArgs e)
        {
            kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
            UpdatePaletteButtons();
        }

        private void button2010Silver_Click(object sender, EventArgs e)
        {
            kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2010Silver;
            UpdatePaletteButtons();
        }

        private void button2010Black_Click(object sender, EventArgs e)
        {
            kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2010Black;
            UpdatePaletteButtons();
        }

        private void button2007Blue_Click(object sender, EventArgs e)
        {
            kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
            UpdatePaletteButtons();
        }

        private void button2007Silver_Click(object sender, EventArgs e)
        {
            kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2007Silver;
            UpdatePaletteButtons();
        }

        private void button2007Black_Click(object sender, EventArgs e)
        {
            kiwiManager.GlobalPaletteMode = PaletteModeManager.Office2007Black;
            UpdatePaletteButtons();
        }

        private void buttonSparkleBlue_Click(object sender, EventArgs e)
        {
            kiwiManager.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
            UpdatePaletteButtons();
        }

        private void buttonSparkleOrange_Click(object sender, EventArgs e)
        {
            kiwiManager.GlobalPaletteMode = PaletteModeManager.SparkleOrange;
            UpdatePaletteButtons();
        }

        private void buttonSparklePurple_Click(object sender, EventArgs e)
        {
            kiwiManager.GlobalPaletteMode = PaletteModeManager.SparklePurple;
            UpdatePaletteButtons();
        }

        private void buttonSystem_Click(object sender, EventArgs e)
        {
            kiwiManager.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
            UpdatePaletteButtons();
        }

        private void kiwiDockableWorkspace_WorkspaceCellAdding(object sender, WorkspaceCellEventArgs e)
        {
            e.Cell.Button.CloseButtonAction = CloseButtonAction.HidePage;
        }

        private void UpdatePaletteButtons()
        {
            button2010Blue.Checked = (kiwiManager.GlobalPaletteMode == PaletteModeManager.Office2010Blue);
            button2010Silver.Checked = (kiwiManager.GlobalPaletteMode == PaletteModeManager.Office2010Silver);
            button2010Black.Checked = (kiwiManager.GlobalPaletteMode == PaletteModeManager.Office2010Black);
            button2007Blue.Checked = (kiwiManager.GlobalPaletteMode == PaletteModeManager.Office2007Blue);
            button2007Silver.Checked = (kiwiManager.GlobalPaletteMode == PaletteModeManager.Office2007Silver);
            button2007Black.Checked = (kiwiManager.GlobalPaletteMode == PaletteModeManager.Office2007Black);
            buttonSparkleBlue.Checked = (kiwiManager.GlobalPaletteMode == PaletteModeManager.SparkleBlue);
            buttonSparkleOrange.Checked = (kiwiManager.GlobalPaletteMode == PaletteModeManager.SparkleOrange);
            buttonSparklePurple.Checked = (kiwiManager.GlobalPaletteMode == PaletteModeManager.SparklePurple);
            buttonSystem.Checked = (kiwiManager.GlobalPaletteMode == PaletteModeManager.ProfessionalSystem);
        }

        private void ribbonAppButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
