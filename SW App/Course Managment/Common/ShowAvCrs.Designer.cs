namespace Course_Managment.Common
{
    partial class ShowAvCrs
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
            this.CatValue = new System.Windows.Forms.TextBox();
            this.FilterCat = new System.Windows.Forms.Button();
            this.Category = new System.Windows.Forms.Label();
            this.Welcome = new System.Windows.Forms.Label();
            this.HighRegisteration = new System.Windows.Forms.Button();
            this.GoBack = new System.Windows.Forms.Button();
            this.ViewAll = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.crsManagementDataSet = new Course_Managment.CrsManagementDataSet();
            this.cOURSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOURSETableAdapter = new Course_Managment.CrsManagementDataSetTableAdapters.COURSETableAdapter();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXAMNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSHIDDENDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.eXAMCIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CatValue
            // 
            this.CatValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.CatValue.Location = new System.Drawing.Point(897, 400);
            this.CatValue.Name = "CatValue";
            this.CatValue.Size = new System.Drawing.Size(190, 22);
            this.CatValue.TabIndex = 16;
            this.CatValue.TextChanged += new System.EventHandler(this.CatValue_TextChanged);
            // 
            // FilterCat
            // 
            this.FilterCat.Location = new System.Drawing.Point(772, 460);
            this.FilterCat.Name = "FilterCat";
            this.FilterCat.Size = new System.Drawing.Size(165, 42);
            this.FilterCat.TabIndex = 15;
            this.FilterCat.Text = "Category Filter";
            this.FilterCat.UseVisualStyleBackColor = true;
            this.FilterCat.Click += new System.EventHandler(this.FilterCat_Click);
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic);
            this.Category.ForeColor = System.Drawing.Color.SlateBlue;
            this.Category.Location = new System.Drawing.Point(766, 391);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(125, 31);
            this.Category.TabIndex = 14;
            this.Category.Text = "Category";
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic);
            this.Welcome.ForeColor = System.Drawing.Color.SlateBlue;
            this.Welcome.Location = new System.Drawing.Point(352, 24);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(410, 36);
            this.Welcome.TabIndex = 13;
            this.Welcome.Text = "SHOW COURSES \\ REPORT";
            this.Welcome.Click += new System.EventHandler(this.Welcome_Click);
            // 
            // HighRegisteration
            // 
            this.HighRegisteration.Location = new System.Drawing.Point(535, 460);
            this.HighRegisteration.Name = "HighRegisteration";
            this.HighRegisteration.Size = new System.Drawing.Size(158, 42);
            this.HighRegisteration.TabIndex = 12;
            this.HighRegisteration.Text = "HighRegisteration";
            this.HighRegisteration.UseVisualStyleBackColor = true;
            this.HighRegisteration.Click += new System.EventHandler(this.HighRegisteration_Click);
            // 
            // GoBack
            // 
            this.GoBack.Location = new System.Drawing.Point(87, 607);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(111, 39);
            this.GoBack.TabIndex = 11;
            this.GoBack.Text = "GoBack";
            this.GoBack.UseVisualStyleBackColor = true;
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // ViewAll
            // 
            this.ViewAll.Location = new System.Drawing.Point(283, 607);
            this.ViewAll.Name = "ViewAll";
            this.ViewAll.Size = new System.Drawing.Size(120, 39);
            this.ViewAll.TabIndex = 10;
            this.ViewAll.Text = "ViewAll";
            this.ViewAll.UseVisualStyleBackColor = true;
            this.ViewAll.Click += new System.EventHandler(this.ViewAll_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDDataGridViewTextBoxColumn,
            this.eXAMNAMEDataGridViewTextBoxColumn,
            this.cRSNAMEDataGridViewTextBoxColumn,
            this.cATEGORYDataGridViewTextBoxColumn,
            this.iSHIDDENDataGridViewCheckBoxColumn,
            this.eXAMCIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cOURSEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(199, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(799, 277);
            this.dataGridView1.TabIndex = 9;
            // 
            // crsManagementDataSet
            // 
            this.crsManagementDataSet.DataSetName = "CrsManagementDataSet";
            this.crsManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOURSEBindingSource
            // 
            this.cOURSEBindingSource.DataMember = "COURSE";
            this.cOURSEBindingSource.DataSource = this.crsManagementDataSet;
            // 
            // cOURSETableAdapter
            // 
            this.cOURSETableAdapter.ClearBeforeFill = true;
            // 
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "CID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "CID";
            this.cIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            this.cIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // eXAMNAMEDataGridViewTextBoxColumn
            // 
            this.eXAMNAMEDataGridViewTextBoxColumn.DataPropertyName = "EXAMNAME";
            this.eXAMNAMEDataGridViewTextBoxColumn.HeaderText = "EXAMNAME";
            this.eXAMNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eXAMNAMEDataGridViewTextBoxColumn.Name = "eXAMNAMEDataGridViewTextBoxColumn";
            this.eXAMNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // cRSNAMEDataGridViewTextBoxColumn
            // 
            this.cRSNAMEDataGridViewTextBoxColumn.DataPropertyName = "CRSNAME";
            this.cRSNAMEDataGridViewTextBoxColumn.HeaderText = "CRSNAME";
            this.cRSNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cRSNAMEDataGridViewTextBoxColumn.Name = "cRSNAMEDataGridViewTextBoxColumn";
            this.cRSNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // cATEGORYDataGridViewTextBoxColumn
            // 
            this.cATEGORYDataGridViewTextBoxColumn.DataPropertyName = "CATEGORY";
            this.cATEGORYDataGridViewTextBoxColumn.HeaderText = "CATEGORY";
            this.cATEGORYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cATEGORYDataGridViewTextBoxColumn.Name = "cATEGORYDataGridViewTextBoxColumn";
            this.cATEGORYDataGridViewTextBoxColumn.Width = 125;
            // 
            // iSHIDDENDataGridViewCheckBoxColumn
            // 
            this.iSHIDDENDataGridViewCheckBoxColumn.DataPropertyName = "ISHIDDEN";
            this.iSHIDDENDataGridViewCheckBoxColumn.HeaderText = "ISHIDDEN";
            this.iSHIDDENDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.iSHIDDENDataGridViewCheckBoxColumn.Name = "iSHIDDENDataGridViewCheckBoxColumn";
            this.iSHIDDENDataGridViewCheckBoxColumn.Width = 125;
            // 
            // eXAMCIDDataGridViewTextBoxColumn
            // 
            this.eXAMCIDDataGridViewTextBoxColumn.DataPropertyName = "EXAMCID";
            this.eXAMCIDDataGridViewTextBoxColumn.HeaderText = "EXAMCID";
            this.eXAMCIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eXAMCIDDataGridViewTextBoxColumn.Name = "eXAMCIDDataGridViewTextBoxColumn";
            this.eXAMCIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ShowAvCrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 722);
            this.Controls.Add(this.CatValue);
            this.Controls.Add(this.FilterCat);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.HighRegisteration);
            this.Controls.Add(this.GoBack);
            this.Controls.Add(this.ViewAll);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowAvCrs";
            this.Text = "ShowAvCrs";
            this.Load += new System.EventHandler(this.ShowAvCrs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CatValue;
        private System.Windows.Forms.Button FilterCat;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Button HighRegisteration;
        private System.Windows.Forms.Button GoBack;
        private System.Windows.Forms.Button ViewAll;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CrsManagementDataSet crsManagementDataSet;
        private System.Windows.Forms.BindingSource cOURSEBindingSource;
        private CrsManagementDataSetTableAdapters.COURSETableAdapter cOURSETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXAMNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGORYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn iSHIDDENDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXAMCIDDataGridViewTextBoxColumn;
    }
}