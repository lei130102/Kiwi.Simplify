
namespace Navigator_Modes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioHeaderGroupTab = new System.Windows.Forms.RadioButton();
            this.radioOutlookMini = new System.Windows.Forms.RadioButton();
            this.radioBarRibbonTabOnly = new System.Windows.Forms.RadioButton();
            this.radioBarRibbonTabGroup = new System.Windows.Forms.RadioButton();
            this.radioBarTabGroup = new System.Windows.Forms.RadioButton();
            this.radioBarTabOnly = new System.Windows.Forms.RadioButton();
            this.radioHeaderBarCheckButtonOnly = new System.Windows.Forms.RadioButton();
            this.radioHeaderBarCheckButtonHeaderGroup = new System.Windows.Forms.RadioButton();
            this.radioHeaderBarCheckButtonGroup = new System.Windows.Forms.RadioButton();
            this.radioStackCheckButtonHeaderGroup = new System.Windows.Forms.RadioButton();
            this.radioStackCheckButtonGroup = new System.Windows.Forms.RadioButton();
            this.radioOutlookFull = new System.Windows.Forms.RadioButton();
            this.radioPanel = new System.Windows.Forms.RadioButton();
            this.radioGroup = new System.Windows.Forms.RadioButton();
            this.radioHeaderGroup = new System.Windows.Forms.RadioButton();
            this.radioBarCheckButtonOnly = new System.Windows.Forms.RadioButton();
            this.radioBarCheckButtonGroupOnly = new System.Windows.Forms.RadioButton();
            this.radioBarCheckButtonGroupInside = new System.Windows.Forms.RadioButton();
            this.radioBarCheckButtonGroupOutside = new System.Windows.Forms.RadioButton();
            this.kiwiNavigator1 = new Kiwi.ComponentFactory.Navigator.KiwiNavigator();
            this.kiwiPage1 = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonPage1 = new System.Windows.Forms.Button();
            this.kiwiPage2 = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPage2 = new System.Windows.Forms.Label();
            this.kiwiPage3 = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxPage3 = new System.Windows.Forms.ComboBox();
            this.kiwiPage4 = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxPage4 = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxDescription = new System.Windows.Forms.RichTextBox();
            this.panelWithNav = new System.Windows.Forms.Panel();
            this.kiwiManager1 = new Kiwi.ComponentFactory.Toolkit.KiwiManager(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiNavigator1)).BeginInit();
            this.kiwiNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage1)).BeginInit();
            this.kiwiPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage2)).BeginInit();
            this.kiwiPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage3)).BeginInit();
            this.kiwiPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage4)).BeginInit();
            this.kiwiPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelWithNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioHeaderGroupTab);
            this.groupBox1.Controls.Add(this.radioOutlookMini);
            this.groupBox1.Controls.Add(this.radioBarRibbonTabOnly);
            this.groupBox1.Controls.Add(this.radioBarRibbonTabGroup);
            this.groupBox1.Controls.Add(this.radioBarTabGroup);
            this.groupBox1.Controls.Add(this.radioBarTabOnly);
            this.groupBox1.Controls.Add(this.radioHeaderBarCheckButtonOnly);
            this.groupBox1.Controls.Add(this.radioHeaderBarCheckButtonHeaderGroup);
            this.groupBox1.Controls.Add(this.radioHeaderBarCheckButtonGroup);
            this.groupBox1.Controls.Add(this.radioStackCheckButtonHeaderGroup);
            this.groupBox1.Controls.Add(this.radioStackCheckButtonGroup);
            this.groupBox1.Controls.Add(this.radioOutlookFull);
            this.groupBox1.Controls.Add(this.radioPanel);
            this.groupBox1.Controls.Add(this.radioGroup);
            this.groupBox1.Controls.Add(this.radioHeaderGroup);
            this.groupBox1.Controls.Add(this.radioBarCheckButtonOnly);
            this.groupBox1.Controls.Add(this.radioBarCheckButtonGroupOnly);
            this.groupBox1.Controls.Add(this.radioBarCheckButtonGroupInside);
            this.groupBox1.Controls.Add(this.radioBarCheckButtonGroupOutside);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 455);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modes";
            // 
            // radioHeaderGroupTab
            // 
            this.radioHeaderGroupTab.AutoSize = true;
            this.radioHeaderGroupTab.Location = new System.Drawing.Point(16, 377);
            this.radioHeaderGroupTab.Name = "radioHeaderGroupTab";
            this.radioHeaderGroupTab.Size = new System.Drawing.Size(117, 17);
            this.radioHeaderGroupTab.TabIndex = 16;
            this.radioHeaderGroupTab.TabStop = true;
            this.radioHeaderGroupTab.Text = "HeaderGroup - Tab";
            this.radioHeaderGroupTab.UseVisualStyleBackColor = true;
            this.radioHeaderGroupTab.CheckedChanged += new System.EventHandler(this.radioMode_CheckedChanged);
            // 
            // radioOutlookMini
            // 
            this.radioOutlookMini.AutoSize = true;
            this.radioOutlookMini.Location = new System.Drawing.Point(16, 333);
            this.radioOutlookMini.Name = "radioOutlookMini";
            this.radioOutlookMini.Size = new System.Drawing.Size(90, 17);
            this.radioOutlookMini.TabIndex = 14;
            this.radioOutlookMini.TabStop = true;
            this.radioOutlookMini.Text = "Outlook - Mini";
            this.radioOutlookMini.UseVisualStyleBackColor = true;
            this.radioOutlookMini.CheckedChanged += new System.EventHandler(this.radioMode_CheckedChanged);
            // 
            // radioBarRibbonTabOnly
            // 
            this.radioBarRibbonTabOnly.AutoSize = true;
            this.radioBarRibbonTabOnly.Location = new System.Drawing.Point(16, 91);
            this.radioBarRibbonTabOnly.Name = "radioBarRibbonTabOnly";
            this.radioBarRibbonTabOnly.Size = new System.Drawing.Size(134, 17);
            this.radioBarRibbonTabOnly.TabIndex = 3;
            this.radioBarRibbonTabOnly.TabStop = true;
            this.radioBarRibbonTabOnly.Text = "Bar - RibbonTab - Only";
            this.radioBarRibbonTabOnly.UseVisualStyleBackColor = true;
            this.radioBarRibbonTabOnly.CheckedChanged += new System.EventHandler(this.radioMode_CheckedChanged);
            // 
            // radioBarRibbonTabGroup
            // 
            this.radioBarRibbonTabGroup.AutoSize = true;
            this.radioBarRibbonTabGroup.Location = new System.Drawing.Point(16, 69);
            this.radioBarRibbonTabGroup.Name = "radioBarRibbonTabGroup";
            this.radioBarRibbonTabGroup.Size = new System.Drawing.Size(141, 17);
            this.radioBarRibbonTabGroup.TabIndex = 2;
            this.radioBarRibbonTabGroup.TabStop = true;
            this.radioBarRibbonTabGroup.Text = "Bar - RibbonTab - Group";
            this.radioBarRibbonTabGroup.UseVisualStyleBackColor = true;
            this.radioBarRibbonTabGroup.CheckedChanged += new System.EventHandler(this.radioMode_CheckedChanged);
            // 
            // radioBarTabGroup
            // 
            this.radioBarTabGroup.AutoSize = true;
            this.radioBarTabGroup.Location = new System.Drawing.Point(16, 25);
            this.radioBarTabGroup.Name = "radioBarTabGroup";
            this.radioBarTabGroup.Size = new System.Drawing.Size(108, 17);
            this.radioBarTabGroup.TabIndex = 0;
            this.radioBarTabGroup.TabStop = true;
            this.radioBarTabGroup.Text = "Bar - Tab - Group";
            this.radioBarTabGroup.UseVisualStyleBackColor = true;
            this.radioBarTabGroup.CheckedChanged += new System.EventHandler(this.radioMode_CheckedChanged);
            // 
            // radioBarTabOnly
            // 
            this.radioBarTabOnly.AutoSize = true;
            this.radioBarTabOnly.Location = new System.Drawing.Point(16, 47);
            this.radioBarTabOnly.Name = "radioBarTabOnly";
            this.radioBarTabOnly.Size = new System.Drawing.Size(101, 17);
            this.radioBarTabOnly.TabIndex = 1;
            this.radioBarTabOnly.TabStop = true;
            this.radioBarTabOnly.Text = "Bar - Tab - Only";
            this.radioBarTabOnly.UseVisualStyleBackColor = true;
            this.radioBarTabOnly.CheckedChanged += new System.EventHandler(this.radioMode_CheckedChanged);
            // 
            // radioHeaderBarCheckButtonOnly
            // 
            this.radioHeaderBarCheckButtonOnly.AutoSize = true;
            this.radioHeaderBarCheckButtonOnly.Location = new System.Drawing.Point(16, 245);
            this.radioHeaderBarCheckButtonOnly.Name = "radioHeaderBarCheckButtonOnly";
            this.radioHeaderBarCheckButtonOnly.Size = new System.Drawing.Size(179, 17);
            this.radioHeaderBarCheckButtonOnly.TabIndex = 10;
            this.radioHeaderBarCheckButtonOnly.TabStop = true;
            this.radioHeaderBarCheckButtonOnly.Text = "HeaderBar - CheckButton - Only";
            this.radioHeaderBarCheckButtonOnly.UseVisualStyleBackColor = true;
            this.radioHeaderBarCheckButtonOnly.CheckedChanged += new System.EventHandler(this.radioMode_CheckedChanged);
            // 
            // radioHeaderBarCheckButtonHeaderGroup
            // 
            this.radioHeaderBarCheckButtonHeaderGroup.AutoSize = true;
            this.radioHeaderBarCheckButtonHeaderGroup.Location = new System.Drawing.Point(16, 223);
            this.radioHeaderBarCheckButtonHeaderGroup.Name = "radioHeaderBarCheckButtonHeaderGroup";
            this.radioHeaderBarCheckButtonHeaderGroup.Size = new System.Drawing.Size(221, 17);
            this.radioHeaderBarCheckButtonHeaderGroup.TabIndex = 9;
            this.radioHeaderBarCheckButtonHeaderGroup.TabStop = true;
            this.radioHeaderBarCheckButtonHeaderGroup.Text = "HeaderBar - CheckButton - HeaderGroup";
            this.radioHeaderBarCheckButtonHeaderGroup.UseVisualStyleBackColor = true;
            this.radioHeaderBarCheckButtonHeaderGroup.CheckedChanged += new System.EventHandler(this.radioMode_CheckedChanged);
            // 
            // radioHeaderBarCheckButtonGroup
            // 
            this.radioHeaderBarCheckButtonGroup.AutoSize = true;
            this.radioHeaderBarCheckButtonGroup.Location = new System.Drawing.Point(16, 201);
            this.radioHeaderBarCheckButtonGroup.Name = "radioHeaderBarCheckButtonGroup";
            this.radioHeaderBarCheckButtonGroup.Size = new System.Drawing.Size(186, 17);
            this.radioHeaderBarCheckButtonGroup.TabIndex = 8;
            this.radioHeaderBarCheckButtonGroup.TabStop = true;
            this.radioHeaderBarCheckButtonGroup.Text = "HeaderBar - CheckButton - Group";
            this.radioHeaderBarCheckButtonGroup.UseVisualStyleBackColor = true;
            this.radioHeaderBarCheckButtonGroup.CheckedChanged += new System.EventHandler(this.radioMode_CheckedChanged);
            // 
            // radioStackCheckButtonHeaderGroup
            // 
            this.radioStackCheckButtonHeaderGroup.AutoSize = true;
            this.radioStackCheckButtonHeaderGroup.Location = new System.Drawing.Point(16, 289);
            this.radioStackCheckButtonHeaderGroup.Name = "radioStackCheckButtonHeaderGroup";
            this.radioStackCheckButtonHeaderGroup.Size = new System.Drawing.Size(196, 17);
            this.radioStackCheckButtonHeaderGroup.TabIndex = 12;
            this.radioStackCheckButtonHeaderGroup.TabStop = true;
            this.radioStackCheckButtonHeaderGroup.Text = "Stack - CheckButton - HeaderGroup";
            this.radioStackCheckButtonHeaderGroup.UseVisualStyleBackColor = true;
            this.radioStackCheckButtonHeaderGroup.CheckedChanged += new System.EventHandler(this.radioMode_CheckedChanged);
            // 
            // radioStackCheckButtonGroup
            // 
            this.radioStackCheckButtonGroup.AutoSize = true;
            this.radioStackCheckButtonGroup.Location = new System.Drawing.Point(16, 267);
            this.radioStackCheckButtonGroup.Name = "radioStackCheckButtonGroup";
            this.radioStackCheckButtonGroup.Size = new System.Drawing.Size(161, 17);
            this.radioStackCheckButtonGroup.TabIndex = 11;
            this.radioStackCheckButtonGroup.TabStop = true;
            this.radioStackCheckButtonGroup.Text = "Stack - CheckButton - Group";
            this.radioStackCheckButtonGroup.UseVisualStyleBackColor = true;
            this.radioStackCheckButtonGroup.CheckedChanged += new System.EventHandler(this.radioMode_CheckedChanged);
            // 
            // radioOutlookFull
            // 
            this.radioOutlookFull.AutoSize = true;
            this.radioOutlookFull.Location = new System.Drawing.Point(16, 311);
            this.radioOutlookFull.Name = "radioOutlookFull";
            this.radioOutlookFull.Size = new System.Drawing.Size(88, 17);
            this.radioOutlookFull.TabIndex = 13;
            this.radioOutlookFull.TabStop = true;
            this.radioOutlookFull.Text = "Outlook - Full";
            this.radioOutlookFull.UseVisualStyleBackColor = true;
            this.radioOutlookFull.CheckedChanged += new System.EventHandler(this.radioMode_CheckedChanged);
            // 
            // radioPanel
            // 
            this.radioPanel.AutoSize = true;
            this.radioPanel.Location = new System.Drawing.Point(16, 421);
            this.radioPanel.Name = "radioPanel";
            this.radioPanel.Size = new System.Drawing.Size(51, 17);
            this.radioPanel.TabIndex = 18;
            this.radioPanel.TabStop = true;
            this.radioPanel.Text = "Panel";
            this.radioPanel.UseVisualStyleBackColor = true;
            this.radioPanel.CheckedChanged += new System.EventHandler(this.radioMode_CheckedChanged);
            // 
            // radioGroup
            // 
            this.radioGroup.AutoSize = true;
            this.radioGroup.Location = new System.Drawing.Point(16, 399);
            this.radioGroup.Name = "radioGroup";
            this.radioGroup.Size = new System.Drawing.Size(54, 17);
            this.radioGroup.TabIndex = 17;
            this.radioGroup.TabStop = true;
            this.radioGroup.Text = "Group";
            this.radioGroup.UseVisualStyleBackColor = true;
            this.radioGroup.CheckedChanged += new System.EventHandler(this.radioMode_CheckedChanged);
            // 
            // radioHeaderGroup
            // 
            this.radioHeaderGroup.AutoSize = true;
            this.radioHeaderGroup.Location = new System.Drawing.Point(16, 355);
            this.radioHeaderGroup.Name = "radioHeaderGroup";
            this.radioHeaderGroup.Size = new System.Drawing.Size(89, 17);
            this.radioHeaderGroup.TabIndex = 15;
            this.radioHeaderGroup.TabStop = true;
            this.radioHeaderGroup.Text = "HeaderGroup";
            this.radioHeaderGroup.UseVisualStyleBackColor = true;
            this.radioHeaderGroup.CheckedChanged += new System.EventHandler(this.radioMode_CheckedChanged);
            // 
            // radioBarCheckButtonOnly
            // 
            this.radioBarCheckButtonOnly.AutoSize = true;
            this.radioBarCheckButtonOnly.Location = new System.Drawing.Point(16, 179);
            this.radioBarCheckButtonOnly.Name = "radioBarCheckButtonOnly";
            this.radioBarCheckButtonOnly.Size = new System.Drawing.Size(144, 17);
            this.radioBarCheckButtonOnly.TabIndex = 7;
            this.radioBarCheckButtonOnly.TabStop = true;
            this.radioBarCheckButtonOnly.Text = "Bar - CheckButton - Only";
            this.radioBarCheckButtonOnly.UseVisualStyleBackColor = true;
            this.radioBarCheckButtonOnly.CheckedChanged += new System.EventHandler(this.radioMode_CheckedChanged);
            // 
            // radioBarCheckButtonGroupOnly
            // 
            this.radioBarCheckButtonGroupOnly.AutoSize = true;
            this.radioBarCheckButtonGroupOnly.Location = new System.Drawing.Point(16, 157);
            this.radioBarCheckButtonGroupOnly.Name = "radioBarCheckButtonGroupOnly";
            this.radioBarCheckButtonGroupOnly.Size = new System.Drawing.Size(183, 17);
            this.radioBarCheckButtonGroupOnly.TabIndex = 6;
            this.radioBarCheckButtonGroupOnly.TabStop = true;
            this.radioBarCheckButtonGroupOnly.Text = "Bar - CheckButton - Group - Only";
            this.radioBarCheckButtonGroupOnly.UseVisualStyleBackColor = true;
            this.radioBarCheckButtonGroupOnly.CheckedChanged += new System.EventHandler(this.radioMode_CheckedChanged);
            // 
            // radioBarCheckButtonGroupInside
            // 
            this.radioBarCheckButtonGroupInside.AutoSize = true;
            this.radioBarCheckButtonGroupInside.Location = new System.Drawing.Point(16, 135);
            this.radioBarCheckButtonGroupInside.Name = "radioBarCheckButtonGroupInside";
            this.radioBarCheckButtonGroupInside.Size = new System.Drawing.Size(190, 17);
            this.radioBarCheckButtonGroupInside.TabIndex = 5;
            this.radioBarCheckButtonGroupInside.TabStop = true;
            this.radioBarCheckButtonGroupInside.Text = "Bar - CheckButton - Group - Inside";
            this.radioBarCheckButtonGroupInside.UseVisualStyleBackColor = true;
            this.radioBarCheckButtonGroupInside.CheckedChanged += new System.EventHandler(this.radioMode_CheckedChanged);
            // 
            // radioBarCheckButtonGroupOutside
            // 
            this.radioBarCheckButtonGroupOutside.AutoSize = true;
            this.radioBarCheckButtonGroupOutside.Location = new System.Drawing.Point(16, 113);
            this.radioBarCheckButtonGroupOutside.Name = "radioBarCheckButtonGroupOutside";
            this.radioBarCheckButtonGroupOutside.Size = new System.Drawing.Size(198, 17);
            this.radioBarCheckButtonGroupOutside.TabIndex = 4;
            this.radioBarCheckButtonGroupOutside.TabStop = true;
            this.radioBarCheckButtonGroupOutside.Text = "Bar - CheckButton - Group - Outside";
            this.radioBarCheckButtonGroupOutside.UseVisualStyleBackColor = true;
            this.radioBarCheckButtonGroupOutside.CheckedChanged += new System.EventHandler(this.radioMode_CheckedChanged);
            // 
            // kiwiNavigator1
            // 
            this.kiwiNavigator1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kiwiNavigator1.Button.CloseButtonDisplay = Kiwi.ComponentFactory.Navigator.ButtonDisplay.Hide;
            this.kiwiNavigator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kiwiNavigator1.Header.HeaderValuesPrimary.MapImage = Kiwi.ComponentFactory.Navigator.MapKiwiPageImage.MediumSmall;
            this.kiwiNavigator1.Location = new System.Drawing.Point(0, 0);
            this.kiwiNavigator1.Name = "kiwiNavigator1";
            this.kiwiNavigator1.Pages.AddRange(new Kiwi.ComponentFactory.Navigator.KiwiPage[] {
            this.kiwiPage1,
            this.kiwiPage2,
            this.kiwiPage3,
            this.kiwiPage4});
            this.kiwiNavigator1.PopupPages.AllowPopupPages = Kiwi.ComponentFactory.Navigator.PopupPageAllow.OnlyCompatibleModes;
            this.kiwiNavigator1.SelectedIndex = 0;
            this.kiwiNavigator1.Size = new System.Drawing.Size(329, 265);
            this.kiwiNavigator1.Stack.StackAlignment = Kiwi.ComponentFactory.Toolkit.RelativePositionAlign.Far;
            this.kiwiNavigator1.TabIndex = 0;
            this.kiwiNavigator1.Text = "kiwiNavigator1";
            // 
            // kiwiPage1
            // 
            this.kiwiPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kiwiPage1.Controls.Add(this.button3);
            this.kiwiPage1.Controls.Add(this.button2);
            this.kiwiPage1.Controls.Add(this.button1);
            this.kiwiPage1.Controls.Add(this.buttonPage1);
            this.kiwiPage1.Flags = 65535;
            this.kiwiPage1.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kiwiPage1.ImageLarge")));
            this.kiwiPage1.ImageMedium = ((System.Drawing.Image)(resources.GetObject("kiwiPage1.ImageMedium")));
            this.kiwiPage1.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiPage1.ImageSmall")));
            this.kiwiPage1.LastVisibleSet = true;
            this.kiwiPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kiwiPage1.Name = "kiwiPage1";
            this.kiwiPage1.Padding = new System.Windows.Forms.Padding(15);
            this.kiwiPage1.Size = new System.Drawing.Size(327, 239);
            this.kiwiPage1.Text = "Page 1";
            this.kiwiPage1.TextDescription = "Page 1 Description";
            this.kiwiPage1.TextTitle = "Page 1 Title";
            this.kiwiPage1.ToolTipTitle = "Page ToolTip";
            this.kiwiPage1.UniqueName = "1D382D54791F410B1D382D54791F410B";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(121, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 3;
            this.button3.Text = "Page 1 Button";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Page 1 Button";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Page 1 Button";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonPage1
            // 
            this.buttonPage1.Location = new System.Drawing.Point(15, 15);
            this.buttonPage1.Name = "buttonPage1";
            this.buttonPage1.Size = new System.Drawing.Size(100, 28);
            this.buttonPage1.TabIndex = 0;
            this.buttonPage1.Text = "Page 1 Button";
            this.buttonPage1.UseVisualStyleBackColor = true;
            // 
            // kiwiPage2
            // 
            this.kiwiPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kiwiPage2.Controls.Add(this.label2);
            this.kiwiPage2.Controls.Add(this.label1);
            this.kiwiPage2.Controls.Add(this.labelPage2);
            this.kiwiPage2.Flags = 65535;
            this.kiwiPage2.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kiwiPage2.ImageLarge")));
            this.kiwiPage2.ImageMedium = ((System.Drawing.Image)(resources.GetObject("kiwiPage2.ImageMedium")));
            this.kiwiPage2.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiPage2.ImageSmall")));
            this.kiwiPage2.LastVisibleSet = true;
            this.kiwiPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kiwiPage2.Name = "kiwiPage2";
            this.kiwiPage2.Padding = new System.Windows.Forms.Padding(20);
            this.kiwiPage2.Size = new System.Drawing.Size(327, 238);
            this.kiwiPage2.Text = "Page 2";
            this.kiwiPage2.TextDescription = "Page 2 Description";
            this.kiwiPage2.TextTitle = "Page 2 Title";
            this.kiwiPage2.ToolTipTitle = "Page ToolTip";
            this.kiwiPage2.UniqueName = "D27AA26C602E434CD27AA26C602E434C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(20, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Page 2 Label";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Page 2 Label";
            // 
            // labelPage2
            // 
            this.labelPage2.AutoSize = true;
            this.labelPage2.BackColor = System.Drawing.Color.Transparent;
            this.labelPage2.Location = new System.Drawing.Point(20, 20);
            this.labelPage2.Name = "labelPage2";
            this.labelPage2.Size = new System.Drawing.Size(68, 13);
            this.labelPage2.TabIndex = 0;
            this.labelPage2.Text = "Page 2 Label";
            // 
            // kiwiPage3
            // 
            this.kiwiPage3.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kiwiPage3.Controls.Add(this.comboBox1);
            this.kiwiPage3.Controls.Add(this.comboBoxPage3);
            this.kiwiPage3.Flags = 65535;
            this.kiwiPage3.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kiwiPage3.ImageLarge")));
            this.kiwiPage3.ImageMedium = ((System.Drawing.Image)(resources.GetObject("kiwiPage3.ImageMedium")));
            this.kiwiPage3.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiPage3.ImageSmall")));
            this.kiwiPage3.LastVisibleSet = true;
            this.kiwiPage3.MinimumSize = new System.Drawing.Size(50, 50);
            this.kiwiPage3.Name = "kiwiPage3";
            this.kiwiPage3.Padding = new System.Windows.Forms.Padding(20);
            this.kiwiPage3.Size = new System.Drawing.Size(327, 238);
            this.kiwiPage3.Text = "Page 3";
            this.kiwiPage3.TextDescription = "Page 3 Description";
            this.kiwiPage3.TextTitle = "Page 3 Title";
            this.kiwiPage3.ToolTipTitle = "Page ToolTip";
            this.kiwiPage3.UniqueName = "868F5B555E11408E868F5B555E11408E";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "One",
            "Two",
            "Three",
            "Four"});
            this.comboBox1.Location = new System.Drawing.Point(20, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Page 4 ComboBox";
            // 
            // comboBoxPage3
            // 
            this.comboBoxPage3.FormattingEnabled = true;
            this.comboBoxPage3.Items.AddRange(new object[] {
            "One",
            "Two",
            "Three",
            "Four"});
            this.comboBoxPage3.Location = new System.Drawing.Point(20, 20);
            this.comboBoxPage3.Name = "comboBoxPage3";
            this.comboBoxPage3.Size = new System.Drawing.Size(129, 21);
            this.comboBoxPage3.TabIndex = 0;
            this.comboBoxPage3.Text = "Page 4 ComboBox";
            // 
            // kiwiPage4
            // 
            this.kiwiPage4.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kiwiPage4.Controls.Add(this.textBox1);
            this.kiwiPage4.Controls.Add(this.textBoxPage4);
            this.kiwiPage4.Flags = 65535;
            this.kiwiPage4.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kiwiPage4.ImageLarge")));
            this.kiwiPage4.ImageMedium = ((System.Drawing.Image)(resources.GetObject("kiwiPage4.ImageMedium")));
            this.kiwiPage4.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiPage4.ImageSmall")));
            this.kiwiPage4.LastVisibleSet = true;
            this.kiwiPage4.MinimumSize = new System.Drawing.Size(50, 50);
            this.kiwiPage4.Name = "kiwiPage4";
            this.kiwiPage4.Padding = new System.Windows.Forms.Padding(20);
            this.kiwiPage4.Size = new System.Drawing.Size(327, 238);
            this.kiwiPage4.Text = "Page 4";
            this.kiwiPage4.TextDescription = "Page 4 Description";
            this.kiwiPage4.TextTitle = "Page 4 Title";
            this.kiwiPage4.ToolTipTitle = "Page ToolTip";
            this.kiwiPage4.UniqueName = "5F53C2C849EF4A225F53C2C849EF4A22";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(20, 67);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 40);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Page 4 TextBox";
            // 
            // textBoxPage4
            // 
            this.textBoxPage4.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxPage4.Location = new System.Drawing.Point(20, 20);
            this.textBoxPage4.Multiline = true;
            this.textBoxPage4.Name = "textBoxPage4";
            this.textBoxPage4.Size = new System.Drawing.Size(117, 40);
            this.textBoxPage4.TabIndex = 0;
            this.textBoxPage4.Text = "Page 4 TextBox";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(520, 473);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxDescription);
            this.groupBox2.Location = new System.Drawing.Point(266, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(329, 177);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mode Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Location = new System.Drawing.Point(5, 19);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(319, 153);
            this.textBoxDescription.TabIndex = 0;
            this.textBoxDescription.Text = "";
            // 
            // panelWithNav
            // 
            this.panelWithNav.Controls.Add(this.kiwiNavigator1);
            this.panelWithNav.Location = new System.Drawing.Point(266, 13);
            this.panelWithNav.Name = "panelWithNav";
            this.panelWithNav.Size = new System.Drawing.Size(329, 265);
            this.panelWithNav.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 508);
            this.Controls.Add(this.panelWithNav);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Navigator Modes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiNavigator1)).EndInit();
            this.kiwiNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage1)).EndInit();
            this.kiwiPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage2)).EndInit();
            this.kiwiPage2.ResumeLayout(false);
            this.kiwiPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage3)).EndInit();
            this.kiwiPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage4)).EndInit();
            this.kiwiPage4.ResumeLayout(false);
            this.kiwiPage4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panelWithNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Kiwi.ComponentFactory.Navigator.KiwiNavigator kiwiNavigator1;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPage1;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioPanel;
        private System.Windows.Forms.RadioButton radioGroup;
        private System.Windows.Forms.RadioButton radioHeaderGroup;
        private System.Windows.Forms.RadioButton radioBarCheckButtonOnly;
        private System.Windows.Forms.RadioButton radioBarCheckButtonGroupOnly;
        private System.Windows.Forms.RadioButton radioBarCheckButtonGroupInside;
        private System.Windows.Forms.RadioButton radioBarCheckButtonGroupOutside;
        private System.Windows.Forms.Button buttonClose;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPage3;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPage4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox textBoxDescription;
        private System.Windows.Forms.Button buttonPage1;
        private System.Windows.Forms.Label labelPage2;
        private System.Windows.Forms.ComboBox comboBoxPage3;
        private System.Windows.Forms.TextBox textBoxPage4;
        private System.Windows.Forms.RadioButton radioStackCheckButtonHeaderGroup;
        private System.Windows.Forms.RadioButton radioStackCheckButtonGroup;
        private System.Windows.Forms.RadioButton radioOutlookFull;
        private System.Windows.Forms.RadioButton radioBarTabGroup;
        private System.Windows.Forms.RadioButton radioBarTabOnly;
        private System.Windows.Forms.RadioButton radioHeaderBarCheckButtonOnly;
        private System.Windows.Forms.RadioButton radioHeaderBarCheckButtonHeaderGroup;
        private System.Windows.Forms.RadioButton radioHeaderBarCheckButtonGroup;
        private System.Windows.Forms.Panel panelWithNav;
        private System.Windows.Forms.RadioButton radioBarRibbonTabOnly;
        private System.Windows.Forms.RadioButton radioBarRibbonTabGroup;
        private System.Windows.Forms.RadioButton radioOutlookMini;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioHeaderGroupTab;
        private Kiwi.ComponentFactory.Toolkit.KiwiManager kiwiManager1;
    }
}

