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
            this.SemesterLabel = new System.Windows.Forms.Label();
            this.SID = new System.Windows.Forms.TextBox();
            this.CrsID = new System.Windows.Forms.TextBox();
            this.Semester = new System.Windows.Forms.TextBox();
            this.Grade = new System.Windows.Forms.TextBox();
            this.GradeLabel = new System.Windows.Forms.Label();
            this.GradeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SIDErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CrsIDErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SemesterErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GradeErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SIDErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrsIDErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SemesterErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(554, 82);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(174, 54);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add Grade";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SIDLabel
            // 
            this.SIDLabel.AutoSize = true;
            this.SIDLabel.Location = new System.Drawing.Point(30, 55);
            this.SIDLabel.Name = "SIDLabel";
            this.SIDLabel.Size = new System.Drawing.Size(68, 16);
            this.SIDLabel.TabIndex = 1;
            this.SIDLabel.Text = "Student ID";
            // 
            // CrsIDLabel
            // 
            this.CrsIDLabel.AutoSize = true;
            this.CrsIDLabel.Location = new System.Drawing.Point(32, 145);
            this.CrsIDLabel.Name = "CrsIDLabel";
            this.CrsIDLabel.Size = new System.Drawing.Size(66, 16);
            this.CrsIDLabel.TabIndex = 2;
            this.CrsIDLabel.Text = "Course ID";
            // 
            // SemesterLabel
            // 
            this.SemesterLabel.AutoSize = true;
            this.SemesterLabel.Location = new System.Drawing.Point(30, 230);
            this.SemesterLabel.Name = "SemesterLabel";
            this.SemesterLabel.Size = new System.Drawing.Size(65, 16);
            this.SemesterLabel.TabIndex = 3;
            this.SemesterLabel.Text = "Semester";
            // 
            // SID
            // 
            this.SID.Location = new System.Drawing.Point(33, 98);
            this.SID.Name = "SID";
            this.SID.Size = new System.Drawing.Size(165, 22);
            this.SID.TabIndex = 4;
            // 
            // CrsID
            // 
            this.CrsID.Location = new System.Drawing.Point(35, 181);
            this.CrsID.Name = "CrsID";
            this.CrsID.Size = new System.Drawing.Size(163, 22);
            this.CrsID.TabIndex = 5;
            // 
            // Semester
            // 
            this.Semester.Location = new System.Drawing.Point(33, 262);
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(165, 22);
            this.Semester.TabIndex = 6;
            // 
            // Grade
            // 
            this.Grade.Location = new System.Drawing.Point(264, 98);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(165, 22);
            this.Grade.TabIndex = 7;
            // 
            // GradeLabel
            // 
            this.GradeLabel.AutoSize = true;
            this.GradeLabel.Location = new System.Drawing.Point(261, 55);
            this.GradeLabel.Name = "GradeLabel";
            this.GradeLabel.Size = new System.Drawing.Size(45, 16);
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
            // AddGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GradeLabel);
            this.Controls.Add(this.Grade);
            this.Controls.Add(this.Semester);
            this.Controls.Add(this.CrsID);
            this.Controls.Add(this.SID);
            this.Controls.Add(this.SemesterLabel);
            this.Controls.Add(this.CrsIDLabel);
            this.Controls.Add(this.SIDLabel);
            this.Controls.Add(this.AddButton);
            this.Name = "AddGrade";
            this.Text = "AddGrade";
            this.Load += new System.EventHandler(this.AddGrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GradeErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SIDErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrsIDErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SemesterErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label SIDLabel;
        private System.Windows.Forms.Label CrsIDLabel;
        private System.Windows.Forms.Label SemesterLabel;
        private System.Windows.Forms.TextBox SID;
        private System.Windows.Forms.TextBox CrsID;
        private System.Windows.Forms.TextBox Semester;
        private System.Windows.Forms.TextBox Grade;
        private System.Windows.Forms.Label GradeLabel;
        private System.Windows.Forms.ErrorProvider GradeErrorProvider;
        private System.Windows.Forms.ErrorProvider SIDErrorProvider;
        private System.Windows.Forms.ErrorProvider CrsIDErrorProvider;
        private System.Windows.Forms.ErrorProvider SemesterErrorProvider;
    }
}