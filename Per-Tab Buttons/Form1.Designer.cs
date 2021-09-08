
namespace Per_Tab_Buttons
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
            this.radioModesOutlook = new System.Windows.Forms.RadioButton();
            this.radioModesStack = new System.Windows.Forms.RadioButton();
            this.radioModeRibbonTabs = new System.Windows.Forms.RadioButton();
            this.radioModesCheckButton = new System.Windows.Forms.RadioButton();
            this.radioModeTabs = new System.Windows.Forms.RadioButton();
            this.kiwiNavigator = new Kiwi.ComponentFactory.Navigator.KiwiNavigator();
            this.kiwiPage1 = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.kiwiPage2 = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.kiwiPage3 = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.kiwiPage4 = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.kiwiContextMenu = new Kiwi.ComponentFactory.Toolkit.KiwiContextMenu();
            this.kiwiContextMenuItems1 = new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItems();
            this.kiwiContextMenuItem1 = new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem();
            this.kiwiContextMenuItem2 = new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem();
            this.kiwiContextMenuItem3 = new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem();
            this.kiwiContextMenuItem4 = new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSpecAny1 = new Kiwi.ComponentFactory.Toolkit.ButtonSpecAny();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clearButtons = new System.Windows.Forms.Button();
            this.addText = new System.Windows.Forms.Button();
            this.addContext = new System.Windows.Forms.Button();
            this.addArrow = new System.Windows.Forms.Button();
            this.kiwiManager1 = new Kiwi.ComponentFactory.Toolkit.KiwiManager(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiNavigator)).BeginInit();
            this.kiwiNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage4)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioModesOutlook);
            this.groupBox1.Controls.Add(this.radioModesStack);
            this.groupBox1.Controls.Add(this.radioModeRibbonTabs);
            this.groupBox1.Controls.Add(this.radioModesCheckButton);
            this.groupBox1.Controls.Add(this.radioModeTabs);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modes";
            // 
            // radioModesOutlook
            // 
            this.radioModesOutlook.AutoSize = true;
            this.radioModesOutlook.Location = new System.Drawing.Point(18, 116);
            this.radioModesOutlook.Name = "radioModesOutlook";
            this.radioModesOutlook.Size = new System.Drawing.Size(62, 17);
            this.radioModesOutlook.TabIndex = 4;
            this.radioModesOutlook.TabStop = true;
            this.radioModesOutlook.Text = "Outlook";
            this.radioModesOutlook.UseVisualStyleBackColor = true;
            this.radioModesOutlook.CheckedChanged += new System.EventHandler(this.radioModesOutlook_CheckedChanged);
            // 
            // radioModesStack
            // 
            this.radioModesStack.AutoSize = true;
            this.radioModesStack.Location = new System.Drawing.Point(18, 93);
            this.radioModesStack.Name = "radioModesStack";
            this.radioModesStack.Size = new System.Drawing.Size(51, 17);
            this.radioModesStack.TabIndex = 3;
            this.radioModesStack.TabStop = true;
            this.radioModesStack.Text = "Stack";
            this.radioModesStack.UseVisualStyleBackColor = true;
            this.radioModesStack.CheckedChanged += new System.EventHandler(this.radioModesStack_CheckedChanged);
            // 
            // radioModeRibbonTabs
            // 
            this.radioModeRibbonTabs.AutoSize = true;
            this.radioModeRibbonTabs.Location = new System.Drawing.Point(18, 47);
            this.radioModeRibbonTabs.Name = "radioModeRibbonTabs";
            this.radioModeRibbonTabs.Size = new System.Drawing.Size(81, 17);
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
            this.radioModesCheckButton.Size = new System.Drawing.Size(91, 17);
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
            this.radioModeTabs.Size = new System.Drawing.Size(48, 17);
            this.radioModeTabs.TabIndex = 0;
            this.radioModeTabs.TabStop = true;
            this.radioModeTabs.Text = "Tabs";
            this.radioModeTabs.UseVisualStyleBackColor = true;
            this.radioModeTabs.CheckedChanged += new System.EventHandler(this.radioModeTabs_CheckedChanged);
            // 
            // kiwiNavigator
            // 
            this.kiwiNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.kiwiNavigator.Bar.ItemMaximumSize = new System.Drawing.Size(2000, 200);
            this.kiwiNavigator.Button.ButtonDisplayLogic = Kiwi.ComponentFactory.Navigator.ButtonDisplayLogic.NextPrevious;
            this.kiwiNavigator.Button.CloseButtonDisplay = Kiwi.ComponentFactory.Navigator.ButtonDisplay.Hide;
            this.kiwiNavigator.Location = new System.Drawing.Point(176, 21);
            this.kiwiNavigator.Name = "kiwiNavigator";
            this.kiwiNavigator.Pages.AddRange(new Kiwi.ComponentFactory.Navigator.KiwiPage[] {
            this.kiwiPage1,
            this.kiwiPage2,
            this.kiwiPage3,
            this.kiwiPage4});
            this.kiwiNavigator.SelectedIndex = 0;
            this.kiwiNavigator.Size = new System.Drawing.Size(488, 314);
            this.kiwiNavigator.TabIndex = 2;
            this.kiwiNavigator.Text = "kiwiNavigator1";
            // 
            // kiwiPage1
            // 
            this.kiwiPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kiwiPage1.Flags = 65534;
            this.kiwiPage1.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiPage1.ImageSmall")));
            this.kiwiPage1.LastVisibleSet = true;
            this.kiwiPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kiwiPage1.Name = "kiwiPage1";
            this.kiwiPage1.Size = new System.Drawing.Size(486, 281);
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
            this.kiwiPage2.Size = new System.Drawing.Size(486, 281);
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
            // kiwiContextMenu
            // 
            this.kiwiContextMenu.Items.AddRange(new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItemBase[] {
            this.kiwiContextMenuItems1});
            // 
            // kiwiContextMenuItems1
            // 
            this.kiwiContextMenuItems1.Items.AddRange(new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItemBase[] {
            this.kiwiContextMenuItem1,
            this.kiwiContextMenuItem2,
            this.kiwiContextMenuItem3,
            this.kiwiContextMenuItem4});
            // 
            // kiwiContextMenuItem1
            // 
            this.kiwiContextMenuItem1.Text = "Menu Item";
            // 
            // kiwiContextMenuItem2
            // 
            this.kiwiContextMenuItem2.Text = "Menu Item";
            // 
            // kiwiContextMenuItem3
            // 
            this.kiwiContextMenuItem3.Text = "Menu Item";
            // 
            // kiwiContextMenuItem4
            // 
            this.kiwiContextMenuItem4.Text = "Menu Item";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(588, 348);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Style = Kiwi.ComponentFactory.Toolkit.PaletteButtonStyle.Standalone;
            this.buttonSpecAny1.Type = Kiwi.ComponentFactory.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny1.UniqueName = "6646CFE7A52E42FA6646CFE7A52E42FA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clearButtons);
            this.groupBox2.Controls.Add(this.addText);
            this.groupBox2.Controls.Add(this.addContext);
            this.groupBox2.Controls.Add(this.addArrow);
            this.groupBox2.Location = new System.Drawing.Point(12, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 167);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Page Buttons";
            // 
            // clearButtons
            // 
            this.clearButtons.Location = new System.Drawing.Point(18, 125);
            this.clearButtons.Name = "clearButtons";
            this.clearButtons.Size = new System.Drawing.Size(103, 26);
            this.clearButtons.TabIndex = 3;
            this.clearButtons.Text = "   Clear";
            this.clearButtons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearButtons.UseVisualStyleBackColor = true;
            this.clearButtons.Click += new System.EventHandler(this.clearButtons_Click);
            // 
            // addText
            // 
            this.addText.Location = new System.Drawing.Point(18, 56);
            this.addText.Name = "addText";
            this.addText.Size = new System.Drawing.Size(103, 26);
            this.addText.TabIndex = 2;
            this.addText.Text = "   Add \'Text\'";
            this.addText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addText.UseVisualStyleBackColor = true;
            this.addText.Click += new System.EventHandler(this.addText_Click);
            // 
            // addContext
            // 
            this.addContext.Location = new System.Drawing.Point(18, 25);
            this.addContext.Name = "addContext";
            this.addContext.Size = new System.Drawing.Size(103, 26);
            this.addContext.TabIndex = 1;
            this.addContext.Text = "   Add \'Context\'";
            this.addContext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addContext.UseVisualStyleBackColor = true;
            this.addContext.Click += new System.EventHandler(this.addContext_Click);
            // 
            // addArrow
            // 
            this.addArrow.Location = new System.Drawing.Point(18, 87);
            this.addArrow.Name = "addArrow";
            this.addArrow.Size = new System.Drawing.Size(103, 26);
            this.addArrow.TabIndex = 0;
            this.addArrow.Text = "   Add \'Arrow\'";
            this.addArrow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addArrow.UseVisualStyleBackColor = true;
            this.addArrow.Click += new System.EventHandler(this.addArrow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 383);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.kiwiNavigator);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(626, 419);
            this.Name = "Form1";
            this.Text = "Per-Tab Buttons";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiNavigator)).EndInit();
            this.kiwiNavigator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioModeRibbonTabs;
        private System.Windows.Forms.RadioButton radioModesCheckButton;
        private System.Windows.Forms.RadioButton radioModeTabs;
        private Kiwi.ComponentFactory.Navigator.KiwiNavigator kiwiNavigator;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPage1;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPage2;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPage3;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPage4;
        private System.Windows.Forms.RadioButton radioModesOutlook;
        private System.Windows.Forms.RadioButton radioModesStack;
        private System.Windows.Forms.Button buttonClose;
        private Kiwi.ComponentFactory.Toolkit.ButtonSpecAny buttonSpecAny1;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenu kiwiContextMenu;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItems kiwiContextMenuItems1;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem kiwiContextMenuItem1;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem kiwiContextMenuItem2;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem kiwiContextMenuItem3;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem kiwiContextMenuItem4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addContext;
        private System.Windows.Forms.Button addArrow;
        private System.Windows.Forms.Button clearButtons;
        private System.Windows.Forms.Button addText;
        private Kiwi.ComponentFactory.Toolkit.KiwiManager kiwiManager1;
    }
}

