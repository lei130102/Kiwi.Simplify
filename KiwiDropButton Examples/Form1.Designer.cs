
namespace KiwiDropButton_Examples
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupProperties = new System.Windows.Forms.GroupBox();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.groupSplitter = new System.Windows.Forms.GroupBox();
            this.splitterArrowLeft = new Kiwi.ComponentFactory.Toolkit.KiwiDropButton();
            this.kcmDropDown = new Kiwi.ComponentFactory.Toolkit.KiwiContextMenu();
            this.kiwiContextMenuHeading1 = new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuHeading();
            this.kiwiContextMenuItems1 = new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItems();
            this.kiwiContextMenuItem1 = new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem();
            this.kiwiContextMenuItem2 = new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem();
            this.kiwiContextMenuItem3 = new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem();
            this.splitterArrowRight = new Kiwi.ComponentFactory.Toolkit.KiwiDropButton();
            this.splitterArrowUp = new Kiwi.ComponentFactory.Toolkit.KiwiDropButton();
            this.splitterArrowDown = new Kiwi.ComponentFactory.Toolkit.KiwiDropButton();
            this.splitterPosBottom = new Kiwi.ComponentFactory.Toolkit.KiwiDropButton();
            this.splitterPosTop = new Kiwi.ComponentFactory.Toolkit.KiwiDropButton();
            this.splitterPosLeft = new Kiwi.ComponentFactory.Toolkit.KiwiDropButton();
            this.splitterPosRight = new Kiwi.ComponentFactory.Toolkit.KiwiDropButton();
            this.groupDropDown = new System.Windows.Forms.GroupBox();
            this.dropArrowLeft = new Kiwi.ComponentFactory.Toolkit.KiwiDropButton();
            this.dropArrowRight = new Kiwi.ComponentFactory.Toolkit.KiwiDropButton();
            this.dropArrowUp = new Kiwi.ComponentFactory.Toolkit.KiwiDropButton();
            this.dropArrowDown = new Kiwi.ComponentFactory.Toolkit.KiwiDropButton();
            this.dropPosBottom = new Kiwi.ComponentFactory.Toolkit.KiwiDropButton();
            this.dropPosTop = new Kiwi.ComponentFactory.Toolkit.KiwiDropButton();
            this.dropPosLeft = new Kiwi.ComponentFactory.Toolkit.KiwiDropButton();
            this.dropPosRight = new Kiwi.ComponentFactory.Toolkit.KiwiDropButton();
            this.groupCustom = new System.Windows.Forms.GroupBox();
            this.dropCustom = new Kiwi.ComponentFactory.Toolkit.KiwiDropButton();
            this.kcmCustom = new Kiwi.ComponentFactory.Toolkit.KiwiContextMenu();
            this.kiwiContextMenuHeading5 = new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuHeading();
            this.kiwiContextMenuItems5 = new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItems();
            this.kiwiContextMenuItem13 = new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem();
            this.kiwiContextMenuItem14 = new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem();
            this.kiwiContextMenuItem15 = new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem();
            this.splitterCustom = new Kiwi.ComponentFactory.Toolkit.KiwiDropButton();
            this.groupProperties.SuspendLayout();
            this.groupSplitter.SuspendLayout();
            this.groupDropDown.SuspendLayout();
            this.groupCustom.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(553, 526);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupProperties
            // 
            this.groupProperties.Controls.Add(this.propertyGrid);
            this.groupProperties.Location = new System.Drawing.Point(306, 12);
            this.groupProperties.Name = "groupProperties";
            this.groupProperties.Size = new System.Drawing.Size(322, 508);
            this.groupProperties.TabIndex = 3;
            this.groupProperties.TabStop = false;
            this.groupProperties.Text = "Properties for Selected KiwiDropButton";
            // 
            // propertyGrid
            // 
            this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid.Location = new System.Drawing.Point(6, 19);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(310, 483);
            this.propertyGrid.TabIndex = 0;
            this.propertyGrid.ToolbarVisible = false;
            // 
            // groupSplitter
            // 
            this.groupSplitter.Controls.Add(this.splitterArrowLeft);
            this.groupSplitter.Controls.Add(this.splitterArrowRight);
            this.groupSplitter.Controls.Add(this.splitterArrowUp);
            this.groupSplitter.Controls.Add(this.splitterArrowDown);
            this.groupSplitter.Controls.Add(this.splitterPosBottom);
            this.groupSplitter.Controls.Add(this.splitterPosTop);
            this.groupSplitter.Controls.Add(this.splitterPosLeft);
            this.groupSplitter.Controls.Add(this.splitterPosRight);
            this.groupSplitter.Location = new System.Drawing.Point(12, 12);
            this.groupSplitter.Name = "groupSplitter";
            this.groupSplitter.Size = new System.Drawing.Size(288, 191);
            this.groupSplitter.TabIndex = 0;
            this.groupSplitter.TabStop = false;
            this.groupSplitter.Text = "Splitter";
            // 
            // splitterArrowLeft
            // 
            this.splitterArrowLeft.DropDownOrientation = Kiwi.ComponentFactory.Toolkit.VisualOrientation.Left;
            this.splitterArrowLeft.KiwiContextMenu = this.kcmDropDown;
            this.splitterArrowLeft.Location = new System.Drawing.Point(154, 92);
            this.splitterArrowLeft.Name = "splitterArrowLeft";
            this.splitterArrowLeft.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2010Blue;
            this.splitterArrowLeft.Size = new System.Drawing.Size(115, 25);
            this.splitterArrowLeft.StateCommon.Content.Image.ImageH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Near;
            this.splitterArrowLeft.StateCommon.Content.ShortText.TextH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Near;
            this.splitterArrowLeft.TabIndex = 6;
            this.splitterArrowLeft.Values.Image = ((System.Drawing.Image)(resources.GetObject("splitterArrowLeft.Values.Image")));
            this.splitterArrowLeft.Values.Text = "Arrow Left";
            this.splitterArrowLeft.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // kcmDropDown
            // 
            this.kcmDropDown.Items.AddRange(new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItemBase[] {
            this.kiwiContextMenuHeading1,
            this.kiwiContextMenuItems1});
            this.kcmDropDown.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2007Blue;
            // 
            // kiwiContextMenuHeading1
            // 
            this.kiwiContextMenuHeading1.ExtraText = "";
            // 
            // kiwiContextMenuItems1
            // 
            this.kiwiContextMenuItems1.Items.AddRange(new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItemBase[] {
            this.kiwiContextMenuItem1,
            this.kiwiContextMenuItem2,
            this.kiwiContextMenuItem3});
            // 
            // kiwiContextMenuItem1
            // 
            this.kiwiContextMenuItem1.Text = "Menu Item 1";
            // 
            // kiwiContextMenuItem2
            // 
            this.kiwiContextMenuItem2.Checked = true;
            this.kiwiContextMenuItem2.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.kiwiContextMenuItem2.Text = "Menu Item 2";
            // 
            // kiwiContextMenuItem3
            // 
            this.kiwiContextMenuItem3.Checked = true;
            this.kiwiContextMenuItem3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kiwiContextMenuItem3.Text = "Menu Item 3";
            // 
            // splitterArrowRight
            // 
            this.splitterArrowRight.DropDownOrientation = Kiwi.ComponentFactory.Toolkit.VisualOrientation.Right;
            this.splitterArrowRight.KiwiContextMenu = this.kcmDropDown;
            this.splitterArrowRight.Location = new System.Drawing.Point(154, 30);
            this.splitterArrowRight.Name = "splitterArrowRight";
            this.splitterArrowRight.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2010Blue;
            this.splitterArrowRight.Size = new System.Drawing.Size(115, 25);
            this.splitterArrowRight.StateCommon.Content.Image.ImageH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Near;
            this.splitterArrowRight.StateCommon.Content.ShortText.TextH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Near;
            this.splitterArrowRight.TabIndex = 4;
            this.splitterArrowRight.Values.Image = ((System.Drawing.Image)(resources.GetObject("splitterArrowRight.Values.Image")));
            this.splitterArrowRight.Values.Text = "Arrow Right";
            this.splitterArrowRight.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // splitterArrowUp
            // 
            this.splitterArrowUp.DropDownOrientation = Kiwi.ComponentFactory.Toolkit.VisualOrientation.Top;
            this.splitterArrowUp.KiwiContextMenu = this.kcmDropDown;
            this.splitterArrowUp.Location = new System.Drawing.Point(154, 123);
            this.splitterArrowUp.Name = "splitterArrowUp";
            this.splitterArrowUp.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2010Blue;
            this.splitterArrowUp.Size = new System.Drawing.Size(115, 25);
            this.splitterArrowUp.StateCommon.Content.Image.ImageH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Near;
            this.splitterArrowUp.StateCommon.Content.ShortText.TextH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Near;
            this.splitterArrowUp.TabIndex = 7;
            this.splitterArrowUp.Values.Image = ((System.Drawing.Image)(resources.GetObject("splitterArrowUp.Values.Image")));
            this.splitterArrowUp.Values.Text = "Arrow Up";
            this.splitterArrowUp.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // splitterArrowDown
            // 
            this.splitterArrowDown.KiwiContextMenu = this.kcmDropDown;
            this.splitterArrowDown.Location = new System.Drawing.Point(154, 61);
            this.splitterArrowDown.Name = "splitterArrowDown";
            this.splitterArrowDown.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2010Blue;
            this.splitterArrowDown.Size = new System.Drawing.Size(115, 25);
            this.splitterArrowDown.StateCommon.Content.Image.ImageH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Near;
            this.splitterArrowDown.StateCommon.Content.ShortText.TextH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Near;
            this.splitterArrowDown.TabIndex = 5;
            this.splitterArrowDown.Values.Image = ((System.Drawing.Image)(resources.GetObject("splitterArrowDown.Values.Image")));
            this.splitterArrowDown.Values.Text = "Arrow Down";
            this.splitterArrowDown.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // splitterPosBottom
            // 
            this.splitterPosBottom.DropDownPosition = Kiwi.ComponentFactory.Toolkit.VisualOrientation.Bottom;
            this.splitterPosBottom.KiwiContextMenu = this.kcmDropDown;
            this.splitterPosBottom.Location = new System.Drawing.Point(25, 136);
            this.splitterPosBottom.Name = "splitterPosBottom";
            this.splitterPosBottom.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2007Blue;
            this.splitterPosBottom.Size = new System.Drawing.Size(104, 38);
            this.splitterPosBottom.TabIndex = 3;
            this.splitterPosBottom.Values.Text = "Position Bottom";
            this.splitterPosBottom.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // splitterPosTop
            // 
            this.splitterPosTop.DropDownPosition = Kiwi.ComponentFactory.Toolkit.VisualOrientation.Top;
            this.splitterPosTop.KiwiContextMenu = this.kcmDropDown;
            this.splitterPosTop.Location = new System.Drawing.Point(25, 92);
            this.splitterPosTop.Name = "splitterPosTop";
            this.splitterPosTop.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2007Blue;
            this.splitterPosTop.Size = new System.Drawing.Size(104, 38);
            this.splitterPosTop.TabIndex = 2;
            this.splitterPosTop.Values.Text = "Position Top";
            this.splitterPosTop.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // splitterPosLeft
            // 
            this.splitterPosLeft.DropDownPosition = Kiwi.ComponentFactory.Toolkit.VisualOrientation.Left;
            this.splitterPosLeft.KiwiContextMenu = this.kcmDropDown;
            this.splitterPosLeft.Location = new System.Drawing.Point(25, 61);
            this.splitterPosLeft.Name = "splitterPosLeft";
            this.splitterPosLeft.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2007Blue;
            this.splitterPosLeft.Size = new System.Drawing.Size(104, 25);
            this.splitterPosLeft.TabIndex = 1;
            this.splitterPosLeft.Values.Text = "Position Left";
            this.splitterPosLeft.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // splitterPosRight
            // 
            this.splitterPosRight.KiwiContextMenu = this.kcmDropDown;
            this.splitterPosRight.Location = new System.Drawing.Point(25, 30);
            this.splitterPosRight.Name = "splitterPosRight";
            this.splitterPosRight.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2007Blue;
            this.splitterPosRight.Size = new System.Drawing.Size(104, 25);
            this.splitterPosRight.TabIndex = 0;
            this.splitterPosRight.Values.Text = "Position Right";
            this.splitterPosRight.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // groupDropDown
            // 
            this.groupDropDown.Controls.Add(this.dropArrowLeft);
            this.groupDropDown.Controls.Add(this.dropArrowRight);
            this.groupDropDown.Controls.Add(this.dropArrowUp);
            this.groupDropDown.Controls.Add(this.dropArrowDown);
            this.groupDropDown.Controls.Add(this.dropPosBottom);
            this.groupDropDown.Controls.Add(this.dropPosTop);
            this.groupDropDown.Controls.Add(this.dropPosLeft);
            this.groupDropDown.Controls.Add(this.dropPosRight);
            this.groupDropDown.Location = new System.Drawing.Point(12, 209);
            this.groupDropDown.Name = "groupDropDown";
            this.groupDropDown.Size = new System.Drawing.Size(288, 191);
            this.groupDropDown.TabIndex = 1;
            this.groupDropDown.TabStop = false;
            this.groupDropDown.Text = "DropDown";
            // 
            // dropArrowLeft
            // 
            this.dropArrowLeft.DropDownOrientation = Kiwi.ComponentFactory.Toolkit.VisualOrientation.Left;
            this.dropArrowLeft.KiwiContextMenu = this.kcmDropDown;
            this.dropArrowLeft.Location = new System.Drawing.Point(154, 92);
            this.dropArrowLeft.Name = "dropArrowLeft";
            this.dropArrowLeft.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalSystem;
            this.dropArrowLeft.Size = new System.Drawing.Size(115, 25);
            this.dropArrowLeft.Splitter = false;
            this.dropArrowLeft.StateCommon.Content.Image.ImageH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Near;
            this.dropArrowLeft.StateCommon.Content.ShortText.TextH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Near;
            this.dropArrowLeft.TabIndex = 6;
            this.dropArrowLeft.Values.Image = ((System.Drawing.Image)(resources.GetObject("dropArrowLeft.Values.Image")));
            this.dropArrowLeft.Values.Text = "Arrow Left";
            this.dropArrowLeft.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // dropArrowRight
            // 
            this.dropArrowRight.DropDownOrientation = Kiwi.ComponentFactory.Toolkit.VisualOrientation.Right;
            this.dropArrowRight.KiwiContextMenu = this.kcmDropDown;
            this.dropArrowRight.Location = new System.Drawing.Point(154, 30);
            this.dropArrowRight.Name = "dropArrowRight";
            this.dropArrowRight.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalSystem;
            this.dropArrowRight.Size = new System.Drawing.Size(115, 25);
            this.dropArrowRight.Splitter = false;
            this.dropArrowRight.StateCommon.Content.Image.ImageH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Near;
            this.dropArrowRight.StateCommon.Content.ShortText.TextH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Near;
            this.dropArrowRight.TabIndex = 4;
            this.dropArrowRight.Values.Image = ((System.Drawing.Image)(resources.GetObject("dropArrowRight.Values.Image")));
            this.dropArrowRight.Values.Text = "Arrow Right";
            this.dropArrowRight.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // dropArrowUp
            // 
            this.dropArrowUp.DropDownOrientation = Kiwi.ComponentFactory.Toolkit.VisualOrientation.Top;
            this.dropArrowUp.KiwiContextMenu = this.kcmDropDown;
            this.dropArrowUp.Location = new System.Drawing.Point(154, 123);
            this.dropArrowUp.Name = "dropArrowUp";
            this.dropArrowUp.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalSystem;
            this.dropArrowUp.Size = new System.Drawing.Size(115, 25);
            this.dropArrowUp.Splitter = false;
            this.dropArrowUp.StateCommon.Content.Image.ImageH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Near;
            this.dropArrowUp.StateCommon.Content.ShortText.TextH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Near;
            this.dropArrowUp.TabIndex = 7;
            this.dropArrowUp.Values.Image = ((System.Drawing.Image)(resources.GetObject("dropArrowUp.Values.Image")));
            this.dropArrowUp.Values.Text = "Arrow Up";
            this.dropArrowUp.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // dropArrowDown
            // 
            this.dropArrowDown.KiwiContextMenu = this.kcmDropDown;
            this.dropArrowDown.Location = new System.Drawing.Point(154, 61);
            this.dropArrowDown.Name = "dropArrowDown";
            this.dropArrowDown.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalSystem;
            this.dropArrowDown.Size = new System.Drawing.Size(115, 25);
            this.dropArrowDown.Splitter = false;
            this.dropArrowDown.StateCommon.Content.Image.ImageH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Near;
            this.dropArrowDown.StateCommon.Content.ShortText.TextH = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Near;
            this.dropArrowDown.TabIndex = 5;
            this.dropArrowDown.Values.Image = ((System.Drawing.Image)(resources.GetObject("dropArrowDown.Values.Image")));
            this.dropArrowDown.Values.Text = "Arrow Down";
            this.dropArrowDown.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // dropPosBottom
            // 
            this.dropPosBottom.DropDownPosition = Kiwi.ComponentFactory.Toolkit.VisualOrientation.Bottom;
            this.dropPosBottom.KiwiContextMenu = this.kcmDropDown;
            this.dropPosBottom.Location = new System.Drawing.Point(25, 136);
            this.dropPosBottom.Name = "dropPosBottom";
            this.dropPosBottom.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.dropPosBottom.Size = new System.Drawing.Size(104, 38);
            this.dropPosBottom.Splitter = false;
            this.dropPosBottom.TabIndex = 3;
            this.dropPosBottom.Values.Text = "Position Bottom";
            this.dropPosBottom.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // dropPosTop
            // 
            this.dropPosTop.DropDownPosition = Kiwi.ComponentFactory.Toolkit.VisualOrientation.Top;
            this.dropPosTop.KiwiContextMenu = this.kcmDropDown;
            this.dropPosTop.Location = new System.Drawing.Point(25, 92);
            this.dropPosTop.Name = "dropPosTop";
            this.dropPosTop.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.dropPosTop.Size = new System.Drawing.Size(104, 38);
            this.dropPosTop.Splitter = false;
            this.dropPosTop.TabIndex = 2;
            this.dropPosTop.Values.Text = "Position Top";
            this.dropPosTop.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // dropPosLeft
            // 
            this.dropPosLeft.DropDownPosition = Kiwi.ComponentFactory.Toolkit.VisualOrientation.Left;
            this.dropPosLeft.KiwiContextMenu = this.kcmDropDown;
            this.dropPosLeft.Location = new System.Drawing.Point(25, 61);
            this.dropPosLeft.Name = "dropPosLeft";
            this.dropPosLeft.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.dropPosLeft.Size = new System.Drawing.Size(104, 25);
            this.dropPosLeft.Splitter = false;
            this.dropPosLeft.TabIndex = 1;
            this.dropPosLeft.Values.Text = "Position Left";
            this.dropPosLeft.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // dropPosRight
            // 
            this.dropPosRight.KiwiContextMenu = this.kcmDropDown;
            this.dropPosRight.Location = new System.Drawing.Point(25, 30);
            this.dropPosRight.Name = "dropPosRight";
            this.dropPosRight.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.dropPosRight.Size = new System.Drawing.Size(104, 25);
            this.dropPosRight.Splitter = false;
            this.dropPosRight.TabIndex = 0;
            this.dropPosRight.Values.Text = "Position Right";
            this.dropPosRight.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // groupCustom
            // 
            this.groupCustom.Controls.Add(this.dropCustom);
            this.groupCustom.Controls.Add(this.splitterCustom);
            this.groupCustom.Location = new System.Drawing.Point(12, 407);
            this.groupCustom.Name = "groupCustom";
            this.groupCustom.Size = new System.Drawing.Size(288, 113);
            this.groupCustom.TabIndex = 2;
            this.groupCustom.TabStop = false;
            this.groupCustom.Text = "Custom";
            // 
            // dropCustom
            // 
            this.dropCustom.DropDownPosition = Kiwi.ComponentFactory.Toolkit.VisualOrientation.Bottom;
            this.dropCustom.Images.Normal = ((System.Drawing.Image)(resources.GetObject("dropCustom.Images.Normal")));
            this.dropCustom.Images.Pressed = ((System.Drawing.Image)(resources.GetObject("dropCustom.Images.Pressed")));
            this.dropCustom.Images.Tracking = ((System.Drawing.Image)(resources.GetObject("dropCustom.Images.Tracking")));
            this.dropCustom.KiwiContextMenu = this.kcmCustom;
            this.dropCustom.Location = new System.Drawing.Point(158, 30);
            this.dropCustom.Name = "dropCustom";
            this.dropCustom.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dropCustom.OverrideDefault.Border.Color1 = System.Drawing.Color.Green;
            this.dropCustom.OverrideDefault.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.dropCustom.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dropCustom.Size = new System.Drawing.Size(115, 52);
            this.dropCustom.Splitter = false;
            this.dropCustom.StateCommon.Back.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Solid;
            this.dropCustom.StateCommon.Border.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Solid;
            this.dropCustom.StateCommon.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.dropCustom.StateCommon.Border.Rounding = 4;
            this.dropCustom.StateCommon.Border.Width = 2;
            this.dropCustom.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dropCustom.StateNormal.Back.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Solid;
            this.dropCustom.StateNormal.Border.Color1 = System.Drawing.Color.Green;
            this.dropCustom.StateNormal.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.dropCustom.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dropCustom.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dropCustom.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dropCustom.StatePressed.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.dropCustom.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dropCustom.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dropCustom.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.dropCustom.StateTracking.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.dropCustom.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dropCustom.TabIndex = 1;
            this.dropCustom.Values.Text = "Custom DropDown";
            this.dropCustom.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // kcmCustom
            // 
            this.kcmCustom.Items.AddRange(new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItemBase[] {
            this.kiwiContextMenuHeading5,
            this.kiwiContextMenuItems5});
            this.kcmCustom.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.ProfessionalSystem;
            this.kcmCustom.StateCommon.ControlInner.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kcmCustom.StateCommon.ControlInner.Back.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Solid;
            this.kcmCustom.StateCommon.ControlInner.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.kcmCustom.StateCommon.ControlInner.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.kcmCustom.StateCommon.ControlInner.Border.GraphicsHint = Kiwi.ComponentFactory.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kcmCustom.StateCommon.ControlInner.Border.Rounding = 4;
            this.kcmCustom.StateCommon.ControlInner.Border.Width = 2;
            this.kcmCustom.StateCommon.ControlOuter.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kcmCustom.StateCommon.ControlOuter.Back.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Solid;
            this.kcmCustom.StateCommon.ControlOuter.Border.Color1 = System.Drawing.Color.Green;
            this.kcmCustom.StateCommon.ControlOuter.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.kcmCustom.StateCommon.ControlOuter.Border.GraphicsHint = Kiwi.ComponentFactory.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kcmCustom.StateCommon.ControlOuter.Border.Rounding = 4;
            this.kcmCustom.StateCommon.ControlOuter.Border.Width = 2;
            this.kcmCustom.StateCommon.Heading.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kcmCustom.StateCommon.Heading.Back.Color2 = System.Drawing.Color.Lime;
            this.kcmCustom.StateCommon.Heading.Back.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Linear;
            this.kcmCustom.StateCommon.Heading.Border.Color1 = System.Drawing.Color.Green;
            this.kcmCustom.StateCommon.Heading.Border.Color2 = System.Drawing.Color.Green;
            this.kcmCustom.StateCommon.Heading.Border.DrawBorders = Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom;
            this.kcmCustom.StateCommon.Heading.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kcmCustom.StateCommon.ItemImageColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(254)))), ((int)(((byte)(188)))));
            this.kcmCustom.StateCommon.ItemImageColumn.Back.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Solid;
            this.kcmCustom.StateCommon.ItemImageColumn.Border.Color1 = System.Drawing.Color.Teal;
            this.kcmCustom.StateCommon.ItemImageColumn.Border.DrawBorders = Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.None;
            this.kcmCustom.StateCommon.ItemTextStandard.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            // 
            // kiwiContextMenuHeading5
            // 
            this.kiwiContextMenuHeading5.ExtraText = "";
            // 
            // kiwiContextMenuItems5
            // 
            this.kiwiContextMenuItems5.Items.AddRange(new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItemBase[] {
            this.kiwiContextMenuItem13,
            this.kiwiContextMenuItem14,
            this.kiwiContextMenuItem15});
            // 
            // kiwiContextMenuItem13
            // 
            this.kiwiContextMenuItem13.Text = "Menu Item 1";
            // 
            // kiwiContextMenuItem14
            // 
            this.kiwiContextMenuItem14.Checked = true;
            this.kiwiContextMenuItem14.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.kiwiContextMenuItem14.Text = "Menu Item 2";
            // 
            // kiwiContextMenuItem15
            // 
            this.kiwiContextMenuItem15.Checked = true;
            this.kiwiContextMenuItem15.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kiwiContextMenuItem15.Text = "Menu Item 3";
            // 
            // splitterCustom
            // 
            this.splitterCustom.Images.Normal = ((System.Drawing.Image)(resources.GetObject("splitterCustom.Images.Normal")));
            this.splitterCustom.Images.Pressed = ((System.Drawing.Image)(resources.GetObject("splitterCustom.Images.Pressed")));
            this.splitterCustom.Images.Tracking = ((System.Drawing.Image)(resources.GetObject("splitterCustom.Images.Tracking")));
            this.splitterCustom.KiwiContextMenu = this.kcmCustom;
            this.splitterCustom.Location = new System.Drawing.Point(16, 40);
            this.splitterCustom.Name = "splitterCustom";
            this.splitterCustom.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.splitterCustom.OverrideDefault.Border.Color1 = System.Drawing.Color.Green;
            this.splitterCustom.OverrideDefault.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.splitterCustom.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.splitterCustom.Size = new System.Drawing.Size(122, 30);
            this.splitterCustom.StateCommon.Back.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Solid;
            this.splitterCustom.StateCommon.Border.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Solid;
            this.splitterCustom.StateCommon.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.splitterCustom.StateCommon.Border.Rounding = 4;
            this.splitterCustom.StateCommon.Border.Width = 2;
            this.splitterCustom.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.splitterCustom.StateNormal.Back.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Solid;
            this.splitterCustom.StateNormal.Border.Color1 = System.Drawing.Color.Green;
            this.splitterCustom.StateNormal.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.splitterCustom.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.splitterCustom.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.splitterCustom.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.splitterCustom.StatePressed.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.splitterCustom.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.splitterCustom.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.splitterCustom.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.splitterCustom.StateTracking.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                        | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.splitterCustom.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.splitterCustom.TabIndex = 0;
            this.splitterCustom.Values.Text = "Custom Splitter";
            this.splitterCustom.Enter += new System.EventHandler(this.dropButtonEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 561);
            this.Controls.Add(this.groupCustom);
            this.Controls.Add(this.groupDropDown);
            this.Controls.Add(this.groupSplitter);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupProperties);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "KiwiDropButton Examples";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupProperties.ResumeLayout(false);
            this.groupSplitter.ResumeLayout(false);
            this.groupDropDown.ResumeLayout(false);
            this.groupCustom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupProperties;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.GroupBox groupSplitter;
        private Kiwi.ComponentFactory.Toolkit.KiwiDropButton splitterPosBottom;
        private Kiwi.ComponentFactory.Toolkit.KiwiDropButton splitterPosTop;
        private Kiwi.ComponentFactory.Toolkit.KiwiDropButton splitterPosLeft;
        private Kiwi.ComponentFactory.Toolkit.KiwiDropButton splitterPosRight;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenu kcmDropDown;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenuHeading kiwiContextMenuHeading1;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItems kiwiContextMenuItems1;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem kiwiContextMenuItem1;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem kiwiContextMenuItem2;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem kiwiContextMenuItem3;
        private Kiwi.ComponentFactory.Toolkit.KiwiDropButton splitterArrowLeft;
        private Kiwi.ComponentFactory.Toolkit.KiwiDropButton splitterArrowRight;
        private Kiwi.ComponentFactory.Toolkit.KiwiDropButton splitterArrowUp;
        private Kiwi.ComponentFactory.Toolkit.KiwiDropButton splitterArrowDown;
        private System.Windows.Forms.GroupBox groupDropDown;
        private Kiwi.ComponentFactory.Toolkit.KiwiDropButton dropArrowLeft;
        private Kiwi.ComponentFactory.Toolkit.KiwiDropButton dropArrowRight;
        private Kiwi.ComponentFactory.Toolkit.KiwiDropButton dropArrowUp;
        private Kiwi.ComponentFactory.Toolkit.KiwiDropButton dropArrowDown;
        private Kiwi.ComponentFactory.Toolkit.KiwiDropButton dropPosBottom;
        private Kiwi.ComponentFactory.Toolkit.KiwiDropButton dropPosTop;
        private Kiwi.ComponentFactory.Toolkit.KiwiDropButton dropPosLeft;
        private Kiwi.ComponentFactory.Toolkit.KiwiDropButton dropPosRight;
        private System.Windows.Forms.GroupBox groupCustom;
        private Kiwi.ComponentFactory.Toolkit.KiwiDropButton splitterCustom;
        private Kiwi.ComponentFactory.Toolkit.KiwiDropButton dropCustom;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenu kcmCustom;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenuHeading kiwiContextMenuHeading5;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItems kiwiContextMenuItems5;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem kiwiContextMenuItem13;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem kiwiContextMenuItem14;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem kiwiContextMenuItem15;
    }
}

