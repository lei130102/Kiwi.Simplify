
namespace Docking_Flags
{
    partial class ContentFlags
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
            this.cbNavigator = new Kiwi.ComponentFactory.Toolkit.KiwiCheckBox();
            this.cbClose = new Kiwi.ComponentFactory.Toolkit.KiwiCheckBox();
            this.cbWorkspace = new Kiwi.ComponentFactory.Toolkit.KiwiCheckBox();
            this.cbFloating = new Kiwi.ComponentFactory.Toolkit.KiwiCheckBox();
            this.cbAutoHidden = new Kiwi.ComponentFactory.Toolkit.KiwiCheckBox();
            this.cbDocked = new Kiwi.ComponentFactory.Toolkit.KiwiCheckBox();
            this.cbDropDown = new Kiwi.ComponentFactory.Toolkit.KiwiCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPanel)).BeginInit();
            this.kiwiPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kiwiPanel
            // 
            this.kiwiPanel.Controls.Add(this.cbDropDown);
            this.kiwiPanel.Controls.Add(this.cbNavigator);
            this.kiwiPanel.Controls.Add(this.cbClose);
            this.kiwiPanel.Controls.Add(this.cbWorkspace);
            this.kiwiPanel.Controls.Add(this.cbFloating);
            this.kiwiPanel.Controls.Add(this.cbAutoHidden);
            this.kiwiPanel.Controls.Add(this.cbDocked);
            this.kiwiPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiwiPanel.Location = new System.Drawing.Point(0, 0);
            this.kiwiPanel.Name = "kiwiPanel";
            this.kiwiPanel.PanelBackStyle = Kiwi.ComponentFactory.Toolkit.PaletteBackStyle.ControlClient;
            this.kiwiPanel.Size = new System.Drawing.Size(203, 192);
            this.kiwiPanel.TabIndex = 0;
            this.kiwiPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kiwiPanel_MouseDown);
            // 
            // cbNavigator
            // 
            this.cbNavigator.Location = new System.Drawing.Point(15, 106);
            this.cbNavigator.Name = "cbNavigator";
            this.cbNavigator.Size = new System.Drawing.Size(111, 20);
            this.cbNavigator.TabIndex = 4;
            this.cbNavigator.Values.Text = "Allow Navigator";
            this.cbNavigator.CheckedChanged += new System.EventHandler(this.cbNavigator_CheckedChanged);
            // 
            // cbClose
            // 
            this.cbClose.Location = new System.Drawing.Point(15, 152);
            this.cbClose.Name = "cbClose";
            this.cbClose.Size = new System.Drawing.Size(87, 20);
            this.cbClose.TabIndex = 6;
            this.cbClose.Values.Text = "Allow Close";
            this.cbClose.CheckedChanged += new System.EventHandler(this.cbClose_CheckedChanged);
            // 
            // cbWorkspace
            // 
            this.cbWorkspace.Location = new System.Drawing.Point(15, 83);
            this.cbWorkspace.Name = "cbWorkspace";
            this.cbWorkspace.Size = new System.Drawing.Size(117, 20);
            this.cbWorkspace.TabIndex = 3;
            this.cbWorkspace.Values.Text = "Allow Workspace";
            this.cbWorkspace.CheckedChanged += new System.EventHandler(this.cbWorkspace_CheckedChanged);
            // 
            // cbFloating
            // 
            this.cbFloating.Location = new System.Drawing.Point(15, 60);
            this.cbFloating.Name = "cbFloating";
            this.cbFloating.Size = new System.Drawing.Size(101, 20);
            this.cbFloating.TabIndex = 2;
            this.cbFloating.Values.Text = "Allow Floating";
            this.cbFloating.CheckedChanged += new System.EventHandler(this.cbFloating_CheckedChanged);
            // 
            // cbAutoHidden
            // 
            this.cbAutoHidden.Location = new System.Drawing.Point(15, 37);
            this.cbAutoHidden.Name = "cbAutoHidden";
            this.cbAutoHidden.Size = new System.Drawing.Size(123, 20);
            this.cbAutoHidden.TabIndex = 1;
            this.cbAutoHidden.Values.Text = "Allow AutoHidden";
            this.cbAutoHidden.CheckedChanged += new System.EventHandler(this.cbAutoHidden_CheckedChanged);
            // 
            // cbDocked
            // 
            this.cbDocked.Location = new System.Drawing.Point(15, 14);
            this.cbDocked.Name = "cbDocked";
            this.cbDocked.Size = new System.Drawing.Size(99, 20);
            this.cbDocked.TabIndex = 0;
            this.cbDocked.Values.Text = "Allow Docked";
            this.cbDocked.CheckedChanged += new System.EventHandler(this.cbDocked_CheckedChanged);
            // 
            // cbDropDown
            // 
            this.cbDropDown.Location = new System.Drawing.Point(15, 129);
            this.cbDropDown.Name = "cbDropDown";
            this.cbDropDown.Size = new System.Drawing.Size(116, 20);
            this.cbDropDown.TabIndex = 5;
            this.cbDropDown.Values.Text = "Allow DropDown";
            this.cbDropDown.CheckedChanged += new System.EventHandler(this.cbDropDown_CheckedChanged);
            // 
            // ContentFlags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kiwiPanel);
            this.Name = "ContentFlags";
            this.Size = new System.Drawing.Size(203, 192);
            this.Load += new System.EventHandler(this.ContentFlags_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPanel)).EndInit();
            this.kiwiPanel.ResumeLayout(false);
            this.kiwiPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Kiwi.ComponentFactory.Toolkit.KiwiPanel kiwiPanel;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckBox cbClose;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckBox cbWorkspace;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckBox cbFloating;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckBox cbAutoHidden;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckBox cbDocked;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckBox cbNavigator;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckBox cbDropDown;
    }
}
