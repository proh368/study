namespace Student_Exam
{
    partial class RegisterForm
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
            this.regLbl = new System.Windows.Forms.Label();
            this.loginTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.newLoginLbl = new System.Windows.Forms.Label();
            this.thinkPasswordLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // regLbl
            // 
            this.regLbl.AutoSize = true;
            this.regLbl.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regLbl.Location = new System.Drawing.Point(52, 9);
            this.regLbl.Name = "regLbl";
            this.regLbl.Size = new System.Drawing.Size(278, 59);
            this.regLbl.TabIndex = 7;
            this.regLbl.Text = "Регистрация";
            // 
            // loginTxt
            // 
            this.loginTxt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTxt.ForeColor = System.Drawing.Color.Black;
            this.loginTxt.Location = new System.Drawing.Point(93, 113);
            this.loginTxt.Name = "loginTxt";
            this.loginTxt.Size = new System.Drawing.Size(215, 31);
            this.loginTxt.TabIndex = 8;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTxt.Location = new System.Drawing.Point(93, 184);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(215, 31);
            this.passwordTxt.TabIndex = 9;
            // 
            // registerBtn
            // 
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerBtn.Location = new System.Drawing.Point(43, 229);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(298, 57);
            this.registerBtn.TabIndex = 10;
            this.registerBtn.Text = "Зарегистрироваться";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backBtn.Location = new System.Drawing.Point(85, 292);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(215, 57);
            this.backBtn.TabIndex = 11;
            this.backBtn.Text = "Вернуться";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // newLoginLbl
            // 
            this.newLoginLbl.AutoSize = true;
            this.newLoginLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newLoginLbl.Location = new System.Drawing.Point(89, 87);
            this.newLoginLbl.Name = "newLoginLbl";
            this.newLoginLbl.Size = new System.Drawing.Size(202, 23);
            this.newLoginLbl.TabIndex = 12;
            this.newLoginLbl.Text = "Придумайте свой логин";
            // 
            // thinkPasswordLbl
            // 
            this.thinkPasswordLbl.AutoSize = true;
            this.thinkPasswordLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thinkPasswordLbl.Location = new System.Drawing.Point(89, 158);
            this.thinkPasswordLbl.Name = "thinkPasswordLbl";
            this.thinkPasswordLbl.Size = new System.Drawing.Size(213, 23);
            this.thinkPasswordLbl.TabIndex = 13;
            this.thinkPasswordLbl.Text = "Придумайте свой пароль";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.thinkPasswordLbl);
            this.Controls.Add(this.newLoginLbl);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.loginTxt);
            this.Controls.Add(this.regLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Exam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label regLbl;
        private System.Windows.Forms.TextBox loginTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label newLoginLbl;
        private System.Windows.Forms.Label thinkPasswordLbl;
    }
}