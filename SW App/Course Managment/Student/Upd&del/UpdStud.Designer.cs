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
            this.Welcome = new System.Windows.Forms.Label();
            this.StudIDText = new System.Windows.Forms.TextBox();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.StudentID = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.GoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(287, 40);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(246, 34);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "UPDATE STUDENT INFO";
            // 
            // StudIDText
            // 
            this.StudIDText.Location = new System.Drawing.Point(182, 143);
            this.StudIDText.Name = "StudIDText";
            this.StudIDText.Size = new System.Drawing.Size(163, 22);
            this.StudIDText.TabIndex = 1;
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(518, 143);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(163, 22);
            this.EmailText.TabIndex = 2;
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(182, 192);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(163, 22);
            this.PasswordText.TabIndex = 3;
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(518, 192);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(163, 22);
            this.NameText.TabIndex = 4;
            // 
            // StudentID
            // 
            this.StudentID.AutoSize = true;
            this.StudentID.Location = new System.Drawing.Point(83, 143);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(65, 16);
            this.StudentID.TabIndex = 5;
            this.StudentID.Text = "StudentID";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(83, 195);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(67, 16);
            this.Password.TabIndex = 6;
            this.Password.Text = "Password";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(448, 198);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(44, 16);
            this.NameLbl.TabIndex = 7;
            this.NameLbl.Text = "Name";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(448, 146);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(41, 16);
            this.Email.TabIndex = 8;
            this.Email.Text = "Email";
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(281, 291);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 9;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // GoBack
            // 
            this.GoBack.Location = new System.Drawing.Point(438, 291);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(75, 23);
            this.GoBack.TabIndex = 10;
            this.GoBack.Text = "GoBack";
            this.GoBack.UseVisualStyleBackColor = true;
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // UpdStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GoBack);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.StudentID);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.StudIDText);
            this.Controls.Add(this.Welcome);
            this.Name = "UpdStud";
            this.Text = "UpdStud";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.TextBox StudIDText;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label StudentID;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button GoBack;
    }
}