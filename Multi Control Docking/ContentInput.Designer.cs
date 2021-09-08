
namespace Multi_Control_Docking
{
    partial class ContentInput
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kiwiPanel = new Kiwi.ComponentFactory.Toolkit.KiwiPanel();
            this.kiwiButton1 = new Kiwi.ComponentFactory.Toolkit.KiwiButton();
            this.kiwiNumericUpDown1 = new Kiwi.ComponentFactory.Toolkit.KiwiNumericUpDown();
            this.kiwiLabel3 = new Kiwi.ComponentFactory.Toolkit.KiwiLabel();
            this.kiwiTextBox2 = new Kiwi.ComponentFactory.Toolkit.KiwiTextBox();
            this.kiwiLabel2 = new Kiwi.ComponentFactory.Toolkit.KiwiLabel();
            this.kiwiTextBox1 = new Kiwi.ComponentFactory.Toolkit.KiwiTextBox();
            this.kiwiLabel1 = new Kiwi.ComponentFactory.Toolkit.KiwiLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPanel)).BeginInit();
            this.kiwiPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kiwiPanel
            // 
            this.kiwiPanel.Controls.Add(this.kiwiButton1);
            this.kiwiPanel.Controls.Add(this.kiwiNumericUpDown1);
            this.kiwiPanel.Controls.Add(this.kiwiLabel3);
            this.kiwiPanel.Controls.Add(this.kiwiTextBox2);
            this.kiwiPanel.Controls.Add(this.kiwiLabel2);
            this.kiwiPanel.Controls.Add(this.kiwiTextBox1);
            this.kiwiPanel.Controls.Add(this.kiwiLabel1);
            this.kiwiPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiwiPanel.Location = new System.Drawing.Point(0, 0);
            this.kiwiPanel.Name = "kiwiPanel";
            this.kiwiPanel.PanelBackStyle = Kiwi.ComponentFactory.Toolkit.PaletteBackStyle.ControlClient;
            this.kiwiPanel.Size = new System.Drawing.Size(191, 154);
            this.kiwiPanel.TabIndex = 0;
            this.kiwiPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kiwiPanel_MouseDown);
            // 
            // kiwiButton1
            // 
            this.kiwiButton1.Location = new System.Drawing.Point(85, 104);
            this.kiwiButton1.Name = "kiwiButton1";
            this.kiwiButton1.Size = new System.Drawing.Size(81, 25);
            this.kiwiButton1.TabIndex = 6;
            this.kiwiButton1.Values.Text = "Update";
            // 
            // kiwiNumericUpDown1
            // 
            this.kiwiNumericUpDown1.Location = new System.Drawing.Point(85, 66);
            this.kiwiNumericUpDown1.Name = "kiwiNumericUpDown1";
            this.kiwiNumericUpDown1.Size = new System.Drawing.Size(81, 22);
            this.kiwiNumericUpDown1.TabIndex = 5;
            this.kiwiNumericUpDown1.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            // 
            // kiwiLabel3
            // 
            this.kiwiLabel3.Location = new System.Drawing.Point(45, 66);
            this.kiwiLabel3.Name = "kiwiLabel3";
            this.kiwiLabel3.Size = new System.Drawing.Size(32, 20);
            this.kiwiLabel3.TabIndex = 4;
            this.kiwiLabel3.Values.Text = "Age";
            // 
            // kiwiTextBox2
            // 
            this.kiwiTextBox2.Location = new System.Drawing.Point(85, 40);
            this.kiwiTextBox2.Name = "kiwiTextBox2";
            this.kiwiTextBox2.Size = new System.Drawing.Size(81, 20);
            this.kiwiTextBox2.TabIndex = 3;
            this.kiwiTextBox2.Text = "Doe";
            // 
            // kiwiLabel2
            // 
            this.kiwiLabel2.Location = new System.Drawing.Point(11, 40);
            this.kiwiLabel2.Name = "kiwiLabel2";
            this.kiwiLabel2.Size = new System.Drawing.Size(68, 20);
            this.kiwiLabel2.TabIndex = 2;
            this.kiwiLabel2.Values.Text = "Last Name";
            // 
            // kiwiTextBox1
            // 
            this.kiwiTextBox1.Location = new System.Drawing.Point(85, 14);
            this.kiwiTextBox1.Name = "kiwiTextBox1";
            this.kiwiTextBox1.Size = new System.Drawing.Size(81, 20);
            this.kiwiTextBox1.TabIndex = 1;
            this.kiwiTextBox1.Text = "John";
            // 
            // kiwiLabel1
            // 
            this.kiwiLabel1.Location = new System.Drawing.Point(10, 14);
            this.kiwiLabel1.Name = "kiwiLabel1";
            this.kiwiLabel1.Size = new System.Drawing.Size(69, 20);
            this.kiwiLabel1.TabIndex = 0;
            this.kiwiLabel1.Values.Text = "First Name";
            // 
            // ContentInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kiwiPanel);
            this.Name = "ContentInput";
            this.Size = new System.Drawing.Size(191, 154);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPanel)).EndInit();
            this.kiwiPanel.ResumeLayout(false);
            this.kiwiPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Kiwi.ComponentFactory.Toolkit.KiwiPanel kiwiPanel;
        private Kiwi.ComponentFactory.Toolkit.KiwiButton kiwiButton1;
        private Kiwi.ComponentFactory.Toolkit.KiwiNumericUpDown kiwiNumericUpDown1;
        private Kiwi.ComponentFactory.Toolkit.KiwiLabel kiwiLabel3;
        private Kiwi.ComponentFactory.Toolkit.KiwiTextBox kiwiTextBox2;
        private Kiwi.ComponentFactory.Toolkit.KiwiLabel kiwiLabel2;
        private Kiwi.ComponentFactory.Toolkit.KiwiTextBox kiwiTextBox1;
        private Kiwi.ComponentFactory.Toolkit.KiwiLabel kiwiLabel1;
    }
}
