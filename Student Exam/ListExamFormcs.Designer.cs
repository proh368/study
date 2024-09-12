namespace Student_Exam
{
    partial class ListExamForm
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
            this.listExamsData = new System.Windows.Forms.DataGridView();
            this.backBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.zapros8Btn = new System.Windows.Forms.Button();
            this.avgLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listExamsData)).BeginInit();
            this.SuspendLayout();
            // 
            // listExamsData
            // 
            this.listExamsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listExamsData.Location = new System.Drawing.Point(12, 12);
            this.listExamsData.Name = "listExamsData";
            this.listExamsData.Size = new System.Drawing.Size(610, 315);
            this.listExamsData.TabIndex = 1;
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Calibri", 18F);
            this.backBtn.Location = new System.Drawing.Point(12, 356);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(183, 42);
            this.backBtn.TabIndex = 14;
            this.backBtn.Text = "Вернуться";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.SlateGray;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Font = new System.Drawing.Font("Calibri", 18F);
            this.refreshBtn.Location = new System.Drawing.Point(439, 356);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(183, 42);
            this.refreshBtn.TabIndex = 26;
            this.refreshBtn.Text = "Сбросить";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // zapros8Btn
            // 
            this.zapros8Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zapros8Btn.Font = new System.Drawing.Font("Calibri", 18F);
            this.zapros8Btn.Location = new System.Drawing.Point(225, 356);
            this.zapros8Btn.Name = "zapros8Btn";
            this.zapros8Btn.Size = new System.Drawing.Size(183, 42);
            this.zapros8Btn.TabIndex = 27;
            this.zapros8Btn.Text = "Выполнить";
            this.zapros8Btn.UseVisualStyleBackColor = true;
            this.zapros8Btn.Click += new System.EventHandler(this.zapros8Btn_Click);
            // 
            // avgLbl
            // 
            this.avgLbl.AutoSize = true;
            this.avgLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avgLbl.Location = new System.Drawing.Point(187, 330);
            this.avgLbl.Name = "avgLbl";
            this.avgLbl.Size = new System.Drawing.Size(262, 23);
            this.avgLbl.TabIndex = 28;
            this.avgLbl.Text = "Средняя оценка за дисциплину";
            // 
            // ListExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.avgLbl);
            this.Controls.Add(this.zapros8Btn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.listExamsData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ListExamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Exam";
            ((System.ComponentModel.ISupportInitialize)(this.listExamsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listExamsData;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button zapros8Btn;
        private System.Windows.Forms.Label avgLbl;
    }
}