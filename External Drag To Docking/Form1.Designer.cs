
namespace External_Drag_To_Docking
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
            this.kiwiManager = new Kiwi.ComponentFactory.Toolkit.KiwiManager(this.components);
            this.kiwiDockingManager = new Kiwi.ComponentFactory.Docking.KiwiDockingManager();
            this.kiwiPanel = new Kiwi.ComponentFactory.Toolkit.KiwiPanel();
            this.kiwiDockableWorkspace = new Kiwi.ComponentFactory.Docking.KiwiDockableWorkspace();
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPanel)).BeginInit();
            this.kiwiPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiDockableWorkspace)).BeginInit();
            this.SuspendLayout();
            // 
            // kiwiManager
            // 
            this.kiwiManager.GlobalPaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteModeManager.SparklePurple;
            // 
            // kiwiPanel
            // 
            this.kiwiPanel.Controls.Add(this.kiwiDockableWorkspace);
            this.kiwiPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiwiPanel.Location = new System.Drawing.Point(0, 0);
            this.kiwiPanel.Name = "kiwiPanel";
            this.kiwiPanel.Size = new System.Drawing.Size(749, 520);
            this.kiwiPanel.TabIndex = 0;
            // 
            // kiwiDockableWorkspace
            // 
            this.kiwiDockableWorkspace.AutoHiddenHost = false;
            this.kiwiDockableWorkspace.CompactFlags = ((Kiwi.ComponentFactory.Workspace.CompactFlags)(((Kiwi.ComponentFactory.Workspace.CompactFlags.RemoveEmptyCells | Kiwi.ComponentFactory.Workspace.CompactFlags.RemoveEmptySequences)
                  | Kiwi.ComponentFactory.Workspace.CompactFlags.PromoteLeafs)));
            this.kiwiDockableWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiwiDockableWorkspace.Location = new System.Drawing.Point(0, 0);
            this.kiwiDockableWorkspace.Name = "kiwiDockableWorkspace";
            // 
            // 
            // 
            this.kiwiDockableWorkspace.Root.UniqueName = "6C9A3354441646DC46BF0E62E96721F3";
            this.kiwiDockableWorkspace.Root.WorkspaceControl = this.kiwiDockableWorkspace;
            this.kiwiDockableWorkspace.ShowMaximizeButton = false;
            this.kiwiDockableWorkspace.Size = new System.Drawing.Size(749, 520);
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
            this.imageListSmall.Images.SetKeyName(3, "dictionary.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 520);
            this.Controls.Add(this.kiwiPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "External Drag To Docking";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPanel)).EndInit();
            this.kiwiPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiDockableWorkspace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Kiwi.ComponentFactory.Toolkit.KiwiManager kiwiManager;
        private Kiwi.ComponentFactory.Docking.KiwiDockingManager kiwiDockingManager;
        private Kiwi.ComponentFactory.Toolkit.KiwiPanel kiwiPanel;
        private Kiwi.ComponentFactory.Docking.KiwiDockableWorkspace kiwiDockableWorkspace;
        private System.Windows.Forms.ImageList imageListSmall;
    }
}

