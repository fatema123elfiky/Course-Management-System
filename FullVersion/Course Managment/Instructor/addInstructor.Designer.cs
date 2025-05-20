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
            this.iIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPASSWORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNSTRUCTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crsManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crsManagementDataSet = new Course_Managment.CrsManagementDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.iNSTRUCTORTableAdapter = new Course_Managment.CrsManagementDataSetTableAdapters.INSTRUCTORTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSTRUCTORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsManagementDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(258, 379);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(124, 34);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // emailEntry
            // 
            this.emailEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailEntry.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailEntry.Location = new System.Drawing.Point(348, 308);
            this.emailEntry.MaxLength = 200;
            this.emailEntry.Name = "emailEntry";
            this.emailEntry.Size = new System.Drawing.Size(230, 30);
            this.emailEntry.TabIndex = 8;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic);
            this.emailLabel.ForeColor = System.Drawing.Color.SlateBlue;
            this.emailLabel.Location = new System.Drawing.Point(151, 302);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(88, 36);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "Email";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic);
            this.nameLabel.ForeColor = System.Drawing.Color.SlateBlue;
            this.nameLabel.Location = new System.Drawing.Point(146, 239);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(92, 36);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nameEntry
            // 
            this.nameEntry.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameEntry.Location = new System.Drawing.Point(348, 245);
            this.nameEntry.MaxLength = 200;
            this.nameEntry.Name = "nameEntry";
            this.nameEntry.Size = new System.Drawing.Size(230, 30);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(252, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "Add Instructor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(814, 475);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 36);
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
            this.dataGridView1.Location = new System.Drawing.Point(617, 154);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(577, 277);
            this.dataGridView1.TabIndex = 17;
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
            // iNSTRUCTORBindingSource
            // 
            this.iNSTRUCTORBindingSource.DataMember = "INSTRUCTOR";
            this.iNSTRUCTORBindingSource.DataSource = this.crsManagementDataSetBindingSource;
            // 
            // crsManagementDataSetBindingSource
            // 
            this.crsManagementDataSetBindingSource.DataSource = this.crsManagementDataSet;
            this.crsManagementDataSetBindingSource.Position = 0;
            // 
            // crsManagementDataSet
            // 
            this.crsManagementDataSet.DataSetName = "CrsManagementDataSet";
            this.crsManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 479);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 36);
            this.button1.TabIndex = 19;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iNSTRUCTORTableAdapter
            // 
            this.iNSTRUCTORTableAdapter.ClearBeforeFill = true;
            // 
            // addInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 722);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.emailEntry);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameEntry);
            this.Name = "addInstructor";
            this.Text = "Add Instructor";
            this.Load += new System.EventHandler(this.addInstructor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSTRUCTORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsManagementDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsManagementDataSet)).EndInit();
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
