namespace Student_Exam
{
    partial class CopyListTeacherForm
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
            this.listExamenatorsData = new System.Windows.Forms.DataGridView();
            this.backBtn = new System.Windows.Forms.Button();
            this.zapros11Btn = new System.Windows.Forms.Button();
            this.oplataBoleeLbl = new System.Windows.Forms.Label();
            this.oplataBoleeTxt = new System.Windows.Forms.TextBox();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.zapros12Btn = new System.Windows.Forms.Button();
            this.oplataMeneeLbl = new System.Windows.Forms.Label();
            this.oplataMeneeTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.listExamenatorsData)).BeginInit();
            this.SuspendLayout();
            // 
            // listExamenatorsData
            // 
            this.listExamenatorsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listExamenatorsData.Location = new System.Drawing.Point(12, 12);
            this.listExamenatorsData.Name = "listExamenatorsData";
            this.listExamenatorsData.Size = new System.Drawing.Size(760, 326);
            this.listExamenatorsData.TabIndex = 16;
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Calibri", 18F);
            this.backBtn.Location = new System.Drawing.Point(12, 507);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(183, 42);
            this.backBtn.TabIndex = 17;
            this.backBtn.Text = "Вернуться";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // zapros11Btn
            // 
            this.zapros11Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zapros11Btn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zapros11Btn.Location = new System.Drawing.Point(12, 361);
            this.zapros11Btn.Name = "zapros11Btn";
            this.zapros11Btn.Size = new System.Drawing.Size(281, 42);
            this.zapros11Btn.TabIndex = 36;
            this.zapros11Btn.Text = "Удалить экзаменаторов";
            this.zapros11Btn.UseVisualStyleBackColor = true;
            this.zapros11Btn.Click += new System.EventHandler(this.zapros11Btn_Click);
            // 
            // oplataBoleeLbl
            // 
            this.oplataBoleeLbl.AutoSize = true;
            this.oplataBoleeLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oplataBoleeLbl.Location = new System.Drawing.Point(299, 344);
            this.oplataBoleeLbl.Name = "oplataBoleeLbl";
            this.oplataBoleeLbl.Size = new System.Drawing.Size(255, 23);
            this.oplataBoleeLbl.TabIndex = 39;
            this.oplataBoleeLbl.Text = "Размер оплаты которых более";
            // 
            // oplataBoleeTxt
            // 
            this.oplataBoleeTxt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oplataBoleeTxt.ForeColor = System.Drawing.Color.Black;
            this.oplataBoleeTxt.Location = new System.Drawing.Point(303, 370);
            this.oplataBoleeTxt.Name = "oplataBoleeTxt";
            this.oplataBoleeTxt.Size = new System.Drawing.Size(234, 31);
            this.oplataBoleeTxt.TabIndex = 38;
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.SlateGray;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Font = new System.Drawing.Font("Calibri", 18F);
            this.refreshBtn.Location = new System.Drawing.Point(589, 507);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(183, 42);
            this.refreshBtn.TabIndex = 42;
            this.refreshBtn.Text = "Сбросить";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // zapros12Btn
            // 
            this.zapros12Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zapros12Btn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zapros12Btn.Location = new System.Drawing.Point(12, 438);
            this.zapros12Btn.Name = "zapros12Btn";
            this.zapros12Btn.Size = new System.Drawing.Size(343, 42);
            this.zapros12Btn.TabIndex = 43;
            this.zapros12Btn.Text = "+10% к оплате экзаменаторам";
            this.zapros12Btn.UseVisualStyleBackColor = true;
            this.zapros12Btn.Click += new System.EventHandler(this.zapros12Btn_Click);
            // 
            // oplataMeneeLbl
            // 
            this.oplataMeneeLbl.AutoSize = true;
            this.oplataMeneeLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oplataMeneeLbl.Location = new System.Drawing.Point(357, 421);
            this.oplataMeneeLbl.Name = "oplataMeneeLbl";
            this.oplataMeneeLbl.Size = new System.Drawing.Size(257, 23);
            this.oplataMeneeLbl.TabIndex = 45;
            this.oplataMeneeLbl.Text = "Размер оплаты которых менее";
            // 
            // oplataMeneeTxt
            // 
            this.oplataMeneeTxt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oplataMeneeTxt.ForeColor = System.Drawing.Color.Black;
            this.oplataMeneeTxt.Location = new System.Drawing.Point(361, 447);
            this.oplataMeneeTxt.Name = "oplataMeneeTxt";
            this.oplataMeneeTxt.Size = new System.Drawing.Size(234, 31);
            this.oplataMeneeTxt.TabIndex = 44;
            // 
            // CopyListTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.oplataMeneeLbl);
            this.Controls.Add(this.oplataMeneeTxt);
            this.Controls.Add(this.zapros12Btn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.oplataBoleeLbl);
            this.Controls.Add(this.oplataBoleeTxt);
            this.Controls.Add(this.zapros11Btn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.listExamenatorsData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CopyListTeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Exam";
            ((System.ComponentModel.ISupportInitialize)(this.listExamenatorsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listExamenatorsData;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button zapros11Btn;
        private System.Windows.Forms.Label oplataBoleeLbl;
        private System.Windows.Forms.TextBox oplataBoleeTxt;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button zapros12Btn;
        private System.Windows.Forms.Label oplataMeneeLbl;
        private System.Windows.Forms.TextBox oplataMeneeTxt;
    }
}