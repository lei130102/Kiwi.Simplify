
namespace Child_Control_Stack
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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolOffice2010 = new System.Windows.Forms.ToolStripButton();
            this.toolOffice2007 = new System.Windows.Forms.ToolStripButton();
            this.toolSparkle = new System.Windows.Forms.ToolStripButton();
            this.toolSystem = new System.Windows.Forms.ToolStripButton();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOffice2010 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOffice2007 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSparkle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.kiwiPanelMain = new Kiwi.ComponentFactory.Toolkit.KiwiPanel();
            this.kiwiGroupMain = new Kiwi.ComponentFactory.Toolkit.KiwiGroup();
            this.textBoxFiller = new Kiwi.ComponentFactory.Toolkit.KiwiTextBox();
            this.kiwiBorderEdge5 = new Kiwi.ComponentFactory.Toolkit.KiwiBorderEdge();
            this.kiwiHeader = new Kiwi.ComponentFactory.Toolkit.KiwiHeader();
            this.kiwiBorderEdge4 = new Kiwi.ComponentFactory.Toolkit.KiwiBorderEdge();
            this.kiwiCheckButton4 = new Kiwi.ComponentFactory.Toolkit.KiwiCheckButton();
            this.kiwiBorderEdge3 = new Kiwi.ComponentFactory.Toolkit.KiwiBorderEdge();
            this.kiwiCheckButton3 = new Kiwi.ComponentFactory.Toolkit.KiwiCheckButton();
            this.kiwiBorderEdge2 = new Kiwi.ComponentFactory.Toolkit.KiwiBorderEdge();
            this.kiwiCheckButton2 = new Kiwi.ComponentFactory.Toolkit.KiwiCheckButton();
            this.kiwiBorderEdge1 = new Kiwi.ComponentFactory.Toolkit.KiwiBorderEdge();
            this.kiwiCheckButton1 = new Kiwi.ComponentFactory.Toolkit.KiwiCheckButton();
            this.kiwiCheckSet = new Kiwi.ComponentFactory.Toolkit.KiwiCheckSet(this.components);
            this.kiwiManager = new Kiwi.ComponentFactory.Toolkit.KiwiManager(this.components);
            this.toolStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPanelMain)).BeginInit();
            this.kiwiPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiGroupMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiGroupMain.Panel)).BeginInit();
            this.kiwiGroupMain.Panel.SuspendLayout();
            this.kiwiGroupMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiCheckSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolOffice2010,
            this.toolOffice2007,
            this.toolSparkle,
            this.toolSystem});
            this.toolStrip.Location = new System.Drawing.Point(3, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(180, 25);
            this.toolStrip.TabIndex = 3;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolOffice2010
            // 
            this.toolOffice2010.Checked = true;
            this.toolOffice2010.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolOffice2010.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolOffice2010.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolOffice2010.Name = "toolOffice2010";
            this.toolOffice2010.Size = new System.Drawing.Size(35, 22);
            this.toolOffice2010.Text = "2010";
            this.toolOffice2010.Click += new System.EventHandler(this.toolOffice2010_Click);
            // 
            // toolOffice2007
            // 
            this.toolOffice2007.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolOffice2007.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolOffice2007.Name = "toolOffice2007";
            this.toolOffice2007.Size = new System.Drawing.Size(35, 22);
            this.toolOffice2007.Text = "2007";
            this.toolOffice2007.Click += new System.EventHandler(this.toolOffice2007_Click);
            // 
            // toolSparkle
            // 
            this.toolSparkle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolSparkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSparkle.Name = "toolSparkle";
            this.toolSparkle.Size = new System.Drawing.Size(49, 22);
            this.toolSparkle.Text = "Sparkle";
            this.toolSparkle.Click += new System.EventHandler(this.toolSparkle_Click);
            // 
            // toolSystem
            // 
            this.toolSystem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolSystem.ImageTransparentColor = System.Drawing.Color.YellowGreen;
            this.toolSystem.Name = "toolSystem";
            this.toolSystem.Size = new System.Drawing.Size(49, 22);
            this.toolSystem.Text = "System";
            this.toolSystem.Click += new System.EventHandler(this.toolSystem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(322, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOffice2010,
            this.menuOffice2007,
            this.menuSparkle,
            this.menuSystem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // menuOffice2010
            // 
            this.menuOffice2010.Checked = true;
            this.menuOffice2010.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuOffice2010.Name = "menuOffice2010";
            this.menuOffice2010.Size = new System.Drawing.Size(167, 22);
            this.menuOffice2010.Text = "Office 2010 - Blue";
            this.menuOffice2010.Click += new System.EventHandler(this.toolOffice2010_Click);
            // 
            // menuOffice2007
            // 
            this.menuOffice2007.Name = "menuOffice2007";
            this.menuOffice2007.Size = new System.Drawing.Size(167, 22);
            this.menuOffice2007.Text = "Office 2007 - Blue";
            this.menuOffice2007.Click += new System.EventHandler(this.toolOffice2007_Click);
            // 
            // menuSparkle
            // 
            this.menuSparkle.Name = "menuSparkle";
            this.menuSparkle.Size = new System.Drawing.Size(167, 22);
            this.menuSparkle.Text = "Sparkle - Blue";
            this.menuSparkle.Click += new System.EventHandler(this.toolSparkle_Click);
            // 
            // menuSystem
            // 
            this.menuSystem.Name = "menuSystem";
            this.menuSystem.Size = new System.Drawing.Size(167, 22);
            this.menuSystem.Text = "System";
            this.menuSystem.Click += new System.EventHandler(this.toolSystem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.kiwiPanelMain);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(322, 265);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(322, 290);
            this.toolStripContainer1.TabIndex = 4;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip);
            // 
            // kiwiPanelMain
            // 
            this.kiwiPanelMain.Controls.Add(this.kiwiGroupMain);
            this.kiwiPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiwiPanelMain.Location = new System.Drawing.Point(0, 0);
            this.kiwiPanelMain.Name = "kiwiPanelMain";
            this.kiwiPanelMain.Padding = new System.Windows.Forms.Padding(5);
            this.kiwiPanelMain.Size = new System.Drawing.Size(322, 265);
            this.kiwiPanelMain.TabIndex = 0;
            // 
            // kiwiGroupMain
            // 
            this.kiwiGroupMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiwiGroupMain.Location = new System.Drawing.Point(5, 5);
            this.kiwiGroupMain.Name = "kiwiGroupMain";
            // 
            // kiwiGroupMain.Panel
            // 
            this.kiwiGroupMain.Panel.Controls.Add(this.textBoxFiller);
            this.kiwiGroupMain.Panel.Controls.Add(this.kiwiBorderEdge5);
            this.kiwiGroupMain.Panel.Controls.Add(this.kiwiHeader);
            this.kiwiGroupMain.Panel.Controls.Add(this.kiwiBorderEdge4);
            this.kiwiGroupMain.Panel.Controls.Add(this.kiwiCheckButton4);
            this.kiwiGroupMain.Panel.Controls.Add(this.kiwiBorderEdge3);
            this.kiwiGroupMain.Panel.Controls.Add(this.kiwiCheckButton3);
            this.kiwiGroupMain.Panel.Controls.Add(this.kiwiBorderEdge2);
            this.kiwiGroupMain.Panel.Controls.Add(this.kiwiCheckButton2);
            this.kiwiGroupMain.Panel.Controls.Add(this.kiwiBorderEdge1);
            this.kiwiGroupMain.Panel.Controls.Add(this.kiwiCheckButton1);
            this.kiwiGroupMain.Size = new System.Drawing.Size(312, 255);
            this.kiwiGroupMain.TabIndex = 0;
            // 
            // textBoxFiller
            // 
            this.textBoxFiller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFiller.Location = new System.Drawing.Point(0, 30);
            this.textBoxFiller.Multiline = true;
            this.textBoxFiller.Name = "textBoxFiller";
            this.textBoxFiller.Size = new System.Drawing.Size(310, 119);
            this.textBoxFiller.StateCommon.Border.Draw = Kiwi.ComponentFactory.Toolkit.InheritBool.False;
            this.textBoxFiller.StateCommon.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom) 
            | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left) 
            | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxFiller.TabIndex = 0;
            // 
            // kiwiBorderEdge5
            // 
            this.kiwiBorderEdge5.Dock = System.Windows.Forms.DockStyle.Top;
            this.kiwiBorderEdge5.Location = new System.Drawing.Point(0, 29);
            this.kiwiBorderEdge5.Name = "kiwiBorderEdge5";
            this.kiwiBorderEdge5.Size = new System.Drawing.Size(310, 1);
            this.kiwiBorderEdge5.Text = "kiwiBorderEdge5";
            // 
            // kiwiHeader
            // 
            this.kiwiHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.kiwiHeader.Location = new System.Drawing.Point(0, 0);
            this.kiwiHeader.Name = "kiwiHeader";
            this.kiwiHeader.Size = new System.Drawing.Size(310, 29);
            this.kiwiHeader.StateCommon.Border.DrawBorders = Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.None;
            this.kiwiHeader.TabIndex = 5;
            this.kiwiHeader.Values.Description = "";
            this.kiwiHeader.Values.Heading = "Calendar";
            this.kiwiHeader.Values.Image = null;
            // 
            // kiwiBorderEdge4
            // 
            this.kiwiBorderEdge4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kiwiBorderEdge4.Location = new System.Drawing.Point(0, 149);
            this.kiwiBorderEdge4.Name = "kiwiBorderEdge4";
            this.kiwiBorderEdge4.Size = new System.Drawing.Size(310, 1);
            this.kiwiBorderEdge4.Text = "kiwiBorderEdge4";
            // 
            // kiwiCheckButton4
            // 
            this.kiwiCheckButton4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kiwiCheckButton4.Location = new System.Drawing.Point(0, 150);
            this.kiwiCheckButton4.Name = "kiwiCheckButton4";
            this.kiwiCheckButton4.Size = new System.Drawing.Size(310, 25);
            this.kiwiCheckButton4.StateCommon.Border.DrawBorders = Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.None;
            this.kiwiCheckButton4.StateCommon.Content.Image.ImageH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Near;
            this.kiwiCheckButton4.StateCommon.Content.Image.ImageV = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Center;
            this.kiwiCheckButton4.StateCommon.Content.LongText.TextH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Far;
            this.kiwiCheckButton4.StateCommon.Content.LongText.TextV = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Center;
            this.kiwiCheckButton4.StateCommon.Content.ShortText.TextH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Near;
            this.kiwiCheckButton4.StateCommon.Content.ShortText.TextV = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Center;
            this.kiwiCheckButton4.TabIndex = 2;
            this.kiwiCheckButton4.Values.Text = "Tasks";
            // 
            // kiwiBorderEdge3
            // 
            this.kiwiBorderEdge3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kiwiBorderEdge3.Location = new System.Drawing.Point(0, 175);
            this.kiwiBorderEdge3.Name = "kiwiBorderEdge3";
            this.kiwiBorderEdge3.Size = new System.Drawing.Size(310, 1);
            this.kiwiBorderEdge3.Text = "kiwiBorderEdge3";
            // 
            // kiwiCheckButton3
            // 
            this.kiwiCheckButton3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kiwiCheckButton3.Location = new System.Drawing.Point(0, 176);
            this.kiwiCheckButton3.Name = "kiwiCheckButton3";
            this.kiwiCheckButton3.Size = new System.Drawing.Size(310, 25);
            this.kiwiCheckButton3.StateCommon.Border.DrawBorders = Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.None;
            this.kiwiCheckButton3.StateCommon.Content.Image.ImageH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Near;
            this.kiwiCheckButton3.StateCommon.Content.Image.ImageV = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Center;
            this.kiwiCheckButton3.StateCommon.Content.LongText.TextH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Far;
            this.kiwiCheckButton3.StateCommon.Content.LongText.TextV = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Center;
            this.kiwiCheckButton3.StateCommon.Content.ShortText.TextH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Near;
            this.kiwiCheckButton3.StateCommon.Content.ShortText.TextV = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Center;
            this.kiwiCheckButton3.TabIndex = 3;
            this.kiwiCheckButton3.Values.Text = "Mail";
            // 
            // kiwiBorderEdge2
            // 
            this.kiwiBorderEdge2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kiwiBorderEdge2.Location = new System.Drawing.Point(0, 201);
            this.kiwiBorderEdge2.Name = "kiwiBorderEdge2";
            this.kiwiBorderEdge2.Size = new System.Drawing.Size(310, 1);
            this.kiwiBorderEdge2.Text = "kiwiBorderEdge2";
            // 
            // kiwiCheckButton2
            // 
            this.kiwiCheckButton2.Checked = true;
            this.kiwiCheckButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kiwiCheckButton2.Location = new System.Drawing.Point(0, 202);
            this.kiwiCheckButton2.Name = "kiwiCheckButton2";
            this.kiwiCheckButton2.Size = new System.Drawing.Size(310, 25);
            this.kiwiCheckButton2.StateCommon.Border.DrawBorders = Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.None;
            this.kiwiCheckButton2.StateCommon.Content.Image.ImageH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Near;
            this.kiwiCheckButton2.StateCommon.Content.Image.ImageV = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Center;
            this.kiwiCheckButton2.StateCommon.Content.LongText.TextH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Far;
            this.kiwiCheckButton2.StateCommon.Content.LongText.TextV = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Center;
            this.kiwiCheckButton2.StateCommon.Content.ShortText.TextH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Near;
            this.kiwiCheckButton2.StateCommon.Content.ShortText.TextV = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Center;
            this.kiwiCheckButton2.TabIndex = 4;
            this.kiwiCheckButton2.Values.Text = "Calendar";
            // 
            // kiwiBorderEdge1
            // 
            this.kiwiBorderEdge1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kiwiBorderEdge1.Location = new System.Drawing.Point(0, 227);
            this.kiwiBorderEdge1.Name = "kiwiBorderEdge1";
            this.kiwiBorderEdge1.Size = new System.Drawing.Size(310, 1);
            this.kiwiBorderEdge1.Text = "kiwiBorderEdge1";
            // 
            // kiwiCheckButton1
            // 
            this.kiwiCheckButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kiwiCheckButton1.Location = new System.Drawing.Point(0, 228);
            this.kiwiCheckButton1.Name = "kiwiCheckButton1";
            this.kiwiCheckButton1.Size = new System.Drawing.Size(310, 25);
            this.kiwiCheckButton1.StateCommon.Border.DrawBorders = Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.None;
            this.kiwiCheckButton1.StateCommon.Content.Image.ImageH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Near;
            this.kiwiCheckButton1.StateCommon.Content.Image.ImageV = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Center;
            this.kiwiCheckButton1.StateCommon.Content.LongText.TextH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Far;
            this.kiwiCheckButton1.StateCommon.Content.LongText.TextV = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Center;
            this.kiwiCheckButton1.StateCommon.Content.ShortText.TextH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Near;
            this.kiwiCheckButton1.StateCommon.Content.ShortText.TextV = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Center;
            this.kiwiCheckButton1.TabIndex = 5;
            this.kiwiCheckButton1.Values.Text = "Notes";
            // 
            // kiwiCheckSet
            // 
            this.kiwiCheckSet.CheckButtons.Add(this.kiwiCheckButton1);
            this.kiwiCheckSet.CheckButtons.Add(this.kiwiCheckButton2);
            this.kiwiCheckSet.CheckButtons.Add(this.kiwiCheckButton3);
            this.kiwiCheckSet.CheckButtons.Add(this.kiwiCheckButton4);
            this.kiwiCheckSet.CheckedButton = this.kiwiCheckButton2;
            this.kiwiCheckSet.CheckedButtonChanged += new System.EventHandler(this.kiwiCheckSet_CheckedButtonChanged);
            // 
            // kiwiManager
            // 
            this.kiwiManager.GlobalPaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteModeManager.Office2007Blue;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(322, 314);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(257, 348);
            this.Name = "Form1";
            this.Text = "Child Control Stack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPanelMain)).EndInit();
            this.kiwiPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiGroupMain.Panel)).EndInit();
            this.kiwiGroupMain.Panel.ResumeLayout(false);
            this.kiwiGroupMain.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiGroupMain)).EndInit();
            this.kiwiGroupMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiCheckSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolSystem;
        private System.Windows.Forms.ToolStripButton toolSparkle;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuSystem;
        private System.Windows.Forms.ToolStripMenuItem menuSparkle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private Kiwi.ComponentFactory.Toolkit.KiwiPanel kiwiPanelMain;
        private Kiwi.ComponentFactory.Toolkit.KiwiGroup kiwiGroupMain;
        private Kiwi.ComponentFactory.Toolkit.KiwiBorderEdge kiwiBorderEdge4;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckButton kiwiCheckButton4;
        private Kiwi.ComponentFactory.Toolkit.KiwiBorderEdge kiwiBorderEdge3;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckButton kiwiCheckButton3;
        private Kiwi.ComponentFactory.Toolkit.KiwiBorderEdge kiwiBorderEdge2;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckButton kiwiCheckButton2;
        private Kiwi.ComponentFactory.Toolkit.KiwiBorderEdge kiwiBorderEdge1;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckButton kiwiCheckButton1;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckSet kiwiCheckSet;
        private Kiwi.ComponentFactory.Toolkit.KiwiBorderEdge kiwiBorderEdge5;
        private Kiwi.ComponentFactory.Toolkit.KiwiHeader kiwiHeader;
        private Kiwi.ComponentFactory.Toolkit.KiwiManager kiwiManager;
        private Kiwi.ComponentFactory.Toolkit.KiwiTextBox textBoxFiller;
        private System.Windows.Forms.ToolStripButton toolOffice2010;
        private System.Windows.Forms.ToolStripButton toolOffice2007;
        private System.Windows.Forms.ToolStripMenuItem menuOffice2010;
        private System.Windows.Forms.ToolStripMenuItem menuOffice2007;

    }
}

