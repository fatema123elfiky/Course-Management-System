namespace Course_Managment.Student.Upd_del
{
    partial class DelEnroll
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
            this.Delete = new System.Windows.Forms.Button();
            this.GoBack = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CrsID = new System.Windows.Forms.Label();
            this.StudIDText = new System.Windows.Forms.TextBox();
            this.CrsIDText = new System.Windows.Forms.TextBox();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.crsManagementDataSet = new Course_Managment.CrsManagementDataSet();
            this.eNROLLINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eNROLL_INTableAdapter = new Course_Managment.CrsManagementDataSetTableAdapters.ENROLL_INTableAdapter();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEMESTERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Welcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNROLLINBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(72, 307);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 0;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // GoBack
            // 
            this.GoBack.Location = new System.Drawing.Point(182, 307);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(75, 23);
            this.GoBack.TabIndex = 1;
            this.GoBack.Text = "GoBack";
            this.GoBack.UseVisualStyleBackColor = true;
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(544, 307);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(75, 23);
            this.View.TabIndex = 2;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "StudentID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CrsID
            // 
            this.CrsID.AutoSize = true;
            this.CrsID.Location = new System.Drawing.Point(69, 241);
            this.CrsID.Name = "CrsID";
            this.CrsID.Size = new System.Drawing.Size(40, 16);
            this.CrsID.TabIndex = 4;
            this.CrsID.Text = "CrsID";
            // 
            // StudIDText
            // 
            this.StudIDText.Location = new System.Drawing.Point(153, 186);
            this.StudIDText.Name = "StudIDText";
            this.StudIDText.Size = new System.Drawing.Size(153, 22);
            this.StudIDText.TabIndex = 5;
            // 
            // CrsIDText
            // 
            this.CrsIDText.Location = new System.Drawing.Point(153, 238);
            this.CrsIDText.Name = "CrsIDText";
            this.CrsIDText.Size = new System.Drawing.Size(153, 22);
            this.CrsIDText.TabIndex = 6;
            // 
            // DataGrid
            // 
            this.DataGrid.AutoGenerateColumns = false;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDDataGridViewTextBoxColumn,
            this.sEMESTERDataGridViewTextBoxColumn,
            this.yEARDataGridViewTextBoxColumn});
            this.DataGrid.DataSource = this.eNROLLINBindingSource;
            this.DataGrid.Location = new System.Drawing.Point(389, 125);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersWidth = 51;
            this.DataGrid.RowTemplate.Height = 24;
            this.DataGrid.Size = new System.Drawing.Size(399, 150);
            this.DataGrid.TabIndex = 7;
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
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(282, 23);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(231, 34);
            this.Welcome.TabIndex = 8;
            this.Welcome.Text = "DELETE ENROLLMENT";
            // 
            // DelEnroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.CrsIDText);
            this.Controls.Add(this.StudIDText);
            this.Controls.Add(this.CrsID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.View);
            this.Controls.Add(this.GoBack);
            this.Controls.Add(this.Delete);
            this.Name = "DelEnroll";
            this.Text = "DelEnroll";
            this.Load += new System.EventHandler(this.DelEnroll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNROLLINBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button GoBack;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CrsID;
        private System.Windows.Forms.TextBox StudIDText;
        private System.Windows.Forms.TextBox CrsIDText;
        private System.Windows.Forms.DataGridView DataGrid;
        private CrsManagementDataSet crsManagementDataSet;
        private System.Windows.Forms.BindingSource eNROLLINBindingSource;
        private CrsManagementDataSetTableAdapters.ENROLL_INTableAdapter eNROLL_INTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEMESTERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label Welcome;
    }
}