namespace Course_Managment.Instructor.Adds
{
    partial class AddGrade
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
            this.AddButton = new System.Windows.Forms.Button();
            this.SIDLabel = new System.Windows.Forms.Label();
            this.CrsIDLabel = new System.Windows.Forms.Label();
            this.SID = new System.Windows.Forms.TextBox();
            this.CrsID = new System.Windows.Forms.TextBox();
            this.Grade = new System.Windows.Forms.TextBox();
            this.GradeLabel = new System.Windows.Forms.Label();
            this.GradeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SIDErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CrsIDErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SemesterErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.GoBack = new System.Windows.Forms.Button();
            this.crsManagementDataSet = new Course_Managment.CrsManagementDataSet();
            this.eNROLLINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eNROLL_INTableAdapter = new Course_Managment.CrsManagementDataSetTableAdapters.ENROLL_INTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GradeErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SIDErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrsIDErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SemesterErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNROLLINBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddButton.Location = new System.Drawing.Point(482, 504);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(212, 58);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add Grade";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SIDLabel
            // 
            this.SIDLabel.AutoSize = true;
            this.SIDLabel.Font = new System.Drawing.Font("Adobe Song Std L", 16F, System.Drawing.FontStyle.Italic);
            this.SIDLabel.Location = new System.Drawing.Point(270, 256);
            this.SIDLabel.Name = "SIDLabel";
            this.SIDLabel.Size = new System.Drawing.Size(155, 37);
            this.SIDLabel.TabIndex = 1;
            this.SIDLabel.Text = "Student ID";
            // 
            // CrsIDLabel
            // 
            this.CrsIDLabel.AutoSize = true;
            this.CrsIDLabel.Font = new System.Drawing.Font("Adobe Song Std L", 16F, System.Drawing.FontStyle.Italic);
            this.CrsIDLabel.Location = new System.Drawing.Point(270, 325);
            this.CrsIDLabel.Name = "CrsIDLabel";
            this.CrsIDLabel.Size = new System.Drawing.Size(149, 37);
            this.CrsIDLabel.TabIndex = 2;
            this.CrsIDLabel.Text = "Course ID";
            // 
            // SID
            // 
            this.SID.Location = new System.Drawing.Point(483, 256);
            this.SID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SID.Name = "SID";
            this.SID.Size = new System.Drawing.Size(421, 26);
            this.SID.TabIndex = 4;
            // 
            // CrsID
            // 
            this.CrsID.Location = new System.Drawing.Point(485, 334);
            this.CrsID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CrsID.Name = "CrsID";
            this.CrsID.Size = new System.Drawing.Size(419, 26);
            this.CrsID.TabIndex = 5;
            // 
            // Grade
            // 
            this.Grade.Location = new System.Drawing.Point(485, 408);
            this.Grade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(421, 26);
            this.Grade.TabIndex = 7;
            // 
            // GradeLabel
            // 
            this.GradeLabel.AutoSize = true;
            this.GradeLabel.Font = new System.Drawing.Font("Adobe Song Std L", 16F, System.Drawing.FontStyle.Italic);
            this.GradeLabel.Location = new System.Drawing.Point(279, 408);
            this.GradeLabel.Name = "GradeLabel";
            this.GradeLabel.Size = new System.Drawing.Size(94, 37);
            this.GradeLabel.TabIndex = 8;
            this.GradeLabel.Text = "Grade";
            // 
            // GradeErrorProvider
            // 
            this.GradeErrorProvider.ContainerControl = this;
            // 
            // SIDErrorProvider
            // 
            this.SIDErrorProvider.ContainerControl = this;
            // 
            // CrsIDErrorProvider
            // 
            this.CrsIDErrorProvider.ContainerControl = this;
            // 
            // SemesterErrorProvider
            // 
            this.SemesterErrorProvider.ContainerControl = this;
            // 
            // GoBack
            // 
            this.GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GoBack.Location = new System.Drawing.Point(31, 633);
            this.GoBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(201, 41);
            this.GoBack.TabIndex = 9;
            this.GoBack.Text = "GoBack";
            this.GoBack.UseVisualStyleBackColor = true;
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Song Std L", 26F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(472, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 60);
            this.label1.TabIndex = 10;
            this.label1.Text = "Add Grade";
            // 
            // AddGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1218, 713);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GoBack);
            this.Controls.Add(this.GradeLabel);
            this.Controls.Add(this.Grade);
            this.Controls.Add(this.CrsID);
            this.Controls.Add(this.SID);
            this.Controls.Add(this.CrsIDLabel);
            this.Controls.Add(this.SIDLabel);
            this.Controls.Add(this.AddButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddGrade";
            this.Text = "AddGrade";
            this.Load += new System.EventHandler(this.AddGrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GradeErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SIDErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrsIDErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SemesterErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNROLLINBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label SIDLabel;
        private System.Windows.Forms.Label CrsIDLabel;
        private System.Windows.Forms.TextBox SID;
        private System.Windows.Forms.TextBox CrsID;
        private System.Windows.Forms.TextBox Grade;
        private System.Windows.Forms.Label GradeLabel;
        private System.Windows.Forms.ErrorProvider GradeErrorProvider;
        private System.Windows.Forms.ErrorProvider SIDErrorProvider;
        private System.Windows.Forms.ErrorProvider CrsIDErrorProvider;
        private System.Windows.Forms.ErrorProvider SemesterErrorProvider;
        private System.Windows.Forms.Button GoBack;
        private CrsManagementDataSet crsManagementDataSet;
        private System.Windows.Forms.BindingSource eNROLLINBindingSource;
        private CrsManagementDataSetTableAdapters.ENROLL_INTableAdapter eNROLL_INTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}