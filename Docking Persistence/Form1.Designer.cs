
namespace Docking_Persistence
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kiwiDockingManager = new Kiwi.ComponentFactory.Docking.KiwiDockingManager();
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.kiwiRibbon = new Kiwi.ComponentFactory.Ribbon.KiwiRibbon();
            this.kiwiContextMenuItem1 = new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem();
            this.tabPersistence = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonTab();
            this.kiwiRibbonGroup1 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroup();
            this.kiwiRibbonGroupTriple1 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupTriple();
            this.buttonSaveArray1 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton();
            this.buttonSaveArray2 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton();
            this.buttonSaveArray3 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton();
            this.kiwiRibbonGroupSeparator1 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupSeparator();
            this.kiwiRibbonGroupTriple3 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupTriple();
            this.buttonLoadArray1 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton();
            this.buttonLoadArray2 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton();
            this.buttonLoadArray3 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton();
            this.kiwiRibbonGroup2 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroup();
            this.kiwiRibbonGroupTriple2 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupTriple();
            this.buttonSaveFile = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton();
            this.kiwiRibbonGroupSeparator2 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupSeparator();
            this.kiwiRibbonGroupTriple4 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupTriple();
            this.buttonLoadFile = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton();
            this.kiwiRibbonGroup3 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroup();
            this.kiwiRibbonGroupTriple5 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupTriple();
            this.buttonHideAll = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton();
            this.buttonShowAll = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton();
            this.kiwiPanel = new Kiwi.ComponentFactory.Toolkit.KiwiPanel();
            this.kiwiDockableWorkspace = new Kiwi.ComponentFactory.Docking.KiwiDockableWorkspace();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.kiwiManager = new Kiwi.ComponentFactory.Toolkit.KiwiManager(this.components);
            this.kiwiPalette1 = new Kiwi.ComponentFactory.Toolkit.KiwiPalette(this.components);
            this.kiwiRibbonTab1 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonTab();
            this.kiwiRibbonTab2 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonTab();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiRibbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPanel)).BeginInit();
            this.kiwiPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiDockableWorkspace)).BeginInit();
            this.SuspendLayout();
            // 
            // kiwiDockingManager
            // 
            this.kiwiDockingManager.GlobalSaving += new System.EventHandler<Kiwi.ComponentFactory.Docking.DockGlobalSavingEventArgs>(this.kiwiDockingManager_GlobalSaving);
            this.kiwiDockingManager.GlobalLoading += new System.EventHandler<Kiwi.ComponentFactory.Docking.DockGlobalLoadingEventArgs>(this.kiwiDockingManager_GlobalLoading);
            this.kiwiDockingManager.PageSaving += new System.EventHandler<Kiwi.ComponentFactory.Docking.DockPageSavingEventArgs>(this.kiwiDockingManager_PageSaving);
            this.kiwiDockingManager.PageLoading += new System.EventHandler<Kiwi.ComponentFactory.Docking.DockPageLoadingEventArgs>(this.kiwiDockingManager_PageLoading);
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "document_plain.png");
            this.imageListSmall.Images.SetKeyName(1, "preferences.png");
            this.imageListSmall.Images.SetKeyName(2, "information2.png");
            // 
            // kiwiRibbon
            // 
            this.kiwiRibbon.InDesignHelperMode = true;
            this.kiwiRibbon.Name = "kiwiRibbon";
            this.kiwiRibbon.RibbonAppButton.AppButtonImage = ((System.Drawing.Image)(resources.GetObject("kiwiRibbon.RibbonAppButton.AppButtonImage")));
            this.kiwiRibbon.RibbonAppButton.AppButtonMenuItems.AddRange(new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItemBase[] {
            this.kiwiContextMenuItem1});
            this.kiwiRibbon.RibbonTabs.AddRange(new Kiwi.ComponentFactory.Ribbon.KiwiRibbonTab[] {
            this.tabPersistence,
            this.kiwiRibbonTab1,
            this.kiwiRibbonTab2});
            this.kiwiRibbon.SelectedTab = this.tabPersistence;
            this.kiwiRibbon.Size = new System.Drawing.Size(784, 115);
            this.kiwiRibbon.TabIndex = 0;
            // 
            // kiwiContextMenuItem1
            // 
            this.kiwiContextMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("kiwiContextMenuItem1.Image")));
            this.kiwiContextMenuItem1.Text = "E&xit";
            this.kiwiContextMenuItem1.Click += new System.EventHandler(this.kiwiContextMenuItem1_Click);
            // 
            // tabPersistence
            // 
            this.tabPersistence.Groups.AddRange(new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroup[] {
            this.kiwiRibbonGroup1,
            this.kiwiRibbonGroup2,
            this.kiwiRibbonGroup3});
            this.tabPersistence.Text = "Persistence";
            // 
            // kiwiRibbonGroup1
            // 
            this.kiwiRibbonGroup1.DialogBoxLauncher = false;
            this.kiwiRibbonGroup1.Image = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroup1.Image")));
            this.kiwiRibbonGroup1.Items.AddRange(new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupContainer[] {
            this.kiwiRibbonGroupTriple1,
            this.kiwiRibbonGroupSeparator1,
            this.kiwiRibbonGroupTriple3});
            this.kiwiRibbonGroup1.KeyTipGroup = "A";
            this.kiwiRibbonGroup1.TextLine1 = "Array Persist";
            // 
            // kiwiRibbonGroupTriple1
            // 
            this.kiwiRibbonGroupTriple1.Items.AddRange(new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupItem[] {
            this.buttonSaveArray1,
            this.buttonSaveArray2,
            this.buttonSaveArray3});
            this.kiwiRibbonGroupTriple1.MaximumSize = Kiwi.ComponentFactory.Ribbon.GroupItemSize.Medium;
            this.kiwiRibbonGroupTriple1.MinimumSize = Kiwi.ComponentFactory.Ribbon.GroupItemSize.Medium;
            // 
            // buttonSaveArray1
            // 
            this.buttonSaveArray1.ImageLarge = ((System.Drawing.Image)(resources.GetObject("buttonSaveArray1.ImageLarge")));
            this.buttonSaveArray1.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonSaveArray1.ImageSmall")));
            this.buttonSaveArray1.KeyTip = "SA1";
            this.buttonSaveArray1.TextLine1 = "Save Array 1";
            this.buttonSaveArray1.Click += new System.EventHandler(this.buttonSaveArray1_Click);
            // 
            // buttonSaveArray2
            // 
            this.buttonSaveArray2.ImageLarge = ((System.Drawing.Image)(resources.GetObject("buttonSaveArray2.ImageLarge")));
            this.buttonSaveArray2.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonSaveArray2.ImageSmall")));
            this.buttonSaveArray2.KeyTip = "SA2";
            this.buttonSaveArray2.TextLine1 = "Save Array 2";
            this.buttonSaveArray2.Click += new System.EventHandler(this.buttonSaveArray2_Click);
            // 
            // buttonSaveArray3
            // 
            this.buttonSaveArray3.ImageLarge = ((System.Drawing.Image)(resources.GetObject("buttonSaveArray3.ImageLarge")));
            this.buttonSaveArray3.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonSaveArray3.ImageSmall")));
            this.buttonSaveArray3.KeyTip = "SA3";
            this.buttonSaveArray3.TextLine1 = "Save Array 3";
            this.buttonSaveArray3.Click += new System.EventHandler(this.buttonSaveArray3_Click);
            // 
            // kiwiRibbonGroupTriple3
            // 
            this.kiwiRibbonGroupTriple3.Items.AddRange(new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupItem[] {
            this.buttonLoadArray1,
            this.buttonLoadArray2,
            this.buttonLoadArray3});
            this.kiwiRibbonGroupTriple3.MaximumSize = Kiwi.ComponentFactory.Ribbon.GroupItemSize.Medium;
            this.kiwiRibbonGroupTriple3.MinimumSize = Kiwi.ComponentFactory.Ribbon.GroupItemSize.Medium;
            // 
            // buttonLoadArray1
            // 
            this.buttonLoadArray1.Enabled = false;
            this.buttonLoadArray1.ImageLarge = ((System.Drawing.Image)(resources.GetObject("buttonLoadArray1.ImageLarge")));
            this.buttonLoadArray1.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonLoadArray1.ImageSmall")));
            this.buttonLoadArray1.KeyTip = "LA1";
            this.buttonLoadArray1.TextLine1 = "Load Array 1";
            this.buttonLoadArray1.Click += new System.EventHandler(this.buttonLoadArray1_Click);
            // 
            // buttonLoadArray2
            // 
            this.buttonLoadArray2.Enabled = false;
            this.buttonLoadArray2.ImageLarge = ((System.Drawing.Image)(resources.GetObject("buttonLoadArray2.ImageLarge")));
            this.buttonLoadArray2.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonLoadArray2.ImageSmall")));
            this.buttonLoadArray2.KeyTip = "LA2";
            this.buttonLoadArray2.TextLine1 = "Load Array 2";
            this.buttonLoadArray2.Click += new System.EventHandler(this.buttonLoadArray2_Click);
            // 
            // buttonLoadArray3
            // 
            this.buttonLoadArray3.Enabled = false;
            this.buttonLoadArray3.ImageLarge = ((System.Drawing.Image)(resources.GetObject("buttonLoadArray3.ImageLarge")));
            this.buttonLoadArray3.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonLoadArray3.ImageSmall")));
            this.buttonLoadArray3.KeyTip = "LA3";
            this.buttonLoadArray3.TextLine1 = "Load Array 3";
            this.buttonLoadArray3.Click += new System.EventHandler(this.buttonLoadArray3_Click);
            // 
            // kiwiRibbonGroup2
            // 
            this.kiwiRibbonGroup2.DialogBoxLauncher = false;
            this.kiwiRibbonGroup2.Image = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroup2.Image")));
            this.kiwiRibbonGroup2.Items.AddRange(new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupContainer[] {
            this.kiwiRibbonGroupTriple2,
            this.kiwiRibbonGroupSeparator2,
            this.kiwiRibbonGroupTriple4});
            this.kiwiRibbonGroup2.TextLine1 = "File Persist";
            // 
            // kiwiRibbonGroupTriple2
            // 
            this.kiwiRibbonGroupTriple2.Items.AddRange(new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupItem[] {
            this.buttonSaveFile});
            this.kiwiRibbonGroupTriple2.MinimumSize = Kiwi.ComponentFactory.Ribbon.GroupItemSize.Large;
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.ImageLarge = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile.ImageLarge")));
            this.buttonSaveFile.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile.ImageSmall")));
            this.buttonSaveFile.KeyTip = "SF";
            this.buttonSaveFile.TextLine1 = "Save";
            this.buttonSaveFile.TextLine2 = "File";
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // kiwiRibbonGroupTriple4
            // 
            this.kiwiRibbonGroupTriple4.Items.AddRange(new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupItem[] {
            this.buttonLoadFile});
            this.kiwiRibbonGroupTriple4.MinimumSize = Kiwi.ComponentFactory.Ribbon.GroupItemSize.Large;
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.ImageLarge = ((System.Drawing.Image)(resources.GetObject("buttonLoadFile.ImageLarge")));
            this.buttonLoadFile.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonLoadFile.ImageSmall")));
            this.buttonLoadFile.KeyTip = "LF";
            this.buttonLoadFile.TextLine1 = "Load";
            this.buttonLoadFile.TextLine2 = "File";
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
            // 
            // kiwiRibbonGroup3
            // 
            this.kiwiRibbonGroup3.DialogBoxLauncher = false;
            this.kiwiRibbonGroup3.Image = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroup3.Image")));
            this.kiwiRibbonGroup3.Items.AddRange(new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupContainer[] {
            this.kiwiRibbonGroupTriple5});
            this.kiwiRibbonGroup3.TextLine1 = "Visibility";
            // 
            // kiwiRibbonGroupTriple5
            // 
            this.kiwiRibbonGroupTriple5.Items.AddRange(new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupItem[] {
            this.buttonHideAll,
            this.buttonShowAll});
            // 
            // buttonHideAll
            // 
            this.buttonHideAll.ImageLarge = ((System.Drawing.Image)(resources.GetObject("buttonHideAll.ImageLarge")));
            this.buttonHideAll.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonHideAll.ImageSmall")));
            this.buttonHideAll.KeyTip = "VH";
            this.buttonHideAll.TextLine1 = "Hide";
            this.buttonHideAll.TextLine2 = "All";
            this.buttonHideAll.Click += new System.EventHandler(this.buttonHideAll_Click);
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.ImageLarge = ((System.Drawing.Image)(resources.GetObject("buttonShowAll.ImageLarge")));
            this.buttonShowAll.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonShowAll.ImageSmall")));
            this.buttonShowAll.KeyTip = "VS";
            this.buttonShowAll.TextLine1 = "Show";
            this.buttonShowAll.TextLine2 = "All";
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // kiwiPanel
            // 
            this.kiwiPanel.Controls.Add(this.kiwiDockableWorkspace);
            this.kiwiPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiwiPanel.Location = new System.Drawing.Point(0, 115);
            this.kiwiPanel.Name = "kiwiPanel";
            this.kiwiPanel.Padding = new System.Windows.Forms.Padding(3);
            this.kiwiPanel.Size = new System.Drawing.Size(784, 449);
            this.kiwiPanel.TabIndex = 1;
            // 
            // kiwiDockableWorkspace
            // 
            this.kiwiDockableWorkspace.AutoHiddenHost = false;
            this.kiwiDockableWorkspace.CompactFlags = ((Kiwi.ComponentFactory.Workspace.CompactFlags)(((Kiwi.ComponentFactory.Workspace.CompactFlags.RemoveEmptyCells | Kiwi.ComponentFactory.Workspace.CompactFlags.RemoveEmptySequences)
                  | Kiwi.ComponentFactory.Workspace.CompactFlags.PromoteLeafs)));
            this.kiwiDockableWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiwiDockableWorkspace.Location = new System.Drawing.Point(3, 3);
            this.kiwiDockableWorkspace.Name = "kiwiDockableWorkspace";
            // 
            // 
            // 
            this.kiwiDockableWorkspace.Root.UniqueName = "5462F66039D342065462F66039D34206";
            this.kiwiDockableWorkspace.Root.WorkspaceControl = this.kiwiDockableWorkspace;
            this.kiwiDockableWorkspace.ShowMaximizeButton = false;
            this.kiwiDockableWorkspace.Size = new System.Drawing.Size(778, 443);
            this.kiwiDockableWorkspace.TabIndex = 0;
            this.kiwiDockableWorkspace.TabStop = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "xml";
            this.openFileDialog.FileName = "Config.xml";
            this.openFileDialog.Filter = "Xml Files|*.xml|All Files|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "xml";
            this.saveFileDialog.FileName = "Config.xml";
            this.saveFileDialog.Filter = "Xml Files|*.xml|All Files|*.*";
            this.saveFileDialog.InitialDirectory = "c:\\";
            // 
            // kiwiManager
            // 
            this.kiwiManager.GlobalPaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteModeManager.SparklePurple;
            // 
            // kiwiPalette1
            // 
            this.kiwiPalette1.AllowFormChrome = Kiwi.ComponentFactory.Toolkit.InheritBool.True;
            this.kiwiPalette1.BasePaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2010Black;
            this.kiwiPalette1.BaseRenderMode = Kiwi.ComponentFactory.Toolkit.RendererMode.Professional;
            this.kiwiPalette1.ControlStyles.ControlCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.kiwiPalette1.GridStyles.GridCommon.StateCommon.Background.Color1 = System.Drawing.Color.Silver;
            this.kiwiPalette1.GridStyles.GridCommon.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kiwiPalette1.GridStyles.GridCommon.StateCommon.BackStyle = Kiwi.ComponentFactory.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kiwiPalette1.GridStyles.GridCommon.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            // 
            // Form1
            // 
            this.AllowButtonSpecToolTips = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 564);
            this.Controls.Add(this.kiwiPanel);
            this.Controls.Add(this.kiwiRibbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2010Black;
            this.Text = "Docking Persistence";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiRibbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPanel)).EndInit();
            this.kiwiPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiDockableWorkspace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Kiwi.ComponentFactory.Docking.KiwiDockingManager kiwiDockingManager;
        private System.Windows.Forms.ImageList imageListSmall;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbon kiwiRibbon;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonTab tabPersistence;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroup kiwiRibbonGroup1;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupTriple kiwiRibbonGroupTriple1;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton buttonSaveArray1;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton buttonSaveArray2;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupSeparator kiwiRibbonGroupSeparator1;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupTriple kiwiRibbonGroupTriple2;
        private Kiwi.ComponentFactory.Toolkit.KiwiPanel kiwiPanel;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton buttonSaveArray3;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroup kiwiRibbonGroup2;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupTriple kiwiRibbonGroupTriple3;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton buttonLoadArray1;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton buttonLoadArray2;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton buttonLoadArray3;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupSeparator kiwiRibbonGroupSeparator2;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupTriple kiwiRibbonGroupTriple4;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton buttonLoadFile;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroup kiwiRibbonGroup3;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupTriple kiwiRibbonGroupTriple5;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton buttonHideAll;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton buttonShowAll;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem kiwiContextMenuItem1;
        private Kiwi.ComponentFactory.Docking.KiwiDockableWorkspace kiwiDockableWorkspace;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton buttonSaveFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private Kiwi.ComponentFactory.Toolkit.KiwiManager kiwiManager;
        private Kiwi.ComponentFactory.Toolkit.KiwiPalette kiwiPalette1;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonTab kiwiRibbonTab1;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonTab kiwiRibbonTab2;
    }
}

