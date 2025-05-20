namespace Course_Managment.Instructor.Upd_del
{
    partial class UpdCrs
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
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.txtNewCategory = new System.Windows.Forms.TextBox();
            this.txtOldCategory = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdateCourseName = new System.Windows.Forms.Button();
            this.txtNewCourseName = new System.Windows.Forms.TextBox();
            this.txtOldCourseName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdateExamName = new System.Windows.Forms.Button();
            this.txtNewExamName = new System.Windows.Forms.TextBox();
            this.txtOldExamName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXAMNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSHIDDENDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.eXAMCIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOURSEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.crsManagementDataSet = new Course_Managment.CrsManagementDataSet();
            this.cOURSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOURSETableAdapter = new Course_Managment.CrsManagementDataSetTableAdapters.COURSETableAdapter();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.fillByToolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(205, 472);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 30);
            this.button3.TabIndex = 35;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.btnUpdateCategory);
            this.panel4.Controls.Add(this.txtNewCategory);
            this.panel4.Controls.Add(this.txtOldCategory);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(198, 140);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(415, 298);
            this.panel4.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic);
            this.label9.ForeColor = System.Drawing.Color.SlateBlue;
            this.label9.Location = new System.Drawing.Point(97, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(239, 36);
            this.label9.TabIndex = 19;
            this.label9.Text = "Update Category";
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Location = new System.Drawing.Point(114, 226);
            this.btnUpdateCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(137, 43);
            this.btnUpdateCategory.TabIndex = 4;
            this.btnUpdateCategory.Text = "Update";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            // 
            // txtNewCategory
            // 
            this.txtNewCategory.Location = new System.Drawing.Point(167, 150);
            this.txtNewCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewCategory.Name = "txtNewCategory";
            this.txtNewCategory.Size = new System.Drawing.Size(181, 22);
            this.txtNewCategory.TabIndex = 3;
            // 
            // txtOldCategory
            // 
            this.txtOldCategory.Location = new System.Drawing.Point(167, 86);
            this.txtOldCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOldCategory.Name = "txtOldCategory";
            this.txtOldCategory.Size = new System.Drawing.Size(181, 22);
            this.txtOldCategory.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Enter the New one";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Enter your data";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnUpdateCourseName);
            this.panel3.Controls.Add(this.txtNewCourseName);
            this.panel3.Controls.Add(this.txtOldCourseName);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(196, 140);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(415, 302);
            this.panel3.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic);
            this.label6.ForeColor = System.Drawing.Color.SlateBlue;
            this.label6.Location = new System.Drawing.Point(97, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 36);
            this.label6.TabIndex = 19;
            this.label6.Text = "Update Course Name";
            // 
            // btnUpdateCourseName
            // 
            this.btnUpdateCourseName.Location = new System.Drawing.Point(114, 226);
            this.btnUpdateCourseName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateCourseName.Name = "btnUpdateCourseName";
            this.btnUpdateCourseName.Size = new System.Drawing.Size(137, 43);
            this.btnUpdateCourseName.TabIndex = 4;
            this.btnUpdateCourseName.Text = "Update";
            this.btnUpdateCourseName.UseVisualStyleBackColor = true;
            // 
            // txtNewCourseName
            // 
            this.txtNewCourseName.Location = new System.Drawing.Point(167, 150);
            this.txtNewCourseName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewCourseName.Name = "txtNewCourseName";
            this.txtNewCourseName.Size = new System.Drawing.Size(181, 22);
            this.txtNewCourseName.TabIndex = 3;
            // 
            // txtOldCourseName
            // 
            this.txtOldCourseName.Location = new System.Drawing.Point(167, 86);
            this.txtOldCourseName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOldCourseName.Name = "txtOldCourseName";
            this.txtOldCourseName.Size = new System.Drawing.Size(181, 22);
            this.txtOldCourseName.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Enter the New one";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Enter Course Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnUpdateExamName);
            this.panel2.Controls.Add(this.txtNewExamName);
            this.panel2.Controls.Add(this.txtOldExamName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(196, 140);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 300);
            this.panel2.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.Color.SlateBlue;
            this.label5.Location = new System.Drawing.Point(97, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 36);
            this.label5.TabIndex = 19;
            this.label5.Text = "Update Exam Name";
            // 
            // btnUpdateExamName
            // 
            this.btnUpdateExamName.Location = new System.Drawing.Point(114, 226);
            this.btnUpdateExamName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateExamName.Name = "btnUpdateExamName";
            this.btnUpdateExamName.Size = new System.Drawing.Size(137, 43);
            this.btnUpdateExamName.TabIndex = 4;
            this.btnUpdateExamName.Text = "Update";
            this.btnUpdateExamName.UseVisualStyleBackColor = true;
            // 
            // txtNewExamName
            // 
            this.txtNewExamName.Location = new System.Drawing.Point(167, 150);
            this.txtNewExamName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewExamName.Name = "txtNewExamName";
            this.txtNewExamName.Size = new System.Drawing.Size(181, 22);
            this.txtNewExamName.TabIndex = 3;
            // 
            // txtOldExamName
            // 
            this.txtOldExamName.Location = new System.Drawing.Point(167, 86);
            this.txtOldExamName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOldExamName.Name = "txtOldExamName";
            this.txtOldExamName.Size = new System.Drawing.Size(181, 22);
            this.txtOldExamName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Enter the New one";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter your data";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic);
            this.label12.ForeColor = System.Drawing.Color.SlateBlue;
            this.label12.Location = new System.Drawing.Point(237, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(273, 36);
            this.label12.TabIndex = 32;
            this.label12.Text = "Update Course Info";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(924, 140);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(106, 30);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1222, 27);
            this.fillByToolStrip.TabIndex = 30;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(48, 24);
            this.fillByToolStripButton.Text = "FillBy";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(196, 140);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 307);
            this.panel1.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "What Do You want to Update?";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(271, 103);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(761, 426);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 30);
            this.button2.TabIndex = 28;
            this.button2.Text = "Show Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 299);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 27;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(393, 212);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(89, 22);
            this.txtid.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Enter your ID";
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
            this.dataGridView1.DataSource = this.cOURSEBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(653, 185);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(333, 236);
            this.dataGridView1.TabIndex = 23;
            // 
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "CID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "CID";
            this.cIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            this.cIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // eXAMNAMEDataGridViewTextBoxColumn
            // 
            this.eXAMNAMEDataGridViewTextBoxColumn.DataPropertyName = "EXAMNAME";
            this.eXAMNAMEDataGridViewTextBoxColumn.HeaderText = "EXAMNAME";
            this.eXAMNAMEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eXAMNAMEDataGridViewTextBoxColumn.Name = "eXAMNAMEDataGridViewTextBoxColumn";
            this.eXAMNAMEDataGridViewTextBoxColumn.Width = 150;
            // 
            // cRSNAMEDataGridViewTextBoxColumn
            // 
            this.cRSNAMEDataGridViewTextBoxColumn.DataPropertyName = "CRSNAME";
            this.cRSNAMEDataGridViewTextBoxColumn.HeaderText = "CRSNAME";
            this.cRSNAMEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cRSNAMEDataGridViewTextBoxColumn.Name = "cRSNAMEDataGridViewTextBoxColumn";
            this.cRSNAMEDataGridViewTextBoxColumn.Width = 150;
            // 
            // cATEGORYDataGridViewTextBoxColumn
            // 
            this.cATEGORYDataGridViewTextBoxColumn.DataPropertyName = "CATEGORY";
            this.cATEGORYDataGridViewTextBoxColumn.HeaderText = "CATEGORY";
            this.cATEGORYDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cATEGORYDataGridViewTextBoxColumn.Name = "cATEGORYDataGridViewTextBoxColumn";
            this.cATEGORYDataGridViewTextBoxColumn.Width = 150;
            // 
            // iSHIDDENDataGridViewCheckBoxColumn
            // 
            this.iSHIDDENDataGridViewCheckBoxColumn.DataPropertyName = "ISHIDDEN";
            this.iSHIDDENDataGridViewCheckBoxColumn.HeaderText = "ISHIDDEN";
            this.iSHIDDENDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.iSHIDDENDataGridViewCheckBoxColumn.Name = "iSHIDDENDataGridViewCheckBoxColumn";
            this.iSHIDDENDataGridViewCheckBoxColumn.Width = 150;
            // 
            // eXAMCIDDataGridViewTextBoxColumn
            // 
            this.eXAMCIDDataGridViewTextBoxColumn.DataPropertyName = "EXAMCID";
            this.eXAMCIDDataGridViewTextBoxColumn.HeaderText = "EXAMCID";
            this.eXAMCIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eXAMCIDDataGridViewTextBoxColumn.Name = "eXAMCIDDataGridViewTextBoxColumn";
            this.eXAMCIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // cOURSEBindingSource1
            // 
            this.cOURSEBindingSource1.DataMember = "COURSE";
            this.cOURSEBindingSource1.DataSource = this.crsManagementDataSet;
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
            // UpdCrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 722);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UpdCrs";
            this.Text = "UpdCrs";
            this.Load += new System.EventHandler(this.UpdCrs_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.TextBox txtNewCategory;
        private System.Windows.Forms.TextBox txtOldCategory;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdateCourseName;
        private System.Windows.Forms.TextBox txtNewCourseName;
        private System.Windows.Forms.TextBox txtOldCourseName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdateExamName;
        private System.Windows.Forms.TextBox txtNewExamName;
        private System.Windows.Forms.TextBox txtOldExamName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.BindingSource cOURSEBindingSource1;
    }
}
