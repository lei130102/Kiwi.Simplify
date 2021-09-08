
namespace Outlook_Mockup
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
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Deleted Items");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Drafts");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Family");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Friends");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Work");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Inbox", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Outbox");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Sent Items");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Drafts");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Family");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.kiwiPanelMain = new Kiwi.ComponentFactory.Toolkit.KiwiPanel();
            this.kiwiSplitContainerMain = new Kiwi.ComponentFactory.Toolkit.KiwiSplitContainer();
            this.kiwiNavigatorMain = new Kiwi.ComponentFactory.Navigator.KiwiNavigator();
            this.buttonSpecExpandCollapse = new Kiwi.ComponentFactory.Navigator.ButtonSpecNavigator();
            this.kiwiPageMail = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.treeViewMailFolders = new System.Windows.Forms.TreeView();
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.panelFoldersSep = new System.Windows.Forms.Panel();
            this.kiwiHeaderFolders = new Kiwi.ComponentFactory.Toolkit.KiwiHeader();
            this.treeViewMailFavs = new System.Windows.Forms.TreeView();
            this.panelFavoriteSep = new System.Windows.Forms.Panel();
            this.kiwiHeaderFavorites = new Kiwi.ComponentFactory.Toolkit.KiwiHeader();
            this.kiwiPageCalendar = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.kiwiPageNotes = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.radioFriends = new Kiwi.ComponentFactory.Toolkit.KiwiRadioButton();
            this.radioFamily = new Kiwi.ComponentFactory.Toolkit.KiwiRadioButton();
            this.radioProject = new Kiwi.ComponentFactory.Toolkit.KiwiRadioButton();
            this.kiwiSplitContainerDetails = new Kiwi.ComponentFactory.Toolkit.KiwiSplitContainer();
            this.kiwiNavigatorDetails = new Kiwi.ComponentFactory.Navigator.KiwiNavigator();
            this.kiwiPageMailDetails = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.kiwiDataGridView1 = new Kiwi.ComponentFactory.Toolkit.KiwiDataGridView();
            this.dgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgReceived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiwiPageCalendarDetails = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.kiwiPageNotesDetails = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.listViewNotes = new System.Windows.Forms.ListView();
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.kiwiButtonGroup = new Kiwi.ComponentFactory.Toolkit.KiwiGroup();
            this.kiwiGroupInner = new Kiwi.ComponentFactory.Toolkit.KiwiGroup();
            this.radioSparkle = new Kiwi.ComponentFactory.Toolkit.KiwiRadioButton();
            this.radioSystem = new Kiwi.ComponentFactory.Toolkit.KiwiRadioButton();
            this.radioOffice2003 = new Kiwi.ComponentFactory.Toolkit.KiwiRadioButton();
            this.radioOffice2007Black = new Kiwi.ComponentFactory.Toolkit.KiwiRadioButton();
            this.radioOffice2007Silver = new Kiwi.ComponentFactory.Toolkit.KiwiRadioButton();
            this.radioOffice2007Blue = new Kiwi.ComponentFactory.Toolkit.KiwiRadioButton();
            this.kiwiManager = new Kiwi.ComponentFactory.Toolkit.KiwiManager(this.components);
            this.dataSet = new System.Data.DataSet();
            this.dtDeletedItems = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dtDrafts = new System.Data.DataTable();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dtFamily = new System.Data.DataTable();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.dtOutbox = new System.Data.DataTable();
            this.dataColumn13 = new System.Data.DataColumn();
            this.dataColumn14 = new System.Data.DataColumn();
            this.dataColumn15 = new System.Data.DataColumn();
            this.dataColumn16 = new System.Data.DataColumn();
            this.dtSentItems = new System.Data.DataTable();
            this.dataColumn17 = new System.Data.DataColumn();
            this.dataColumn18 = new System.Data.DataColumn();
            this.dataColumn19 = new System.Data.DataColumn();
            this.dataColumn20 = new System.Data.DataColumn();
            this.dtFriends = new System.Data.DataTable();
            this.dataColumn21 = new System.Data.DataColumn();
            this.dataColumn22 = new System.Data.DataColumn();
            this.dataColumn23 = new System.Data.DataColumn();
            this.dataColumn24 = new System.Data.DataColumn();
            this.dtWork = new System.Data.DataTable();
            this.dataColumn25 = new System.Data.DataColumn();
            this.dataColumn26 = new System.Data.DataColumn();
            this.dataColumn27 = new System.Data.DataColumn();
            this.dataColumn28 = new System.Data.DataColumn();
            this.dtInbox = new System.Data.DataTable();
            this.dataColumn29 = new System.Data.DataColumn();
            this.dataColumn30 = new System.Data.DataColumn();
            this.dataColumn31 = new System.Data.DataColumn();
            this.dataColumn32 = new System.Data.DataColumn();
            this.radioOffice2010Black = new Kiwi.ComponentFactory.Toolkit.KiwiRadioButton();
            this.radioOffice2010Silver = new Kiwi.ComponentFactory.Toolkit.KiwiRadioButton();
            this.radioOffice2010Blue = new Kiwi.ComponentFactory.Toolkit.KiwiRadioButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.kiwiNavigatorMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPageMail)).BeginInit();
            this.kiwiPageMail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPageCalendar)).BeginInit();
            this.kiwiPageCalendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPageNotes)).BeginInit();
            this.kiwiPageNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiSplitContainerDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiSplitContainerDetails.Panel1)).BeginInit();
            this.kiwiSplitContainerDetails.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiSplitContainerDetails.Panel2)).BeginInit();
            this.kiwiSplitContainerDetails.Panel2.SuspendLayout();
            this.kiwiSplitContainerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiNavigatorDetails)).BeginInit();
            this.kiwiNavigatorDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPageMailDetails)).BeginInit();
            this.kiwiPageMailDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPageCalendarDetails)).BeginInit();
            this.kiwiPageCalendarDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPageNotesDetails)).BeginInit();
            this.kiwiPageNotesDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiButtonGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiButtonGroup.Panel)).BeginInit();
            this.kiwiButtonGroup.Panel.SuspendLayout();
            this.kiwiButtonGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiGroupInner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiGroupInner.Panel)).BeginInit();
            this.kiwiGroupInner.Panel.SuspendLayout();
            this.kiwiGroupInner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDeletedItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDrafts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFamily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOutbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSentItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInbox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(712, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator6,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator7,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(208, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.kiwiPanelMain);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(712, 450);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(712, 475);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // kiwiPanelMain
            // 
            this.kiwiPanelMain.Controls.Add(this.kiwiSplitContainerMain);
            this.kiwiPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiwiPanelMain.Location = new System.Drawing.Point(0, 0);
            this.kiwiPanelMain.Name = "kiwiPanelMain";
            this.kiwiPanelMain.Padding = new System.Windows.Forms.Padding(4);
            this.kiwiPanelMain.Size = new System.Drawing.Size(712, 450);
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
            this.kiwiSplitContainerMain.Panel1.Controls.Add(this.kiwiNavigatorMain);
            // 
            // kiwiSplitContainerMain.Panel2
            // 
            this.kiwiSplitContainerMain.Panel2.Controls.Add(this.kiwiSplitContainerDetails);
            this.kiwiSplitContainerMain.Size = new System.Drawing.Size(704, 442);
            this.kiwiSplitContainerMain.SplitterDistance = 183;
            this.kiwiSplitContainerMain.TabIndex = 0;
            // 
            // kiwiNavigatorMain
            // 
            this.kiwiNavigatorMain.Button.ButtonDisplayLogic = Kiwi.ComponentFactory.Navigator.ButtonDisplayLogic.None;
            this.kiwiNavigatorMain.Button.ButtonSpecs.AddRange(new Kiwi.ComponentFactory.Navigator.ButtonSpecNavigator[] {
            this.buttonSpecExpandCollapse});
            this.kiwiNavigatorMain.Button.CloseButtonDisplay = Kiwi.ComponentFactory.Navigator.ButtonDisplay.Hide;
            this.kiwiNavigatorMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiwiNavigatorMain.Header.HeaderValuesPrimary.MapImage = Kiwi.ComponentFactory.Navigator.MapKiwiPageImage.None;
            this.kiwiNavigatorMain.Location = new System.Drawing.Point(0, 0);
            this.kiwiNavigatorMain.Name = "kiwiNavigatorMain";
            this.kiwiNavigatorMain.NavigatorMode = Kiwi.ComponentFactory.Navigator.NavigatorMode.OutlookFull;
            this.kiwiNavigatorMain.Pages.AddRange(new Kiwi.ComponentFactory.Navigator.KiwiPage[] {
            this.kiwiPageMail,
            this.kiwiPageCalendar,
            this.kiwiPageNotes});
            this.kiwiNavigatorMain.SelectedIndex = 0;
            this.kiwiNavigatorMain.Size = new System.Drawing.Size(183, 442);
            this.kiwiNavigatorMain.StateCommon.CheckButton.Content.AdjacentGap = 5;
            this.kiwiNavigatorMain.TabIndex = 0;
            this.kiwiNavigatorMain.Text = "kiwiNavigator1";
            this.kiwiNavigatorMain.SelectedPageChanged += new System.EventHandler(this.kiwiNavigatorMain_SelectedPageChanged);
            // 
            // buttonSpecExpandCollapse
            // 
            this.buttonSpecExpandCollapse.Type = Kiwi.ComponentFactory.Toolkit.PaletteButtonSpecStyle.ArrowLeft;
            this.buttonSpecExpandCollapse.TypeRestricted = Kiwi.ComponentFactory.Navigator.PaletteNavButtonSpecStyle.ArrowLeft;
            this.buttonSpecExpandCollapse.UniqueName = "1B343938A2284A991B343938A2284A99";
            this.buttonSpecExpandCollapse.Click += new System.EventHandler(this.buttonSpecExpandCollapse_Click);
            // 
            // kiwiPageMail
            // 
            this.kiwiPageMail.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kiwiPageMail.Controls.Add(this.treeViewMailFolders);
            this.kiwiPageMail.Controls.Add(this.panelFoldersSep);
            this.kiwiPageMail.Controls.Add(this.kiwiHeaderFolders);
            this.kiwiPageMail.Controls.Add(this.treeViewMailFavs);
            this.kiwiPageMail.Controls.Add(this.panelFavoriteSep);
            this.kiwiPageMail.Controls.Add(this.kiwiHeaderFavorites);
            this.kiwiPageMail.Flags = 65534;
            this.kiwiPageMail.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kiwiPageMail.ImageLarge")));
            this.kiwiPageMail.ImageMedium = ((System.Drawing.Image)(resources.GetObject("kiwiPageMail.ImageMedium")));
            this.kiwiPageMail.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiPageMail.ImageSmall")));
            this.kiwiPageMail.LastVisibleSet = true;
            this.kiwiPageMail.MinimumSize = new System.Drawing.Size(180, 230);
            this.kiwiPageMail.Name = "kiwiPageMail";
            this.kiwiPageMail.Size = new System.Drawing.Size(181, 295);
            this.kiwiPageMail.Text = "Mail";
            this.kiwiPageMail.TextTitle = "Mail";
            this.kiwiPageMail.ToolTipTitle = "Page ToolTip";
            this.kiwiPageMail.UniqueName = "6D4A539F5AB946C76D4A539F5AB946C7";
            // 
            // treeViewMailFolders
            // 
            this.treeViewMailFolders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewMailFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewMailFolders.HideSelection = false;
            this.treeViewMailFolders.ImageIndex = 0;
            this.treeViewMailFolders.ImageList = this.imageListSmall;
            this.treeViewMailFolders.Location = new System.Drawing.Point(0, 89);
            this.treeViewMailFolders.Name = "treeViewMailFolders";
            treeNode3.Name = "nodeDeletedItems";
            treeNode3.Tag = "0";
            treeNode3.Text = "Deleted Items";
            treeNode4.Name = "nodeDrafts";
            treeNode4.Tag = "1";
            treeNode4.Text = "Drafts";
            treeNode5.Name = "nodeFamily";
            treeNode5.Tag = "3";
            treeNode5.Text = "Family";
            treeNode6.Name = "nodeFriends";
            treeNode6.Tag = "4";
            treeNode6.Text = "Friends";
            treeNode7.Name = "nodeWork";
            treeNode7.Tag = "5";
            treeNode7.Text = "Work";
            treeNode8.Name = "nodeInbox";
            treeNode8.Tag = "2";
            treeNode8.Text = "Inbox";
            treeNode9.Name = "nodeOutbox";
            treeNode9.Tag = "6";
            treeNode9.Text = "Outbox";
            treeNode10.Name = "nodeSentItems";
            treeNode10.Tag = "7";
            treeNode10.Text = "Sent Items";
            this.treeViewMailFolders.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode8,
            treeNode9,
            treeNode10});
            this.treeViewMailFolders.SelectedImageIndex = 0;
            this.treeViewMailFolders.Size = new System.Drawing.Size(181, 206);
            this.treeViewMailFolders.TabIndex = 1;
            this.treeViewMailFolders.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewMail_AfterSelect);
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Magenta;
            this.imageListSmall.Images.SetKeyName(0, "VSFolder_closed.bmp");
            this.imageListSmall.Images.SetKeyName(1, "OpendedClosed.bmp");
            this.imageListSmall.Images.SetKeyName(2, "eps_openHS.png");
            // 
            // panelFoldersSep
            // 
            this.panelFoldersSep.BackColor = System.Drawing.SystemColors.Window;
            this.panelFoldersSep.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFoldersSep.Location = new System.Drawing.Point(0, 84);
            this.panelFoldersSep.Name = "panelFoldersSep";
            this.panelFoldersSep.Size = new System.Drawing.Size(181, 5);
            this.panelFoldersSep.TabIndex = 5;
            // 
            // kiwiHeaderFolders
            // 
            this.kiwiHeaderFolders.Dock = System.Windows.Forms.DockStyle.Top;
            this.kiwiHeaderFolders.HeaderStyle = Kiwi.ComponentFactory.Toolkit.HeaderStyle.Secondary;
            this.kiwiHeaderFolders.Location = new System.Drawing.Point(0, 63);
            this.kiwiHeaderFolders.Name = "kiwiHeaderFolders";
            this.kiwiHeaderFolders.Size = new System.Drawing.Size(181, 21);
            this.kiwiHeaderFolders.StateCommon.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)));
            this.kiwiHeaderFolders.TabIndex = 2;
            this.kiwiHeaderFolders.Values.Description = "";
            this.kiwiHeaderFolders.Values.Heading = "Mail Folders";
            this.kiwiHeaderFolders.Values.Image = null;
            // 
            // treeViewMailFavs
            // 
            this.treeViewMailFavs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewMailFavs.Dock = System.Windows.Forms.DockStyle.Top;
            this.treeViewMailFavs.HideSelection = false;
            this.treeViewMailFavs.ImageIndex = 0;
            this.treeViewMailFavs.ImageList = this.imageListSmall;
            this.treeViewMailFavs.Location = new System.Drawing.Point(0, 25);
            this.treeViewMailFavs.Name = "treeViewMailFavs";
            treeNode11.Name = "nodeDrafts";
            treeNode11.Tag = "1";
            treeNode11.Text = "Drafts";
            treeNode12.Name = "nodeFamily";
            treeNode12.Tag = "3";
            treeNode12.Text = "Family";
            this.treeViewMailFavs.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            this.treeViewMailFavs.SelectedImageIndex = 0;
            this.treeViewMailFavs.Size = new System.Drawing.Size(181, 38);
            this.treeViewMailFavs.TabIndex = 0;
            this.treeViewMailFavs.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewMail_AfterSelect);
            // 
            // panelFavoriteSep
            // 
            this.panelFavoriteSep.BackColor = System.Drawing.SystemColors.Window;
            this.panelFavoriteSep.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFavoriteSep.Location = new System.Drawing.Point(0, 20);
            this.panelFavoriteSep.Name = "panelFavoriteSep";
            this.panelFavoriteSep.Size = new System.Drawing.Size(181, 5);
            this.panelFavoriteSep.TabIndex = 4;
            // 
            // kiwiHeaderFavorites
            // 
            this.kiwiHeaderFavorites.Dock = System.Windows.Forms.DockStyle.Top;
            this.kiwiHeaderFavorites.HeaderStyle = Kiwi.ComponentFactory.Toolkit.HeaderStyle.Secondary;
            this.kiwiHeaderFavorites.Location = new System.Drawing.Point(0, 0);
            this.kiwiHeaderFavorites.Name = "kiwiHeaderFavorites";
            this.kiwiHeaderFavorites.Size = new System.Drawing.Size(181, 20);
            this.kiwiHeaderFavorites.StateCommon.Border.DrawBorders = Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom;
            this.kiwiHeaderFavorites.TabIndex = 1;
            this.kiwiHeaderFavorites.Values.Description = "";
            this.kiwiHeaderFavorites.Values.Heading = "Favorite Folders";
            this.kiwiHeaderFavorites.Values.Image = null;
            // 
            // kiwiPageCalendar
            // 
            this.kiwiPageCalendar.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kiwiPageCalendar.Controls.Add(this.monthCalendar1);
            this.kiwiPageCalendar.Flags = 65534;
            this.kiwiPageCalendar.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kiwiPageCalendar.ImageLarge")));
            this.kiwiPageCalendar.ImageMedium = ((System.Drawing.Image)(resources.GetObject("kiwiPageCalendar.ImageMedium")));
            this.kiwiPageCalendar.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiPageCalendar.ImageSmall")));
            this.kiwiPageCalendar.LastVisibleSet = true;
            this.kiwiPageCalendar.MinimumSize = new System.Drawing.Size(190, 155);
            this.kiwiPageCalendar.Name = "kiwiPageCalendar";
            this.kiwiPageCalendar.Padding = new System.Windows.Forms.Padding(5);
            this.kiwiPageCalendar.Size = new System.Drawing.Size(190, 296);
            this.kiwiPageCalendar.Text = "Calendar";
            this.kiwiPageCalendar.TextTitle = "Calendar";
            this.kiwiPageCalendar.ToolTipTitle = "Page ToolTip";
            this.kiwiPageCalendar.UniqueName = "20332D6AA91B4AF120332D6AA91B4AF1";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(5, 5);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.ShowTodayCircle = false;
            this.monthCalendar1.TabIndex = 0;
            // 
            // kiwiPageNotes
            // 
            this.kiwiPageNotes.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kiwiPageNotes.Controls.Add(this.radioFriends);
            this.kiwiPageNotes.Controls.Add(this.radioFamily);
            this.kiwiPageNotes.Controls.Add(this.radioProject);
            this.kiwiPageNotes.Flags = 65534;
            this.kiwiPageNotes.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kiwiPageNotes.ImageLarge")));
            this.kiwiPageNotes.ImageMedium = ((System.Drawing.Image)(resources.GetObject("kiwiPageNotes.ImageMedium")));
            this.kiwiPageNotes.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiPageNotes.ImageSmall")));
            this.kiwiPageNotes.LastVisibleSet = true;
            this.kiwiPageNotes.MinimumSize = new System.Drawing.Size(50, 50);
            this.kiwiPageNotes.Name = "kiwiPageNotes";
            this.kiwiPageNotes.Padding = new System.Windows.Forms.Padding(20);
            this.kiwiPageNotes.Size = new System.Drawing.Size(181, 296);
            this.kiwiPageNotes.Text = "Notes";
            this.kiwiPageNotes.TextTitle = "Notes";
            this.kiwiPageNotes.ToolTipTitle = "Page ToolTip";
            this.kiwiPageNotes.UniqueName = "F896ACB8955B498FF896ACB8955B498F";
            // 
            // radioFriends
            // 
            this.radioFriends.Location = new System.Drawing.Point(23, 73);
            this.radioFriends.Name = "radioFriends";
            this.radioFriends.Size = new System.Drawing.Size(62, 20);
            this.radioFriends.TabIndex = 8;
            this.radioFriends.Values.Text = "Friends";
            this.radioFriends.CheckedChanged += new System.EventHandler(this.radioNotes_CheckedChanged);
            // 
            // radioFamily
            // 
            this.radioFamily.Location = new System.Drawing.Point(23, 48);
            this.radioFamily.Name = "radioFamily";
            this.radioFamily.Size = new System.Drawing.Size(57, 20);
            this.radioFamily.TabIndex = 7;
            this.radioFamily.Values.Text = "Family";
            this.radioFamily.CheckedChanged += new System.EventHandler(this.radioNotes_CheckedChanged);
            // 
            // radioProject
            // 
            this.radioProject.Checked = true;
            this.radioProject.Location = new System.Drawing.Point(23, 23);
            this.radioProject.Name = "radioProject";
            this.radioProject.Size = new System.Drawing.Size(60, 20);
            this.radioProject.TabIndex = 6;
            this.radioProject.Values.Text = "Project";
            this.radioProject.CheckedChanged += new System.EventHandler(this.radioNotes_CheckedChanged);
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
            this.kiwiSplitContainerDetails.Panel1.Controls.Add(this.kiwiNavigatorDetails);
            // 
            // kiwiSplitContainerDetails.Panel2
            // 
            this.kiwiSplitContainerDetails.Panel2.Controls.Add(this.kiwiButtonGroup);
            this.kiwiSplitContainerDetails.Size = new System.Drawing.Size(516, 442);
            this.kiwiSplitContainerDetails.SplitterDistance = 233;
            this.kiwiSplitContainerDetails.TabIndex = 0;
            // 
            // kiwiNavigatorDetails
            // 
            this.kiwiNavigatorDetails.Button.ButtonDisplayLogic = Kiwi.ComponentFactory.Navigator.ButtonDisplayLogic.None;
            this.kiwiNavigatorDetails.Button.CloseButtonDisplay = Kiwi.ComponentFactory.Navigator.ButtonDisplay.Hide;
            this.kiwiNavigatorDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiwiNavigatorDetails.Header.HeaderVisibleSecondary = false;
            this.kiwiNavigatorDetails.Location = new System.Drawing.Point(0, 0);
            this.kiwiNavigatorDetails.Name = "kiwiNavigatorDetails";
            this.kiwiNavigatorDetails.NavigatorMode = Kiwi.ComponentFactory.Navigator.NavigatorMode.HeaderGroup;
            this.kiwiNavigatorDetails.Pages.AddRange(new Kiwi.ComponentFactory.Navigator.KiwiPage[] {
            this.kiwiPageMailDetails,
            this.kiwiPageCalendarDetails,
            this.kiwiPageNotesDetails});
            this.kiwiNavigatorDetails.SelectedIndex = 0;
            this.kiwiNavigatorDetails.Size = new System.Drawing.Size(516, 233);
            this.kiwiNavigatorDetails.StateCommon.HeaderGroup.HeaderPrimary.Content.Image.ImageH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Far;
            this.kiwiNavigatorDetails.TabIndex = 0;
            this.kiwiNavigatorDetails.Text = "kiwiNavigator1";
            // 
            // kiwiPageMailDetails
            // 
            this.kiwiPageMailDetails.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kiwiPageMailDetails.Controls.Add(this.kiwiDataGridView1);
            this.kiwiPageMailDetails.Flags = 65534;
            this.kiwiPageMailDetails.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kiwiPageMailDetails.ImageLarge")));
            this.kiwiPageMailDetails.ImageMedium = ((System.Drawing.Image)(resources.GetObject("kiwiPageMailDetails.ImageMedium")));
            this.kiwiPageMailDetails.LastVisibleSet = true;
            this.kiwiPageMailDetails.MinimumSize = new System.Drawing.Size(50, 50);
            this.kiwiPageMailDetails.Name = "kiwiPageMailDetails";
            this.kiwiPageMailDetails.Size = new System.Drawing.Size(514, 202);
            this.kiwiPageMailDetails.Text = "Mail";
            this.kiwiPageMailDetails.TextTitle = "Mail";
            this.kiwiPageMailDetails.ToolTipTitle = "Page ToolTip";
            this.kiwiPageMailDetails.UniqueName = "2978E4C56C8641122978E4C56C864112";
            // 
            // kiwiDataGridView1
            // 
            this.kiwiDataGridView1.AllowUserToAddRows = false;
            this.kiwiDataGridView1.AllowUserToDeleteRows = false;
            this.kiwiDataGridView1.AllowUserToResizeRows = false;
            this.kiwiDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgName,
            this.dgSubject,
            this.dgReceived,
            this.dgSize});
            this.kiwiDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiwiDataGridView1.GridStyles.Style = Kiwi.ComponentFactory.Toolkit.DataGridViewStyle.Mixed;
            this.kiwiDataGridView1.GridStyles.StyleBackground = Kiwi.ComponentFactory.Toolkit.PaletteBackStyle.ControlClient;
            this.kiwiDataGridView1.HideOuterBorders = true;
            this.kiwiDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.kiwiDataGridView1.MultiSelect = false;
            this.kiwiDataGridView1.Name = "kiwiDataGridView1";
            this.kiwiDataGridView1.ReadOnly = true;
            this.kiwiDataGridView1.RowHeadersVisible = false;
            this.kiwiDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.kiwiDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kiwiDataGridView1.Size = new System.Drawing.Size(514, 202);
            this.kiwiDataGridView1.StateCommon.BackStyle = Kiwi.ComponentFactory.Toolkit.PaletteBackStyle.ControlClient;
            this.kiwiDataGridView1.StateCommon.DataCell.Border.DrawBorders = Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom;
            this.kiwiDataGridView1.TabIndex = 0;
            // 
            // dgName
            // 
            this.dgName.DataPropertyName = "Name";
            this.dgName.HeaderText = "Name";
            this.dgName.MinimumWidth = 100;
            this.dgName.Name = "dgName";
            this.dgName.ReadOnly = true;
            // 
            // dgSubject
            // 
            this.dgSubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgSubject.DataPropertyName = "Subject";
            this.dgSubject.HeaderText = "Subject";
            this.dgSubject.MinimumWidth = 100;
            this.dgSubject.Name = "dgSubject";
            this.dgSubject.ReadOnly = true;
            // 
            // dgReceived
            // 
            this.dgReceived.DataPropertyName = "Received";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgReceived.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgReceived.HeaderText = "Received";
            this.dgReceived.MinimumWidth = 100;
            this.dgReceived.Name = "dgReceived";
            this.dgReceived.ReadOnly = true;
            // 
            // dgSize
            // 
            this.dgSize.DataPropertyName = "Size";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgSize.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgSize.HeaderText = "Size";
            this.dgSize.MinimumWidth = 50;
            this.dgSize.Name = "dgSize";
            this.dgSize.ReadOnly = true;
            this.dgSize.Width = 50;
            // 
            // kiwiPageCalendarDetails
            // 
            this.kiwiPageCalendarDetails.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kiwiPageCalendarDetails.Controls.Add(this.textBox1);
            this.kiwiPageCalendarDetails.Flags = 65534;
            this.kiwiPageCalendarDetails.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kiwiPageCalendarDetails.ImageLarge")));
            this.kiwiPageCalendarDetails.ImageMedium = ((System.Drawing.Image)(resources.GetObject("kiwiPageCalendarDetails.ImageMedium")));
            this.kiwiPageCalendarDetails.LastVisibleSet = true;
            this.kiwiPageCalendarDetails.MinimumSize = new System.Drawing.Size(50, 50);
            this.kiwiPageCalendarDetails.Name = "kiwiPageCalendarDetails";
            this.kiwiPageCalendarDetails.Padding = new System.Windows.Forms.Padding(5);
            this.kiwiPageCalendarDetails.Size = new System.Drawing.Size(514, 205);
            this.kiwiPageCalendarDetails.Text = "Calendar";
            this.kiwiPageCalendarDetails.TextTitle = "Calendar";
            this.kiwiPageCalendarDetails.ToolTipTitle = "Page ToolTip";
            this.kiwiPageCalendarDetails.UniqueName = "7E4DA62769154DBD7E4DA62769154DBD";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(5, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(504, 195);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // kiwiPageNotesDetails
            // 
            this.kiwiPageNotesDetails.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kiwiPageNotesDetails.Controls.Add(this.listViewNotes);
            this.kiwiPageNotesDetails.Flags = 65534;
            this.kiwiPageNotesDetails.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kiwiPageNotesDetails.ImageLarge")));
            this.kiwiPageNotesDetails.ImageMedium = ((System.Drawing.Image)(resources.GetObject("kiwiPageNotesDetails.ImageMedium")));
            this.kiwiPageNotesDetails.LastVisibleSet = true;
            this.kiwiPageNotesDetails.MinimumSize = new System.Drawing.Size(50, 50);
            this.kiwiPageNotesDetails.Name = "kiwiPageNotesDetails";
            this.kiwiPageNotesDetails.Padding = new System.Windows.Forms.Padding(3, 6, 0, 0);
            this.kiwiPageNotesDetails.Size = new System.Drawing.Size(514, 205);
            this.kiwiPageNotesDetails.Text = "Notes";
            this.kiwiPageNotesDetails.TextTitle = "Notes";
            this.kiwiPageNotesDetails.ToolTipTitle = "Page ToolTip";
            this.kiwiPageNotesDetails.UniqueName = "44092B31BDA3475E44092B31BDA3475E";
            // 
            // listViewNotes
            // 
            this.listViewNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewNotes.LargeImageList = this.imageListLarge;
            this.listViewNotes.Location = new System.Drawing.Point(3, 6);
            this.listViewNotes.Name = "listViewNotes";
            this.listViewNotes.Size = new System.Drawing.Size(511, 199);
            this.listViewNotes.TabIndex = 0;
            this.listViewNotes.UseCompatibleStateImageBehavior = false;
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLarge.Images.SetKeyName(0, "note.png");
            // 
            // kiwiButtonGroup
            // 
            this.kiwiButtonGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiwiButtonGroup.GroupBackStyle = Kiwi.ComponentFactory.Toolkit.PaletteBackStyle.PanelAlternate;
            this.kiwiButtonGroup.GroupBorderStyle = Kiwi.ComponentFactory.Toolkit.PaletteBorderStyle.ControlAlternate;
            this.kiwiButtonGroup.Location = new System.Drawing.Point(0, 0);
            this.kiwiButtonGroup.Name = "kiwiButtonGroup";
            // 
            // kiwiButtonGroup.Panel
            // 
            this.kiwiButtonGroup.Panel.Controls.Add(this.kiwiGroupInner);
            this.kiwiButtonGroup.Panel.Padding = new System.Windows.Forms.Padding(5);
            this.kiwiButtonGroup.Size = new System.Drawing.Size(516, 204);
            this.kiwiButtonGroup.TabIndex = 0;
            // 
            // kiwiGroupInner
            // 
            this.kiwiGroupInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiwiGroupInner.Location = new System.Drawing.Point(5, 5);
            this.kiwiGroupInner.Name = "kiwiGroupInner";
            // 
            // kiwiGroupInner.Panel
            // 
            this.kiwiGroupInner.Panel.Controls.Add(this.radioOffice2010Black);
            this.kiwiGroupInner.Panel.Controls.Add(this.radioOffice2010Silver);
            this.kiwiGroupInner.Panel.Controls.Add(this.radioOffice2010Blue);
            this.kiwiGroupInner.Panel.Controls.Add(this.radioSparkle);
            this.kiwiGroupInner.Panel.Controls.Add(this.radioSystem);
            this.kiwiGroupInner.Panel.Controls.Add(this.radioOffice2003);
            this.kiwiGroupInner.Panel.Controls.Add(this.radioOffice2007Black);
            this.kiwiGroupInner.Panel.Controls.Add(this.radioOffice2007Silver);
            this.kiwiGroupInner.Panel.Controls.Add(this.radioOffice2007Blue);
            this.kiwiGroupInner.Size = new System.Drawing.Size(504, 192);
            this.kiwiGroupInner.TabIndex = 0;
            // 
            // radioSparkle
            // 
            this.radioSparkle.Location = new System.Drawing.Point(288, 44);
            this.radioSparkle.Name = "radioSparkle";
            this.radioSparkle.Size = new System.Drawing.Size(60, 19);
            this.radioSparkle.TabIndex = 7;
            this.radioSparkle.Values.Text = "Sparkle";
            this.radioSparkle.CheckedChanged += new System.EventHandler(this.radioSparkle_CheckedChanged);
            // 
            // radioSystem
            // 
            this.radioSystem.Location = new System.Drawing.Point(288, 68);
            this.radioSystem.Name = "radioSystem";
            this.radioSystem.Size = new System.Drawing.Size(59, 19);
            this.radioSystem.TabIndex = 8;
            this.radioSystem.Values.Text = "System";
            this.radioSystem.CheckedChanged += new System.EventHandler(this.radioSystem_CheckedChanged);
            // 
            // radioOffice2003
            // 
            this.radioOffice2003.Location = new System.Drawing.Point(288, 20);
            this.radioOffice2003.Name = "radioOffice2003";
            this.radioOffice2003.Size = new System.Drawing.Size(81, 19);
            this.radioOffice2003.TabIndex = 6;
            this.radioOffice2003.Values.Text = "Office 2003";
            this.radioOffice2003.CheckedChanged += new System.EventHandler(this.radioOffice2003_CheckedChanged);
            // 
            // radioOffice2007Black
            // 
            this.radioOffice2007Black.Location = new System.Drawing.Point(153, 68);
            this.radioOffice2007Black.Name = "radioOffice2007Black";
            this.radioOffice2007Black.Size = new System.Drawing.Size(119, 19);
            this.radioOffice2007Black.TabIndex = 5;
            this.radioOffice2007Black.Values.Text = "Office 2007 - Black";
            this.radioOffice2007Black.CheckedChanged += new System.EventHandler(this.radioOffice2007Black_CheckedChanged);
            // 
            // radioOffice2007Silver
            // 
            this.radioOffice2007Silver.Location = new System.Drawing.Point(153, 45);
            this.radioOffice2007Silver.Name = "radioOffice2007Silver";
            this.radioOffice2007Silver.Size = new System.Drawing.Size(120, 19);
            this.radioOffice2007Silver.TabIndex = 4;
            this.radioOffice2007Silver.Values.Text = "Office 2007 - Silver";
            this.radioOffice2007Silver.CheckedChanged += new System.EventHandler(this.radioOffice2007Silver_CheckedChanged);
            // 
            // radioOffice2007Blue
            // 
            this.radioOffice2007Blue.Location = new System.Drawing.Point(153, 20);
            this.radioOffice2007Blue.Name = "radioOffice2007Blue";
            this.radioOffice2007Blue.Size = new System.Drawing.Size(114, 19);
            this.radioOffice2007Blue.TabIndex = 3;
            this.radioOffice2007Blue.Values.Text = "Office 2007 - Blue";
            this.radioOffice2007Blue.CheckedChanged += new System.EventHandler(this.radioOffice2007Blue_CheckedChanged);
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "NewDataSet";
            this.dataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.dtDeletedItems,
            this.dtDrafts,
            this.dtFamily,
            this.dtOutbox,
            this.dtSentItems,
            this.dtFriends,
            this.dtWork,
            this.dtInbox});
            // 
            // dtDeletedItems
            // 
            this.dtDeletedItems.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4});
            this.dtDeletedItems.TableName = "Deleted Items";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Name";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Subject";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Received";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Size";
            // 
            // dtDrafts
            // 
            this.dtDrafts.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8});
            this.dtDrafts.TableName = "Drafts";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Name";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "Subject";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "Received";
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "Size";
            // 
            // dtFamily
            // 
            this.dtFamily.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11,
            this.dataColumn12});
            this.dtFamily.TableName = "Family";
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "Name";
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "Subject";
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "Received";
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "Size";
            // 
            // dtOutbox
            // 
            this.dtOutbox.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn13,
            this.dataColumn14,
            this.dataColumn15,
            this.dataColumn16});
            this.dtOutbox.TableName = "Outbox";
            // 
            // dataColumn13
            // 
            this.dataColumn13.ColumnName = "Name";
            // 
            // dataColumn14
            // 
            this.dataColumn14.ColumnName = "Subject";
            // 
            // dataColumn15
            // 
            this.dataColumn15.ColumnName = "Received";
            // 
            // dataColumn16
            // 
            this.dataColumn16.ColumnName = "Size";
            // 
            // dtSentItems
            // 
            this.dtSentItems.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn17,
            this.dataColumn18,
            this.dataColumn19,
            this.dataColumn20});
            this.dtSentItems.TableName = "Sent Items";
            // 
            // dataColumn17
            // 
            this.dataColumn17.ColumnName = "Name";
            // 
            // dataColumn18
            // 
            this.dataColumn18.ColumnName = "Subject";
            // 
            // dataColumn19
            // 
            this.dataColumn19.ColumnName = "Received";
            // 
            // dataColumn20
            // 
            this.dataColumn20.ColumnName = "Size";
            // 
            // dtFriends
            // 
            this.dtFriends.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn21,
            this.dataColumn22,
            this.dataColumn23,
            this.dataColumn24});
            this.dtFriends.TableName = "Friends";
            // 
            // dataColumn21
            // 
            this.dataColumn21.ColumnName = "Name";
            // 
            // dataColumn22
            // 
            this.dataColumn22.ColumnName = "Subject";
            // 
            // dataColumn23
            // 
            this.dataColumn23.ColumnName = "Received";
            // 
            // dataColumn24
            // 
            this.dataColumn24.ColumnName = "Size";
            // 
            // dtWork
            // 
            this.dtWork.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn25,
            this.dataColumn26,
            this.dataColumn27,
            this.dataColumn28});
            this.dtWork.TableName = "Work";
            // 
            // dataColumn25
            // 
            this.dataColumn25.ColumnName = "Work";
            // 
            // dataColumn26
            // 
            this.dataColumn26.ColumnName = "Subject";
            // 
            // dataColumn27
            // 
            this.dataColumn27.ColumnName = "Received";
            // 
            // dataColumn28
            // 
            this.dataColumn28.ColumnName = "Size";
            // 
            // dtInbox
            // 
            this.dtInbox.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn29,
            this.dataColumn30,
            this.dataColumn31,
            this.dataColumn32});
            this.dtInbox.TableName = "Inbox";
            // 
            // dataColumn29
            // 
            this.dataColumn29.ColumnName = "Name";
            // 
            // dataColumn30
            // 
            this.dataColumn30.ColumnName = "Subject";
            // 
            // dataColumn31
            // 
            this.dataColumn31.ColumnName = "Received";
            // 
            // dataColumn32
            // 
            this.dataColumn32.ColumnName = "Size";
            // 
            // radioOffice2010Black
            // 
            this.radioOffice2010Black.Location = new System.Drawing.Point(17, 68);
            this.radioOffice2010Black.Name = "radioOffice2010Black";
            this.radioOffice2010Black.Size = new System.Drawing.Size(119, 19);
            this.radioOffice2010Black.TabIndex = 2;
            this.radioOffice2010Black.Values.Text = "Office 2010 - Black";
            this.radioOffice2010Black.CheckedChanged += new System.EventHandler(this.radioOffice2010Black_CheckedChanged);
            // 
            // radioOffice2010Silver
            // 
            this.radioOffice2010Silver.Location = new System.Drawing.Point(17, 45);
            this.radioOffice2010Silver.Name = "radioOffice2010Silver";
            this.radioOffice2010Silver.Size = new System.Drawing.Size(120, 19);
            this.radioOffice2010Silver.TabIndex = 1;
            this.radioOffice2010Silver.Values.Text = "Office 2010 - Silver";
            this.radioOffice2010Silver.CheckedChanged += new System.EventHandler(this.radioOffice2010Silver_CheckedChanged);
            // 
            // radioOffice2010Blue
            // 
            this.radioOffice2010Blue.Checked = true;
            this.radioOffice2010Blue.Location = new System.Drawing.Point(17, 20);
            this.radioOffice2010Blue.Name = "radioOffice2010Blue";
            this.radioOffice2010Blue.Size = new System.Drawing.Size(114, 19);
            this.radioOffice2010Blue.TabIndex = 0;
            this.radioOffice2010Blue.Values.Text = "Office 2010 - Blue";
            this.radioOffice2010Blue.CheckedChanged += new System.EventHandler(this.radioOffice2010Blue_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 499);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(417, 308);
            this.Name = "Form1";
            this.Text = "Outlook 2003 Mockup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.kiwiNavigatorMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPageMail)).EndInit();
            this.kiwiPageMail.ResumeLayout(false);
            this.kiwiPageMail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPageCalendar)).EndInit();
            this.kiwiPageCalendar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPageNotes)).EndInit();
            this.kiwiPageNotes.ResumeLayout(false);
            this.kiwiPageNotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiSplitContainerDetails.Panel1)).EndInit();
            this.kiwiSplitContainerDetails.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiSplitContainerDetails.Panel2)).EndInit();
            this.kiwiSplitContainerDetails.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiSplitContainerDetails)).EndInit();
            this.kiwiSplitContainerDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiNavigatorDetails)).EndInit();
            this.kiwiNavigatorDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPageMailDetails)).EndInit();
            this.kiwiPageMailDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPageCalendarDetails)).EndInit();
            this.kiwiPageCalendarDetails.ResumeLayout(false);
            this.kiwiPageCalendarDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPageNotesDetails)).EndInit();
            this.kiwiPageNotesDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiButtonGroup.Panel)).EndInit();
            this.kiwiButtonGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiButtonGroup)).EndInit();
            this.kiwiButtonGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiGroupInner.Panel)).EndInit();
            this.kiwiGroupInner.Panel.ResumeLayout(false);
            this.kiwiGroupInner.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiGroupInner)).EndInit();
            this.kiwiGroupInner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDeletedItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDrafts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFamily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOutbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSentItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private Kiwi.ComponentFactory.Toolkit.KiwiPanel kiwiPanelMain;
        private Kiwi.ComponentFactory.Toolkit.KiwiSplitContainer kiwiSplitContainerMain;
        private Kiwi.ComponentFactory.Toolkit.KiwiSplitContainer kiwiSplitContainerDetails;
        private Kiwi.ComponentFactory.Toolkit.KiwiGroup kiwiButtonGroup;
        private Kiwi.ComponentFactory.Toolkit.KiwiManager kiwiManager;
        private Kiwi.ComponentFactory.Toolkit.KiwiGroup kiwiGroupInner;
        private Kiwi.ComponentFactory.Navigator.KiwiNavigator kiwiNavigatorMain;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPageMail;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPageCalendar;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPageNotes;
        private System.Windows.Forms.TreeView treeViewMailFolders;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private Kiwi.ComponentFactory.Navigator.KiwiNavigator kiwiNavigatorDetails;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPageMailDetails;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPageCalendarDetails;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPageNotesDetails;
        private System.Windows.Forms.ListView listViewNotes;
        private System.Windows.Forms.ImageList imageListLarge;
        private System.Windows.Forms.TreeView treeViewMailFavs;
        private Kiwi.ComponentFactory.Toolkit.KiwiHeader kiwiHeaderFolders;
        private Kiwi.ComponentFactory.Toolkit.KiwiHeader kiwiHeaderFavorites;
        private System.Windows.Forms.Panel panelFoldersSep;
        private System.Windows.Forms.Panel panelFavoriteSep;
        private System.Windows.Forms.TextBox textBox1;
        private Kiwi.ComponentFactory.Navigator.ButtonSpecNavigator buttonSpecExpandCollapse;
        private Kiwi.ComponentFactory.Toolkit.KiwiRadioButton radioSystem;
        private Kiwi.ComponentFactory.Toolkit.KiwiRadioButton radioOffice2003;
        private Kiwi.ComponentFactory.Toolkit.KiwiRadioButton radioOffice2007Black;
        private Kiwi.ComponentFactory.Toolkit.KiwiRadioButton radioOffice2007Silver;
        private Kiwi.ComponentFactory.Toolkit.KiwiRadioButton radioOffice2007Blue;
        private Kiwi.ComponentFactory.Toolkit.KiwiRadioButton radioFriends;
        private Kiwi.ComponentFactory.Toolkit.KiwiRadioButton radioFamily;
        private Kiwi.ComponentFactory.Toolkit.KiwiRadioButton radioProject;
        private Kiwi.ComponentFactory.Toolkit.KiwiDataGridView kiwiDataGridView1;
        private System.Data.DataSet dataSet;
        private System.Data.DataTable dtDeletedItems;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataTable dtDrafts;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataTable dtFamily;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn12;
        private System.Data.DataTable dtOutbox;
        private System.Data.DataColumn dataColumn13;
        private System.Data.DataColumn dataColumn14;
        private System.Data.DataColumn dataColumn15;
        private System.Data.DataColumn dataColumn16;
        private System.Data.DataTable dtSentItems;
        private System.Data.DataColumn dataColumn17;
        private System.Data.DataColumn dataColumn18;
        private System.Data.DataColumn dataColumn19;
        private System.Data.DataColumn dataColumn20;
        private System.Data.DataTable dtFriends;
        private System.Data.DataColumn dataColumn21;
        private System.Data.DataColumn dataColumn22;
        private System.Data.DataColumn dataColumn23;
        private System.Data.DataColumn dataColumn24;
        private System.Data.DataTable dtWork;
        private System.Data.DataColumn dataColumn25;
        private System.Data.DataColumn dataColumn26;
        private System.Data.DataColumn dataColumn27;
        private System.Data.DataColumn dataColumn28;
        private System.Data.DataTable dtInbox;
        private System.Data.DataColumn dataColumn29;
        private System.Data.DataColumn dataColumn30;
        private System.Data.DataColumn dataColumn31;
        private System.Data.DataColumn dataColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgReceived;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSize;
        private Kiwi.ComponentFactory.Toolkit.KiwiRadioButton radioSparkle;
        private Kiwi.ComponentFactory.Toolkit.KiwiRadioButton radioOffice2010Black;
        private Kiwi.ComponentFactory.Toolkit.KiwiRadioButton radioOffice2010Silver;
        private Kiwi.ComponentFactory.Toolkit.KiwiRadioButton radioOffice2010Blue;
    }
}

