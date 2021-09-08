
namespace Navigator_ToolTips
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
            this.groupBoxTooltipProperties = new System.Windows.Forms.GroupBox();
            this.checkAllowButtonSpecTooltips = new System.Windows.Forms.CheckBox();
            this.checkAllowPageTooltips = new System.Windows.Forms.CheckBox();
            this.comboMapImage = new System.Windows.Forms.ComboBox();
            this.comboMapExtraText = new System.Windows.Forms.ComboBox();
            this.comboMapText = new System.Windows.Forms.ComboBox();
            this.labelMapImage = new System.Windows.Forms.Label();
            this.labelMapExtraText = new System.Windows.Forms.Label();
            this.labelMapText = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.kiwiNavigator = new Kiwi.ComponentFactory.Navigator.KiwiNavigator();
            this.kiwiPage1 = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.kiwiPage2 = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.kiwiPage3 = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.kiwiPage4 = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.buttonClose = new System.Windows.Forms.Button();
            this.kiwiManager1 = new Kiwi.ComponentFactory.Toolkit.KiwiManager(this.components);
            this.groupBoxTooltipProperties.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiNavigator)).BeginInit();
            this.kiwiNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTooltipProperties
            // 
            this.groupBoxTooltipProperties.Controls.Add(this.checkAllowButtonSpecTooltips);
            this.groupBoxTooltipProperties.Controls.Add(this.checkAllowPageTooltips);
            this.groupBoxTooltipProperties.Controls.Add(this.comboMapImage);
            this.groupBoxTooltipProperties.Controls.Add(this.comboMapExtraText);
            this.groupBoxTooltipProperties.Controls.Add(this.comboMapText);
            this.groupBoxTooltipProperties.Controls.Add(this.labelMapImage);
            this.groupBoxTooltipProperties.Controls.Add(this.labelMapExtraText);
            this.groupBoxTooltipProperties.Controls.Add(this.labelMapText);
            this.groupBoxTooltipProperties.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTooltipProperties.Name = "groupBoxTooltipProperties";
            this.groupBoxTooltipProperties.Size = new System.Drawing.Size(323, 176);
            this.groupBoxTooltipProperties.TabIndex = 1;
            this.groupBoxTooltipProperties.TabStop = false;
            this.groupBoxTooltipProperties.Text = "ToolTip Properties";
            // 
            // checkAllowButtonSpecTooltips
            // 
            this.checkAllowButtonSpecTooltips.AutoSize = true;
            this.checkAllowButtonSpecTooltips.Location = new System.Drawing.Point(102, 49);
            this.checkAllowButtonSpecTooltips.Name = "checkAllowButtonSpecTooltips";
            this.checkAllowButtonSpecTooltips.Size = new System.Drawing.Size(154, 17);
            this.checkAllowButtonSpecTooltips.TabIndex = 1;
            this.checkAllowButtonSpecTooltips.Text = "Allow ButtonSpec ToolTips";
            this.checkAllowButtonSpecTooltips.UseVisualStyleBackColor = true;
            this.checkAllowButtonSpecTooltips.CheckedChanged += new System.EventHandler(this.checkAllowButtonSpecTooltips_CheckedChanged);
            // 
            // checkAllowPageTooltips
            // 
            this.checkAllowPageTooltips.AutoSize = true;
            this.checkAllowPageTooltips.Location = new System.Drawing.Point(102, 25);
            this.checkAllowPageTooltips.Name = "checkAllowPageTooltips";
            this.checkAllowPageTooltips.Size = new System.Drawing.Size(123, 17);
            this.checkAllowPageTooltips.TabIndex = 0;
            this.checkAllowPageTooltips.Text = "Allow Page ToolTips";
            this.checkAllowPageTooltips.UseVisualStyleBackColor = true;
            this.checkAllowPageTooltips.CheckedChanged += new System.EventHandler(this.checkAllowPageTooltips_CheckedChanged);
            // 
            // comboMapImage
            // 
            this.comboMapImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMapImage.FormattingEnabled = true;
            this.comboMapImage.Location = new System.Drawing.Point(102, 140);
            this.comboMapImage.Name = "comboMapImage";
            this.comboMapImage.Size = new System.Drawing.Size(198, 21);
            this.comboMapImage.TabIndex = 4;
            this.comboMapImage.SelectedIndexChanged += new System.EventHandler(this.comboMapImage_SelectedIndexChanged);
            // 
            // comboMapExtraText
            // 
            this.comboMapExtraText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMapExtraText.FormattingEnabled = true;
            this.comboMapExtraText.Location = new System.Drawing.Point(102, 113);
            this.comboMapExtraText.Name = "comboMapExtraText";
            this.comboMapExtraText.Size = new System.Drawing.Size(198, 21);
            this.comboMapExtraText.TabIndex = 3;
            this.comboMapExtraText.SelectedIndexChanged += new System.EventHandler(this.comboMapExtraText_SelectedIndexChanged);
            // 
            // comboMapText
            // 
            this.comboMapText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMapText.FormattingEnabled = true;
            this.comboMapText.Location = new System.Drawing.Point(102, 86);
            this.comboMapText.Name = "comboMapText";
            this.comboMapText.Size = new System.Drawing.Size(198, 21);
            this.comboMapText.TabIndex = 2;
            this.comboMapText.SelectedIndexChanged += new System.EventHandler(this.comboMapText_SelectedIndexChanged);
            // 
            // labelMapImage
            // 
            this.labelMapImage.AutoSize = true;
            this.labelMapImage.Location = new System.Drawing.Point(35, 143);
            this.labelMapImage.Name = "labelMapImage";
            this.labelMapImage.Size = new System.Drawing.Size(60, 13);
            this.labelMapImage.TabIndex = 8;
            this.labelMapImage.Text = "Map Image";
            // 
            // labelMapExtraText
            // 
            this.labelMapExtraText.AutoSize = true;
            this.labelMapExtraText.Location = new System.Drawing.Point(16, 116);
            this.labelMapExtraText.Name = "labelMapExtraText";
            this.labelMapExtraText.Size = new System.Drawing.Size(79, 13);
            this.labelMapExtraText.TabIndex = 7;
            this.labelMapExtraText.Text = "Map Extra Text";
            // 
            // labelMapText
            // 
            this.labelMapText.AutoSize = true;
            this.labelMapText.Location = new System.Drawing.Point(43, 89);
            this.labelMapText.Name = "labelMapText";
            this.labelMapText.Size = new System.Drawing.Size(52, 13);
            this.labelMapText.TabIndex = 6;
            this.labelMapText.Text = "Map Text";
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Controls.Add(this.kiwiNavigator);
            this.panel.Location = new System.Drawing.Point(351, 18);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(313, 171);
            this.panel.TabIndex = 1;
            // 
            // kiwiNavigator
            // 
            this.kiwiNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiwiNavigator.Location = new System.Drawing.Point(0, 0);
            this.kiwiNavigator.Name = "kiwiNavigator";
            this.kiwiNavigator.Pages.AddRange(new Kiwi.ComponentFactory.Navigator.KiwiPage[] {
            this.kiwiPage1,
            this.kiwiPage2,
            this.kiwiPage3,
            this.kiwiPage4});
            this.kiwiNavigator.SelectedIndex = 0;
            this.kiwiNavigator.Size = new System.Drawing.Size(313, 171);
            this.kiwiNavigator.TabIndex = 0;
            this.kiwiNavigator.Text = "kiwiNavigator1";
            this.kiwiNavigator.ToolTips.AllowButtonSpecToolTips = true;
            this.kiwiNavigator.ToolTips.AllowPageToolTips = true;
            // 
            // kiwiPage1
            // 
            this.kiwiPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kiwiPage1.Flags = 65534;
            this.kiwiPage1.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kiwiPage1.ImageLarge")));
            this.kiwiPage1.ImageMedium = ((System.Drawing.Image)(resources.GetObject("kiwiPage1.ImageMedium")));
            this.kiwiPage1.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiPage1.ImageSmall")));
            this.kiwiPage1.LastVisibleSet = true;
            this.kiwiPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kiwiPage1.Name = "kiwiPage1";
            this.kiwiPage1.Size = new System.Drawing.Size(311, 145);
            this.kiwiPage1.Text = "Page 1";
            this.kiwiPage1.TextDescription = "Description of page 1";
            this.kiwiPage1.TextTitle = "Page Title 1";
            this.kiwiPage1.ToolTipBody = "This is a long description of \r\npage 1 which covers several\r\nlines of text.";
            this.kiwiPage1.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("kiwiPage1.ToolTipImage")));
            this.kiwiPage1.ToolTipStyle = Kiwi.ComponentFactory.Toolkit.LabelStyle.SuperTip;
            this.kiwiPage1.ToolTipTitle = "Page 1 SuperTip";
            this.kiwiPage1.UniqueName = "A2A9C435C1E1424FA2A9C435C1E1424F";
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
            this.kiwiPage2.Size = new System.Drawing.Size(304, 145);
            this.kiwiPage2.Text = "Page 2";
            this.kiwiPage2.TextDescription = "A description of page 2";
            this.kiwiPage2.TextTitle = "Page Title 2";
            this.kiwiPage2.ToolTipBody = "Information about the second page\r\nalso covers more than a single line\r\nof text.";
            this.kiwiPage2.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("kiwiPage2.ToolTipImage")));
            this.kiwiPage2.ToolTipStyle = Kiwi.ComponentFactory.Toolkit.LabelStyle.SuperTip;
            this.kiwiPage2.ToolTipTitle = "Page 2 SuperTip";
            this.kiwiPage2.UniqueName = "9A45A535BEE6487F9A45A535BEE6487F";
            // 
            // kiwiPage3
            // 
            this.kiwiPage3.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kiwiPage3.Flags = 65534;
            this.kiwiPage3.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kiwiPage3.ImageLarge")));
            this.kiwiPage3.ImageMedium = ((System.Drawing.Image)(resources.GetObject("kiwiPage3.ImageMedium")));
            this.kiwiPage3.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiPage3.ImageSmall")));
            this.kiwiPage3.LastVisibleSet = true;
            this.kiwiPage3.MinimumSize = new System.Drawing.Size(50, 50);
            this.kiwiPage3.Name = "kiwiPage3";
            this.kiwiPage3.Size = new System.Drawing.Size(304, 145);
            this.kiwiPage3.Text = "Page 3";
            this.kiwiPage3.TextDescription = "The description of page 3";
            this.kiwiPage3.TextTitle = "Page Title 3";
            this.kiwiPage3.ToolTipTitle = "Detailed information of page 3 in a tooltip";
            this.kiwiPage3.UniqueName = "46E548699395412546E5486993954125";
            // 
            // kiwiPage4
            // 
            this.kiwiPage4.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kiwiPage4.Flags = 65534;
            this.kiwiPage4.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kiwiPage4.ImageLarge")));
            this.kiwiPage4.ImageMedium = ((System.Drawing.Image)(resources.GetObject("kiwiPage4.ImageMedium")));
            this.kiwiPage4.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiPage4.ImageSmall")));
            this.kiwiPage4.LastVisibleSet = true;
            this.kiwiPage4.MinimumSize = new System.Drawing.Size(50, 50);
            this.kiwiPage4.Name = "kiwiPage4";
            this.kiwiPage4.Size = new System.Drawing.Size(311, 145);
            this.kiwiPage4.Text = "Page 4";
            this.kiwiPage4.TextDescription = "Brief description of page 4";
            this.kiwiPage4.TextTitle = "Page Title 4";
            this.kiwiPage4.ToolTipTitle = "Explanation of what page 4 is all about";
            this.kiwiPage4.UniqueName = "483D78EBE8814B82483D78EBE8814B82";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(588, 199);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 234);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.groupBoxTooltipProperties);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(643, 260);
            this.Name = "Form1";
            this.Text = "Navigator ToolTips";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTooltipProperties.ResumeLayout(false);
            this.groupBoxTooltipProperties.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiNavigator)).EndInit();
            this.kiwiNavigator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private Kiwi.ComponentFactory.Navigator.KiwiNavigator kiwiNavigator;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPage1;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPage2;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPage3;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPage4;
        private System.Windows.Forms.GroupBox groupBoxTooltipProperties;
        private System.Windows.Forms.Label labelMapText;
        private System.Windows.Forms.Label labelMapExtraText;
        private System.Windows.Forms.Label labelMapImage;
        private System.Windows.Forms.ComboBox comboMapImage;
        private System.Windows.Forms.ComboBox comboMapExtraText;
        private System.Windows.Forms.ComboBox comboMapText;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.CheckBox checkAllowButtonSpecTooltips;
        private System.Windows.Forms.CheckBox checkAllowPageTooltips;
        private Kiwi.ComponentFactory.Toolkit.KiwiManager kiwiManager1;
    }
}

