
namespace Ribbon_ToolTips
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
            this.kiwiRibbon1 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbon();
            this.qatSave = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonQATButton();
            this.qatUndo = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonQATButton();
            this.qatRedo = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonQATButton();
            this.kiwiContextMenuItem1 = new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem();
            this.tabHome = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonTab();
            this.kiwiRibbonGroup1 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroup();
            this.kiwiRibbonGroupTriple1 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupTriple();
            this.kiwiRibbonGroupButton1 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton();
            this.cmsPaste = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteSpecialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiwiRibbonGroupTriple2 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupTriple();
            this.kiwiRibbonGroupButton2 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton();
            this.kiwiRibbonGroupButton3 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton();
            this.kiwiRibbonGroupButton4 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton();
            this.kiwiRibbonGroup2 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroup();
            this.kiwiRibbonGroupTriple3 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupTriple();
            this.kiwiRibbonGroupButton5 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton();
            this.kiwiRibbonGroupButton7 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton();
            this.kiwiRibbonGroupTriple4 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupTriple();
            this.kiwiRibbonGroupButton6 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton();
            this.cmsBusinessCards = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.otherBusinessCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiwiRibbonGroupButton8 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton();
            this.kiwiRibbonGroupButton9 = new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton();
            this.cmsSignatures = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.signaturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiwiPanel = new Kiwi.ComponentFactory.Toolkit.KiwiPanel();
            this.kiwiLabel = new Kiwi.ComponentFactory.Toolkit.KiwiLabel();
            this.kiwiManager = new Kiwi.ComponentFactory.Toolkit.KiwiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiRibbon1)).BeginInit();
            this.cmsPaste.SuspendLayout();
            this.cmsBusinessCards.SuspendLayout();
            this.cmsSignatures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPanel)).BeginInit();
            this.kiwiPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kiwiRibbon1
            // 
            this.kiwiRibbon1.HideRibbonSize = new System.Drawing.Size(300, 150);
            this.kiwiRibbon1.Name = "kiwiRibbon1";
            this.kiwiRibbon1.QATButtons.AddRange(new System.ComponentModel.Component[] {
            this.qatSave,
            this.qatUndo,
            this.qatRedo});
            this.kiwiRibbon1.RibbonAppButton.AppButtonMenuItems.AddRange(new Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItemBase[] {
            this.kiwiContextMenuItem1});
            this.kiwiRibbon1.RibbonAppButton.AppButtonShowRecentDocs = false;
            this.kiwiRibbon1.RibbonAppButton.AppButtonToolTipBody = "  Click here to open, save, or print,\r\n  and to see everything else you can\r\n  do" +
                " with your document.";
            this.kiwiRibbon1.RibbonAppButton.AppButtonToolTipTitle = "Office Button";
            this.kiwiRibbon1.RibbonTabs.AddRange(new Kiwi.ComponentFactory.Ribbon.KiwiRibbonTab[] {
            this.tabHome});
            this.kiwiRibbon1.SelectedTab = this.tabHome;
            this.kiwiRibbon1.Size = new System.Drawing.Size(408, 115);
            this.kiwiRibbon1.TabIndex = 0;
            // 
            // qatSave
            // 
            this.qatSave.Image = ((System.Drawing.Image)(resources.GetObject("qatSave.Image")));
            this.qatSave.Tag = null;
            this.qatSave.Text = "Save";
            this.qatSave.ToolTipBody = "Save (Ctrl + S)";
            // 
            // qatUndo
            // 
            this.qatUndo.Image = ((System.Drawing.Image)(resources.GetObject("qatUndo.Image")));
            this.qatUndo.Tag = null;
            this.qatUndo.Text = "Undo";
            this.qatUndo.ToolTipBody = "Undo (Ctrl + Z)";
            // 
            // qatRedo
            // 
            this.qatRedo.Image = ((System.Drawing.Image)(resources.GetObject("qatRedo.Image")));
            this.qatRedo.Tag = null;
            this.qatRedo.Text = "Redo";
            this.qatRedo.ToolTipBody = "Redo (Ctrl + Y)";
            // 
            // kiwiContextMenuItem1
            // 
            this.kiwiContextMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("kiwiContextMenuItem1.Image")));
            this.kiwiContextMenuItem1.Text = "E&xit";
            this.kiwiContextMenuItem1.Click += new System.EventHandler(this.appMenu_Click);
            // 
            // tabHome
            // 
            this.tabHome.Groups.AddRange(new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroup[] {
            this.kiwiRibbonGroup1,
            this.kiwiRibbonGroup2});
            this.tabHome.KeyTip = "H";
            this.tabHome.Tag = null;
            this.tabHome.Text = "Home";
            // 
            // kiwiRibbonGroup1
            // 
            this.kiwiRibbonGroup1.AllowCollapsed = false;
            this.kiwiRibbonGroup1.DialogBoxLauncher = false;
            this.kiwiRibbonGroup1.Image = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroup1.Image")));
            this.kiwiRibbonGroup1.Items.AddRange(new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupContainer[] {
            this.kiwiRibbonGroupTriple1,
            this.kiwiRibbonGroupTriple2});
            this.kiwiRibbonGroup1.KeyTipDialogLauncher = "FO";
            this.kiwiRibbonGroup1.Tag = null;
            this.kiwiRibbonGroup1.TextLine1 = "Clipboard";
            // 
            // kiwiRibbonGroupTriple1
            // 
            this.kiwiRibbonGroupTriple1.Items.AddRange(new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupItem[] {
            this.kiwiRibbonGroupButton1});
            this.kiwiRibbonGroupTriple1.Tag = null;
            // 
            // kiwiRibbonGroupButton1
            // 
            this.kiwiRibbonGroupButton1.ButtonType = Kiwi.ComponentFactory.Ribbon.GroupButtonType.Split;
            this.kiwiRibbonGroupButton1.ContextMenuStrip = this.cmsPaste;
            this.kiwiRibbonGroupButton1.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroupButton1.ImageLarge")));
            this.kiwiRibbonGroupButton1.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroupButton1.ImageSmall")));
            this.kiwiRibbonGroupButton1.KeyTip = "V";
            this.kiwiRibbonGroupButton1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.kiwiRibbonGroupButton1.Tag = null;
            this.kiwiRibbonGroupButton1.TextLine1 = "Paste";
            this.kiwiRibbonGroupButton1.ToolTipBody = "  Paste the contents of the\r\n  Clipboard.";
            this.kiwiRibbonGroupButton1.ToolTipTitle = "Paste (Ctrl + V)";
            // 
            // cmsPaste
            // 
            this.cmsPaste.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cmsPaste.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasteToolStripMenuItem,
            this.pasteSpecialToolStripMenuItem});
            this.cmsPaste.Name = "cmsPaste";
            this.cmsPaste.Size = new System.Drawing.Size(141, 48);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // pasteSpecialToolStripMenuItem
            // 
            this.pasteSpecialToolStripMenuItem.Name = "pasteSpecialToolStripMenuItem";
            this.pasteSpecialToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.pasteSpecialToolStripMenuItem.Text = "Paste Special";
            // 
            // kiwiRibbonGroupTriple2
            // 
            this.kiwiRibbonGroupTriple2.Items.AddRange(new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupItem[] {
            this.kiwiRibbonGroupButton2,
            this.kiwiRibbonGroupButton3,
            this.kiwiRibbonGroupButton4});
            this.kiwiRibbonGroupTriple2.MaximumSize = Kiwi.ComponentFactory.Ribbon.GroupItemSize.Medium;
            this.kiwiRibbonGroupTriple2.Tag = null;
            // 
            // kiwiRibbonGroupButton2
            // 
            this.kiwiRibbonGroupButton2.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroupButton2.ImageLarge")));
            this.kiwiRibbonGroupButton2.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroupButton2.ImageSmall")));
            this.kiwiRibbonGroupButton2.KeyTip = "X";
            this.kiwiRibbonGroupButton2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.kiwiRibbonGroupButton2.Tag = null;
            this.kiwiRibbonGroupButton2.TextLine1 = "Cut";
            this.kiwiRibbonGroupButton2.ToolTipBody = "  Cut the selection from the\r\n  document and put it on the\r\n  Clipboard.";
            this.kiwiRibbonGroupButton2.ToolTipTitle = "Cut  (Ctrl + X)";
            // 
            // kiwiRibbonGroupButton3
            // 
            this.kiwiRibbonGroupButton3.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroupButton3.ImageLarge")));
            this.kiwiRibbonGroupButton3.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroupButton3.ImageSmall")));
            this.kiwiRibbonGroupButton3.KeyTip = "C";
            this.kiwiRibbonGroupButton3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kiwiRibbonGroupButton3.Tag = null;
            this.kiwiRibbonGroupButton3.TextLine1 = "Copy";
            this.kiwiRibbonGroupButton3.ToolTipBody = "  Copy the selection and put it on\r\n  the Clipboard.";
            this.kiwiRibbonGroupButton3.ToolTipTitle = "Copy (Ctrl + C)";
            // 
            // kiwiRibbonGroupButton4
            // 
            this.kiwiRibbonGroupButton4.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroupButton4.ImageLarge")));
            this.kiwiRibbonGroupButton4.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroupButton4.ImageSmall")));
            this.kiwiRibbonGroupButton4.KeyTip = "FP";
            this.kiwiRibbonGroupButton4.Tag = null;
            this.kiwiRibbonGroupButton4.TextLine1 = "Format";
            this.kiwiRibbonGroupButton4.TextLine2 = "Painter";
            this.kiwiRibbonGroupButton4.ToolTipBody = "  Copy formatting from one place\r\n  and apply it to another.\r\n\r\n  Double-click th" +
                "is button to apply\r\n  the same formatting to multiple\r\n  places in the document." +
                "";
            this.kiwiRibbonGroupButton4.ToolTipTitle = "Format Painter";
            // 
            // kiwiRibbonGroup2
            // 
            this.kiwiRibbonGroup2.AllowCollapsed = false;
            this.kiwiRibbonGroup2.DialogBoxLauncher = false;
            this.kiwiRibbonGroup2.Image = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroup2.Image")));
            this.kiwiRibbonGroup2.Items.AddRange(new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupContainer[] {
            this.kiwiRibbonGroupTriple3,
            this.kiwiRibbonGroupTriple4});
            this.kiwiRibbonGroup2.KeyTipDialogLauncher = "AP";
            this.kiwiRibbonGroup2.KeyTipGroup = "ZC";
            this.kiwiRibbonGroup2.Tag = null;
            this.kiwiRibbonGroup2.TextLine1 = "Include";
            // 
            // kiwiRibbonGroupTriple3
            // 
            this.kiwiRibbonGroupTriple3.Items.AddRange(new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupItem[] {
            this.kiwiRibbonGroupButton5,
            this.kiwiRibbonGroupButton7});
            this.kiwiRibbonGroupTriple3.Tag = null;
            // 
            // kiwiRibbonGroupButton5
            // 
            this.kiwiRibbonGroupButton5.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroupButton5.ImageLarge")));
            this.kiwiRibbonGroupButton5.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroupButton5.ImageSmall")));
            this.kiwiRibbonGroupButton5.KeyTip = "AF";
            this.kiwiRibbonGroupButton5.Tag = null;
            this.kiwiRibbonGroupButton5.TextLine1 = "Attach";
            this.kiwiRibbonGroupButton5.TextLine2 = "File";
            this.kiwiRibbonGroupButton5.ToolTipBody = "Attach a file to this item.";
            this.kiwiRibbonGroupButton5.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroupButton5.ToolTipImage")));
            this.kiwiRibbonGroupButton5.ToolTipTitle = "Attach File";
            // 
            // kiwiRibbonGroupButton7
            // 
            this.kiwiRibbonGroupButton7.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroupButton7.ImageLarge")));
            this.kiwiRibbonGroupButton7.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroupButton7.ImageSmall")));
            this.kiwiRibbonGroupButton7.KeyTip = "AM";
            this.kiwiRibbonGroupButton7.Tag = null;
            this.kiwiRibbonGroupButton7.TextLine1 = "Attach";
            this.kiwiRibbonGroupButton7.TextLine2 = "Item";
            this.kiwiRibbonGroupButton7.ToolTipBody = " Attach another Outlook item to\r\n this item.";
            this.kiwiRibbonGroupButton7.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroupButton7.ToolTipImage")));
            this.kiwiRibbonGroupButton7.ToolTipTitle = "Attach Item";
            // 
            // kiwiRibbonGroupTriple4
            // 
            this.kiwiRibbonGroupTriple4.Items.AddRange(new Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupItem[] {
            this.kiwiRibbonGroupButton6,
            this.kiwiRibbonGroupButton8,
            this.kiwiRibbonGroupButton9});
            this.kiwiRibbonGroupTriple4.Tag = null;
            // 
            // kiwiRibbonGroupButton6
            // 
            this.kiwiRibbonGroupButton6.ButtonType = Kiwi.ComponentFactory.Ribbon.GroupButtonType.DropDown;
            this.kiwiRibbonGroupButton6.ContextMenuStrip = this.cmsBusinessCards;
            this.kiwiRibbonGroupButton6.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroupButton6.ImageLarge")));
            this.kiwiRibbonGroupButton6.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroupButton6.ImageSmall")));
            this.kiwiRibbonGroupButton6.KeyTip = "AA";
            this.kiwiRibbonGroupButton6.Tag = null;
            this.kiwiRibbonGroupButton6.TextLine1 = "Business";
            this.kiwiRibbonGroupButton6.TextLine2 = "Card";
            this.kiwiRibbonGroupButton6.ToolTipBody = " Attach an electronic business card\r\n to this message.";
            this.kiwiRibbonGroupButton6.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroupButton6.ToolTipImage")));
            this.kiwiRibbonGroupButton6.ToolTipTitle = "Insert Business Card";
            // 
            // cmsBusinessCards
            // 
            this.cmsBusinessCards.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cmsBusinessCards.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otherBusinessCardsToolStripMenuItem});
            this.cmsBusinessCards.Name = "cmsBusinessCards";
            this.cmsBusinessCards.Size = new System.Drawing.Size(194, 26);
            // 
            // otherBusinessCardsToolStripMenuItem
            // 
            this.otherBusinessCardsToolStripMenuItem.Name = "otherBusinessCardsToolStripMenuItem";
            this.otherBusinessCardsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.otherBusinessCardsToolStripMenuItem.Text = "Other Business Cards...";
            // 
            // kiwiRibbonGroupButton8
            // 
            this.kiwiRibbonGroupButton8.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroupButton8.ImageLarge")));
            this.kiwiRibbonGroupButton8.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroupButton8.ImageSmall")));
            this.kiwiRibbonGroupButton8.KeyTip = "OC";
            this.kiwiRibbonGroupButton8.Tag = null;
            this.kiwiRibbonGroupButton8.TextLine1 = "Calendar";
            this.kiwiRibbonGroupButton8.ToolTipBody = " Attach your calendar information\r\n to this message.";
            this.kiwiRibbonGroupButton8.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroupButton8.ToolTipImage")));
            this.kiwiRibbonGroupButton8.ToolTipTitle = "Insert Calendar";
            // 
            // kiwiRibbonGroupButton9
            // 
            this.kiwiRibbonGroupButton9.ButtonType = Kiwi.ComponentFactory.Ribbon.GroupButtonType.DropDown;
            this.kiwiRibbonGroupButton9.ContextMenuStrip = this.cmsSignatures;
            this.kiwiRibbonGroupButton9.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroupButton9.ImageLarge")));
            this.kiwiRibbonGroupButton9.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroupButton9.ImageSmall")));
            this.kiwiRibbonGroupButton9.KeyTip = "G";
            this.kiwiRibbonGroupButton9.Tag = null;
            this.kiwiRibbonGroupButton9.TextLine1 = "Signature";
            this.kiwiRibbonGroupButton9.ToolTipBody = " Attach one of your e-mail\r\n signatures to this message.";
            this.kiwiRibbonGroupButton9.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("kiwiRibbonGroupButton9.ToolTipImage")));
            this.kiwiRibbonGroupButton9.ToolTipTitle = "Signature";
            // 
            // cmsSignatures
            // 
            this.cmsSignatures.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cmsSignatures.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signaturesToolStripMenuItem});
            this.cmsSignatures.Name = "cmsSignatures";
            this.cmsSignatures.Size = new System.Drawing.Size(139, 26);
            // 
            // signaturesToolStripMenuItem
            // 
            this.signaturesToolStripMenuItem.Name = "signaturesToolStripMenuItem";
            this.signaturesToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.signaturesToolStripMenuItem.Text = "Signatures...";
            // 
            // kiwiPanel
            // 
            this.kiwiPanel.Controls.Add(this.kiwiLabel);
            this.kiwiPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiwiPanel.Location = new System.Drawing.Point(0, 115);
            this.kiwiPanel.Name = "kiwiPanel";
            this.kiwiPanel.Size = new System.Drawing.Size(408, 179);
            this.kiwiPanel.TabIndex = 1;
            // 
            // kiwiLabel
            // 
            this.kiwiLabel.Location = new System.Drawing.Point(12, 14);
            this.kiwiLabel.Name = "kiwiLabel";
            this.kiwiLabel.Size = new System.Drawing.Size(391, 132);
            this.kiwiLabel.TabIndex = 0;
            this.kiwiLabel.Values.Text = resources.GetString("kiwiLabel.Values.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 294);
            this.Controls.Add(this.kiwiPanel);
            this.Controls.Add(this.kiwiRibbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ribbon ToolTips";
            ((System.ComponentModel.ISupportInitialize)(this.kiwiRibbon1)).EndInit();
            this.cmsPaste.ResumeLayout(false);
            this.cmsBusinessCards.ResumeLayout(false);
            this.cmsSignatures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiPanel)).EndInit();
            this.kiwiPanel.ResumeLayout(false);
            this.kiwiPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Kiwi.ComponentFactory.Ribbon.KiwiRibbon kiwiRibbon1;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonTab tabHome;
        private Kiwi.ComponentFactory.Toolkit.KiwiPanel kiwiPanel;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroup kiwiRibbonGroup1;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupTriple kiwiRibbonGroupTriple1;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton kiwiRibbonGroupButton1;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupTriple kiwiRibbonGroupTriple2;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton kiwiRibbonGroupButton2;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton kiwiRibbonGroupButton3;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton kiwiRibbonGroupButton4;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroup kiwiRibbonGroup2;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupTriple kiwiRibbonGroupTriple3;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton kiwiRibbonGroupButton5;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton kiwiRibbonGroupButton7;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupTriple kiwiRibbonGroupTriple4;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton kiwiRibbonGroupButton6;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton kiwiRibbonGroupButton8;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonGroupButton kiwiRibbonGroupButton9;
        private System.Windows.Forms.ContextMenuStrip cmsPaste;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteSpecialToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsBusinessCards;
        private System.Windows.Forms.ToolStripMenuItem otherBusinessCardsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsSignatures;
        private System.Windows.Forms.ToolStripMenuItem signaturesToolStripMenuItem;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonQATButton qatSave;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonQATButton qatUndo;
        private Kiwi.ComponentFactory.Ribbon.KiwiRibbonQATButton qatRedo;
        private Kiwi.ComponentFactory.Toolkit.KiwiLabel kiwiLabel;
        private Kiwi.ComponentFactory.Toolkit.KiwiManager kiwiManager;
        private Kiwi.ComponentFactory.Toolkit.KiwiContextMenuItem kiwiContextMenuItem1;
    }
}

