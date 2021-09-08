
namespace Quick_Access_Toolbar
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
            this.kiwiRibbon = new Kiwi.ComponentFactory.Ribbon.KiwiRibbon();
            this.kiwiContextMenuItem1 = new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem();
            this.tabHome = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonTab();
            this.kiwiManager = new Kiwi.ComponentFactory.Toolkit.KiwiManager(this.components);
            this.panelFill = new Kiwi.ComponentFactory.Toolkit.KiwiPanel();
            this.kiwiGroup2 = new Kiwi.ComponentFactory.Toolkit.KiwiGroup();
            this.buttonClear = new Kiwi.ComponentFactory.Toolkit.KiwiButton();
            this.buttonRemove = new Kiwi.ComponentFactory.Toolkit.KiwiButton();
            this.buttonAdd = new Kiwi.ComponentFactory.Toolkit.KiwiButton();
            this.labelQATButtons = new Kiwi.ComponentFactory.Toolkit.KiwiLabel();
            this.kiwiGroup1 = new Kiwi.ComponentFactory.Toolkit.KiwiGroup();
            this.checkButtonDisallowUserChanges = new Kiwi.ComponentFactory.Toolkit.KiwiCheckButton();
            this.checkButtonAllowUserChanges = new Kiwi.ComponentFactory.Toolkit.KiwiCheckButton();
            this.labelQATUserChange = new Kiwi.ComponentFactory.Toolkit.KiwiLabel();
            this.groupQATLocation = new Kiwi.ComponentFactory.Toolkit.KiwiGroup();
            this.checkButtonHidden = new Kiwi.ComponentFactory.Toolkit.KiwiCheckButton();
            this.checkButtonBelow = new Kiwi.ComponentFactory.Toolkit.KiwiCheckButton();
            this.checkButtonAbove = new Kiwi.ComponentFactory.Toolkit.KiwiCheckButton();
            this.labelQATLocation = new Kiwi.ComponentFactory.Toolkit.KiwiLabel();
            this.checkSetQATPosition = new Kiwi.ComponentFactory.Toolkit.KiwiCheckSet(this.components);
            this.checkSetQATUserChange = new Kiwi.ComponentFactory.Toolkit.KiwiCheckSet(this.components);
            this.kiwiCheckButton1 = new Kiwi.ComponentFactory.Toolkit.KiwiCheckButton();
            this.kiwiCheckButton2 = new Kiwi.ComponentFactory.Toolkit.KiwiCheckButton();
            this.kiwiCheckButton3 = new Kiwi.ComponentFactory.Toolkit.KiwiCheckButton();
            this.kiwiLabel1 = new Kiwi.ComponentFactory.Toolkit.KiwiLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiRibbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelFill)).BeginInit();
            this.panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiGroup2.Panel)).BeginInit();
            this.kiwiGroup2.Panel.SuspendLayout();
            this.kiwiGroup2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiGroup1.Panel)).BeginInit();
            this.kiwiGroup1.Panel.SuspendLayout();
            this.kiwiGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupQATLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupQATLocation.Panel)).BeginInit();
            this.groupQATLocation.Panel.SuspendLayout();
            this.groupQATLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // kiwiRibbon
            // 
            this.kiwiRibbon.Name = "kiwiRibbon";
            this.kiwiRibbon.RibbonAppButton.AppButtonMenuItems.AddRange(new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItemBase[] {
            this.kiwiContextMenuItem1});
            this.kiwiRibbon.RibbonAppButton.AppButtonShowRecentDocs = false;
            this.kiwiRibbon.RibbonTabs.AddRange(new Kiwi.ComponentFactory.Ribbon.KiwiRibbonTab[] {
            this.tabHome});
            this.kiwiRibbon.SelectedContext = null;
            this.kiwiRibbon.SelectedTab = this.tabHome;
            this.kiwiRibbon.Size = new System.Drawing.Size(375, 115);
            this.kiwiRibbon.TabIndex = 0;
            // 
            // kiwiContextMenuItem1
            // 
            this.kiwiContextMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("kiwiContextMenuItem1.Image")));
            this.kiwiContextMenuItem1.Text = "E&xit";
            this.kiwiContextMenuItem1.Click += new System.EventHandler(this.appMenu_Click);
            // 
            // tabHome
            // 
            this.tabHome.Tag = null;
            this.tabHome.Text = "Home";
            // 
            // kiwiManager
            // 
            this.kiwiManager.GlobalPaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteModeManager.Office2007Silver;
            // 
            // panelFill
            // 
            this.panelFill.Controls.Add(this.kiwiGroup2);
            this.panelFill.Controls.Add(this.kiwiGroup1);
            this.panelFill.Controls.Add(this.groupQATLocation);
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Location = new System.Drawing.Point(0, 115);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(375, 296);
            this.panelFill.TabIndex = 1;
            // 
            // kiwiGroup2
            // 
            this.kiwiGroup2.GroupBackStyle = Kiwi.ComponentFactory.Toolkit.PaletteBackStyle.PanelAlternate;
            this.kiwiGroup2.Location = new System.Drawing.Point(12, 174);
            this.kiwiGroup2.Name = "kiwiGroup2";
            // 
            // kiwiGroup2.Panel
            // 
            this.kiwiGroup2.Panel.Controls.Add(this.buttonClear);
            this.kiwiGroup2.Panel.Controls.Add(this.buttonRemove);
            this.kiwiGroup2.Panel.Controls.Add(this.buttonAdd);
            this.kiwiGroup2.Panel.Controls.Add(this.labelQATButtons);
            this.kiwiGroup2.Size = new System.Drawing.Size(323, 81);
            this.kiwiGroup2.TabIndex = 7;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(213, 40);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(90, 25);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Values.Text = "Clear";
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(116, 40);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(90, 25);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Values.Text = "Remove";
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(20, 40);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(90, 25);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Values.Text = "Add";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelQATButtons
            // 
            this.labelQATButtons.LabelStyle = Kiwi.ComponentFactory.Toolkit.LabelStyle.TitlePanel;
            this.labelQATButtons.Location = new System.Drawing.Point(4, 4);
            this.labelQATButtons.Name = "labelQATButtons";
            this.labelQATButtons.Size = new System.Drawing.Size(124, 29);
            this.labelQATButtons.TabIndex = 1;
            this.labelQATButtons.Values.Text = "QAT Buttons";
            // 
            // kiwiGroup1
            // 
            this.kiwiGroup1.GroupBackStyle = Kiwi.ComponentFactory.Toolkit.PaletteBackStyle.PanelAlternate;
            this.kiwiGroup1.Location = new System.Drawing.Point(159, 16);
            this.kiwiGroup1.Name = "kiwiGroup1";
            // 
            // kiwiGroup1.Panel
            // 
            this.kiwiGroup1.Panel.Controls.Add(this.checkButtonDisallowUserChanges);
            this.kiwiGroup1.Panel.Controls.Add(this.checkButtonAllowUserChanges);
            this.kiwiGroup1.Panel.Controls.Add(this.labelQATUserChange);
            this.kiwiGroup1.Size = new System.Drawing.Size(176, 142);
            this.kiwiGroup1.TabIndex = 6;
            // 
            // checkButtonDisallowUserChanges
            // 
            this.checkButtonDisallowUserChanges.Location = new System.Drawing.Point(16, 82);
            this.checkButtonDisallowUserChanges.Name = "checkButtonDisallowUserChanges";
            this.checkButtonDisallowUserChanges.Size = new System.Drawing.Size(140, 25);
            this.checkButtonDisallowUserChanges.TabIndex = 3;
            this.checkButtonDisallowUserChanges.Values.Text = "Disallow User Changes";
            // 
            // checkButtonAllowUserChanges
            // 
            this.checkButtonAllowUserChanges.Checked = true;
            this.checkButtonAllowUserChanges.Location = new System.Drawing.Point(16, 51);
            this.checkButtonAllowUserChanges.Name = "checkButtonAllowUserChanges";
            this.checkButtonAllowUserChanges.Size = new System.Drawing.Size(140, 25);
            this.checkButtonAllowUserChanges.TabIndex = 2;
            this.checkButtonAllowUserChanges.Values.Text = "Allow User Changes";
            // 
            // labelQATUserChange
            // 
            this.labelQATUserChange.LabelStyle = Kiwi.ComponentFactory.Toolkit.LabelStyle.TitlePanel;
            this.labelQATUserChange.Location = new System.Drawing.Point(4, 4);
            this.labelQATUserChange.Name = "labelQATUserChange";
            this.labelQATUserChange.Size = new System.Drawing.Size(165, 29);
            this.labelQATUserChange.TabIndex = 1;
            this.labelQATUserChange.Values.Text = "QAT User Change";
            // 
            // groupQATLocation
            // 
            this.groupQATLocation.GroupBackStyle = Kiwi.ComponentFactory.Toolkit.PaletteBackStyle.PanelAlternate;
            this.groupQATLocation.Location = new System.Drawing.Point(12, 16);
            this.groupQATLocation.Name = "groupQATLocation";
            // 
            // groupQATLocation.Panel
            // 
            this.groupQATLocation.Panel.Controls.Add(this.checkButtonHidden);
            this.groupQATLocation.Panel.Controls.Add(this.checkButtonBelow);
            this.groupQATLocation.Panel.Controls.Add(this.checkButtonAbove);
            this.groupQATLocation.Panel.Controls.Add(this.labelQATLocation);
            this.groupQATLocation.Size = new System.Drawing.Size(132, 142);
            this.groupQATLocation.TabIndex = 5;
            // 
            // checkButtonHidden
            // 
            this.checkButtonHidden.Location = new System.Drawing.Point(20, 101);
            this.checkButtonHidden.Name = "checkButtonHidden";
            this.checkButtonHidden.Size = new System.Drawing.Size(90, 25);
            this.checkButtonHidden.TabIndex = 4;
            this.checkButtonHidden.Values.Text = "Hidden";
            // 
            // checkButtonBelow
            // 
            this.checkButtonBelow.Location = new System.Drawing.Point(20, 70);
            this.checkButtonBelow.Name = "checkButtonBelow";
            this.checkButtonBelow.Size = new System.Drawing.Size(90, 25);
            this.checkButtonBelow.TabIndex = 3;
            this.checkButtonBelow.Values.Text = "Below";
            // 
            // checkButtonAbove
            // 
            this.checkButtonAbove.Checked = true;
            this.checkButtonAbove.Location = new System.Drawing.Point(20, 39);
            this.checkButtonAbove.Name = "checkButtonAbove";
            this.checkButtonAbove.Size = new System.Drawing.Size(90, 25);
            this.checkButtonAbove.TabIndex = 2;
            this.checkButtonAbove.Values.Text = "Above";
            // 
            // labelQATLocation
            // 
            this.labelQATLocation.LabelStyle = Kiwi.ComponentFactory.Toolkit.LabelStyle.TitlePanel;
            this.labelQATLocation.Location = new System.Drawing.Point(4, 4);
            this.labelQATLocation.Name = "labelQATLocation";
            this.labelQATLocation.Size = new System.Drawing.Size(130, 29);
            this.labelQATLocation.TabIndex = 1;
            this.labelQATLocation.Values.Text = "QAT Location";
            // 
            // checkSetQATPosition
            // 
            this.checkSetQATPosition.CheckButtons.Add(this.checkButtonAbove);
            this.checkSetQATPosition.CheckButtons.Add(this.checkButtonBelow);
            this.checkSetQATPosition.CheckButtons.Add(this.checkButtonHidden);
            this.checkSetQATPosition.CheckedButton = this.checkButtonAbove;
            this.checkSetQATPosition.CheckedButtonChanged += new System.EventHandler(this.checkSetQATPosition_CheckedButtonChanged);
            // 
            // checkSetQATUserChange
            // 
            this.checkSetQATUserChange.CheckButtons.Add(this.checkButtonDisallowUserChanges);
            this.checkSetQATUserChange.CheckButtons.Add(this.checkButtonAllowUserChanges);
            this.checkSetQATUserChange.CheckedButton = this.checkButtonAllowUserChanges;
            this.checkSetQATUserChange.CheckedButtonChanged += new System.EventHandler(this.checkSetQATUserChange_CheckedButtonChanged);
            // 
            // kiwiCheckButton1
            // 
            this.kiwiCheckButton1.Location = new System.Drawing.Point(20, 101);
            this.kiwiCheckButton1.Name = "kiwiCheckButton1";
            this.kiwiCheckButton1.Size = new System.Drawing.Size(90, 25);
            this.kiwiCheckButton1.TabIndex = 4;
            this.kiwiCheckButton1.Values.Text = "Hidden";
            // 
            // kiwiCheckButton2
            // 
            this.kiwiCheckButton2.Location = new System.Drawing.Point(20, 70);
            this.kiwiCheckButton2.Name = "kiwiCheckButton2";
            this.kiwiCheckButton2.Size = new System.Drawing.Size(90, 25);
            this.kiwiCheckButton2.TabIndex = 3;
            this.kiwiCheckButton2.Values.Text = "Below";
            // 
            // kiwiCheckButton3
            // 
            this.kiwiCheckButton3.Checked = true;
            this.kiwiCheckButton3.Location = new System.Drawing.Point(20, 39);
            this.kiwiCheckButton3.Name = "kiwiCheckButton3";
            this.kiwiCheckButton3.Size = new System.Drawing.Size(90, 25);
            this.kiwiCheckButton3.TabIndex = 2;
            this.kiwiCheckButton3.Values.Text = "Above";
            // 
            // kiwiLabel1
            // 
            this.kiwiLabel1.LabelStyle = Kiwi.ComponentFactory.Toolkit.LabelStyle.TitlePanel;
            this.kiwiLabel1.Location = new System.Drawing.Point(4, 4);
            this.kiwiLabel1.Name = "kiwiLabel1";
            this.kiwiLabel1.Size = new System.Drawing.Size(123, 27);
            this.kiwiLabel1.TabIndex = 1;
            this.kiwiLabel1.Values.Text = "QAT Location";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 411);
            this.Controls.Add(this.panelFill);
            this.Controls.Add(this.kiwiRibbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(383, 445);
            this.Name = "Form1";
            this.Text = "Quick Access Toolbar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiRibbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelFill)).EndInit();
            this.panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiGroup2.Panel)).EndInit();
            this.kiwiGroup2.Panel.ResumeLayout(false);
            this.kiwiGroup2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiGroup2)).EndInit();
            this.kiwiGroup2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiGroup1.Panel)).EndInit();
            this.kiwiGroup1.Panel.ResumeLayout(false);
            this.kiwiGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiGroup1)).EndInit();
            this.kiwiGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupQATLocation.Panel)).EndInit();
            this.groupQATLocation.Panel.ResumeLayout(false);
            this.groupQATLocation.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupQATLocation)).EndInit();
            this.groupQATLocation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Kiwi.ComponentFactory.Ribbon.KiwiRibbon kiwiRibbon;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonTab tabHome;
        private Kiwi.ComponentFactory.Toolkit.KiwiManager kiwiManager;
        private Kiwi.ComponentFactory.Toolkit.KiwiPanel panelFill;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckSet checkSetQATPosition;
        private Kiwi.ComponentFactory.Toolkit.KiwiGroup groupQATLocation;
        private Kiwi.ComponentFactory.Toolkit.KiwiLabel labelQATLocation;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckButton checkButtonHidden;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckButton checkButtonBelow;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckButton checkButtonAbove;
        private Kiwi.ComponentFactory.Toolkit.KiwiGroup kiwiGroup1;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckButton checkButtonDisallowUserChanges;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckButton checkButtonAllowUserChanges;
        private Kiwi.ComponentFactory.Toolkit.KiwiLabel labelQATUserChange;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckSet checkSetQATUserChange;
        private Kiwi.ComponentFactory.Toolkit.KiwiGroup kiwiGroup2;
        private Kiwi.ComponentFactory.Toolkit.KiwiButton buttonClear;
        private Kiwi.ComponentFactory.Toolkit.KiwiButton buttonRemove;
        private Kiwi.ComponentFactory.Toolkit.KiwiButton buttonAdd;
        private Kiwi.ComponentFactory.Toolkit.KiwiLabel labelQATButtons;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckButton kiwiCheckButton1;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckButton kiwiCheckButton2;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckButton kiwiCheckButton3;
        private Kiwi.ComponentFactory.Toolkit.KiwiLabel kiwiLabel1;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem kiwiContextMenuItem1;
    }
}

