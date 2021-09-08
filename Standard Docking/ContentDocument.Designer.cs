
namespace Standard_Docking
{
    partial class ContentDocument
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContentDocument));
            this.richTextBox = new Kiwi.ComponentFactory.Toolkit.KiwiRichTextBox();
            this.kiwiPanel = new Kiwi.ComponentFactory.Toolkit.KiwiPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPanel)).BeginInit();
            this.kiwiPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(5, 5);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(142, 101);
            this.richTextBox.StateCommon.Border.Draw = Kiwi.ComponentFactory.Toolkit.InheritBool.False;
            this.richTextBox.StateCommon.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = resources.GetString("richTextBox.Text");
            // 
            // kiwiPanel
            // 
            this.kiwiPanel.Controls.Add(this.richTextBox);
            this.kiwiPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiwiPanel.Location = new System.Drawing.Point(0, 0);
            this.kiwiPanel.Name = "kiwiPanel";
            this.kiwiPanel.Padding = new System.Windows.Forms.Padding(5);
            this.kiwiPanel.PanelBackStyle = Kiwi.ComponentFactory.Toolkit.PaletteBackStyle.ControlClient;
            this.kiwiPanel.Size = new System.Drawing.Size(152, 111);
            this.kiwiPanel.TabIndex = 1;
            // 
            // ContentDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kiwiPanel);
            this.Name = "ContentDocument";
            this.Size = new System.Drawing.Size(152, 111);
            this.Load += new System.EventHandler(this.ContentDocument_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPanel)).EndInit();
            this.kiwiPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Kiwi.ComponentFactory.Toolkit.KiwiRichTextBox richTextBox;
        private Kiwi.ComponentFactory.Toolkit.KiwiPanel kiwiPanel;
    }
}
