
namespace Multi_Control_Docking
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
            this.kiwiLabel2 = new Kiwi.ComponentFactory.Toolkit.KiwiLabel();
            this.kiwiLabel1 = new Kiwi.ComponentFactory.Toolkit.KiwiLabel();
            this.kiwiPanel3 = new Kiwi.ComponentFactory.Toolkit.KiwiPanel();
            this.kiwiPanel2 = new Kiwi.ComponentFactory.Toolkit.KiwiPanel();
            this.kiwiDockingManager = new Kiwi.ComponentFactory.Docking.KiwiDockingManager();
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.kiwiManager = new Kiwi.ComponentFactory.Toolkit.KiwiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPanel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPanel2)).BeginInit();
            this.SuspendLayout();
            // 
            // kiwiLabel2
            // 
            this.kiwiLabel2.LabelStyle = Kiwi.ComponentFactory.Toolkit.LabelStyle.TitlePanel;
            this.kiwiLabel2.Location = new System.Drawing.Point(443, 12);
            this.kiwiLabel2.Name = "kiwiLabel2";
            this.kiwiLabel2.Size = new System.Drawing.Size(153, 29);
            this.kiwiLabel2.TabIndex = 3;
            this.kiwiLabel2.Values.Text = "Docking Panel 2";
            // 
            // kiwiLabel1
            // 
            this.kiwiLabel1.LabelStyle = Kiwi.ComponentFactory.Toolkit.LabelStyle.TitlePanel;
            this.kiwiLabel1.Location = new System.Drawing.Point(12, 12);
            this.kiwiLabel1.Name = "kiwiLabel1";
            this.kiwiLabel1.Size = new System.Drawing.Size(153, 29);
            this.kiwiLabel1.TabIndex = 2;
            this.kiwiLabel1.Values.Text = "Docking Panel 1";
            // 
            // kiwiPanel3
            // 
            this.kiwiPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.kiwiPanel3.Location = new System.Drawing.Point(443, 47);
            this.kiwiPanel3.Name = "kiwiPanel3";
            this.kiwiPanel3.Size = new System.Drawing.Size(400, 407);
            this.kiwiPanel3.TabIndex = 1;
            // 
            // kiwiPanel2
            // 
            this.kiwiPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.kiwiPanel2.Location = new System.Drawing.Point(12, 47);
            this.kiwiPanel2.Name = "kiwiPanel2";
            this.kiwiPanel2.Size = new System.Drawing.Size(400, 407);
            this.kiwiPanel2.TabIndex = 0;
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "document_plain.png");
            this.imageListSmall.Images.SetKeyName(1, "preferences.png");
            this.imageListSmall.Images.SetKeyName(2, "information2.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 466);
            this.Controls.Add(this.kiwiPanel3);
            this.Controls.Add(this.kiwiLabel2);
            this.Controls.Add(this.kiwiLabel1);
            this.Controls.Add(this.kiwiPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 330);
            this.Name = "Form1";
            this.Text = "Multi Control Docking";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPanel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPanel2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Kiwi.ComponentFactory.Toolkit.KiwiPanel kiwiPanel3;
        private Kiwi.ComponentFactory.Toolkit.KiwiPanel kiwiPanel2;
        private Kiwi.ComponentFactory.Toolkit.KiwiLabel kiwiLabel2;
        private Kiwi.ComponentFactory.Toolkit.KiwiLabel kiwiLabel1;
        private Kiwi.ComponentFactory.Docking.KiwiDockingManager kiwiDockingManager;
        private System.Windows.Forms.ImageList imageListSmall;
        private Kiwi.ComponentFactory.Toolkit.KiwiManager kiwiManager;

    }
}

