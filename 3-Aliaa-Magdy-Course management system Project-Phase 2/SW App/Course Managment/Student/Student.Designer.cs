namespace Course_Managment.Student
{
    partial class Student
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
            this.ADDENROLL = new System.Windows.Forms.Button();
            this.DELENROLL = new System.Windows.Forms.Button();
            this.UPDSTUD = new System.Windows.Forms.Button();
            this.shwcrs = new System.Windows.Forms.Button();
            this.Welcome = new System.Windows.Forms.Label();
            this.LogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ADDENROLL
            // 
            this.ADDENROLL.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDENROLL.Location = new System.Drawing.Point(162, 164);
            this.ADDENROLL.Name = "ADDENROLL";
            this.ADDENROLL.Size = new System.Drawing.Size(212, 40);
            this.ADDENROLL.TabIndex = 0;
            this.ADDENROLL.Text = "Add Enrollment";
            this.ADDENROLL.UseVisualStyleBackColor = true;
            this.ADDENROLL.Click += new System.EventHandler(this.ADDENROLL_Click);
            // 
            // DELENROLL
            // 
            this.DELENROLL.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELENROLL.Location = new System.Drawing.Point(446, 164);
            this.DELENROLL.Name = "DELENROLL";
            this.DELENROLL.Size = new System.Drawing.Size(212, 40);
            this.DELENROLL.TabIndex = 1;
            this.DELENROLL.Text = "Delete Enrollment";
            this.DELENROLL.UseVisualStyleBackColor = true;
            this.DELENROLL.Click += new System.EventHandler(this.DELENROLL_Click);
            // 
            // UPDSTUD
            // 
            this.UPDSTUD.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDSTUD.Location = new System.Drawing.Point(162, 256);
            this.UPDSTUD.Name = "UPDSTUD";
            this.UPDSTUD.Size = new System.Drawing.Size(212, 36);
            this.UPDSTUD.TabIndex = 3;
            this.UPDSTUD.Text = "Update Student Info";
            this.UPDSTUD.UseVisualStyleBackColor = true;
            this.UPDSTUD.Click += new System.EventHandler(this.UPDSTUD_Click);
            // 
            // shwcrs
            // 
            this.shwcrs.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shwcrs.Location = new System.Drawing.Point(446, 256);
            this.shwcrs.Name = "shwcrs";
            this.shwcrs.Size = new System.Drawing.Size(212, 36);
            this.shwcrs.TabIndex = 4;
            this.shwcrs.Text = "Show Crs";
            this.shwcrs.UseVisualStyleBackColor = true;
            this.shwcrs.Click += new System.EventHandler(this.shwcrs_Click);
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(276, 37);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(237, 34);
            this.Welcome.TabIndex = 5;
            this.Welcome.Text = "STUDENT DASHBOARD";
            // 
            // LogOut
            // 
            this.LogOut.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.ForeColor = System.Drawing.Color.Red;
            this.LogOut.Location = new System.Drawing.Point(686, 12);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(102, 31);
            this.LogOut.TabIndex = 6;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.shwcrs);
            this.Controls.Add(this.UPDSTUD);
            this.Controls.Add(this.DELENROLL);
            this.Controls.Add(this.ADDENROLL);
            this.Name = "Student";
            this.Text = "Stud";
            this.Load += new System.EventHandler(this.Student_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ADDENROLL;
        private System.Windows.Forms.Button DELENROLL;
        private System.Windows.Forms.Button UPDSTUD;
        private System.Windows.Forms.Button shwcrs;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Button LogOut;
    }
}