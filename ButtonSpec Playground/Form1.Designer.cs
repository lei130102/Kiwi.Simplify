
namespace ButtonSpec_Playground
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
            this.groupBoxProperties = new System.Windows.Forms.GroupBox();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.buttonClose = new System.Windows.Forms.Button();
            this.kiwiHeaderGroup1 = new Kiwi.ComponentFactory.Toolkit.KiwiHeaderGroup();
            this.kiwiManager1 = new Kiwi.ComponentFactory.Toolkit.KiwiManager(this.components);
            this.kiwiButtonAdd = new Kiwi.ComponentFactory.Toolkit.KiwiButton();
            this.kiwiButtonRemove = new Kiwi.ComponentFactory.Toolkit.KiwiButton();
            this.kiwiButtonClear = new Kiwi.ComponentFactory.Toolkit.KiwiButton();
            this.groupBoxExample = new System.Windows.Forms.GroupBox();
            this.groupBoxButtonSpecs = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.groupBoxPrimary = new System.Windows.Forms.GroupBox();
            this.kiwiButtonBottomP = new Kiwi.ComponentFactory.Toolkit.KiwiButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kiwiButton1 = new Kiwi.ComponentFactory.Toolkit.KiwiButton();
            this.kiwiButton2 = new Kiwi.ComponentFactory.Toolkit.KiwiButton();
            this.kiwiButton3 = new Kiwi.ComponentFactory.Toolkit.KiwiButton();
            this.kiwiButtonTopP = new Kiwi.ComponentFactory.Toolkit.KiwiButton();
            this.kiwiButtonRightP = new Kiwi.ComponentFactory.Toolkit.KiwiButton();
            this.kiwiButtonLeftP = new Kiwi.ComponentFactory.Toolkit.KiwiButton();
            this.groupBoxSecondary = new System.Windows.Forms.GroupBox();
            this.kiwiButtonBottomS = new Kiwi.ComponentFactory.Toolkit.KiwiButton();
            this.kiwiButtonTopS = new Kiwi.ComponentFactory.Toolkit.KiwiButton();
            this.kiwiButtonRightS = new Kiwi.ComponentFactory.Toolkit.KiwiButton();
            this.kiwiButtonLeftS = new Kiwi.ComponentFactory.Toolkit.KiwiButton();
            this.groupBoxProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiHeaderGroup1.Panel)).BeginInit();
            this.kiwiHeaderGroup1.SuspendLayout();
            this.groupBoxExample.SuspendLayout();
            this.groupBoxButtonSpecs.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxPrimary.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxSecondary.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxProperties
            // 
            this.groupBoxProperties.Controls.Add(this.propertyGrid);
            this.groupBoxProperties.Location = new System.Drawing.Point(285, 12);
            this.groupBoxProperties.Name = "groupBoxProperties";
            this.groupBoxProperties.Size = new System.Drawing.Size(294, 436);
            this.groupBoxProperties.TabIndex = 2;
            this.groupBoxProperties.TabStop = false;
            this.groupBoxProperties.Text = "Properties for Selected ButtonSpec";
            // 
            // propertyGrid
            // 
            this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid.Location = new System.Drawing.Point(6, 19);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(282, 411);
            this.propertyGrid.TabIndex = 0;
            this.propertyGrid.ToolbarVisible = false;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(504, 454);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // kiwiHeaderGroup1
            // 
            this.kiwiHeaderGroup1.CollapseTarget = Kiwi.ComponentFactory.Toolkit.HeaderGroupCollapsedTarget.CollapsedToPrimary;
            this.kiwiHeaderGroup1.GroupBackStyle = Kiwi.ComponentFactory.Toolkit.PaletteBackStyle.ControlClient;
            this.kiwiHeaderGroup1.GroupBorderStyle = Kiwi.ComponentFactory.Toolkit.PaletteBorderStyle.ControlClient;
            this.kiwiHeaderGroup1.HeaderStylePrimary = Kiwi.ComponentFactory.Toolkit.HeaderStyle.Primary;
            this.kiwiHeaderGroup1.HeaderStyleSecondary = Kiwi.ComponentFactory.Toolkit.HeaderStyle.Secondary;
            this.kiwiHeaderGroup1.Location = new System.Drawing.Point(11, 23);
            this.kiwiHeaderGroup1.Name = "kiwiHeaderGroup1";
            this.kiwiHeaderGroup1.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Global;
            this.kiwiHeaderGroup1.Size = new System.Drawing.Size(246, 165);
            this.kiwiHeaderGroup1.TabIndex = 0;
            // 
            // kiwiManager1
            // 
            this.kiwiManager1.GlobalPaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteModeManager.Office2007Blue;
            // 
            // kiwiButtonAdd
            // 
            this.kiwiButtonAdd.AutoSize = true;
            this.kiwiButtonAdd.ButtonStyle = Kiwi.ComponentFactory.Toolkit.ButtonStyle.Standalone;
            this.kiwiButtonAdd.Location = new System.Drawing.Point(10, 25);
            this.kiwiButtonAdd.Name = "kiwiButtonAdd";
            this.kiwiButtonAdd.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Global;
            this.kiwiButtonAdd.Size = new System.Drawing.Size(65, 27);
            this.kiwiButtonAdd.TabIndex = 0;
            this.kiwiButtonAdd.Values.Text = "Add";
            this.kiwiButtonAdd.Click += new System.EventHandler(this.kiwiButtonAdd_Click);
            // 
            // kiwiButtonRemove
            // 
            this.kiwiButtonRemove.AutoSize = true;
            this.kiwiButtonRemove.ButtonStyle = Kiwi.ComponentFactory.Toolkit.ButtonStyle.Standalone;
            this.kiwiButtonRemove.Enabled = false;
            this.kiwiButtonRemove.Location = new System.Drawing.Point(11, 56);
            this.kiwiButtonRemove.Name = "kiwiButtonRemove";
            this.kiwiButtonRemove.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Global;
            this.kiwiButtonRemove.Size = new System.Drawing.Size(64, 27);
            this.kiwiButtonRemove.TabIndex = 1;
            this.kiwiButtonRemove.Values.Text = "Remove";
            this.kiwiButtonRemove.Click += new System.EventHandler(this.kiwiButtonRemove_Click);
            // 
            // kiwiButtonClear
            // 
            this.kiwiButtonClear.AutoSize = true;
            this.kiwiButtonClear.ButtonStyle = Kiwi.ComponentFactory.Toolkit.ButtonStyle.Standalone;
            this.kiwiButtonClear.Enabled = false;
            this.kiwiButtonClear.Location = new System.Drawing.Point(11, 87);
            this.kiwiButtonClear.Name = "kiwiButtonClear";
            this.kiwiButtonClear.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Global;
            this.kiwiButtonClear.Size = new System.Drawing.Size(64, 27);
            this.kiwiButtonClear.TabIndex = 2;
            this.kiwiButtonClear.Values.Text = "Clear";
            this.kiwiButtonClear.Click += new System.EventHandler(this.kiwiButtonClear_Click);
            // 
            // groupBoxExample
            // 
            this.groupBoxExample.Controls.Add(this.kiwiHeaderGroup1);
            this.groupBoxExample.Location = new System.Drawing.Point(12, 12);
            this.groupBoxExample.Name = "groupBoxExample";
            this.groupBoxExample.Size = new System.Drawing.Size(267, 198);
            this.groupBoxExample.TabIndex = 0;
            this.groupBoxExample.TabStop = false;
            this.groupBoxExample.Text = "Example HeaderGroup";
            // 
            // groupBoxButtonSpecs
            // 
            this.groupBoxButtonSpecs.Controls.Add(this.kiwiButtonAdd);
            this.groupBoxButtonSpecs.Controls.Add(this.kiwiButtonClear);
            this.groupBoxButtonSpecs.Controls.Add(this.kiwiButtonRemove);
            this.groupBoxButtonSpecs.Location = new System.Drawing.Point(12, 216);
            this.groupBoxButtonSpecs.Name = "groupBoxButtonSpecs";
            this.groupBoxButtonSpecs.Size = new System.Drawing.Size(85, 154);
            this.groupBoxButtonSpecs.TabIndex = 1;
            this.groupBoxButtonSpecs.TabStop = false;
            this.groupBoxButtonSpecs.Text = "ButtonSpec";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelInstructions);
            this.groupBox1.Location = new System.Drawing.Point(11, 376);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 72);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instructions";
            // 
            // labelInstructions
            // 
            this.labelInstructions.Location = new System.Drawing.Point(8, 20);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(250, 50);
            this.labelInstructions.TabIndex = 0;
            this.labelInstructions.Text = "Use the Add/Remove buttons to create/delete ButtonSpec instances.  Click the butt" +
                "on in order to display its properties in the property window.";
            // 
            // groupBoxPrimary
            // 
            this.groupBoxPrimary.Controls.Add(this.kiwiButtonBottomP);
            this.groupBoxPrimary.Controls.Add(this.groupBox2);
            this.groupBoxPrimary.Controls.Add(this.kiwiButtonTopP);
            this.groupBoxPrimary.Controls.Add(this.kiwiButtonRightP);
            this.groupBoxPrimary.Controls.Add(this.kiwiButtonLeftP);
            this.groupBoxPrimary.Location = new System.Drawing.Point(103, 216);
            this.groupBoxPrimary.Name = "groupBoxPrimary";
            this.groupBoxPrimary.Size = new System.Drawing.Size(85, 154);
            this.groupBoxPrimary.TabIndex = 3;
            this.groupBoxPrimary.TabStop = false;
            this.groupBoxPrimary.Text = "Primary";
            // 
            // kiwiButtonBottomP
            // 
            this.kiwiButtonBottomP.AutoSize = true;
            this.kiwiButtonBottomP.ButtonStyle = Kiwi.ComponentFactory.Toolkit.ButtonStyle.Standalone;
            this.kiwiButtonBottomP.Location = new System.Drawing.Point(11, 118);
            this.kiwiButtonBottomP.Name = "kiwiButtonBottomP";
            this.kiwiButtonBottomP.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Global;
            this.kiwiButtonBottomP.Size = new System.Drawing.Size(64, 27);
            this.kiwiButtonBottomP.TabIndex = 5;
            this.kiwiButtonBottomP.Values.Text = "Bottom";
            this.kiwiButtonBottomP.Click += new System.EventHandler(this.kiwiButtonBottomP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kiwiButton1);
            this.groupBox2.Controls.Add(this.kiwiButton2);
            this.groupBox2.Controls.Add(this.kiwiButton3);
            this.groupBox2.Location = new System.Drawing.Point(96, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(90, 130);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Primary";
            // 
            // kiwiButton1
            // 
            this.kiwiButton1.AutoSize = true;
            this.kiwiButton1.ButtonStyle = Kiwi.ComponentFactory.Toolkit.ButtonStyle.Standalone;
            this.kiwiButton1.Location = new System.Drawing.Point(10, 28);
            this.kiwiButton1.Name = "kiwiButton1";
            this.kiwiButton1.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Global;
            this.kiwiButton1.Size = new System.Drawing.Size(65, 27);
            this.kiwiButton1.TabIndex = 0;
            this.kiwiButton1.Values.Text = "Top";
            // 
            // kiwiButton2
            // 
            this.kiwiButton2.AutoSize = true;
            this.kiwiButton2.ButtonStyle = Kiwi.ComponentFactory.Toolkit.ButtonStyle.Standalone;
            this.kiwiButton2.Enabled = false;
            this.kiwiButton2.Location = new System.Drawing.Point(11, 90);
            this.kiwiButton2.Name = "kiwiButton2";
            this.kiwiButton2.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Global;
            this.kiwiButton2.Size = new System.Drawing.Size(64, 27);
            this.kiwiButton2.TabIndex = 2;
            this.kiwiButton2.Values.Text = "Right";
            // 
            // kiwiButton3
            // 
            this.kiwiButton3.AutoSize = true;
            this.kiwiButton3.ButtonStyle = Kiwi.ComponentFactory.Toolkit.ButtonStyle.Standalone;
            this.kiwiButton3.Enabled = false;
            this.kiwiButton3.Location = new System.Drawing.Point(11, 59);
            this.kiwiButton3.Name = "kiwiButton3";
            this.kiwiButton3.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Global;
            this.kiwiButton3.Size = new System.Drawing.Size(64, 27);
            this.kiwiButton3.TabIndex = 1;
            this.kiwiButton3.Values.Text = "Left";
            // 
            // kiwiButtonTopP
            // 
            this.kiwiButtonTopP.AutoSize = true;
            this.kiwiButtonTopP.ButtonStyle = Kiwi.ComponentFactory.Toolkit.ButtonStyle.Standalone;
            this.kiwiButtonTopP.Location = new System.Drawing.Point(10, 25);
            this.kiwiButtonTopP.Name = "kiwiButtonTopP";
            this.kiwiButtonTopP.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Global;
            this.kiwiButtonTopP.Size = new System.Drawing.Size(65, 27);
            this.kiwiButtonTopP.TabIndex = 0;
            this.kiwiButtonTopP.Values.Text = "Top";
            this.kiwiButtonTopP.Click += new System.EventHandler(this.kiwiButtonTopP_Click);
            // 
            // kiwiButtonRightP
            // 
            this.kiwiButtonRightP.AutoSize = true;
            this.kiwiButtonRightP.ButtonStyle = Kiwi.ComponentFactory.Toolkit.ButtonStyle.Standalone;
            this.kiwiButtonRightP.Location = new System.Drawing.Point(11, 87);
            this.kiwiButtonRightP.Name = "kiwiButtonRightP";
            this.kiwiButtonRightP.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Global;
            this.kiwiButtonRightP.Size = new System.Drawing.Size(64, 27);
            this.kiwiButtonRightP.TabIndex = 2;
            this.kiwiButtonRightP.Values.Text = "Right";
            this.kiwiButtonRightP.Click += new System.EventHandler(this.kiwiButtonRightP_Click);
            // 
            // kiwiButtonLeftP
            // 
            this.kiwiButtonLeftP.AutoSize = true;
            this.kiwiButtonLeftP.ButtonStyle = Kiwi.ComponentFactory.Toolkit.ButtonStyle.Standalone;
            this.kiwiButtonLeftP.Location = new System.Drawing.Point(11, 56);
            this.kiwiButtonLeftP.Name = "kiwiButtonLeftP";
            this.kiwiButtonLeftP.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Global;
            this.kiwiButtonLeftP.Size = new System.Drawing.Size(64, 27);
            this.kiwiButtonLeftP.TabIndex = 1;
            this.kiwiButtonLeftP.Values.Text = "Left";
            this.kiwiButtonLeftP.Click += new System.EventHandler(this.kiwiButtonLeftP_Click);
            // 
            // groupBoxSecondary
            // 
            this.groupBoxSecondary.Controls.Add(this.kiwiButtonBottomS);
            this.groupBoxSecondary.Controls.Add(this.kiwiButtonTopS);
            this.groupBoxSecondary.Controls.Add(this.kiwiButtonRightS);
            this.groupBoxSecondary.Controls.Add(this.kiwiButtonLeftS);
            this.groupBoxSecondary.Location = new System.Drawing.Point(194, 216);
            this.groupBoxSecondary.Name = "groupBoxSecondary";
            this.groupBoxSecondary.Size = new System.Drawing.Size(85, 154);
            this.groupBoxSecondary.TabIndex = 5;
            this.groupBoxSecondary.TabStop = false;
            this.groupBoxSecondary.Text = "Secondary";
            // 
            // kiwiButtonBottomS
            // 
            this.kiwiButtonBottomS.AutoSize = true;
            this.kiwiButtonBottomS.ButtonStyle = Kiwi.ComponentFactory.Toolkit.ButtonStyle.Standalone;
            this.kiwiButtonBottomS.Location = new System.Drawing.Point(11, 118);
            this.kiwiButtonBottomS.Name = "kiwiButtonBottomS";
            this.kiwiButtonBottomS.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Global;
            this.kiwiButtonBottomS.Size = new System.Drawing.Size(64, 27);
            this.kiwiButtonBottomS.TabIndex = 6;
            this.kiwiButtonBottomS.Values.Text = "Bottom";
            this.kiwiButtonBottomS.Click += new System.EventHandler(this.kiwiButtonBottomS_Click);
            // 
            // kiwiButtonTopS
            // 
            this.kiwiButtonTopS.AutoSize = true;
            this.kiwiButtonTopS.ButtonStyle = Kiwi.ComponentFactory.Toolkit.ButtonStyle.Standalone;
            this.kiwiButtonTopS.Location = new System.Drawing.Point(10, 25);
            this.kiwiButtonTopS.Name = "kiwiButtonTopS";
            this.kiwiButtonTopS.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Global;
            this.kiwiButtonTopS.Size = new System.Drawing.Size(65, 27);
            this.kiwiButtonTopS.TabIndex = 0;
            this.kiwiButtonTopS.Values.Text = "Top";
            this.kiwiButtonTopS.Click += new System.EventHandler(this.kiwiButtonTopS_Click);
            // 
            // kiwiButtonRightS
            // 
            this.kiwiButtonRightS.AutoSize = true;
            this.kiwiButtonRightS.ButtonStyle = Kiwi.ComponentFactory.Toolkit.ButtonStyle.Standalone;
            this.kiwiButtonRightS.Location = new System.Drawing.Point(11, 87);
            this.kiwiButtonRightS.Name = "kiwiButtonRightS";
            this.kiwiButtonRightS.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Global;
            this.kiwiButtonRightS.Size = new System.Drawing.Size(64, 27);
            this.kiwiButtonRightS.TabIndex = 2;
            this.kiwiButtonRightS.Values.Text = "Right";
            this.kiwiButtonRightS.Click += new System.EventHandler(this.kiwiButtonRightS_Click);
            // 
            // kiwiButtonLeftS
            // 
            this.kiwiButtonLeftS.AutoSize = true;
            this.kiwiButtonLeftS.ButtonStyle = Kiwi.ComponentFactory.Toolkit.ButtonStyle.Standalone;
            this.kiwiButtonLeftS.Location = new System.Drawing.Point(11, 56);
            this.kiwiButtonLeftS.Name = "kiwiButtonLeftS";
            this.kiwiButtonLeftS.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Global;
            this.kiwiButtonLeftS.Size = new System.Drawing.Size(64, 27);
            this.kiwiButtonLeftS.TabIndex = 1;
            this.kiwiButtonLeftS.Values.Text = "Left";
            this.kiwiButtonLeftS.Click += new System.EventHandler(this.kiwiButtonLeftS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 485);
            this.Controls.Add(this.groupBoxSecondary);
            this.Controls.Add(this.groupBoxPrimary);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxButtonSpecs);
            this.Controls.Add(this.groupBoxExample);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxProperties);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "ButtonSpec Playground";
            this.groupBoxProperties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiHeaderGroup1.Panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiHeaderGroup1)).EndInit();
            this.kiwiHeaderGroup1.ResumeLayout(false);
            this.groupBoxExample.ResumeLayout(false);
            this.groupBoxButtonSpecs.ResumeLayout(false);
            this.groupBoxButtonSpecs.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxPrimary.ResumeLayout(false);
            this.groupBoxPrimary.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxSecondary.ResumeLayout(false);
            this.groupBoxSecondary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProperties;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.Button buttonClose;
        private Kiwi.ComponentFactory.Toolkit.KiwiHeaderGroup kiwiHeaderGroup1;
        private Kiwi.ComponentFactory.Toolkit.KiwiManager kiwiManager1;
        private Kiwi.ComponentFactory.Toolkit.KiwiButton kiwiButtonAdd;
        private Kiwi.ComponentFactory.Toolkit.KiwiButton kiwiButtonRemove;
        private Kiwi.ComponentFactory.Toolkit.KiwiButton kiwiButtonClear;
        private System.Windows.Forms.GroupBox groupBoxExample;
        private System.Windows.Forms.GroupBox groupBoxButtonSpecs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.GroupBox groupBoxPrimary;
        private System.Windows.Forms.GroupBox groupBox2;
        private Kiwi.ComponentFactory.Toolkit.KiwiButton kiwiButton1;
        private Kiwi.ComponentFactory.Toolkit.KiwiButton kiwiButton2;
        private Kiwi.ComponentFactory.Toolkit.KiwiButton kiwiButton3;
        private Kiwi.ComponentFactory.Toolkit.KiwiButton kiwiButtonTopP;
        private Kiwi.ComponentFactory.Toolkit.KiwiButton kiwiButtonRightP;
        private Kiwi.ComponentFactory.Toolkit.KiwiButton kiwiButtonLeftP;
        private Kiwi.ComponentFactory.Toolkit.KiwiButton kiwiButtonBottomP;
        private System.Windows.Forms.GroupBox groupBoxSecondary;
        private Kiwi.ComponentFactory.Toolkit.KiwiButton kiwiButtonBottomS;
        private Kiwi.ComponentFactory.Toolkit.KiwiButton kiwiButtonTopS;
        private Kiwi.ComponentFactory.Toolkit.KiwiButton kiwiButtonRightS;
        private Kiwi.ComponentFactory.Toolkit.KiwiButton kiwiButtonLeftS;
    }
}

