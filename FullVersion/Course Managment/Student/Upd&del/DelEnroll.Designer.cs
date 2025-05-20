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
            this.CrsID = new System.Windows.Forms.Label();
            this.CrsIDText = new System.Windows.Forms.TextBox();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEMESTERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNROLLINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crsManagementDataSet = new Course_Managment.CrsManagementDataSet();
            this.eNROLL_INTableAdapter = new Course_Managment.CrsManagementDataSetTableAdapters.ENROLL_INTableAdapter();
            this.Welcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNROLLINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(87, 542);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(138, 42);
            this.Delete.TabIndex = 0;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // GoBack
            // 
            this.GoBack.Location = new System.Drawing.Point(247, 542);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(152, 42);
            this.GoBack.TabIndex = 1;
            this.GoBack.Text = "GoBack";
            this.GoBack.UseVisualStyleBackColor = true;
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(679, 433);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(174, 42);
            this.View.TabIndex = 2;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // CrsID
            // 
            this.CrsID.AutoSize = true;
            this.CrsID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic);
            this.CrsID.ForeColor = System.Drawing.Color.SlateBlue;
            this.CrsID.Location = new System.Drawing.Point(69, 277);
            this.CrsID.Name = "CrsID";
            this.CrsID.Size = new System.Drawing.Size(90, 36);
            this.CrsID.TabIndex = 4;
            this.CrsID.Text = "CrsID";
            // 
            // CrsIDText
            // 
            this.CrsIDText.Location = new System.Drawing.Point(165, 290);
            this.CrsIDText.Name = "CrsIDText";
            this.CrsIDText.Size = new System.Drawing.Size(195, 22);
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
            this.DataGrid.Location = new System.Drawing.Point(490, 137);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersWidth = 51;
            this.DataGrid.RowTemplate.Height = 24;
            this.DataGrid.Size = new System.Drawing.Size(554, 251);
            this.DataGrid.TabIndex = 7;
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
            // eNROLLINBindingSource
            // 
            this.eNROLLINBindingSource.DataMember = "ENROLL_IN";
            this.eNROLLINBindingSource.DataSource = this.crsManagementDataSet;
            // 
            // crsManagementDataSet
            // 
            this.crsManagementDataSet.DataSetName = "CrsManagementDataSet";
            this.crsManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eNROLL_INTableAdapter
            // 
            this.eNROLL_INTableAdapter.ClearBeforeFill = true;
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic);
            this.Welcome.ForeColor = System.Drawing.Color.SlateBlue;
            this.Welcome.Location = new System.Drawing.Point(484, 28);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(344, 36);
            this.Welcome.TabIndex = 8;
            this.Welcome.Text = "DELETE ENROLLMENT";
            this.Welcome.Click += new System.EventHandler(this.Welcome_Click);
            // 
            // DelEnroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 722);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.CrsIDText);
            this.Controls.Add(this.CrsID);
            this.Controls.Add(this.View);
            this.Controls.Add(this.GoBack);
            this.Controls.Add(this.Delete);
            this.Name = "DelEnroll";
            this.Text = "DelEnroll";
            this.Load += new System.EventHandler(this.DelEnroll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNROLLINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsManagementDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button GoBack;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Label CrsID;
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