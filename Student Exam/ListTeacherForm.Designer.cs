namespace Student_Exam
{
    partial class ListTeacherForm
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
            this.backBtn = new System.Windows.Forms.Button();
            this.listExamenatorsData = new System.Windows.Forms.DataGridView();
            this.oplataLbl = new System.Windows.Forms.Label();
            this.endLbl = new System.Windows.Forms.Label();
            this.startLbl = new System.Windows.Forms.Label();
            this.endTxt = new System.Windows.Forms.TextBox();
            this.startTxt = new System.Windows.Forms.TextBox();
            this.zapros2Btn = new System.Windows.Forms.Button();
            this.zapros4Btn = new System.Windows.Forms.Button();
            this.searchLbl = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.zarplataLbl = new System.Windows.Forms.Label();
            this.zapros6Btn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listExamenatorsData)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Calibri", 18F);
            this.backBtn.Location = new System.Drawing.Point(12, 507);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(183, 42);
            this.backBtn.TabIndex = 14;
            this.backBtn.Text = "Вернуться";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // listExamenatorsData
            // 
            this.listExamenatorsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listExamenatorsData.Location = new System.Drawing.Point(12, 12);
            this.listExamenatorsData.Name = "listExamenatorsData";
            this.listExamenatorsData.Size = new System.Drawing.Size(760, 326);
            this.listExamenatorsData.TabIndex = 15;
            // 
            // oplataLbl
            // 
            this.oplataLbl.AutoSize = true;
            this.oplataLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oplataLbl.Location = new System.Drawing.Point(345, 339);
            this.oplataLbl.Name = "oplataLbl";
            this.oplataLbl.Size = new System.Drawing.Size(132, 23);
            this.oplataLbl.TabIndex = 24;
            this.oplataLbl.Text = "Размер оплаты";
            // 
            // endLbl
            // 
            this.endLbl.AutoSize = true;
            this.endLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endLbl.Location = new System.Drawing.Point(407, 366);
            this.endLbl.Name = "endLbl";
            this.endLbl.Size = new System.Drawing.Size(32, 23);
            this.endLbl.TabIndex = 34;
            this.endLbl.Text = "До";
            // 
            // startLbl
            // 
            this.startLbl.AutoSize = true;
            this.startLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startLbl.Location = new System.Drawing.Point(256, 366);
            this.startLbl.Name = "startLbl";
            this.startLbl.Size = new System.Drawing.Size(30, 23);
            this.startLbl.TabIndex = 33;
            this.startLbl.Text = "От";
            // 
            // endTxt
            // 
            this.endTxt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endTxt.ForeColor = System.Drawing.Color.Black;
            this.endTxt.Location = new System.Drawing.Point(445, 363);
            this.endTxt.Name = "endTxt";
            this.endTxt.Size = new System.Drawing.Size(106, 31);
            this.endTxt.TabIndex = 32;
            // 
            // startTxt
            // 
            this.startTxt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startTxt.ForeColor = System.Drawing.Color.Black;
            this.startTxt.Location = new System.Drawing.Point(292, 363);
            this.startTxt.Name = "startTxt";
            this.startTxt.Size = new System.Drawing.Size(109, 31);
            this.startTxt.TabIndex = 31;
            // 
            // zapros2Btn
            // 
            this.zapros2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zapros2Btn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zapros2Btn.Location = new System.Drawing.Point(292, 400);
            this.zapros2Btn.Name = "zapros2Btn";
            this.zapros2Btn.Size = new System.Drawing.Size(241, 42);
            this.zapros2Btn.TabIndex = 35;
            this.zapros2Btn.Text = "По размеру оплаты";
            this.zapros2Btn.UseVisualStyleBackColor = true;
            this.zapros2Btn.Click += new System.EventHandler(this.zapros2Btn_Click);
            // 
            // zapros4Btn
            // 
            this.zapros4Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zapros4Btn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zapros4Btn.Location = new System.Drawing.Point(12, 400);
            this.zapros4Btn.Name = "zapros4Btn";
            this.zapros4Btn.Size = new System.Drawing.Size(234, 42);
            this.zapros4Btn.TabIndex = 38;
            this.zapros4Btn.Text = "Найти экзаменатора";
            this.zapros4Btn.UseVisualStyleBackColor = true;
            this.zapros4Btn.Click += new System.EventHandler(this.zapros4Btn_Click);
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchLbl.Location = new System.Drawing.Point(12, 339);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(199, 23);
            this.searchLbl.TabIndex = 37;
            this.searchLbl.Text = "Фамилия экзаменатора";
            // 
            // searchTxt
            // 
            this.searchTxt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTxt.ForeColor = System.Drawing.Color.Black;
            this.searchTxt.Location = new System.Drawing.Point(12, 363);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(234, 31);
            this.searchTxt.TabIndex = 36;
            // 
            // zarplataLbl
            // 
            this.zarplataLbl.AutoSize = true;
            this.zarplataLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zarplataLbl.Location = new System.Drawing.Point(564, 351);
            this.zarplataLbl.Name = "zarplataLbl";
            this.zarplataLbl.Size = new System.Drawing.Size(208, 46);
            this.zarplataLbl.TabIndex = 39;
            this.zarplataLbl.Text = "Зарплата экзаменаторов\r\n             (с налогом)";
            // 
            // zapros6Btn
            // 
            this.zapros6Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zapros6Btn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zapros6Btn.Location = new System.Drawing.Point(568, 400);
            this.zapros6Btn.Name = "zapros6Btn";
            this.zapros6Btn.Size = new System.Drawing.Size(204, 42);
            this.zapros6Btn.TabIndex = 40;
            this.zapros6Btn.Text = "Вычислить";
            this.zapros6Btn.UseVisualStyleBackColor = true;
            this.zapros6Btn.Click += new System.EventHandler(this.zapros6Btn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.SlateGray;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Font = new System.Drawing.Font("Calibri", 18F);
            this.refreshBtn.Location = new System.Drawing.Point(589, 507);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(183, 42);
            this.refreshBtn.TabIndex = 41;
            this.refreshBtn.Text = "Сбросить";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // ListTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.zapros6Btn);
            this.Controls.Add(this.zarplataLbl);
            this.Controls.Add(this.zapros4Btn);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.zapros2Btn);
            this.Controls.Add(this.endLbl);
            this.Controls.Add(this.startLbl);
            this.Controls.Add(this.endTxt);
            this.Controls.Add(this.startTxt);
            this.Controls.Add(this.oplataLbl);
            this.Controls.Add(this.listExamenatorsData);
            this.Controls.Add(this.backBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ListTeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Exam";
            ((System.ComponentModel.ISupportInitialize)(this.listExamenatorsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataGridView listExamenatorsData;
        private System.Windows.Forms.Label oplataLbl;
        private System.Windows.Forms.Label endLbl;
        private System.Windows.Forms.Label startLbl;
        private System.Windows.Forms.TextBox endTxt;
        private System.Windows.Forms.TextBox startTxt;
        private System.Windows.Forms.Button zapros2Btn;
        private System.Windows.Forms.Button zapros4Btn;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Label zarplataLbl;
        private System.Windows.Forms.Button zapros6Btn;
        private System.Windows.Forms.Button refreshBtn;
    }
}