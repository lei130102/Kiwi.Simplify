
namespace External_Drag_To_Docking
{
    partial class ContentPropertyGrid
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.kiwiPanel = new Kiwi.ComponentFactory.Toolkit.KiwiPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPanel)).BeginInit();
            this.kiwiPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.HelpVisible = false;
            this.propertyGrid1.Location = new System.Drawing.Point(5, 5);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.propertyGrid1;
            this.propertyGrid1.Size = new System.Drawing.Size(233, 151);
            this.propertyGrid1.TabIndex = 0;
            this.propertyGrid1.ToolbarVisible = false;
            // 
            // kiwiPanel
            // 
            this.kiwiPanel.Controls.Add(this.propertyGrid1);
            this.kiwiPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiwiPanel.Location = new System.Drawing.Point(0, 0);
            this.kiwiPanel.Name = "kiwiPanel";
            this.kiwiPanel.Padding = new System.Windows.Forms.Padding(5);
            this.kiwiPanel.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Global;
            this.kiwiPanel.PanelBackStyle = Kiwi.ComponentFactory.Toolkit.PaletteBackStyle.ControlClient;
            this.kiwiPanel.Size = new System.Drawing.Size(243, 161);
            this.kiwiPanel.TabIndex = 1;
            // 
            // ContentPropertyGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kiwiPanel);
            this.Name = "ContentPropertyGrid";
            this.Size = new System.Drawing.Size(243, 161);
            this.Load += new System.EventHandler(this.ContentPropertyGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPanel)).EndInit();
            this.kiwiPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private Kiwi.ComponentFactory.Toolkit.KiwiPanel kiwiPanel;
    }
}
