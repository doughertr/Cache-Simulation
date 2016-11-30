namespace GUI
{
    partial class CacheSimulatorGUI
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.memoryTypeComboBox = new System.Windows.Forms.ComboBox();
            this.calculateAllButton = new System.Windows.Forms.Button();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.instructionTextbox = new System.Windows.Forms.RichTextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.iterationTextBox = new System.Windows.Forms.TextBox();
            this.loopCountLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.entrySizeLabel = new System.Windows.Forms.Label();
            this.entrySizeTextBox = new System.Windows.Forms.TextBox();
            this.rowNumberLabel = new System.Windows.Forms.Label();
            this.numRowsTextBox = new System.Windows.Forms.TextBox();
            this.numberOfWaysLabel = new System.Windows.Forms.Label();
            this.numberOfWaysTextBox = new System.Windows.Forms.TextBox();
            this.cacheDatabaseDataSet = new GUI.CacheDatabaseDataSet();
            this.cacheDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cacheDatabaseDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cacheDatabaseData = new GUI.CacheDatabaseData();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new GUI.CacheDatabaseDataTableAdapters.TableTableAdapter();
            this.cacheDatabaseDataSet1 = new GUI.CacheDatabaseDataSet();
            this.tableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter1 = new GUI.CacheDatabaseDataSetTableAdapters.TableTableAdapter();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cacheDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cacheDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cacheDatabaseDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cacheDatabaseData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cacheDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addressDataGridViewTextBoxColumn,
            this.tagDataGridViewTextBoxColumn,
            this.rowDataGridViewTextBoxColumn,
            this.actionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(410, 591);
            this.dataGridView1.TabIndex = 0;
            // 
            // memoryTypeComboBox
            // 
            this.memoryTypeComboBox.FormattingEnabled = true;
            this.memoryTypeComboBox.Items.AddRange(new object[] {
            "Direct Mapped",
            "Fully Associative",
            "Set Associative"});
            this.memoryTypeComboBox.Location = new System.Drawing.Point(500, 40);
            this.memoryTypeComboBox.Name = "memoryTypeComboBox";
            this.memoryTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.memoryTypeComboBox.TabIndex = 4;
            // 
            // calculateAllButton
            // 
            this.calculateAllButton.Location = new System.Drawing.Point(676, 142);
            this.calculateAllButton.Name = "calculateAllButton";
            this.calculateAllButton.Size = new System.Drawing.Size(136, 57);
            this.calculateAllButton.TabIndex = 3;
            this.calculateAllButton.Text = "Calculate All \r\nHits and Misses";
            this.calculateAllButton.UseVisualStyleBackColor = true;
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsLabel.Location = new System.Drawing.Point(516, 9);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(71, 20);
            this.optionsLabel.TabIndex = 5;
            this.optionsLabel.Text = "Options";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(420, 43);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(74, 13);
            this.typeLabel.TabIndex = 6;
            this.typeLabel.Text = "Memory Type:";
            // 
            // instructionTextbox
            // 
            this.instructionTextbox.Location = new System.Drawing.Point(500, 82);
            this.instructionTextbox.Name = "instructionTextbox";
            this.instructionTextbox.Size = new System.Drawing.Size(121, 117);
            this.instructionTextbox.TabIndex = 7;
            this.instructionTextbox.Text = "4, 8, 20, 24, 28, 36, 44, 20, 24, 28, 36, 40, 44, 68, 72, 92, 96, 100, 104, 108, " +
    "112, 100, 112, 116, 120, 128, 140";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(420, 85);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(63, 52);
            this.addressLabel.TabIndex = 8;
            this.addressLabel.Text = "Instruction \r\nMemory \r\nAddresses\r\n(DECIMAL):";
            // 
            // iterationTextBox
            // 
            this.iterationTextBox.Location = new System.Drawing.Point(500, 207);
            this.iterationTextBox.Name = "iterationTextBox";
            this.iterationTextBox.Size = new System.Drawing.Size(121, 20);
            this.iterationTextBox.TabIndex = 9;
            this.iterationTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // loopCountLabel
            // 
            this.loopCountLabel.AutoSize = true;
            this.loopCountLabel.Location = new System.Drawing.Point(423, 207);
            this.loopCountLabel.Name = "loopCountLabel";
            this.loopCountLabel.Size = new System.Drawing.Size(56, 26);
            this.loopCountLabel.TabIndex = 10;
            this.loopCountLabel.Text = "Number of\r\nIterations:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 57);
            this.button1.TabIndex = 11;
            this.button1.Text = "Calculate Single\r\nIteration\r\n";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // entrySizeLabel
            // 
            this.entrySizeLabel.AutoSize = true;
            this.entrySizeLabel.Location = new System.Drawing.Point(416, 254);
            this.entrySizeLabel.Name = "entrySizeLabel";
            this.entrySizeLabel.Size = new System.Drawing.Size(78, 13);
            this.entrySizeLabel.TabIndex = 13;
            this.entrySizeLabel.Text = "Entry byte size:\r\n";
            // 
            // entrySizeTextBox
            // 
            this.entrySizeTextBox.Location = new System.Drawing.Point(500, 251);
            this.entrySizeTextBox.Name = "entrySizeTextBox";
            this.entrySizeTextBox.Size = new System.Drawing.Size(121, 20);
            this.entrySizeTextBox.TabIndex = 12;
            // 
            // rowNumberLabel
            // 
            this.rowNumberLabel.AutoSize = true;
            this.rowNumberLabel.Location = new System.Drawing.Point(424, 294);
            this.rowNumberLabel.Name = "rowNumberLabel";
            this.rowNumberLabel.Size = new System.Drawing.Size(59, 26);
            this.rowNumberLabel.TabIndex = 15;
            this.rowNumberLabel.Text = "Number of \r\nRows:";
            // 
            // numRowsTextBox
            // 
            this.numRowsTextBox.Location = new System.Drawing.Point(500, 294);
            this.numRowsTextBox.Name = "numRowsTextBox";
            this.numRowsTextBox.Size = new System.Drawing.Size(121, 20);
            this.numRowsTextBox.TabIndex = 14;
            // 
            // numberOfWaysLabel
            // 
            this.numberOfWaysLabel.AutoSize = true;
            this.numberOfWaysLabel.Location = new System.Drawing.Point(424, 340);
            this.numberOfWaysLabel.Name = "numberOfWaysLabel";
            this.numberOfWaysLabel.Size = new System.Drawing.Size(56, 26);
            this.numberOfWaysLabel.TabIndex = 17;
            this.numberOfWaysLabel.Text = "Number of\r\nWays:";
            this.numberOfWaysLabel.Visible = false;
            // 
            // numberOfWaysTextBox
            // 
            this.numberOfWaysTextBox.Location = new System.Drawing.Point(500, 340);
            this.numberOfWaysTextBox.Name = "numberOfWaysTextBox";
            this.numberOfWaysTextBox.Size = new System.Drawing.Size(121, 20);
            this.numberOfWaysTextBox.TabIndex = 16;
            this.numberOfWaysTextBox.Visible = false;
            // 
            // cacheDatabaseDataSet
            // 
            this.cacheDatabaseDataSet.DataSetName = "CacheDatabaseDataSet";
            this.cacheDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cacheDatabaseDataSetBindingSource
            // 
            this.cacheDatabaseDataSetBindingSource.DataSource = this.cacheDatabaseDataSet;
            this.cacheDatabaseDataSetBindingSource.Position = 0;
            // 
            // cacheDatabaseDataSetBindingSource1
            // 
            this.cacheDatabaseDataSetBindingSource1.DataSource = this.cacheDatabaseDataSet;
            this.cacheDatabaseDataSetBindingSource1.Position = 0;
            // 
            // cacheDatabaseData
            // 
            this.cacheDatabaseData.DataSetName = "CacheDatabaseData";
            this.cacheDatabaseData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.cacheDatabaseData;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // cacheDatabaseDataSet1
            // 
            this.cacheDatabaseDataSet1.DataSetName = "CacheDatabaseDataSet";
            this.cacheDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource1
            // 
            this.tableBindingSource1.DataMember = "Table";
            this.tableBindingSource1.DataSource = this.cacheDatabaseDataSet1;
            // 
            // tableTableAdapter1
            // 
            this.tableTableAdapter1.ClearBeforeFill = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // tagDataGridViewTextBoxColumn
            // 
            this.tagDataGridViewTextBoxColumn.DataPropertyName = "Tag";
            this.tagDataGridViewTextBoxColumn.HeaderText = "Tag";
            this.tagDataGridViewTextBoxColumn.Name = "tagDataGridViewTextBoxColumn";
            // 
            // rowDataGridViewTextBoxColumn
            // 
            this.rowDataGridViewTextBoxColumn.DataPropertyName = "Row";
            this.rowDataGridViewTextBoxColumn.HeaderText = "Row";
            this.rowDataGridViewTextBoxColumn.Name = "rowDataGridViewTextBoxColumn";
            // 
            // actionDataGridViewTextBoxColumn
            // 
            this.actionDataGridViewTextBoxColumn.DataPropertyName = "Action";
            this.actionDataGridViewTextBoxColumn.HeaderText = "Action";
            this.actionDataGridViewTextBoxColumn.Name = "actionDataGridViewTextBoxColumn";
            // 
            // CacheSimulatorGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 591);
            this.Controls.Add(this.numberOfWaysLabel);
            this.Controls.Add(this.numberOfWaysTextBox);
            this.Controls.Add(this.rowNumberLabel);
            this.Controls.Add(this.numRowsTextBox);
            this.Controls.Add(this.entrySizeLabel);
            this.Controls.Add(this.entrySizeTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loopCountLabel);
            this.Controls.Add(this.iterationTextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.instructionTextbox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.optionsLabel);
            this.Controls.Add(this.memoryTypeComboBox);
            this.Controls.Add(this.calculateAllButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CacheSimulatorGUI";
            this.Text = "CPU Cache Simulator";
            this.Load += new System.EventHandler(this.CacheSimulatorGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cacheDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cacheDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cacheDatabaseDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cacheDatabaseData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cacheDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox memoryTypeComboBox;
        private System.Windows.Forms.Button calculateAllButton;
        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.RichTextBox instructionTextbox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox iterationTextBox;
        private System.Windows.Forms.Label loopCountLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label entrySizeLabel;
        private System.Windows.Forms.TextBox entrySizeTextBox;
        private System.Windows.Forms.Label rowNumberLabel;
        private System.Windows.Forms.TextBox numRowsTextBox;
        private System.Windows.Forms.Label numberOfWaysLabel;
        private System.Windows.Forms.TextBox numberOfWaysTextBox;
        private System.Windows.Forms.BindingSource cacheDatabaseDataSetBindingSource;
        private CacheDatabaseDataSet cacheDatabaseDataSet;
        private System.Windows.Forms.BindingSource cacheDatabaseDataSetBindingSource1;
        private CacheDatabaseData cacheDatabaseData;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private CacheDatabaseDataTableAdapters.TableTableAdapter tableTableAdapter;
        private CacheDatabaseDataSet cacheDatabaseDataSet1;
        private System.Windows.Forms.BindingSource tableBindingSource1;
        private CacheDatabaseDataSetTableAdapters.TableTableAdapter tableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDataGridViewTextBoxColumn;
    }
}

