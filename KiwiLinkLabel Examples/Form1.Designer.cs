
namespace KiwiLinkLabel_Examples
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kiwiLabel1 = new Kiwi.ComponentFactory.Toolkit.KiwiLinkLabel();
            this.label4Professional = new Kiwi.ComponentFactory.Toolkit.KiwiLinkLabel();
            this.label3Professional = new Kiwi.ComponentFactory.Toolkit.KiwiLinkLabel();
            this.label5Professional = new Kiwi.ComponentFactory.Toolkit.KiwiLinkLabel();
            this.label2Professional = new Kiwi.ComponentFactory.Toolkit.KiwiLinkLabel();
            this.label1Professional = new Kiwi.ComponentFactory.Toolkit.KiwiLinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3Custom = new Kiwi.ComponentFactory.Toolkit.KiwiLinkLabel();
            this.label2Custom = new Kiwi.ComponentFactory.Toolkit.KiwiLinkLabel();
            this.label1Custom = new Kiwi.ComponentFactory.Toolkit.KiwiLinkLabel();
            this.kiwiManager1 = new Kiwi.ComponentFactory.Toolkit.KiwiManager(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.propertyGrid);
            this.groupBox3.Location = new System.Drawing.Point(257, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 390);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Properties for Selected KiwiLinkLabel";
            // 
            // propertyGrid
            // 
            this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid.Location = new System.Drawing.Point(6, 19);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(310, 365);
            this.propertyGrid.TabIndex = 0;
            this.propertyGrid.ToolbarVisible = false;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(504, 408);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kiwiLabel1);
            this.groupBox1.Controls.Add(this.label4Professional);
            this.groupBox1.Controls.Add(this.label3Professional);
            this.groupBox1.Controls.Add(this.label5Professional);
            this.groupBox1.Controls.Add(this.label2Professional);
            this.groupBox1.Controls.Add(this.label1Professional);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Office 2007 - Blue";
            // 
            // kiwiLabel1
            // 
            this.kiwiLabel1.Location = new System.Drawing.Point(164, 42);
            this.kiwiLabel1.Name = "kiwiLabel1";
            this.kiwiLabel1.Orientation = Kiwi.ComponentFactory.Toolkit.VisualOrientation.Left;
            this.kiwiLabel1.Size = new System.Drawing.Size(20, 115);
            this.kiwiLabel1.TabIndex = 4;
            this.kiwiLabel1.Values.ExtraText = "Left";
            this.kiwiLabel1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kiwiLabel1.Values.Image")));
            this.kiwiLabel1.Values.Text = "Orientation";
            this.kiwiLabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kiwiLabel_MouseDown);
            // 
            // label4Professional
            // 
            this.label4Professional.Location = new System.Drawing.Point(14, 137);
            this.label4Professional.Name = "label4Professional";
            this.label4Professional.Orientation = Kiwi.ComponentFactory.Toolkit.VisualOrientation.Bottom;
            this.label4Professional.Size = new System.Drawing.Size(108, 20);
            this.label4Professional.TabIndex = 3;
            this.label4Professional.Values.ExtraText = "Extra Text";
            this.label4Professional.Values.Image = ((System.Drawing.Image)(resources.GetObject("label4Professional.Values.Image")));
            this.label4Professional.Values.Text = "Text";
            this.label4Professional.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kiwiLabel_MouseDown);
            // 
            // label3Professional
            // 
            this.label3Professional.Location = new System.Drawing.Point(14, 110);
            this.label3Professional.Name = "label3Professional";
            this.label3Professional.Size = new System.Drawing.Size(108, 20);
            this.label3Professional.TabIndex = 2;
            this.label3Professional.Values.ExtraText = "Extra Text";
            this.label3Professional.Values.Image = ((System.Drawing.Image)(resources.GetObject("label3Professional.Values.Image")));
            this.label3Professional.Values.Text = "Text";
            this.label3Professional.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kiwiLabel_MouseDown);
            // 
            // label5Professional
            // 
            this.label5Professional.Location = new System.Drawing.Point(191, 42);
            this.label5Professional.Name = "label5Professional";
            this.label5Professional.Orientation = Kiwi.ComponentFactory.Toolkit.VisualOrientation.Right;
            this.label5Professional.Size = new System.Drawing.Size(20, 123);
            this.label5Professional.TabIndex = 5;
            this.label5Professional.Values.ExtraText = "Right";
            this.label5Professional.Values.Image = ((System.Drawing.Image)(resources.GetObject("label5Professional.Values.Image")));
            this.label5Professional.Values.Text = "Orientation";
            this.label5Professional.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kiwiLabel_MouseDown);
            // 
            // label2Professional
            // 
            this.label2Professional.LabelStyle = Kiwi.ComponentFactory.Toolkit.LabelStyle.TitleControl;
            this.label2Professional.Location = new System.Drawing.Point(14, 32);
            this.label2Professional.Name = "label2Professional";
            this.label2Professional.Size = new System.Drawing.Size(117, 29);
            this.label2Professional.TabIndex = 1;
            this.label2Professional.Values.Text = "Style = Title";
            this.label2Professional.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kiwiLabel_MouseDown);
            // 
            // label1Professional
            // 
            this.label1Professional.Location = new System.Drawing.Point(14, 62);
            this.label1Professional.Name = "label1Professional";
            this.label1Professional.Size = new System.Drawing.Size(93, 20);
            this.label1Professional.TabIndex = 0;
            this.label1Professional.Values.Text = "Style = Normal";
            this.label1Professional.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kiwiLabel_MouseDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3Custom);
            this.groupBox2.Controls.Add(this.label2Custom);
            this.groupBox2.Controls.Add(this.label1Custom);
            this.groupBox2.Location = new System.Drawing.Point(12, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 191);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Custom";
            // 
            // label3Custom
            // 
            this.label3Custom.Location = new System.Drawing.Point(14, 125);
            this.label3Custom.Name = "label3Custom";
            this.label3Custom.OverrideNotVisited.ShortText.Color1 = System.Drawing.Color.White;
            this.label3Custom.OverrideNotVisited.ShortText.Color2 = System.Drawing.Color.Blue;
            this.label3Custom.OverrideNotVisited.ShortText.ImageStyle = Kiwi.ComponentFactory.Toolkit.PaletteImageStyle.Inherit;
            this.label3Custom.OverrideNotVisited.ShortText.Trim = Kiwi.ComponentFactory.Toolkit.PaletteTextTrim.Inherit;
            this.label3Custom.OverridePressed.ShortText.Color1 = System.Drawing.Color.White;
            this.label3Custom.OverridePressed.ShortText.Color2 = System.Drawing.Color.Red;
            this.label3Custom.OverridePressed.ShortText.ImageStyle = Kiwi.ComponentFactory.Toolkit.PaletteImageStyle.Inherit;
            this.label3Custom.OverridePressed.ShortText.Trim = Kiwi.ComponentFactory.Toolkit.PaletteTextTrim.Inherit;
            this.label3Custom.OverrideVisited.ShortText.Color1 = System.Drawing.Color.White;
            this.label3Custom.OverrideVisited.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3Custom.OverrideVisited.ShortText.ImageStyle = Kiwi.ComponentFactory.Toolkit.PaletteImageStyle.Inherit;
            this.label3Custom.OverrideVisited.ShortText.Trim = Kiwi.ComponentFactory.Toolkit.PaletteTextTrim.Inherit;
            this.label3Custom.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalSystem;
            this.label3Custom.Size = new System.Drawing.Size(168, 53);
            this.label3Custom.StateNormal.Image.Effect = Kiwi.ComponentFactory.Toolkit.PaletteImageEffect.Inherit;
            this.label3Custom.StateNormal.Image.ImageH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Far;
            this.label3Custom.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3Custom.StateNormal.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3Custom.StateNormal.LongText.ColorAngle = 45F;
            this.label3Custom.StateNormal.LongText.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Sigma;
            this.label3Custom.StateNormal.LongText.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3Custom.StateNormal.LongText.ImageStyle = Kiwi.ComponentFactory.Toolkit.PaletteImageStyle.Inherit;
            this.label3Custom.StateNormal.LongText.MultiLine = Kiwi.ComponentFactory.Toolkit.InheritBool.True;
            this.label3Custom.StateNormal.LongText.TextH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Center;
            this.label3Custom.StateNormal.LongText.Trim = Kiwi.ComponentFactory.Toolkit.PaletteTextTrim.Inherit;
            this.label3Custom.StateNormal.ShortText.ColorAngle = 45F;
            this.label3Custom.StateNormal.ShortText.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Linear;
            this.label3Custom.StateNormal.ShortText.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3Custom.StateNormal.ShortText.ImageStyle = Kiwi.ComponentFactory.Toolkit.PaletteImageStyle.Inherit;
            this.label3Custom.StateNormal.ShortText.TextH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Near;
            this.label3Custom.StateNormal.ShortText.Trim = Kiwi.ComponentFactory.Toolkit.PaletteTextTrim.Inherit;
            this.label3Custom.TabIndex = 2;
            this.label3Custom.Values.ExtraText = "Extra Text\r\nOver Multi\r\nLines";
            this.label3Custom.Values.Image = global::KiwiLinkLabel_Examples.Properties.Resources.sidebar_icon;
            this.label3Custom.Values.Text = "Multi\r\nText";
            this.label3Custom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kiwiLabel_MouseDown);
            // 
            // label2Custom
            // 
            this.label2Custom.Location = new System.Drawing.Point(14, 76);
            this.label2Custom.Name = "label2Custom";
            this.label2Custom.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalSystem;
            this.label2Custom.Size = new System.Drawing.Size(178, 33);
            this.label2Custom.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2Custom.StateNormal.LongText.Color2 = System.Drawing.Color.White;
            this.label2Custom.StateNormal.LongText.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.HalfCut;
            this.label2Custom.StateNormal.LongText.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Custom.StateNormal.LongText.ImageStyle = Kiwi.ComponentFactory.Toolkit.PaletteImageStyle.Inherit;
            this.label2Custom.StateNormal.LongText.Trim = Kiwi.ComponentFactory.Toolkit.PaletteTextTrim.Inherit;
            this.label2Custom.StateNormal.ShortText.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Custom.StateNormal.ShortText.ImageStyle = Kiwi.ComponentFactory.Toolkit.PaletteImageStyle.Inherit;
            this.label2Custom.StateNormal.ShortText.Trim = Kiwi.ComponentFactory.Toolkit.PaletteTextTrim.Inherit;
            this.label2Custom.TabIndex = 1;
            this.label2Custom.Values.Image = ((System.Drawing.Image)(resources.GetObject("label2Custom.Values.Image")));
            this.label2Custom.Values.Text = "Image Text";
            this.label2Custom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kiwiLabel_MouseDown);
            // 
            // label1Custom
            // 
            this.label1Custom.Location = new System.Drawing.Point(14, 27);
            this.label1Custom.Name = "label1Custom";
            this.label1Custom.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalSystem;
            this.label1Custom.Size = new System.Drawing.Size(157, 38);
            this.label1Custom.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1Custom.StateNormal.LongText.Color2 = System.Drawing.Color.White;
            this.label1Custom.StateNormal.LongText.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.HalfCut;
            this.label1Custom.StateNormal.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Custom.StateNormal.LongText.ImageStyle = Kiwi.ComponentFactory.Toolkit.PaletteImageStyle.Inherit;
            this.label1Custom.StateNormal.LongText.Trim = Kiwi.ComponentFactory.Toolkit.PaletteTextTrim.Inherit;
            this.label1Custom.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1Custom.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1Custom.StateNormal.ShortText.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Rounded;
            this.label1Custom.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Custom.StateNormal.ShortText.ImageStyle = Kiwi.ComponentFactory.Toolkit.PaletteImageStyle.Inherit;
            this.label1Custom.StateNormal.ShortText.Trim = Kiwi.ComponentFactory.Toolkit.PaletteTextTrim.Inherit;
            this.label1Custom.TabIndex = 0;
            this.label1Custom.Values.ExtraText = "Extra Text";
            this.label1Custom.Values.Image = ((System.Drawing.Image)(resources.GetObject("label1Custom.Values.Image")));
            this.label1Custom.Values.Text = "Text";
            this.label1Custom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kiwiLabel_MouseDown);
            // 
            // kiwiManager1
            // 
            this.kiwiManager1.GlobalPaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteModeManager.Office2007Blue;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 439);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "KiwiLinkLabel Examples";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private Kiwi.ComponentFactory.Toolkit.KiwiLinkLabel label1Professional;
        private Kiwi.ComponentFactory.Toolkit.KiwiLinkLabel label2Professional;
        private Kiwi.ComponentFactory.Toolkit.KiwiLinkLabel label3Professional;
        private Kiwi.ComponentFactory.Toolkit.KiwiLinkLabel label4Professional;
        private Kiwi.ComponentFactory.Toolkit.KiwiLinkLabel label5Professional;
        private Kiwi.ComponentFactory.Toolkit.KiwiLinkLabel label1Custom;
        private Kiwi.ComponentFactory.Toolkit.KiwiLinkLabel label2Custom;
        private Kiwi.ComponentFactory.Toolkit.KiwiLinkLabel label3Custom;
        private Kiwi.ComponentFactory.Toolkit.KiwiLinkLabel kiwiLabel1;
        private Kiwi.ComponentFactory.Toolkit.KiwiManager kiwiManager1;

    }
}

