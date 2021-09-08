
namespace Cell_Maximize___Restore
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.kiwiWorkspace = new Kiwi.ComponentFactory.Workspace.KiwiWorkspace();
            this.kiwiWorkspaceCell1 = new Kiwi.ComponentFactory.Workspace.KiwiWorkspaceCell();
            this.kiwiPage1 = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.kiwiPage2 = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.kiwiWorkspaceSequence1 = new Kiwi.ComponentFactory.Workspace.KiwiWorkspaceSequence();
            this.kiwiWorkspaceCell2 = new Kiwi.ComponentFactory.Workspace.KiwiWorkspaceCell();
            this.kiwiPage3 = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.kiwiPage4 = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.kiwiWorkspaceCell3 = new Kiwi.ComponentFactory.Workspace.KiwiWorkspaceCell();
            this.kiwiPage5 = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.kiwiPage6 = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.kiwiManager1 = new Kiwi.ComponentFactory.Toolkit.KiwiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiWorkspace)).BeginInit();
            this.kiwiWorkspace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiWorkspaceCell1)).BeginInit();
            this.kiwiWorkspaceCell1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage1)).BeginInit();
            this.kiwiPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage2)).BeginInit();
            this.kiwiPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiWorkspaceCell2)).BeginInit();
            this.kiwiWorkspaceCell2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage3)).BeginInit();
            this.kiwiPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage4)).BeginInit();
            this.kiwiPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiWorkspaceCell3)).BeginInit();
            this.kiwiWorkspaceCell3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage5)).BeginInit();
            this.kiwiPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage6)).BeginInit();
            this.kiwiPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(547, 476);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 26);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // kiwiWorkspace
            // 
            this.kiwiWorkspace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.kiwiWorkspace.Location = new System.Drawing.Point(12, 12);
            this.kiwiWorkspace.Name = "kiwiWorkspace";
            // 
            // 
            // 
            this.kiwiWorkspace.Root.Children.AddRange(new System.ComponentModel.Component[] {
            this.kiwiWorkspaceCell1,
            this.kiwiWorkspaceSequence1});
            this.kiwiWorkspace.Root.UniqueName = "4364A9E9DAF34C0D4364A9E9DAF34C0D";
            this.kiwiWorkspace.Size = new System.Drawing.Size(610, 456);
            this.kiwiWorkspace.TabIndex = 0;
            this.kiwiWorkspace.TabStop = true;
            this.kiwiWorkspace.ActiveCellChanged += new System.EventHandler<Kiwi.ComponentFactory.Workspace.ActiveCellChangedEventArgs>(this.kiwiWorkspace_ActiveCellChanged);
            this.kiwiWorkspace.WorkspaceCellAdding += new System.EventHandler<Kiwi.ComponentFactory.Workspace.WorkspaceCellEventArgs>(this.kiwiWorkspace_WorkspaceCellAdding);
            // 
            // kiwiWorkspaceCell1
            // 
            this.kiwiWorkspaceCell1.AllowPageDrag = true;
            this.kiwiWorkspaceCell1.AllowTabFocus = false;
            this.kiwiWorkspaceCell1.Name = "kiwiWorkspaceCell1";
            this.kiwiWorkspaceCell1.Pages.AddRange(new Kiwi.ComponentFactory.Navigator.KiwiPage[] {
            this.kiwiPage1,
            this.kiwiPage2});
            this.kiwiWorkspaceCell1.SelectedIndex = 1;
            this.kiwiWorkspaceCell1.UniqueName = "B46823ED744B4A87B46823ED744B4A87";
            // 
            // kiwiPage1
            // 
            this.kiwiPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kiwiPage1.Controls.Add(this.richTextBox1);
            this.kiwiPage1.Flags = 65534;
            this.kiwiPage1.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiPage1.ImageSmall")));
            this.kiwiPage1.LastVisibleSet = true;
            this.kiwiPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kiwiPage1.Name = "kiwiPage1";
            this.kiwiPage1.Padding = new System.Windows.Forms.Padding(5);
            this.kiwiPage1.Size = new System.Drawing.Size(300, 423);
            this.kiwiPage1.Text = "Bug List";
            this.kiwiPage1.ToolTipTitle = "Page ToolTip";
            this.kiwiPage1.UniqueName = "38D886AD20CD402D38D886AD20CD402D";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(5, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(290, 413);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // kiwiPage2
            // 
            this.kiwiPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kiwiPage2.Controls.Add(this.richTextBox2);
            this.kiwiPage2.Flags = 65534;
            this.kiwiPage2.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiPage2.ImageSmall")));
            this.kiwiPage2.LastVisibleSet = true;
            this.kiwiPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kiwiPage2.Name = "kiwiPage2";
            this.kiwiPage2.Padding = new System.Windows.Forms.Padding(5);
            this.kiwiPage2.Size = new System.Drawing.Size(300, 423);
            this.kiwiPage2.Text = "Workstation";
            this.kiwiPage2.ToolTipTitle = "Page ToolTip";
            this.kiwiPage2.UniqueName = "B057555EE9CE421BB057555EE9CE421B";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(5, 5);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(290, 413);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // kiwiWorkspaceSequence1
            // 
            this.kiwiWorkspaceSequence1.Children.AddRange(new System.ComponentModel.Component[] {
            this.kiwiWorkspaceCell2,
            this.kiwiWorkspaceCell3});
            this.kiwiWorkspaceSequence1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.kiwiWorkspaceSequence1.UniqueName = "99DF5376A7A6421599DF5376A7A64215";
            // 
            // kiwiWorkspaceCell2
            // 
            this.kiwiWorkspaceCell2.AllowPageDrag = true;
            this.kiwiWorkspaceCell2.AllowTabFocus = false;
            this.kiwiWorkspaceCell2.Name = "kiwiWorkspaceCell2";
            this.kiwiWorkspaceCell2.Pages.AddRange(new Kiwi.ComponentFactory.Navigator.KiwiPage[] {
            this.kiwiPage3,
            this.kiwiPage4});
            this.kiwiWorkspaceCell2.SelectedIndex = 1;
            this.kiwiWorkspaceCell2.UniqueName = "9182BBE062034D889182BBE062034D88";
            // 
            // kiwiPage3
            // 
            this.kiwiPage3.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kiwiPage3.Controls.Add(this.richTextBox4);
            this.kiwiPage3.Flags = 65534;
            this.kiwiPage3.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiPage3.ImageSmall")));
            this.kiwiPage3.LastVisibleSet = true;
            this.kiwiPage3.MinimumSize = new System.Drawing.Size(50, 50);
            this.kiwiPage3.Name = "kiwiPage3";
            this.kiwiPage3.Padding = new System.Windows.Forms.Padding(5);
            this.kiwiPage3.Size = new System.Drawing.Size(301, 192);
            this.kiwiPage3.Text = "Server List";
            this.kiwiPage3.ToolTipTitle = "Page ToolTip";
            this.kiwiPage3.UniqueName = "05A80B272D8C411705A80B272D8C4117";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox4.Location = new System.Drawing.Point(5, 5);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(291, 182);
            this.richTextBox4.TabIndex = 1;
            this.richTextBox4.Text = "";
            // 
            // kiwiPage4
            // 
            this.kiwiPage4.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kiwiPage4.Controls.Add(this.richTextBox3);
            this.kiwiPage4.Flags = 65534;
            this.kiwiPage4.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiPage4.ImageSmall")));
            this.kiwiPage4.LastVisibleSet = true;
            this.kiwiPage4.MinimumSize = new System.Drawing.Size(50, 50);
            this.kiwiPage4.Name = "kiwiPage4";
            this.kiwiPage4.Padding = new System.Windows.Forms.Padding(5);
            this.kiwiPage4.Size = new System.Drawing.Size(301, 192);
            this.kiwiPage4.Text = "Planets";
            this.kiwiPage4.ToolTipTitle = "Page ToolTip";
            this.kiwiPage4.UniqueName = "0A2FA4EB0679438E0A2FA4EB0679438E";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox3.Location = new System.Drawing.Point(5, 5);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(291, 182);
            this.richTextBox3.TabIndex = 1;
            this.richTextBox3.Text = "";
            // 
            // kiwiWorkspaceCell3
            // 
            this.kiwiWorkspaceCell3.AllowPageDrag = true;
            this.kiwiWorkspaceCell3.AllowTabFocus = false;
            this.kiwiWorkspaceCell3.Name = "kiwiWorkspaceCell3";
            this.kiwiWorkspaceCell3.Pages.AddRange(new Kiwi.ComponentFactory.Navigator.KiwiPage[] {
            this.kiwiPage5,
            this.kiwiPage6});
            this.kiwiWorkspaceCell3.SelectedIndex = 0;
            this.kiwiWorkspaceCell3.UniqueName = "A69A2BEFC56C49EFA69A2BEFC56C49EF";
            // 
            // kiwiPage5
            // 
            this.kiwiPage5.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kiwiPage5.Controls.Add(this.richTextBox6);
            this.kiwiPage5.Flags = 65534;
            this.kiwiPage5.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiPage5.ImageSmall")));
            this.kiwiPage5.LastVisibleSet = true;
            this.kiwiPage5.MinimumSize = new System.Drawing.Size(50, 50);
            this.kiwiPage5.Name = "kiwiPage5";
            this.kiwiPage5.Padding = new System.Windows.Forms.Padding(5);
            this.kiwiPage5.Size = new System.Drawing.Size(301, 193);
            this.kiwiPage5.Text = "Dance Steps";
            this.kiwiPage5.ToolTipTitle = "Page ToolTip";
            this.kiwiPage5.UniqueName = "5F44CFE539EF46555F44CFE539EF4655";
            // 
            // richTextBox6
            // 
            this.richTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox6.Location = new System.Drawing.Point(5, 5);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(291, 183);
            this.richTextBox6.TabIndex = 1;
            this.richTextBox6.Text = "";
            // 
            // kiwiPage6
            // 
            this.kiwiPage6.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kiwiPage6.Controls.Add(this.richTextBox5);
            this.kiwiPage6.Flags = 65534;
            this.kiwiPage6.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiPage6.ImageSmall")));
            this.kiwiPage6.LastVisibleSet = true;
            this.kiwiPage6.MinimumSize = new System.Drawing.Size(50, 50);
            this.kiwiPage6.Name = "kiwiPage6";
            this.kiwiPage6.Padding = new System.Windows.Forms.Padding(5);
            this.kiwiPage6.Size = new System.Drawing.Size(301, 193);
            this.kiwiPage6.Text = "Music List";
            this.kiwiPage6.ToolTipTitle = "Page ToolTip";
            this.kiwiPage6.UniqueName = "20C9A0DF02044CE120C9A0DF02044CE1";
            // 
            // richTextBox5
            // 
            this.richTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox5.Location = new System.Drawing.Point(5, 5);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(291, 183);
            this.richTextBox5.TabIndex = 1;
            this.richTextBox5.Text = "";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList.Images.SetKeyName(0, "Restore.bmp");
            this.imageList.Images.SetKeyName(1, "Maximize.bmp");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 514);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.kiwiWorkspace);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "Form1";
            this.Text = "Cell Maximize + Restore";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiWorkspace)).EndInit();
            this.kiwiWorkspace.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiWorkspaceCell1)).EndInit();
            this.kiwiWorkspaceCell1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage1)).EndInit();
            this.kiwiPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage2)).EndInit();
            this.kiwiPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiWorkspaceCell2)).EndInit();
            this.kiwiWorkspaceCell2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage3)).EndInit();
            this.kiwiPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage4)).EndInit();
            this.kiwiPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiWorkspaceCell3)).EndInit();
            this.kiwiWorkspaceCell3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage5)).EndInit();
            this.kiwiPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPage6)).EndInit();
            this.kiwiPage6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private Kiwi.ComponentFactory.Workspace.KiwiWorkspace kiwiWorkspace;
        private Kiwi.ComponentFactory.Workspace.KiwiWorkspaceCell kiwiWorkspaceCell1;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPage1;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPage2;
        private Kiwi.ComponentFactory.Workspace.KiwiWorkspaceSequence kiwiWorkspaceSequence1;
        private Kiwi.ComponentFactory.Workspace.KiwiWorkspaceCell kiwiWorkspaceCell2;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPage3;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPage4;
        private Kiwi.ComponentFactory.Workspace.KiwiWorkspaceCell kiwiWorkspaceCell3;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPage5;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiPage6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.ImageList imageList;
        private Kiwi.ComponentFactory.Toolkit.KiwiManager kiwiManager1;
    }
}

