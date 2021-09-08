
namespace Ribbon_Gallery
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
            this.kiwiRibbonTab1 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonTab();
            this.kiwiRibbonGroup1 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroup();
            this.kiwiRibbonGroupTriple1 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupTriple();
            this.kiwiRibbonGroupButton1 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton();
            this.kiwiRibbonGroupButton2 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton();
            this.kiwiRibbonGroupButton3 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton();
            this.kiwiRibbonGroup2 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroup();
            this.galleryNormal = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupGallery();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.galleryRanges = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupGallery();
            this.kiwiGalleryRange5 = new Kiwi.ComponentFactory.Ribbon.KiwiGalleryRange();
            this.kiwiGalleryRange6 = new Kiwi.ComponentFactory.Ribbon.KiwiGalleryRange();
            this.kiwiGalleryRange7 = new Kiwi.ComponentFactory.Ribbon.KiwiGalleryRange();
            this.galleryCustom = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupGallery();
            this.kiwiGalleryRange1 = new Kiwi.ComponentFactory.Ribbon.KiwiGalleryRange();
            this.kiwiGalleryRange2 = new Kiwi.ComponentFactory.Ribbon.KiwiGalleryRange();
            this.kiwiGalleryRange3 = new Kiwi.ComponentFactory.Ribbon.KiwiGalleryRange();
            this.kiwiGalleryRange4 = new Kiwi.ComponentFactory.Ribbon.KiwiGalleryRange();
            this.kiwiFillPanel = new Kiwi.ComponentFactory.Toolkit.KiwiPanel();
            this.kiwiPanel1 = new Kiwi.ComponentFactory.Toolkit.KiwiPanel();
            this.kiwiLabelExplain = new Kiwi.ComponentFactory.Toolkit.KiwiLabel();
            this.kiwiLabelTitle = new Kiwi.ComponentFactory.Toolkit.KiwiLabel();
            this.kiwiManager1 = new Kiwi.ComponentFactory.Toolkit.KiwiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiRibbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiFillPanel)).BeginInit();
            this.kiwiFillPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPanel1)).BeginInit();
            this.kiwiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kiwiRibbon
            // 
            this.kiwiRibbon.HideRibbonSize = new System.Drawing.Size(100, 100);
            this.kiwiRibbon.Name = "kiwiRibbon";
            this.kiwiRibbon.RibbonAppButton.AppButtonMenuItems.AddRange(new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItemBase[] {
            this.kiwiContextMenuItem1});
            this.kiwiRibbon.RibbonAppButton.AppButtonShowRecentDocs = false;
            this.kiwiRibbon.RibbonTabs.AddRange(new Kiwi.ComponentFactory.Ribbon.KiwiRibbonTab[] {
            this.kiwiRibbonTab1});
            this.kiwiRibbon.SelectedContext = null;
            this.kiwiRibbon.SelectedTab = this.kiwiRibbonTab1;
            this.kiwiRibbon.Size = new System.Drawing.Size(769, 114);
            this.kiwiRibbon.TabIndex = 0;
            // 
            // kiwiContextMenuItem1
            // 
            this.kiwiContextMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("kiwiContextMenuItem1.Image")));
            this.kiwiContextMenuItem1.Text = "E&xit";
            this.kiwiContextMenuItem1.Click += new System.EventHandler(this.kiwiContextMenuItem1_Click);
            // 
            // kiwiRibbonTab1
            // 
            this.kiwiRibbonTab1.Groups.AddRange(new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroup[] {
            this.kiwiRibbonGroup1,
            this.kiwiRibbonGroup2});
            // 
            // kiwiRibbonGroup1
            // 
            this.kiwiRibbonGroup1.AllowCollapsed = false;
            this.kiwiRibbonGroup1.Image = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroup1.Image")));
            this.kiwiRibbonGroup1.Items.AddRange(new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupContainer[] {
            this.kiwiRibbonGroupTriple1});
            this.kiwiRibbonGroup1.KeyTipGroup = "P";
            this.kiwiRibbonGroup1.TextLine1 = "Palettes";
            // 
            // kiwiRibbonGroupTriple1
            // 
            this.kiwiRibbonGroupTriple1.Items.AddRange(new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupItem[] {
            this.kiwiRibbonGroupButton1,
            this.kiwiRibbonGroupButton2,
            this.kiwiRibbonGroupButton3});
            this.kiwiRibbonGroupTriple1.MaximumSize = Kiwi.ComponentFactory.Ribbon.GroupItemSize.Medium;
            this.kiwiRibbonGroupTriple1.MinimumSize = Kiwi.ComponentFactory.Ribbon.GroupItemSize.Medium;
            // 
            // kiwiRibbonGroupButton1
            // 
            this.kiwiRibbonGroupButton1.ButtonType = Kiwi.ComponentFactory.Ribbon.GroupButtonType.Check;
            this.kiwiRibbonGroupButton1.Checked = true;
            this.kiwiRibbonGroupButton1.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroupButton1.ImageSmall")));
            this.kiwiRibbonGroupButton1.TextLine1 = "Office 2010";
            this.kiwiRibbonGroupButton1.TextLine2 = "Blue";
            this.kiwiRibbonGroupButton1.Click += new System.EventHandler(this.kiwiRibbonGroupButton1_Click);
            // 
            // kiwiRibbonGroupButton2
            // 
            this.kiwiRibbonGroupButton2.ButtonType = Kiwi.ComponentFactory.Ribbon.GroupButtonType.Check;
            this.kiwiRibbonGroupButton2.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroupButton2.ImageSmall")));
            this.kiwiRibbonGroupButton2.TextLine1 = "Office 2007";
            this.kiwiRibbonGroupButton2.TextLine2 = "Silver";
            this.kiwiRibbonGroupButton2.Click += new System.EventHandler(this.kiwiRibbonGroupButton2_Click);
            // 
            // kiwiRibbonGroupButton3
            // 
            this.kiwiRibbonGroupButton3.ButtonType = Kiwi.ComponentFactory.Ribbon.GroupButtonType.Check;
            this.kiwiRibbonGroupButton3.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroupButton3.ImageSmall")));
            this.kiwiRibbonGroupButton3.TextLine1 = "Sparkle Orange";
            this.kiwiRibbonGroupButton3.Click += new System.EventHandler(this.kiwiRibbonGroupButton3_Click);
            // 
            // kiwiRibbonGroup2
            // 
            this.kiwiRibbonGroup2.Image = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroup2.Image")));
            this.kiwiRibbonGroup2.Items.AddRange(new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupContainer[] {
            this.galleryNormal,
            this.galleryRanges,
            this.galleryCustom});
            this.kiwiRibbonGroup2.TextLine1 = "Galleries";
            // 
            // galleryNormal
            // 
            this.galleryNormal.DropButtonItemWidth = 6;
            this.galleryNormal.ImageLarge = ((System.Drawing.Image)(resources.GetObject("galleryNormal.ImageLarge")));
            this.galleryNormal.ImageList = this.imageList1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "flag_australia.png");
            this.imageList1.Images.SetKeyName(1, "flag_bahamas.png");
            this.imageList1.Images.SetKeyName(2, "flag_belgium.png");
            this.imageList1.Images.SetKeyName(3, "flag_brazil.png");
            this.imageList1.Images.SetKeyName(4, "flag_canada.png");
            this.imageList1.Images.SetKeyName(5, "flag_england.png");
            this.imageList1.Images.SetKeyName(6, "flag_germany.png");
            this.imageList1.Images.SetKeyName(7, "flag_jamaica.png");
            this.imageList1.Images.SetKeyName(8, "flag_norway.png");
            this.imageList1.Images.SetKeyName(9, "flag_scotland.png");
            this.imageList1.Images.SetKeyName(10, "flag_south_africa.png");
            this.imageList1.Images.SetKeyName(11, "flag_spain.png");
            this.imageList1.Images.SetKeyName(12, "flag_switzerland.png");
            this.imageList1.Images.SetKeyName(13, "flag_united_kingdom.png");
            this.imageList1.Images.SetKeyName(14, "flag_usa.png");
            this.imageList1.Images.SetKeyName(15, "flag_wales.png");
            // 
            // galleryRanges
            // 
            this.galleryRanges.DropButtonItemWidth = 6;
            this.galleryRanges.DropButtonRanges.AddRange(new Kiwi.ComponentFactory.Ribbon.KiwiGalleryRange[] {
            this.kiwiGalleryRange5,
            this.kiwiGalleryRange6,
            this.kiwiGalleryRange7});
            this.galleryRanges.ImageLarge = ((System.Drawing.Image)(resources.GetObject("galleryRanges.ImageLarge")));
            this.galleryRanges.ImageList = this.imageList1;
            this.galleryRanges.KeyTip = "Y";
            // 
            // kiwiGalleryRange5
            // 
            this.kiwiGalleryRange5.Heading = "Users";
            this.kiwiGalleryRange5.ImageIndexEnd = 5;
            this.kiwiGalleryRange5.ImageIndexStart = 0;
            // 
            // kiwiGalleryRange6
            // 
            this.kiwiGalleryRange6.Heading = "Managers";
            this.kiwiGalleryRange6.ImageIndexEnd = 11;
            this.kiwiGalleryRange6.ImageIndexStart = 6;
            // 
            // kiwiGalleryRange7
            // 
            this.kiwiGalleryRange7.Heading = "Others";
            this.kiwiGalleryRange7.ImageIndexEnd = 15;
            this.kiwiGalleryRange7.ImageIndexStart = 12;
            // 
            // galleryCustom
            // 
            this.galleryCustom.DropButtonItemWidth = 6;
            this.galleryCustom.ImageLarge = ((System.Drawing.Image)(resources.GetObject("galleryCustom.ImageLarge")));
            this.galleryCustom.ImageList = this.imageList1;
            this.galleryCustom.KeyTip = "Z";
            this.galleryCustom.GalleryDropMenu += new System.EventHandler<Kiwi.ComponentFactory.Ribbon.GalleryDropMenuEventArgs>(this.galleryCustom_GalleryDropMenu);
            // 
            // kiwiGalleryRange1
            // 
            this.kiwiGalleryRange1.Heading = "Group 1";
            this.kiwiGalleryRange1.ImageIndexEnd = 4;
            this.kiwiGalleryRange1.ImageIndexStart = 0;
            // 
            // kiwiGalleryRange2
            // 
            this.kiwiGalleryRange2.Heading = "Group 2";
            this.kiwiGalleryRange2.ImageIndexEnd = 9;
            this.kiwiGalleryRange2.ImageIndexStart = 5;
            // 
            // kiwiGalleryRange3
            // 
            this.kiwiGalleryRange3.Heading = "Group 3";
            this.kiwiGalleryRange3.ImageIndexEnd = 14;
            this.kiwiGalleryRange3.ImageIndexStart = 10;
            // 
            // kiwiGalleryRange4
            // 
            this.kiwiGalleryRange4.Heading = "Group 4";
            this.kiwiGalleryRange4.ImageIndexEnd = 20;
            this.kiwiGalleryRange4.ImageIndexStart = 15;
            // 
            // kiwiFillPanel
            // 
            this.kiwiFillPanel.Controls.Add(this.kiwiPanel1);
            this.kiwiFillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiwiFillPanel.Location = new System.Drawing.Point(0, 114);
            this.kiwiFillPanel.Name = "kiwiFillPanel";
            this.kiwiFillPanel.Size = new System.Drawing.Size(769, 174);
            this.kiwiFillPanel.TabIndex = 1;
            // 
            // kiwiPanel1
            // 
            this.kiwiPanel1.Controls.Add(this.kiwiLabelExplain);
            this.kiwiPanel1.Controls.Add(this.kiwiLabelTitle);
            this.kiwiPanel1.Location = new System.Drawing.Point(16, 16);
            this.kiwiPanel1.Name = "kiwiPanel1";
            this.kiwiPanel1.PanelBackStyle = Kiwi.ComponentFactory.Toolkit.PaletteBackStyle.PanelAlternate;
            this.kiwiPanel1.Size = new System.Drawing.Size(335, 101);
            this.kiwiPanel1.TabIndex = 0;
            // 
            // kiwiLabelExplain
            // 
            this.kiwiLabelExplain.LabelStyle = Kiwi.ComponentFactory.Toolkit.LabelStyle.NormalPanel;
            this.kiwiLabelExplain.Location = new System.Drawing.Point(8, 36);
            this.kiwiLabelExplain.Name = "kiwiLabelExplain";
            this.kiwiLabelExplain.Size = new System.Drawing.Size(312, 49);
            this.kiwiLabelExplain.TabIndex = 1;
            this.kiwiLabelExplain.Values.Text = "The Left gallery shows a standard drop down of all images.\r\nThe Middle gallery pr" +
                "ovides grouping in the drop down.\r\nThe Right gallery customizes the drop down me" +
                "nu.\r\n";
            // 
            // kiwiLabelTitle
            // 
            this.kiwiLabelTitle.LabelStyle = Kiwi.ComponentFactory.Toolkit.LabelStyle.TitlePanel;
            this.kiwiLabelTitle.Location = new System.Drawing.Point(8, 8);
            this.kiwiLabelTitle.Name = "kiwiLabelTitle";
            this.kiwiLabelTitle.Size = new System.Drawing.Size(84, 28);
            this.kiwiLabelTitle.TabIndex = 0;
            this.kiwiLabelTitle.Values.Text = "Galleries";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 288);
            this.Controls.Add(this.kiwiFillPanel);
            this.Controls.Add(this.kiwiRibbon);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(381, 322);
            this.Name = "Form1";
            this.Text = "Ribbon Gallery";
            ((System.ComponentModel.ISupportInitialize)(this.kiwiRibbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiFillPanel)).EndInit();
            this.kiwiFillPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPanel1)).EndInit();
            this.kiwiPanel1.ResumeLayout(false);
            this.kiwiPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Kiwi.ComponentFactory.Ribbon.KiwiRibbon kiwiRibbon;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonTab kiwiRibbonTab1;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroup kiwiRibbonGroup1;
        private Kiwi.ComponentFactory.Toolkit.KiwiPanel kiwiFillPanel;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupTriple kiwiRibbonGroupTriple1;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton kiwiRibbonGroupButton1;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton kiwiRibbonGroupButton2;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton kiwiRibbonGroupButton3;
        private System.Windows.Forms.ImageList imageList1;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroup kiwiRibbonGroup2;
        private Kiwi.ComponentFactory.Ribbon.KiwiGalleryRange kiwiGalleryRange1;
        private Kiwi.ComponentFactory.Ribbon.KiwiGalleryRange kiwiGalleryRange2;
        private Kiwi.ComponentFactory.Ribbon.KiwiGalleryRange kiwiGalleryRange3;
        private Kiwi.ComponentFactory.Ribbon.KiwiGalleryRange kiwiGalleryRange4;
        private Kiwi.ComponentFactory.Toolkit.KiwiManager kiwiManager1;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem kiwiContextMenuItem1;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupGallery galleryNormal;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupGallery galleryRanges;
        private Kiwi.ComponentFactory.Ribbon.KiwiGalleryRange kiwiGalleryRange5;
        private Kiwi.ComponentFactory.Ribbon.KiwiGalleryRange kiwiGalleryRange6;
        private Kiwi.ComponentFactory.Ribbon.KiwiGalleryRange kiwiGalleryRange7;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupGallery galleryCustom;
        private Kiwi.ComponentFactory.Toolkit.KiwiPanel kiwiPanel1;
        private Kiwi.ComponentFactory.Toolkit.KiwiLabel kiwiLabelExplain;
        private Kiwi.ComponentFactory.Toolkit.KiwiLabel kiwiLabelTitle;
    }
}

