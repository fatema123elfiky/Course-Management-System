namespace Course_Managment.Instructor
{
    partial class addStudent
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
            this.nameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.emailErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPASSWORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crsManagementDataSet = new Course_Managment.CrsManagementDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.sTUDENTTableAdapter = new Course_Managment.CrsManagementDataSetTableAdapters.STUDENTTableAdapter();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addButton.Location = new System.Drawing.Point(241, 402);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(172, 38);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // emailEntry
            // 
            this.emailEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailEntry.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailEntry.Location = new System.Drawing.Point(293, 335);
            this.emailEntry.MaxLength = 200;
            this.emailEntry.Name = "emailEntry";
            this.emailEntry.Size = new System.Drawing.Size(230, 30);
            this.emailEntry.TabIndex = 13;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic);
            this.emailLabel.ForeColor = System.Drawing.Color.SlateBlue;
            this.emailLabel.Location = new System.Drawing.Point(124, 335);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(88, 36);
            this.emailLabel.TabIndex = 12;
            this.emailLabel.Text = "Email";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic);
            this.nameLabel.ForeColor = System.Drawing.Color.SlateBlue;
            this.nameLabel.Location = new System.Drawing.Point(120, 269);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(92, 36);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nameEntry
            // 
            this.nameEntry.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameEntry.Location = new System.Drawing.Point(293, 269);
            this.nameEntry.MaxLength = 200;
            this.nameEntry.Name = "nameEntry";
            this.nameEntry.Size = new System.Drawing.Size(230, 30);
            this.nameEntry.TabIndex = 10;
            this.nameEntry.WordWrap = false;
            // 
            // nameErrorProvider
            // 
            this.nameErrorProvider.ContainerControl = this;
            // 
            // emailErrorProvider
            // 
            this.emailErrorProvider.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(839, 457);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 36);
            this.button2.TabIndex = 16;
            this.button2.Text = "show data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sIDDataGridViewTextBoxColumn,
            this.sNAMEDataGridViewTextBoxColumn,
            this.sEMAILDataGridViewTextBoxColumn,
            this.sPASSWORDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sTUDENTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(581, 193);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(616, 246);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sIDDataGridViewTextBoxColumn
            // 
            this.sIDDataGridViewTextBoxColumn.DataPropertyName = "SID";
            this.sIDDataGridViewTextBoxColumn.HeaderText = "SID";
            this.sIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sIDDataGridViewTextBoxColumn.Name = "sIDDataGridViewTextBoxColumn";
            this.sIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // sNAMEDataGridViewTextBoxColumn
            // 
            this.sNAMEDataGridViewTextBoxColumn.DataPropertyName = "SNAME";
            this.sNAMEDataGridViewTextBoxColumn.HeaderText = "SNAME";
            this.sNAMEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sNAMEDataGridViewTextBoxColumn.Name = "sNAMEDataGridViewTextBoxColumn";
            this.sNAMEDataGridViewTextBoxColumn.Width = 150;
            // 
            // sEMAILDataGridViewTextBoxColumn
            // 
            this.sEMAILDataGridViewTextBoxColumn.DataPropertyName = "SEMAIL";
            this.sEMAILDataGridViewTextBoxColumn.HeaderText = "SEMAIL";
            this.sEMAILDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sEMAILDataGridViewTextBoxColumn.Name = "sEMAILDataGridViewTextBoxColumn";
            this.sEMAILDataGridViewTextBoxColumn.Width = 150;
            // 
            // sPASSWORDDataGridViewTextBoxColumn
            // 
            this.sPASSWORDDataGridViewTextBoxColumn.DataPropertyName = "SPASSWORD";
            this.sPASSWORDDataGridViewTextBoxColumn.HeaderText = "SPASSWORD";
            this.sPASSWORDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sPASSWORDDataGridViewTextBoxColumn.Name = "sPASSWORDDataGridViewTextBoxColumn";
            this.sPASSWORDDataGridViewTextBoxColumn.Width = 150;
            // 
            // sTUDENTBindingSource
            // 
            this.sTUDENTBindingSource.DataMember = "STUDENT";
            this.sTUDENTBindingSource.DataSource = this.crsManagementDataSet;
            // 
            // crsManagementDataSet
            // 
            this.crsManagementDataSet.DataSetName = "CrsManagementDataSet";
            this.crsManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(226, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "Add Student";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sTUDENTTableAdapter
            // 
            this.sTUDENTTableAdapter.ClearBeforeFill = true;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(112, 469);
            this.Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(129, 27);
            this.Back.TabIndex = 18;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // addStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 722);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.emailEntry);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameEntry);
            this.Name = "addStudent";
            this.Text = "Add Student";
            this.Load += new System.EventHandler(this.addStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).EndInit();
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
        private System.Windows.Forms.ErrorProvider nameErrorProvider;
        private System.Windows.Forms.ErrorProvider emailErrorProvider;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private CrsManagementDataSet crsManagementDataSet;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource;
        private CrsManagementDataSetTableAdapters.STUDENTTableAdapter sTUDENTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPASSWORDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Back;
    }
}
