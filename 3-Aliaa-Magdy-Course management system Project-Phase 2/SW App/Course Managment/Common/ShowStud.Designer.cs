namespace Course_Managment.Common
{
    partial class ShowStud
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
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPASSWORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crsManagementDataSet = new Course_Managment.CrsManagementDataSet();
            this.sTUDENTTableAdapter = new Course_Managment.CrsManagementDataSetTableAdapters.STUDENTTableAdapter();
            this.Welcome = new System.Windows.Forms.Label();
            this.GoBack = new System.Windows.Forms.Button();
            this.ViewAll = new System.Windows.Forms.Button();
            this.TopFive = new System.Windows.Forms.Button();
            this.GradeFilter = new System.Windows.Forms.Button();
            this.Grade = new System.Windows.Forms.Label();
            this.GradeText = new System.Windows.Forms.TextBox();
            this.CrsIDText = new System.Windows.Forms.TextBox();
            this.CRSID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsManagementDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(136, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(552, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // sIDDataGridViewTextBoxColumn
            // 
            this.sIDDataGridViewTextBoxColumn.DataPropertyName = "SID";
            this.sIDDataGridViewTextBoxColumn.HeaderText = "SID";
            this.sIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sIDDataGridViewTextBoxColumn.Name = "sIDDataGridViewTextBoxColumn";
            this.sIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // sNAMEDataGridViewTextBoxColumn
            // 
            this.sNAMEDataGridViewTextBoxColumn.DataPropertyName = "SNAME";
            this.sNAMEDataGridViewTextBoxColumn.HeaderText = "SNAME";
            this.sNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sNAMEDataGridViewTextBoxColumn.Name = "sNAMEDataGridViewTextBoxColumn";
            this.sNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // sEMAILDataGridViewTextBoxColumn
            // 
            this.sEMAILDataGridViewTextBoxColumn.DataPropertyName = "SEMAIL";
            this.sEMAILDataGridViewTextBoxColumn.HeaderText = "SEMAIL";
            this.sEMAILDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sEMAILDataGridViewTextBoxColumn.Name = "sEMAILDataGridViewTextBoxColumn";
            this.sEMAILDataGridViewTextBoxColumn.Width = 125;
            // 
            // sPASSWORDDataGridViewTextBoxColumn
            // 
            this.sPASSWORDDataGridViewTextBoxColumn.DataPropertyName = "SPASSWORD";
            this.sPASSWORDDataGridViewTextBoxColumn.HeaderText = "SPASSWORD";
            this.sPASSWORDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sPASSWORDDataGridViewTextBoxColumn.Name = "sPASSWORDDataGridViewTextBoxColumn";
            this.sPASSWORDDataGridViewTextBoxColumn.Width = 125;
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
            // sTUDENTTableAdapter
            // 
            this.sTUDENTTableAdapter.ClearBeforeFill = true;
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(274, 21);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(276, 34);
            this.Welcome.TabIndex = 1;
            this.Welcome.Text = "SHOW STUDENTS \\ REPORT";
            // 
            // GoBack
            // 
            this.GoBack.Location = new System.Drawing.Point(64, 379);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(89, 28);
            this.GoBack.TabIndex = 2;
            this.GoBack.Text = "GoBack";
            this.GoBack.UseVisualStyleBackColor = true;
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // ViewAll
            // 
            this.ViewAll.Location = new System.Drawing.Point(173, 379);
            this.ViewAll.Name = "ViewAll";
            this.ViewAll.Size = new System.Drawing.Size(90, 28);
            this.ViewAll.TabIndex = 3;
            this.ViewAll.Text = "ViewAll";
            this.ViewAll.UseVisualStyleBackColor = true;
            this.ViewAll.Click += new System.EventHandler(this.ViewAll_Click);
            // 
            // TopFive
            // 
            this.TopFive.Location = new System.Drawing.Point(317, 356);
            this.TopFive.Name = "TopFive";
            this.TopFive.Size = new System.Drawing.Size(94, 27);
            this.TopFive.TabIndex = 4;
            this.TopFive.Text = "Get Top Five";
            this.TopFive.UseVisualStyleBackColor = true;
            this.TopFive.Click += new System.EventHandler(this.TopFive_Click);
            // 
            // GradeFilter
            // 
            this.GradeFilter.Location = new System.Drawing.Point(551, 356);
            this.GradeFilter.Name = "GradeFilter";
            this.GradeFilter.Size = new System.Drawing.Size(100, 27);
            this.GradeFilter.TabIndex = 5;
            this.GradeFilter.Text = "Grade Filter";
            this.GradeFilter.UseVisualStyleBackColor = true;
            this.GradeFilter.Click += new System.EventHandler(this.GradeFilter_Click);
            // 
            // Grade
            // 
            this.Grade.AutoSize = true;
            this.Grade.Location = new System.Drawing.Point(548, 291);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(45, 16);
            this.Grade.TabIndex = 6;
            this.Grade.Text = "Grade";
            // 
            // GradeText
            // 
            this.GradeText.Location = new System.Drawing.Point(611, 285);
            this.GradeText.Name = "GradeText";
            this.GradeText.Size = new System.Drawing.Size(146, 22);
            this.GradeText.TabIndex = 7;
            // 
            // CrsIDText
            // 
            this.CrsIDText.Location = new System.Drawing.Point(369, 288);
            this.CrsIDText.Name = "CrsIDText";
            this.CrsIDText.Size = new System.Drawing.Size(149, 22);
            this.CrsIDText.TabIndex = 8;
            // 
            // CRSID
            // 
            this.CRSID.AutoSize = true;
            this.CRSID.Location = new System.Drawing.Point(314, 291);
            this.CRSID.Name = "CRSID";
            this.CRSID.Size = new System.Drawing.Size(40, 16);
            this.CRSID.TabIndex = 9;
            this.CRSID.Text = "CrsID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(551, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "CrsID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(611, 314);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 22);
            this.textBox1.TabIndex = 11;
            // 
            // ShowStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CRSID);
            this.Controls.Add(this.CrsIDText);
            this.Controls.Add(this.GradeText);
            this.Controls.Add(this.Grade);
            this.Controls.Add(this.GradeFilter);
            this.Controls.Add(this.TopFive);
            this.Controls.Add(this.ViewAll);
            this.Controls.Add(this.GoBack);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowStud";
            this.Text = "ShowStud";
            this.Load += new System.EventHandler(this.ShowStud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsManagementDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CrsManagementDataSet crsManagementDataSet;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource;
        private CrsManagementDataSetTableAdapters.STUDENTTableAdapter sTUDENTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPASSWORDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Button GoBack;
        private System.Windows.Forms.Button ViewAll;
        private System.Windows.Forms.Button TopFive;
        private System.Windows.Forms.Button GradeFilter;
        private System.Windows.Forms.Label Grade;
        private System.Windows.Forms.TextBox GradeText;
        private System.Windows.Forms.TextBox CrsIDText;
        private System.Windows.Forms.Label CRSID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}