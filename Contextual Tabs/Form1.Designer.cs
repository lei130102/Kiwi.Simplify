
namespace Contextual_Tabs
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
            this.contextDefRed = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonContext();
            this.contextDefGreen = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonContext();
            this.tabHome = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonTab();
            this.contextRed = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonTab();
            this.contextGreen1 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonTab();
            this.contextGreen2 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonTab();
            this.labelOffice2007Styles = new Kiwi.ComponentFactory.Toolkit.KiwiPanel();
            this.groupOffice2007Styles = new Kiwi.ComponentFactory.Toolkit.KiwiGroup();
            this.radioSparkleOrange = new Kiwi.ComponentFactory.Toolkit.KiwiRadioButton();
            this.radioSparklePurple = new Kiwi.ComponentFactory.Toolkit.KiwiRadioButton();
            this.radioSparkleBlue = new Kiwi.ComponentFactory.Toolkit.KiwiRadioButton();
            this.radioSystem = new Kiwi.ComponentFactory.Toolkit.KiwiRadioButton();
            this.radioOffice2003 = new Kiwi.ComponentFactory.Toolkit.KiwiRadioButton();
            this.radioOffice2007Black = new Kiwi.ComponentFactory.Toolkit.KiwiRadioButton();
            this.radioOffice2007Silver = new Kiwi.ComponentFactory.Toolkit.KiwiRadioButton();
            this.radioOffice2007Blue = new Kiwi.ComponentFactory.Toolkit.KiwiRadioButton();
            this.kiwiLabel2 = new Kiwi.ComponentFactory.Toolkit.KiwiLabel();
            this.groupAddContext = new Kiwi.ComponentFactory.Toolkit.KiwiGroup();
            this.buttonAddContext = new Kiwi.ComponentFactory.Toolkit.KiwiButton();
            this.panelContextColor = new Kiwi.ComponentFactory.Toolkit.KiwiPanel();
            this.buttonEditColor = new Kiwi.ComponentFactory.Toolkit.KiwiButton();
            this.labelContextColor = new Kiwi.ComponentFactory.Toolkit.KiwiLabel();
            this.textBoxContextTitle = new Kiwi.ComponentFactory.Toolkit.KiwiTextBox();
            this.labelContextTitle = new Kiwi.ComponentFactory.Toolkit.KiwiLabel();
            this.labelContextName = new Kiwi.ComponentFactory.Toolkit.KiwiLabel();
            this.textBoxContextName = new Kiwi.ComponentFactory.Toolkit.KiwiTextBox();
            this.kiwiLabel1 = new Kiwi.ComponentFactory.Toolkit.KiwiLabel();
            this.groupSelectedContexts = new Kiwi.ComponentFactory.Toolkit.KiwiGroup();
            this.labelSelectedContexts = new Kiwi.ComponentFactory.Toolkit.KiwiLabel();
            this.buttonSelectedApply = new Kiwi.ComponentFactory.Toolkit.KiwiButton();
            this.textBoxSelectedContexts = new Kiwi.ComponentFactory.Toolkit.KiwiTextBox();
            this.labelContextsInstructions = new Kiwi.ComponentFactory.Toolkit.KiwiLabel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.kiwiManager = new Kiwi.ComponentFactory.Toolkit.KiwiManager(this.components);
            this.radioOffice2010Black = new Kiwi.ComponentFactory.Toolkit.KiwiRadioButton();
            this.radioOffice2010Silver = new Kiwi.ComponentFactory.Toolkit.KiwiRadioButton();
            this.radioOffice2010Blue = new Kiwi.ComponentFactory.Toolkit.KiwiRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiRibbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelOffice2007Styles)).BeginInit();
            this.labelOffice2007Styles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupOffice2007Styles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupOffice2007Styles.Panel)).BeginInit();
            this.groupOffice2007Styles.Panel.SuspendLayout();
            this.groupOffice2007Styles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupAddContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupAddContext.Panel)).BeginInit();
            this.groupAddContext.Panel.SuspendLayout();
            this.groupAddContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelContextColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupSelectedContexts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupSelectedContexts.Panel)).BeginInit();
            this.groupSelectedContexts.Panel.SuspendLayout();
            this.groupSelectedContexts.SuspendLayout();
            this.SuspendLayout();
            // 
            // kiwiRibbon
            // 
            this.kiwiRibbon.Name = "kiwiRibbon";
            this.kiwiRibbon.RibbonAppButton.AppButtonMenuItems.AddRange(new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItemBase[] {
            this.kiwiContextMenuItem1});
            this.kiwiRibbon.RibbonAppButton.AppButtonShowRecentDocs = false;
            this.kiwiRibbon.RibbonContexts.AddRange(new Kiwi.ComponentFactory.Ribbon.KiwiRibbonContext[] {
            this.contextDefRed,
            this.contextDefGreen});
            this.kiwiRibbon.RibbonTabs.AddRange(new Kiwi.ComponentFactory.Ribbon.KiwiRibbonTab[] {
            this.tabHome,
            this.contextRed,
            this.contextGreen1,
            this.contextGreen2});
            this.kiwiRibbon.SelectedContext = "Red,Green";
            this.kiwiRibbon.SelectedTab = this.contextGreen1;
            this.kiwiRibbon.Size = new System.Drawing.Size(594, 114);
            this.kiwiRibbon.TabIndex = 0;
            // 
            // kiwiContextMenuItem1
            // 
            this.kiwiContextMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("kiwiContextMenuItem1.Image")));
            this.kiwiContextMenuItem1.Text = "E&xit";
            this.kiwiContextMenuItem1.Click += new System.EventHandler(this.appMenu_Click);
            // 
            // contextDefRed
            // 
            this.contextDefRed.ContextName = "Red";
            this.contextDefRed.ContextTitle = "Red";
            // 
            // contextDefGreen
            // 
            this.contextDefGreen.ContextColor = System.Drawing.Color.LimeGreen;
            this.contextDefGreen.ContextName = "Green";
            this.contextDefGreen.ContextTitle = "Green";
            // 
            // tabHome
            // 
            this.tabHome.Text = "Home";
            // 
            // contextRed
            // 
            this.contextRed.ContextName = "Red";
            this.contextRed.Text = "Red";
            // 
            // contextGreen1
            // 
            this.contextGreen1.ContextName = "Green";
            this.contextGreen1.Text = "Green1";
            // 
            // contextGreen2
            // 
            this.contextGreen2.ContextName = "Green";
            this.contextGreen2.Text = "Green2";
            // 
            // labelOffice2007Styles
            // 
            this.labelOffice2007Styles.Controls.Add(this.groupOffice2007Styles);
            this.labelOffice2007Styles.Controls.Add(this.groupAddContext);
            this.labelOffice2007Styles.Controls.Add(this.groupSelectedContexts);
            this.labelOffice2007Styles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOffice2007Styles.Location = new System.Drawing.Point(0, 114);
            this.labelOffice2007Styles.Name = "labelOffice2007Styles";
            this.labelOffice2007Styles.Size = new System.Drawing.Size(594, 374);
            this.labelOffice2007Styles.TabIndex = 1;
            // 
            // groupOffice2007Styles
            // 
            this.groupOffice2007Styles.GroupBackStyle = Kiwi.ComponentFactory.Toolkit.PaletteBackStyle.PanelAlternate;
            this.groupOffice2007Styles.Location = new System.Drawing.Point(401, 16);
            this.groupOffice2007Styles.Name = "groupOffice2007Styles";
            // 
            // groupOffice2007Styles.Panel
            // 
            this.groupOffice2007Styles.Panel.Controls.Add(this.radioOffice2010Black);
            this.groupOffice2007Styles.Panel.Controls.Add(this.radioOffice2010Silver);
            this.groupOffice2007Styles.Panel.Controls.Add(this.radioOffice2010Blue);
            this.groupOffice2007Styles.Panel.Controls.Add(this.radioSparkleOrange);
            this.groupOffice2007Styles.Panel.Controls.Add(this.radioSparklePurple);
            this.groupOffice2007Styles.Panel.Controls.Add(this.radioSparkleBlue);
            this.groupOffice2007Styles.Panel.Controls.Add(this.radioSystem);
            this.groupOffice2007Styles.Panel.Controls.Add(this.radioOffice2003);
            this.groupOffice2007Styles.Panel.Controls.Add(this.radioOffice2007Black);
            this.groupOffice2007Styles.Panel.Controls.Add(this.radioOffice2007Silver);
            this.groupOffice2007Styles.Panel.Controls.Add(this.radioOffice2007Blue);
            this.groupOffice2007Styles.Panel.Controls.Add(this.kiwiLabel2);
            this.groupOffice2007Styles.Size = new System.Drawing.Size(180, 305);
            this.groupOffice2007Styles.TabIndex = 0;
            // 
            // radioSparkleOrange
            // 
            this.radioSparkleOrange.LabelStyle = Kiwi.ComponentFactory.Toolkit.LabelStyle.NormalPanel;
            this.radioSparkleOrange.Location = new System.Drawing.Point(20, 222);
            this.radioSparkleOrange.Name = "radioSparkleOrange";
            this.radioSparkleOrange.Size = new System.Drawing.Size(110, 19);
            this.radioSparkleOrange.TabIndex = 9;
            this.radioSparkleOrange.Values.Text = "Sparkle - Orange";
            this.radioSparkleOrange.CheckedChanged += new System.EventHandler(this.radioSparkleOrange_CheckedChanged);
            // 
            // radioSparklePurple
            // 
            this.radioSparklePurple.LabelStyle = Kiwi.ComponentFactory.Toolkit.LabelStyle.NormalPanel;
            this.radioSparklePurple.Location = new System.Drawing.Point(20, 245);
            this.radioSparklePurple.Name = "radioSparklePurple";
            this.radioSparklePurple.Size = new System.Drawing.Size(104, 19);
            this.radioSparklePurple.TabIndex = 10;
            this.radioSparklePurple.Values.Text = "Sparkle - Purple";
            this.radioSparklePurple.CheckedChanged += new System.EventHandler(this.radioSparklePurple_CheckedChanged);
            // 
            // radioSparkleBlue
            // 
            this.radioSparkleBlue.LabelStyle = Kiwi.ComponentFactory.Toolkit.LabelStyle.NormalPanel;
            this.radioSparkleBlue.Location = new System.Drawing.Point(20, 199);
            this.radioSparkleBlue.Name = "radioSparkleBlue";
            this.radioSparkleBlue.Size = new System.Drawing.Size(93, 19);
            this.radioSparkleBlue.TabIndex = 8;
            this.radioSparkleBlue.Values.Text = "Sparkle - Blue";
            this.radioSparkleBlue.CheckedChanged += new System.EventHandler(this.radioSparkleBlue_CheckedChanged);
            // 
            // radioSystem
            // 
            this.radioSystem.LabelStyle = Kiwi.ComponentFactory.Toolkit.LabelStyle.NormalPanel;
            this.radioSystem.Location = new System.Drawing.Point(21, 268);
            this.radioSystem.Name = "radioSystem";
            this.radioSystem.Size = new System.Drawing.Size(59, 19);
            this.radioSystem.TabIndex = 11;
            this.radioSystem.Values.Text = "System";
            this.radioSystem.CheckedChanged += new System.EventHandler(this.radioSystem_CheckedChanged);
            // 
            // radioOffice2003
            // 
            this.radioOffice2003.LabelStyle = Kiwi.ComponentFactory.Toolkit.LabelStyle.NormalPanel;
            this.radioOffice2003.Location = new System.Drawing.Point(20, 176);
            this.radioOffice2003.Name = "radioOffice2003";
            this.radioOffice2003.Size = new System.Drawing.Size(81, 19);
            this.radioOffice2003.TabIndex = 7;
            this.radioOffice2003.Values.Text = "Office 2003";
            this.radioOffice2003.CheckedChanged += new System.EventHandler(this.radioOffice2003_CheckedChanged);
            // 
            // radioOffice2007Black
            // 
            this.radioOffice2007Black.LabelStyle = Kiwi.ComponentFactory.Toolkit.LabelStyle.NormalPanel;
            this.radioOffice2007Black.Location = new System.Drawing.Point(20, 153);
            this.radioOffice2007Black.Name = "radioOffice2007Black";
            this.radioOffice2007Black.Size = new System.Drawing.Size(119, 19);
            this.radioOffice2007Black.TabIndex = 6;
            this.radioOffice2007Black.Values.Text = "Office 2007 - Black";
            this.radioOffice2007Black.CheckedChanged += new System.EventHandler(this.radioOffice2007Black_CheckedChanged);
            // 
            // radioOffice2007Silver
            // 
            this.radioOffice2007Silver.LabelStyle = Kiwi.ComponentFactory.Toolkit.LabelStyle.NormalPanel;
            this.radioOffice2007Silver.Location = new System.Drawing.Point(20, 130);
            this.radioOffice2007Silver.Name = "radioOffice2007Silver";
            this.radioOffice2007Silver.Size = new System.Drawing.Size(120, 19);
            this.radioOffice2007Silver.TabIndex = 5;
            this.radioOffice2007Silver.Values.Text = "Office 2007 - Silver";
            this.radioOffice2007Silver.CheckedChanged += new System.EventHandler(this.radioOffice2007Silver_CheckedChanged);
            // 
            // radioOffice2007Blue
            // 
            this.radioOffice2007Blue.LabelStyle = Kiwi.ComponentFactory.Toolkit.LabelStyle.NormalPanel;
            this.radioOffice2007Blue.Location = new System.Drawing.Point(20, 107);
            this.radioOffice2007Blue.Name = "radioOffice2007Blue";
            this.radioOffice2007Blue.Size = new System.Drawing.Size(114, 19);
            this.radioOffice2007Blue.TabIndex = 4;
            this.radioOffice2007Blue.Values.Text = "Office 2007 - Blue";
            this.radioOffice2007Blue.CheckedChanged += new System.EventHandler(this.radioOffice2007Blue_CheckedChanged);
            // 
            // kiwiLabel2
            // 
            this.kiwiLabel2.LabelStyle = Kiwi.ComponentFactory.Toolkit.LabelStyle.TitlePanel;
            this.kiwiLabel2.Location = new System.Drawing.Point(4, 4);
            this.kiwiLabel2.Name = "kiwiLabel2";
            this.kiwiLabel2.Size = new System.Drawing.Size(130, 28);
            this.kiwiLabel2.TabIndex = 0;
            this.kiwiLabel2.Values.Text = "Global Palette";
            // 
            // groupAddContext
            // 
            this.groupAddContext.GroupBackStyle = Kiwi.ComponentFactory.Toolkit.PaletteBackStyle.PanelAlternate;
            this.groupAddContext.Location = new System.Drawing.Point(16, 160);
            this.groupAddContext.Name = "groupAddContext";
            // 
            // groupAddContext.Panel
            // 
            this.groupAddContext.Panel.Controls.Add(this.buttonAddContext);
            this.groupAddContext.Panel.Controls.Add(this.panelContextColor);
            this.groupAddContext.Panel.Controls.Add(this.buttonEditColor);
            this.groupAddContext.Panel.Controls.Add(this.labelContextColor);
            this.groupAddContext.Panel.Controls.Add(this.textBoxContextTitle);
            this.groupAddContext.Panel.Controls.Add(this.labelContextTitle);
            this.groupAddContext.Panel.Controls.Add(this.labelContextName);
            this.groupAddContext.Panel.Controls.Add(this.textBoxContextName);
            this.groupAddContext.Panel.Controls.Add(this.kiwiLabel1);
            this.groupAddContext.Size = new System.Drawing.Size(371, 161);
            this.groupAddContext.TabIndex = 5;
            // 
            // buttonAddContext
            // 
            this.buttonAddContext.AutoSize = true;
            this.buttonAddContext.Location = new System.Drawing.Point(97, 123);
            this.buttonAddContext.Name = "buttonAddContext";
            this.buttonAddContext.Size = new System.Drawing.Size(94, 24);
            this.buttonAddContext.TabIndex = 10;
            this.buttonAddContext.Values.Text = "Add Context";
            this.buttonAddContext.Click += new System.EventHandler(this.buttonAddContext_Click);
            // 
            // panelContextColor
            // 
            this.panelContextColor.Location = new System.Drawing.Point(97, 88);
            this.panelContextColor.Name = "panelContextColor";
            this.panelContextColor.Size = new System.Drawing.Size(94, 23);
            this.panelContextColor.StateCommon.Color1 = System.Drawing.Color.DodgerBlue;
            this.panelContextColor.TabIndex = 9;
            // 
            // buttonEditColor
            // 
            this.buttonEditColor.AutoSize = true;
            this.buttonEditColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEditColor.Location = new System.Drawing.Point(197, 88);
            this.buttonEditColor.Name = "buttonEditColor";
            this.buttonEditColor.Size = new System.Drawing.Size(75, 23);
            this.buttonEditColor.TabIndex = 8;
            this.buttonEditColor.Values.Text = "Define Color";
            this.buttonEditColor.Click += new System.EventHandler(this.buttonEditColor_Click);
            // 
            // labelContextColor
            // 
            this.labelContextColor.AutoSize = false;
            this.labelContextColor.LabelStyle = Kiwi.ComponentFactory.Toolkit.LabelStyle.NormalPanel;
            this.labelContextColor.Location = new System.Drawing.Point(9, 88);
            this.labelContextColor.Name = "labelContextColor";
            this.labelContextColor.Size = new System.Drawing.Size(82, 22);
            this.labelContextColor.StateCommon.ShortText.TextH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Far;
            this.labelContextColor.TabIndex = 7;
            this.labelContextColor.Values.Text = "Context Color";
            // 
            // textBoxContextTitle
            // 
            this.textBoxContextTitle.Location = new System.Drawing.Point(97, 62);
            this.textBoxContextTitle.Name = "textBoxContextTitle";
            this.textBoxContextTitle.Size = new System.Drawing.Size(95, 20);
            this.textBoxContextTitle.TabIndex = 6;
            this.textBoxContextTitle.Text = "Tools";
            // 
            // labelContextTitle
            // 
            this.labelContextTitle.AutoSize = false;
            this.labelContextTitle.LabelStyle = Kiwi.ComponentFactory.Toolkit.LabelStyle.NormalPanel;
            this.labelContextTitle.Location = new System.Drawing.Point(9, 63);
            this.labelContextTitle.Name = "labelContextTitle";
            this.labelContextTitle.Size = new System.Drawing.Size(82, 22);
            this.labelContextTitle.StateCommon.ShortText.TextH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Far;
            this.labelContextTitle.TabIndex = 5;
            this.labelContextTitle.Values.Text = "Context Title";
            // 
            // labelContextName
            // 
            this.labelContextName.AutoSize = false;
            this.labelContextName.LabelStyle = Kiwi.ComponentFactory.Toolkit.LabelStyle.NormalPanel;
            this.labelContextName.Location = new System.Drawing.Point(9, 38);
            this.labelContextName.Name = "labelContextName";
            this.labelContextName.Size = new System.Drawing.Size(82, 22);
            this.labelContextName.StateCommon.ShortText.TextH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Far;
            this.labelContextName.TabIndex = 4;
            this.labelContextName.Values.Text = "Context Name";
            // 
            // textBoxContextName
            // 
            this.textBoxContextName.Location = new System.Drawing.Point(97, 37);
            this.textBoxContextName.Name = "textBoxContextName";
            this.textBoxContextName.Size = new System.Drawing.Size(95, 20);
            this.textBoxContextName.TabIndex = 3;
            this.textBoxContextName.Text = "Blue";
            // 
            // kiwiLabel1
            // 
            this.kiwiLabel1.LabelStyle = Kiwi.ComponentFactory.Toolkit.LabelStyle.TitlePanel;
            this.kiwiLabel1.Location = new System.Drawing.Point(4, 4);
            this.kiwiLabel1.Name = "kiwiLabel1";
            this.kiwiLabel1.Size = new System.Drawing.Size(118, 28);
            this.kiwiLabel1.TabIndex = 2;
            this.kiwiLabel1.Values.Text = "Add Context";
            // 
            // groupSelectedContexts
            // 
            this.groupSelectedContexts.GroupBackStyle = Kiwi.ComponentFactory.Toolkit.PaletteBackStyle.PanelAlternate;
            this.groupSelectedContexts.Location = new System.Drawing.Point(16, 16);
            this.groupSelectedContexts.Name = "groupSelectedContexts";
            // 
            // groupSelectedContexts.Panel
            // 
            this.groupSelectedContexts.Panel.Controls.Add(this.labelSelectedContexts);
            this.groupSelectedContexts.Panel.Controls.Add(this.buttonSelectedApply);
            this.groupSelectedContexts.Panel.Controls.Add(this.textBoxSelectedContexts);
            this.groupSelectedContexts.Panel.Controls.Add(this.labelContextsInstructions);
            this.groupSelectedContexts.Size = new System.Drawing.Size(371, 129);
            this.groupSelectedContexts.TabIndex = 4;
            // 
            // labelSelectedContexts
            // 
            this.labelSelectedContexts.LabelStyle = Kiwi.ComponentFactory.Toolkit.LabelStyle.TitlePanel;
            this.labelSelectedContexts.Location = new System.Drawing.Point(4, 4);
            this.labelSelectedContexts.Name = "labelSelectedContexts";
            this.labelSelectedContexts.Size = new System.Drawing.Size(162, 28);
            this.labelSelectedContexts.TabIndex = 1;
            this.labelSelectedContexts.Values.Text = "Selected Contexts";
            // 
            // buttonSelectedApply
            // 
            this.buttonSelectedApply.AutoSize = true;
            this.buttonSelectedApply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSelectedApply.Location = new System.Drawing.Point(311, 35);
            this.buttonSelectedApply.Name = "buttonSelectedApply";
            this.buttonSelectedApply.Size = new System.Drawing.Size(40, 23);
            this.buttonSelectedApply.TabIndex = 3;
            this.buttonSelectedApply.Values.Text = "Apply";
            this.buttonSelectedApply.Click += new System.EventHandler(this.buttonSelectedApply_Click);
            // 
            // textBoxSelectedContexts
            // 
            this.textBoxSelectedContexts.Location = new System.Drawing.Point(9, 36);
            this.textBoxSelectedContexts.Name = "textBoxSelectedContexts";
            this.textBoxSelectedContexts.Size = new System.Drawing.Size(296, 20);
            this.textBoxSelectedContexts.TabIndex = 0;
            this.textBoxSelectedContexts.Text = "Red,Green";
            this.textBoxSelectedContexts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSelectedContexts_KeyDown);
            // 
            // labelContextsInstructions
            // 
            this.labelContextsInstructions.LabelStyle = Kiwi.ComponentFactory.Toolkit.LabelStyle.NormalPanel;
            this.labelContextsInstructions.Location = new System.Drawing.Point(5, 64);
            this.labelContextsInstructions.Name = "labelContextsInstructions";
            this.labelContextsInstructions.Size = new System.Drawing.Size(300, 49);
            this.labelContextsInstructions.TabIndex = 2;
            this.labelContextsInstructions.Values.Text = "Use a common separated list of context names and then\r\npress the \'Apply\' button. " +
                "To remove all contextual tabs\r\njust remove all the text and press \'Apply\'.";
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.Color = System.Drawing.Color.DodgerBlue;
            this.colorDialog.FullOpen = true;
            this.colorDialog.SolidColorOnly = true;
            // 
            // radioOffice2010Black
            // 
            this.radioOffice2010Black.LabelStyle = Kiwi.ComponentFactory.Toolkit.LabelStyle.NormalPanel;
            this.radioOffice2010Black.Location = new System.Drawing.Point(20, 84);
            this.radioOffice2010Black.Name = "radioOffice2010Black";
            this.radioOffice2010Black.Size = new System.Drawing.Size(119, 19);
            this.radioOffice2010Black.TabIndex = 3;
            this.radioOffice2010Black.Values.Text = "Office 2010 - Black";
            this.radioOffice2010Black.CheckedChanged += new System.EventHandler(this.radioOffice2010Black_CheckedChanged);
            // 
            // radioOffice2010Silver
            // 
            this.radioOffice2010Silver.LabelStyle = Kiwi.ComponentFactory.Toolkit.LabelStyle.NormalPanel;
            this.radioOffice2010Silver.Location = new System.Drawing.Point(20, 61);
            this.radioOffice2010Silver.Name = "radioOffice2010Silver";
            this.radioOffice2010Silver.Size = new System.Drawing.Size(120, 19);
            this.radioOffice2010Silver.TabIndex = 2;
            this.radioOffice2010Silver.Values.Text = "Office 2010 - Silver";
            this.radioOffice2010Silver.CheckedChanged += new System.EventHandler(this.radioOffice2010Silver_CheckedChanged);
            // 
            // radioOffice2010Blue
            // 
            this.radioOffice2010Blue.Checked = true;
            this.radioOffice2010Blue.LabelStyle = Kiwi.ComponentFactory.Toolkit.LabelStyle.NormalPanel;
            this.radioOffice2010Blue.Location = new System.Drawing.Point(20, 38);
            this.radioOffice2010Blue.Name = "radioOffice2010Blue";
            this.radioOffice2010Blue.Size = new System.Drawing.Size(114, 19);
            this.radioOffice2010Blue.TabIndex = 1;
            this.radioOffice2010Blue.Values.Text = "Office 2010 - Blue";
            this.radioOffice2010Blue.CheckedChanged += new System.EventHandler(this.radioOffice2010Blue_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 488);
            this.Controls.Add(this.labelOffice2007Styles);
            this.Controls.Add(this.kiwiRibbon);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(602, 511);
            this.Name = "Form1";
            this.StateCommon.Header.Content.LongText.TextH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Center;
            this.StateCommon.Header.Content.ShortText.TextH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Center;
            this.Text = "Contextual Tabs";
            ((System.ComponentModel.ISupportInitialize)(this.kiwiRibbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelOffice2007Styles)).EndInit();
            this.labelOffice2007Styles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupOffice2007Styles.Panel)).EndInit();
            this.groupOffice2007Styles.Panel.ResumeLayout(false);
            this.groupOffice2007Styles.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupOffice2007Styles)).EndInit();
            this.groupOffice2007Styles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupAddContext.Panel)).EndInit();
            this.groupAddContext.Panel.ResumeLayout(false);
            this.groupAddContext.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupAddContext)).EndInit();
            this.groupAddContext.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelContextColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupSelectedContexts.Panel)).EndInit();
            this.groupSelectedContexts.Panel.ResumeLayout(false);
            this.groupSelectedContexts.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupSelectedContexts)).EndInit();
            this.groupSelectedContexts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Kiwi.ComponentFactory.Toolkit.KiwiTextBox textBoxSelectedContexts;
        private Kiwi.ComponentFactory.Toolkit.KiwiTextBox textBoxContextTitle;
        private Kiwi.ComponentFactory.Toolkit.KiwiTextBox textBoxContextName;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbon kiwiRibbon;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonContext contextDefRed;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonContext contextDefGreen;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonTab tabHome;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonTab contextRed;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonTab contextGreen1;
        private Kiwi.ComponentFactory.Toolkit.KiwiPanel labelOffice2007Styles;
        private Kiwi.ComponentFactory.Toolkit.KiwiLabel labelSelectedContexts;
        private Kiwi.ComponentFactory.Toolkit.KiwiButton buttonSelectedApply;
        private Kiwi.ComponentFactory.Toolkit.KiwiLabel labelContextsInstructions;
        private Kiwi.ComponentFactory.Toolkit.KiwiGroup groupAddContext;
        private Kiwi.ComponentFactory.Toolkit.KiwiLabel kiwiLabel1;
        private Kiwi.ComponentFactory.Toolkit.KiwiGroup groupSelectedContexts;
        private Kiwi.ComponentFactory.Toolkit.KiwiLabel labelContextColor;
        private Kiwi.ComponentFactory.Toolkit.KiwiLabel labelContextTitle;
        private Kiwi.ComponentFactory.Toolkit.KiwiLabel labelContextName;
        private Kiwi.ComponentFactory.Toolkit.KiwiPanel panelContextColor;
        private Kiwi.ComponentFactory.Toolkit.KiwiButton buttonEditColor;
        private Kiwi.ComponentFactory.Toolkit.KiwiButton buttonAddContext;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonTab contextGreen2;
        private Kiwi.ComponentFactory.Toolkit.KiwiGroup groupOffice2007Styles;
        private Kiwi.ComponentFactory.Toolkit.KiwiLabel kiwiLabel2;
        private Kiwi.ComponentFactory.Toolkit.KiwiManager kiwiManager;
        private System.Windows.Forms.ColorDialog colorDialog;
        private Kiwi.ComponentFactory.Toolkit.KiwiRadioButton radioSystem;
        private Kiwi.ComponentFactory.Toolkit.KiwiRadioButton radioOffice2003;
        private Kiwi.ComponentFactory.Toolkit.KiwiRadioButton radioOffice2007Black;
        private Kiwi.ComponentFactory.Toolkit.KiwiRadioButton radioOffice2007Silver;
        private Kiwi.ComponentFactory.Toolkit.KiwiRadioButton radioOffice2007Blue;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem kiwiContextMenuItem1;
        private Kiwi.ComponentFactory.Toolkit.KiwiRadioButton radioSparkleBlue;
        private Kiwi.ComponentFactory.Toolkit.KiwiRadioButton radioSparkleOrange;
        private Kiwi.ComponentFactory.Toolkit.KiwiRadioButton radioSparklePurple;
        private Kiwi.ComponentFactory.Toolkit.KiwiRadioButton radioOffice2010Black;
        private Kiwi.ComponentFactory.Toolkit.KiwiRadioButton radioOffice2010Silver;
        private Kiwi.ComponentFactory.Toolkit.KiwiRadioButton radioOffice2010Blue;
    }
}

