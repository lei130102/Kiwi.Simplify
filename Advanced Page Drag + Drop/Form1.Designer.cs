
namespace Advanced_Page_Drag___Drop
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("London", 0, 0);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Paris", 1, 1);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Madrid", 2, 2);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Lisbon", 3, 3);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Rome", 4, 4);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Berlin", 5, 5);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Vienna", 6, 6);
            this.kiwiWorkspace = new Kiwi.ComponentFactory.Workspace.KiwiWorkspace();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.dragTreeView = new Advanced_Page_Drag___Drop.PageDragTreeView();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelTreeView = new System.Windows.Forms.Label();
            this.groupBoxDragFeedback = new System.Windows.Forms.GroupBox();
            this.radioRounded = new System.Windows.Forms.RadioButton();
            this.radioSquares = new System.Windows.Forms.RadioButton();
            this.radioBlock = new System.Windows.Forms.RadioButton();
            this.labelWorkspaces = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelNavigators = new System.Windows.Forms.Label();
            this.kiwiNavigator = new Kiwi.ComponentFactory.Navigator.KiwiNavigator();
            this.kiwiManager1 = new Kiwi.ComponentFactory.Toolkit.KiwiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiWorkspace)).BeginInit();
            this.groupBoxDragFeedback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiNavigator)).BeginInit();
            this.kiwiNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // kiwiWorkspace
            // 
            this.kiwiWorkspace.Location = new System.Drawing.Point(466, 74);
            this.kiwiWorkspace.Name = "kiwiWorkspace";
            // 
            // 
            // 
            this.kiwiWorkspace.Root.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.kiwiWorkspace.Root.UniqueName = "18D7B2B1649347B418D7B2B1649347B4";
            this.kiwiWorkspace.ShowMaximizeButton = false;
            this.kiwiWorkspace.Size = new System.Drawing.Size(333, 250);
            this.kiwiWorkspace.TabIndex = 2;
            this.kiwiWorkspace.TabStop = true;
            this.kiwiWorkspace.WorkspaceCellAdding += new System.EventHandler<Kiwi.ComponentFactory.Workspace.WorkspaceCellEventArgs>(this.workspaceCellAdding);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "flag_great_britain.png");
            this.imageList.Images.SetKeyName(1, "flag_france.png");
            this.imageList.Images.SetKeyName(2, "flag_spain.png");
            this.imageList.Images.SetKeyName(3, "flag_portugal.png");
            this.imageList.Images.SetKeyName(4, "flag_italy.png");
            this.imageList.Images.SetKeyName(5, "flag_germany.png");
            this.imageList.Images.SetKeyName(6, "flag_austria.png");
            this.imageList.Images.SetKeyName(7, "flag_australia.png");
            this.imageList.Images.SetKeyName(8, "flag_cyprus.png");
            this.imageList.Images.SetKeyName(9, "flag_ireland.png");
            this.imageList.Images.SetKeyName(10, "flag_norway.png");
            this.imageList.Images.SetKeyName(11, "flag_hungary.png");
            this.imageList.Images.SetKeyName(12, "flag_japan.png");
            // 
            // dragTreeView
            // 
            this.dragTreeView.ImageIndex = 0;
            this.dragTreeView.ImageList = this.imageList;
            this.dragTreeView.Location = new System.Drawing.Point(13, 74);
            this.dragTreeView.Name = "dragTreeView";
            treeNode1.ImageIndex = 0;
            treeNode1.Name = "nodeLondon";
            treeNode1.SelectedImageIndex = 0;
            treeNode1.Tag = "0";
            treeNode1.Text = "London";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "nodeParis";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Tag = "1";
            treeNode2.Text = "Paris";
            treeNode3.ImageIndex = 2;
            treeNode3.Name = "nodeMadrid";
            treeNode3.SelectedImageIndex = 2;
            treeNode3.Tag = "2";
            treeNode3.Text = "Madrid";
            treeNode4.ImageIndex = 3;
            treeNode4.Name = "modeLisbon";
            treeNode4.SelectedImageIndex = 3;
            treeNode4.Tag = "3";
            treeNode4.Text = "Lisbon";
            treeNode5.ImageIndex = 4;
            treeNode5.Name = "nodeRome";
            treeNode5.SelectedImageIndex = 4;
            treeNode5.Tag = "4";
            treeNode5.Text = "Rome";
            treeNode6.ImageIndex = 5;
            treeNode6.Name = "nodeBerlin";
            treeNode6.SelectedImageIndex = 5;
            treeNode6.Tag = "5";
            treeNode6.Text = "Berlin";
            treeNode7.ImageIndex = 6;
            treeNode7.Name = "nodeVienna";
            treeNode7.SelectedImageIndex = 6;
            treeNode7.Tag = "6";
            treeNode7.Text = "Vienna";
            this.dragTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            this.dragTreeView.SelectedImageIndex = 0;
            this.dragTreeView.Size = new System.Drawing.Size(134, 250);
            this.dragTreeView.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 13);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(661, 19);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Try dragging TreeView nodes to the Navigator/Workspace and then back again.\r\n";
            // 
            // labelTreeView
            // 
            this.labelTreeView.AutoSize = true;
            this.labelTreeView.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTreeView.Location = new System.Drawing.Point(13, 50);
            this.labelTreeView.Name = "labelTreeView";
            this.labelTreeView.Size = new System.Drawing.Size(79, 18);
            this.labelTreeView.TabIndex = 4;
            this.labelTreeView.Text = "TreeView";
            // 
            // groupBoxDragFeedback
            // 
            this.groupBoxDragFeedback.Controls.Add(this.radioRounded);
            this.groupBoxDragFeedback.Controls.Add(this.radioSquares);
            this.groupBoxDragFeedback.Controls.Add(this.radioBlock);
            this.groupBoxDragFeedback.Location = new System.Drawing.Point(13, 339);
            this.groupBoxDragFeedback.Name = "groupBoxDragFeedback";
            this.groupBoxDragFeedback.Size = new System.Drawing.Size(248, 52);
            this.groupBoxDragFeedback.TabIndex = 8;
            this.groupBoxDragFeedback.TabStop = false;
            this.groupBoxDragFeedback.Text = "Drag Feedback";
            // 
            // radioRounded
            // 
            this.radioRounded.AutoSize = true;
            this.radioRounded.Checked = true;
            this.radioRounded.Location = new System.Drawing.Point(162, 22);
            this.radioRounded.Name = "radioRounded";
            this.radioRounded.Size = new System.Drawing.Size(68, 17);
            this.radioRounded.TabIndex = 2;
            this.radioRounded.TabStop = true;
            this.radioRounded.Text = "Rounded";
            this.radioRounded.UseVisualStyleBackColor = true;
            this.radioRounded.CheckedChanged += new System.EventHandler(this.radioRounded_CheckedChanged);
            // 
            // radioSquares
            // 
            this.radioSquares.AutoSize = true;
            this.radioSquares.Location = new System.Drawing.Point(83, 22);
            this.radioSquares.Name = "radioSquares";
            this.radioSquares.Size = new System.Drawing.Size(64, 17);
            this.radioSquares.TabIndex = 1;
            this.radioSquares.Text = "Squares";
            this.radioSquares.UseVisualStyleBackColor = true;
            this.radioSquares.CheckedChanged += new System.EventHandler(this.radioSquares_CheckedChanged);
            // 
            // radioBlock
            // 
            this.radioBlock.AutoSize = true;
            this.radioBlock.Location = new System.Drawing.Point(18, 22);
            this.radioBlock.Name = "radioBlock";
            this.radioBlock.Size = new System.Drawing.Size(49, 17);
            this.radioBlock.TabIndex = 0;
            this.radioBlock.Text = "Block";
            this.radioBlock.UseVisualStyleBackColor = true;
            this.radioBlock.CheckedChanged += new System.EventHandler(this.radioBlock_CheckedChanged);
            // 
            // labelWorkspaces
            // 
            this.labelWorkspaces.AutoSize = true;
            this.labelWorkspaces.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorkspaces.Location = new System.Drawing.Point(463, 50);
            this.labelWorkspaces.Name = "labelWorkspaces";
            this.labelWorkspaces.Size = new System.Drawing.Size(91, 18);
            this.labelWorkspaces.TabIndex = 9;
            this.labelWorkspaces.Text = "Workspace";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(729, 339);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(70, 23);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelNavigators
            // 
            this.labelNavigators.AutoSize = true;
            this.labelNavigators.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNavigators.Location = new System.Drawing.Point(162, 50);
            this.labelNavigators.Name = "labelNavigators";
            this.labelNavigators.Size = new System.Drawing.Size(83, 18);
            this.labelNavigators.TabIndex = 11;
            this.labelNavigators.Text = "Navigator";
            // 
            // kiwiNavigator
            // 
            this.kiwiNavigator.AllowPageDrag = true;
            this.kiwiNavigator.AllowTabFocus = false;
            this.kiwiNavigator.Button.CloseButtonDisplay = Kiwi.ComponentFactory.Navigator.ButtonDisplay.Hide;
            this.kiwiNavigator.Button.ContextButtonDisplay = Kiwi.ComponentFactory.Navigator.ButtonDisplay.Hide;
            this.kiwiNavigator.Location = new System.Drawing.Point(165, 74);
            this.kiwiNavigator.Name = "kiwiNavigator";
            this.kiwiNavigator.Size = new System.Drawing.Size(285, 250);
            this.kiwiNavigator.TabIndex = 12;
            this.kiwiNavigator.Text = "kiwiNavigator1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 399);
            this.Controls.Add(this.kiwiNavigator);
            this.Controls.Add(this.labelNavigators);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelWorkspaces);
            this.Controls.Add(this.groupBoxDragFeedback);
            this.Controls.Add(this.labelTreeView);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.kiwiWorkspace);
            this.Controls.Add(this.dragTreeView);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Advanced Page Drag and Drop";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiWorkspace)).EndInit();
            this.groupBoxDragFeedback.ResumeLayout(false);
            this.groupBoxDragFeedback.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiNavigator)).EndInit();
            this.kiwiNavigator.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PageDragTreeView dragTreeView;
        private Kiwi.ComponentFactory.Workspace.KiwiWorkspace kiwiWorkspace;
        private Kiwi.ComponentFactory.Navigator.KiwiNavigator kiwiNavigator;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTreeView;
        private System.Windows.Forms.GroupBox groupBoxDragFeedback;
        private System.Windows.Forms.RadioButton radioRounded;
        private System.Windows.Forms.RadioButton radioSquares;
        private System.Windows.Forms.RadioButton radioBlock;
        private System.Windows.Forms.Label labelWorkspaces;
        private System.Windows.Forms.Label labelNavigators;
        private System.Windows.Forms.Button buttonClose;
        private Kiwi.ComponentFactory.Toolkit.KiwiManager kiwiManager1;
    }
}

