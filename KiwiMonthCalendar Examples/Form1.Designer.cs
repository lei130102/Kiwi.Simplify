
namespace KiwiMonthCalendar_Examples
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOffice2007Black = new System.Windows.Forms.RadioButton();
            this.rbOffice2007Silver = new System.Windows.Forms.RadioButton();
            this.rbSparklePurple = new System.Windows.Forms.RadioButton();
            this.rbSparkleOrange = new System.Windows.Forms.RadioButton();
            this.rbSystem = new System.Windows.Forms.RadioButton();
            this.rbOffice2003 = new System.Windows.Forms.RadioButton();
            this.rbSparkleBlue = new System.Windows.Forms.RadioButton();
            this.rbOffice2007Blue = new System.Windows.Forms.RadioButton();
            this.rbOffice2010Black = new System.Windows.Forms.RadioButton();
            this.rbOffice2010Silver = new System.Windows.Forms.RadioButton();
            this.rbOffice2010Blue = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.kiwiMonthCalendar1 = new Kiwi.ComponentFactory.Toolkit.KiwiMonthCalendar();
            this.kiwiPalette = new Kiwi.ComponentFactory.Toolkit.KiwiPalette(this.components);
            this.buttonClose = new System.Windows.Forms.Button();
            this.kiwiManager1 = new Kiwi.ComponentFactory.Toolkit.KiwiManager(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOffice2007Black);
            this.groupBox1.Controls.Add(this.rbOffice2007Silver);
            this.groupBox1.Controls.Add(this.rbSparklePurple);
            this.groupBox1.Controls.Add(this.rbSparkleOrange);
            this.groupBox1.Controls.Add(this.rbSystem);
            this.groupBox1.Controls.Add(this.rbOffice2003);
            this.groupBox1.Controls.Add(this.rbSparkleBlue);
            this.groupBox1.Controls.Add(this.rbOffice2007Blue);
            this.groupBox1.Controls.Add(this.rbOffice2010Black);
            this.groupBox1.Controls.Add(this.rbOffice2010Silver);
            this.groupBox1.Controls.Add(this.rbOffice2010Blue);
            this.groupBox1.Location = new System.Drawing.Point(12, 404);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Palette";
            // 
            // rbOffice2007Black
            // 
            this.rbOffice2007Black.AutoSize = true;
            this.rbOffice2007Black.Location = new System.Drawing.Point(154, 66);
            this.rbOffice2007Black.Name = "rbOffice2007Black";
            this.rbOffice2007Black.Size = new System.Drawing.Size(137, 16);
            this.rbOffice2007Black.TabIndex = 0;
            this.rbOffice2007Black.Text = "Office 2007 - Black";
            this.rbOffice2007Black.UseVisualStyleBackColor = true;
            this.rbOffice2007Black.CheckedChanged += new System.EventHandler(this.rbOffice2007Black_CheckedChanged);
            // 
            // rbOffice2007Silver
            // 
            this.rbOffice2007Silver.AutoSize = true;
            this.rbOffice2007Silver.Location = new System.Drawing.Point(154, 42);
            this.rbOffice2007Silver.Name = "rbOffice2007Silver";
            this.rbOffice2007Silver.Size = new System.Drawing.Size(143, 16);
            this.rbOffice2007Silver.TabIndex = 0;
            this.rbOffice2007Silver.Text = "Office 2007 - Silver";
            this.rbOffice2007Silver.UseVisualStyleBackColor = true;
            this.rbOffice2007Silver.CheckedChanged += new System.EventHandler(this.rbOffice2007Silver_CheckedChanged);
            // 
            // rbSparklePurple
            // 
            this.rbSparklePurple.AutoSize = true;
            this.rbSparklePurple.Location = new System.Drawing.Point(301, 64);
            this.rbSparklePurple.Name = "rbSparklePurple";
            this.rbSparklePurple.Size = new System.Drawing.Size(119, 16);
            this.rbSparklePurple.TabIndex = 0;
            this.rbSparklePurple.Text = "Sparkle - Purple";
            this.rbSparklePurple.UseVisualStyleBackColor = true;
            this.rbSparklePurple.CheckedChanged += new System.EventHandler(this.rbSparklePurple_CheckedChanged);
            // 
            // rbSparkleOrange
            // 
            this.rbSparkleOrange.AutoSize = true;
            this.rbSparkleOrange.Location = new System.Drawing.Point(301, 42);
            this.rbSparkleOrange.Name = "rbSparkleOrange";
            this.rbSparkleOrange.Size = new System.Drawing.Size(119, 16);
            this.rbSparkleOrange.TabIndex = 0;
            this.rbSparkleOrange.Text = "Sparkle - Orange";
            this.rbSparkleOrange.UseVisualStyleBackColor = true;
            this.rbSparkleOrange.CheckedChanged += new System.EventHandler(this.rbSparkleOrange_CheckedChanged);
            // 
            // rbSystem
            // 
            this.rbSystem.AutoSize = true;
            this.rbSystem.Location = new System.Drawing.Point(438, 44);
            this.rbSystem.Name = "rbSystem";
            this.rbSystem.Size = new System.Drawing.Size(59, 16);
            this.rbSystem.TabIndex = 0;
            this.rbSystem.Text = "System";
            this.rbSystem.UseVisualStyleBackColor = true;
            this.rbSystem.CheckedChanged += new System.EventHandler(this.rbSystem_CheckedChanged);
            // 
            // rbOffice2003
            // 
            this.rbOffice2003.AutoSize = true;
            this.rbOffice2003.Location = new System.Drawing.Point(438, 21);
            this.rbOffice2003.Name = "rbOffice2003";
            this.rbOffice2003.Size = new System.Drawing.Size(89, 16);
            this.rbOffice2003.TabIndex = 0;
            this.rbOffice2003.Text = "Office 2003";
            this.rbOffice2003.UseVisualStyleBackColor = true;
            this.rbOffice2003.CheckedChanged += new System.EventHandler(this.rbOffice2003_CheckedChanged);
            // 
            // rbSparkleBlue
            // 
            this.rbSparkleBlue.AutoSize = true;
            this.rbSparkleBlue.Location = new System.Drawing.Point(302, 21);
            this.rbSparkleBlue.Name = "rbSparkleBlue";
            this.rbSparkleBlue.Size = new System.Drawing.Size(107, 16);
            this.rbSparkleBlue.TabIndex = 0;
            this.rbSparkleBlue.Text = "Sparkle - Blue";
            this.rbSparkleBlue.UseVisualStyleBackColor = true;
            this.rbSparkleBlue.CheckedChanged += new System.EventHandler(this.rbSparkleBlue_CheckedChanged);
            // 
            // rbOffice2007Blue
            // 
            this.rbOffice2007Blue.AutoSize = true;
            this.rbOffice2007Blue.Location = new System.Drawing.Point(154, 20);
            this.rbOffice2007Blue.Name = "rbOffice2007Blue";
            this.rbOffice2007Blue.Size = new System.Drawing.Size(131, 16);
            this.rbOffice2007Blue.TabIndex = 0;
            this.rbOffice2007Blue.Text = "Office 2007 - Blue";
            this.rbOffice2007Blue.UseVisualStyleBackColor = true;
            this.rbOffice2007Blue.CheckedChanged += new System.EventHandler(this.rbOffice2007Blue_CheckedChanged);
            // 
            // rbOffice2010Black
            // 
            this.rbOffice2010Black.AutoSize = true;
            this.rbOffice2010Black.Location = new System.Drawing.Point(6, 66);
            this.rbOffice2010Black.Name = "rbOffice2010Black";
            this.rbOffice2010Black.Size = new System.Drawing.Size(137, 16);
            this.rbOffice2010Black.TabIndex = 0;
            this.rbOffice2010Black.Text = "Office 2010 - Black";
            this.rbOffice2010Black.UseVisualStyleBackColor = true;
            this.rbOffice2010Black.CheckedChanged += new System.EventHandler(this.rbOffice2010Black_CheckedChanged);
            // 
            // rbOffice2010Silver
            // 
            this.rbOffice2010Silver.AutoSize = true;
            this.rbOffice2010Silver.Location = new System.Drawing.Point(7, 44);
            this.rbOffice2010Silver.Name = "rbOffice2010Silver";
            this.rbOffice2010Silver.Size = new System.Drawing.Size(143, 16);
            this.rbOffice2010Silver.TabIndex = 0;
            this.rbOffice2010Silver.Text = "Office 2010 - Silver";
            this.rbOffice2010Silver.UseVisualStyleBackColor = true;
            this.rbOffice2010Silver.CheckedChanged += new System.EventHandler(this.rbOffice2010Silver_CheckedChanged);
            // 
            // rbOffice2010Blue
            // 
            this.rbOffice2010Blue.AutoSize = true;
            this.rbOffice2010Blue.Checked = true;
            this.rbOffice2010Blue.Location = new System.Drawing.Point(7, 22);
            this.rbOffice2010Blue.Name = "rbOffice2010Blue";
            this.rbOffice2010Blue.Size = new System.Drawing.Size(131, 16);
            this.rbOffice2010Blue.TabIndex = 0;
            this.rbOffice2010Blue.TabStop = true;
            this.rbOffice2010Blue.Text = "Office 2010 - Blue";
            this.rbOffice2010Blue.UseVisualStyleBackColor = true;
            this.rbOffice2010Blue.CheckedChanged += new System.EventHandler(this.rbOffice2010Blue_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.propertyGrid);
            this.groupBox2.Location = new System.Drawing.Point(559, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 488);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Properties for KiwiMonthCalendar";
            // 
            // propertyGrid
            // 
            this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid.Location = new System.Drawing.Point(7, 21);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.SelectedObject = this.kiwiMonthCalendar1;
            this.propertyGrid.Size = new System.Drawing.Size(279, 462);
            this.propertyGrid.TabIndex = 0;
            this.propertyGrid.ToolbarVisible = false;
            // 
            // kiwiMonthCalendar1
            // 
            this.kiwiMonthCalendar1.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.kiwiMonthCalendar1.Location = new System.Drawing.Point(12, 12);
            this.kiwiMonthCalendar1.Name = "kiwiMonthCalendar1";
            this.kiwiMonthCalendar1.Palette = this.kiwiPalette;
            this.kiwiMonthCalendar1.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Custom;
            this.kiwiMonthCalendar1.Size = new System.Drawing.Size(230, 338);
            this.kiwiMonthCalendar1.TabIndex = 3;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(770, 506);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // kiwiManager1
            // 
            this.kiwiManager1.GlobalPalette = this.kiwiPalette;
            this.kiwiManager1.GlobalPaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteModeManager.Custom;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 536);
            this.Controls.Add(this.kiwiMonthCalendar1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "KiwiMonthCalendar Examples";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOffice2007Black;
        private System.Windows.Forms.RadioButton rbOffice2007Silver;
        private System.Windows.Forms.RadioButton rbSparklePurple;
        private System.Windows.Forms.RadioButton rbSparkleOrange;
        private System.Windows.Forms.RadioButton rbSystem;
        private System.Windows.Forms.RadioButton rbOffice2003;
        private System.Windows.Forms.RadioButton rbSparkleBlue;
        private System.Windows.Forms.RadioButton rbOffice2007Blue;
        private System.Windows.Forms.RadioButton rbOffice2010Black;
        private System.Windows.Forms.RadioButton rbOffice2010Silver;
        private System.Windows.Forms.RadioButton rbOffice2010Blue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.Button buttonClose;
        private Kiwi.ComponentFactory.Toolkit.KiwiMonthCalendar kiwiMonthCalendar1;
        private Kiwi.ComponentFactory.Toolkit.KiwiPalette kiwiPalette;
        private Kiwi.ComponentFactory.Toolkit.KiwiManager kiwiManager1;
    }
}

