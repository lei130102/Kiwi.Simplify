
namespace Popup_Pages
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
            this.groupBoxModes = new System.Windows.Forms.GroupBox();
            this.radioOutlookMini = new System.Windows.Forms.RadioButton();
            this.radioHeaderBarCheckButtonOnly = new System.Windows.Forms.RadioButton();
            this.radioBarCheckButtonOnly = new System.Windows.Forms.RadioButton();
            this.radioBarRibbonTabOnly = new System.Windows.Forms.RadioButton();
            this.radioBarCheckButtonGroupOnly = new System.Windows.Forms.RadioButton();
            this.radioBarTabOnly = new System.Windows.Forms.RadioButton();
            this.groupBoxBarOrientation = new System.Windows.Forms.GroupBox();
            this.radioOrientationRight = new System.Windows.Forms.RadioButton();
            this.radioOrientationLeft = new System.Windows.Forms.RadioButton();
            this.radioOrientationBottom = new System.Windows.Forms.RadioButton();
            this.radioOrientationTop = new System.Windows.Forms.RadioButton();
            this.kiwiNavigator = new Kiwi.ComponentFactory.Navigator.KiwiNavigator();
            this.kiwiPage1 = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.kiwiPage2 = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.kiwiPage3 = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBoxPopupPageProperties = new System.Windows.Forms.GroupBox();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.comboBoxElement = new System.Windows.Forms.ComboBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelElement = new System.Windows.Forms.Label();
            this.labelGap = new System.Windows.Forms.Label();
            this.numericGap = new System.Windows.Forms.NumericUpDown();
            this.labelBorder = new System.Windows.Forms.Label();
            this.numericBorder = new System.Windows.Forms.NumericUpDown();
            this.panelHost = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.kiwiManager1 = new Kiwi.ComponentFactory.Toolkit.KiwiManager(this.components);
            this.groupBoxModes.SuspendLayout();
            this.groupBoxBarOrientation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiNavigator)).BeginInit();
            this.kiwiNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage1)).BeginInit();
            this.kiwiPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage2)).BeginInit();
            this.kiwiPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage3)).BeginInit();
            this.kiwiPage3.SuspendLayout();
            this.groupBoxPopupPageProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBorder)).BeginInit();
            this.panelHost.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxModes
            // 
            this.groupBoxModes.Controls.Add(this.radioOutlookMini);
            this.groupBoxModes.Controls.Add(this.radioHeaderBarCheckButtonOnly);
            this.groupBoxModes.Controls.Add(this.radioBarCheckButtonOnly);
            this.groupBoxModes.Controls.Add(this.radioBarRibbonTabOnly);
            this.groupBoxModes.Controls.Add(this.radioBarCheckButtonGroupOnly);
            this.groupBoxModes.Controls.Add(this.radioBarTabOnly);
            this.groupBoxModes.Location = new System.Drawing.Point(12, 12);
            this.groupBoxModes.Name = "groupBoxModes";
            this.groupBoxModes.Size = new System.Drawing.Size(205, 166);
            this.groupBoxModes.TabIndex = 0;
            this.groupBoxModes.TabStop = false;
            this.groupBoxModes.Text = "Modes";
            // 
            // radioOutlookMini
            // 
            this.radioOutlookMini.AutoSize = true;
            this.radioOutlookMini.Location = new System.Drawing.Point(18, 139);
            this.radioOutlookMini.Name = "radioOutlookMini";
            this.radioOutlookMini.Size = new System.Drawing.Size(90, 17);
            this.radioOutlookMini.TabIndex = 5;
            this.radioOutlookMini.TabStop = true;
            this.radioOutlookMini.Text = "Outlook - Mini";
            this.radioOutlookMini.UseVisualStyleBackColor = true;
            this.radioOutlookMini.CheckedChanged += new System.EventHandler(this.radioOutlookMini_CheckedChanged);
            // 
            // radioHeaderBarCheckButtonOnly
            // 
            this.radioHeaderBarCheckButtonOnly.AutoSize = true;
            this.radioHeaderBarCheckButtonOnly.Location = new System.Drawing.Point(18, 116);
            this.radioHeaderBarCheckButtonOnly.Name = "radioHeaderBarCheckButtonOnly";
            this.radioHeaderBarCheckButtonOnly.Size = new System.Drawing.Size(177, 17);
            this.radioHeaderBarCheckButtonOnly.TabIndex = 4;
            this.radioHeaderBarCheckButtonOnly.TabStop = true;
            this.radioHeaderBarCheckButtonOnly.Text = "HeaderBar - CheckButton - Only";
            this.radioHeaderBarCheckButtonOnly.UseVisualStyleBackColor = true;
            this.radioHeaderBarCheckButtonOnly.CheckedChanged += new System.EventHandler(this.radioHeaderBarCheckButtonOnly_CheckedChanged);
            // 
            // radioBarCheckButtonOnly
            // 
            this.radioBarCheckButtonOnly.AutoSize = true;
            this.radioBarCheckButtonOnly.Location = new System.Drawing.Point(18, 93);
            this.radioBarCheckButtonOnly.Name = "radioBarCheckButtonOnly";
            this.radioBarCheckButtonOnly.Size = new System.Drawing.Size(145, 17);
            this.radioBarCheckButtonOnly.TabIndex = 3;
            this.radioBarCheckButtonOnly.TabStop = true;
            this.radioBarCheckButtonOnly.Text = "Bar - CheckButton -  Only";
            this.radioBarCheckButtonOnly.UseVisualStyleBackColor = true;
            this.radioBarCheckButtonOnly.CheckedChanged += new System.EventHandler(this.radioBarCheckButtonOnly_CheckedChanged);
            // 
            // radioBarRibbonTabOnly
            // 
            this.radioBarRibbonTabOnly.AutoSize = true;
            this.radioBarRibbonTabOnly.Location = new System.Drawing.Point(18, 47);
            this.radioBarRibbonTabOnly.Name = "radioBarRibbonTabOnly";
            this.radioBarRibbonTabOnly.Size = new System.Drawing.Size(133, 17);
            this.radioBarRibbonTabOnly.TabIndex = 1;
            this.radioBarRibbonTabOnly.TabStop = true;
            this.radioBarRibbonTabOnly.Text = "Bar - RibbonTab - Only";
            this.radioBarRibbonTabOnly.UseVisualStyleBackColor = true;
            this.radioBarRibbonTabOnly.CheckedChanged += new System.EventHandler(this.radioBarRibbonTabOnly_CheckedChanged);
            // 
            // radioBarCheckButtonGroupOnly
            // 
            this.radioBarCheckButtonGroupOnly.AutoSize = true;
            this.radioBarCheckButtonGroupOnly.Location = new System.Drawing.Point(18, 70);
            this.radioBarCheckButtonGroupOnly.Name = "radioBarCheckButtonGroupOnly";
            this.radioBarCheckButtonGroupOnly.Size = new System.Drawing.Size(180, 17);
            this.radioBarCheckButtonGroupOnly.TabIndex = 2;
            this.radioBarCheckButtonGroupOnly.TabStop = true;
            this.radioBarCheckButtonGroupOnly.Text = "Bar - CheckButton - Group - Only";
            this.radioBarCheckButtonGroupOnly.UseVisualStyleBackColor = true;
            this.radioBarCheckButtonGroupOnly.CheckedChanged += new System.EventHandler(this.radioBarCheckButtonGroupOnly_CheckedChanged);
            // 
            // radioBarTabOnly
            // 
            this.radioBarTabOnly.AutoSize = true;
            this.radioBarTabOnly.Location = new System.Drawing.Point(18, 24);
            this.radioBarTabOnly.Name = "radioBarTabOnly";
            this.radioBarTabOnly.Size = new System.Drawing.Size(99, 17);
            this.radioBarTabOnly.TabIndex = 0;
            this.radioBarTabOnly.TabStop = true;
            this.radioBarTabOnly.Text = "Bar - Tab - Only";
            this.radioBarTabOnly.UseVisualStyleBackColor = true;
            this.radioBarTabOnly.CheckedChanged += new System.EventHandler(this.radioBarTabOnly_CheckedChanged);
            // 
            // groupBoxBarOrientation
            // 
            this.groupBoxBarOrientation.Controls.Add(this.radioOrientationRight);
            this.groupBoxBarOrientation.Controls.Add(this.radioOrientationLeft);
            this.groupBoxBarOrientation.Controls.Add(this.radioOrientationBottom);
            this.groupBoxBarOrientation.Controls.Add(this.radioOrientationTop);
            this.groupBoxBarOrientation.Location = new System.Drawing.Point(12, 184);
            this.groupBoxBarOrientation.Name = "groupBoxBarOrientation";
            this.groupBoxBarOrientation.Size = new System.Drawing.Size(205, 120);
            this.groupBoxBarOrientation.TabIndex = 1;
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
            // kiwiNavigator
            // 
            this.kiwiNavigator.AutoSize = true;
            this.kiwiNavigator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kiwiNavigator.Button.CloseButtonDisplay = Kiwi.ComponentFactory.Navigator.ButtonDisplay.Hide;
            this.kiwiNavigator.Dock = System.Windows.Forms.DockStyle.Top;
            this.kiwiNavigator.Location = new System.Drawing.Point(0, 0);
            this.kiwiNavigator.Name = "kiwiNavigator";
            this.kiwiNavigator.NavigatorMode = Kiwi.ComponentFactory.Navigator.NavigatorMode.HeaderBarCheckButtonOnly;
            this.kiwiNavigator.Pages.AddRange(new Kiwi.ComponentFactory.Navigator.KiwiPage[] {
            this.kiwiPage1,
            this.kiwiPage2,
            this.kiwiPage3});
            this.kiwiNavigator.PopupPages.AllowPopupPages = Kiwi.ComponentFactory.Navigator.PopupPageAllow.OnlyCompatibleModes;
            this.kiwiNavigator.SelectedIndex = 2;
            this.kiwiNavigator.Size = new System.Drawing.Size(325, 31);
            this.kiwiNavigator.TabIndex = 0;
            this.kiwiNavigator.Text = "kiwiNavigator1";
            // 
            // kiwiPage1
            // 
            this.kiwiPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kiwiPage1.Controls.Add(this.button3);
            this.kiwiPage1.Controls.Add(this.button4);
            this.kiwiPage1.Controls.Add(this.button2);
            this.kiwiPage1.Controls.Add(this.button1);
            this.kiwiPage1.Flags = 65534;
            this.kiwiPage1.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiPage1.ImageSmall")));
            this.kiwiPage1.LastVisibleSet = true;
            this.kiwiPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kiwiPage1.Name = "kiwiPage1";
            this.kiwiPage1.Padding = new System.Windows.Forms.Padding(15);
            this.kiwiPage1.Size = new System.Drawing.Size(323, 87);
            this.kiwiPage1.Text = "First";
            this.kiwiPage1.TextDescription = "First";
            this.kiwiPage1.TextTitle = "First";
            this.kiwiPage1.ToolTipTitle = "Page ToolTip";
            this.kiwiPage1.UniqueName = "7E2C077BE4094D077E2C077BE4094D07";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // kiwiPage2
            // 
            this.kiwiPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kiwiPage2.Controls.Add(this.listBox1);
            this.kiwiPage2.Flags = 65534;
            this.kiwiPage2.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiPage2.ImageSmall")));
            this.kiwiPage2.LastVisibleSet = true;
            this.kiwiPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kiwiPage2.Name = "kiwiPage2";
            this.kiwiPage2.Padding = new System.Windows.Forms.Padding(15);
            this.kiwiPage2.Size = new System.Drawing.Size(323, 117);
            this.kiwiPage2.Text = "Second";
            this.kiwiPage2.TextDescription = "Second";
            this.kiwiPage2.TextTitle = "Second";
            this.kiwiPage2.ToolTipTitle = "Page ToolTip";
            this.kiwiPage2.UniqueName = "BFAC6C72E7814623BFAC6C72E7814623";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "alpha",
            "beta",
            "gamma",
            "theta",
            "omega",
            "delta",
            "ohmn",
            "pi"});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 82);
            this.listBox1.TabIndex = 0;
            // 
            // kiwiPage3
            // 
            this.kiwiPage3.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kiwiPage3.Controls.Add(this.textBox1);
            this.kiwiPage3.Controls.Add(this.progressBar1);
            this.kiwiPage3.Flags = 65534;
            this.kiwiPage3.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiPage3.ImageSmall")));
            this.kiwiPage3.LastVisibleSet = true;
            this.kiwiPage3.MinimumSize = new System.Drawing.Size(50, 50);
            this.kiwiPage3.Name = "kiwiPage3";
            this.kiwiPage3.Padding = new System.Windows.Forms.Padding(15);
            this.kiwiPage3.Size = new System.Drawing.Size(323, 83);
            this.kiwiPage3.Text = "Third";
            this.kiwiPage3.TextDescription = "Third";
            this.kiwiPage3.TextTitle = "Third";
            this.kiwiPage3.ToolTipTitle = "Page ToolTip";
            this.kiwiPage3.UniqueName = "FB3FA57F03934EE1FB3FA57F03934EE1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Progress";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 75;
            // 
            // groupBoxPopupPageProperties
            // 
            this.groupBoxPopupPageProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPopupPageProperties.Controls.Add(this.comboBoxPosition);
            this.groupBoxPopupPageProperties.Controls.Add(this.comboBoxElement);
            this.groupBoxPopupPageProperties.Controls.Add(this.labelPosition);
            this.groupBoxPopupPageProperties.Controls.Add(this.labelElement);
            this.groupBoxPopupPageProperties.Controls.Add(this.labelGap);
            this.groupBoxPopupPageProperties.Controls.Add(this.numericGap);
            this.groupBoxPopupPageProperties.Controls.Add(this.labelBorder);
            this.groupBoxPopupPageProperties.Controls.Add(this.numericBorder);
            this.groupBoxPopupPageProperties.Location = new System.Drawing.Point(562, 12);
            this.groupBoxPopupPageProperties.Name = "groupBoxPopupPageProperties";
            this.groupBoxPopupPageProperties.Size = new System.Drawing.Size(207, 141);
            this.groupBoxPopupPageProperties.TabIndex = 3;
            this.groupBoxPopupPageProperties.TabStop = false;
            this.groupBoxPopupPageProperties.Text = "Popup Page Properties";
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "ModeAppropriate",
            "AboveNear",
            "AboveFar",
            "AboveMatch",
            "BelowNear",
            "BelowFar",
            "BelowMatch",
            "FarTop",
            "FarBottom",
            "FarMatch",
            "NearTop",
            "NearBottom",
            "NearMatch"});
            this.comboBoxPosition.Location = new System.Drawing.Point(68, 107);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPosition.TabIndex = 4;
            this.comboBoxPosition.SelectedIndexChanged += new System.EventHandler(this.comboBoxPosition_SelectedIndexChanged);
            // 
            // comboBoxElement
            // 
            this.comboBoxElement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxElement.FormattingEnabled = true;
            this.comboBoxElement.Items.AddRange(new object[] {
            "Item",
            "Navigator"});
            this.comboBoxElement.Location = new System.Drawing.Point(68, 80);
            this.comboBoxElement.Name = "comboBoxElement";
            this.comboBoxElement.Size = new System.Drawing.Size(121, 21);
            this.comboBoxElement.TabIndex = 3;
            this.comboBoxElement.SelectedIndexChanged += new System.EventHandler(this.comboBoxElement_SelectedIndexChanged);
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(17, 110);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(44, 13);
            this.labelPosition.TabIndex = 6;
            this.labelPosition.Text = "Position";
            // 
            // labelElement
            // 
            this.labelElement.AutoSize = true;
            this.labelElement.Location = new System.Drawing.Point(16, 83);
            this.labelElement.Name = "labelElement";
            this.labelElement.Size = new System.Drawing.Size(45, 13);
            this.labelElement.TabIndex = 5;
            this.labelElement.Text = "Element";
            // 
            // labelGap
            // 
            this.labelGap.AutoSize = true;
            this.labelGap.Location = new System.Drawing.Point(34, 56);
            this.labelGap.Name = "labelGap";
            this.labelGap.Size = new System.Drawing.Size(27, 13);
            this.labelGap.TabIndex = 4;
            this.labelGap.Text = "Gap";
            // 
            // numericGap
            // 
            this.numericGap.Location = new System.Drawing.Point(68, 54);
            this.numericGap.Name = "numericGap";
            this.numericGap.Size = new System.Drawing.Size(50, 20);
            this.numericGap.TabIndex = 2;
            this.numericGap.ValueChanged += new System.EventHandler(this.numericGap_ValueChanged);
            // 
            // labelBorder
            // 
            this.labelBorder.AutoSize = true;
            this.labelBorder.Location = new System.Drawing.Point(23, 30);
            this.labelBorder.Name = "labelBorder";
            this.labelBorder.Size = new System.Drawing.Size(38, 13);
            this.labelBorder.TabIndex = 2;
            this.labelBorder.Text = "Border";
            // 
            // numericBorder
            // 
            this.numericBorder.Location = new System.Drawing.Point(68, 28);
            this.numericBorder.Name = "numericBorder";
            this.numericBorder.Size = new System.Drawing.Size(50, 20);
            this.numericBorder.TabIndex = 1;
            this.numericBorder.ValueChanged += new System.EventHandler(this.numericBorder_ValueChanged);
            // 
            // panelHost
            // 
            this.panelHost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHost.Controls.Add(this.kiwiNavigator);
            this.panelHost.Location = new System.Drawing.Point(227, 19);
            this.panelHost.Name = "panelHost";
            this.panelHost.Size = new System.Drawing.Size(325, 285);
            this.panelHost.TabIndex = 6;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(694, 281);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 319);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panelHost);
            this.Controls.Add(this.groupBoxPopupPageProperties);
            this.Controls.Add(this.groupBoxBarOrientation);
            this.Controls.Add(this.groupBoxModes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(789, 353);
            this.Name = "Form1";
            this.Text = "Popup Pages";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxModes.ResumeLayout(false);
            this.groupBoxModes.PerformLayout();
            this.groupBoxBarOrientation.ResumeLayout(false);
            this.groupBoxBarOrientation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiNavigator)).EndInit();
            this.kiwiNavigator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage1)).EndInit();
            this.kiwiPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage2)).EndInit();
            this.kiwiPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage3)).EndInit();
            this.kiwiPage3.ResumeLayout(false);
            this.kiwiPage3.PerformLayout();
            this.groupBoxPopupPageProperties.ResumeLayout(false);
            this.groupBoxPopupPageProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBorder)).EndInit();
            this.panelHost.ResumeLayout(false);
            this.panelHost.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxModes;
        private System.Windows.Forms.RadioButton radioBarRibbonTabOnly;
        private System.Windows.Forms.RadioButton radioBarCheckButtonGroupOnly;
        private System.Windows.Forms.RadioButton radioBarTabOnly;
        private System.Windows.Forms.GroupBox groupBoxBarOrientation;
        private System.Windows.Forms.RadioButton radioOrientationRight;
        private System.Windows.Forms.RadioButton radioOrientationLeft;
        private System.Windows.Forms.RadioButton radioOrientationBottom;
        private System.Windows.Forms.RadioButton radioOrientationTop;
        private System.Windows.Forms.RadioButton radioOutlookMini;
        private System.Windows.Forms.RadioButton radioHeaderBarCheckButtonOnly;
        private System.Windows.Forms.RadioButton radioBarCheckButtonOnly;
        private Kiwi.ComponentFactory.Navigator.KiwiNavigator kiwiNavigator;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPage1;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPage2;
        private System.Windows.Forms.GroupBox groupBoxPopupPageProperties;
        private System.Windows.Forms.Label labelElement;
        private System.Windows.Forms.Label labelGap;
        private System.Windows.Forms.NumericUpDown numericGap;
        private System.Windows.Forms.Label labelBorder;
        private System.Windows.Forms.NumericUpDown numericBorder;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.ComboBox comboBoxElement;
        private System.Windows.Forms.Label labelPosition;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPage3;
        private System.Windows.Forms.Panel panelHost;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonClose;
        private Kiwi.ComponentFactory.Toolkit.KiwiManager kiwiManager1;
    }
}

