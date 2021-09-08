
namespace KiwiCommand_Examples
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
            this.groupBoxProperties = new System.Windows.Forms.GroupBox();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.kiwiCommand = new Kiwi.ComponentFactory.Toolkit.KiwiCommand();
            this.groupBoxControls = new System.Windows.Forms.GroupBox();
            this.kiwiDropButton1 = new Kiwi.ComponentFactory.Toolkit.KiwiDropButton();
            this.kiwiHeader1 = new Kiwi.ComponentFactory.Toolkit.KiwiHeader();
            this.buttonSpecAny1 = new Kiwi.ComponentFactory.Toolkit.ButtonSpecAny();
            this.kiwiColorButton1 = new Kiwi.ComponentFactory.Toolkit.KiwiColorButton();
            this.kiwiLinkLabel1 = new Kiwi.ComponentFactory.Toolkit.KiwiLinkLabel();
            this.kiwiLabel1 = new Kiwi.ComponentFactory.Toolkit.KiwiLabel();
            this.kiwiCheckBox1 = new Kiwi.ComponentFactory.Toolkit.KiwiCheckBox();
            this.kiwiCheckButton1 = new Kiwi.ComponentFactory.Toolkit.KiwiCheckButton();
            this.kiwiButton1 = new Kiwi.ComponentFactory.Toolkit.KiwiButton();
            this.buttonAttach = new System.Windows.Forms.Button();
            this.buttonUnattach = new System.Windows.Forms.Button();
            this.groupBoxProperties.SuspendLayout();
            this.groupBoxControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(360, 514);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 26);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBoxProperties
            // 
            this.groupBoxProperties.Controls.Add(this.propertyGrid);
            this.groupBoxProperties.Location = new System.Drawing.Point(13, 13);
            this.groupBoxProperties.Name = "groupBoxProperties";
            this.groupBoxProperties.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxProperties.Size = new System.Drawing.Size(422, 259);
            this.groupBoxProperties.TabIndex = 3;
            this.groupBoxProperties.TabStop = false;
            this.groupBoxProperties.Text = "Properties for KiwiCommand";
            // 
            // propertyGrid
            // 
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid.HelpVisible = false;
            this.propertyGrid.Location = new System.Drawing.Point(10, 24);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.SelectedObject = this.kiwiCommand;
            this.propertyGrid.Size = new System.Drawing.Size(402, 225);
            this.propertyGrid.TabIndex = 0;
            this.propertyGrid.ToolbarVisible = false;
            // 
            // kiwiCommand
            // 
            this.kiwiCommand.Checked = true;
            this.kiwiCommand.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.kiwiCommand.ExtraText = "Extra";
            this.kiwiCommand.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kiwiCommand.ImageLarge")));
            this.kiwiCommand.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiCommand.ImageSmall")));
            this.kiwiCommand.Text = "Text";
            this.kiwiCommand.TextLine1 = "";
            this.kiwiCommand.TextLine2 = "";
            // 
            // groupBoxControls
            // 
            this.groupBoxControls.Controls.Add(this.kiwiDropButton1);
            this.groupBoxControls.Controls.Add(this.kiwiHeader1);
            this.groupBoxControls.Controls.Add(this.kiwiColorButton1);
            this.groupBoxControls.Controls.Add(this.kiwiLinkLabel1);
            this.groupBoxControls.Controls.Add(this.kiwiLabel1);
            this.groupBoxControls.Controls.Add(this.kiwiCheckBox1);
            this.groupBoxControls.Controls.Add(this.kiwiCheckButton1);
            this.groupBoxControls.Controls.Add(this.kiwiButton1);
            this.groupBoxControls.Location = new System.Drawing.Point(13, 279);
            this.groupBoxControls.Name = "groupBoxControls";
            this.groupBoxControls.Size = new System.Drawing.Size(422, 225);
            this.groupBoxControls.TabIndex = 4;
            this.groupBoxControls.TabStop = false;
            this.groupBoxControls.Text = "Controls attached to KiwiCommand";
            // 
            // kiwiDropButton1
            // 
            this.kiwiDropButton1.AutoSize = true;
            this.kiwiDropButton1.Location = new System.Drawing.Point(19, 103);
            this.kiwiDropButton1.Name = "kiwiDropButton1";
            this.kiwiDropButton1.Size = new System.Drawing.Size(136, 25);
            this.kiwiDropButton1.TabIndex = 2;
            this.kiwiDropButton1.Values.Text = "DropButton";
            // 
            // kiwiHeader1
            // 
            this.kiwiHeader1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.kiwiHeader1.ButtonSpecs.AddRange(new Kiwi.ComponentFactory.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.kiwiHeader1.Location = new System.Drawing.Point(19, 165);
            this.kiwiHeader1.Name = "kiwiHeader1";
            this.kiwiHeader1.Size = new System.Drawing.Size(170, 31);
            this.kiwiHeader1.TabIndex = 4;
            this.kiwiHeader1.Values.Description = "";
            this.kiwiHeader1.Values.Heading = "Header";
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Text = "ButtonSpec";
            this.buttonSpecAny1.UniqueName = "BC4FEDE1ECC34E64BC4FEDE1ECC34E64";
            // 
            // kiwiColorButton1
            // 
            this.kiwiColorButton1.AutoSize = true;
            this.kiwiColorButton1.Location = new System.Drawing.Point(19, 134);
            this.kiwiColorButton1.Name = "kiwiColorButton1";
            this.kiwiColorButton1.Size = new System.Drawing.Size(136, 25);
            this.kiwiColorButton1.TabIndex = 3;
            this.kiwiColorButton1.Values.Text = "ColorButton";
            // 
            // kiwiLinkLabel1
            // 
            this.kiwiLinkLabel1.Location = new System.Drawing.Point(256, 72);
            this.kiwiLinkLabel1.Name = "kiwiLinkLabel1";
            this.kiwiLinkLabel1.Size = new System.Drawing.Size(61, 20);
            this.kiwiLinkLabel1.TabIndex = 6;
            this.kiwiLinkLabel1.Values.Text = "LinkLabel";
            // 
            // kiwiLabel1
            // 
            this.kiwiLabel1.Location = new System.Drawing.Point(256, 41);
            this.kiwiLabel1.Name = "kiwiLabel1";
            this.kiwiLabel1.Size = new System.Drawing.Size(39, 20);
            this.kiwiLabel1.TabIndex = 5;
            // 
            // kiwiCheckBox1
            // 
            this.kiwiCheckBox1.Location = new System.Drawing.Point(261, 103);
            this.kiwiCheckBox1.Name = "kiwiCheckBox1";
            this.kiwiCheckBox1.Size = new System.Drawing.Size(76, 20);
            this.kiwiCheckBox1.TabIndex = 7;
            this.kiwiCheckBox1.Values.Text = "CheckBox";
            // 
            // kiwiCheckButton1
            // 
            this.kiwiCheckButton1.AutoSize = true;
            this.kiwiCheckButton1.Location = new System.Drawing.Point(19, 72);
            this.kiwiCheckButton1.Name = "kiwiCheckButton1";
            this.kiwiCheckButton1.Size = new System.Drawing.Size(122, 25);
            this.kiwiCheckButton1.TabIndex = 1;
            this.kiwiCheckButton1.Values.Text = "CheckButton";
            // 
            // kiwiButton1
            // 
            this.kiwiButton1.AutoSize = true;
            this.kiwiButton1.Location = new System.Drawing.Point(19, 41);
            this.kiwiButton1.Name = "kiwiButton1";
            this.kiwiButton1.Size = new System.Drawing.Size(122, 25);
            this.kiwiButton1.TabIndex = 0;
            // 
            // buttonAttach
            // 
            this.buttonAttach.Location = new System.Drawing.Point(13, 514);
            this.buttonAttach.Name = "buttonAttach";
            this.buttonAttach.Size = new System.Drawing.Size(159, 26);
            this.buttonAttach.TabIndex = 0;
            this.buttonAttach.Text = "Attach KiwiCommand";
            this.buttonAttach.UseVisualStyleBackColor = true;
            this.buttonAttach.Click += new System.EventHandler(this.buttonAttach_Click);
            // 
            // buttonUnattach
            // 
            this.buttonUnattach.Location = new System.Drawing.Point(178, 514);
            this.buttonUnattach.Name = "buttonUnattach";
            this.buttonUnattach.Size = new System.Drawing.Size(75, 26);
            this.buttonUnattach.TabIndex = 1;
            this.buttonUnattach.Text = "Unattach";
            this.buttonUnattach.UseVisualStyleBackColor = true;
            this.buttonUnattach.Click += new System.EventHandler(this.buttonUnattach_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonAttach;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(446, 553);
            this.Controls.Add(this.buttonUnattach);
            this.Controls.Add(this.buttonAttach);
            this.Controls.Add(this.groupBoxControls);
            this.Controls.Add(this.groupBoxProperties);
            this.Controls.Add(this.buttonClose);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "KiwiCommand Examples";
            this.groupBoxProperties.ResumeLayout(false);
            this.groupBoxControls.ResumeLayout(false);
            this.groupBoxControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBoxProperties;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.GroupBox groupBoxControls;
        private Kiwi.ComponentFactory.Toolkit.KiwiLinkLabel kiwiLinkLabel1;
        private Kiwi.ComponentFactory.Toolkit.KiwiLabel kiwiLabel1;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckBox kiwiCheckBox1;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckButton kiwiCheckButton1;
        private Kiwi.ComponentFactory.Toolkit.KiwiButton kiwiButton1;
        private Kiwi.ComponentFactory.Toolkit.KiwiCommand kiwiCommand;
        private Kiwi.ComponentFactory.Toolkit.KiwiDropButton kiwiDropButton1;
        private Kiwi.ComponentFactory.Toolkit.KiwiHeader kiwiHeader1;
        private Kiwi.ComponentFactory.Toolkit.KiwiColorButton kiwiColorButton1;
        private Kiwi.ComponentFactory.Toolkit.ButtonSpecAny buttonSpecAny1;
        private System.Windows.Forms.Button buttonAttach;
        private System.Windows.Forms.Button buttonUnattach;
    }
}

