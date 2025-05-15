namespace Course_Managment
{
    partial class Login
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
            this.emailEntry = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordEntry = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.emailErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.passwordErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.invalidCredsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // emailEntry
            // 
            this.emailEntry.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailEntry.Location = new System.Drawing.Point(85, 100);
            this.emailEntry.MaxLength = 200;
            this.emailEntry.Name = "emailEntry";
            this.emailEntry.Size = new System.Drawing.Size(230, 30);
            this.emailEntry.TabIndex = 0;
            this.emailEntry.WordWrap = false;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(157, 45);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(86, 31);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "Email";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(129, 150);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(142, 31);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // passwordEntry
            // 
            this.passwordEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordEntry.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordEntry.Location = new System.Drawing.Point(85, 200);
            this.passwordEntry.MaxLength = 200;
            this.passwordEntry.Name = "passwordEntry";
            this.passwordEntry.PasswordChar = '*';
            this.passwordEntry.Size = new System.Drawing.Size(230, 30);
            this.passwordEntry.TabIndex = 3;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(85, 290);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(230, 50);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // emailErrorProvider
            // 
            this.emailErrorProvider.ContainerControl = this;
            // 
            // passwordErrorProvider
            // 
            this.passwordErrorProvider.ContainerControl = this;
            // 
            // invalidCredsLabel
            // 
            this.invalidCredsLabel.AutoSize = true;
            this.invalidCredsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidCredsLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidCredsLabel.Location = new System.Drawing.Point(89, 354);
            this.invalidCredsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.invalidCredsLabel.Name = "invalidCredsLabel";
            this.invalidCredsLabel.Size = new System.Drawing.Size(0, 20);
            this.invalidCredsLabel.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(382, 393);
            this.Controls.Add(this.invalidCredsLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordEntry);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailEntry);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailEntry;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordEntry;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.ErrorProvider emailErrorProvider;
        private System.Windows.Forms.ErrorProvider passwordErrorProvider;
        private System.Windows.Forms.Label invalidCredsLabel;
    }
}

