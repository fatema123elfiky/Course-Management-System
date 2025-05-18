namespace Course_Managment.Instructor
{
    partial class addInstructor
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
            this.addButton = new System.Windows.Forms.Button();
            this.emailEntry = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameEntry = new System.Windows.Forms.TextBox();
            this.emailErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.nameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.crsManagementDataSet = new Course_Managment.CrsManagementDataSet();
            this.crsManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNSTRUCTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNSTRUCTORTableAdapter = new Course_Managment.CrsManagementDataSetTableAdapters.INSTRUCTORTableAdapter();
            this.iIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPASSWORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsManagementDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSTRUCTORBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(169, 324);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(139, 42);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // emailEntry
            // 
            this.emailEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailEntry.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailEntry.Location = new System.Drawing.Point(270, 235);
            this.emailEntry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailEntry.MaxLength = 200;
            this.emailEntry.Name = "emailEntry";
            this.emailEntry.Size = new System.Drawing.Size(258, 35);
            this.emailEntry.TabIndex = 8;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Adobe Song Std L", 18F, System.Drawing.FontStyle.Italic);
            this.emailLabel.ForeColor = System.Drawing.Color.SlateBlue;
            this.emailLabel.Location = new System.Drawing.Point(48, 228);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(99, 42);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "Email";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Adobe Song Std L", 18F, System.Drawing.FontStyle.Italic);
            this.nameLabel.ForeColor = System.Drawing.Color.SlateBlue;
            this.nameLabel.Location = new System.Drawing.Point(43, 149);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(104, 42);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nameEntry
            // 
            this.nameEntry.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameEntry.Location = new System.Drawing.Point(270, 156);
            this.nameEntry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameEntry.MaxLength = 200;
            this.nameEntry.Name = "nameEntry";
            this.nameEntry.Size = new System.Drawing.Size(258, 35);
            this.nameEntry.TabIndex = 5;
            this.nameEntry.WordWrap = false;
            // 
            // emailErrorProvider
            // 
            this.emailErrorProvider.ContainerControl = this;
            // 
            // nameErrorProvider
            // 
            this.nameErrorProvider.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Song Std L", 18F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(162, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "Add Instructor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(719, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 45);
            this.button2.TabIndex = 18;
            this.button2.Text = "show data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iIDDataGridViewTextBoxColumn,
            this.iNAMEDataGridViewTextBoxColumn,
            this.iEMAILDataGridViewTextBoxColumn,
            this.iPASSWORDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.iNSTRUCTORBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(557, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(423, 308);
            this.dataGridView1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 45);
            this.button1.TabIndex = 19;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // crsManagementDataSet
            // 
            this.crsManagementDataSet.DataSetName = "CrsManagementDataSet";
            this.crsManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // crsManagementDataSetBindingSource
            // 
            this.crsManagementDataSetBindingSource.DataSource = this.crsManagementDataSet;
            this.crsManagementDataSetBindingSource.Position = 0;
            // 
            // iNSTRUCTORBindingSource
            // 
            this.iNSTRUCTORBindingSource.DataMember = "INSTRUCTOR";
            this.iNSTRUCTORBindingSource.DataSource = this.crsManagementDataSetBindingSource;
            // 
            // iNSTRUCTORTableAdapter
            // 
            this.iNSTRUCTORTableAdapter.ClearBeforeFill = true;
            // 
            // iIDDataGridViewTextBoxColumn
            // 
            this.iIDDataGridViewTextBoxColumn.DataPropertyName = "IID";
            this.iIDDataGridViewTextBoxColumn.HeaderText = "IID";
            this.iIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iIDDataGridViewTextBoxColumn.Name = "iIDDataGridViewTextBoxColumn";
            this.iIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // iNAMEDataGridViewTextBoxColumn
            // 
            this.iNAMEDataGridViewTextBoxColumn.DataPropertyName = "INAME";
            this.iNAMEDataGridViewTextBoxColumn.HeaderText = "INAME";
            this.iNAMEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iNAMEDataGridViewTextBoxColumn.Name = "iNAMEDataGridViewTextBoxColumn";
            this.iNAMEDataGridViewTextBoxColumn.Width = 150;
            // 
            // iEMAILDataGridViewTextBoxColumn
            // 
            this.iEMAILDataGridViewTextBoxColumn.DataPropertyName = "IEMAIL";
            this.iEMAILDataGridViewTextBoxColumn.HeaderText = "IEMAIL";
            this.iEMAILDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iEMAILDataGridViewTextBoxColumn.Name = "iEMAILDataGridViewTextBoxColumn";
            this.iEMAILDataGridViewTextBoxColumn.Width = 150;
            // 
            // iPASSWORDDataGridViewTextBoxColumn
            // 
            this.iPASSWORDDataGridViewTextBoxColumn.DataPropertyName = "IPASSWORD";
            this.iPASSWORDDataGridViewTextBoxColumn.HeaderText = "IPASSWORD";
            this.iPASSWORDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iPASSWORDDataGridViewTextBoxColumn.Name = "iPASSWORDDataGridViewTextBoxColumn";
            this.iPASSWORDDataGridViewTextBoxColumn.Width = 150;
            // 
            // addInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 529);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.emailEntry);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameEntry);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "addInstructor";
            this.Text = "Add Instructor";
            this.Load += new System.EventHandler(this.addInstructor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsManagementDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSTRUCTORBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox emailEntry;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameEntry;
        private System.Windows.Forms.ErrorProvider emailErrorProvider;
        private System.Windows.Forms.ErrorProvider nameErrorProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource crsManagementDataSetBindingSource;
        private CrsManagementDataSet crsManagementDataSet;
        private System.Windows.Forms.BindingSource iNSTRUCTORBindingSource;
        private CrsManagementDataSetTableAdapters.INSTRUCTORTableAdapter iNSTRUCTORTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPASSWORDDataGridViewTextBoxColumn;
    }
}
