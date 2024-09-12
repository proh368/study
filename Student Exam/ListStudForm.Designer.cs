namespace Student_Exam
{
    partial class ListStudForm
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
            this.listStudentsData = new System.Windows.Forms.DataGridView();
            this.backBtn = new System.Windows.Forms.Button();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.zapros1Btn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.zapros3Btn = new System.Windows.Forms.Button();
            this.startTxt = new System.Windows.Forms.TextBox();
            this.endTxt = new System.Windows.Forms.TextBox();
            this.startLbl = new System.Windows.Forms.Label();
            this.endLbl = new System.Windows.Forms.Label();
            this.zapros5Btn = new System.Windows.Forms.Button();
            this.secondDateLbl = new System.Windows.Forms.Label();
            this.firstDateLbl = new System.Windows.Forms.Label();
            this.secondDateTxt = new System.Windows.Forms.TextBox();
            this.firstDateTxt = new System.Windows.Forms.TextBox();
            this.zapros7Lbl = new System.Windows.Forms.Label();
            this.zapros7Btn = new System.Windows.Forms.Button();
            this.godRozhLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listStudentsData)).BeginInit();
            this.SuspendLayout();
            // 
            // listStudentsData
            // 
            this.listStudentsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listStudentsData.Location = new System.Drawing.Point(12, 12);
            this.listStudentsData.Name = "listStudentsData";
            this.listStudentsData.Size = new System.Drawing.Size(760, 326);
            this.listStudentsData.TabIndex = 0;
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Calibri", 18F);
            this.backBtn.Location = new System.Drawing.Point(12, 507);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(183, 42);
            this.backBtn.TabIndex = 13;
            this.backBtn.Text = "Вернуться";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // searchTxt
            // 
            this.searchTxt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTxt.ForeColor = System.Drawing.Color.Black;
            this.searchTxt.Location = new System.Drawing.Point(12, 365);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(220, 31);
            this.searchTxt.TabIndex = 22;
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchLbl.Location = new System.Drawing.Point(12, 341);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(188, 23);
            this.searchLbl.TabIndex = 23;
            this.searchLbl.Text = "Фамилия абитуриента";
            // 
            // zapros1Btn
            // 
            this.zapros1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zapros1Btn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zapros1Btn.Location = new System.Drawing.Point(12, 402);
            this.zapros1Btn.Name = "zapros1Btn";
            this.zapros1Btn.Size = new System.Drawing.Size(220, 42);
            this.zapros1Btn.TabIndex = 24;
            this.zapros1Btn.Text = "Найти абитуриента";
            this.zapros1Btn.UseVisualStyleBackColor = true;
            this.zapros1Btn.Click += new System.EventHandler(this.zapros1Btn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.SlateGray;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Font = new System.Drawing.Font("Calibri", 18F);
            this.refreshBtn.Location = new System.Drawing.Point(589, 507);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(183, 42);
            this.refreshBtn.TabIndex = 25;
            this.refreshBtn.Text = "Сбросить";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // zapros3Btn
            // 
            this.zapros3Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zapros3Btn.Font = new System.Drawing.Font("Calibri", 18F);
            this.zapros3Btn.Location = new System.Drawing.Point(288, 402);
            this.zapros3Btn.Name = "zapros3Btn";
            this.zapros3Btn.Size = new System.Drawing.Size(215, 42);
            this.zapros3Btn.TabIndex = 26;
            this.zapros3Btn.Text = "По году рождения";
            this.zapros3Btn.UseVisualStyleBackColor = true;
            this.zapros3Btn.Click += new System.EventHandler(this.zapros3Btn_Click);
            // 
            // startTxt
            // 
            this.startTxt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startTxt.ForeColor = System.Drawing.Color.Black;
            this.startTxt.Location = new System.Drawing.Point(278, 364);
            this.startTxt.Name = "startTxt";
            this.startTxt.Size = new System.Drawing.Size(109, 31);
            this.startTxt.TabIndex = 27;
            // 
            // endTxt
            // 
            this.endTxt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endTxt.ForeColor = System.Drawing.Color.Black;
            this.endTxt.Location = new System.Drawing.Point(431, 364);
            this.endTxt.Name = "endTxt";
            this.endTxt.Size = new System.Drawing.Size(106, 31);
            this.endTxt.TabIndex = 28;
            // 
            // startLbl
            // 
            this.startLbl.AutoSize = true;
            this.startLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startLbl.Location = new System.Drawing.Point(256, 367);
            this.startLbl.Name = "startLbl";
            this.startLbl.Size = new System.Drawing.Size(20, 23);
            this.startLbl.TabIndex = 29;
            this.startLbl.Text = "С";
            // 
            // endLbl
            // 
            this.endLbl.AutoSize = true;
            this.endLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endLbl.Location = new System.Drawing.Point(393, 367);
            this.endLbl.Name = "endLbl";
            this.endLbl.Size = new System.Drawing.Size(32, 23);
            this.endLbl.TabIndex = 30;
            this.endLbl.Text = "До";
            // 
            // zapros5Btn
            // 
            this.zapros5Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zapros5Btn.Font = new System.Drawing.Font("Calibri", 18F);
            this.zapros5Btn.Location = new System.Drawing.Point(301, 507);
            this.zapros5Btn.Name = "zapros5Btn";
            this.zapros5Btn.Size = new System.Drawing.Size(183, 42);
            this.zapros5Btn.TabIndex = 31;
            this.zapros5Btn.Text = "По дате сдачи";
            this.zapros5Btn.UseVisualStyleBackColor = true;
            this.zapros5Btn.Click += new System.EventHandler(this.zapros5Btn_Click);
            // 
            // secondDateLbl
            // 
            this.secondDateLbl.AutoSize = true;
            this.secondDateLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondDateLbl.Location = new System.Drawing.Point(393, 473);
            this.secondDateLbl.Name = "secondDateLbl";
            this.secondDateLbl.Size = new System.Drawing.Size(32, 23);
            this.secondDateLbl.TabIndex = 35;
            this.secondDateLbl.Text = "До";
            // 
            // firstDateLbl
            // 
            this.firstDateLbl.AutoSize = true;
            this.firstDateLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstDateLbl.Location = new System.Drawing.Point(252, 473);
            this.firstDateLbl.Name = "firstDateLbl";
            this.firstDateLbl.Size = new System.Drawing.Size(20, 23);
            this.firstDateLbl.TabIndex = 34;
            this.firstDateLbl.Text = "С";
            // 
            // secondDateTxt
            // 
            this.secondDateTxt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondDateTxt.ForeColor = System.Drawing.Color.Black;
            this.secondDateTxt.Location = new System.Drawing.Point(431, 470);
            this.secondDateTxt.Name = "secondDateTxt";
            this.secondDateTxt.Size = new System.Drawing.Size(106, 31);
            this.secondDateTxt.TabIndex = 33;
            // 
            // firstDateTxt
            // 
            this.firstDateTxt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstDateTxt.ForeColor = System.Drawing.Color.Black;
            this.firstDateTxt.Location = new System.Drawing.Point(278, 470);
            this.firstDateTxt.Name = "firstDateTxt";
            this.firstDateTxt.Size = new System.Drawing.Size(109, 31);
            this.firstDateTxt.TabIndex = 32;
            // 
            // zapros7Lbl
            // 
            this.zapros7Lbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zapros7Lbl.Location = new System.Drawing.Point(589, 341);
            this.zapros7Lbl.Name = "zapros7Lbl";
            this.zapros7Lbl.Size = new System.Drawing.Size(183, 96);
            this.zapros7Lbl.TabIndex = 36;
            this.zapros7Lbl.Text = "Количество абитуриентов, родившихся в определенный год";
            // 
            // zapros7Btn
            // 
            this.zapros7Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zapros7Btn.Font = new System.Drawing.Font("Calibri", 18F);
            this.zapros7Btn.Location = new System.Drawing.Point(589, 434);
            this.zapros7Btn.Name = "zapros7Btn";
            this.zapros7Btn.Size = new System.Drawing.Size(183, 42);
            this.zapros7Btn.TabIndex = 37;
            this.zapros7Btn.Text = "Выполнить";
            this.zapros7Btn.UseVisualStyleBackColor = true;
            this.zapros7Btn.Click += new System.EventHandler(this.zapros7Btn_Click);
            // 
            // godRozhLbl
            // 
            this.godRozhLbl.AutoSize = true;
            this.godRozhLbl.BackColor = System.Drawing.Color.DarkCyan;
            this.godRozhLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.godRozhLbl.Location = new System.Drawing.Point(343, 339);
            this.godRozhLbl.Name = "godRozhLbl";
            this.godRozhLbl.Size = new System.Drawing.Size(122, 23);
            this.godRozhLbl.TabIndex = 38;
            this.godRozhLbl.Text = "Год рождения";
            // 
            // ListStudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.godRozhLbl);
            this.Controls.Add(this.zapros7Btn);
            this.Controls.Add(this.zapros7Lbl);
            this.Controls.Add(this.secondDateLbl);
            this.Controls.Add(this.firstDateLbl);
            this.Controls.Add(this.secondDateTxt);
            this.Controls.Add(this.firstDateTxt);
            this.Controls.Add(this.zapros5Btn);
            this.Controls.Add(this.endLbl);
            this.Controls.Add(this.startLbl);
            this.Controls.Add(this.endTxt);
            this.Controls.Add(this.startTxt);
            this.Controls.Add(this.zapros3Btn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.zapros1Btn);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.listStudentsData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ListStudForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Exam";
            ((System.ComponentModel.ISupportInitialize)(this.listStudentsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listStudentsData;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Button zapros1Btn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button zapros3Btn;
        private System.Windows.Forms.TextBox startTxt;
        private System.Windows.Forms.TextBox endTxt;
        private System.Windows.Forms.Label startLbl;
        private System.Windows.Forms.Label endLbl;
        private System.Windows.Forms.Button zapros5Btn;
        private System.Windows.Forms.Label secondDateLbl;
        private System.Windows.Forms.Label firstDateLbl;
        private System.Windows.Forms.TextBox secondDateTxt;
        private System.Windows.Forms.TextBox firstDateTxt;
        private System.Windows.Forms.Label zapros7Lbl;
        private System.Windows.Forms.Button zapros7Btn;
        private System.Windows.Forms.Label godRozhLbl;
    }
}