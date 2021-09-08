
namespace KiwiDataGridView_Examples
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.kiwiDataGridView1 = new Kiwi.ComponentFactory.Toolkit.KiwiDataGridView();
            this.colDateTime = new Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewDateTimePickerColumn();
            this.colComboBox = new Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewComboBoxColumn();
            this.colTextBox = new Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewTextBoxColumn();
            this.colMaskedTextBox = new Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewMaskedTextBoxColumn();
            this.colDomainUpDown = new Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewDomainUpDownColumn();
            this.colNumericUpDown = new Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewNumericUpDownColumn();
            this.colCheckBox = new Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewCheckBoxColumn();
            this.dataSet = new System.Data.DataSet();
            this.dtTestData = new System.Data.DataTable();
            this.dataDateTime = new System.Data.DataColumn();
            this.dataComboBox = new System.Data.DataColumn();
            this.dataTextBox = new System.Data.DataColumn();
            this.dataMaskedTextBox = new System.Data.DataColumn();
            this.dataDomainUpDown = new System.Data.DataColumn();
            this.dataNumericUpDown = new System.Data.DataColumn();
            this.dataButton = new System.Data.DataColumn();
            this.dataCheckBox = new System.Data.DataColumn();
            this.kiwiDataGridViewCheckBoxColumn1 = new Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewCheckBoxColumn();
            this.kiwiDataGridViewTextBoxColumn4 = new Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewTextBoxColumn();
            this.kiwiDataGridViewTextBoxColumn5 = new Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewTextBoxColumn();
            this.kiwiDataGridViewTextBoxColumn6 = new Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewTextBoxColumn();
            this.kiwiDataGridViewButtonColumn1 = new Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewButtonColumn();
            this.Column1 = new Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewCheckBoxColumn();
            this.kiwiDataGridViewTextBoxColumn1 = new Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewTextBoxColumn();
            this.kiwiDataGridViewTextBoxColumn2 = new Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewTextBoxColumn();
            this.kiwiDataGridViewTextBoxColumn3 = new Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewTextBoxColumn();
            this.Column2 = new Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewButtonColumn();
            this.groupBoxPalette = new System.Windows.Forms.GroupBox();
            this.rbOffice2010Blue = new System.Windows.Forms.RadioButton();
            this.rbSparkle = new System.Windows.Forms.RadioButton();
            this.rbSystem = new System.Windows.Forms.RadioButton();
            this.rbOffice2003 = new System.Windows.Forms.RadioButton();
            this.rbOffice2007Black = new System.Windows.Forms.RadioButton();
            this.rbOffice2007Blue = new System.Windows.Forms.RadioButton();
            this.rbStyleList = new System.Windows.Forms.RadioButton();
            this.groupBoxGridStyle = new System.Windows.Forms.GroupBox();
            this.rbStyleCustom = new System.Windows.Forms.RadioButton();
            this.rbStyleSheet = new System.Windows.Forms.RadioButton();
            this.kiwiPalette = new Kiwi.ComponentFactory.Toolkit.KiwiPalette(this.components);
            this.kiwiManager = new Kiwi.ComponentFactory.Toolkit.KiwiManager(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonClearCellColors = new Kiwi.ComponentFactory.Toolkit.KiwiButton();
            this.buttonRandomCellColors = new Kiwi.ComponentFactory.Toolkit.KiwiButton();
            this.lbPropChanges = new Kiwi.ComponentFactory.Toolkit.KiwiListBox();
            this.btnCompare = new Kiwi.ComponentFactory.Toolkit.KiwiButton();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwiDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTestData)).BeginInit();
            this.groupBoxPalette.SuspendLayout();
            this.groupBoxGridStyle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(995, 462);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.propertyGrid);
            this.groupBox4.Location = new System.Drawing.Point(818, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(252, 437);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Properties for KiwiDataGridView";
            // 
            // propertyGrid
            // 
            this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid.Location = new System.Drawing.Point(6, 19);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(240, 412);
            this.propertyGrid.TabIndex = 0;
            this.propertyGrid.ToolbarVisible = false;
            // 
            // kiwiDataGridView1
            // 
            this.kiwiDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
            this.kiwiDataGridView1.AutoGenerateColumns = false;
            this.kiwiDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDateTime,
            this.colComboBox,
            this.colTextBox,
            this.colMaskedTextBox,
            this.colDomainUpDown,
            this.colNumericUpDown,
            this.colCheckBox});
            this.kiwiDataGridView1.DataMember = "TestData";
            this.kiwiDataGridView1.DataSource = this.dataSet;
            this.kiwiDataGridView1.GridStyles.Style = Kiwi.ComponentFactory.Toolkit.DataGridViewStyle.Mixed;
            this.kiwiDataGridView1.Location = new System.Drawing.Point(12, 20);
            this.kiwiDataGridView1.Name = "kiwiDataGridView1";
            this.kiwiDataGridView1.Size = new System.Drawing.Size(800, 252);
            this.kiwiDataGridView1.TabIndex = 0;
            // 
            // colDateTime
            // 
            this.colDateTime.Checked = false;
            this.colDateTime.DataPropertyName = "DateTime";
            this.colDateTime.HeaderText = "DateTime";
            this.colDateTime.Name = "colDateTime";
            this.colDateTime.Width = 190;
            // 
            // colComboBox
            // 
            this.colComboBox.DataPropertyName = "ComboBox";
            this.colComboBox.DropDownWidth = 121;
            this.colComboBox.HeaderText = "ComboBox";
            this.colComboBox.Items.AddRange(new string[] {
            "Mr",
            "Mrs",
            "Miss",
            "Ms"});
            this.colComboBox.Name = "colComboBox";
            this.colComboBox.Width = 75;
            // 
            // colTextBox
            // 
            this.colTextBox.DataPropertyName = "TextBox";
            this.colTextBox.HeaderText = "TextBox";
            this.colTextBox.Name = "colTextBox";
            this.colTextBox.Width = 100;
            // 
            // colMaskedTextBox
            // 
            this.colMaskedTextBox.DataPropertyName = "MaskedTextBox";
            this.colMaskedTextBox.HeaderText = "MaskedTextBox";
            this.colMaskedTextBox.Mask = "(99) 9999-9999";
            this.colMaskedTextBox.Name = "colMaskedTextBox";
            this.colMaskedTextBox.Width = 100;
            // 
            // colDomainUpDown
            // 
            this.colDomainUpDown.DataPropertyName = "DomainUpDown";
            this.colDomainUpDown.HeaderText = "DomainUpDown";
            this.colDomainUpDown.Items.AddRange(new string[] {
            "Single",
            "Married",
            "Divorced",
            "Separated"});
            this.colDomainUpDown.Name = "colDomainUpDown";
            this.colDomainUpDown.Width = 105;
            // 
            // colNumericUpDown
            // 
            this.colNumericUpDown.DataPropertyName = "NumericUpDown";
            this.colNumericUpDown.HeaderText = "NumericUpDown";
            this.colNumericUpDown.Name = "colNumericUpDown";
            this.colNumericUpDown.Width = 105;
            // 
            // colCheckBox
            // 
            this.colCheckBox.DataPropertyName = "CheckBox";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = false;
            this.colCheckBox.DefaultCellStyle = dataGridViewCellStyle1;
            this.colCheckBox.FalseValue = null;
            this.colCheckBox.HeaderText = "CheckBox";
            this.colCheckBox.IndeterminateValue = null;
            this.colCheckBox.Name = "colCheckBox";
            this.colCheckBox.TrueValue = null;
            this.colCheckBox.Width = 68;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "NewDataSet";
            this.dataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.dtTestData});
            // 
            // dtTestData
            // 
            this.dtTestData.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataDateTime,
            this.dataComboBox,
            this.dataTextBox,
            this.dataMaskedTextBox,
            this.dataDomainUpDown,
            this.dataNumericUpDown,
            this.dataButton,
            this.dataCheckBox});
            this.dtTestData.TableName = "TestData";
            // 
            // dataDateTime
            // 
            this.dataDateTime.Caption = "DateTime";
            this.dataDateTime.ColumnName = "DateTime";
            this.dataDateTime.DataType = typeof(System.DateTime);
            // 
            // dataComboBox
            // 
            this.dataComboBox.Caption = "ComboBox";
            this.dataComboBox.ColumnName = "ComboBox";
            // 
            // dataTextBox
            // 
            this.dataTextBox.Caption = "TextBox";
            this.dataTextBox.ColumnName = "TextBox";
            // 
            // dataMaskedTextBox
            // 
            this.dataMaskedTextBox.Caption = "MaskedTextBox";
            this.dataMaskedTextBox.ColumnName = "MaskedTextBox";
            // 
            // dataDomainUpDown
            // 
            this.dataDomainUpDown.Caption = "DomainUpDown";
            this.dataDomainUpDown.ColumnName = "DomainUpDown";
            // 
            // dataNumericUpDown
            // 
            this.dataNumericUpDown.Caption = "NumericUpDown";
            this.dataNumericUpDown.ColumnName = "NumericUpDown";
            this.dataNumericUpDown.DataType = typeof(decimal);
            // 
            // dataButton
            // 
            this.dataButton.Caption = "Button";
            this.dataButton.ColumnName = "Button";
            // 
            // dataCheckBox
            // 
            this.dataCheckBox.Caption = "CheckBox";
            this.dataCheckBox.ColumnName = "CheckBox";
            this.dataCheckBox.DataType = typeof(bool);
            // 
            // kiwiDataGridViewCheckBoxColumn1
            // 
            this.kiwiDataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kiwiDataGridViewCheckBoxColumn1.DataPropertyName = "Check";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = false;
            this.kiwiDataGridViewCheckBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.kiwiDataGridViewCheckBoxColumn1.FalseValue = null;
            this.kiwiDataGridViewCheckBoxColumn1.HeaderText = "Check";
            this.kiwiDataGridViewCheckBoxColumn1.IndeterminateValue = null;
            this.kiwiDataGridViewCheckBoxColumn1.Name = "kiwiDataGridViewCheckBoxColumn1";
            this.kiwiDataGridViewCheckBoxColumn1.TrueValue = null;
            // 
            // kiwiDataGridViewTextBoxColumn4
            // 
            this.kiwiDataGridViewTextBoxColumn4.DataPropertyName = "Age";
            this.kiwiDataGridViewTextBoxColumn4.HeaderText = "Age";
            this.kiwiDataGridViewTextBoxColumn4.Name = "kiwiDataGridViewTextBoxColumn4";
            this.kiwiDataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kiwiDataGridViewTextBoxColumn4.Width = 100;
            // 
            // kiwiDataGridViewTextBoxColumn5
            // 
            this.kiwiDataGridViewTextBoxColumn5.DataPropertyName = "Comment";
            this.kiwiDataGridViewTextBoxColumn5.HeaderText = "Comment";
            this.kiwiDataGridViewTextBoxColumn5.Name = "kiwiDataGridViewTextBoxColumn5";
            this.kiwiDataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kiwiDataGridViewTextBoxColumn5.Width = 100;
            // 
            // kiwiDataGridViewTextBoxColumn6
            // 
            this.kiwiDataGridViewTextBoxColumn6.DataPropertyName = "Name";
            this.kiwiDataGridViewTextBoxColumn6.HeaderText = "Name";
            this.kiwiDataGridViewTextBoxColumn6.Name = "kiwiDataGridViewTextBoxColumn6";
            this.kiwiDataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kiwiDataGridViewTextBoxColumn6.Width = 100;
            // 
            // kiwiDataGridViewButtonColumn1
            // 
            this.kiwiDataGridViewButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kiwiDataGridViewButtonColumn1.DataPropertyName = "Button";
            this.kiwiDataGridViewButtonColumn1.HeaderText = "Button";
            this.kiwiDataGridViewButtonColumn1.Name = "kiwiDataGridViewButtonColumn1";
            this.kiwiDataGridViewButtonColumn1.Text = "Press!";
            this.kiwiDataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "Name";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = false;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.FalseValue = null;
            this.Column1.HeaderText = "Check";
            this.Column1.IndeterminateValue = null;
            this.Column1.Name = "Column1";
            this.Column1.TrueValue = null;
            // 
            // kiwiDataGridViewTextBoxColumn1
            // 
            this.kiwiDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.kiwiDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.kiwiDataGridViewTextBoxColumn1.Name = "kiwiDataGridViewTextBoxColumn1";
            this.kiwiDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kiwiDataGridViewTextBoxColumn1.Width = 100;
            // 
            // kiwiDataGridViewTextBoxColumn2
            // 
            this.kiwiDataGridViewTextBoxColumn2.DataPropertyName = "Age";
            this.kiwiDataGridViewTextBoxColumn2.HeaderText = "Age";
            this.kiwiDataGridViewTextBoxColumn2.Name = "kiwiDataGridViewTextBoxColumn2";
            this.kiwiDataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kiwiDataGridViewTextBoxColumn2.Width = 100;
            // 
            // kiwiDataGridViewTextBoxColumn3
            // 
            this.kiwiDataGridViewTextBoxColumn3.DataPropertyName = "Comment";
            this.kiwiDataGridViewTextBoxColumn3.HeaderText = "Comment";
            this.kiwiDataGridViewTextBoxColumn3.Name = "kiwiDataGridViewTextBoxColumn3";
            this.kiwiDataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kiwiDataGridViewTextBoxColumn3.Width = 100;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Button";
            this.Column2.Name = "Column2";
            this.Column2.Text = "Press!";
            this.Column2.UseColumnTextForButtonValue = true;
            // 
            // groupBoxPalette
            // 
            this.groupBoxPalette.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxPalette.Controls.Add(this.rbOffice2010Blue);
            this.groupBoxPalette.Controls.Add(this.rbSparkle);
            this.groupBoxPalette.Controls.Add(this.rbSystem);
            this.groupBoxPalette.Controls.Add(this.rbOffice2003);
            this.groupBoxPalette.Controls.Add(this.rbOffice2007Black);
            this.groupBoxPalette.Controls.Add(this.rbOffice2007Blue);
            this.groupBoxPalette.Location = new System.Drawing.Point(12, 278);
            this.groupBoxPalette.Name = "groupBoxPalette";
            this.groupBoxPalette.Size = new System.Drawing.Size(144, 171);
            this.groupBoxPalette.TabIndex = 1;
            this.groupBoxPalette.TabStop = false;
            this.groupBoxPalette.Text = "Palette";
            // 
            // rbOffice2010Blue
            // 
            this.rbOffice2010Blue.AutoSize = true;
            this.rbOffice2010Blue.Checked = true;
            this.rbOffice2010Blue.Location = new System.Drawing.Point(16, 26);
            this.rbOffice2010Blue.Name = "rbOffice2010Blue";
            this.rbOffice2010Blue.Size = new System.Drawing.Size(111, 17);
            this.rbOffice2010Blue.TabIndex = 6;
            this.rbOffice2010Blue.TabStop = true;
            this.rbOffice2010Blue.Text = "Office 2010 - Blue";
            this.rbOffice2010Blue.UseVisualStyleBackColor = true;
            this.rbOffice2010Blue.CheckedChanged += new System.EventHandler(this.rbOffice2010Blue_CheckedChanged);
            // 
            // rbSparkle
            // 
            this.rbSparkle.AutoSize = true;
            this.rbSparkle.Location = new System.Drawing.Point(16, 118);
            this.rbSparkle.Name = "rbSparkle";
            this.rbSparkle.Size = new System.Drawing.Size(90, 17);
            this.rbSparkle.TabIndex = 4;
            this.rbSparkle.Text = "Sparkle - Blue";
            this.rbSparkle.UseVisualStyleBackColor = true;
            this.rbSparkle.CheckedChanged += new System.EventHandler(this.rbSparkle_CheckedChanged);
            // 
            // rbSystem
            // 
            this.rbSystem.AutoSize = true;
            this.rbSystem.Location = new System.Drawing.Point(16, 141);
            this.rbSystem.Name = "rbSystem";
            this.rbSystem.Size = new System.Drawing.Size(60, 17);
            this.rbSystem.TabIndex = 5;
            this.rbSystem.Text = "System";
            this.rbSystem.UseVisualStyleBackColor = true;
            this.rbSystem.CheckedChanged += new System.EventHandler(this.rbSystem_CheckedChanged);
            // 
            // rbOffice2003
            // 
            this.rbOffice2003.AutoSize = true;
            this.rbOffice2003.Location = new System.Drawing.Point(16, 95);
            this.rbOffice2003.Name = "rbOffice2003";
            this.rbOffice2003.Size = new System.Drawing.Size(81, 17);
            this.rbOffice2003.TabIndex = 3;
            this.rbOffice2003.Text = "Office 2003";
            this.rbOffice2003.UseVisualStyleBackColor = true;
            this.rbOffice2003.CheckedChanged += new System.EventHandler(this.rbOffice2003_CheckedChanged);
            // 
            // rbOffice2007Black
            // 
            this.rbOffice2007Black.AutoSize = true;
            this.rbOffice2007Black.Location = new System.Drawing.Point(16, 72);
            this.rbOffice2007Black.Name = "rbOffice2007Black";
            this.rbOffice2007Black.Size = new System.Drawing.Size(115, 17);
            this.rbOffice2007Black.TabIndex = 2;
            this.rbOffice2007Black.Text = "Office 2007 - Black";
            this.rbOffice2007Black.UseVisualStyleBackColor = true;
            this.rbOffice2007Black.CheckedChanged += new System.EventHandler(this.rbOffice2007Black_CheckedChanged);
            // 
            // rbOffice2007Blue
            // 
            this.rbOffice2007Blue.AutoSize = true;
            this.rbOffice2007Blue.Location = new System.Drawing.Point(16, 49);
            this.rbOffice2007Blue.Name = "rbOffice2007Blue";
            this.rbOffice2007Blue.Size = new System.Drawing.Size(111, 17);
            this.rbOffice2007Blue.TabIndex = 0;
            this.rbOffice2007Blue.Text = "Office 2007 - Blue";
            this.rbOffice2007Blue.UseVisualStyleBackColor = true;
            this.rbOffice2007Blue.CheckedChanged += new System.EventHandler(this.rbOffice2007Blue_CheckedChanged);
            // 
            // rbStyleList
            // 
            this.rbStyleList.AutoSize = true;
            this.rbStyleList.Checked = true;
            this.rbStyleList.Location = new System.Drawing.Point(18, 26);
            this.rbStyleList.Name = "rbStyleList";
            this.rbStyleList.Size = new System.Drawing.Size(41, 17);
            this.rbStyleList.TabIndex = 0;
            this.rbStyleList.TabStop = true;
            this.rbStyleList.Text = "List";
            this.rbStyleList.UseVisualStyleBackColor = true;
            this.rbStyleList.CheckedChanged += new System.EventHandler(this.rbStyleList_CheckedChanged);
            // 
            // groupBoxGridStyle
            // 
            this.groupBoxGridStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxGridStyle.Controls.Add(this.rbStyleCustom);
            this.groupBoxGridStyle.Controls.Add(this.rbStyleSheet);
            this.groupBoxGridStyle.Controls.Add(this.rbStyleList);
            this.groupBoxGridStyle.Location = new System.Drawing.Point(162, 278);
            this.groupBoxGridStyle.Name = "groupBoxGridStyle";
            this.groupBoxGridStyle.Size = new System.Drawing.Size(91, 171);
            this.groupBoxGridStyle.TabIndex = 2;
            this.groupBoxGridStyle.TabStop = false;
            this.groupBoxGridStyle.Text = "GridStyle";
            // 
            // rbStyleCustom
            // 
            this.rbStyleCustom.AutoSize = true;
            this.rbStyleCustom.Location = new System.Drawing.Point(18, 72);
            this.rbStyleCustom.Name = "rbStyleCustom";
            this.rbStyleCustom.Size = new System.Drawing.Size(61, 17);
            this.rbStyleCustom.TabIndex = 2;
            this.rbStyleCustom.Text = "Custom";
            this.rbStyleCustom.UseVisualStyleBackColor = true;
            this.rbStyleCustom.CheckedChanged += new System.EventHandler(this.rbStyleCustom_CheckedChanged);
            // 
            // rbStyleSheet
            // 
            this.rbStyleSheet.AutoSize = true;
            this.rbStyleSheet.Location = new System.Drawing.Point(18, 49);
            this.rbStyleSheet.Name = "rbStyleSheet";
            this.rbStyleSheet.Size = new System.Drawing.Size(53, 17);
            this.rbStyleSheet.TabIndex = 1;
            this.rbStyleSheet.Text = "Sheet";
            this.rbStyleSheet.UseVisualStyleBackColor = true;
            this.rbStyleSheet.CheckedChanged += new System.EventHandler(this.rbStyleSheet_CheckedChanged);
            // 
            // kiwiPalette
            // 
            this.kiwiPalette.GridStyles.GridCustom1.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kiwiPalette.GridStyles.GridCustom1.StateCommon.Background.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Solid;
            this.kiwiPalette.GridStyles.GridCustom1.StateCommon.BackStyle = Kiwi.ComponentFactory.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kiwiPalette.GridStyles.GridCustom1.StateNormal.DataCell.Back.Color1 = System.Drawing.Color.Gray;
            this.kiwiPalette.GridStyles.GridCustom1.StateNormal.DataCell.Border.Color1 = System.Drawing.Color.Black;
            this.kiwiPalette.GridStyles.GridCustom1.StateNormal.DataCell.Border.Color2 = System.Drawing.Color.Black;
            this.kiwiPalette.GridStyles.GridCustom1.StateNormal.DataCell.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                  | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                  | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.kiwiPalette.GridStyles.GridCustom1.StateNormal.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.kiwiPalette.GridStyles.GridCustom1.StateNormal.DataCell.Content.Color2 = System.Drawing.Color.White;
            this.kiwiPalette.GridStyles.GridCustom1.StateNormal.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kiwiPalette.GridStyles.GridCustom1.StateNormal.HeaderColumn.Back.Color2 = System.Drawing.Color.Silver;
            this.kiwiPalette.GridStyles.GridCustom1.StateNormal.HeaderColumn.Back.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Rounded;
            this.kiwiPalette.GridStyles.GridCustom1.StateNormal.HeaderColumn.Border.Color1 = System.Drawing.Color.Black;
            this.kiwiPalette.GridStyles.GridCustom1.StateNormal.HeaderColumn.Border.Color2 = System.Drawing.Color.Black;
            this.kiwiPalette.GridStyles.GridCustom1.StateNormal.HeaderColumn.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                  | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                  | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.kiwiPalette.GridStyles.GridCustom1.StateNormal.HeaderColumn.Content.Color1 = System.Drawing.Color.Black;
            this.kiwiPalette.GridStyles.GridCustom1.StateNormal.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kiwiPalette.GridStyles.GridCustom1.StateNormal.HeaderRow.Back.Color2 = System.Drawing.Color.Silver;
            this.kiwiPalette.GridStyles.GridCustom1.StateNormal.HeaderRow.Back.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Rounded;
            this.kiwiPalette.GridStyles.GridCustom1.StateNormal.HeaderRow.Border.Color1 = System.Drawing.Color.Black;
            this.kiwiPalette.GridStyles.GridCustom1.StateNormal.HeaderRow.Border.Color2 = System.Drawing.Color.Black;
            this.kiwiPalette.GridStyles.GridCustom1.StateNormal.HeaderRow.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                  | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                  | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.kiwiPalette.GridStyles.GridCustom1.StateNormal.HeaderRow.Content.Color1 = System.Drawing.Color.Black;
            this.kiwiPalette.GridStyles.GridCustom1.StateNormal.HeaderRow.Content.Color2 = System.Drawing.Color.Black;
            this.kiwiPalette.GridStyles.GridCustom1.StatePressed.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kiwiPalette.GridStyles.GridCustom1.StatePressed.HeaderColumn.Back.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Solid;
            this.kiwiPalette.GridStyles.GridCustom1.StatePressed.HeaderColumn.Border.Color1 = System.Drawing.Color.Black;
            this.kiwiPalette.GridStyles.GridCustom1.StatePressed.HeaderColumn.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                  | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                  | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.kiwiPalette.GridStyles.GridCustom1.StatePressed.HeaderColumn.Content.Color1 = System.Drawing.Color.Black;
            this.kiwiPalette.GridStyles.GridCustom1.StatePressed.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kiwiPalette.GridStyles.GridCustom1.StatePressed.HeaderRow.Back.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Solid;
            this.kiwiPalette.GridStyles.GridCustom1.StatePressed.HeaderRow.Border.Color1 = System.Drawing.Color.Black;
            this.kiwiPalette.GridStyles.GridCustom1.StatePressed.HeaderRow.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                  | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                  | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.kiwiPalette.GridStyles.GridCustom1.StatePressed.HeaderRow.Content.Color1 = System.Drawing.Color.Black;
            this.kiwiPalette.GridStyles.GridCustom1.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kiwiPalette.GridStyles.GridCustom1.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kiwiPalette.GridStyles.GridCustom1.StateSelected.DataCell.Border.Color1 = System.Drawing.Color.Black;
            this.kiwiPalette.GridStyles.GridCustom1.StateSelected.DataCell.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                  | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                  | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.kiwiPalette.GridStyles.GridCustom1.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.kiwiPalette.GridStyles.GridCustom1.StateSelected.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kiwiPalette.GridStyles.GridCustom1.StateSelected.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kiwiPalette.GridStyles.GridCustom1.StateSelected.HeaderColumn.Back.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Rounded;
            this.kiwiPalette.GridStyles.GridCustom1.StateSelected.HeaderColumn.Border.Color1 = System.Drawing.Color.Black;
            this.kiwiPalette.GridStyles.GridCustom1.StateSelected.HeaderColumn.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                  | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                  | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.kiwiPalette.GridStyles.GridCustom1.StateSelected.HeaderColumn.Content.Color1 = System.Drawing.Color.Black;
            this.kiwiPalette.GridStyles.GridCustom1.StateSelected.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kiwiPalette.GridStyles.GridCustom1.StateSelected.HeaderRow.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kiwiPalette.GridStyles.GridCustom1.StateSelected.HeaderRow.Back.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Rounded;
            this.kiwiPalette.GridStyles.GridCustom1.StateSelected.HeaderRow.Border.Color1 = System.Drawing.Color.Black;
            this.kiwiPalette.GridStyles.GridCustom1.StateSelected.HeaderRow.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                  | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                  | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.kiwiPalette.GridStyles.GridCustom1.StateSelected.HeaderRow.Content.Color1 = System.Drawing.Color.Black;
            this.kiwiPalette.GridStyles.GridCustom1.StateTracking.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kiwiPalette.GridStyles.GridCustom1.StateTracking.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kiwiPalette.GridStyles.GridCustom1.StateTracking.HeaderColumn.Back.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Solid;
            this.kiwiPalette.GridStyles.GridCustom1.StateTracking.HeaderColumn.Border.Color1 = System.Drawing.Color.Black;
            this.kiwiPalette.GridStyles.GridCustom1.StateTracking.HeaderColumn.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                  | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                  | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.kiwiPalette.GridStyles.GridCustom1.StateTracking.HeaderColumn.Content.Color1 = System.Drawing.Color.Black;
            this.kiwiPalette.GridStyles.GridCustom1.StateTracking.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kiwiPalette.GridStyles.GridCustom1.StateTracking.HeaderRow.Back.ColorStyle = Kiwi.ComponentFactory.Toolkit.PaletteColorStyle.Solid;
            this.kiwiPalette.GridStyles.GridCustom1.StateTracking.HeaderRow.Border.Color1 = System.Drawing.Color.Black;
            this.kiwiPalette.GridStyles.GridCustom1.StateTracking.HeaderRow.Border.DrawBorders = ((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders)((((Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Top | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Bottom)
                  | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Left)
                  | Kiwi.ComponentFactory.Toolkit.PaletteDrawBorders.Right)));
            this.kiwiPalette.GridStyles.GridCustom1.StateTracking.HeaderRow.Content.Color1 = System.Drawing.Color.Black;
            // 
            // kiwiManager
            // 
            this.kiwiManager.GlobalPalette = this.kiwiPalette;
            this.kiwiManager.GlobalPaletteMode = Kiwi.ComponentFactory.Toolkit.PaletteModeManager.Custom;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnCompare);
            this.groupBox1.Controls.Add(this.buttonClearCellColors);
            this.groupBox1.Controls.Add(this.buttonRandomCellColors);
            this.groupBox1.Location = new System.Drawing.Point(259, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 170);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            // 
            // buttonClearCellColors
            // 
            this.buttonClearCellColors.Location = new System.Drawing.Point(12, 60);
            this.buttonClearCellColors.Name = "buttonClearCellColors";
            this.buttonClearCellColors.Size = new System.Drawing.Size(129, 29);
            this.buttonClearCellColors.TabIndex = 1;
            this.buttonClearCellColors.Values.Text = "Clear Cell Colors";
            this.buttonClearCellColors.Click += new System.EventHandler(this.buttonClearCellColors_Click);
            // 
            // buttonRandomCellColors
            // 
            this.buttonRandomCellColors.Location = new System.Drawing.Point(13, 26);
            this.buttonRandomCellColors.Name = "buttonRandomCellColors";
            this.buttonRandomCellColors.Size = new System.Drawing.Size(129, 29);
            this.buttonRandomCellColors.TabIndex = 0;
            this.buttonRandomCellColors.Values.Text = "Random Cell Colors";
            this.buttonRandomCellColors.Click += new System.EventHandler(this.buttonRandomCellColors_Click);
            // 
            // lbPropChanges
            // 
            this.lbPropChanges.Location = new System.Drawing.Point(419, 288);
            this.lbPropChanges.Name = "lbPropChanges";
            this.lbPropChanges.Size = new System.Drawing.Size(393, 161);
            this.lbPropChanges.TabIndex = 6;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(12, 96);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(129, 30);
            this.btnCompare.TabIndex = 2;
            this.btnCompare.Values.Text = "&Compare";
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 497);
            this.Controls.Add(this.lbPropChanges);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxGridStyle);
            this.Controls.Add(this.groupBoxPalette);
            this.Controls.Add(this.kiwiDataGridView1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(750, 416);
            this.Name = "Form1";
            this.Text = "KiwiDataGridView Examples";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiwiDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTestData)).EndInit();
            this.groupBoxPalette.ResumeLayout(false);
            this.groupBoxPalette.PerformLayout();
            this.groupBoxGridStyle.ResumeLayout(false);
            this.groupBoxGridStyle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private Kiwi.ComponentFactory.Toolkit.KiwiDataGridView kiwiDataGridView1;
        private System.Windows.Forms.GroupBox groupBoxPalette;
        private System.Windows.Forms.RadioButton rbSystem;
        private System.Windows.Forms.RadioButton rbOffice2003;
        private System.Windows.Forms.RadioButton rbOffice2007Black;
        private System.Windows.Forms.RadioButton rbOffice2007Blue;
        private System.Windows.Forms.RadioButton rbStyleList;
        private System.Windows.Forms.GroupBox groupBoxGridStyle;
        private System.Windows.Forms.RadioButton rbStyleCustom;
        private System.Windows.Forms.RadioButton rbStyleSheet;
        private System.Data.DataSet dataSet;
        private System.Data.DataTable dtTestData;
        private Kiwi.ComponentFactory.Toolkit.KiwiPalette kiwiPalette;
        private Kiwi.ComponentFactory.Toolkit.KiwiManager kiwiManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private Kiwi.ComponentFactory.Toolkit.KiwiButton buttonRandomCellColors;
        private Kiwi.ComponentFactory.Toolkit.KiwiButton buttonClearCellColors;
        private Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewCheckBoxColumn Column1;
        private Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewTextBoxColumn kiwiDataGridViewTextBoxColumn1;
        private Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewTextBoxColumn kiwiDataGridViewTextBoxColumn2;
        private Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewTextBoxColumn kiwiDataGridViewTextBoxColumn3;
        private Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewButtonColumn Column2;
        private Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewCheckBoxColumn kiwiDataGridViewCheckBoxColumn1;
        private Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewTextBoxColumn kiwiDataGridViewTextBoxColumn4;
        private Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewTextBoxColumn kiwiDataGridViewTextBoxColumn5;
        private Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewTextBoxColumn kiwiDataGridViewTextBoxColumn6;
        private Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewButtonColumn kiwiDataGridViewButtonColumn1;
        private System.Windows.Forms.RadioButton rbSparkle;
        private System.Windows.Forms.RadioButton rbOffice2010Blue;
        private System.Data.DataColumn dataDateTime;
        private System.Data.DataColumn dataComboBox;
        private System.Data.DataColumn dataTextBox;
        private System.Data.DataColumn dataMaskedTextBox;
        private System.Data.DataColumn dataDomainUpDown;
        private System.Data.DataColumn dataNumericUpDown;
        private System.Data.DataColumn dataButton;
        private System.Data.DataColumn dataCheckBox;
        private Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewDateTimePickerColumn colDateTime;
        private Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewComboBoxColumn colComboBox;
        private Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewTextBoxColumn colTextBox;
        private Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewMaskedTextBoxColumn colMaskedTextBox;
        private Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewDomainUpDownColumn colDomainUpDown;
        private Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewNumericUpDownColumn colNumericUpDown;
        private Kiwi.ComponentFactory.Toolkit.KiwiDataGridViewCheckBoxColumn colCheckBox;
        private Kiwi.ComponentFactory.Toolkit.KiwiListBox lbPropChanges;
        private Kiwi.ComponentFactory.Toolkit.KiwiButton btnCompare;
    }
}

