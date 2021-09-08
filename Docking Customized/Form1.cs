using Kiwi.ComponentFactory.Docking;
using Kiwi.ComponentFactory.Navigator;
using Kiwi.ComponentFactory.Ribbon;
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

namespace Docking_Customized
{
    public partial class Form1 : KiwiForm
    {
        private int _count = 1;
        private Random _random = new Random(DateTime.Now.Millisecond);
        private NavigatorMode _mode = NavigatorMode.HeaderBarCheckButtonHeaderGroup;
        private PaletteButtonSpecStyle[] _buttonSpecStyles = new PaletteButtonSpecStyle[]{ PaletteButtonSpecStyle.ArrowDown, PaletteButtonSpecStyle.ArrowLeft,
                                                                                           PaletteButtonSpecStyle.ArrowRight, PaletteButtonSpecStyle.ArrowUp,
                                                                                           PaletteButtonSpecStyle.Close, PaletteButtonSpecStyle.Context,
                                                                                           PaletteButtonSpecStyle.DropDown };

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
            kiwiDockingManager.AddDockspace("Control", DockingEdge.Right, new KiwiPage[] { NewPropertyGrid(), NewInput(), NewPropertyGrid(), NewInput() });
            kiwiDockingManager.AddDockspace("Control", DockingEdge.Bottom, new KiwiPage[] { NewInput(), NewPropertyGrid(), NewInput(), NewPropertyGrid() });

            UpdateModeButtons();
        }

        private void kiwiDockingManager_DockspaceAdding(object sender, DockspaceEventArgs e)
        {
            // Set all new dockspace controls to a larger than default size
            e.DockspaceControl.Size = new Size(250, 250);
        }

        private void kiwiDockingManager_FloatingWindowAdding(object sender, FloatingWindowEventArgs e)
        {
            // Set all new floating windows to a larger than default size
            e.FloatingWindow.ClientSize = new Size(400, 400);
        }

        private void kiwiDockingManager_DockspaceCellAdding(object sender, DockspaceCellEventArgs e)
        {
            Console.WriteLine("DockspaceCellAdding");

            // Set the correct appearance of the dockspace cell based on current settings
            UpdateCell(e.CellControl);
        }

        private void kiwiDockingManager_FloatspaceCellAdding(object sender, FloatspaceCellEventArgs e)
        {
            // Set the correct appearance of the floatspace cell based on current settings
            UpdateCell(e.CellControl);
        }

        private void kiwiDockingManager_ShowPageContextMenu(object sender, ContextPageEventArgs e)
        {
            // Create a set of custom menu items
            KiwiContextMenuItems customItems = new KiwiContextMenuItems();
            KiwiContextMenuSeparator customSeparator = new KiwiContextMenuSeparator();
            KiwiContextMenuItem customItem1 = new KiwiContextMenuItem("Custom Item 1", new EventHandler(OnCustomMenuItem));
            KiwiContextMenuItem customItem2 = new KiwiContextMenuItem("Custom Item 2", new EventHandler(OnCustomMenuItem));
            customItem1.Tag = e.Page;
            customItem2.Tag = e.Page;
            customItems.Items.AddRange(new KiwiContextMenuItemBase[] { customSeparator, customItem1, customItem2 });

            // Add set of custom items into the provided menu
            e.KiwiContextMenu.Items.Add(customItems);
        }

        private void kiwiDockingManager_ShowWorkspacePageContextMenu(object sender, ContextPageEventArgs e)
        {
            // Create a set of custom menu items
            KiwiContextMenuItems customItems = new KiwiContextMenuItems();
            KiwiContextMenuSeparator customSeparator = new KiwiContextMenuSeparator();
            KiwiContextMenuItem customItem1 = new KiwiContextMenuItem("Custom Item 3", new EventHandler(OnCustomMenuItem));
            KiwiContextMenuItem customItem2 = new KiwiContextMenuItem("Custom Item 4", new EventHandler(OnCustomMenuItem));
            customItem1.Tag = e.Page;
            customItem2.Tag = e.Page;
            customItems.Items.AddRange(new KiwiContextMenuItemBase[] { customSeparator, customItem1, customItem2 });

            // Add set of custom items into the provided menu
            e.KiwiContextMenu.Items.Add(customItems);
        }

        private void OnCustomMenuItem(object sender, EventArgs e)
        {
            KiwiContextMenuItem menuItem = (KiwiContextMenuItem)sender;
            KiwiPage page = (KiwiPage)menuItem.Tag;
            MessageBox.Show("Clicked menu option '" + menuItem.Text + "' for the page '" + page.Text + "'.", "Page Context Menu");
        }

        private void colorsRandom_Click(object sender, EventArgs e)
        {
            foreach (KiwiPage page in kiwiDockingManager.Pages)
            {
                page.StateNormal.Tab.Content.ShortText.Color1 = RandomColor();
                page.StateNormal.Tab.Back.Color1 = RandomColor();
                page.StateNormal.Tab.Back.ColorStyle = PaletteColorStyle.Solid;

                page.StateNormal.RibbonTab.TabDraw.TextColor = RandomColor();
                page.StateNormal.RibbonTab.TabDraw.BackColor1 = RandomColor();
                page.StateNormal.RibbonTab.TabDraw.BackColor2 = RandomColor();

                page.StateNormal.CheckButton.Content.ShortText.Color1 = RandomColor();
                page.StateNormal.CheckButton.Back.Color1 = RandomColor();
                page.StateNormal.CheckButton.Back.ColorStyle = PaletteColorStyle.Solid;
            }
        }

        private void colorsReset_Click(object sender, EventArgs e)
        {
            foreach (KiwiPage page in kiwiDockingManager.Pages)
            {
                page.StateNormal.Tab.Content.ShortText.Color1 = Color.Empty;
                page.StateNormal.Tab.Back.Color1 = Color.Empty;
                page.StateNormal.Tab.Back.ColorStyle = PaletteColorStyle.Inherit;

                page.StateNormal.RibbonTab.TabDraw.TextColor = Color.Empty;
                page.StateNormal.RibbonTab.TabDraw.BackColor1 = Color.Empty;
                page.StateNormal.RibbonTab.TabDraw.BackColor2 = Color.Empty;

                page.StateNormal.CheckButton.Content.ShortText.Color1 = Color.Empty;
                page.StateNormal.CheckButton.Back.Color1 = Color.Empty;
                page.StateNormal.CheckButton.Back.ColorStyle = PaletteColorStyle.Inherit;
            }
        }

        private void buttonSpecsAdd_Click(object sender, EventArgs e)
        {
            foreach (KiwiPage page in kiwiDockingManager.Pages)
            {
                // Create a button spec and make it a random style so we get a random image
                ButtonSpecAny bs = new ButtonSpecAny();
                bs.Type = _buttonSpecStyles[_random.Next(_buttonSpecStyles.Length)];
                page.ButtonSpecs.Add(bs);
            }
        }

        private void buttonSpecsClear_Click(object sender, EventArgs e)
        {
            foreach (KiwiPage page in kiwiDockingManager.Pages)
                page.ButtonSpecs.Clear();
        }

        private void kiwiRibbonModeButton_Click(object sender, EventArgs e)
        {
            // Extract the navigator mode from the tag field of the ribbon button
            KiwiRibbonGroupButton button = (KiwiRibbonGroupButton)sender;
            _mode = (NavigatorMode)Enum.Parse(typeof(NavigatorMode), (string)button.Tag);

            UpdateModeButtons();
            UpdateAllCells();
        }

        private void UpdateModeButtons()
        {
            modeHeaderGroupTab.Checked = (_mode == NavigatorMode.HeaderGroupTab);
            modeHeaderBarHeaderGroup.Checked = (_mode == NavigatorMode.HeaderBarCheckButtonHeaderGroup);
            modeHeaderBarGroup.Checked = (_mode == NavigatorMode.HeaderBarCheckButtonGroup);
            modeTabGroup.Checked = (_mode == NavigatorMode.BarTabGroup);
            modeBarGroupInside.Checked = (_mode == NavigatorMode.BarCheckButtonGroupInside);
            modeBarGroupOutside.Checked = (_mode == NavigatorMode.BarCheckButtonGroupOutside);
            modeBarRibbonTabGroup.Checked = (_mode == NavigatorMode.BarRibbonTabGroup);
            modeStackGroup.Checked = (_mode == NavigatorMode.StackCheckButtonGroup);
            modeStackHeaderGroup.Checked = (_mode == NavigatorMode.StackCheckButtonHeaderGroup);
        }

        private void UpdateAllCells()
        {
            foreach (KiwiWorkspaceCell cell in kiwiDockingManager.CellsDocked)
                UpdateCell(cell);

            foreach (KiwiWorkspaceCell cell in kiwiDockingManager.CellsFloating)
                UpdateCell(cell);
        }

        private void UpdateCell(KiwiWorkspaceCell cell)
        {
            cell.NavigatorMode = _mode;
        }

        private Color RandomColor()
        {
            return Color.FromArgb(_random.Next(255), _random.Next(255), _random.Next(255));
        }
    }
}
