
namespace KiwiListBox_Examples
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.kiwiListBox = new Kiwi.ComponentFactory.Toolkit.KiwiListBox();
            this.buttonAppend = new Kiwi.ComponentFactory.Toolkit.KiwiButton();
            this.buttonClear = new Kiwi.ComponentFactory.Toolkit.KiwiButton();
            this.buttonRemove = new Kiwi.ComponentFactory.Toolkit.KiwiButton();
            this.buttonInsert = new Kiwi.ComponentFactory.Toolkit.KiwiButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkSystem = new Kiwi.ComponentFactory.Toolkit.KiwiCheckButton();
            this.checkSparkle = new Kiwi.ComponentFactory.Toolkit.KiwiCheckButton();
            this.check2010Blue = new Kiwi.ComponentFactory.Toolkit.KiwiCheckButton();
            this.check2007Blue = new Kiwi.ComponentFactory.Toolkit.KiwiCheckButton();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.kiwiCheckSet = new Kiwi.ComponentFactory.Toolkit.KiwiCheckSet(this.components);
            this.kiwiManager1 = new Kiwi.ComponentFactory.Toolkit.KiwiManager(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiCheckSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(493, 408);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.propertyGrid);
            this.groupBox3.Location = new System.Drawing.Point(273, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(295, 390);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Properties for KiwiListBox";
            // 
            // propertyGrid
            // 
            this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid.Location = new System.Drawing.Point(6, 19);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(283, 365);
            this.propertyGrid.TabIndex = 0;
            this.propertyGrid.ToolbarVisible = false;
            // 
            // kiwiListBox
            // 
            this.kiwiListBox.Location = new System.Drawing.Point(23, 24);
            this.kiwiListBox.Name = "kiwiListBox";
            this.kiwiListBox.Size = new System.Drawing.Size(227, 192);
            this.kiwiListBox.TabIndex = 0;
            this.kiwiListBox.SelectedIndexChanged += new System.EventHandler(this.kiwiListBox_SelectedIndexChanged);
            // 
            // buttonAppend
            // 
            this.buttonAppend.AutoSize = true;
            this.buttonAppend.Location = new System.Drawing.Point(19, 30);
            this.buttonAppend.Name = "buttonAppend";
            this.buttonAppend.Size = new System.Drawing.Size(90, 25);
            this.buttonAppend.TabIndex = 0;
            this.buttonAppend.Values.Text = "Append";
            this.buttonAppend.Click += new System.EventHandler(this.buttonAppend_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.AutoSize = true;
            this.buttonClear.Location = new System.Drawing.Point(19, 126);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(90, 25);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Values.Text = "Clear";
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.AutoSize = true;
            this.buttonRemove.Location = new System.Drawing.Point(19, 94);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(90, 25);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Values.Text = "Remove";
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.AutoSize = true;
            this.buttonInsert.Location = new System.Drawing.Point(19, 62);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(90, 25);
            this.buttonInsert.TabIndex = 1;
            this.buttonInsert.Values.Text = "Insert";
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkSystem);
            this.groupBox1.Controls.Add(this.checkSparkle);
            this.groupBox1.Controls.Add(this.check2010Blue);
            this.groupBox1.Controls.Add(this.check2007Blue);
            this.groupBox1.Controls.Add(this.buttonAppend);
            this.groupBox1.Controls.Add(this.buttonInsert);
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.buttonRemove);
            this.groupBox1.Location = new System.Drawing.Point(12, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 168);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // checkSystem
            // 
            this.checkSystem.AutoSize = true;
            this.checkSystem.Location = new System.Drawing.Point(125, 126);
            this.checkSystem.Name = "checkSystem";
            this.checkSystem.Size = new System.Drawing.Size(113, 25);
            this.checkSystem.TabIndex = 7;
            this.checkSystem.Values.Text = "System";
            // 
            // checkSparkle
            // 
            this.checkSparkle.AutoSize = true;
            this.checkSparkle.Location = new System.Drawing.Point(125, 93);
            this.checkSparkle.Name = "checkSparkle";
            this.checkSparkle.Size = new System.Drawing.Size(113, 25);
            this.checkSparkle.TabIndex = 6;
            this.checkSparkle.Values.Text = "Sparkle - Blue";
            // 
            // check2010Blue
            // 
            this.check2010Blue.AutoSize = true;
            this.check2010Blue.Checked = true;
            this.check2010Blue.Location = new System.Drawing.Point(125, 31);
            this.check2010Blue.Name = "check2010Blue";
            this.check2010Blue.Size = new System.Drawing.Size(113, 25);
            this.check2010Blue.TabIndex = 5;
            this.check2010Blue.Values.Text = "Office 2010 - Black";
            // 
            // check2007Blue
            // 
            this.check2007Blue.AutoSize = true;
            this.check2007Blue.Location = new System.Drawing.Point(125, 62);
            this.check2007Blue.Name = "check2007Blue";
            this.check2007Blue.Size = new System.Drawing.Size(113, 25);
            this.check2007Blue.TabIndex = 4;
            this.check2007Blue.Values.Text = "Office 2007 - Blue";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "document_plain.png");
            this.imageList.Images.SetKeyName(1, "document_plain_blue.png");
            this.imageList.Images.SetKeyName(2, "document_plain_green.png");
            this.imageList.Images.SetKeyName(3, "document_plain_red.png");
            this.imageList.Images.SetKeyName(4, "document_plain_yellow.png");
            this.imageList.Images.SetKeyName(5, "star_blue.png");
            this.imageList.Images.SetKeyName(6, "star_green.png");
            this.imageList.Images.SetKeyName(7, "star_grey.png");
            this.imageList.Images.SetKeyName(8, "star_red.png");
            this.imageList.Images.SetKeyName(9, "star_yellow.png");
            this.imageList.Images.SetKeyName(10, "telephone.png");
            this.imageList.Images.SetKeyName(11, "telephone2.png");
            this.imageList.Images.SetKeyName(12, "thought.png");
            this.imageList.Images.SetKeyName(13, "alarmclock.png");
            this.imageList.Images.SetKeyName(14, "apple.png");
            this.imageList.Images.SetKeyName(15, "banana.png");
            this.imageList.Images.SetKeyName(16, "basketball.png");
            this.imageList.Images.SetKeyName(17, "binocular.png");
            this.imageList.Images.SetKeyName(18, "clock2.png");
            // 
            // kiwiCheckSet
            // 
            this.kiwiCheckSet.CheckButtons.Add(this.check2007Blue);
            this.kiwiCheckSet.CheckButtons.Add(this.check2010Blue);
            this.kiwiCheckSet.CheckButtons.Add(this.checkSparkle);
            this.kiwiCheckSet.CheckButtons.Add(this.checkSystem);
            this.kiwiCheckSet.CheckedButton = this.check2010Blue;
            this.kiwiCheckSet.CheckedButtonChanged += new System.EventHandler(this.kiwiCheckSet_CheckedButtonChanged);
            // 
            // kiwiManager1
            // 
            this.kiwiManager1.GlobalPaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteModeManager.Office2007Blue;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 438);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kiwiListBox);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "KiwiListBox Examples";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiCheckSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private Kiwi.ComponentFactory.Toolkit.KiwiListBox kiwiListBox;
        private Kiwi.ComponentFactory.Toolkit.KiwiButton buttonAppend;
        private Kiwi.ComponentFactory.Toolkit.KiwiButton buttonClear;
        private Kiwi.ComponentFactory.Toolkit.KiwiButton buttonRemove;
        private Kiwi.ComponentFactory.Toolkit.KiwiButton buttonInsert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList imageList;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckButton checkSystem;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckButton checkSparkle;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckButton check2010Blue;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckButton check2007Blue;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckSet kiwiCheckSet;
        private Kiwi.ComponentFactory.Toolkit.KiwiManager kiwiManager1;
    }
}

