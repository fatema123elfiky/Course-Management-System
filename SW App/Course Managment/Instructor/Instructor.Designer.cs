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
            this.SuspendLayout();
            // 
            // addInstBtn
            // 
            this.addInstBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInstBtn.Location = new System.Drawing.Point(55, 47);
            this.addInstBtn.Name = "addInstBtn";
            this.addInstBtn.Size = new System.Drawing.Size(137, 64);
            this.addInstBtn.TabIndex = 0;
            this.addInstBtn.Text = "Add Instructor";
            this.addInstBtn.UseVisualStyleBackColor = true;
            this.addInstBtn.Click += new System.EventHandler(this.addInstBtn_Click);
            // 
            // instructorFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1113, 604);
            this.Controls.Add(this.addInstBtn);
            this.Name = "instructorFrom";
            this.Text = "Instructor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addInstBtn;
    }
}