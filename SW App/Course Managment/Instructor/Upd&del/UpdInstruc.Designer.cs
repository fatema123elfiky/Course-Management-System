
namespace Course_Managment.Instructor.Upd_del
{
    partial class UpdInstruc
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
            this.iIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPASSWORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNSTRUCTORBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.crsManagementDataSet = new Course_Managment.CrsManagementDataSet();
            this.iNSTRUCTORBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.CrsManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNSTRUCTORBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.iNSTRUCTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdateEmail = new System.Windows.Forms.Button();
            this.txtNewEmail = new System.Windows.Forms.TextBox();
            this.txtOldEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdateName = new System.Windows.Forms.Button();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.txtOldName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iNSTRUCTORBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.iNSTRUCTORTableAdapter1 = new Course_Managment.CrsManagementDataSetTableAdapters.INSTRUCTORTableAdapter();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSTRUCTORBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSTRUCTORBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrsManagementDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSTRUCTORBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSTRUCTORBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iNSTRUCTORBindingSource1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.DataSource = this.iNSTRUCTORBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(526, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(375, 295);
            this.dataGridView1.TabIndex = 0;
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
            // iNSTRUCTORBindingSource4
            // 
            this.iNSTRUCTORBindingSource4.DataMember = "INSTRUCTOR";
            this.iNSTRUCTORBindingSource4.DataSource = this.crsManagementDataSet;
            // 
            // crsManagementDataSet
            // 
            this.crsManagementDataSet.DataSetName = "CrsManagementDataSet";
            this.crsManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iNSTRUCTORBindingSource3
            // 
            this.iNSTRUCTORBindingSource3.DataMember = "INSTRUCTOR";
            this.iNSTRUCTORBindingSource3.DataSource = this.CrsManagementDataSetBindingSource;
            // 
            // CrsManagementDataSetBindingSource
            // 
            this.CrsManagementDataSetBindingSource.DataSource = this.crsManagementDataSet;
            // 
            // iNSTRUCTORBindingSource2
            // 
            this.iNSTRUCTORBindingSource2.DataMember = "INSTRUCTOR";
            this.iNSTRUCTORBindingSource2.DataSource = this.CrsManagementDataSetBindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter your ID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(234, 123);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 26);
            this.txtid.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(648, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Show Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // iNSTRUCTORBindingSource
            // 
            this.iNSTRUCTORBindingSource.DataMember = "INSTRUCTOR";
            this.iNSTRUCTORBindingSource.DataSource = this.CrsManagementDataSetBindingSource;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 384);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "What Do You want to Update?";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(305, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnUpdateEmail);
            this.panel3.Controls.Add(this.txtNewEmail);
            this.panel3.Controls.Add(this.txtOldEmail);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(12, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(467, 378);
            this.panel3.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Adobe Song Std L", 18F, System.Drawing.FontStyle.Italic);
            this.label6.ForeColor = System.Drawing.Color.SlateBlue;
            this.label6.Location = new System.Drawing.Point(109, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 42);
            this.label6.TabIndex = 19;
            this.label6.Text = "Update Email";
            // 
            // btnUpdateEmail
            // 
            this.btnUpdateEmail.Location = new System.Drawing.Point(128, 282);
            this.btnUpdateEmail.Name = "btnUpdateEmail";
            this.btnUpdateEmail.Size = new System.Drawing.Size(154, 54);
            this.btnUpdateEmail.TabIndex = 4;
            this.btnUpdateEmail.Text = "Update";
            this.btnUpdateEmail.UseVisualStyleBackColor = true;
            // 
            // txtNewEmail
            // 
            this.txtNewEmail.Location = new System.Drawing.Point(188, 188);
            this.txtNewEmail.Name = "txtNewEmail";
            this.txtNewEmail.Size = new System.Drawing.Size(203, 26);
            this.txtNewEmail.TabIndex = 3;
            // 
            // txtOldEmail
            // 
            this.txtOldEmail.Location = new System.Drawing.Point(188, 107);
            this.txtOldEmail.Name = "txtOldEmail";
            this.txtOldEmail.Size = new System.Drawing.Size(203, 26);
            this.txtOldEmail.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Enter the New one";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Enter your data";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.btnUpdatePassword);
            this.panel4.Controls.Add(this.txtNewPassword);
            this.panel4.Controls.Add(this.txtOldPassword);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(12, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(467, 373);
            this.panel4.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Adobe Song Std L", 18F, System.Drawing.FontStyle.Italic);
            this.label9.ForeColor = System.Drawing.Color.SlateBlue;
            this.label9.Location = new System.Drawing.Point(109, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(262, 42);
            this.label9.TabIndex = 19;
            this.label9.Text = "Update Password";
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.Location = new System.Drawing.Point(128, 282);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(154, 54);
            this.btnUpdatePassword.TabIndex = 4;
            this.btnUpdatePassword.Text = "Update";
            this.btnUpdatePassword.UseVisualStyleBackColor = true;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(188, 188);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(203, 26);
            this.txtNewPassword.TabIndex = 3;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(188, 107);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(203, 26);
            this.txtOldPassword.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Enter the New one";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Enter your data";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnUpdateName);
            this.panel2.Controls.Add(this.txtNewName);
            this.panel2.Controls.Add(this.txtOldName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 375);
            this.panel2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Adobe Song Std L", 18F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.Color.SlateBlue;
            this.label5.Location = new System.Drawing.Point(109, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 42);
            this.label5.TabIndex = 19;
            this.label5.Text = "Update Name";
            // 
            // btnUpdateName
            // 
            this.btnUpdateName.Location = new System.Drawing.Point(128, 282);
            this.btnUpdateName.Name = "btnUpdateName";
            this.btnUpdateName.Size = new System.Drawing.Size(154, 54);
            this.btnUpdateName.TabIndex = 4;
            this.btnUpdateName.Text = "Update";
            this.btnUpdateName.UseVisualStyleBackColor = true;
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(188, 188);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(203, 26);
            this.txtNewName.TabIndex = 3;
            // 
            // txtOldName
            // 
            this.txtOldName.Location = new System.Drawing.Point(188, 107);
            this.txtOldName.Name = "txtOldName";
            this.txtOldName.Size = new System.Drawing.Size(203, 26);
            this.txtOldName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Enter the New one";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter your data";
            // 
            // iNSTRUCTORBindingSource1
            // 
            this.iNSTRUCTORBindingSource1.DataMember = "INSTRUCTOR";
            this.iNSTRUCTORBindingSource1.DataSource = this.CrsManagementDataSetBindingSource;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(962, 34);
            this.fillByToolStrip.TabIndex = 6;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(56, 29);
            this.fillByToolStripButton.Text = "FillBy";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(831, 34);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(119, 38);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // iNSTRUCTORTableAdapter1
            // 
            this.iNSTRUCTORTableAdapter1.ClearBeforeFill = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Adobe Song Std L", 18F, System.Drawing.FontStyle.Italic);
            this.label12.ForeColor = System.Drawing.Color.SlateBlue;
            this.label12.Location = new System.Drawing.Point(59, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(331, 42);
            this.label12.TabIndex = 8;
            this.label12.Text = "Update Instractor Info";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 449);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 38);
            this.button3.TabIndex = 22;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // UpdInstruc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 520);
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
            this.Name = "UpdInstruc";
            this.Text = "UpdInstruc";
            this.Load += new System.EventHandler(this.UpdInstruc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSTRUCTORBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSTRUCTORBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrsManagementDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSTRUCTORBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSTRUCTORBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iNSTRUCTORBindingSource1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource CrsManagementDataSetBindingSource;
        private CrsManagementDataSet CrsManagementDataSet;
        //private CrsManagementDataSetTableAdapters.COURSETableAdapter cOURSETableAdapter;
        //private CrsManagementDataSetTableAdapters.COURSETableAdapter cOURSETableAdapter;

        private System.Windows.Forms.BindingSource iNSTRUCTORBindingSource;
       // private CrsManagementDataSetTableAdapters.INSTRUCTORTableAdapter iNSTRUCTORTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.TextBox txtOldName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdateName;
        private System.Windows.Forms.BindingSource iNSTRUCTORBindingSource1;
        private System.Windows.Forms.BindingSource iNSTRUCTORBindingSource2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdateEmail;
        private System.Windows.Forms.TextBox txtNewEmail;
        private System.Windows.Forms.TextBox txtOldEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource iNSTRUCTORBindingSource3;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Button btnBack;
        private CrsManagementDataSet crsManagementDataSet;
        private System.Windows.Forms.BindingSource iNSTRUCTORBindingSource4;
        private CrsManagementDataSetTableAdapters.INSTRUCTORTableAdapter iNSTRUCTORTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPASSWORDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
    }
}
