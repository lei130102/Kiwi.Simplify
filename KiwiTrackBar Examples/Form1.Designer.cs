
namespace KiwiTrackBar_Examples
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
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kiwiTrackBar4 = new Kiwi.ComponentFactory.Toolkit.KiwiTrackBar();
            this.kiwiTrackBar3 = new Kiwi.ComponentFactory.Toolkit.KiwiTrackBar();
            this.kiwiTrackBar2 = new Kiwi.ComponentFactory.Toolkit.KiwiTrackBar();
            this.kiwiTrackBar1 = new Kiwi.ComponentFactory.Toolkit.KiwiTrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kiwiTrackBar11 = new Kiwi.ComponentFactory.Toolkit.KiwiTrackBar();
            this.kiwiTrackBar10 = new Kiwi.ComponentFactory.Toolkit.KiwiTrackBar();
            this.kiwiTrackBar9 = new Kiwi.ComponentFactory.Toolkit.KiwiTrackBar();
            this.kiwiTrackBar5 = new Kiwi.ComponentFactory.Toolkit.KiwiTrackBar();
            this.kiwiTrackBar6 = new Kiwi.ComponentFactory.Toolkit.KiwiTrackBar();
            this.kiwiTrackBar7 = new Kiwi.ComponentFactory.Toolkit.KiwiTrackBar();
            this.kiwiTrackBar8 = new Kiwi.ComponentFactory.Toolkit.KiwiTrackBar();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // propertyGrid
            // 
            this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid.Location = new System.Drawing.Point(6, 19);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(310, 364);
            this.propertyGrid.TabIndex = 0;
            this.propertyGrid.ToolbarVisible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.propertyGrid);
            this.groupBox4.Location = new System.Drawing.Point(297, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(322, 389);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Properties for Selected KiwiTrackBar";
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(544, 407);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kiwiTrackBar4);
            this.groupBox1.Controls.Add(this.kiwiTrackBar3);
            this.groupBox1.Controls.Add(this.kiwiTrackBar2);
            this.groupBox1.Controls.Add(this.kiwiTrackBar1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orientation = Horizontal";
            // 
            // kiwiTrackBar4
            // 
            this.kiwiTrackBar4.DrawBackground = true;
            this.kiwiTrackBar4.Location = new System.Drawing.Point(15, 148);
            this.kiwiTrackBar4.Name = "kiwiTrackBar4";
            this.kiwiTrackBar4.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalSystem;
            this.kiwiTrackBar4.Size = new System.Drawing.Size(250, 27);
            this.kiwiTrackBar4.TabIndex = 3;
            this.kiwiTrackBar4.TickStyle = System.Windows.Forms.TickStyle.None;
            this.kiwiTrackBar4.TrackBarSize = Kiwi.ComponentFactory.Toolkit.PaletteTrackBarSize.Large;
            this.kiwiTrackBar4.Value = 7;
            this.kiwiTrackBar4.VolumeControl = true;
            this.kiwiTrackBar4.Enter += new System.EventHandler(this.trackBar_Enter);
            // 
            // kiwiTrackBar3
            // 
            this.kiwiTrackBar3.DrawBackground = true;
            this.kiwiTrackBar3.Location = new System.Drawing.Point(15, 97);
            this.kiwiTrackBar3.Maximum = 30;
            this.kiwiTrackBar3.Name = "kiwiTrackBar3";
            this.kiwiTrackBar3.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.SparkleBlue;
            this.kiwiTrackBar3.Size = new System.Drawing.Size(250, 41);
            this.kiwiTrackBar3.TabIndex = 2;
            this.kiwiTrackBar3.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.kiwiTrackBar3.TrackBarSize = Kiwi.ComponentFactory.Toolkit.PaletteTrackBarSize.Large;
            this.kiwiTrackBar3.Value = 15;
            this.kiwiTrackBar3.Enter += new System.EventHandler(this.trackBar_Enter);
            // 
            // kiwiTrackBar2
            // 
            this.kiwiTrackBar2.DrawBackground = true;
            this.kiwiTrackBar2.Location = new System.Drawing.Point(15, 60);
            this.kiwiTrackBar2.Maximum = 20;
            this.kiwiTrackBar2.Name = "kiwiTrackBar2";
            this.kiwiTrackBar2.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2007Blue;
            this.kiwiTrackBar2.Size = new System.Drawing.Size(250, 27);
            this.kiwiTrackBar2.TabIndex = 1;
            this.kiwiTrackBar2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.kiwiTrackBar2.Value = 5;
            this.kiwiTrackBar2.Enter += new System.EventHandler(this.trackBar_Enter);
            // 
            // kiwiTrackBar1
            // 
            this.kiwiTrackBar1.DrawBackground = true;
            this.kiwiTrackBar1.Location = new System.Drawing.Point(15, 30);
            this.kiwiTrackBar1.Name = "kiwiTrackBar1";
            this.kiwiTrackBar1.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2010Blue;
            this.kiwiTrackBar1.Size = new System.Drawing.Size(250, 20);
            this.kiwiTrackBar1.TabIndex = 0;
            this.kiwiTrackBar1.TrackBarSize = Kiwi.ComponentFactory.Toolkit.PaletteTrackBarSize.Small;
            this.kiwiTrackBar1.Value = 1;
            this.kiwiTrackBar1.Enter += new System.EventHandler(this.trackBar_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kiwiTrackBar11);
            this.groupBox2.Controls.Add(this.kiwiTrackBar10);
            this.groupBox2.Controls.Add(this.kiwiTrackBar9);
            this.groupBox2.Controls.Add(this.kiwiTrackBar5);
            this.groupBox2.Controls.Add(this.kiwiTrackBar6);
            this.groupBox2.Controls.Add(this.kiwiTrackBar7);
            this.groupBox2.Controls.Add(this.kiwiTrackBar8);
            this.groupBox2.Location = new System.Drawing.Point(12, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 198);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Orientation = Vertical";
            // 
            // kiwiTrackBar11
            // 
            this.kiwiTrackBar11.DrawBackground = true;
            this.kiwiTrackBar11.Location = new System.Drawing.Point(141, 28);
            this.kiwiTrackBar11.Maximum = 20;
            this.kiwiTrackBar11.Name = "kiwiTrackBar11";
            this.kiwiTrackBar11.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.kiwiTrackBar11.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2007Silver;
            this.kiwiTrackBar11.Size = new System.Drawing.Size(27, 159);
            this.kiwiTrackBar11.TabIndex = 4;
            this.kiwiTrackBar11.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.kiwiTrackBar11.Value = 5;
            this.kiwiTrackBar11.Enter += new System.EventHandler(this.trackBar_Enter);
            // 
            // kiwiTrackBar10
            // 
            this.kiwiTrackBar10.DrawBackground = true;
            this.kiwiTrackBar10.Location = new System.Drawing.Point(74, 28);
            this.kiwiTrackBar10.Name = "kiwiTrackBar10";
            this.kiwiTrackBar10.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.kiwiTrackBar10.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2010Black;
            this.kiwiTrackBar10.Size = new System.Drawing.Size(20, 159);
            this.kiwiTrackBar10.TabIndex = 2;
            this.kiwiTrackBar10.TrackBarSize = Kiwi.ComponentFactory.Toolkit.PaletteTrackBarSize.Small;
            this.kiwiTrackBar10.Value = 1;
            this.kiwiTrackBar10.Enter += new System.EventHandler(this.trackBar_Enter);
            // 
            // kiwiTrackBar9
            // 
            this.kiwiTrackBar9.DrawBackground = true;
            this.kiwiTrackBar9.Location = new System.Drawing.Point(44, 28);
            this.kiwiTrackBar9.Name = "kiwiTrackBar9";
            this.kiwiTrackBar9.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.kiwiTrackBar9.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2010Silver;
            this.kiwiTrackBar9.Size = new System.Drawing.Size(20, 159);
            this.kiwiTrackBar9.TabIndex = 1;
            this.kiwiTrackBar9.TrackBarSize = Kiwi.ComponentFactory.Toolkit.PaletteTrackBarSize.Small;
            this.kiwiTrackBar9.Value = 1;
            this.kiwiTrackBar9.Enter += new System.EventHandler(this.trackBar_Enter);
            // 
            // kiwiTrackBar5
            // 
            this.kiwiTrackBar5.DrawBackground = true;
            this.kiwiTrackBar5.Location = new System.Drawing.Point(238, 28);
            this.kiwiTrackBar5.Name = "kiwiTrackBar5";
            this.kiwiTrackBar5.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.kiwiTrackBar5.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalSystem;
            this.kiwiTrackBar5.Size = new System.Drawing.Size(27, 159);
            this.kiwiTrackBar5.TabIndex = 7;
            this.kiwiTrackBar5.TickStyle = System.Windows.Forms.TickStyle.None;
            this.kiwiTrackBar5.TrackBarSize = Kiwi.ComponentFactory.Toolkit.PaletteTrackBarSize.Large;
            this.kiwiTrackBar5.UseWaitCursor = true;
            this.kiwiTrackBar5.Value = 7;
            this.kiwiTrackBar5.VolumeControl = true;
            this.kiwiTrackBar5.Enter += new System.EventHandler(this.trackBar_Enter);
            // 
            // kiwiTrackBar6
            // 
            this.kiwiTrackBar6.DrawBackground = true;
            this.kiwiTrackBar6.Location = new System.Drawing.Point(182, 28);
            this.kiwiTrackBar6.Maximum = 20;
            this.kiwiTrackBar6.Name = "kiwiTrackBar6";
            this.kiwiTrackBar6.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.kiwiTrackBar6.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.SparkleBlue;
            this.kiwiTrackBar6.Size = new System.Drawing.Size(41, 159);
            this.kiwiTrackBar6.TabIndex = 6;
            this.kiwiTrackBar6.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.kiwiTrackBar6.TrackBarSize = Kiwi.ComponentFactory.Toolkit.PaletteTrackBarSize.Large;
            this.kiwiTrackBar6.Value = 10;
            this.kiwiTrackBar6.Enter += new System.EventHandler(this.trackBar_Enter);
            // 
            // kiwiTrackBar7
            // 
            this.kiwiTrackBar7.DrawBackground = true;
            this.kiwiTrackBar7.Location = new System.Drawing.Point(105, 28);
            this.kiwiTrackBar7.Maximum = 20;
            this.kiwiTrackBar7.Name = "kiwiTrackBar7";
            this.kiwiTrackBar7.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.kiwiTrackBar7.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2007Blue;
            this.kiwiTrackBar7.Size = new System.Drawing.Size(27, 159);
            this.kiwiTrackBar7.TabIndex = 3;
            this.kiwiTrackBar7.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.kiwiTrackBar7.Value = 5;
            this.kiwiTrackBar7.Enter += new System.EventHandler(this.trackBar_Enter);
            // 
            // kiwiTrackBar8
            // 
            this.kiwiTrackBar8.DrawBackground = true;
            this.kiwiTrackBar8.Location = new System.Drawing.Point(14, 28);
            this.kiwiTrackBar8.Name = "kiwiTrackBar8";
            this.kiwiTrackBar8.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.kiwiTrackBar8.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2010Blue;
            this.kiwiTrackBar8.Size = new System.Drawing.Size(20, 159);
            this.kiwiTrackBar8.TabIndex = 0;
            this.kiwiTrackBar8.TrackBarSize = Kiwi.ComponentFactory.Toolkit.PaletteTrackBarSize.Small;
            this.kiwiTrackBar8.Value = 1;
            this.kiwiTrackBar8.Enter += new System.EventHandler(this.trackBar_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 438);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "KiwiTrackBar Examples";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private Kiwi.ComponentFactory.Toolkit.KiwiTrackBar kiwiTrackBar4;
        private Kiwi.ComponentFactory.Toolkit.KiwiTrackBar kiwiTrackBar3;
        private Kiwi.ComponentFactory.Toolkit.KiwiTrackBar kiwiTrackBar2;
        private Kiwi.ComponentFactory.Toolkit.KiwiTrackBar kiwiTrackBar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Kiwi.ComponentFactory.Toolkit.KiwiTrackBar kiwiTrackBar11;
        private Kiwi.ComponentFactory.Toolkit.KiwiTrackBar kiwiTrackBar10;
        private Kiwi.ComponentFactory.Toolkit.KiwiTrackBar kiwiTrackBar9;
        private Kiwi.ComponentFactory.Toolkit.KiwiTrackBar kiwiTrackBar5;
        private Kiwi.ComponentFactory.Toolkit.KiwiTrackBar kiwiTrackBar6;
        private Kiwi.ComponentFactory.Toolkit.KiwiTrackBar kiwiTrackBar7;
        private Kiwi.ComponentFactory.Toolkit.KiwiTrackBar kiwiTrackBar8;
    }
}

