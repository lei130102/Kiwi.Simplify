
namespace Singleline___Multiline
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
            this.radioModeRibbonTabs = new System.Windows.Forms.RadioButton();
            this.radioModesCheckButton = new System.Windows.Forms.RadioButton();
            this.radioModeTabs = new System.Windows.Forms.RadioButton();
            this.groupBoxItemAlignment = new System.Windows.Forms.GroupBox();
            this.radioItemFar = new System.Windows.Forms.RadioButton();
            this.radioItemCenter = new System.Windows.Forms.RadioButton();
            this.radioItemNear = new System.Windows.Forms.RadioButton();
            this.groupBoxItemOrientation = new System.Windows.Forms.GroupBox();
            this.radioItemFixedRight = new System.Windows.Forms.RadioButton();
            this.radioItemFixedLeft = new System.Windows.Forms.RadioButton();
            this.radioItemFixedBottom = new System.Windows.Forms.RadioButton();
            this.radioItemFixedTop = new System.Windows.Forms.RadioButton();
            this.radioItemAuto = new System.Windows.Forms.RadioButton();
            this.groupBoxBarOrientation = new System.Windows.Forms.GroupBox();
            this.radioOrientationRight = new System.Windows.Forms.RadioButton();
            this.radioOrientationLeft = new System.Windows.Forms.RadioButton();
            this.radioOrientationBottom = new System.Windows.Forms.RadioButton();
            this.radioOrientationTop = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioExpandline = new System.Windows.Forms.RadioButton();
            this.radioMultiline = new System.Windows.Forms.RadioButton();
            this.radioExactline = new System.Windows.Forms.RadioButton();
            this.radioShrinkline = new System.Windows.Forms.RadioButton();
            this.radioSingleline = new System.Windows.Forms.RadioButton();
            this.buttonClose = new System.Windows.Forms.Button();
            this.kiwiNavigator1 = new Kiwi.ComponentFactory.Navigator.KiwiNavigator();
            this.kiwiPage1 = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.kiwiPage2 = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.kiwiPage3 = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.kiwiPage4 = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.kiwiPage5 = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.kiwiPage6 = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.buttonAddPage = new System.Windows.Forms.Button();
            this.buttonClearAllPages = new System.Windows.Forms.Button();
            this.groupBoxPages = new System.Windows.Forms.GroupBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.kiwiManager1 = new Kiwi.ComponentFactory.Toolkit.KiwiManager(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBoxItemAlignment.SuspendLayout();
            this.groupBoxItemOrientation.SuspendLayout();
            this.groupBoxBarOrientation.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiNavigator1)).BeginInit();
            this.kiwiNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage6)).BeginInit();
            this.groupBoxPages.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioModeRibbonTabs);
            this.groupBox1.Controls.Add(this.radioModesCheckButton);
            this.groupBox1.Controls.Add(this.radioModeTabs);
            this.groupBox1.Location = new System.Drawing.Point(13, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 99);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modes";
            // 
            // radioModeRibbonTabs
            // 
            this.radioModeRibbonTabs.AutoSize = true;
            this.radioModeRibbonTabs.Location = new System.Drawing.Point(18, 47);
            this.radioModeRibbonTabs.Name = "radioModeRibbonTabs";
            this.radioModeRibbonTabs.Size = new System.Drawing.Size(83, 17);
            this.radioModeRibbonTabs.TabIndex = 1;
            this.radioModeRibbonTabs.TabStop = true;
            this.radioModeRibbonTabs.Text = "RibbonTabs";
            this.radioModeRibbonTabs.UseVisualStyleBackColor = true;
            this.radioModeRibbonTabs.CheckedChanged += new System.EventHandler(this.radioModeRibbonTabs_CheckedChanged);
            // 
            // radioModesCheckButton
            // 
            this.radioModesCheckButton.AutoSize = true;
            this.radioModesCheckButton.Location = new System.Drawing.Point(18, 70);
            this.radioModesCheckButton.Name = "radioModesCheckButton";
            this.radioModesCheckButton.Size = new System.Drawing.Size(92, 17);
            this.radioModesCheckButton.TabIndex = 2;
            this.radioModesCheckButton.TabStop = true;
            this.radioModesCheckButton.Text = "CheckButtons";
            this.radioModesCheckButton.UseVisualStyleBackColor = true;
            this.radioModesCheckButton.CheckedChanged += new System.EventHandler(this.radioModesCheckButton_CheckedChanged);
            // 
            // radioModeTabs
            // 
            this.radioModeTabs.AutoSize = true;
            this.radioModeTabs.Location = new System.Drawing.Point(18, 24);
            this.radioModeTabs.Name = "radioModeTabs";
            this.radioModeTabs.Size = new System.Drawing.Size(49, 17);
            this.radioModeTabs.TabIndex = 0;
            this.radioModeTabs.TabStop = true;
            this.radioModeTabs.Text = "Tabs";
            this.radioModeTabs.UseVisualStyleBackColor = true;
            this.radioModeTabs.CheckedChanged += new System.EventHandler(this.radioModeTabs_CheckedChanged);
            // 
            // groupBoxItemAlignment
            // 
            this.groupBoxItemAlignment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxItemAlignment.Controls.Add(this.radioItemFar);
            this.groupBoxItemAlignment.Controls.Add(this.radioItemCenter);
            this.groupBoxItemAlignment.Controls.Add(this.radioItemNear);
            this.groupBoxItemAlignment.Location = new System.Drawing.Point(531, 253);
            this.groupBoxItemAlignment.Name = "groupBoxItemAlignment";
            this.groupBoxItemAlignment.Size = new System.Drawing.Size(147, 99);
            this.groupBoxItemAlignment.TabIndex = 4;
            this.groupBoxItemAlignment.TabStop = false;
            this.groupBoxItemAlignment.Text = "Item Alignment";
            // 
            // radioItemFar
            // 
            this.radioItemFar.AutoSize = true;
            this.radioItemFar.Location = new System.Drawing.Point(18, 70);
            this.radioItemFar.Name = "radioItemFar";
            this.radioItemFar.Size = new System.Drawing.Size(40, 17);
            this.radioItemFar.TabIndex = 2;
            this.radioItemFar.TabStop = true;
            this.radioItemFar.Text = "Far";
            this.radioItemFar.UseVisualStyleBackColor = true;
            this.radioItemFar.CheckedChanged += new System.EventHandler(this.radioItemFar_CheckedChanged);
            // 
            // radioItemCenter
            // 
            this.radioItemCenter.AutoSize = true;
            this.radioItemCenter.Location = new System.Drawing.Point(18, 47);
            this.radioItemCenter.Name = "radioItemCenter";
            this.radioItemCenter.Size = new System.Drawing.Size(56, 17);
            this.radioItemCenter.TabIndex = 1;
            this.radioItemCenter.TabStop = true;
            this.radioItemCenter.Text = "Center";
            this.radioItemCenter.UseVisualStyleBackColor = true;
            this.radioItemCenter.CheckedChanged += new System.EventHandler(this.radioItemCenter_CheckedChanged);
            // 
            // radioItemNear
            // 
            this.radioItemNear.AutoSize = true;
            this.radioItemNear.Location = new System.Drawing.Point(18, 24);
            this.radioItemNear.Name = "radioItemNear";
            this.radioItemNear.Size = new System.Drawing.Size(48, 17);
            this.radioItemNear.TabIndex = 0;
            this.radioItemNear.TabStop = true;
            this.radioItemNear.Text = "Near";
            this.radioItemNear.UseVisualStyleBackColor = true;
            this.radioItemNear.CheckedChanged += new System.EventHandler(this.radioItemNear_CheckedChanged);
            // 
            // groupBoxItemOrientation
            // 
            this.groupBoxItemOrientation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxItemOrientation.Controls.Add(this.radioItemFixedRight);
            this.groupBoxItemOrientation.Controls.Add(this.radioItemFixedLeft);
            this.groupBoxItemOrientation.Controls.Add(this.radioItemFixedBottom);
            this.groupBoxItemOrientation.Controls.Add(this.radioItemFixedTop);
            this.groupBoxItemOrientation.Controls.Add(this.radioItemAuto);
            this.groupBoxItemOrientation.Location = new System.Drawing.Point(531, 105);
            this.groupBoxItemOrientation.Name = "groupBoxItemOrientation";
            this.groupBoxItemOrientation.Size = new System.Drawing.Size(147, 142);
            this.groupBoxItemOrientation.TabIndex = 3;
            this.groupBoxItemOrientation.TabStop = false;
            this.groupBoxItemOrientation.Text = "Item Orientation";
            // 
            // radioItemFixedRight
            // 
            this.radioItemFixedRight.AutoSize = true;
            this.radioItemFixedRight.Location = new System.Drawing.Point(18, 116);
            this.radioItemFixedRight.Name = "radioItemFixedRight";
            this.radioItemFixedRight.Size = new System.Drawing.Size(78, 17);
            this.radioItemFixedRight.TabIndex = 4;
            this.radioItemFixedRight.TabStop = true;
            this.radioItemFixedRight.Text = "Fixed Right";
            this.radioItemFixedRight.UseVisualStyleBackColor = true;
            this.radioItemFixedRight.CheckedChanged += new System.EventHandler(this.radioItemFixedRight_CheckedChanged);
            // 
            // radioItemFixedLeft
            // 
            this.radioItemFixedLeft.AutoSize = true;
            this.radioItemFixedLeft.Location = new System.Drawing.Point(18, 93);
            this.radioItemFixedLeft.Name = "radioItemFixedLeft";
            this.radioItemFixedLeft.Size = new System.Drawing.Size(71, 17);
            this.radioItemFixedLeft.TabIndex = 3;
            this.radioItemFixedLeft.TabStop = true;
            this.radioItemFixedLeft.Text = "Fixed Left";
            this.radioItemFixedLeft.UseVisualStyleBackColor = true;
            this.radioItemFixedLeft.CheckedChanged += new System.EventHandler(this.radioItemFixedLeft_CheckedChanged);
            // 
            // radioItemFixedBottom
            // 
            this.radioItemFixedBottom.AutoSize = true;
            this.radioItemFixedBottom.Location = new System.Drawing.Point(18, 70);
            this.radioItemFixedBottom.Name = "radioItemFixedBottom";
            this.radioItemFixedBottom.Size = new System.Drawing.Size(86, 17);
            this.radioItemFixedBottom.TabIndex = 2;
            this.radioItemFixedBottom.TabStop = true;
            this.radioItemFixedBottom.Text = "Fixed Bottom";
            this.radioItemFixedBottom.UseVisualStyleBackColor = true;
            this.radioItemFixedBottom.CheckedChanged += new System.EventHandler(this.radioItemFixedBottom_CheckedChanged);
            // 
            // radioItemFixedTop
            // 
            this.radioItemFixedTop.AutoSize = true;
            this.radioItemFixedTop.Location = new System.Drawing.Point(18, 47);
            this.radioItemFixedTop.Name = "radioItemFixedTop";
            this.radioItemFixedTop.Size = new System.Drawing.Size(72, 17);
            this.radioItemFixedTop.TabIndex = 1;
            this.radioItemFixedTop.TabStop = true;
            this.radioItemFixedTop.Text = "Fixed Top";
            this.radioItemFixedTop.UseVisualStyleBackColor = true;
            this.radioItemFixedTop.CheckedChanged += new System.EventHandler(this.radioItemFixedTop_CheckedChanged);
            // 
            // radioItemAuto
            // 
            this.radioItemAuto.AutoSize = true;
            this.radioItemAuto.Location = new System.Drawing.Point(18, 24);
            this.radioItemAuto.Name = "radioItemAuto";
            this.radioItemAuto.Size = new System.Drawing.Size(47, 17);
            this.radioItemAuto.TabIndex = 0;
            this.radioItemAuto.TabStop = true;
            this.radioItemAuto.Text = "Auto";
            this.radioItemAuto.UseVisualStyleBackColor = true;
            this.radioItemAuto.CheckedChanged += new System.EventHandler(this.radioItemAuto_CheckedChanged);
            // 
            // groupBoxBarOrientation
            // 
            this.groupBoxBarOrientation.Controls.Add(this.radioOrientationRight);
            this.groupBoxBarOrientation.Controls.Add(this.radioOrientationLeft);
            this.groupBoxBarOrientation.Controls.Add(this.radioOrientationBottom);
            this.groupBoxBarOrientation.Controls.Add(this.radioOrientationTop);
            this.groupBoxBarOrientation.Location = new System.Drawing.Point(13, 265);
            this.groupBoxBarOrientation.Name = "groupBoxBarOrientation";
            this.groupBoxBarOrientation.Size = new System.Drawing.Size(147, 120);
            this.groupBoxBarOrientation.TabIndex = 2;
            this.groupBoxBarOrientation.TabStop = false;
            this.groupBoxBarOrientation.Text = "Bar Orientation";
            // 
            // radioOrientationRight
            // 
            this.radioOrientationRight.AutoSize = true;
            this.radioOrientationRight.Location = new System.Drawing.Point(18, 93);
            this.radioOrientationRight.Name = "radioOrientationRight";
            this.radioOrientationRight.Size = new System.Drawing.Size(50, 17);
            this.radioOrientationRight.TabIndex = 3;
            this.radioOrientationRight.TabStop = true;
            this.radioOrientationRight.Text = "Right";
            this.radioOrientationRight.UseVisualStyleBackColor = true;
            this.radioOrientationRight.CheckedChanged += new System.EventHandler(this.radioOrientationRight_CheckedChanged);
            // 
            // radioOrientationLeft
            // 
            this.radioOrientationLeft.AutoSize = true;
            this.radioOrientationLeft.Location = new System.Drawing.Point(18, 70);
            this.radioOrientationLeft.Name = "radioOrientationLeft";
            this.radioOrientationLeft.Size = new System.Drawing.Size(43, 17);
            this.radioOrientationLeft.TabIndex = 2;
            this.radioOrientationLeft.TabStop = true;
            this.radioOrientationLeft.Text = "Left";
            this.radioOrientationLeft.UseVisualStyleBackColor = true;
            this.radioOrientationLeft.CheckedChanged += new System.EventHandler(this.radioOrientationLeft_CheckedChanged);
            // 
            // radioOrientationBottom
            // 
            this.radioOrientationBottom.AutoSize = true;
            this.radioOrientationBottom.Location = new System.Drawing.Point(18, 47);
            this.radioOrientationBottom.Name = "radioOrientationBottom";
            this.radioOrientationBottom.Size = new System.Drawing.Size(58, 17);
            this.radioOrientationBottom.TabIndex = 1;
            this.radioOrientationBottom.TabStop = true;
            this.radioOrientationBottom.Text = "Bottom";
            this.radioOrientationBottom.UseVisualStyleBackColor = true;
            this.radioOrientationBottom.CheckedChanged += new System.EventHandler(this.radioOrientationBottom_CheckedChanged);
            // 
            // radioOrientationTop
            // 
            this.radioOrientationTop.AutoSize = true;
            this.radioOrientationTop.Location = new System.Drawing.Point(18, 24);
            this.radioOrientationTop.Name = "radioOrientationTop";
            this.radioOrientationTop.Size = new System.Drawing.Size(44, 17);
            this.radioOrientationTop.TabIndex = 0;
            this.radioOrientationTop.TabStop = true;
            this.radioOrientationTop.Text = "Top";
            this.radioOrientationTop.UseVisualStyleBackColor = true;
            this.radioOrientationTop.CheckedChanged += new System.EventHandler(this.radioOrientationTop_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioExpandline);
            this.groupBox2.Controls.Add(this.radioMultiline);
            this.groupBox2.Controls.Add(this.radioExactline);
            this.groupBox2.Controls.Add(this.radioShrinkline);
            this.groupBox2.Controls.Add(this.radioSingleline);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 141);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Multiline Setting";
            // 
            // radioExpandline
            // 
            this.radioExpandline.AutoSize = true;
            this.radioExpandline.Location = new System.Drawing.Point(17, 114);
            this.radioExpandline.Name = "radioExpandline";
            this.radioExpandline.Size = new System.Drawing.Size(77, 17);
            this.radioExpandline.TabIndex = 4;
            this.radioExpandline.Text = "Expandline";
            this.radioExpandline.UseVisualStyleBackColor = true;
            this.radioExpandline.CheckedChanged += new System.EventHandler(this.radioExpandline_CheckedChanged);
            // 
            // radioMultiline
            // 
            this.radioMultiline.AutoSize = true;
            this.radioMultiline.Location = new System.Drawing.Point(17, 45);
            this.radioMultiline.Name = "radioMultiline";
            this.radioMultiline.Size = new System.Drawing.Size(63, 17);
            this.radioMultiline.TabIndex = 3;
            this.radioMultiline.Text = "Multiline";
            this.radioMultiline.UseVisualStyleBackColor = true;
            this.radioMultiline.CheckedChanged += new System.EventHandler(this.radioMultiline_CheckedChanged);
            // 
            // radioExactline
            // 
            this.radioExactline.AutoSize = true;
            this.radioExactline.Location = new System.Drawing.Point(17, 68);
            this.radioExactline.Name = "radioExactline";
            this.radioExactline.Size = new System.Drawing.Size(68, 17);
            this.radioExactline.TabIndex = 2;
            this.radioExactline.Text = "Exactline";
            this.radioExactline.UseVisualStyleBackColor = true;
            this.radioExactline.CheckedChanged += new System.EventHandler(this.radioExactline_CheckedChanged);
            // 
            // radioShrinkline
            // 
            this.radioShrinkline.AutoSize = true;
            this.radioShrinkline.Location = new System.Drawing.Point(17, 91);
            this.radioShrinkline.Name = "radioShrinkline";
            this.radioShrinkline.Size = new System.Drawing.Size(71, 17);
            this.radioShrinkline.TabIndex = 1;
            this.radioShrinkline.Text = "Shrinkline";
            this.radioShrinkline.UseVisualStyleBackColor = true;
            this.radioShrinkline.CheckedChanged += new System.EventHandler(this.radioShrinkline_CheckedChanged);
            // 
            // radioSingleline
            // 
            this.radioSingleline.AutoSize = true;
            this.radioSingleline.Location = new System.Drawing.Point(17, 22);
            this.radioSingleline.Name = "radioSingleline";
            this.radioSingleline.Size = new System.Drawing.Size(70, 17);
            this.radioSingleline.TabIndex = 0;
            this.radioSingleline.Text = "Singleline";
            this.radioSingleline.UseVisualStyleBackColor = true;
            this.radioSingleline.CheckedChanged += new System.EventHandler(this.radioSingleline_CheckedChanged);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(603, 362);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // kiwiNavigator1
            // 
            this.kiwiNavigator1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.kiwiNavigator1.Bar.BarMapExtraText = Kiwi.ComponentFactory.Navigator.MapKiwiPageText.None;
            this.kiwiNavigator1.Bar.BarMapImage = Kiwi.ComponentFactory.Navigator.MapKiwiPageImage.Small;
            this.kiwiNavigator1.Bar.BarMapText = Kiwi.ComponentFactory.Navigator.MapKiwiPageText.TextTitle;
            this.kiwiNavigator1.Bar.BarMultiline = Kiwi.ComponentFactory.Navigator.BarMultiline.Multiline;
            this.kiwiNavigator1.Bar.ItemSizing = Kiwi.ComponentFactory.Navigator.BarItemSizing.SameHeight;
            this.kiwiNavigator1.Bar.TabBorderStyle = Kiwi.ComponentFactory.Toolkit.TabBorderStyle.RoundedEqualMedium;
            this.kiwiNavigator1.Button.ButtonDisplayLogic = Kiwi.ComponentFactory.Navigator.ButtonDisplayLogic.Context;
            this.kiwiNavigator1.Button.CloseButtonAction = Kiwi.ComponentFactory.Navigator.CloseButtonAction.RemovePageAndDispose;
            this.kiwiNavigator1.Button.CloseButtonDisplay = Kiwi.ComponentFactory.Navigator.ButtonDisplay.Logic;
            this.kiwiNavigator1.Button.ContextButtonAction = Kiwi.ComponentFactory.Navigator.ContextButtonAction.SelectPage;
            this.kiwiNavigator1.Button.ContextButtonDisplay = Kiwi.ComponentFactory.Navigator.ButtonDisplay.Logic;
            this.kiwiNavigator1.Button.ContextMenuMapImage = Kiwi.ComponentFactory.Navigator.MapKiwiPageImage.Small;
            this.kiwiNavigator1.Button.ContextMenuMapText = Kiwi.ComponentFactory.Navigator.MapKiwiPageText.TextTitle;
            this.kiwiNavigator1.Button.NextButtonAction = Kiwi.ComponentFactory.Navigator.DirectionButtonAction.ModeAppropriateAction;
            this.kiwiNavigator1.Button.NextButtonDisplay = Kiwi.ComponentFactory.Navigator.ButtonDisplay.Logic;
            this.kiwiNavigator1.Button.PreviousButtonAction = Kiwi.ComponentFactory.Navigator.DirectionButtonAction.ModeAppropriateAction;
            this.kiwiNavigator1.Button.PreviousButtonDisplay = Kiwi.ComponentFactory.Navigator.ButtonDisplay.Logic;
            this.kiwiNavigator1.Location = new System.Drawing.Point(176, 19);
            this.kiwiNavigator1.Name = "kiwiNavigator1";
            this.kiwiNavigator1.NavigatorMode = Kiwi.ComponentFactory.Navigator.NavigatorMode.BarTabGroup;
            this.kiwiNavigator1.Pages.AddRange(new Kiwi.ComponentFactory.Navigator.KiwiPage[] {
            this.kiwiPage1,
            this.kiwiPage2,
            this.kiwiPage3,
            this.kiwiPage4,
            this.kiwiPage5,
            this.kiwiPage6});
            this.kiwiNavigator1.SelectedIndex = 0;
            this.kiwiNavigator1.Size = new System.Drawing.Size(340, 366);
            this.kiwiNavigator1.StateCommon.CheckButton.Content.Image.ImageH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Center;
            this.kiwiNavigator1.StateCommon.CheckButton.Content.Image.ImageV = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Center;
            this.kiwiNavigator1.StateCommon.CheckButton.Content.ShortText.TextH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Center;
            this.kiwiNavigator1.StateCommon.CheckButton.Content.ShortText.TextV = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Far;
            this.kiwiNavigator1.TabIndex = 7;
            this.kiwiNavigator1.Text = "kiwiNavigator1";
            // 
            // kiwiPage1
            // 
            this.kiwiPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kiwiPage1.Flags = 65534;
            this.kiwiPage1.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiPage1.ImageSmall")));
            this.kiwiPage1.LastVisibleSet = true;
            this.kiwiPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kiwiPage1.Name = "kiwiPage1";
            this.kiwiPage1.Size = new System.Drawing.Size(338, 302);
            this.kiwiPage1.Text = "Page 1";
            this.kiwiPage1.TextDescription = "Page 1";
            this.kiwiPage1.TextTitle = "Page 1";
            this.kiwiPage1.ToolTipTitle = "Page ToolTip";
            this.kiwiPage1.UniqueName = "83EBB3EA59B0452F83EBB3EA59B0452F";
            // 
            // kiwiPage2
            // 
            this.kiwiPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kiwiPage2.Flags = 65534;
            this.kiwiPage2.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiPage2.ImageSmall")));
            this.kiwiPage2.LastVisibleSet = true;
            this.kiwiPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kiwiPage2.Name = "kiwiPage2";
            this.kiwiPage2.Size = new System.Drawing.Size(338, 302);
            this.kiwiPage2.Text = "Two";
            this.kiwiPage2.TextDescription = "Two";
            this.kiwiPage2.TextTitle = "Two";
            this.kiwiPage2.ToolTipTitle = "Page ToolTip";
            this.kiwiPage2.UniqueName = "2DCBCC926137414E2DCBCC926137414E";
            // 
            // kiwiPage3
            // 
            this.kiwiPage3.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kiwiPage3.Flags = 65534;
            this.kiwiPage3.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiPage3.ImageSmall")));
            this.kiwiPage3.LastVisibleSet = true;
            this.kiwiPage3.MinimumSize = new System.Drawing.Size(50, 50);
            this.kiwiPage3.Name = "kiwiPage3";
            this.kiwiPage3.Size = new System.Drawing.Size(338, 302);
            this.kiwiPage3.Text = "Page Three";
            this.kiwiPage3.TextDescription = "Page Three";
            this.kiwiPage3.TextTitle = "Page Three";
            this.kiwiPage3.ToolTipTitle = "Page ToolTip";
            this.kiwiPage3.UniqueName = "230DEF4541DE4E34230DEF4541DE4E34";
            // 
            // kiwiPage4
            // 
            this.kiwiPage4.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kiwiPage4.Flags = 65534;
            this.kiwiPage4.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiPage4.ImageSmall")));
            this.kiwiPage4.LastVisibleSet = true;
            this.kiwiPage4.MinimumSize = new System.Drawing.Size(50, 50);
            this.kiwiPage4.Name = "kiwiPage4";
            this.kiwiPage4.Size = new System.Drawing.Size(338, 302);
            this.kiwiPage4.Text = "Page 4";
            this.kiwiPage4.TextDescription = "Page 4";
            this.kiwiPage4.TextTitle = "Page 4";
            this.kiwiPage4.ToolTipTitle = "Page ToolTip";
            this.kiwiPage4.UniqueName = "1D7E3CAE56E340031D7E3CAE56E34003";
            // 
            // kiwiPage5
            // 
            this.kiwiPage5.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kiwiPage5.Flags = 65534;
            this.kiwiPage5.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiPage5.ImageSmall")));
            this.kiwiPage5.LastVisibleSet = true;
            this.kiwiPage5.MinimumSize = new System.Drawing.Size(50, 50);
            this.kiwiPage5.Name = "kiwiPage5";
            this.kiwiPage5.Size = new System.Drawing.Size(338, 302);
            this.kiwiPage5.Text = "Fifth Page";
            this.kiwiPage5.TextDescription = "Fifth Page";
            this.kiwiPage5.TextTitle = "Fifth Page";
            this.kiwiPage5.ToolTipTitle = "Page ToolTip";
            this.kiwiPage5.UniqueName = "39046C03B4E74DF239046C03B4E74DF2";
            // 
            // kiwiPage6
            // 
            this.kiwiPage6.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kiwiPage6.Flags = 65534;
            this.kiwiPage6.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiPage6.ImageSmall")));
            this.kiwiPage6.LastVisibleSet = true;
            this.kiwiPage6.MinimumSize = new System.Drawing.Size(50, 50);
            this.kiwiPage6.Name = "kiwiPage6";
            this.kiwiPage6.Size = new System.Drawing.Size(338, 302);
            this.kiwiPage6.Text = "Page 6";
            this.kiwiPage6.TextDescription = "Page 6";
            this.kiwiPage6.TextTitle = "Page 6";
            this.kiwiPage6.ToolTipTitle = "Page ToolTip";
            this.kiwiPage6.UniqueName = "A72F1119BE1D4099A72F1119BE1D4099";
            // 
            // buttonAddPage
            // 
            this.buttonAddPage.Location = new System.Drawing.Point(14, 22);
            this.buttonAddPage.Name = "buttonAddPage";
            this.buttonAddPage.Size = new System.Drawing.Size(101, 23);
            this.buttonAddPage.TabIndex = 5;
            this.buttonAddPage.Text = "Add Page";
            this.buttonAddPage.UseVisualStyleBackColor = true;
            this.buttonAddPage.Click += new System.EventHandler(this.buttonAddPage_Click);
            // 
            // buttonClearAllPages
            // 
            this.buttonClearAllPages.Location = new System.Drawing.Point(14, 51);
            this.buttonClearAllPages.Name = "buttonClearAllPages";
            this.buttonClearAllPages.Size = new System.Drawing.Size(101, 23);
            this.buttonClearAllPages.TabIndex = 6;
            this.buttonClearAllPages.Text = "Clear All Pages";
            this.buttonClearAllPages.UseVisualStyleBackColor = true;
            this.buttonClearAllPages.Click += new System.EventHandler(this.buttonClearAllPages_Click);
            // 
            // groupBoxPages
            // 
            this.groupBoxPages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPages.Controls.Add(this.buttonAddPage);
            this.groupBoxPages.Controls.Add(this.buttonClearAllPages);
            this.groupBoxPages.Location = new System.Drawing.Point(531, 13);
            this.groupBoxPages.Name = "groupBoxPages";
            this.groupBoxPages.Size = new System.Drawing.Size(147, 86);
            this.groupBoxPages.TabIndex = 9;
            this.groupBoxPages.TabStop = false;
            this.groupBoxPages.Text = "Pages";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "document_plain_red.png");
            this.imageList1.Images.SetKeyName(1, "find.png");
            this.imageList1.Images.SetKeyName(2, "flash_yellow.png");
            this.imageList1.Images.SetKeyName(3, "floppy_disk.png");
            this.imageList1.Images.SetKeyName(4, "font.png");
            this.imageList1.Images.SetKeyName(5, "heart_broken.png");
            this.imageList1.Images.SetKeyName(6, "lifebelt.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 399);
            this.Controls.Add(this.groupBoxPages);
            this.Controls.Add(this.kiwiNavigator1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxItemAlignment);
            this.Controls.Add(this.groupBoxItemOrientation);
            this.Controls.Add(this.groupBoxBarOrientation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(697, 433);
            this.Name = "Form1";
            this.Text = "Singleline + Multiline";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxItemAlignment.ResumeLayout(false);
            this.groupBoxItemAlignment.PerformLayout();
            this.groupBoxItemOrientation.ResumeLayout(false);
            this.groupBoxItemOrientation.PerformLayout();
            this.groupBoxBarOrientation.ResumeLayout(false);
            this.groupBoxBarOrientation.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiNavigator1)).EndInit();
            this.kiwiNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage6)).EndInit();
            this.groupBoxPages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioModesCheckButton;
        private System.Windows.Forms.RadioButton radioModeTabs;
        private System.Windows.Forms.GroupBox groupBoxItemAlignment;
        private System.Windows.Forms.RadioButton radioItemFar;
        private System.Windows.Forms.RadioButton radioItemCenter;
        private System.Windows.Forms.RadioButton radioItemNear;
        private System.Windows.Forms.GroupBox groupBoxItemOrientation;
        private System.Windows.Forms.RadioButton radioItemFixedRight;
        private System.Windows.Forms.RadioButton radioItemFixedLeft;
        private System.Windows.Forms.RadioButton radioItemFixedBottom;
        private System.Windows.Forms.RadioButton radioItemFixedTop;
        private System.Windows.Forms.RadioButton radioItemAuto;
        private System.Windows.Forms.GroupBox groupBoxBarOrientation;
        private System.Windows.Forms.RadioButton radioOrientationRight;
        private System.Windows.Forms.RadioButton radioOrientationLeft;
        private System.Windows.Forms.RadioButton radioOrientationBottom;
        private System.Windows.Forms.RadioButton radioOrientationTop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioExactline;
        private System.Windows.Forms.RadioButton radioShrinkline;
        private System.Windows.Forms.RadioButton radioSingleline;
        private System.Windows.Forms.Button buttonClose;
        private Kiwi.ComponentFactory.Navigator.KiwiNavigator kiwiNavigator1;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPage1;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPage2;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPage3;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPage4;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPage5;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPage6;
        private System.Windows.Forms.Button buttonAddPage;
        private System.Windows.Forms.Button buttonClearAllPages;
        private System.Windows.Forms.RadioButton radioModeRibbonTabs;
        private System.Windows.Forms.RadioButton radioExpandline;
        private System.Windows.Forms.RadioButton radioMultiline;
        private System.Windows.Forms.GroupBox groupBoxPages;
        private System.Windows.Forms.ImageList imageList1;
        private Kiwi.ComponentFactory.Toolkit.KiwiManager kiwiManager1;
    }
}

