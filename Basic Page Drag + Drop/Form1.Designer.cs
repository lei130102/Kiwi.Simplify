
namespace Basic_Page_Drag___Drop
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
            this.kiwiNavigator1 = new Kiwi.ComponentFactory.Navigator.KiwiNavigator();
            this.kiwiNavigator2 = new Kiwi.ComponentFactory.Navigator.KiwiNavigator();
            this.kiwiWorkspace2 = new Kiwi.ComponentFactory.Workspace.KiwiWorkspace();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxDragFeedback = new System.Windows.Forms.GroupBox();
            this.radioRounded = new System.Windows.Forms.RadioButton();
            this.radioSquares = new System.Windows.Forms.RadioButton();
            this.radioBlock = new System.Windows.Forms.RadioButton();
            this.buttonClose = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.kiwiWorkspace1 = new Kiwi.ComponentFactory.Workspace.KiwiWorkspace();
            this.labelNavigators = new System.Windows.Forms.Label();
            this.labelWorkspaces = new System.Windows.Forms.Label();
            this.kiwiManager1 = new Kiwi.ComponentFactory.Toolkit.KiwiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiNavigator1)).BeginInit();
            this.kiwiNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiNavigator2)).BeginInit();
            this.kiwiNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiWorkspace2)).BeginInit();
            this.groupBoxDragFeedback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiWorkspace1)).BeginInit();
            this.SuspendLayout();
            // 
            // kiwiNavigator1
            // 
            this.kiwiNavigator1.AllowPageDrag = true;
            this.kiwiNavigator1.AllowTabFocus = false;
            this.kiwiNavigator1.Button.CloseButtonDisplay = Kiwi.ComponentFactory.Navigator.ButtonDisplay.Hide;
            this.kiwiNavigator1.Button.ContextButtonDisplay = Kiwi.ComponentFactory.Navigator.ButtonDisplay.Hide;
            this.kiwiNavigator1.Location = new System.Drawing.Point(13, 70);
            this.kiwiNavigator1.Name = "kiwiNavigator1";
            this.kiwiNavigator1.Size = new System.Drawing.Size(313, 202);
            this.kiwiNavigator1.TabIndex = 2;
            this.kiwiNavigator1.Text = "kiwiNavigator1";
            // 
            // kiwiNavigator2
            // 
            this.kiwiNavigator2.AllowPageDrag = true;
            this.kiwiNavigator2.AllowTabFocus = false;
            this.kiwiNavigator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.kiwiNavigator2.Button.CloseButtonDisplay = Kiwi.ComponentFactory.Navigator.ButtonDisplay.Hide;
            this.kiwiNavigator2.Button.ContextButtonDisplay = Kiwi.ComponentFactory.Navigator.ButtonDisplay.Hide;
            this.kiwiNavigator2.Header.HeaderVisibleSecondary = false;
            this.kiwiNavigator2.Location = new System.Drawing.Point(343, 70);
            this.kiwiNavigator2.Name = "kiwiNavigator2";
            this.kiwiNavigator2.NavigatorMode = Kiwi.ComponentFactory.Navigator.NavigatorMode.HeaderBarCheckButtonHeaderGroup;
            this.kiwiNavigator2.Size = new System.Drawing.Size(329, 202);
            this.kiwiNavigator2.TabIndex = 3;
            this.kiwiNavigator2.Text = "kiwiNavigator1";
            // 
            // kiwiWorkspace2
            // 
            this.kiwiWorkspace2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.kiwiWorkspace2.Location = new System.Drawing.Point(343, 309);
            this.kiwiWorkspace2.Name = "kiwiWorkspace2";
            // 
            // 
            // 
            this.kiwiWorkspace2.Root.UniqueName = "CFCD8E8D88A44257CFCD8E8D88A44257";
            this.kiwiWorkspace2.ShowMaximizeButton = false;
            this.kiwiWorkspace2.Size = new System.Drawing.Size(329, 271);
            this.kiwiWorkspace2.TabIndex = 6;
            this.kiwiWorkspace2.TabStop = true;
            this.kiwiWorkspace2.WorkspaceCellAdding += new System.EventHandler<Kiwi.ComponentFactory.Workspace.WorkspaceCellEventArgs>(this.kiwiWorkspace2_WorkspaceCellAdding);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 13);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(636, 19);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Try dragging page headers between the Navigator and Workspace instances.";
            // 
            // groupBoxDragFeedback
            // 
            this.groupBoxDragFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxDragFeedback.Controls.Add(this.radioRounded);
            this.groupBoxDragFeedback.Controls.Add(this.radioSquares);
            this.groupBoxDragFeedback.Controls.Add(this.radioBlock);
            this.groupBoxDragFeedback.Location = new System.Drawing.Point(13, 592);
            this.groupBoxDragFeedback.Name = "groupBoxDragFeedback";
            this.groupBoxDragFeedback.Size = new System.Drawing.Size(248, 52);
            this.groupBoxDragFeedback.TabIndex = 7;
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
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(602, 592);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(70, 23);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "bell.png");
            this.imageList.Images.SetKeyName(1, "box.png");
            this.imageList.Images.SetKeyName(2, "brickwall.png");
            this.imageList.Images.SetKeyName(3, "castle.png");
            this.imageList.Images.SetKeyName(4, "chart.png");
            this.imageList.Images.SetKeyName(5, "colors.png");
            this.imageList.Images.SetKeyName(6, "cubes.png");
            this.imageList.Images.SetKeyName(7, "pawn.png");
            // 
            // kiwiWorkspace1
            // 
            this.kiwiWorkspace1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.kiwiWorkspace1.Location = new System.Drawing.Point(13, 309);
            this.kiwiWorkspace1.Name = "kiwiWorkspace1";
            // 
            // 
            // 
            this.kiwiWorkspace1.Root.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.kiwiWorkspace1.Root.UniqueName = "E37CE04BEBFB4C1DE37CE04BEBFB4C1D";
            this.kiwiWorkspace1.ShowMaximizeButton = false;
            this.kiwiWorkspace1.Size = new System.Drawing.Size(313, 271);
            this.kiwiWorkspace1.TabIndex = 5;
            this.kiwiWorkspace1.TabStop = true;
            this.kiwiWorkspace1.WorkspaceCellAdding += new System.EventHandler<Kiwi.ComponentFactory.Workspace.WorkspaceCellEventArgs>(this.kiwiWorkspace1_WorkspaceCellAdding);
            // 
            // labelNavigators
            // 
            this.labelNavigators.AutoSize = true;
            this.labelNavigators.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNavigators.Location = new System.Drawing.Point(13, 46);
            this.labelNavigators.Name = "labelNavigators";
            this.labelNavigators.Size = new System.Drawing.Size(91, 18);
            this.labelNavigators.TabIndex = 1;
            this.labelNavigators.Text = "Navigators";
            // 
            // labelWorkspaces
            // 
            this.labelWorkspaces.AutoSize = true;
            this.labelWorkspaces.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorkspaces.Location = new System.Drawing.Point(13, 284);
            this.labelWorkspaces.Name = "labelWorkspaces";
            this.labelWorkspaces.Size = new System.Drawing.Size(99, 18);
            this.labelWorkspaces.TabIndex = 4;
            this.labelWorkspaces.Text = "Workspaces";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 654);
            this.Controls.Add(this.labelWorkspaces);
            this.Controls.Add(this.labelNavigators);
            this.Controls.Add(this.kiwiWorkspace1);
            this.Controls.Add(this.kiwiNavigator2);
            this.Controls.Add(this.kiwiWorkspace2);
            this.Controls.Add(this.kiwiNavigator1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxDragFeedback);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(675, 641);
            this.Name = "Form1";
            this.Text = "Basic Page Drag and Drop";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiNavigator1)).EndInit();
            this.kiwiNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiNavigator2)).EndInit();
            this.kiwiNavigator2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiWorkspace2)).EndInit();
            this.groupBoxDragFeedback.ResumeLayout(false);
            this.groupBoxDragFeedback.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiWorkspace1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Kiwi.ComponentFactory.Navigator.KiwiNavigator kiwiNavigator1;
        private Kiwi.ComponentFactory.Navigator.KiwiNavigator kiwiNavigator2;
        private Kiwi.ComponentFactory.Workspace.KiwiWorkspace kiwiWorkspace2;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxDragFeedback;
        private System.Windows.Forms.RadioButton radioRounded;
        private System.Windows.Forms.RadioButton radioSquares;
        private System.Windows.Forms.RadioButton radioBlock;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ImageList imageList;
        private Kiwi.ComponentFactory.Workspace.KiwiWorkspace kiwiWorkspace1;
        private System.Windows.Forms.Label labelNavigators;
        private System.Windows.Forms.Label labelWorkspaces;
        private Kiwi.ComponentFactory.Toolkit.KiwiManager kiwiManager1;
    }
}

