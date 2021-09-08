
namespace KiwiMaskedTextBox_Examples
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox9Custom = new Kiwi.ComponentFactory.Toolkit.KiwiMaskedTextBox();
            this.buttonSpecAny2 = new Kiwi.ComponentFactory.Toolkit.ButtonSpecAny();
            this.kiwiContextMenu = new Kiwi.ComponentFactory.Toolkit.KiwiContextMenu();
            this.kiwiContextMenuItems1 = new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItems();
            this.kiwiContextMenuItem1 = new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem();
            this.kiwiContextMenuItem2 = new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem();
            this.kiwiContextMenuSeparator1 = new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuSeparator();
            this.kiwiContextMenuItem3 = new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem();
            this.maskedTextBox8Custom = new Kiwi.ComponentFactory.Toolkit.KiwiMaskedTextBox();
            this.maskedTextBox7Custom = new Kiwi.ComponentFactory.Toolkit.KiwiMaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox6System = new Kiwi.ComponentFactory.Toolkit.KiwiMaskedTextBox();
            this.maskedTextBox5System = new Kiwi.ComponentFactory.Toolkit.KiwiMaskedTextBox();
            this.buttonSpecAny3 = new Kiwi.ComponentFactory.Toolkit.ButtonSpecAny();
            this.maskedTextBox4System = new Kiwi.ComponentFactory.Toolkit.KiwiMaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox3Blue = new Kiwi.ComponentFactory.Toolkit.KiwiMaskedTextBox();
            this.maskedTextBox2Blue = new Kiwi.ComponentFactory.Toolkit.KiwiMaskedTextBox();
            this.buttonSpecAny1 = new Kiwi.ComponentFactory.Toolkit.ButtonSpecAny();
            this.maskedTextBox1Blue = new Kiwi.ComponentFactory.Toolkit.KiwiMaskedTextBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(460, 464);
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
            this.groupBox4.Location = new System.Drawing.Point(213, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(322, 446);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Properties for Selected KiwiMaskedTextBox";
            // 
            // propertyGrid
            // 
            this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid.Location = new System.Drawing.Point(6, 19);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(310, 421);
            this.propertyGrid.TabIndex = 0;
            this.propertyGrid.ToolbarVisible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.maskedTextBox9Custom);
            this.groupBox3.Controls.Add(this.maskedTextBox8Custom);
            this.groupBox3.Controls.Add(this.maskedTextBox7Custom);
            this.groupBox3.Location = new System.Drawing.Point(12, 300);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(195, 158);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Custom Settings";
            // 
            // maskedTextBox9Custom
            // 
            this.maskedTextBox9Custom.ButtonSpecs.AddRange(new Kiwi.ComponentFactory.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny2});
            this.maskedTextBox9Custom.Location = new System.Drawing.Point(16, 115);
            this.maskedTextBox9Custom.Mask = "00/00/0000";
            this.maskedTextBox9Custom.Name = "maskedTextBox9Custom";
            this.maskedTextBox9Custom.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2007Silver;
            this.maskedTextBox9Custom.PromptChar = '-';
            this.maskedTextBox9Custom.Size = new System.Drawing.Size(161, 23);
            this.maskedTextBox9Custom.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.maskedTextBox9Custom.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.maskedTextBox9Custom.StateCommon.Border.ColorAngle = 80F;
            this.maskedTextBox9Custom.StateCommon.Border.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Rounded;
            this.maskedTextBox9Custom.StateCommon.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.maskedTextBox9Custom.StateCommon.Border.GraphicsHint = Kiwi.ComponentFactory.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.maskedTextBox9Custom.StateCommon.Border.Rounding = 3;
            this.maskedTextBox9Custom.StateCommon.Border.Width = 1;
            this.maskedTextBox9Custom.TabIndex = 2;
            this.maskedTextBox9Custom.Text = "  /  /";
            this.maskedTextBox9Custom.Enter += new System.EventHandler(this.maskedTextBox1Blue_Enter);
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.KiwiContextMenu = this.kiwiContextMenu;
            this.buttonSpecAny2.Style = Kiwi.ComponentFactory.Toolkit.PaletteButtonStyle.Standalone;
            this.buttonSpecAny2.Type = Kiwi.ComponentFactory.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny2.UniqueName = "AFADF6E71C27433DAFADF6E71C27433D";
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
            this.kiwiContextMenuSeparator1,
            this.kiwiContextMenuItem3});
            // 
            // kiwiContextMenuItem1
            // 
            this.kiwiContextMenuItem1.Text = "DateTime.Now";
            this.kiwiContextMenuItem1.Click += new System.EventHandler(this.fixedText1_Click);
            // 
            // kiwiContextMenuItem2
            // 
            this.kiwiContextMenuItem2.Text = "Previous Date";
            this.kiwiContextMenuItem2.Click += new System.EventHandler(this.fixedText2_Click);
            // 
            // kiwiContextMenuItem3
            // 
            this.kiwiContextMenuItem3.Text = "Clear";
            this.kiwiContextMenuItem3.Click += new System.EventHandler(this.clear_Click);
            // 
            // maskedTextBox8Custom
            // 
            this.maskedTextBox8Custom.Location = new System.Drawing.Point(16, 72);
            this.maskedTextBox8Custom.Name = "maskedTextBox8Custom";
            this.maskedTextBox8Custom.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.maskedTextBox8Custom.PasswordChar = '●';
            this.maskedTextBox8Custom.Size = new System.Drawing.Size(161, 26);
            this.maskedTextBox8Custom.StateCommon.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.maskedTextBox8Custom.StateCommon.Border.GraphicsHint = Kiwi.ComponentFactory.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.maskedTextBox8Custom.StateCommon.Border.Rounding = 4;
            this.maskedTextBox8Custom.StateCommon.Border.Width = 2;
            this.maskedTextBox8Custom.TabIndex = 1;
            this.maskedTextBox8Custom.Text = "Password";
            this.maskedTextBox8Custom.UseSystemPasswordChar = true;
            this.maskedTextBox8Custom.Enter += new System.EventHandler(this.maskedTextBox1Blue_Enter);
            // 
            // maskedTextBox7Custom
            // 
            this.maskedTextBox7Custom.AlwaysActive = false;
            this.maskedTextBox7Custom.Location = new System.Drawing.Point(16, 29);
            this.maskedTextBox7Custom.Name = "maskedTextBox7Custom";
            this.maskedTextBox7Custom.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.maskedTextBox7Custom.Size = new System.Drawing.Size(161, 26);
            this.maskedTextBox7Custom.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.maskedTextBox7Custom.StateActive.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.maskedTextBox7Custom.StateCommon.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.maskedTextBox7Custom.StateCommon.Border.GraphicsHint = Kiwi.ComponentFactory.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.maskedTextBox7Custom.StateCommon.Border.Rounding = 4;
            this.maskedTextBox7Custom.StateCommon.Border.Width = 2;
            this.maskedTextBox7Custom.TabIndex = 0;
            this.maskedTextBox7Custom.Text = "Orange when Active";
            this.maskedTextBox7Custom.Enter += new System.EventHandler(this.maskedTextBox1Blue_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.maskedTextBox6System);
            this.groupBox1.Controls.Add(this.maskedTextBox5System);
            this.groupBox1.Controls.Add(this.maskedTextBox4System);
            this.groupBox1.Location = new System.Drawing.Point(12, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Professional - System";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ribbon Style";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "7 Digit Mask";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Short Date Mask";
            // 
            // maskedTextBox6System
            // 
            this.maskedTextBox6System.AlwaysActive = false;
            this.maskedTextBox6System.InputControlStyle = Kiwi.ComponentFactory.Toolkit.InputControlStyle.Ribbon;
            this.maskedTextBox6System.Location = new System.Drawing.Point(101, 82);
            this.maskedTextBox6System.Mask = "00/00/0000";
            this.maskedTextBox6System.Name = "maskedTextBox6System";
            this.maskedTextBox6System.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalSystem;
            this.maskedTextBox6System.PromptChar = '?';
            this.maskedTextBox6System.Size = new System.Drawing.Size(76, 20);
            this.maskedTextBox6System.TabIndex = 2;
            this.maskedTextBox6System.Text = "  /  /";
            this.maskedTextBox6System.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox6System.Enter += new System.EventHandler(this.maskedTextBox1Blue_Enter);
            // 
            // maskedTextBox5System
            // 
            this.maskedTextBox5System.AllowButtonSpecToolTips = true;
            this.maskedTextBox5System.ButtonSpecs.AddRange(new Kiwi.ComponentFactory.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny3});
            this.maskedTextBox5System.Location = new System.Drawing.Point(101, 55);
            this.maskedTextBox5System.Mask = "0000000";
            this.maskedTextBox5System.Name = "maskedTextBox5System";
            this.maskedTextBox5System.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalSystem;
            this.maskedTextBox5System.PromptChar = '-';
            this.maskedTextBox5System.Size = new System.Drawing.Size(76, 20);
            this.maskedTextBox5System.TabIndex = 1;
            this.maskedTextBox5System.Enter += new System.EventHandler(this.maskedTextBox1Blue_Enter);
            // 
            // buttonSpecAny3
            // 
            this.buttonSpecAny3.Type = Kiwi.ComponentFactory.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny3.UniqueName = "0D0CBE484603438F0D0CBE484603438F";
            this.buttonSpecAny3.Click += new System.EventHandler(this.buttonSpecAny3_Click);
            // 
            // maskedTextBox4System
            // 
            this.maskedTextBox4System.Location = new System.Drawing.Point(101, 29);
            this.maskedTextBox4System.Mask = "00/00/0000";
            this.maskedTextBox4System.Name = "maskedTextBox4System";
            this.maskedTextBox4System.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalSystem;
            this.maskedTextBox4System.Size = new System.Drawing.Size(76, 20);
            this.maskedTextBox4System.TabIndex = 0;
            this.maskedTextBox4System.Text = "  /  /";
            this.maskedTextBox4System.Enter += new System.EventHandler(this.maskedTextBox1Blue_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.maskedTextBox3Blue);
            this.groupBox2.Controls.Add(this.maskedTextBox2Blue);
            this.groupBox2.Controls.Add(this.maskedTextBox1Blue);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 138);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Office 2010 - Blue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ribbon Style";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "7 Digit Mask";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Short Date Mask";
            // 
            // maskedTextBox3Blue
            // 
            this.maskedTextBox3Blue.AlwaysActive = false;
            this.maskedTextBox3Blue.InputControlStyle = Kiwi.ComponentFactory.Toolkit.InputControlStyle.Ribbon;
            this.maskedTextBox3Blue.Location = new System.Drawing.Point(101, 85);
            this.maskedTextBox3Blue.Mask = "00/00/0000";
            this.maskedTextBox3Blue.Name = "maskedTextBox3Blue";
            this.maskedTextBox3Blue.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2010Blue;
            this.maskedTextBox3Blue.PromptChar = '?';
            this.maskedTextBox3Blue.Size = new System.Drawing.Size(76, 20);
            this.maskedTextBox3Blue.TabIndex = 2;
            this.maskedTextBox3Blue.Text = "  /  /";
            this.maskedTextBox3Blue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox3Blue.Enter += new System.EventHandler(this.maskedTextBox1Blue_Enter);
            // 
            // maskedTextBox2Blue
            // 
            this.maskedTextBox2Blue.AllowButtonSpecToolTips = true;
            this.maskedTextBox2Blue.ButtonSpecs.AddRange(new Kiwi.ComponentFactory.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.maskedTextBox2Blue.Location = new System.Drawing.Point(101, 58);
            this.maskedTextBox2Blue.Mask = "0000000";
            this.maskedTextBox2Blue.Name = "maskedTextBox2Blue";
            this.maskedTextBox2Blue.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2010Blue;
            this.maskedTextBox2Blue.PromptChar = '-';
            this.maskedTextBox2Blue.Size = new System.Drawing.Size(76, 20);
            this.maskedTextBox2Blue.TabIndex = 1;
            this.maskedTextBox2Blue.Enter += new System.EventHandler(this.maskedTextBox1Blue_Enter);
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Type = Kiwi.ComponentFactory.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "2600D6A1691343B72600D6A1691343B7";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // maskedTextBox1Blue
            // 
            this.maskedTextBox1Blue.Location = new System.Drawing.Point(101, 31);
            this.maskedTextBox1Blue.Mask = "00/00/0000";
            this.maskedTextBox1Blue.Name = "maskedTextBox1Blue";
            this.maskedTextBox1Blue.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2010Blue;
            this.maskedTextBox1Blue.Size = new System.Drawing.Size(76, 20);
            this.maskedTextBox1Blue.TabIndex = 0;
            this.maskedTextBox1Blue.Text = "  /  /";
            this.maskedTextBox1Blue.Enter += new System.EventHandler(this.maskedTextBox1Blue_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 495);
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
            this.Text = "KiwiMaskedTextBox Examples";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private Kiwi.ComponentFactory.Toolkit.KiwiMaskedTextBox maskedTextBox3Blue;
        private Kiwi.ComponentFactory.Toolkit.KiwiMaskedTextBox maskedTextBox2Blue;
        private Kiwi.ComponentFactory.Toolkit.KiwiMaskedTextBox maskedTextBox1Blue;
        private Kiwi.ComponentFactory.Toolkit.KiwiMaskedTextBox maskedTextBox6System;
        private Kiwi.ComponentFactory.Toolkit.KiwiMaskedTextBox maskedTextBox5System;
        private Kiwi.ComponentFactory.Toolkit.KiwiMaskedTextBox maskedTextBox4System;
        private Kiwi.ComponentFactory.Toolkit.KiwiMaskedTextBox maskedTextBox8Custom;
        private Kiwi.ComponentFactory.Toolkit.KiwiMaskedTextBox maskedTextBox7Custom;
        private Kiwi.ComponentFactory.Toolkit.KiwiMaskedTextBox maskedTextBox9Custom;
        private Kiwi.ComponentFactory.Toolkit.ButtonSpecAny buttonSpecAny2;
        private Kiwi.ComponentFactory.Toolkit.ButtonSpecAny buttonSpecAny3;
        private Kiwi.ComponentFactory.Toolkit.ButtonSpecAny buttonSpecAny1;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenu kiwiContextMenu;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItems kiwiContextMenuItems1;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem kiwiContextMenuItem1;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem kiwiContextMenuItem2;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenuSeparator kiwiContextMenuSeparator1;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem kiwiContextMenuItem3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

