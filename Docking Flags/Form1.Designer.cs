
namespace Docking_Flags
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
            this.kiwiPanel = new Kiwi.ComponentFactory.Toolkit.KiwiPanel();
            this.kiwiDockableWorkspace = new Kiwi.ComponentFactory.Docking.KiwiDockableWorkspace();
            this.kiwiDockingManager = new Kiwi.ComponentFactory.Docking.KiwiDockingManager();
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.kiwiManager = new Kiwi.ComponentFactory.Toolkit.KiwiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPanel)).BeginInit();
            this.kiwiPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiDockableWorkspace)).BeginInit();
            this.SuspendLayout();
            // 
            // kiwiPanel
            // 
            this.kiwiPanel.Controls.Add(this.kiwiDockableWorkspace);
            this.kiwiPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiwiPanel.Location = new System.Drawing.Point(0, 0);
            this.kiwiPanel.Name = "kiwiPanel";
            this.kiwiPanel.Padding = new System.Windows.Forms.Padding(3);
            this.kiwiPanel.Size = new System.Drawing.Size(684, 564);
            this.kiwiPanel.TabIndex = 0;
            // 
            // kiwiDockableWorkspace
            // 
            this.kiwiDockableWorkspace.AutoHiddenHost = false;
            this.kiwiDockableWorkspace.CompactFlags = ((Kiwi.ComponentFactory.Workspace.CompactFlags)(((Kiwi.ComponentFactory.Workspace.CompactFlags.RemoveEmptyCells | Kiwi.ComponentFactory.Workspace.CompactFlags.RemoveEmptySequences)
                        | Kiwi.ComponentFactory.Workspace.CompactFlags.PromoteLeafs)));
            this.kiwiDockableWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiwiDockableWorkspace.Location = new System.Drawing.Point(3, 3);
            this.kiwiDockableWorkspace.Name = "kiwiDockableWorkspace";
            // 
            // 
            // 
            this.kiwiDockableWorkspace.Root.UniqueName = "D3A631E8871B4E59D3A631E8871B4E59";
            this.kiwiDockableWorkspace.ShowMaximizeButton = false;
            this.kiwiDockableWorkspace.Size = new System.Drawing.Size(678, 558);
            this.kiwiDockableWorkspace.TabIndex = 0;
            this.kiwiDockableWorkspace.TabStop = true;
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "document_plain.png");
            this.imageListSmall.Images.SetKeyName(1, "preferences.png");
            this.imageListSmall.Images.SetKeyName(2, "information2.png");
            // 
            // kiwiManager
            // 
            this.kiwiManager.GlobalPaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteModeManager.Office2010Blue;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 564);
            this.Controls.Add(this.kiwiPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Docking Flags";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPanel)).EndInit();
            this.kiwiPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiDockableWorkspace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Kiwi.ComponentFactory.Toolkit.KiwiPanel kiwiPanel;
        private Kiwi.ComponentFactory.Docking.KiwiDockingManager kiwiDockingManager;
        private System.Windows.Forms.ImageList imageListSmall;
        private Kiwi.ComponentFactory.Docking.KiwiDockableWorkspace kiwiDockableWorkspace;
        private Kiwi.ComponentFactory.Toolkit.KiwiManager kiwiManager;

    }
}

