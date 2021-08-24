
namespace KiwiPanel_Examples
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.panel1Office = new Kiwi.ComponentFactory.Toolkit.KiwiPanel();
            this.panel2Office = new Kiwi.ComponentFactory.Toolkit.KiwiPanel();
            this.panel3Office = new Kiwi.ComponentFactory.Toolkit.KiwiPanel();
            this.panel4Office = new Kiwi.ComponentFactory.Toolkit.KiwiPanel();
            this.panel1Blue = new Kiwi.ComponentFactory.Toolkit.KiwiPanel();
            this.panel2Blue = new Kiwi.ComponentFactory.Toolkit.KiwiPanel();
            this.panel3Blue = new Kiwi.ComponentFactory.Toolkit.KiwiPanel();
            this.panel4Blue = new Kiwi.ComponentFactory.Toolkit.KiwiPanel();
            this.panel1Custom = new Kiwi.ComponentFactory.Toolkit.KiwiPanel();
            this.panel2Custom = new Kiwi.ComponentFactory.Toolkit.KiwiPanel();
            this.panel3Custom = new Kiwi.ComponentFactory.Toolkit.KiwiPanel();
            this.panel4Custom = new Kiwi.ComponentFactory.Toolkit.KiwiPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel1Office)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel2Office)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel3Office)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel4Office)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel2Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel3Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel4Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1Custom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel2Custom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel3Custom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel4Custom)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel4Office);
            this.groupBox1.Controls.Add(this.panel3Office);
            this.groupBox1.Controls.Add(this.panel2Office);
            this.groupBox1.Controls.Add(this.panel1Office);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Professional - Office 2003";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel4Blue);
            this.groupBox2.Controls.Add(this.panel1Blue);
            this.groupBox2.Controls.Add(this.panel3Blue);
            this.groupBox2.Controls.Add(this.panel2Blue);
            this.groupBox2.Location = new System.Drawing.Point(12, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 151);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Office 2007 - Blue";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel4Custom);
            this.groupBox3.Controls.Add(this.panel3Custom);
            this.groupBox3.Controls.Add(this.panel2Custom);
            this.groupBox3.Controls.Add(this.panel1Custom);
            this.groupBox3.Location = new System.Drawing.Point(13, 327);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 234);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Custom Settings";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.propertyGrid);
            this.groupBox4.Location = new System.Drawing.Point(309, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(280, 548);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Properties for Selected KiwiPanel";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(514, 567);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // propertyGrid
            // 
            this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid.Location = new System.Drawing.Point(6, 20);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(268, 522);
            this.propertyGrid.TabIndex = 0;
            this.propertyGrid.ToolbarVisible = false;
            // 
            // panel1Office
            // 
            this.panel1Office.Location = new System.Drawing.Point(31, 26);
            this.panel1Office.Name = "panel1Office";
            this.panel1Office.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.panel1Office.Size = new System.Drawing.Size(96, 51);
            this.panel1Office.TabIndex = 0;
            this.panel1Office.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kiwiPanel_MouseDown);
            // 
            // panel2Office
            // 
            this.panel2Office.Location = new System.Drawing.Point(146, 26);
            this.panel2Office.Name = "panel2Office";
            this.panel2Office.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.panel2Office.Size = new System.Drawing.Size(96, 51);
            this.panel2Office.TabIndex = 0;
            this.panel2Office.PanelBackStyle = Kiwi.ComponentFactory.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.panel2Office.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kiwiPanel_MouseDown);
            // 
            // panel3Office
            // 
            this.panel3Office.Location = new System.Drawing.Point(32, 83);
            this.panel3Office.Name = "panel3Office";
            this.panel3Office.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.panel3Office.Size = new System.Drawing.Size(96, 51);
            this.panel3Office.TabIndex = 0;
            this.panel3Office.PanelBackStyle = Kiwi.ComponentFactory.Toolkit.PaletteBackStyle.HeaderSecondary;
            this.panel3Office.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kiwiPanel_MouseDown);
            // 
            // panel4Office
            // 
            this.panel4Office.Location = new System.Drawing.Point(146, 83);
            this.panel4Office.Name = "panel4Office";
            this.panel4Office.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.panel4Office.Size = new System.Drawing.Size(96, 51);
            this.panel4Office.TabIndex = 0;
            this.panel4Office.PanelBackStyle = Kiwi.ComponentFactory.Toolkit.PaletteBackStyle.ControlClient;
            this.panel4Office.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kiwiPanel_MouseDown);

            // 
            // panel1Blue
            // 
            this.panel1Blue.Location = new System.Drawing.Point(33, 24);
            this.panel1Blue.Name = "panel1Blue";
            this.panel1Blue.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2007Blue;
            this.panel1Blue.Size = new System.Drawing.Size(96, 51);
            this.panel1Blue.TabIndex = 0;
            this.panel1Blue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kiwiPanel_MouseDown);
            // 
            // panel2Blue
            // 
            this.panel2Blue.Location = new System.Drawing.Point(146, 23);
            this.panel2Blue.Name = "panel2Blue";
            this.panel2Blue.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2007Blue;
            this.panel2Blue.Size = new System.Drawing.Size(96, 51);
            this.panel2Blue.TabIndex = 0;
            this.panel2Blue.PanelBackStyle = Kiwi.ComponentFactory.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.panel2Blue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kiwiPanel_MouseDown);
            // 
            // panel3Blue
            // 
            this.panel3Blue.Location = new System.Drawing.Point(32, 80);
            this.panel3Blue.Name = "panel3Blue";
            this.panel3Blue.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2007Blue;
            this.panel3Blue.Size = new System.Drawing.Size(96, 51);
            this.panel3Blue.TabIndex = 0;
            this.panel3Blue.PanelBackStyle = Kiwi.ComponentFactory.Toolkit.PaletteBackStyle.HeaderSecondary;
            this.panel3Blue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kiwiPanel_MouseDown);
            // 
            // panel4Blue
            // 
            this.panel4Blue.Location = new System.Drawing.Point(146, 80);
            this.panel4Blue.Name = "panel4Blue";
            this.panel4Blue.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2007Blue;
            this.panel4Blue.Size = new System.Drawing.Size(96, 51);
            this.panel4Blue.TabIndex = 0;
            this.panel4Blue.PanelBackStyle = Kiwi.ComponentFactory.Toolkit.PaletteBackStyle.ControlClient;
            this.panel4Blue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kiwiPanel_MouseDown);
            // 
            // panel1Custom
            // 
            this.panel1Custom.Location = new System.Drawing.Point(31, 31);
            this.panel1Custom.Name = "panel1Custom";
            this.panel1Custom.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2007Blue;
            this.panel1Custom.Size = new System.Drawing.Size(96, 93);
            this.panel1Custom.TabIndex = 0;
            this.panel1Custom.StateNormal.Color1 = System.Drawing.Color.White;
            this.panel1Custom.StateNormal.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1Custom.StateNormal.ColorAngle = 60F;
            this.panel1Custom.StateNormal.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Rounded;
            this.panel1Custom.StateNormal.ImageStyle = Kiwi.ComponentFactory.Toolkit.PaletteImageStyle.Inherit;
            this.panel1Custom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kiwiPanel_MouseDown);
            // 
            // panel2Custom
            // 
            this.panel2Custom.Location = new System.Drawing.Point(145, 31);
            this.panel2Custom.Name = "panel2Custom";
            this.panel2Custom.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2007Blue;
            this.panel2Custom.Size = new System.Drawing.Size(96, 93);
            this.panel2Custom.TabIndex = 0;
            this.panel2Custom.StateNormal.Color1 = System.Drawing.Color.White;
            this.panel2Custom.StateNormal.Color2 = System.Drawing.Color.Maroon;
            this.panel2Custom.StateNormal.ColorAngle = 10F;
            this.panel2Custom.StateNormal.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Sigma;
            this.panel2Custom.StateNormal.ImageStyle = Kiwi.ComponentFactory.Toolkit.PaletteImageStyle.Inherit;
            this.panel2Custom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kiwiPanel_MouseDown);
            // 
            // panel3Custom
            // 
            this.panel3Custom.Location = new System.Drawing.Point(32, 130);
            this.panel3Custom.Name = "panel3Custom";
            this.panel3Custom.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2007Blue;
            this.panel3Custom.Size = new System.Drawing.Size(96, 93);
            this.panel3Custom.TabIndex = 0;
            this.panel3Custom.StateNormal.Color1 = System.Drawing.Color.White;
            this.panel3Custom.StateNormal.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3Custom.StateNormal.ColorAngle = 45F;
            this.panel3Custom.StateNormal.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Linear;
            this.panel3Custom.StateNormal.Image = ((System.Drawing.Image)(resources.GetObject("panel3Custom.StateNormal.Image")));
            this.panel3Custom.StateNormal.ImageStyle = Kiwi.ComponentFactory.Toolkit.PaletteImageStyle.CenterMiddle;
            this.panel3Custom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kiwiPanel_MouseDown);
            // 
            // panel4Custom
            // 
            this.panel4Custom.Location = new System.Drawing.Point(145, 130);
            this.panel4Custom.Name = "panel4Custom";
            this.panel4Custom.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2007Blue;
            this.panel4Custom.Size = new System.Drawing.Size(96, 93);
            this.panel4Custom.TabIndex = 0;
            this.panel4Custom.StateNormal.Color1 = System.Drawing.Color.White;
            this.panel4Custom.StateNormal.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel4Custom.StateNormal.ColorAngle = 45F;
            this.panel4Custom.StateNormal.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Sigma;
            this.panel4Custom.StateNormal.Image = ((System.Drawing.Image)(resources.GetObject("panel4Custom.StateNormal.Image")));
            this.panel4Custom.StateNormal.ImageAlign = Kiwi.ComponentFactory.Toolkit.PaletteRectangleAlign.Local;
            this.panel4Custom.StateNormal.ImageStyle = Kiwi.ComponentFactory.Toolkit.PaletteImageStyle.Inherit;
            this.panel4Custom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kiwiPanel_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 600);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "KiwiPanel Examples";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel1Office)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel2Office)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel3Office)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel4Office)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel2Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel3Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel4Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1Custom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel2Custom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel3Custom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel4Custom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.Button buttonClose;
        private Kiwi.ComponentFactory.Toolkit.KiwiPanel panel4Office;
        private Kiwi.ComponentFactory.Toolkit.KiwiPanel panel3Office;
        private Kiwi.ComponentFactory.Toolkit.KiwiPanel panel2Office;
        private Kiwi.ComponentFactory.Toolkit.KiwiPanel panel1Office;
        private Kiwi.ComponentFactory.Toolkit.KiwiPanel panel4Blue;
        private Kiwi.ComponentFactory.Toolkit.KiwiPanel panel1Blue;
        private Kiwi.ComponentFactory.Toolkit.KiwiPanel panel3Blue;
        private Kiwi.ComponentFactory.Toolkit.KiwiPanel panel2Blue;
        private Kiwi.ComponentFactory.Toolkit.KiwiPanel panel4Custom;
        private Kiwi.ComponentFactory.Toolkit.KiwiPanel panel3Custom;
        private Kiwi.ComponentFactory.Toolkit.KiwiPanel panel2Custom;
        private Kiwi.ComponentFactory.Toolkit.KiwiPanel panel1Custom;
    }
}

