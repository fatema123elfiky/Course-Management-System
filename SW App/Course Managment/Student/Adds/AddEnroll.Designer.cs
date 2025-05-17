namespace Course_Managment.Student.Adds
{
    partial class AddEnroll
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
            this.View = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.StudentID = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.Semester = new System.Windows.Forms.Label();
            this.CrsID = new System.Windows.Forms.Label();
            this.YearText = new System.Windows.Forms.TextBox();
            this.CrsIDText = new System.Windows.Forms.TextBox();
            this.StudIDText = new System.Windows.Forms.TextBox();
            this.SemesterText = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.crsManagementDataSet = new Course_Managment.CrsManagementDataSet();
            this.eNROLLINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eNROLL_INTableAdapter = new Course_Managment.CrsManagementDataSetTableAdapters.ENROLL_INTableAdapter();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEMESTERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.Welcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNROLLINBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(545, 288);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(75, 23);
            this.View.TabIndex = 0;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(70, 288);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // StudentID
            // 
            this.StudentID.AutoSize = true;
            this.StudentID.Location = new System.Drawing.Point(67, 88);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(65, 16);
            this.StudentID.TabIndex = 2;
            this.StudentID.Text = "StudentID";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(67, 132);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(36, 16);
            this.Year.TabIndex = 3;
            this.Year.Text = "Year";
            // 
            // Semester
            // 
            this.Semester.AutoSize = true;
            this.Semester.Location = new System.Drawing.Point(67, 170);
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(65, 16);
            this.Semester.TabIndex = 4;
            this.Semester.Text = "Semester";
            // 
            // CrsID
            // 
            this.CrsID.AutoSize = true;
            this.CrsID.Location = new System.Drawing.Point(71, 215);
            this.CrsID.Name = "CrsID";
            this.CrsID.Size = new System.Drawing.Size(40, 16);
            this.CrsID.TabIndex = 5;
            this.CrsID.Text = "CrsID";
            // 
            // YearText
            // 
            this.YearText.Location = new System.Drawing.Point(138, 126);
            this.YearText.Name = "YearText";
            this.YearText.Size = new System.Drawing.Size(173, 22);
            this.YearText.TabIndex = 6;
            // 
            // CrsIDText
            // 
            this.CrsIDText.Location = new System.Drawing.Point(138, 209);
            this.CrsIDText.Name = "CrsIDText";
            this.CrsIDText.Size = new System.Drawing.Size(173, 22);
            this.CrsIDText.TabIndex = 7;
            // 
            // StudIDText
            // 
            this.StudIDText.Location = new System.Drawing.Point(138, 82);
            this.StudIDText.Name = "StudIDText";
            this.StudIDText.Size = new System.Drawing.Size(173, 22);
            this.StudIDText.TabIndex = 8;
            // 
            // SemesterText
            // 
            this.SemesterText.Location = new System.Drawing.Point(138, 167);
            this.SemesterText.Name = "SemesterText";
            this.SemesterText.Size = new System.Drawing.Size(173, 22);
            this.SemesterText.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDDataGridViewTextBoxColumn,
            this.sEMESTERDataGridViewTextBoxColumn,
            this.yEARDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eNROLLINBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(371, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(395, 150);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // crsManagementDataSet
            // 
            this.crsManagementDataSet.DataSetName = "CrsManagementDataSet";
            this.crsManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eNROLLINBindingSource
            // 
            this.eNROLLINBindingSource.DataMember = "ENROLL_IN";
            this.eNROLLINBindingSource.DataSource = this.crsManagementDataSet;
            // 
            // eNROLL_INTableAdapter
            // 
            this.eNROLL_INTableAdapter.ClearBeforeFill = true;
            // 
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "CID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "CID";
            this.cIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            this.cIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // sEMESTERDataGridViewTextBoxColumn
            // 
            this.sEMESTERDataGridViewTextBoxColumn.DataPropertyName = "SEMESTER";
            this.sEMESTERDataGridViewTextBoxColumn.HeaderText = "SEMESTER";
            this.sEMESTERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sEMESTERDataGridViewTextBoxColumn.Name = "sEMESTERDataGridViewTextBoxColumn";
            this.sEMESTERDataGridViewTextBoxColumn.Width = 125;
            // 
            // yEARDataGridViewTextBoxColumn
            // 
            this.yEARDataGridViewTextBoxColumn.DataPropertyName = "YEAR";
            this.yEARDataGridViewTextBoxColumn.HeaderText = "YEAR";
            this.yEARDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yEARDataGridViewTextBoxColumn.Name = "yEARDataGridViewTextBoxColumn";
            this.yEARDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "GoBack";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Welcome.Location = new System.Drawing.Point(281, 21);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(200, 34);
            this.Welcome.TabIndex = 12;
            this.Welcome.Text = "ADD ENROLLMENT";
            // 
            // AddEnroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 345);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SemesterText);
            this.Controls.Add(this.StudIDText);
            this.Controls.Add(this.CrsIDText);
            this.Controls.Add(this.YearText);
            this.Controls.Add(this.CrsID);
            this.Controls.Add(this.Semester);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.StudentID);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.View);
            this.Name = "AddEnroll";
            this.Text = "AddEnroll";
            this.Load += new System.EventHandler(this.AddEnroll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNROLLINBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label StudentID;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label Semester;
        private System.Windows.Forms.Label CrsID;
        private System.Windows.Forms.TextBox YearText;
        private System.Windows.Forms.TextBox CrsIDText;
        private System.Windows.Forms.TextBox StudIDText;
        private System.Windows.Forms.TextBox SemesterText;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CrsManagementDataSet crsManagementDataSet;
        private System.Windows.Forms.BindingSource eNROLLINBindingSource;
        private CrsManagementDataSetTableAdapters.ENROLL_INTableAdapter eNROLL_INTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEMESTERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Welcome;
    }
}