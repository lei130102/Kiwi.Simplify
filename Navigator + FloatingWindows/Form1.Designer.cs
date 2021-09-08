
namespace Navigator___FloatingWindows
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
            this.kiwiDockingManager = new Kiwi.ComponentFactory.Docking.KiwiDockingManager();
            this.kiwiManager = new Kiwi.ComponentFactory.Toolkit.KiwiManager(this.components);
            this.kiwiPanel = new Kiwi.ComponentFactory.Toolkit.KiwiPanel();
            this.kiwiDockableNavigator = new Kiwi.ComponentFactory.Docking.KiwiDockableNavigator();
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPanel)).BeginInit();
            this.kiwiPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiDockableNavigator)).BeginInit();
            this.kiwiDockableNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // kiwiPanel
            // 
            this.kiwiPanel.Controls.Add(this.kiwiDockableNavigator);
            this.kiwiPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiwiPanel.Location = new System.Drawing.Point(0, 0);
            this.kiwiPanel.Name = "kiwiPanel";
            this.kiwiPanel.Padding = new System.Windows.Forms.Padding(3);
            this.kiwiPanel.Size = new System.Drawing.Size(397, 284);
            this.kiwiPanel.TabIndex = 0;
            // 
            // kiwiDockableNavigator
            // 
            this.kiwiDockableNavigator.Button.CloseButtonDisplay = Kiwi.ComponentFactory.Navigator.ButtonDisplay.Hide;
            this.kiwiDockableNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiwiDockableNavigator.Location = new System.Drawing.Point(3, 3);
            this.kiwiDockableNavigator.Name = "kiwiDockableNavigator";
            this.kiwiDockableNavigator.Size = new System.Drawing.Size(391, 278);
            this.kiwiDockableNavigator.TabIndex = 0;
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
            this.ClientSize = new System.Drawing.Size(397, 284);
            this.Controls.Add(this.kiwiPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Navigator + FloatingWindows";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPanel)).EndInit();
            this.kiwiPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiDockableNavigator)).EndInit();
            this.kiwiDockableNavigator.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Kiwi.ComponentFactory.Docking.KiwiDockingManager kiwiDockingManager;
        private Kiwi.ComponentFactory.Toolkit.KiwiManager kiwiManager;
        private Kiwi.ComponentFactory.Toolkit.KiwiPanel kiwiPanel;
        private Kiwi.ComponentFactory.Docking.KiwiDockableNavigator kiwiDockableNavigator;
        private System.Windows.Forms.ImageList imageListSmall;
    }
}

