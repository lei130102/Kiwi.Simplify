
namespace KiwiTextBox_Examples
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
            this.kiwiTextBox9Custom = new Kiwi.ComponentFactory.Toolkit.KiwiTextBox();
            this.buttonSpecAny2 = new Kiwi.ComponentFactory.Toolkit.ButtonSpecAny();
            this.kiwiContextMenu = new Kiwi.ComponentFactory.Toolkit.KiwiContextMenu();
            this.kiwiContextMenuItems1 = new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItems();
            this.kiwiContextMenuItem1 = new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem();
            this.kiwiContextMenuItem2 = new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem();
            this.kiwiContextMenuSeparator1 = new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuSeparator();
            this.kiwiContextMenuItem3 = new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem();
            this.kiwiTextBox8Custom = new Kiwi.ComponentFactory.Toolkit.KiwiTextBox();
            this.kiwiTextBox7Custom = new Kiwi.ComponentFactory.Toolkit.KiwiTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kiwiTextBox6System = new Kiwi.ComponentFactory.Toolkit.KiwiTextBox();
            this.kiwiTextBox5System = new Kiwi.ComponentFactory.Toolkit.KiwiTextBox();
            this.buttonSpecAny3 = new Kiwi.ComponentFactory.Toolkit.ButtonSpecAny();
            this.kiwiTextBox4System = new Kiwi.ComponentFactory.Toolkit.KiwiTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kiwiTextBox3Blue = new Kiwi.ComponentFactory.Toolkit.KiwiTextBox();
            this.kiwiTextBox2Blue = new Kiwi.ComponentFactory.Toolkit.KiwiTextBox();
            this.buttonSpecAny1 = new Kiwi.ComponentFactory.Toolkit.ButtonSpecAny();
            this.kiwiTextBox1Blue = new Kiwi.ComponentFactory.Toolkit.KiwiTextBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(460, 550);
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
            this.groupBox4.Size = new System.Drawing.Size(322, 532);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Properties for Selected KiwiTextBox";
            // 
            // propertyGrid
            // 
            this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid.Location = new System.Drawing.Point(6, 19);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(310, 507);
            this.propertyGrid.TabIndex = 0;
            this.propertyGrid.ToolbarVisible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.kiwiTextBox9Custom);
            this.groupBox3.Controls.Add(this.kiwiTextBox8Custom);
            this.groupBox3.Controls.Add(this.kiwiTextBox7Custom);
            this.groupBox3.Location = new System.Drawing.Point(12, 386);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(195, 158);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Custom Settings";
            // 
            // kiwiTextBox9Custom
            // 
            this.kiwiTextBox9Custom.ButtonSpecs.AddRange(new Kiwi.ComponentFactory.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny2});
            this.kiwiTextBox9Custom.Location = new System.Drawing.Point(16, 115);
            this.kiwiTextBox9Custom.Name = "kiwiTextBox9Custom";
            this.kiwiTextBox9Custom.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2007Silver;
            this.kiwiTextBox9Custom.Size = new System.Drawing.Size(161, 23);
            this.kiwiTextBox9Custom.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.kiwiTextBox9Custom.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.kiwiTextBox9Custom.StateCommon.Border.ColorAngle = 80F;
            this.kiwiTextBox9Custom.StateCommon.Border.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Rounded;
            this.kiwiTextBox9Custom.StateCommon.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.kiwiTextBox9Custom.StateCommon.Border.GraphicsHint = Kiwi.ComponentFactory.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kiwiTextBox9Custom.StateCommon.Border.ImageStyle = Kiwi.ComponentFactory.Toolkit.PaletteImageStyle.Inherit;
            this.kiwiTextBox9Custom.StateCommon.Border.Rounding = 3;
            this.kiwiTextBox9Custom.StateCommon.Border.Width = 1;
            this.kiwiTextBox9Custom.TabIndex = 2;
            this.kiwiTextBox9Custom.Text = "Use Button";
            this.kiwiTextBox9Custom.Enter += new System.EventHandler(this.kiwiTextBox1Blue_Enter);
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.KiwiContextMenu = this.kiwiContextMenu;
            this.buttonSpecAny2.Style = Kiwi.ComponentFactory.Toolkit.PaletteButtonStyle.Standalone;
            this.buttonSpecAny2.ToolTipStyle = Kiwi.ComponentFactory.Toolkit.LabelStyle.ToolTip;
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
            this.kiwiContextMenuItem1.Text = "Fixed Text 1";
            this.kiwiContextMenuItem1.Click += new System.EventHandler(this.fixedText1_Click);
            // 
            // kiwiContextMenuItem2
            // 
            this.kiwiContextMenuItem2.Text = "Fixed Text 2";
            this.kiwiContextMenuItem2.Click += new System.EventHandler(this.fixedText2_Click);
            // 
            // kiwiContextMenuItem3
            // 
            this.kiwiContextMenuItem3.Text = "Clear";
            this.kiwiContextMenuItem3.Click += new System.EventHandler(this.clear_Click);
            // 
            // kiwiTextBox8Custom
            // 
            this.kiwiTextBox8Custom.Location = new System.Drawing.Point(16, 72);
            this.kiwiTextBox8Custom.Name = "kiwiTextBox8Custom";
            this.kiwiTextBox8Custom.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.kiwiTextBox8Custom.PasswordChar = '●';
            this.kiwiTextBox8Custom.Size = new System.Drawing.Size(161, 26);
            this.kiwiTextBox8Custom.StateCommon.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.kiwiTextBox8Custom.StateCommon.Border.GraphicsHint = Kiwi.ComponentFactory.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kiwiTextBox8Custom.StateCommon.Border.ImageStyle = Kiwi.ComponentFactory.Toolkit.PaletteImageStyle.Inherit;
            this.kiwiTextBox8Custom.StateCommon.Border.Rounding = 4;
            this.kiwiTextBox8Custom.StateCommon.Border.Width = 2;
            this.kiwiTextBox8Custom.TabIndex = 1;
            this.kiwiTextBox8Custom.Text = "Password";
            this.kiwiTextBox8Custom.UseSystemPasswordChar = true;
            this.kiwiTextBox8Custom.Enter += new System.EventHandler(this.kiwiTextBox1Blue_Enter);
            // 
            // kiwiTextBox7Custom
            // 
            this.kiwiTextBox7Custom.AlwaysActive = false;
            this.kiwiTextBox7Custom.Location = new System.Drawing.Point(16, 29);
            this.kiwiTextBox7Custom.Name = "kiwiTextBox7Custom";
            this.kiwiTextBox7Custom.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.kiwiTextBox7Custom.Size = new System.Drawing.Size(161, 26);
            this.kiwiTextBox7Custom.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kiwiTextBox7Custom.StateActive.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.kiwiTextBox7Custom.StateActive.Border.ImageStyle = Kiwi.ComponentFactory.Toolkit.PaletteImageStyle.Inherit;
            this.kiwiTextBox7Custom.StateCommon.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.kiwiTextBox7Custom.StateCommon.Border.GraphicsHint = Kiwi.ComponentFactory.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kiwiTextBox7Custom.StateCommon.Border.ImageStyle = Kiwi.ComponentFactory.Toolkit.PaletteImageStyle.Inherit;
            this.kiwiTextBox7Custom.StateCommon.Border.Rounding = 4;
            this.kiwiTextBox7Custom.StateCommon.Border.Width = 2;
            this.kiwiTextBox7Custom.TabIndex = 0;
            this.kiwiTextBox7Custom.Text = "Orange when Active";
            this.kiwiTextBox7Custom.Enter += new System.EventHandler(this.kiwiTextBox1Blue_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kiwiTextBox6System);
            this.groupBox1.Controls.Add(this.kiwiTextBox5System);
            this.groupBox1.Controls.Add(this.kiwiTextBox4System);
            this.groupBox1.Location = new System.Drawing.Point(12, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 181);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Professional - System";
            // 
            // kiwiTextBox6System
            // 
            this.kiwiTextBox6System.AlwaysActive = false;
            this.kiwiTextBox6System.InputControlStyle = Kiwi.ComponentFactory.Toolkit.InputControlStyle.Ribbon;
            this.kiwiTextBox6System.Location = new System.Drawing.Point(16, 82);
            this.kiwiTextBox6System.Multiline = true;
            this.kiwiTextBox6System.Name = "kiwiTextBox6System";
            this.kiwiTextBox6System.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalSystem;
            this.kiwiTextBox6System.Size = new System.Drawing.Size(161, 81);
            this.kiwiTextBox6System.TabIndex = 2;
            this.kiwiTextBox6System.Text = "Ribbon style for use inside the Ribbon control. Also has Multiline setting set to" +
                " True.";
            this.kiwiTextBox6System.Enter += new System.EventHandler(this.kiwiTextBox1Blue_Enter);
            // 
            // kiwiTextBox5System
            // 
            this.kiwiTextBox5System.AllowButtonSpecToolTips = true;
            this.kiwiTextBox5System.ButtonSpecs.AddRange(new Kiwi.ComponentFactory.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny3});
            this.kiwiTextBox5System.Location = new System.Drawing.Point(16, 55);
            this.kiwiTextBox5System.Name = "kiwiTextBox5System";
            this.kiwiTextBox5System.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalSystem;
            this.kiwiTextBox5System.Size = new System.Drawing.Size(161, 20);
            this.kiwiTextBox5System.TabIndex = 1;
            this.kiwiTextBox5System.Text = "Use Button To Clear";
            this.kiwiTextBox5System.Enter += new System.EventHandler(this.kiwiTextBox1Blue_Enter);
            // 
            // buttonSpecAny3
            // 
            this.buttonSpecAny3.Style = Kiwi.ComponentFactory.Toolkit.PaletteButtonStyle.Inherit;
            this.buttonSpecAny3.ToolTipStyle = Kiwi.ComponentFactory.Toolkit.LabelStyle.ToolTip;
            this.buttonSpecAny3.Type = Kiwi.ComponentFactory.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny3.UniqueName = "0D0CBE484603438F0D0CBE484603438F";
            this.buttonSpecAny3.Click += new System.EventHandler(this.buttonSpecAny3_Click);
            // 
            // kiwiTextBox4System
            // 
            this.kiwiTextBox4System.Location = new System.Drawing.Point(16, 29);
            this.kiwiTextBox4System.Name = "kiwiTextBox4System";
            this.kiwiTextBox4System.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalSystem;
            this.kiwiTextBox4System.Size = new System.Drawing.Size(161, 20);
            this.kiwiTextBox4System.TabIndex = 0;
            this.kiwiTextBox4System.Text = "KiwiTextBox";
            this.kiwiTextBox4System.Enter += new System.EventHandler(this.kiwiTextBox1Blue_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kiwiTextBox3Blue);
            this.groupBox2.Controls.Add(this.kiwiTextBox2Blue);
            this.groupBox2.Controls.Add(this.kiwiTextBox1Blue);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 181);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Office 2007 - Blue";
            // 
            // kiwiTextBox3Blue
            // 
            this.kiwiTextBox3Blue.AlwaysActive = false;
            this.kiwiTextBox3Blue.InputControlStyle = Kiwi.ComponentFactory.Toolkit.InputControlStyle.Ribbon;
            this.kiwiTextBox3Blue.Location = new System.Drawing.Point(16, 83);
            this.kiwiTextBox3Blue.Multiline = true;
            this.kiwiTextBox3Blue.Name = "kiwiTextBox3Blue";
            this.kiwiTextBox3Blue.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2007Blue;
            this.kiwiTextBox3Blue.Size = new System.Drawing.Size(161, 81);
            this.kiwiTextBox3Blue.TabIndex = 2;
            this.kiwiTextBox3Blue.Text = "Ribbon style for use inside the Ribbon control. Also has Multiline setting set to" +
                " True.";
            this.kiwiTextBox3Blue.Enter += new System.EventHandler(this.kiwiTextBox1Blue_Enter);
            // 
            // kiwiTextBox2Blue
            // 
            this.kiwiTextBox2Blue.AllowButtonSpecToolTips = true;
            this.kiwiTextBox2Blue.ButtonSpecs.AddRange(new Kiwi.ComponentFactory.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.kiwiTextBox2Blue.Location = new System.Drawing.Point(16, 56);
            this.kiwiTextBox2Blue.Name = "kiwiTextBox2Blue";
            this.kiwiTextBox2Blue.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2007Blue;
            this.kiwiTextBox2Blue.Size = new System.Drawing.Size(161, 20);
            this.kiwiTextBox2Blue.TabIndex = 1;
            this.kiwiTextBox2Blue.Text = "Use Button To Clear";
            this.kiwiTextBox2Blue.Enter += new System.EventHandler(this.kiwiTextBox1Blue_Enter);
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Style = Kiwi.ComponentFactory.Toolkit.PaletteButtonStyle.Inherit;
            this.buttonSpecAny1.ToolTipStyle = Kiwi.ComponentFactory.Toolkit.LabelStyle.ToolTip;
            this.buttonSpecAny1.Type = Kiwi.ComponentFactory.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "2600D6A1691343B72600D6A1691343B7";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // kiwiTextBox1Blue
            // 
            this.kiwiTextBox1Blue.Location = new System.Drawing.Point(16, 30);
            this.kiwiTextBox1Blue.Name = "kiwiTextBox1Blue";
            this.kiwiTextBox1Blue.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2007Blue;
            this.kiwiTextBox1Blue.Size = new System.Drawing.Size(161, 20);
            this.kiwiTextBox1Blue.TabIndex = 0;
            this.kiwiTextBox1Blue.Text = "KiwiTextBox";
            this.kiwiTextBox1Blue.Enter += new System.EventHandler(this.kiwiTextBox1Blue_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 580);
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
            this.Text = "KiwiTextBox Examples";
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
        private Kiwi.ComponentFactory.Toolkit.KiwiTextBox kiwiTextBox3Blue;
        private Kiwi.ComponentFactory.Toolkit.KiwiTextBox kiwiTextBox2Blue;
        private Kiwi.ComponentFactory.Toolkit.KiwiTextBox kiwiTextBox1Blue;
        private Kiwi.ComponentFactory.Toolkit.KiwiTextBox kiwiTextBox6System;
        private Kiwi.ComponentFactory.Toolkit.KiwiTextBox kiwiTextBox5System;
        private Kiwi.ComponentFactory.Toolkit.KiwiTextBox kiwiTextBox4System;
        private Kiwi.ComponentFactory.Toolkit.KiwiTextBox kiwiTextBox8Custom;
        private Kiwi.ComponentFactory.Toolkit.KiwiTextBox kiwiTextBox7Custom;
        private Kiwi.ComponentFactory.Toolkit.KiwiTextBox kiwiTextBox9Custom;
        private Kiwi.ComponentFactory.Toolkit.ButtonSpecAny buttonSpecAny2;
        private Kiwi.ComponentFactory.Toolkit.ButtonSpecAny buttonSpecAny3;
        private Kiwi.ComponentFactory.Toolkit.ButtonSpecAny buttonSpecAny1;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenu kiwiContextMenu;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItems kiwiContextMenuItems1;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem kiwiContextMenuItem1;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem kiwiContextMenuItem2;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenuSeparator kiwiContextMenuSeparator1;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem kiwiContextMenuItem3;
    }
}

