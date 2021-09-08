
namespace User_Page_Creation
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
            this.kiwiAddPage = new Kiwi.ComponentFactory.Navigator.KiwiPage();
            this.groupBoxDescription = new System.Windows.Forms.GroupBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.kiwiManager1 = new Kiwi.ComponentFactory.Toolkit.KiwiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiNavigator1)).BeginInit();
            this.kiwiNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiAddPage)).BeginInit();
            this.groupBoxDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // kiwiNavigator1
            // 
            this.kiwiNavigator1.AllowPageReorder = false;
            this.kiwiNavigator1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.kiwiNavigator1.Button.CloseButtonDisplay = Kiwi.ComponentFactory.Navigator.ButtonDisplay.ShowDisabled;
            this.kiwiNavigator1.Location = new System.Drawing.Point(12, 172);
            this.kiwiNavigator1.Name = "kiwiNavigator1";
            this.kiwiNavigator1.Pages.AddRange(new Kiwi.ComponentFactory.Navigator.KiwiPage[] {
            this.kiwiAddPage});
            this.kiwiNavigator1.SelectedIndex = 0;
            this.kiwiNavigator1.Size = new System.Drawing.Size(430, 97);
            this.kiwiNavigator1.TabIndex = 0;
            this.kiwiNavigator1.Text = "kiwiNavigator1";
            this.kiwiNavigator1.CloseAction += new System.EventHandler<Kiwi.ComponentFactory.Navigator.CloseActionEventArgs>(this.kiwiNavigator1_CloseAction);
            this.kiwiNavigator1.ContextAction += new System.EventHandler<Kiwi.ComponentFactory.Navigator.ContextActionEventArgs>(this.kiwiNavigator1_ContextAction);
            this.kiwiNavigator1.SelectedPageChanged += new System.EventHandler(this.kiwiNavigator1_SelectedPageChanged);
            // 
            // kiwiAddPage
            // 
            this.kiwiAddPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kiwiAddPage.Flags = 65534;
            this.kiwiAddPage.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kiwiAddPage.ImageLarge")));
            this.kiwiAddPage.ImageMedium = ((System.Drawing.Image)(resources.GetObject("kiwiAddPage.ImageMedium")));
            this.kiwiAddPage.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiAddPage.ImageSmall")));
            this.kiwiAddPage.LastVisibleSet = true;
            this.kiwiAddPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.kiwiAddPage.Name = "kiwiAddPage";
            this.kiwiAddPage.Size = new System.Drawing.Size(428, 72);
            this.kiwiAddPage.Text = "";
            this.kiwiAddPage.TextDescription = "";
            this.kiwiAddPage.TextTitle = "";
            this.kiwiAddPage.ToolTipTitle = "Page ToolTip";
            this.kiwiAddPage.UniqueName = "006F26A780F64009006F26A780F64009";
            // 
            // groupBoxDescription
            // 
            this.groupBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDescription.Controls.Add(this.textBoxDescription);
            this.groupBoxDescription.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDescription.Name = "groupBoxDescription";
            this.groupBoxDescription.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxDescription.Size = new System.Drawing.Size(430, 154);
            this.groupBoxDescription.TabIndex = 1;
            this.groupBoxDescription.TabStop = false;
            this.groupBoxDescription.Text = "Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Location = new System.Drawing.Point(5, 19);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(420, 130);
            this.textBoxDescription.TabIndex = 0;
            this.textBoxDescription.Text = resources.GetString("textBoxDescription.Text");
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(367, 282);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 317);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxDescription);
            this.Controls.Add(this.kiwiNavigator1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "User Page Creation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiNavigator1)).EndInit();
            this.kiwiNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiAddPage)).EndInit();
            this.groupBoxDescription.ResumeLayout(false);
            this.groupBoxDescription.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Kiwi.ComponentFactory.Navigator.KiwiNavigator kiwiNavigator1;
        private Kiwi.ComponentFactory.Navigator.KiwiPage kiwiAddPage;
        private System.Windows.Forms.GroupBox groupBoxDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonClose;
        private Kiwi.ComponentFactory.Toolkit.KiwiManager kiwiManager1;
    }
}

