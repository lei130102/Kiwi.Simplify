
namespace Three_Pane_Application__Extended_
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Staff reviews", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Job interviews", 1, 1);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Project meetings", 1, 1);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Appointments", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Administration", 2, 2);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Programmers", 3, 3);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Managers", 4, 4);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Employees", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPaletteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.office2010BlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.office2010SilverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.office2010BlackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.office2007BlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.office2007SilverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.office2007BlackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.sparkleBlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparkleOrangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparklePurpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readingPaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panePositonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripGeneral = new System.Windows.Forms.ToolStrip();
            this.toolStripLoadPalette = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripReadingPane = new System.Windows.Forms.ToolStripButton();
            this.toolStripPosition = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.kiwiPanelMain = new Kiwi.ComponentFactory.Toolkit.KiwiPanel();
            this.kiwiSplitContainerMain = new Kiwi.ComponentFactory.Toolkit.KiwiSplitContainer();
            this.kiwiHeaderGroupNavigation = new Kiwi.ComponentFactory.Toolkit.KiwiHeaderGroup();
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.kiwiSplitContainerDetails = new Kiwi.ComponentFactory.Toolkit.KiwiSplitContainer();
            this.kiwiHeaderGroupDetails = new Kiwi.ComponentFactory.Toolkit.KiwiHeaderGroup();
            this.buttonSpecPrevious = new Kiwi.ComponentFactory.Toolkit.ButtonSpecHeaderGroup();
            this.buttonSpecNext = new Kiwi.ComponentFactory.Toolkit.ButtonSpecHeaderGroup();
            this.kiwiDataGridView = new Kiwi.ComponentFactory.Toolkit.KiwiDataGridView();
            this.dgValid = new Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewCheckBoxColumn();
            this.dgName = new Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewTextBoxColumn();
            this.dgDescription = new Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewTextBoxColumn();
            this.dgDetails = new Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewTextBoxColumn();
            this.dgDepartment = new Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewTextBoxColumn();
            this.dgCategory = new Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewTextBoxColumn();
            this.kiwiReadingGroupOuter = new Kiwi.ComponentFactory.Toolkit.KiwiGroup();
            this.kiwiReadingLabel = new Kiwi.ComponentFactory.Toolkit.KiwiLabel();
            this.toolStrip2007 = new System.Windows.Forms.ToolStrip();
            this.toolStripOffice2007Blue = new System.Windows.Forms.ToolStripButton();
            this.toolStripOffice2007Silver = new System.Windows.Forms.ToolStripButton();
            this.toolStripOffice2007Black = new System.Windows.Forms.ToolStripButton();
            this.toolStripOther = new System.Windows.Forms.ToolStrip();
            this.toolStripSystem = new System.Windows.Forms.ToolStripButton();
            this.toolStripCustom = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2010 = new System.Windows.Forms.ToolStrip();
            this.toolStripOffice2010Blue = new System.Windows.Forms.ToolStripButton();
            this.toolStripOffice2010Silver = new System.Windows.Forms.ToolStripButton();
            this.toolStripOffice2010Black = new System.Windows.Forms.ToolStripButton();
            this.toolStripSparkle = new System.Windows.Forms.ToolStrip();
            this.toolStripSparkleBlue = new System.Windows.Forms.ToolStripButton();
            this.toolStripSparkleOrange = new System.Windows.Forms.ToolStripButton();
            this.toolStripSparklePurple = new System.Windows.Forms.ToolStripButton();
            this.dataSet = new System.Data.DataSet();
            this.dataTable = new System.Data.DataTable();
            this.colName = new System.Data.DataColumn();
            this.colDescription = new System.Data.DataColumn();
            this.colDetails = new System.Data.DataColumn();
            this.colDepartment = new System.Data.DataColumn();
            this.colCategory = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.kiwiManager = new Kiwi.ComponentFactory.Toolkit.KiwiManager(this.components);
            this.kiwiPaletteCustom = new Kiwi.ComponentFactory.Toolkit.KiwiPalette(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menuStrip.SuspendLayout();
            this.toolStripGeneral.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPanelMain)).BeginInit();
            this.kiwiPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiSplitContainerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiSplitContainerMain.Panel1)).BeginInit();
            this.kiwiSplitContainerMain.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiSplitContainerMain.Panel2)).BeginInit();
            this.kiwiSplitContainerMain.Panel2.SuspendLayout();
            this.kiwiSplitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiHeaderGroupNavigation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiHeaderGroupNavigation.Panel)).BeginInit();
            this.kiwiHeaderGroupNavigation.Panel.SuspendLayout();
            this.kiwiHeaderGroupNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiSplitContainerDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiSplitContainerDetails.Panel1)).BeginInit();
            this.kiwiSplitContainerDetails.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiSplitContainerDetails.Panel2)).BeginInit();
            this.kiwiSplitContainerDetails.Panel2.SuspendLayout();
            this.kiwiSplitContainerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiHeaderGroupDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiHeaderGroupDetails.Panel)).BeginInit();
            this.kiwiHeaderGroupDetails.Panel.SuspendLayout();
            this.kiwiHeaderGroupDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiReadingGroupOuter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiReadingGroupOuter.Panel)).BeginInit();
            this.kiwiReadingGroupOuter.Panel.SuspendLayout();
            this.kiwiReadingGroupOuter.SuspendLayout();
            this.toolStrip2007.SuspendLayout();
            this.toolStripOther.SuspendLayout();
            this.toolStrip2010.SuspendLayout();
            this.toolStripSparkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(626, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadPaletteToolStripMenuItem,
            this.toolStripSeparator2,
            this.office2010BlueToolStripMenuItem,
            this.office2010SilverToolStripMenuItem,
            this.office2010BlackToolStripMenuItem,
            this.toolStripSeparator3,
            this.office2007BlueToolStripMenuItem,
            this.office2007SilverToolStripMenuItem,
            this.office2007BlackToolStripMenuItem,
            this.toolStripSeparator4,
            this.sparkleBlueToolStripMenuItem,
            this.sparkleOrangeToolStripMenuItem,
            this.sparklePurpleToolStripMenuItem,
            this.toolStripSeparator5,
            this.systemToolStripMenuItem,
            this.customToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadPaletteToolStripMenuItem
            // 
            this.loadPaletteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loadPaletteToolStripMenuItem.Image")));
            this.loadPaletteToolStripMenuItem.Name = "loadPaletteToolStripMenuItem";
            this.loadPaletteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.loadPaletteToolStripMenuItem.Text = "Load Palette";
            this.loadPaletteToolStripMenuItem.Click += new System.EventHandler(this.loadPaletteToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(161, 6);
            // 
            // office2010BlueToolStripMenuItem
            // 
            this.office2010BlueToolStripMenuItem.Checked = true;
            this.office2010BlueToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.office2010BlueToolStripMenuItem.Name = "office2010BlueToolStripMenuItem";
            this.office2010BlueToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.office2010BlueToolStripMenuItem.Text = "Office 2010 Blue";
            this.office2010BlueToolStripMenuItem.Click += new System.EventHandler(this.toolStripOffice2010Blue_Click);
            // 
            // office2010SilverToolStripMenuItem
            // 
            this.office2010SilverToolStripMenuItem.Name = "office2010SilverToolStripMenuItem";
            this.office2010SilverToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.office2010SilverToolStripMenuItem.Text = "Office 2010 Silver";
            this.office2010SilverToolStripMenuItem.Click += new System.EventHandler(this.toolStripOffice2010Silver_Click);
            // 
            // office2010BlackToolStripMenuItem
            // 
            this.office2010BlackToolStripMenuItem.Name = "office2010BlackToolStripMenuItem";
            this.office2010BlackToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.office2010BlackToolStripMenuItem.Text = "Office 2010 Black";
            this.office2010BlackToolStripMenuItem.Click += new System.EventHandler(this.toolStripOffice2010Black_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
            // 
            // office2007BlueToolStripMenuItem
            // 
            this.office2007BlueToolStripMenuItem.Name = "office2007BlueToolStripMenuItem";
            this.office2007BlueToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.office2007BlueToolStripMenuItem.Text = "Office 2007 Blue";
            this.office2007BlueToolStripMenuItem.Click += new System.EventHandler(this.toolStripOffice2007Blue_Click);
            // 
            // office2007SilverToolStripMenuItem
            // 
            this.office2007SilverToolStripMenuItem.Name = "office2007SilverToolStripMenuItem";
            this.office2007SilverToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.office2007SilverToolStripMenuItem.Text = "Office 2007 Silver";
            this.office2007SilverToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.office2007SilverToolStripMenuItem.Click += new System.EventHandler(this.toolStripOffice2007Silver_Click);
            // 
            // office2007BlackToolStripMenuItem
            // 
            this.office2007BlackToolStripMenuItem.Name = "office2007BlackToolStripMenuItem";
            this.office2007BlackToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.office2007BlackToolStripMenuItem.Text = "Office 2007 Black";
            this.office2007BlackToolStripMenuItem.Click += new System.EventHandler(this.toolStripOffice2007Black_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(161, 6);
            // 
            // sparkleBlueToolStripMenuItem
            // 
            this.sparkleBlueToolStripMenuItem.Name = "sparkleBlueToolStripMenuItem";
            this.sparkleBlueToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.sparkleBlueToolStripMenuItem.Text = "Sparkle Blue";
            this.sparkleBlueToolStripMenuItem.Click += new System.EventHandler(this.toolStripSparkleBlue_Click);
            // 
            // sparkleOrangeToolStripMenuItem
            // 
            this.sparkleOrangeToolStripMenuItem.Name = "sparkleOrangeToolStripMenuItem";
            this.sparkleOrangeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.sparkleOrangeToolStripMenuItem.Text = "Sparkle Orange";
            this.sparkleOrangeToolStripMenuItem.Click += new System.EventHandler(this.toolStripSparkleOrange_Click);
            // 
            // sparklePurpleToolStripMenuItem
            // 
            this.sparklePurpleToolStripMenuItem.Name = "sparklePurpleToolStripMenuItem";
            this.sparklePurpleToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.sparklePurpleToolStripMenuItem.Text = "Sparkle Purple";
            this.sparklePurpleToolStripMenuItem.Click += new System.EventHandler(this.toolStripSparklePurple_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(161, 6);
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.systemToolStripMenuItem.Text = "System";
            this.systemToolStripMenuItem.Click += new System.EventHandler(this.toolStripSystem_Click);
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.customToolStripMenuItem.Text = "Custom";
            this.customToolStripMenuItem.Click += new System.EventHandler(this.toolStripCustom_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(161, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readingPaneToolStripMenuItem,
            this.panePositonToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.toolsToolStripMenuItem.Text = "&Options";
            // 
            // readingPaneToolStripMenuItem
            // 
            this.readingPaneToolStripMenuItem.Name = "readingPaneToolStripMenuItem";
            this.readingPaneToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.readingPaneToolStripMenuItem.Text = "Hide &Reading Pane";
            this.readingPaneToolStripMenuItem.Click += new System.EventHandler(this.readingPaneToolStripMenuItem_Click);
            // 
            // panePositonToolStripMenuItem
            // 
            this.panePositonToolStripMenuItem.Name = "panePositonToolStripMenuItem";
            this.panePositonToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.panePositonToolStripMenuItem.Text = "Reading Pane &Position";
            this.panePositonToolStripMenuItem.Click += new System.EventHandler(this.panePositonToolStripMenuItem_Click);
            // 
            // toolStripGeneral
            // 
            this.toolStripGeneral.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripGeneral.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLoadPalette,
            this.toolStripSeparator1,
            this.toolStripReadingPane,
            this.toolStripPosition});
            this.toolStripGeneral.Location = new System.Drawing.Point(3, 24);
            this.toolStripGeneral.Name = "toolStripGeneral";
            this.toolStripGeneral.Size = new System.Drawing.Size(117, 25);
            this.toolStripGeneral.TabIndex = 1;
            this.toolStripGeneral.Text = "toolStrip1";
            // 
            // toolStripLoadPalette
            // 
            this.toolStripLoadPalette.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLoadPalette.Image")));
            this.toolStripLoadPalette.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLoadPalette.Name = "toolStripLoadPalette";
            this.toolStripLoadPalette.Size = new System.Drawing.Size(53, 22);
            this.toolStripLoadPalette.Text = "Load";
            this.toolStripLoadPalette.ToolTipText = "Load a palette definition";
            this.toolStripLoadPalette.Click += new System.EventHandler(this.toolStripLoadPalette_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripReadingPane
            // 
            this.toolStripReadingPane.CheckOnClick = true;
            this.toolStripReadingPane.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripReadingPane.Image = ((System.Drawing.Image)(resources.GetObject("toolStripReadingPane.Image")));
            this.toolStripReadingPane.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripReadingPane.Name = "toolStripReadingPane";
            this.toolStripReadingPane.Size = new System.Drawing.Size(23, 22);
            this.toolStripReadingPane.ToolTipText = "Show/Hide the reading pane";
            this.toolStripReadingPane.Click += new System.EventHandler(this.toolStripReadingPane_CheckedChanged);
            // 
            // toolStripPosition
            // 
            this.toolStripPosition.CheckOnClick = true;
            this.toolStripPosition.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPosition.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPosition.Image")));
            this.toolStripPosition.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPosition.Name = "toolStripPosition";
            this.toolStripPosition.Size = new System.Drawing.Size(23, 22);
            this.toolStripPosition.ToolTipText = "Show reading pane on right or bottom";
            this.toolStripPosition.Click += new System.EventHandler(this.toolStripPosition_CheckedChanged);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.kiwiPanelMain);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(626, 411);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(626, 485);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripGeneral);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripSparkle);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip2010);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripOther);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip2007);
            // 
            // kiwiPanelMain
            // 
            this.kiwiPanelMain.Controls.Add(this.kiwiSplitContainerMain);
            this.kiwiPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiwiPanelMain.Location = new System.Drawing.Point(0, 0);
            this.kiwiPanelMain.Name = "kiwiPanelMain";
            this.kiwiPanelMain.Padding = new System.Windows.Forms.Padding(4);
            this.kiwiPanelMain.Size = new System.Drawing.Size(626, 411);
            this.kiwiPanelMain.TabIndex = 0;
            // 
            // kiwiSplitContainerMain
            // 
            this.kiwiSplitContainerMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.kiwiSplitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiwiSplitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.kiwiSplitContainerMain.Location = new System.Drawing.Point(4, 4);
            this.kiwiSplitContainerMain.Name = "kiwiSplitContainerMain";
            // 
            // kiwiSplitContainerMain.Panel1
            // 
            this.kiwiSplitContainerMain.Panel1.Controls.Add(this.kiwiHeaderGroupNavigation);
            // 
            // kiwiSplitContainerMain.Panel2
            // 
            this.kiwiSplitContainerMain.Panel2.Controls.Add(this.kiwiSplitContainerDetails);
            this.kiwiSplitContainerMain.Size = new System.Drawing.Size(618, 403);
            this.kiwiSplitContainerMain.SplitterDistance = 176;
            this.kiwiSplitContainerMain.TabIndex = 0;
            // 
            // kiwiHeaderGroupNavigation
            // 
            this.kiwiHeaderGroupNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiwiHeaderGroupNavigation.Location = new System.Drawing.Point(0, 0);
            this.kiwiHeaderGroupNavigation.Name = "kiwiHeaderGroupNavigation";
            // 
            // kiwiHeaderGroupNavigation.Panel
            // 
            this.kiwiHeaderGroupNavigation.Panel.Controls.Add(this.treeView);
            this.kiwiHeaderGroupNavigation.Size = new System.Drawing.Size(176, 403);
            this.kiwiHeaderGroupNavigation.TabIndex = 0;
            this.kiwiHeaderGroupNavigation.ValuesPrimary.Heading = "Navigation";
            this.kiwiHeaderGroupNavigation.ValuesPrimary.Image = null;
            this.kiwiHeaderGroupNavigation.ValuesSecondary.Heading = "Select option";
            // 
            // treeView
            // 
            this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.HideSelection = false;
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageList;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "NodeYearlyReview";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "Staff reviews";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "NodeCandidateInterview";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "Job interviews";
            treeNode3.ImageIndex = 1;
            treeNode3.Name = "NodeProjectMilestone";
            treeNode3.SelectedImageIndex = 1;
            treeNode3.Text = "Project meetings";
            treeNode4.ImageIndex = 0;
            treeNode4.Name = "NodeAppointments";
            treeNode4.SelectedImageIndex = 0;
            treeNode4.Text = "Appointments";
            treeNode5.ImageIndex = 2;
            treeNode5.Name = "NodeAdministration";
            treeNode5.SelectedImageIndex = 2;
            treeNode5.Text = "Administration";
            treeNode6.ImageIndex = 3;
            treeNode6.Name = "Programmers";
            treeNode6.SelectedImageIndex = 3;
            treeNode6.Text = "Programmers";
            treeNode7.ImageIndex = 4;
            treeNode7.Name = "NodeManagers";
            treeNode7.SelectedImageIndex = 4;
            treeNode7.Text = "Managers";
            treeNode8.ImageIndex = 0;
            treeNode8.Name = "NodeEmployees";
            treeNode8.SelectedImageIndex = 0;
            treeNode8.Text = "Employees";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8});
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(174, 352);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Folder.ico");
            this.imageList.Images.SetKeyName(1, "calendar.png");
            this.imageList.Images.SetKeyName(2, "user2.png");
            this.imageList.Images.SetKeyName(3, "dude1.png");
            this.imageList.Images.SetKeyName(4, "businessman2.png");
            // 
            // kiwiSplitContainerDetails
            // 
            this.kiwiSplitContainerDetails.Cursor = System.Windows.Forms.Cursors.Default;
            this.kiwiSplitContainerDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiwiSplitContainerDetails.Location = new System.Drawing.Point(0, 0);
            this.kiwiSplitContainerDetails.Name = "kiwiSplitContainerDetails";
            this.kiwiSplitContainerDetails.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // kiwiSplitContainerDetails.Panel1
            // 
            this.kiwiSplitContainerDetails.Panel1.Controls.Add(this.kiwiHeaderGroupDetails);
            this.kiwiSplitContainerDetails.Panel1MinSize = 50;
            // 
            // kiwiSplitContainerDetails.Panel2
            // 
            this.kiwiSplitContainerDetails.Panel2.Controls.Add(this.kiwiReadingGroupOuter);
            this.kiwiSplitContainerDetails.Panel2MinSize = 50;
            this.kiwiSplitContainerDetails.Size = new System.Drawing.Size(437, 403);
            this.kiwiSplitContainerDetails.SplitterDistance = 231;
            this.kiwiSplitContainerDetails.TabIndex = 0;
            // 
            // kiwiHeaderGroupDetails
            // 
            this.kiwiHeaderGroupDetails.AllowButtonSpecToolTips = true;
            this.kiwiHeaderGroupDetails.ButtonSpecs.AddRange(new Kiwi.ComponentFactory.Toolkit.ButtonSpecHeaderGroup[] {
            this.buttonSpecPrevious,
            this.buttonSpecNext});
            this.kiwiHeaderGroupDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiwiHeaderGroupDetails.HeaderVisibleSecondary = false;
            this.kiwiHeaderGroupDetails.Location = new System.Drawing.Point(0, 0);
            this.kiwiHeaderGroupDetails.Name = "kiwiHeaderGroupDetails";
            // 
            // kiwiHeaderGroupDetails.Panel
            // 
            this.kiwiHeaderGroupDetails.Panel.Controls.Add(this.kiwiDataGridView);
            this.kiwiHeaderGroupDetails.Size = new System.Drawing.Size(437, 231);
            this.kiwiHeaderGroupDetails.TabIndex = 0;
            this.kiwiHeaderGroupDetails.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("kiwiHeaderGroupDetails.ValuesPrimary.Image")));
            // 
            // buttonSpecPrevious
            // 
            this.buttonSpecPrevious.Image = ((System.Drawing.Image)(resources.GetObject("buttonSpecPrevious.Image")));
            this.buttonSpecPrevious.ToolTipTitle = "Move to previous selection";
            this.buttonSpecPrevious.Type = Kiwi.ComponentFactory.Toolkit.PaletteButtonSpecStyle.Previous;
            this.buttonSpecPrevious.UniqueName = "5D8BDAFE5D4E48755D8BDAFE5D4E4875";
            // 
            // buttonSpecNext
            // 
            this.buttonSpecNext.Image = ((System.Drawing.Image)(resources.GetObject("buttonSpecNext.Image")));
            this.buttonSpecNext.ToolTipTitle = "Move to next selection";
            this.buttonSpecNext.Type = Kiwi.ComponentFactory.Toolkit.PaletteButtonSpecStyle.Next;
            this.buttonSpecNext.UniqueName = "8C33B0A305634EC58C33B0A305634EC5";
            // 
            // kiwiDataGridView
            // 
            this.kiwiDataGridView.AllowUserToAddRows = false;
            this.kiwiDataGridView.AllowUserToDeleteRows = false;
            this.kiwiDataGridView.AllowUserToResizeRows = false;
            this.kiwiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgValid,
            this.dgName,
            this.dgDescription,
            this.dgDetails,
            this.dgDepartment,
            this.dgCategory});
            this.kiwiDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiwiDataGridView.GridStyles.Style = Kiwi.ComponentFactory.Toolkit.DataGridViewStyle.Mixed;
            this.kiwiDataGridView.GridStyles.StyleBackground = Kiwi.ComponentFactory.Toolkit.PaletteBackStyle.ControlClient;
            this.kiwiDataGridView.HideOuterBorders = true;
            this.kiwiDataGridView.Location = new System.Drawing.Point(0, 0);
            this.kiwiDataGridView.MultiSelect = false;
            this.kiwiDataGridView.Name = "kiwiDataGridView";
            this.kiwiDataGridView.ReadOnly = true;
            this.kiwiDataGridView.RowHeadersVisible = false;
            this.kiwiDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kiwiDataGridView.Size = new System.Drawing.Size(435, 200);
            this.kiwiDataGridView.TabIndex = 0;
            this.kiwiDataGridView.SelectionChanged += new System.EventHandler(this.kiwiDataGridView_SelectionChanged);
            // 
            // dgValid
            // 
            this.dgValid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgValid.DataPropertyName = "Valid";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = false;
            this.dgValid.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgValid.FalseValue = null;
            this.dgValid.HeaderText = "Valid";
            this.dgValid.IndeterminateValue = null;
            this.dgValid.Name = "dgValid";
            this.dgValid.ReadOnly = true;
            this.dgValid.TrueValue = null;
            this.dgValid.Width = 43;
            // 
            // dgName
            // 
            this.dgName.DataPropertyName = "Name";
            this.dgName.HeaderText = "Name";
            this.dgName.MinimumWidth = 60;
            this.dgName.Name = "dgName";
            this.dgName.ReadOnly = true;
            this.dgName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgName.Width = 120;
            // 
            // dgDescription
            // 
            this.dgDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgDescription.DataPropertyName = "Description";
            this.dgDescription.HeaderText = "Description";
            this.dgDescription.MinimumWidth = 100;
            this.dgDescription.Name = "dgDescription";
            this.dgDescription.ReadOnly = true;
            this.dgDescription.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgDetails
            // 
            this.dgDetails.DataPropertyName = "Details";
            this.dgDetails.HeaderText = "Details";
            this.dgDetails.Name = "dgDetails";
            this.dgDetails.ReadOnly = true;
            this.dgDetails.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDetails.Visible = false;
            // 
            // dgDepartment
            // 
            this.dgDepartment.DataPropertyName = "Department";
            this.dgDepartment.HeaderText = "Department";
            this.dgDepartment.Name = "dgDepartment";
            this.dgDepartment.ReadOnly = true;
            this.dgDepartment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDepartment.Visible = false;
            // 
            // dgCategory
            // 
            this.dgCategory.DataPropertyName = "Category";
            this.dgCategory.HeaderText = "Category";
            this.dgCategory.Name = "dgCategory";
            this.dgCategory.ReadOnly = true;
            this.dgCategory.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCategory.Visible = false;
            // 
            // kiwiReadingGroupOuter
            // 
            this.kiwiReadingGroupOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiwiReadingGroupOuter.GroupBackStyle = Kiwi.ComponentFactory.Toolkit.PaletteBackStyle.PanelAlternate;
            this.kiwiReadingGroupOuter.Location = new System.Drawing.Point(0, 0);
            this.kiwiReadingGroupOuter.Name = "kiwiReadingGroupOuter";
            // 
            // kiwiReadingGroupOuter.Panel
            // 
            this.kiwiReadingGroupOuter.Panel.Controls.Add(this.kiwiReadingLabel);
            this.kiwiReadingGroupOuter.Panel.Padding = new System.Windows.Forms.Padding(5);
            this.kiwiReadingGroupOuter.Size = new System.Drawing.Size(437, 167);
            this.kiwiReadingGroupOuter.TabIndex = 0;
            // 
            // kiwiReadingLabel
            // 
            this.kiwiReadingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiwiReadingLabel.LabelStyle = Kiwi.ComponentFactory.Toolkit.LabelStyle.TitlePanel;
            this.kiwiReadingLabel.Location = new System.Drawing.Point(5, 5);
            this.kiwiReadingLabel.Name = "kiwiReadingLabel";
            this.kiwiReadingLabel.Size = new System.Drawing.Size(425, 155);
            this.kiwiReadingLabel.StateCommon.ShortText.MultiLine = Kiwi.ComponentFactory.Toolkit.InheritBool.True;
            this.kiwiReadingLabel.StateCommon.ShortText.MultiLineH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Near;
            this.kiwiReadingLabel.StateCommon.ShortText.TextH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Near;
            this.kiwiReadingLabel.StateCommon.ShortText.TextV = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Near;
            this.kiwiReadingLabel.TabIndex = 0;
            this.kiwiReadingLabel.Values.Text = "";
            // 
            // toolStrip2007
            // 
            this.toolStrip2007.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2007.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip2007.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripOffice2007Blue,
            this.toolStripOffice2007Silver,
            this.toolStripOffice2007Black});
            this.toolStrip2007.Location = new System.Drawing.Point(117, 49);
            this.toolStrip2007.Name = "toolStrip2007";
            this.toolStrip2007.Size = new System.Drawing.Size(205, 25);
            this.toolStrip2007.TabIndex = 2;
            // 
            // toolStripOffice2007Blue
            // 
            this.toolStripOffice2007Blue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripOffice2007Blue.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOffice2007Blue.Image")));
            this.toolStripOffice2007Blue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOffice2007Blue.Name = "toolStripOffice2007Blue";
            this.toolStripOffice2007Blue.Size = new System.Drawing.Size(61, 22);
            this.toolStripOffice2007Blue.Text = "2007 Blue";
            this.toolStripOffice2007Blue.ToolTipText = "Use the built in preofessional office palette";
            this.toolStripOffice2007Blue.Click += new System.EventHandler(this.toolStripOffice2007Blue_Click);
            // 
            // toolStripOffice2007Silver
            // 
            this.toolStripOffice2007Silver.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripOffice2007Silver.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOffice2007Silver.Image")));
            this.toolStripOffice2007Silver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOffice2007Silver.Name = "toolStripOffice2007Silver";
            this.toolStripOffice2007Silver.Size = new System.Drawing.Size(66, 22);
            this.toolStripOffice2007Silver.Text = "2007 Silver";
            this.toolStripOffice2007Silver.ToolTipText = "Use the built in preofessional office palette";
            this.toolStripOffice2007Silver.Click += new System.EventHandler(this.toolStripOffice2007Silver_Click);
            // 
            // toolStripOffice2007Black
            // 
            this.toolStripOffice2007Black.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripOffice2007Black.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOffice2007Black.Image")));
            this.toolStripOffice2007Black.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOffice2007Black.Name = "toolStripOffice2007Black";
            this.toolStripOffice2007Black.Size = new System.Drawing.Size(66, 22);
            this.toolStripOffice2007Black.Text = "2007 Black";
            this.toolStripOffice2007Black.ToolTipText = "Use the built in preofessional office palette";
            this.toolStripOffice2007Black.Click += new System.EventHandler(this.toolStripOffice2007Black_Click);
            // 
            // toolStripOther
            // 
            this.toolStripOther.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripOther.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripOther.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSystem,
            this.toolStripCustom});
            this.toolStripOther.Location = new System.Drawing.Point(3, 49);
            this.toolStripOther.Name = "toolStripOther";
            this.toolStripOther.Size = new System.Drawing.Size(114, 25);
            this.toolStripOther.TabIndex = 3;
            // 
            // toolStripSystem
            // 
            this.toolStripSystem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSystem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSystem.Image")));
            this.toolStripSystem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSystem.Name = "toolStripSystem";
            this.toolStripSystem.Size = new System.Drawing.Size(49, 22);
            this.toolStripSystem.Text = "System";
            this.toolStripSystem.ToolTipText = "Use the built in professional system palette";
            this.toolStripSystem.Click += new System.EventHandler(this.toolStripSystem_Click);
            // 
            // toolStripCustom
            // 
            this.toolStripCustom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripCustom.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCustom.Image")));
            this.toolStripCustom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCustom.Name = "toolStripCustom";
            this.toolStripCustom.Size = new System.Drawing.Size(53, 22);
            this.toolStripCustom.Text = "Custom";
            this.toolStripCustom.ToolTipText = "Use a custom palette";
            this.toolStripCustom.Click += new System.EventHandler(this.toolStripCustom_Click);
            // 
            // toolStrip2010
            // 
            this.toolStrip2010.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2010.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip2010.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripOffice2010Blue,
            this.toolStripOffice2010Silver,
            this.toolStripOffice2010Black});
            this.toolStrip2010.Location = new System.Drawing.Point(120, 24);
            this.toolStrip2010.Name = "toolStrip2010";
            this.toolStrip2010.Size = new System.Drawing.Size(205, 25);
            this.toolStrip2010.TabIndex = 4;
            // 
            // toolStripOffice2010Blue
            // 
            this.toolStripOffice2010Blue.Checked = true;
            this.toolStripOffice2010Blue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripOffice2010Blue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripOffice2010Blue.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOffice2010Blue.Image")));
            this.toolStripOffice2010Blue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOffice2010Blue.Name = "toolStripOffice2010Blue";
            this.toolStripOffice2010Blue.Size = new System.Drawing.Size(61, 22);
            this.toolStripOffice2010Blue.Text = "2010 Blue";
            this.toolStripOffice2010Blue.ToolTipText = "Use the built in preofessional office palette";
            this.toolStripOffice2010Blue.Click += new System.EventHandler(this.toolStripOffice2010Blue_Click);
            // 
            // toolStripOffice2010Silver
            // 
            this.toolStripOffice2010Silver.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripOffice2010Silver.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOffice2010Silver.Image")));
            this.toolStripOffice2010Silver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOffice2010Silver.Name = "toolStripOffice2010Silver";
            this.toolStripOffice2010Silver.Size = new System.Drawing.Size(66, 22);
            this.toolStripOffice2010Silver.Text = "2010 Silver";
            this.toolStripOffice2010Silver.ToolTipText = "Use the built in preofessional office palette";
            this.toolStripOffice2010Silver.Click += new System.EventHandler(this.toolStripOffice2010Silver_Click);
            // 
            // toolStripOffice2010Black
            // 
            this.toolStripOffice2010Black.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripOffice2010Black.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOffice2010Black.Image")));
            this.toolStripOffice2010Black.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOffice2010Black.Name = "toolStripOffice2010Black";
            this.toolStripOffice2010Black.Size = new System.Drawing.Size(66, 22);
            this.toolStripOffice2010Black.Text = "2010 Black";
            this.toolStripOffice2010Black.ToolTipText = "Use the built in preofessional office palette";
            this.toolStripOffice2010Black.Click += new System.EventHandler(this.toolStripOffice2010Black_Click);
            // 
            // toolStripSparkle
            // 
            this.toolStripSparkle.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripSparkle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripSparkle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSparkleBlue,
            this.toolStripSparkleOrange,
            this.toolStripSparklePurple});
            this.toolStripSparkle.Location = new System.Drawing.Point(325, 24);
            this.toolStripSparkle.Name = "toolStripSparkle";
            this.toolStripSparkle.Size = new System.Drawing.Size(264, 25);
            this.toolStripSparkle.TabIndex = 5;
            // 
            // toolStripSparkleBlue
            // 
            this.toolStripSparkleBlue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSparkleBlue.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSparkleBlue.Image")));
            this.toolStripSparkleBlue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSparkleBlue.Name = "toolStripSparkleBlue";
            this.toolStripSparkleBlue.Size = new System.Drawing.Size(75, 22);
            this.toolStripSparkleBlue.Text = "Sparkle Blue";
            this.toolStripSparkleBlue.Click += new System.EventHandler(this.toolStripSparkleBlue_Click);
            // 
            // toolStripSparkleOrange
            // 
            this.toolStripSparkleOrange.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSparkleOrange.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSparkleOrange.Image")));
            this.toolStripSparkleOrange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSparkleOrange.Name = "toolStripSparkleOrange";
            this.toolStripSparkleOrange.Size = new System.Drawing.Size(91, 22);
            this.toolStripSparkleOrange.Text = "Sparkle Orange";
            this.toolStripSparkleOrange.Click += new System.EventHandler(this.toolStripSparkleOrange_Click);
            // 
            // toolStripSparklePurple
            // 
            this.toolStripSparklePurple.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSparklePurple.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSparklePurple.Image")));
            this.toolStripSparklePurple.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSparklePurple.Name = "toolStripSparklePurple";
            this.toolStripSparklePurple.Size = new System.Drawing.Size(86, 22);
            this.toolStripSparklePurple.Text = "Sparkle Purple";
            this.toolStripSparklePurple.Click += new System.EventHandler(this.toolStripSparklePurple_Click);
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "NewDataSet";
            this.dataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable});
            // 
            // dataTable
            // 
            this.dataTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.colName,
            this.colDescription,
            this.colDetails,
            this.colDepartment,
            this.colCategory,
            this.dataColumn1});
            this.dataTable.TableName = "TestTable";
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.ColumnName = "Name";
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.ColumnName = "Description";
            this.colDescription.DefaultValue = "";
            // 
            // colDetails
            // 
            this.colDetails.ColumnName = "Details";
            // 
            // colDepartment
            // 
            this.colDepartment.ColumnName = "Department";
            // 
            // colCategory
            // 
            this.colCategory.ColumnName = "Category";
            // 
            // dataColumn1
            // 
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.ColumnName = "Valid";
            this.dataColumn1.DataType = typeof(bool);
            this.dataColumn1.DefaultValue = true;
            // 
            // kiwiPaletteCustom
            // 
            this.kiwiPaletteCustom.AllowFormChrome = Kiwi.ComponentFactory.Toolkit.InheritBool.False;
            this.kiwiPaletteCustom.BasePaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.kiwiPaletteCustom.ButtonStyles.ButtonButtonSpec.StateDisabled.Border.Draw = Kiwi.ComponentFactory.Toolkit.InheritBool.False;
            this.kiwiPaletteCustom.ButtonStyles.ButtonButtonSpec.StateDisabled.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.kiwiPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Back.Draw = Kiwi.ComponentFactory.Toolkit.InheritBool.False;
            this.kiwiPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.kiwiPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Border.Draw = Kiwi.ComponentFactory.Toolkit.InheritBool.True;
            this.kiwiPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.kiwiPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.kiwiPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.Padding = new System.Windows.Forms.Padding(3);
            this.kiwiPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.kiwiPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kiwiPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.kiwiPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedPressed.Content.Padding = new System.Windows.Forms.Padding(5, 5, 1, 1);
            this.kiwiPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.kiwiPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Back.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Solid;
            this.kiwiPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kiwiPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Solid;
            this.kiwiPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.kiwiPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.GraphicsHint = Kiwi.ComponentFactory.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kiwiPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.Rounding = 3;
            this.kiwiPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.Width = 2;
            this.kiwiPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.kiwiPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Solid;
            this.kiwiPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.Padding = new System.Windows.Forms.Padding(3);
            this.kiwiPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kiwiPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Solid;
            this.kiwiPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Border.Color1 = System.Drawing.Color.Silver;
            this.kiwiPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.kiwiPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.Color1 = System.Drawing.Color.Silver;
            this.kiwiPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Silver;
            this.kiwiPaletteCustom.ButtonStyles.ButtonCommon.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.kiwiPaletteCustom.ButtonStyles.ButtonCommon.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kiwiPaletteCustom.ButtonStyles.ButtonCommon.StatePressed.Content.Padding = new System.Windows.Forms.Padding(5, 5, 1, 1);
            this.kiwiPaletteCustom.ButtonStyles.ButtonCommon.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kiwiPaletteCustom.ButtonStyles.ButtonLowProfile.StateDisabled.Border.Draw = Kiwi.ComponentFactory.Toolkit.InheritBool.False;
            this.kiwiPaletteCustom.ButtonStyles.ButtonLowProfile.StateDisabled.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.kiwiPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Back.Draw = Kiwi.ComponentFactory.Toolkit.InheritBool.False;
            this.kiwiPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.kiwiPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Border.Draw = Kiwi.ComponentFactory.Toolkit.InheritBool.True;
            this.kiwiPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.kiwiPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.kiwiPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.Padding = new System.Windows.Forms.Padding(3);
            this.kiwiPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.kiwiPaletteCustom.ButtonStyles.ButtonStandalone.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.kiwiPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(227)))));
            this.kiwiPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Solid;
            this.kiwiPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.kiwiPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.GraphicsHint = Kiwi.ComponentFactory.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kiwiPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.Rounding = 9;
            this.kiwiPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.Width = 3;
            this.kiwiPaletteCustom.ControlStyles.ControlCommon.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kiwiPaletteCustom.ControlStyles.ControlCommon.StateDisabled.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.kiwiPaletteCustom.ControlStyles.ControlCommon.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(212)))), ((int)(((byte)(192)))));
            this.kiwiPaletteCustom.ControlStyles.ControlCommon.StateNormal.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.kiwiPaletteCustom.ControlStyles.ControlToolTip.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kiwiPaletteCustom.ControlStyles.ControlToolTip.StateCommon.Back.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Solid;
            this.kiwiPaletteCustom.ControlStyles.ControlToolTip.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kiwiPaletteCustom.ControlStyles.ControlToolTip.StateCommon.Border.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Solid;
            this.kiwiPaletteCustom.ControlStyles.ControlToolTip.StateCommon.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.kiwiPaletteCustom.GridStyles.GridCommon.StateCommon.BackStyle = Kiwi.ComponentFactory.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kiwiPaletteCustom.GridStyles.GridCommon.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.Red;
            this.kiwiPaletteCustom.GridStyles.GridCommon.StateCommon.DataCell.Border.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Solid;
            this.kiwiPaletteCustom.GridStyles.GridCommon.StateCommon.DataCell.Border.DrawBorders = Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.None;
            this.kiwiPaletteCustom.GridStyles.GridCommon.StateCommon.DataCell.Border.Rounding = 0;
            this.kiwiPaletteCustom.GridStyles.GridCommon.StateCommon.DataCell.Border.Width = 0;
            this.kiwiPaletteCustom.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(213)))), ((int)(((byte)(194)))));
            this.kiwiPaletteCustom.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.White;
            this.kiwiPaletteCustom.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Linear;
            this.kiwiPaletteCustom.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Red;
            this.kiwiPaletteCustom.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.kiwiPaletteCustom.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.Rounding = 0;
            this.kiwiPaletteCustom.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.Width = 0;
            this.kiwiPaletteCustom.GridStyles.GridCommon.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.kiwiPaletteCustom.GridStyles.GridCommon.StateSelected.DataCell.Back.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Solid;
            this.kiwiPaletteCustom.GridStyles.GridCommon.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.kiwiPaletteCustom.HeaderGroup.StateCommon.OverlayHeaders = Kiwi.ComponentFactory.Toolkit.InheritBool.False;
            this.kiwiPaletteCustom.HeaderGroup.StateCommon.PrimaryHeaderPadding = new System.Windows.Forms.Padding(3);
            this.kiwiPaletteCustom.HeaderGroup.StateCommon.SecondaryHeaderPadding = new System.Windows.Forms.Padding(3);
            this.kiwiPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Back.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Linear;
            this.kiwiPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Back.GraphicsHint = Kiwi.ComponentFactory.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kiwiPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Border.Draw = Kiwi.ComponentFactory.Toolkit.InheritBool.False;
            this.kiwiPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.kiwiPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Border.Rounding = 7;
            this.kiwiPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Border.Width = 3;
            this.kiwiPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.AdjacentGap = 2;
            this.kiwiPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.kiwiPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Solid;
            this.kiwiPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.TextH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Far;
            this.kiwiPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 1, 10, 1);
            this.kiwiPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.kiwiPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Solid;
            this.kiwiPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.TextH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Near;
            this.kiwiPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Color1 = System.Drawing.Color.Silver;
            this.kiwiPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Silver;
            this.kiwiPaletteCustom.HeaderStyles.HeaderPrimary.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kiwiPaletteCustom.HeaderStyles.HeaderPrimary.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.kiwiPaletteCustom.HeaderStyles.HeaderPrimary.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(213)))), ((int)(((byte)(194)))));
            this.kiwiPaletteCustom.HeaderStyles.HeaderPrimary.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.kiwiPaletteCustom.HeaderStyles.HeaderSecondary.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.kiwiPaletteCustom.HeaderStyles.HeaderSecondary.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kiwiPaletteCustom.HeaderStyles.HeaderSecondary.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.kiwiPaletteCustom.HeaderStyles.HeaderSecondary.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(213)))), ((int)(((byte)(194)))));
            this.kiwiPaletteCustom.LabelStyles.LabelToolTip.StateCommon.LongText.Color1 = System.Drawing.Color.White;
            this.kiwiPaletteCustom.LabelStyles.LabelToolTip.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kiwiPaletteCustom.PanelStyles.PanelAlternate.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(212)))), ((int)(((byte)(192)))));
            this.kiwiPaletteCustom.PanelStyles.PanelClient.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(227)))));
            this.kiwiPaletteCustom.PanelStyles.PanelCommon.StateCommon.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Solid;
            this.kiwiPaletteCustom.ToolMenuStatus.Button.ButtonCheckedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Button.ButtonCheckedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Button.ButtonCheckedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Button.ButtonCheckedHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Button.ButtonCheckedHighlightBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Button.ButtonPressedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Button.ButtonPressedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Button.ButtonPressedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Button.ButtonPressedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Button.ButtonPressedHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Button.ButtonPressedHighlightBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Button.ButtonSelectedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Button.ButtonSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Button.ButtonSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Button.ButtonSelectedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Button.ButtonSelectedHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Button.ButtonSelectedHighlightBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Button.CheckBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Button.CheckPressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Button.CheckSelectedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Button.OverflowButtonGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Button.OverflowButtonGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(144)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Button.OverflowButtonGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Grip.GripDark = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(133)))), ((int)(((byte)(215)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Grip.GripLight = System.Drawing.Color.Transparent;
            this.kiwiPaletteCustom.ToolMenuStatus.Menu.ImageMarginGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Menu.ImageMarginGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Menu.ImageMarginGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Menu.ImageMarginRevealedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Menu.ImageMarginRevealedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Menu.ImageMarginRevealedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Menu.MenuBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Menu.MenuItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Menu.MenuItemPressedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Menu.MenuItemPressedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Menu.MenuItemPressedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Menu.MenuItemSelected = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Menu.MenuItemSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Menu.MenuItemSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Menu.MenuItemText = System.Drawing.Color.White;
            this.kiwiPaletteCustom.ToolMenuStatus.MenuStrip.MenuStripGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kiwiPaletteCustom.ToolMenuStatus.MenuStrip.MenuStripGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kiwiPaletteCustom.ToolMenuStatus.MenuStrip.MenuStripText = System.Drawing.Color.WhiteSmoke;
            this.kiwiPaletteCustom.ToolMenuStatus.Rafting.RaftingContainerGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Rafting.RaftingContainerGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Separator.SeparatorDark = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kiwiPaletteCustom.ToolMenuStatus.Separator.SeparatorLight = System.Drawing.Color.Transparent;
            this.kiwiPaletteCustom.ToolMenuStatus.StatusStrip.StatusStripGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kiwiPaletteCustom.ToolMenuStatus.StatusStrip.StatusStripGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kiwiPaletteCustom.ToolMenuStatus.StatusStrip.StatusStripText = System.Drawing.Color.WhiteSmoke;
            this.kiwiPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripBorder = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(144)))));
            this.kiwiPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripContentPanelGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(227)))));
            this.kiwiPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripContentPanelGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(227)))));
            this.kiwiPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripDropDownBackground = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kiwiPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(144)))));
            this.kiwiPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(144)))));
            this.kiwiPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(144)))));
            this.kiwiPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripPanelGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kiwiPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripPanelGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kiwiPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripText = System.Drawing.Color.WhiteSmoke;
            this.kiwiPaletteCustom.ToolMenuStatus.UseRoundedEdges = Kiwi.ComponentFactory.Toolkit.InheritBool.False;
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip.Location = new System.Drawing.Point(0, 485);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip.Size = new System.Drawing.Size(626, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 507);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(320, 286);
            this.Name = "Form1";
            this.Text = "Three Pane Application (Extended)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SystemColorsChanged += new System.EventHandler(this.Form1_SystemColorsChanged);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStripGeneral.ResumeLayout(false);
            this.toolStripGeneral.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPanelMain)).EndInit();
            this.kiwiPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiSplitContainerMain.Panel1)).EndInit();
            this.kiwiSplitContainerMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiSplitContainerMain.Panel2)).EndInit();
            this.kiwiSplitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiSplitContainerMain)).EndInit();
            this.kiwiSplitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiHeaderGroupNavigation.Panel)).EndInit();
            this.kiwiHeaderGroupNavigation.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiHeaderGroupNavigation)).EndInit();
            this.kiwiHeaderGroupNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiSplitContainerDetails.Panel1)).EndInit();
            this.kiwiSplitContainerDetails.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiSplitContainerDetails.Panel2)).EndInit();
            this.kiwiSplitContainerDetails.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiSplitContainerDetails)).EndInit();
            this.kiwiSplitContainerDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiHeaderGroupDetails.Panel)).EndInit();
            this.kiwiHeaderGroupDetails.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiHeaderGroupDetails)).EndInit();
            this.kiwiHeaderGroupDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiReadingGroupOuter.Panel)).EndInit();
            this.kiwiReadingGroupOuter.Panel.ResumeLayout(false);
            this.kiwiReadingGroupOuter.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiReadingGroupOuter)).EndInit();
            this.kiwiReadingGroupOuter.ResumeLayout(false);
            this.toolStrip2007.ResumeLayout(false);
            this.toolStrip2007.PerformLayout();
            this.toolStripOther.ResumeLayout(false);
            this.toolStripOther.PerformLayout();
            this.toolStrip2010.ResumeLayout(false);
            this.toolStrip2010.PerformLayout();
            this.toolStripSparkle.ResumeLayout(false);
            this.toolStripSparkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readingPaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panePositonToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripGeneral;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private Kiwi.ComponentFactory.Toolkit.KiwiPanel kiwiPanelMain;
        private Kiwi.ComponentFactory.Toolkit.KiwiSplitContainer kiwiSplitContainerMain;
        private Kiwi.ComponentFactory.Toolkit.KiwiHeaderGroup kiwiHeaderGroupNavigation;
        private Kiwi.ComponentFactory.Toolkit.KiwiSplitContainer kiwiSplitContainerDetails;
        private Kiwi.ComponentFactory.Toolkit.KiwiHeaderGroup kiwiHeaderGroupDetails;
        private Kiwi.ComponentFactory.Toolkit.KiwiGroup kiwiReadingGroupOuter;
        private Kiwi.ComponentFactory.Toolkit.KiwiManager kiwiManager;
        private Kiwi.ComponentFactory.Toolkit.KiwiPalette kiwiPaletteCustom;
        private System.Windows.Forms.ImageList imageList;
        private Kiwi.ComponentFactory.Toolkit.KiwiLabel kiwiReadingLabel;
        private System.Windows.Forms.ToolStripMenuItem loadPaletteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ToolStripButton toolStripLoadPalette;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private Kiwi.ComponentFactory.Toolkit.ButtonSpecHeaderGroup buttonSpecPrevious;
        private Kiwi.ComponentFactory.Toolkit.ButtonSpecHeaderGroup buttonSpecNext;
        private System.Windows.Forms.ToolStripMenuItem office2007BlueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem office2007SilverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem office2007BlackToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private Kiwi.ComponentFactory.Toolkit.KiwiDataGridView kiwiDataGridView;
        private System.Data.DataSet dataSet;
        private System.Data.DataTable dataTable;
        private System.Data.DataColumn colName;
        private System.Data.DataColumn colDescription;
        private System.Data.DataColumn colDetails;
        private System.Data.DataColumn colDepartment;
        private System.Data.DataColumn colCategory;
        private System.Data.DataColumn dataColumn1;
        private Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewCheckBoxColumn dgValid;
        private Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewTextBoxColumn dgName;
        private Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewTextBoxColumn dgDescription;
        private Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewTextBoxColumn dgDetails;
        private Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewTextBoxColumn dgDepartment;
        private Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewTextBoxColumn dgCategory;
        private System.Windows.Forms.ToolStripMenuItem sparklePurpleToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip2007;
        private System.Windows.Forms.ToolStripMenuItem office2010BlueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem office2010SilverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem office2010BlackToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem sparkleBlueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparkleOrangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripReadingPane;
        private System.Windows.Forms.ToolStripButton toolStripPosition;
        private System.Windows.Forms.ToolStripButton toolStripOffice2007Blue;
        private System.Windows.Forms.ToolStripButton toolStripOffice2007Silver;
        private System.Windows.Forms.ToolStripButton toolStripOffice2007Black;
        private System.Windows.Forms.ToolStrip toolStripOther;
        private System.Windows.Forms.ToolStripButton toolStripSystem;
        private System.Windows.Forms.ToolStripButton toolStripCustom;
        private System.Windows.Forms.ToolStrip toolStrip2010;
        private System.Windows.Forms.ToolStripButton toolStripOffice2010Blue;
        private System.Windows.Forms.ToolStripButton toolStripOffice2010Silver;
        private System.Windows.Forms.ToolStripButton toolStripOffice2010Black;
        private System.Windows.Forms.ToolStrip toolStripSparkle;
        private System.Windows.Forms.ToolStripButton toolStripSparkleBlue;
        private System.Windows.Forms.ToolStripButton toolStripSparkleOrange;
        private System.Windows.Forms.ToolStripButton toolStripSparklePurple;
    }
}

