namespace Course_Managment.Student.Upd_del
{
    partial class UpdStud
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
            this.Welcome = new System.Windows.Forms.Label();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.GoBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPASSWORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crsManagementDataSet = new Course_Managment.CrsManagementDataSet();
            this.sTUDENTTableAdapter = new Course_Managment.CrsManagementDataSetTableAdapters.STUDENTTableAdapter();
            this.View = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic);
            this.Welcome.ForeColor = System.Drawing.Color.SlateBlue;
            this.Welcome.Location = new System.Drawing.Point(409, 25);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(364, 36);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "UPDATE STUDENT INFO";
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(219, 317);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(246, 22);
            this.EmailText.TabIndex = 2;
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(219, 261);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(246, 22);
            this.PasswordText.TabIndex = 3;
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(219, 201);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(246, 22);
            this.NameText.TabIndex = 4;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic);
            this.Password.ForeColor = System.Drawing.Color.SlateBlue;
            this.Password.Location = new System.Drawing.Point(52, 247);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(147, 36);
            this.Password.TabIndex = 6;
            this.Password.Text = "Password";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic);
            this.NameLbl.ForeColor = System.Drawing.Color.SlateBlue;
            this.NameLbl.Location = new System.Drawing.Point(56, 187);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(92, 36);
            this.NameLbl.TabIndex = 7;
            this.NameLbl.Text = "Name";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic);
            this.Email.ForeColor = System.Drawing.Color.SlateBlue;
            this.Email.Location = new System.Drawing.Point(52, 304);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(88, 36);
            this.Email.TabIndex = 8;
            this.Email.Text = "Email";
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(58, 595);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(142, 41);
            this.Update.TabIndex = 9;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // GoBack
            // 
            this.GoBack.Location = new System.Drawing.Point(233, 595);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(142, 41);
            this.GoBack.TabIndex = 10;
            this.GoBack.Text = "GoBack";
            this.GoBack.UseVisualStyleBackColor = true;
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(579, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(552, 208);
            this.dataGridView1.TabIndex = 11;
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
            // View
            // 
            this.View.Location = new System.Drawing.Point(786, 381);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(143, 35);
            this.View.TabIndex = 12;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // UpdStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 722);
            this.Controls.Add(this.View);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GoBack);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.Welcome);
            this.Name = "UpdStud";
            this.Text = "UpdStud";
            this.Load += new System.EventHandler(this.UpdStud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsManagementDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button GoBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CrsManagementDataSet crsManagementDataSet;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource;
        private CrsManagementDataSetTableAdapters.STUDENTTableAdapter sTUDENTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPASSWORDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button View;
    }
}