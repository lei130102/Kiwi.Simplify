
namespace MDI_Ribbon
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
            this.ribbon = new Kiwi.ComponentFactory.Ribbon.KiwiRibbon();
            this.buttonSpecHelp = new Kiwi.ComponentFactory.Toolkit.ButtonSpecAny();
            this.kiwiContextMenuItem1 = new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem();
            this.tabHome = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonTab();
            this.kiwiRibbonGroup2 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroup();
            this.kiwiRibbonGroupTriple2 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupTriple();
            this.buttonNewWindow = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton();
            this.kiwiRibbonGroupSeparator1 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupSeparator();
            this.kiwiRibbonGroupTriple3 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupTriple();
            this.buttonCloseWindow = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton();
            this.buttonCloseAllWindows = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton();
            this.kiwiRibbonGroup1 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroup();
            this.kiwiRibbonGroupTriple4 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupTriple();
            this.buttonCascade = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton();
            this.buttonTileHorizontal = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton();
            this.buttonTileVertical = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton();
            this.kiwiManager1 = new Kiwi.ComponentFactory.Toolkit.KiwiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ButtonSpecs.AddRange(new Kiwi.ComponentFactory.Toolkit.ButtonSpecAny[] {
            this.buttonSpecHelp});
            this.ribbon.Name = "ribbon";
            this.ribbon.QATLocation = Kiwi.ComponentFactory.Ribbon.QATLocation.Hidden;
            this.ribbon.RibbonAppButton.AppButtonMenuItems.AddRange(new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItemBase[] {
            this.kiwiContextMenuItem1});
            this.ribbon.RibbonAppButton.AppButtonShowRecentDocs = false;
            this.ribbon.RibbonTabs.AddRange(new Kiwi.ComponentFactory.Ribbon.KiwiRibbonTab[] {
            this.tabHome});
            this.ribbon.SelectedTab = this.tabHome;
            this.ribbon.Size = new System.Drawing.Size(692, 114);
            this.ribbon.TabIndex = 0;
            // 
            // buttonSpecHelp
            // 
            this.buttonSpecHelp.Image = ((System.Drawing.Image)(resources.GetObject("buttonSpecHelp.Image")));
            this.buttonSpecHelp.Style = Kiwi.ComponentFactory.Toolkit.PaletteButtonStyle.ButtonSpec;
            this.buttonSpecHelp.UniqueName = "06E98F3735BC4B1106E98F3735BC4B11";
            this.buttonSpecHelp.Click += new System.EventHandler(this.buttonSpecHelp_Click);
            // 
            // kiwiContextMenuItem1
            // 
            this.kiwiContextMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("kiwiContextMenuItem1.Image")));
            this.kiwiContextMenuItem1.Text = "E&xit";
            this.kiwiContextMenuItem1.Click += new System.EventHandler(this.appMenu_Click);
            // 
            // tabHome
            // 
            this.tabHome.Groups.AddRange(new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroup[] {
            this.kiwiRibbonGroup2,
            this.kiwiRibbonGroup1});
            this.tabHome.KeyTip = "H";
            this.tabHome.Text = "Home";
            // 
            // kiwiRibbonGroup2
            // 
            this.kiwiRibbonGroup2.DialogBoxLauncher = false;
            this.kiwiRibbonGroup2.Image = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroup2.Image")));
            this.kiwiRibbonGroup2.Items.AddRange(new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupContainer[] {
            this.kiwiRibbonGroupTriple2,
            this.kiwiRibbonGroupSeparator1,
            this.kiwiRibbonGroupTriple3});
            this.kiwiRibbonGroup2.KeyTipGroup = "O";
            this.kiwiRibbonGroup2.TextLine1 = "Operations";
            // 
            // kiwiRibbonGroupTriple2
            // 
            this.kiwiRibbonGroupTriple2.Items.AddRange(new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupItem[] {
            this.buttonNewWindow});
            // 
            // buttonNewWindow
            // 
            this.buttonNewWindow.ImageLarge = ((System.Drawing.Image)(resources.GetObject("buttonNewWindow.ImageLarge")));
            this.buttonNewWindow.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonNewWindow.ImageSmall")));
            this.buttonNewWindow.KeyTip = "N";
            this.buttonNewWindow.TextLine1 = "New";
            this.buttonNewWindow.TextLine2 = "Window";
            this.buttonNewWindow.Click += new System.EventHandler(this.buttonNewWindow_Click);
            // 
            // kiwiRibbonGroupTriple3
            // 
            this.kiwiRibbonGroupTriple3.Items.AddRange(new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupItem[] {
            this.buttonCloseWindow,
            this.buttonCloseAllWindows});
            // 
            // buttonCloseWindow
            // 
            this.buttonCloseWindow.ImageLarge = ((System.Drawing.Image)(resources.GetObject("buttonCloseWindow.ImageLarge")));
            this.buttonCloseWindow.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonCloseWindow.ImageSmall")));
            this.buttonCloseWindow.KeyTip = "X";
            this.buttonCloseWindow.TextLine1 = "Close";
            this.buttonCloseWindow.TextLine2 = "Window";
            this.buttonCloseWindow.Click += new System.EventHandler(this.buttonCloseWindow_Click);
            // 
            // buttonCloseAllWindows
            // 
            this.buttonCloseAllWindows.ImageLarge = ((System.Drawing.Image)(resources.GetObject("buttonCloseAllWindows.ImageLarge")));
            this.buttonCloseAllWindows.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonCloseAllWindows.ImageSmall")));
            this.buttonCloseAllWindows.KeyTip = "A";
            this.buttonCloseAllWindows.TextLine1 = "Close All";
            this.buttonCloseAllWindows.TextLine2 = "Windows";
            this.buttonCloseAllWindows.Click += new System.EventHandler(this.buttonCloseAllWindows_Click);
            // 
            // kiwiRibbonGroup1
            // 
            this.kiwiRibbonGroup1.DialogBoxLauncher = false;
            this.kiwiRibbonGroup1.Image = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroup1.Image")));
            this.kiwiRibbonGroup1.Items.AddRange(new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupContainer[] {
            this.kiwiRibbonGroupTriple4});
            this.kiwiRibbonGroup1.KeyTipGroup = "A";
            this.kiwiRibbonGroup1.TextLine1 = "Arrange";
            // 
            // kiwiRibbonGroupTriple4
            // 
            this.kiwiRibbonGroupTriple4.Items.AddRange(new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupItem[] {
            this.buttonCascade,
            this.buttonTileHorizontal,
            this.buttonTileVertical});
            // 
            // buttonCascade
            // 
            this.buttonCascade.ImageLarge = ((System.Drawing.Image)(resources.GetObject("buttonCascade.ImageLarge")));
            this.buttonCascade.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonCascade.ImageSmall")));
            this.buttonCascade.KeyTip = "C";
            this.buttonCascade.TextLine1 = "Cascade";
            this.buttonCascade.Click += new System.EventHandler(this.buttonCascade_Click);
            // 
            // buttonTileHorizontal
            // 
            this.buttonTileHorizontal.ImageLarge = ((System.Drawing.Image)(resources.GetObject("buttonTileHorizontal.ImageLarge")));
            this.buttonTileHorizontal.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonTileHorizontal.ImageSmall")));
            this.buttonTileHorizontal.KeyTip = "H";
            this.buttonTileHorizontal.TextLine1 = "Tile";
            this.buttonTileHorizontal.TextLine2 = "Horizontal";
            this.buttonTileHorizontal.Click += new System.EventHandler(this.buttonTileHorizontal_Click);
            // 
            // buttonTileVertical
            // 
            this.buttonTileVertical.ImageLarge = ((System.Drawing.Image)(resources.GetObject("buttonTileVertical.ImageLarge")));
            this.buttonTileVertical.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonTileVertical.ImageSmall")));
            this.buttonTileVertical.KeyTip = "V";
            this.buttonTileVertical.TextLine1 = "Tile";
            this.buttonTileVertical.TextLine2 = "Vertical";
            this.buttonTileVertical.Click += new System.EventHandler(this.buttonTileVertical_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 516);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "Form1";
            this.Text = "MDI Ribbon";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Kiwi.ComponentFactory.Ribbon.KiwiRibbon ribbon;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonTab tabHome;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroup kiwiRibbonGroup2;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupTriple kiwiRibbonGroupTriple2;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton buttonNewWindow;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupSeparator kiwiRibbonGroupSeparator1;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupTriple kiwiRibbonGroupTriple3;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton buttonCloseWindow;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton buttonCloseAllWindows;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroup kiwiRibbonGroup1;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupTriple kiwiRibbonGroupTriple4;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton buttonCascade;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton buttonTileHorizontal;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton buttonTileVertical;
        private Kiwi.ComponentFactory.Toolkit.ButtonSpecAny buttonSpecHelp;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem kiwiContextMenuItem1;
        private Kiwi.ComponentFactory.Toolkit.KiwiManager kiwiManager1;
    }
}

