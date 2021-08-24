
namespace KiwiCheckSet_Examples
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.thetaSparkle = new Kiwi.ComponentFactory.Toolkit.KiwiCheckButton();
            this.gammaSparkle = new Kiwi.ComponentFactory.Toolkit.KiwiCheckButton();
            this.betaSparkle = new Kiwi.ComponentFactory.Toolkit.KiwiCheckButton();
            this.alphaSparkle = new Kiwi.ComponentFactory.Toolkit.KiwiCheckButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.thetaSystem = new Kiwi.ComponentFactory.Toolkit.KiwiCheckButton();
            this.alphaSystem = new Kiwi.ComponentFactory.Toolkit.KiwiCheckButton();
            this.gammaSystem = new Kiwi.ComponentFactory.Toolkit.KiwiCheckButton();
            this.betaSystem = new Kiwi.ComponentFactory.Toolkit.KiwiCheckButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.forwardCheckButton = new Kiwi.ComponentFactory.Toolkit.KiwiCheckButton();
            this.rewindCheckButton = new Kiwi.ComponentFactory.Toolkit.KiwiCheckButton();
            this.pauseCheckButton = new Kiwi.ComponentFactory.Toolkit.KiwiCheckButton();
            this.playCheckButton = new Kiwi.ComponentFactory.Toolkit.KiwiCheckButton();
            this.buttonClose = new System.Windows.Forms.Button();
            this.kiwiCheckSetOffice = new Kiwi.ComponentFactory.Toolkit.KiwiCheckSet(this.components);
            this.kiwiCheckSetSystem = new Kiwi.ComponentFactory.Toolkit.KiwiCheckSet(this.components);
            this.kiwiCheckSetCustom = new Kiwi.ComponentFactory.Toolkit.KiwiCheckSet(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiCheckSetOffice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiCheckSetSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiCheckSetCustom)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.thetaSparkle);
            this.groupBox1.Controls.Add(this.gammaSparkle);
            this.groupBox1.Controls.Add(this.betaSparkle);
            this.groupBox1.Controls.Add(this.alphaSparkle);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sparkle - Blue";
            // 
            // thetaSparkle
            // 
            this.thetaSparkle.Location = new System.Drawing.Point(241, 30);
            this.thetaSparkle.Name = "thetaSparkle";
            this.thetaSparkle.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.SparkleBlue;
            this.thetaSparkle.Size = new System.Drawing.Size(69, 25);
            this.thetaSparkle.TabIndex = 3;
            this.thetaSparkle.Values.Text = "Theta";
            // 
            // gammaSparkle
            // 
            this.gammaSparkle.Location = new System.Drawing.Point(166, 30);
            this.gammaSparkle.Name = "gammaSparkle";
            this.gammaSparkle.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.SparkleBlue;
            this.gammaSparkle.Size = new System.Drawing.Size(69, 25);
            this.gammaSparkle.TabIndex = 2;
            this.gammaSparkle.Values.Text = "Gamma";
            // 
            // betaSparkle
            // 
            this.betaSparkle.Location = new System.Drawing.Point(91, 30);
            this.betaSparkle.Name = "betaSparkle";
            this.betaSparkle.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.SparkleBlue;
            this.betaSparkle.Size = new System.Drawing.Size(69, 25);
            this.betaSparkle.TabIndex = 1;
            this.betaSparkle.Values.Text = "Beta";
            // 
            // alphaSparkle
            // 
            this.alphaSparkle.Checked = true;
            this.alphaSparkle.Location = new System.Drawing.Point(16, 30);
            this.alphaSparkle.Name = "alphaSparkle";
            this.alphaSparkle.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.SparkleBlue;
            this.alphaSparkle.Size = new System.Drawing.Size(69, 25);
            this.alphaSparkle.TabIndex = 0;
            this.alphaSparkle.Values.Text = "Alpha";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.thetaSystem);
            this.groupBox2.Controls.Add(this.alphaSystem);
            this.groupBox2.Controls.Add(this.gammaSystem);
            this.groupBox2.Controls.Add(this.betaSystem);
            this.groupBox2.Location = new System.Drawing.Point(13, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 88);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Office 2007 - Blue";
            // 
            // thetaSystem
            // 
            this.thetaSystem.Location = new System.Drawing.Point(241, 34);
            this.thetaSystem.Name = "thetaSystem";
            this.thetaSystem.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2007Blue;
            this.thetaSystem.Size = new System.Drawing.Size(69, 25);
            this.thetaSystem.TabIndex = 3;
            this.thetaSystem.Values.Text = "Theta";
            // 
            // alphaSystem
            // 
            this.alphaSystem.Checked = true;
            this.alphaSystem.Location = new System.Drawing.Point(16, 34);
            this.alphaSystem.Name = "alphaSystem";
            this.alphaSystem.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2007Blue;
            this.alphaSystem.Size = new System.Drawing.Size(69, 25);
            this.alphaSystem.TabIndex = 0;
            this.alphaSystem.Values.Text = "Alpha";
            // 
            // gammaSystem
            // 
            this.gammaSystem.Location = new System.Drawing.Point(166, 34);
            this.gammaSystem.Name = "gammaSystem";
            this.gammaSystem.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2007Blue;
            this.gammaSystem.Size = new System.Drawing.Size(69, 25);
            this.gammaSystem.TabIndex = 2;
            this.gammaSystem.Values.Text = "Gamma";
            // 
            // betaSystem
            // 
            this.betaSystem.Location = new System.Drawing.Point(91, 34);
            this.betaSystem.Name = "betaSystem";
            this.betaSystem.PaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteMode.Office2007Blue;
            this.betaSystem.Size = new System.Drawing.Size(69, 25);
            this.betaSystem.TabIndex = 1;
            this.betaSystem.Values.Text = "Beta";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.forwardCheckButton);
            this.groupBox3.Controls.Add(this.rewindCheckButton);
            this.groupBox3.Controls.Add(this.pauseCheckButton);
            this.groupBox3.Controls.Add(this.playCheckButton);
            this.groupBox3.Location = new System.Drawing.Point(13, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 110);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Custom Settings";
            // 
            // forwardCheckButton
            // 
            this.forwardCheckButton.AutoSize = true;
            this.forwardCheckButton.Location = new System.Drawing.Point(228, 30);
            this.forwardCheckButton.Name = "forwardCheckButton";
            this.forwardCheckButton.Size = new System.Drawing.Size(61, 75);
            this.forwardCheckButton.StateCheckedNormal.Content.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.forwardCheckButton.StateCheckedPressed.Content.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.forwardCheckButton.StateCheckedTracking.Content.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.forwardCheckButton.StateCommon.Back.Draw = Kiwi.ComponentFactory.Toolkit.InheritBool.False;
            this.forwardCheckButton.StateCommon.Border.Draw = Kiwi.ComponentFactory.Toolkit.InheritBool.False;
            this.forwardCheckButton.StateCommon.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom) 
            | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left) 
            | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.forwardCheckButton.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.forwardCheckButton.StateCommon.Content.ShortText.TextV = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Far;
            this.forwardCheckButton.StatePressed.Content.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.forwardCheckButton.TabIndex = 3;
            this.forwardCheckButton.Values.Image = ((System.Drawing.Image)(resources.GetObject("forwardCheckButton.Values.Image")));
            this.forwardCheckButton.Values.ImageStates.ImageCheckedNormal = ((System.Drawing.Image)(resources.GetObject("forwardCheckButton.Values.ImageStates.ImageCheckedNormal")));
            this.forwardCheckButton.Values.ImageStates.ImageCheckedPressed = ((System.Drawing.Image)(resources.GetObject("forwardCheckButton.Values.ImageStates.ImageCheckedPressed")));
            this.forwardCheckButton.Values.ImageStates.ImageCheckedTracking = ((System.Drawing.Image)(resources.GetObject("forwardCheckButton.Values.ImageStates.ImageCheckedTracking")));
            this.forwardCheckButton.Values.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("forwardCheckButton.Values.ImageStates.ImagePressed")));
            this.forwardCheckButton.Values.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("forwardCheckButton.Values.ImageStates.ImageTracking")));
            this.forwardCheckButton.Values.Text = "Forward";
            // 
            // rewindCheckButton
            // 
            this.rewindCheckButton.AutoSize = true;
            this.rewindCheckButton.Location = new System.Drawing.Point(52, 30);
            this.rewindCheckButton.Name = "rewindCheckButton";
            this.rewindCheckButton.Size = new System.Drawing.Size(58, 75);
            this.rewindCheckButton.StateCheckedNormal.Content.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.rewindCheckButton.StateCheckedPressed.Content.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.rewindCheckButton.StateCheckedTracking.Content.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.rewindCheckButton.StateCommon.Back.Draw = Kiwi.ComponentFactory.Toolkit.InheritBool.False;
            this.rewindCheckButton.StateCommon.Border.Draw = Kiwi.ComponentFactory.Toolkit.InheritBool.False;
            this.rewindCheckButton.StateCommon.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom) 
            | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left) 
            | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.rewindCheckButton.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.rewindCheckButton.StateCommon.Content.ShortText.TextV = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Far;
            this.rewindCheckButton.StatePressed.Content.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.rewindCheckButton.TabIndex = 0;
            this.rewindCheckButton.Values.Image = ((System.Drawing.Image)(resources.GetObject("rewindCheckButton.Values.Image")));
            this.rewindCheckButton.Values.ImageStates.ImageCheckedNormal = ((System.Drawing.Image)(resources.GetObject("rewindCheckButton.Values.ImageStates.ImageCheckedNormal")));
            this.rewindCheckButton.Values.ImageStates.ImageCheckedPressed = ((System.Drawing.Image)(resources.GetObject("rewindCheckButton.Values.ImageStates.ImageCheckedPressed")));
            this.rewindCheckButton.Values.ImageStates.ImageCheckedTracking = ((System.Drawing.Image)(resources.GetObject("rewindCheckButton.Values.ImageStates.ImageCheckedTracking")));
            this.rewindCheckButton.Values.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("rewindCheckButton.Values.ImageStates.ImagePressed")));
            this.rewindCheckButton.Values.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("rewindCheckButton.Values.ImageStates.ImageTracking")));
            this.rewindCheckButton.Values.Text = "Rewind";
            // 
            // pauseCheckButton
            // 
            this.pauseCheckButton.AutoSize = true;
            this.pauseCheckButton.Location = new System.Drawing.Point(110, 30);
            this.pauseCheckButton.Name = "pauseCheckButton";
            this.pauseCheckButton.Size = new System.Drawing.Size(58, 75);
            this.pauseCheckButton.StateCheckedNormal.Content.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.pauseCheckButton.StateCheckedPressed.Content.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.pauseCheckButton.StateCheckedTracking.Content.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.pauseCheckButton.StateCommon.Back.Draw = Kiwi.ComponentFactory.Toolkit.InheritBool.False;
            this.pauseCheckButton.StateCommon.Border.Draw = Kiwi.ComponentFactory.Toolkit.InheritBool.False;
            this.pauseCheckButton.StateCommon.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom) 
            | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left) 
            | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.pauseCheckButton.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.pauseCheckButton.StateCommon.Content.ShortText.TextV = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Far;
            this.pauseCheckButton.StatePressed.Content.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.pauseCheckButton.TabIndex = 1;
            this.pauseCheckButton.Values.Image = ((System.Drawing.Image)(resources.GetObject("pauseCheckButton.Values.Image")));
            this.pauseCheckButton.Values.ImageStates.ImageCheckedNormal = ((System.Drawing.Image)(resources.GetObject("pauseCheckButton.Values.ImageStates.ImageCheckedNormal")));
            this.pauseCheckButton.Values.ImageStates.ImageCheckedPressed = ((System.Drawing.Image)(resources.GetObject("pauseCheckButton.Values.ImageStates.ImageCheckedPressed")));
            this.pauseCheckButton.Values.ImageStates.ImageCheckedTracking = ((System.Drawing.Image)(resources.GetObject("pauseCheckButton.Values.ImageStates.ImageCheckedTracking")));
            this.pauseCheckButton.Values.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("pauseCheckButton.Values.ImageStates.ImagePressed")));
            this.pauseCheckButton.Values.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("pauseCheckButton.Values.ImageStates.ImageTracking")));
            this.pauseCheckButton.Values.Text = "Pause";
            // 
            // playCheckButton
            // 
            this.playCheckButton.AutoSize = true;
            this.playCheckButton.Checked = true;
            this.playCheckButton.Location = new System.Drawing.Point(168, 30);
            this.playCheckButton.Name = "playCheckButton";
            this.playCheckButton.Size = new System.Drawing.Size(60, 77);
            this.playCheckButton.StateCheckedNormal.Content.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.playCheckButton.StateCheckedPressed.Content.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.playCheckButton.StateCheckedTracking.Content.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.playCheckButton.StateCommon.Back.Draw = Kiwi.ComponentFactory.Toolkit.InheritBool.False;
            this.playCheckButton.StateCommon.Border.Draw = Kiwi.ComponentFactory.Toolkit.InheritBool.False;
            this.playCheckButton.StateCommon.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom) 
            | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left) 
            | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.playCheckButton.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.playCheckButton.StateCommon.Content.ShortText.TextV = Kiwi.ComponentFactory.Toolkit.PaletteRelativeAlign.Far;
            this.playCheckButton.StatePressed.Content.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.playCheckButton.TabIndex = 2;
            this.playCheckButton.Values.Image = ((System.Drawing.Image)(resources.GetObject("playCheckButton.Values.Image")));
            this.playCheckButton.Values.ImageStates.ImageCheckedNormal = ((System.Drawing.Image)(resources.GetObject("playCheckButton.Values.ImageStates.ImageCheckedNormal")));
            this.playCheckButton.Values.ImageStates.ImageCheckedPressed = ((System.Drawing.Image)(resources.GetObject("playCheckButton.Values.ImageStates.ImageCheckedPressed")));
            this.playCheckButton.Values.ImageStates.ImageCheckedTracking = ((System.Drawing.Image)(resources.GetObject("playCheckButton.Values.ImageStates.ImageCheckedTracking")));
            this.playCheckButton.Values.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("playCheckButton.Values.ImageStates.ImagePressed")));
            this.playCheckButton.Values.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("playCheckButton.Values.ImageStates.ImageTracking")));
            this.playCheckButton.Values.Text = "Play";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(279, 312);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // kiwiCheckSetOffice
            // 
            this.kiwiCheckSetOffice.CheckButtons.Add(this.thetaSparkle);
            this.kiwiCheckSetOffice.CheckButtons.Add(this.gammaSparkle);
            this.kiwiCheckSetOffice.CheckButtons.Add(this.betaSparkle);
            this.kiwiCheckSetOffice.CheckButtons.Add(this.alphaSparkle);
            this.kiwiCheckSetOffice.CheckedButton = this.alphaSparkle;
            // 
            // kiwiCheckSetSystem
            // 
            this.kiwiCheckSetSystem.CheckButtons.Add(this.thetaSystem);
            this.kiwiCheckSetSystem.CheckButtons.Add(this.alphaSystem);
            this.kiwiCheckSetSystem.CheckButtons.Add(this.gammaSystem);
            this.kiwiCheckSetSystem.CheckButtons.Add(this.betaSystem);
            this.kiwiCheckSetSystem.CheckedButton = this.alphaSystem;
            // 
            // kiwiCheckSetCustom
            // 
            this.kiwiCheckSetCustom.CheckButtons.Add(this.forwardCheckButton);
            this.kiwiCheckSetCustom.CheckButtons.Add(this.rewindCheckButton);
            this.kiwiCheckSetCustom.CheckButtons.Add(this.pauseCheckButton);
            this.kiwiCheckSetCustom.CheckButtons.Add(this.playCheckButton);
            this.kiwiCheckSetCustom.CheckedButton = this.playCheckButton;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 345);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "KiwiCheckSet Examples";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiCheckSetOffice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiCheckSetSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiCheckSetCustom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckButton thetaSparkle;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckButton gammaSparkle;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckButton betaSparkle;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckButton alphaSparkle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonClose;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckButton thetaSystem;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckButton alphaSystem;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckButton gammaSystem;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckButton betaSystem;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckButton forwardCheckButton;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckButton rewindCheckButton;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckButton pauseCheckButton;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckButton playCheckButton;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckSet kiwiCheckSetOffice;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckSet kiwiCheckSetSystem;
        private Kiwi.ComponentFactory.Toolkit.KiwiCheckSet kiwiCheckSetCustom;
    }
}

