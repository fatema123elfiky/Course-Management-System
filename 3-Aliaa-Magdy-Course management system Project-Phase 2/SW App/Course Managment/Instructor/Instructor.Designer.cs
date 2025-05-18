namespace Course_Managment.Instructor
{
    partial class instructorFrom
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
            this.addInstBtn = new System.Windows.Forms.Button();
            this.addStudBtn = new System.Windows.Forms.Button();
            this.Welcome = new System.Windows.Forms.Label();
            this.showcrs = new System.Windows.Forms.Button();
            this.showstud = new System.Windows.Forms.Button();
            this.addCrs = new System.Windows.Forms.Button();
            this.delCrs = new System.Windows.Forms.Button();
            this.UpdCrs = new System.Windows.Forms.Button();
            this.UpdInstruc = new System.Windows.Forms.Button();
            this.addGrade = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addInstBtn
            // 
            this.addInstBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInstBtn.Location = new System.Drawing.Point(165, 134);
            this.addInstBtn.Name = "addInstBtn";
            this.addInstBtn.Size = new System.Drawing.Size(238, 41);
            this.addInstBtn.TabIndex = 0;
            this.addInstBtn.Text = "Add Instructor";
            this.addInstBtn.UseVisualStyleBackColor = true;
            this.addInstBtn.Click += new System.EventHandler(this.addInstBtn_Click);
            // 
            // addStudBtn
            // 
            this.addStudBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudBtn.Location = new System.Drawing.Point(506, 134);
            this.addStudBtn.Name = "addStudBtn";
            this.addStudBtn.Size = new System.Drawing.Size(238, 42);
            this.addStudBtn.TabIndex = 1;
            this.addStudBtn.Text = "Add Student";
            this.addStudBtn.UseVisualStyleBackColor = true;
            this.addStudBtn.Click += new System.EventHandler(this.addStudBtn_Click);
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(346, 39);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(273, 34);
            this.Welcome.TabIndex = 2;
            this.Welcome.Text = "INSTRUCTOR DASHBOARD";
            // 
            // showcrs
            // 
            this.showcrs.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showcrs.Location = new System.Drawing.Point(165, 206);
            this.showcrs.Name = "showcrs";
            this.showcrs.Size = new System.Drawing.Size(238, 40);
            this.showcrs.TabIndex = 3;
            this.showcrs.Text = "Show Crs";
            this.showcrs.UseVisualStyleBackColor = true;
            this.showcrs.Click += new System.EventHandler(this.showcrs_Click);
            // 
            // showstud
            // 
            this.showstud.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showstud.Location = new System.Drawing.Point(506, 206);
            this.showstud.Name = "showstud";
            this.showstud.Size = new System.Drawing.Size(238, 40);
            this.showstud.TabIndex = 4;
            this.showstud.Text = "Show Students";
            this.showstud.UseVisualStyleBackColor = true;
            this.showstud.Click += new System.EventHandler(this.showstud_Click);
            // 
            // addCrs
            // 
            this.addCrs.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCrs.Location = new System.Drawing.Point(165, 290);
            this.addCrs.Name = "addCrs";
            this.addCrs.Size = new System.Drawing.Size(238, 42);
            this.addCrs.TabIndex = 7;
            this.addCrs.Text = "Add Crs";
            this.addCrs.UseVisualStyleBackColor = true;
            this.addCrs.Click += new System.EventHandler(this.addCrs_Click);
            // 
            // delCrs
            // 
            this.delCrs.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delCrs.Location = new System.Drawing.Point(165, 369);
            this.delCrs.Name = "delCrs";
            this.delCrs.Size = new System.Drawing.Size(238, 46);
            this.delCrs.TabIndex = 8;
            this.delCrs.Text = "Delete Crs";
            this.delCrs.UseVisualStyleBackColor = true;
            this.delCrs.Click += new System.EventHandler(this.delCrs_Click);
            // 
            // UpdCrs
            // 
            this.UpdCrs.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdCrs.Location = new System.Drawing.Point(506, 290);
            this.UpdCrs.Name = "UpdCrs";
            this.UpdCrs.Size = new System.Drawing.Size(238, 42);
            this.UpdCrs.TabIndex = 9;
            this.UpdCrs.Text = "Update Crs";
            this.UpdCrs.UseVisualStyleBackColor = true;
            this.UpdCrs.Click += new System.EventHandler(this.UpdCrs_Click);
            // 
            // UpdInstruc
            // 
            this.UpdInstruc.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdInstruc.Location = new System.Drawing.Point(506, 369);
            this.UpdInstruc.Name = "UpdInstruc";
            this.UpdInstruc.Size = new System.Drawing.Size(238, 46);
            this.UpdInstruc.TabIndex = 10;
            this.UpdInstruc.Text = "Update Instrcutor";
            this.UpdInstruc.UseVisualStyleBackColor = true;
            this.UpdInstruc.Click += new System.EventHandler(this.UpdInstruc_Click);
            // 
            // addGrade
            // 
            this.addGrade.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGrade.Location = new System.Drawing.Point(331, 464);
            this.addGrade.Name = "addGrade";
            this.addGrade.Size = new System.Drawing.Size(238, 45);
            this.addGrade.TabIndex = 11;
            this.addGrade.Text = "Add Grade";
            this.addGrade.UseVisualStyleBackColor = true;
            this.addGrade.Click += new System.EventHandler(this.addGrade_Click);
            // 
            // LogOut
            // 
            this.LogOut.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.ForeColor = System.Drawing.Color.Red;
            this.LogOut.Location = new System.Drawing.Point(789, 12);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(124, 40);
            this.LogOut.TabIndex = 12;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // instructorFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(925, 604);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.addGrade);
            this.Controls.Add(this.UpdInstruc);
            this.Controls.Add(this.UpdCrs);
            this.Controls.Add(this.delCrs);
            this.Controls.Add(this.addCrs);
            this.Controls.Add(this.showstud);
            this.Controls.Add(this.showcrs);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.addStudBtn);
            this.Controls.Add(this.addInstBtn);
            this.Name = "instructorFrom";
            this.Text = "Instructor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addInstBtn;
        private System.Windows.Forms.Button addStudBtn;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Button showcrs;
        private System.Windows.Forms.Button showstud;
        private System.Windows.Forms.Button addCrs;
        private System.Windows.Forms.Button delCrs;
        private System.Windows.Forms.Button UpdCrs;
        private System.Windows.Forms.Button UpdInstruc;
        private System.Windows.Forms.Button addGrade;
        private System.Windows.Forms.Button LogOut;
    }
}