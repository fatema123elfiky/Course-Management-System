namespace Course_Managment.Common
{
    partial class ShowCrs
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
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXAMNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSHIDDENDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.eXAMCIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOURSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crsManagementDataSet = new Course_Managment.CrsManagementDataSet();
            this.ViewAll = new System.Windows.Forms.Button();
            this.GoBack = new System.Windows.Forms.Button();
            this.HighRegisteration = new System.Windows.Forms.Button();
            this.Welcome = new System.Windows.Forms.Label();
            this.cOURSETableAdapter = new Course_Managment.CrsManagementDataSetTableAdapters.COURSETableAdapter();
            this.Category = new System.Windows.Forms.Label();
            this.FilterCat = new System.Windows.Forms.Button();
            this.cOURSEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.CatValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(2, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(795, 170);
            this.dataGridView1.TabIndex = 0;
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
            // cOURSEBindingSource
            // 
            this.cOURSEBindingSource.DataMember = "COURSE";
            this.cOURSEBindingSource.DataSource = this.crsManagementDataSet;
            // 
            // crsManagementDataSet
            // 
            this.crsManagementDataSet.DataSetName = "CrsManagementDataSet";
            this.crsManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ViewAll
            // 
            this.ViewAll.Location = new System.Drawing.Point(188, 390);
            this.ViewAll.Name = "ViewAll";
            this.ViewAll.Size = new System.Drawing.Size(93, 27);
            this.ViewAll.TabIndex = 1;
            this.ViewAll.Text = "ViewAll";
            this.ViewAll.UseVisualStyleBackColor = true;
            this.ViewAll.Click += new System.EventHandler(this.ViewAll_Click);
            // 
            // GoBack
            // 
            this.GoBack.Location = new System.Drawing.Point(52, 391);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(93, 26);
            this.GoBack.TabIndex = 2;
            this.GoBack.Text = "GoBack";
            this.GoBack.UseVisualStyleBackColor = true;
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // HighRegisteration
            // 
            this.HighRegisteration.Location = new System.Drawing.Point(387, 320);
            this.HighRegisteration.Name = "HighRegisteration";
            this.HighRegisteration.Size = new System.Drawing.Size(140, 26);
            this.HighRegisteration.TabIndex = 3;
            this.HighRegisteration.Text = "HighRegisteration";
            this.HighRegisteration.UseVisualStyleBackColor = true;
            this.HighRegisteration.Click += new System.EventHandler(this.HighRegisteration_Click);
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(288, 19);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(263, 34);
            this.Welcome.TabIndex = 4;
            this.Welcome.Text = "SHOW COURSES \\ REPORT";
            this.Welcome.Click += new System.EventHandler(this.Welcome_Click);
            // 
            // cOURSETableAdapter
            // 
            this.cOURSETableAdapter.ClearBeforeFill = true;
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(578, 290);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(62, 16);
            this.Category.TabIndex = 6;
            this.Category.Text = "Category";
            // 
            // FilterCat
            // 
            this.FilterCat.Location = new System.Drawing.Point(581, 320);
            this.FilterCat.Name = "FilterCat";
            this.FilterCat.Size = new System.Drawing.Size(138, 26);
            this.FilterCat.TabIndex = 7;
            this.FilterCat.Text = "Category Filter";
            this.FilterCat.UseVisualStyleBackColor = true;
            this.FilterCat.Click += new System.EventHandler(this.FilterCat_Click);
            // 
            // cOURSEBindingSource1
            // 
            this.cOURSEBindingSource1.DataMember = "COURSE";
            this.cOURSEBindingSource1.DataSource = this.crsManagementDataSet;
            // 
            // CatValue
            // 
            this.CatValue.Location = new System.Drawing.Point(646, 284);
            this.CatValue.Name = "CatValue";
            this.CatValue.Size = new System.Drawing.Size(142, 22);
            this.CatValue.TabIndex = 8;
            // 
            // ShowCrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CatValue);
            this.Controls.Add(this.FilterCat);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.HighRegisteration);
            this.Controls.Add(this.GoBack);
            this.Controls.Add(this.ViewAll);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowCrs";
            this.Text = "ShowCrs";
            this.Load += new System.EventHandler(this.ShowCrs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ViewAll;
        private System.Windows.Forms.Button GoBack;
        private System.Windows.Forms.Button HighRegisteration;
        private System.Windows.Forms.Label Welcome;
        private CrsManagementDataSet crsManagementDataSet;
        private System.Windows.Forms.BindingSource cOURSEBindingSource;
        private CrsManagementDataSetTableAdapters.COURSETableAdapter cOURSETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXAMNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGORYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn iSHIDDENDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXAMCIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Button FilterCat;
        private System.Windows.Forms.BindingSource cOURSEBindingSource1;
        private System.Windows.Forms.TextBox CatValue;
    }
}