
namespace KiwiComboBox_Examples
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kiwiComboBox3Blue = new Kiwi.ComponentFactory.Toolkit.KiwiComboBox();
            this.kiwiComboBox2Blue = new Kiwi.ComponentFactory.Toolkit.KiwiComboBox();
            this.buttonSpecAny1 = new Kiwi.ComponentFactory.Toolkit.ButtonSpecAny();
            this.kiwiComboBox1Blue = new Kiwi.ComponentFactory.Toolkit.KiwiComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kiwiComboBox6System = new Kiwi.ComponentFactory.Toolkit.KiwiComboBox();
            this.kiwiComboBox5System = new Kiwi.ComponentFactory.Toolkit.KiwiComboBox();
            this.buttonSpecAny2 = new Kiwi.ComponentFactory.Toolkit.ButtonSpecAny();
            this.kiwiComboBox4System = new Kiwi.ComponentFactory.Toolkit.KiwiComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.kiwiComboBox8Custom = new Kiwi.ComponentFactory.Toolkit.KiwiComboBox();
            this.buttonSpecAny3 = new Kiwi.ComponentFactory.Toolkit.ButtonSpecAny();
            this.buttonSpecAny4 = new Kiwi.ComponentFactory.Toolkit.ButtonSpecAny();
            this.kiwiComboBox7Custom = new Kiwi.ComponentFactory.Toolkit.KiwiComboBox();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiComboBox3Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiComboBox2Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiComboBox1Blue)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiComboBox6System)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiComboBox5System)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiComboBox4System)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiComboBox8Custom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiComboBox7Custom)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(466, 408);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.propertyGrid);
            this.groupBox4.Location = new System.Drawing.Point(219, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(322, 390);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Properties for Selected KiwiComboBox";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kiwiComboBox3Blue);
            this.groupBox2.Controls.Add(this.kiwiComboBox2Blue);
            this.groupBox2.Controls.Add(this.kiwiComboBox1Blue);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 126);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Office 2010 - Blue";
            // 
            // kiwiComboBox3Blue
            // 
            this.kiwiComboBox3Blue.AlwaysActive = false;
            this.kiwiComboBox3Blue.DropDownWidth = 121;
            this.kiwiComboBox3Blue.InputControlStyle = Kiwi.ComponentFactory.Toolkit.InputControlStyle.Ribbon;
            this.kiwiComboBox3Blue.Items.AddRange(new object[] {
            "one",
            "two",
            "three",
            "four",
            "five",
            "six"});
            this.kiwiComboBox3Blue.Location = new System.Drawing.Point(16, 84);
            this.kiwiComboBox3Blue.Name = "kiwiComboBox3Blue";
            this.kiwiComboBox3Blue.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2010Blue;
            this.kiwiComboBox3Blue.Size = new System.Drawing.Size(169, 21);
            this.kiwiComboBox3Blue.TabIndex = 2;
            this.kiwiComboBox3Blue.Text = "ribbon style";
            this.kiwiComboBox3Blue.Enter += new System.EventHandler(this.kiwiComboBox1Blue_Enter);
            // 
            // kiwiComboBox2Blue
            // 
            this.kiwiComboBox2Blue.ButtonSpecs.AddRange(new Kiwi.ComponentFactory.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.kiwiComboBox2Blue.DropDownWidth = 121;
            this.kiwiComboBox2Blue.Items.AddRange(new object[] {
            "one",
            "two",
            "three",
            "four",
            "five",
            "six"});
            this.kiwiComboBox2Blue.Location = new System.Drawing.Point(16, 57);
            this.kiwiComboBox2Blue.Name = "kiwiComboBox2Blue";
            this.kiwiComboBox2Blue.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2010Blue;
            this.kiwiComboBox2Blue.Size = new System.Drawing.Size(169, 21);
            this.kiwiComboBox2Blue.TabIndex = 1;
            this.kiwiComboBox2Blue.Text = "clear with button";
            this.kiwiComboBox2Blue.Enter += new System.EventHandler(this.kiwiComboBox1Blue_Enter);
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Edge = Kiwi.ComponentFactory.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.buttonSpecAny1.Style = Kiwi.ComponentFactory.Toolkit.PaletteButtonStyle.LowProfile;
            this.buttonSpecAny1.Type = Kiwi.ComponentFactory.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "37524C52AC4E48FE37524C52AC4E48FE";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // kiwiComboBox1Blue
            // 
            this.kiwiComboBox1Blue.DropDownWidth = 169;
            this.kiwiComboBox1Blue.Items.AddRange(new object[] {
            "one",
            "two",
            "three",
            "four",
            "five",
            "six"});
            this.kiwiComboBox1Blue.Location = new System.Drawing.Point(16, 30);
            this.kiwiComboBox1Blue.Name = "kiwiComboBox1Blue";
            this.kiwiComboBox1Blue.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2010Blue;
            this.kiwiComboBox1Blue.Size = new System.Drawing.Size(169, 21);
            this.kiwiComboBox1Blue.TabIndex = 0;
            this.kiwiComboBox1Blue.Text = "normal";
            this.kiwiComboBox1Blue.Enter += new System.EventHandler(this.kiwiComboBox1Blue_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kiwiComboBox6System);
            this.groupBox1.Controls.Add(this.kiwiComboBox5System);
            this.groupBox1.Controls.Add(this.kiwiComboBox4System);
            this.groupBox1.Location = new System.Drawing.Point(12, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Professional - System";
            // 
            // kiwiComboBox6System
            // 
            this.kiwiComboBox6System.AlwaysActive = false;
            this.kiwiComboBox6System.DropDownWidth = 121;
            this.kiwiComboBox6System.InputControlStyle = Kiwi.ComponentFactory.Toolkit.InputControlStyle.Ribbon;
            this.kiwiComboBox6System.Items.AddRange(new object[] {
            "one",
            "two",
            "three",
            "four",
            "five",
            "six"});
            this.kiwiComboBox6System.Location = new System.Drawing.Point(16, 84);
            this.kiwiComboBox6System.Name = "kiwiComboBox6System";
            this.kiwiComboBox6System.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalSystem;
            this.kiwiComboBox6System.Size = new System.Drawing.Size(169, 21);
            this.kiwiComboBox6System.TabIndex = 2;
            this.kiwiComboBox6System.Text = "ribbon style";
            this.kiwiComboBox6System.Enter += new System.EventHandler(this.kiwiComboBox1Blue_Enter);
            // 
            // kiwiComboBox5System
            // 
            this.kiwiComboBox5System.ButtonSpecs.AddRange(new Kiwi.ComponentFactory.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny2});
            this.kiwiComboBox5System.DropDownWidth = 121;
            this.kiwiComboBox5System.Items.AddRange(new object[] {
            "one",
            "two",
            "three",
            "four",
            "five",
            "six"});
            this.kiwiComboBox5System.Location = new System.Drawing.Point(16, 57);
            this.kiwiComboBox5System.Name = "kiwiComboBox5System";
            this.kiwiComboBox5System.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalSystem;
            this.kiwiComboBox5System.Size = new System.Drawing.Size(169, 21);
            this.kiwiComboBox5System.TabIndex = 1;
            this.kiwiComboBox5System.Text = "clear with button";
            this.kiwiComboBox5System.Enter += new System.EventHandler(this.kiwiComboBox1Blue_Enter);
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.Edge = Kiwi.ComponentFactory.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.buttonSpecAny2.Style = Kiwi.ComponentFactory.Toolkit.PaletteButtonStyle.ButtonSpec;
            this.buttonSpecAny2.Type = Kiwi.ComponentFactory.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny2.UniqueName = "37524C52AC4E48FE37524C52AC4E48FE";
            this.buttonSpecAny2.Click += new System.EventHandler(this.buttonSpecAny2_Click);
            // 
            // kiwiComboBox4System
            // 
            this.kiwiComboBox4System.DropDownWidth = 169;
            this.kiwiComboBox4System.Items.AddRange(new object[] {
            "one",
            "two",
            "three",
            "four",
            "five",
            "six"});
            this.kiwiComboBox4System.Location = new System.Drawing.Point(16, 30);
            this.kiwiComboBox4System.Name = "kiwiComboBox4System";
            this.kiwiComboBox4System.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalSystem;
            this.kiwiComboBox4System.Size = new System.Drawing.Size(169, 21);
            this.kiwiComboBox4System.TabIndex = 0;
            this.kiwiComboBox4System.Text = "normal";
            this.kiwiComboBox4System.Enter += new System.EventHandler(this.kiwiComboBox1Blue_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.kiwiComboBox8Custom);
            this.groupBox3.Controls.Add(this.kiwiComboBox7Custom);
            this.groupBox3.Location = new System.Drawing.Point(12, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 126);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Custom Settings";
            // 
            // kiwiComboBox8Custom
            // 
            this.kiwiComboBox8Custom.ButtonSpecs.AddRange(new Kiwi.ComponentFactory.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny3,
            this.buttonSpecAny4});
            this.kiwiComboBox8Custom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kiwiComboBox8Custom.DropDownWidth = 169;
            this.kiwiComboBox8Custom.Items.AddRange(new object[] {
            "one",
            "two",
            "three",
            "four",
            "five",
            "six"});
            this.kiwiComboBox8Custom.Location = new System.Drawing.Point(16, 69);
            this.kiwiComboBox8Custom.Name = "kiwiComboBox8Custom";
            this.kiwiComboBox8Custom.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalSystem;
            this.kiwiComboBox8Custom.Size = new System.Drawing.Size(169, 23);
            this.kiwiComboBox8Custom.StateCommon.ComboBox.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.kiwiComboBox8Custom.StateCommon.ComboBox.Border.GraphicsHint = Kiwi.ComponentFactory.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kiwiComboBox8Custom.StateCommon.ComboBox.Border.Rounding = 2;
            this.kiwiComboBox8Custom.TabIndex = 1;
            this.kiwiComboBox8Custom.Enter += new System.EventHandler(this.kiwiComboBox1Blue_Enter);
            // 
            // buttonSpecAny3
            // 
            this.buttonSpecAny3.Style = Kiwi.ComponentFactory.Toolkit.PaletteButtonStyle.Standalone;
            this.buttonSpecAny3.Type = Kiwi.ComponentFactory.Toolkit.PaletteButtonSpecStyle.ArrowLeft;
            this.buttonSpecAny3.UniqueName = "43801810E6F9413243801810E6F94132";
            this.buttonSpecAny3.Click += new System.EventHandler(this.buttonSpecAny3_Click);
            // 
            // buttonSpecAny4
            // 
            this.buttonSpecAny4.Style = Kiwi.ComponentFactory.Toolkit.PaletteButtonStyle.Standalone;
            this.buttonSpecAny4.Type = Kiwi.ComponentFactory.Toolkit.PaletteButtonSpecStyle.ArrowRight;
            this.buttonSpecAny4.UniqueName = "0CDF070A67D6473D0CDF070A67D6473D";
            this.buttonSpecAny4.Click += new System.EventHandler(this.buttonSpecAny4_Click);
            // 
            // kiwiComboBox7Custom
            // 
            this.kiwiComboBox7Custom.DropDownWidth = 169;
            this.kiwiComboBox7Custom.Items.AddRange(new object[] {
            "one",
            "two",
            "three",
            "four",
            "five",
            "six"});
            this.kiwiComboBox7Custom.Location = new System.Drawing.Point(16, 30);
            this.kiwiComboBox7Custom.Name = "kiwiComboBox7Custom";
            this.kiwiComboBox7Custom.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2007Black;
            this.kiwiComboBox7Custom.Size = new System.Drawing.Size(169, 23);
            this.kiwiComboBox7Custom.StateCommon.ComboBox.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.kiwiComboBox7Custom.StateCommon.ComboBox.Border.GraphicsHint = Kiwi.ComponentFactory.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kiwiComboBox7Custom.StateCommon.ComboBox.Border.Rounding = 2;
            this.kiwiComboBox7Custom.TabIndex = 0;
            this.kiwiComboBox7Custom.Text = "normal";
            this.kiwiComboBox7Custom.Enter += new System.EventHandler(this.kiwiComboBox1Blue_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 440);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "KiwiComboBox Examples";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiComboBox3Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiComboBox2Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiComboBox1Blue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiComboBox6System)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiComboBox5System)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiComboBox4System)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiComboBox8Custom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiComboBox7Custom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private Kiwi.ComponentFactory.Toolkit.KiwiComboBox kiwiComboBox1Blue;
        private Kiwi.ComponentFactory.Toolkit.KiwiComboBox kiwiComboBox3Blue;
        private Kiwi.ComponentFactory.Toolkit.KiwiComboBox kiwiComboBox2Blue;
        private Kiwi.ComponentFactory.Toolkit.ButtonSpecAny buttonSpecAny1;
        private Kiwi.ComponentFactory.Toolkit.KiwiComboBox kiwiComboBox6System;
        private Kiwi.ComponentFactory.Toolkit.KiwiComboBox kiwiComboBox5System;
        private Kiwi.ComponentFactory.Toolkit.ButtonSpecAny buttonSpecAny2;
        private Kiwi.ComponentFactory.Toolkit.KiwiComboBox kiwiComboBox4System;
        private Kiwi.ComponentFactory.Toolkit.KiwiComboBox kiwiComboBox7Custom;
        private Kiwi.ComponentFactory.Toolkit.KiwiComboBox kiwiComboBox8Custom;
        private Kiwi.ComponentFactory.Toolkit.ButtonSpecAny buttonSpecAny3;
        private Kiwi.ComponentFactory.Toolkit.ButtonSpecAny buttonSpecAny4;
    }
}

