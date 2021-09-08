
namespace MDI_Ribbon
{
    partial class Form3
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
            this.kiwiPanel1 = new Kiwi.ComponentFactory.Toolkit.KiwiPanel();
            this.labelMessage = new Kiwi.ComponentFactory.Toolkit.KiwiLabel();
            this.buttonOK = new Kiwi.ComponentFactory.Toolkit.KiwiButton();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPanel1)).BeginInit();
            this.kiwiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kiwiPanel1
            // 
            this.kiwiPanel1.Controls.Add(this.labelMessage);
            this.kiwiPanel1.Controls.Add(this.buttonOK);
            this.kiwiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiwiPanel1.Location = new System.Drawing.Point(0, 0);
            this.kiwiPanel1.Name = "kiwiPanel1";
            this.kiwiPanel1.Size = new System.Drawing.Size(260, 91);
            this.kiwiPanel1.TabIndex = 0;
            // 
            // labelMessage
            // 
            this.labelMessage.LabelStyle = Kiwi.ComponentFactory.Toolkit.LabelStyle.NormalPanel;
            this.labelMessage.Location = new System.Drawing.Point(15, 13);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(236, 20);
            this.labelMessage.TabIndex = 1;
            this.labelMessage.Values.Text = "This is where you would show some help!";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonOK.Location = new System.Drawing.Point(89, 48);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(67, 25);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Values.Text = "OK";
            // 
            // Form3
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonOK;
            this.ClientSize = new System.Drawing.Size(260, 91);
            this.Controls.Add(this.kiwiPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Help";
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPanel1)).EndInit();
            this.kiwiPanel1.ResumeLayout(false);
            this.kiwiPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Kiwi.ComponentFactory.Toolkit.KiwiPanel kiwiPanel1;
        private Kiwi.ComponentFactory.Toolkit.KiwiLabel labelMessage;
        private Kiwi.ComponentFactory.Toolkit.KiwiButton buttonOK;
    }
}