
namespace Basic_Events
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.kiwiNavigator1 = new Kiwi.ComponentFactory.Navigator.KiwiNavigator();
            this.kiwiPage1 = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.kiwiPage2 = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.groupBoxPages = new System.Windows.Forms.GroupBox();
            this.kiwiButtonEnable = new Kiwi.ComponentFactory.Toolkit.KiwiButton();
            this.kiwiButtonClear = new Kiwi.ComponentFactory.Toolkit.KiwiButton();
            this.kiwiButtonRemove = new Kiwi.ComponentFactory.Toolkit.KiwiButton();
            this.kiwiButtonAdd = new Kiwi.ComponentFactory.Toolkit.KiwiButton();
            this.groupBoxProperties = new System.Windows.Forms.GroupBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonClearEventList = new System.Windows.Forms.Button();
            this.kiwiManager1 = new Kiwi.ComponentFactory.Toolkit.KiwiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiNavigator1)).BeginInit();
            this.kiwiNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage2)).BeginInit();
            this.groupBoxPages.SuspendLayout();
            this.groupBoxProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "alarmclock.png");
            this.imageList1.Images.SetKeyName(1, "apple.png");
            this.imageList1.Images.SetKeyName(2, "banana.png");
            this.imageList1.Images.SetKeyName(3, "basketball.png");
            this.imageList1.Images.SetKeyName(4, "cloud_sun.png");
            this.imageList1.Images.SetKeyName(5, "die_blue.png");
            this.imageList1.Images.SetKeyName(6, "doctor.png");
            this.imageList1.Images.SetKeyName(7, "flower_blue.png");
            this.imageList1.Images.SetKeyName(8, "gear.png");
            this.imageList1.Images.SetKeyName(9, "house.png");
            // 
            // kiwiNavigator1
            // 
            this.kiwiNavigator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.kiwiNavigator1.Button.ButtonDisplayLogic = Kiwi.ComponentFactory.Navigator.ButtonDisplayLogic.ContextNextPrevious;
            this.kiwiNavigator1.Location = new System.Drawing.Point(18, 31);
            this.kiwiNavigator1.Name = "kiwiNavigator1";
            this.kiwiNavigator1.Pages.AddRange(new Kiwi.ComponentFactory.Navigator.KiwiPage[] {
            this.kiwiPage1,
            this.kiwiPage2});
            this.kiwiNavigator1.SelectedIndex = 0;
            this.kiwiNavigator1.Size = new System.Drawing.Size(297, 355);
            this.kiwiNavigator1.StateCommon.CheckButton.Content.Image.ImageH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Center;
            this.kiwiNavigator1.StateCommon.CheckButton.Content.Image.ImageV = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Near;
            this.kiwiNavigator1.TabIndex = 0;
            this.kiwiNavigator1.Text = "kiwiNavigator1";
            this.kiwiNavigator1.Selected += new System.EventHandler<Kiwi.ComponentFactory.Navigator.KiwiPageEventArgs>(this.kiwiNavigator1_Selected);
            this.kiwiNavigator1.Deselecting += new System.EventHandler<Kiwi.ComponentFactory.Navigator.KiwiPageCancelEventArgs>(this.kiwiNavigator1_Deselecting);
            this.kiwiNavigator1.CloseAction += new System.EventHandler<Kiwi.ComponentFactory.Navigator.CloseActionEventArgs>(this.kiwiNavigator1_CloseAction);
            this.kiwiNavigator1.ContextAction += new System.EventHandler<Kiwi.ComponentFactory.Navigator.ContextActionEventArgs>(this.kiwiNavigator1_ContextAction);
            this.kiwiNavigator1.NextAction += new System.EventHandler<Kiwi.ComponentFactory.Navigator.DirectionActionEventArgs>(this.kiwiNavigator1_NextAction);
            this.kiwiNavigator1.Deselected += new System.EventHandler<Kiwi.ComponentFactory.Navigator.KiwiPageEventArgs>(this.kiwiNavigator1_Deselected);
            this.kiwiNavigator1.PreviousAction += new System.EventHandler<Kiwi.ComponentFactory.Navigator.DirectionActionEventArgs>(this.kiwiNavigator1_PreviousAction);
            this.kiwiNavigator1.SelectedPageChanged += new System.EventHandler(this.kiwiNavigator1_SelectedPageChanged);
            this.kiwiNavigator1.Selecting += new System.EventHandler<Kiwi.ComponentFactory.Navigator.KiwiPageCancelEventArgs>(this.kiwiNavigator1_Selecting);
            // 
            // kiwiage1
            // 
            this.kiwiPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kiwiPage1.Flags = 65534;
            this.kiwiPage1.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kiwiPage1.ImageLarge")));
            this.kiwiPage1.ImageMedium = ((System.Drawing.Image)(resources.GetObject("kiwiPage1.ImageMedium")));
            this.kiwiPage1.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiPage1.ImageSmall")));
            this.kiwiPage1.LastVisibleSet = true;
            this.kiwiPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kiwiPage1.Name = "kiwiPage1";
            this.kiwiPage1.Size = new System.Drawing.Size(295, 329);
            this.kiwiPage1.Text = "Page 1";
            this.kiwiPage1.TextDescription = "Page 1 Description";
            this.kiwiPage1.TextTitle = "Page 1 Title";
            this.kiwiPage1.ToolTipTitle = "Page ToolTip";
            this.kiwiPage1.UniqueName = "BA1D4D82F8F54F79BA1D4D82F8F54F79";
            // 
            // kiwiPage2
            // 
            this.kiwiPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kiwiPage2.Flags = 65534;
            this.kiwiPage2.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kiwiPage2.ImageLarge")));
            this.kiwiPage2.ImageMedium = ((System.Drawing.Image)(resources.GetObject("kiwiPage2.ImageMedium")));
            this.kiwiPage2.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiPage2.ImageSmall")));
            this.kiwiPage2.LastVisibleSet = true;
            this.kiwiPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kiwiPage2.Name = "kiwiPage2";
            this.kiwiPage2.Size = new System.Drawing.Size(295, 329);
            this.kiwiPage2.Text = "Page 2";
            this.kiwiPage2.TextDescription = "Page 2 Description";
            this.kiwiPage2.TextTitle = "Page 2 Title";
            this.kiwiPage2.ToolTipTitle = "Page ToolTip";
            this.kiwiPage2.UniqueName = "1FDD9B3FB1A6438C1FDD9B3FB1A6438C";
            // 
            // groupBoxPages
            // 
            this.groupBoxPages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxPages.Controls.Add(this.kiwiButtonEnable);
            this.groupBoxPages.Controls.Add(this.kiwiButtonClear);
            this.groupBoxPages.Controls.Add(this.kiwiButtonRemove);
            this.groupBoxPages.Controls.Add(this.kiwiButtonAdd);
            this.groupBoxPages.Location = new System.Drawing.Point(13, 407);
            this.groupBoxPages.Name = "groupBoxPages";
            this.groupBoxPages.Size = new System.Drawing.Size(309, 69);
            this.groupBoxPages.TabIndex = 1;
            this.groupBoxPages.TabStop = false;
            this.groupBoxPages.Text = "Pages";
            // 
            // kiwiButtonEnable
            // 
            this.kiwiButtonEnable.Location = new System.Drawing.Point(234, 26);
            this.kiwiButtonEnable.Name = "kiwiButtonEnable";
            this.kiwiButtonEnable.Size = new System.Drawing.Size(65, 29);
            this.kiwiButtonEnable.TabIndex = 4;
            this.kiwiButtonEnable.Values.Text = "Enable";
            this.kiwiButtonEnable.Click += new System.EventHandler(this.kiwiButtonEnable_Click);
            // 
            // kiwiButtonClear
            // 
            this.kiwiButtonClear.Location = new System.Drawing.Point(159, 26);
            this.kiwiButtonClear.Name = "kiwiButtonClear";
            this.kiwiButtonClear.Size = new System.Drawing.Size(65, 29);
            this.kiwiButtonClear.TabIndex = 2;
            this.kiwiButtonClear.Values.Text = "Clear";
            this.kiwiButtonClear.Click += new System.EventHandler(this.kiwiButtonClear_Click);
            // 
            // kiwiButtonRemove
            // 
            this.kiwiButtonRemove.Location = new System.Drawing.Point(84, 26);
            this.kiwiButtonRemove.Name = "kiwiButtonRemove";
            this.kiwiButtonRemove.Size = new System.Drawing.Size(65, 29);
            this.kiwiButtonRemove.TabIndex = 1;
            this.kiwiButtonRemove.Values.Text = "Remove";
            this.kiwiButtonRemove.Click += new System.EventHandler(this.kiwiButtonRemove_Click);
            // 
            // kiwiButtonAdd
            // 
            this.kiwiButtonAdd.Location = new System.Drawing.Point(9, 26);
            this.kiwiButtonAdd.Name = "kiwiButtonAdd";
            this.kiwiButtonAdd.Size = new System.Drawing.Size(65, 29);
            this.kiwiButtonAdd.TabIndex = 0;
            this.kiwiButtonAdd.Values.Text = "Add";
            this.kiwiButtonAdd.Click += new System.EventHandler(this.kiwiButtonAdd_Click);
            // 
            // groupBoxProperties
            // 
            this.groupBoxProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxProperties.Controls.Add(this.listBoxEvents);
            this.groupBoxProperties.Location = new System.Drawing.Point(328, 12);
            this.groupBoxProperties.Name = "groupBoxProperties";
            this.groupBoxProperties.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxProperties.Size = new System.Drawing.Size(312, 464);
            this.groupBoxProperties.TabIndex = 2;
            this.groupBoxProperties.TabStop = false;
            this.groupBoxProperties.Text = "Properties for KiwiNavigator";
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxEvents.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 15;
            this.listBoxEvents.Location = new System.Drawing.Point(5, 19);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(302, 439);
            this.listBoxEvents.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(565, 485);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonClearEventList
            // 
            this.buttonClearEventList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearEventList.Location = new System.Drawing.Point(455, 485);
            this.buttonClearEventList.Name = "buttonClearEventList";
            this.buttonClearEventList.Size = new System.Drawing.Size(104, 23);
            this.buttonClearEventList.TabIndex = 3;
            this.buttonClearEventList.Text = "Clear Event List";
            this.buttonClearEventList.UseVisualStyleBackColor = true;
            this.buttonClearEventList.Click += new System.EventHandler(this.buttonClearEventList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 516);
            this.Controls.Add(this.buttonClearEventList);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxProperties);
            this.Controls.Add(this.groupBoxPages);
            this.Controls.Add(this.kiwiNavigator1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(530, 326);
            this.Name = "Form1";
            this.Text = "Basic Events";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiNavigator1)).EndInit();
            this.kiwiNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage2)).EndInit();
            this.groupBoxPages.ResumeLayout(false);
            this.groupBoxProperties.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private Kiwi.ComponentFactory.Navigator.KiwiNavigator kiwiNavigator1;
        private System.Windows.Forms.GroupBox groupBoxPages;
        private Kiwi.ComponentFactory.Toolkit.KiwiButton kiwiButtonClear;
        private Kiwi.ComponentFactory.Toolkit.KiwiButton kiwiButtonRemove;
        private Kiwi.ComponentFactory.Toolkit.KiwiButton kiwiButtonAdd;
        private System.Windows.Forms.GroupBox groupBoxProperties;
        private System.Windows.Forms.Button buttonClose;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPage1;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPage2;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Button buttonClearEventList;
        private Kiwi.ComponentFactory.Toolkit.KiwiButton kiwiButtonEnable;
        private Kiwi.ComponentFactory.Toolkit.KiwiManager kiwiManager1;
    }
}

