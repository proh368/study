using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Exam
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DB.Open();
        }
        public static SQLiteConnection DB = new SQLiteConnection(DataBase.connection);
        private void listStudBtn_Click(object sender, EventArgs e)
        {
            DB.Close();
            Application.Exit();
            var thread = new Thread(OpenListStudForm);
            thread.Start();
        }
        public void OpenListStudForm()
        {
            Application.Run(new ListStudForm());
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DB.Close();
            Application.Exit();
            var thread = new Thread(OpenLoginForm);
            thread.Start();
        }
        public void OpenLoginForm()
        {
            Application.Run(new LoginForm());
        }

        private void listTeacherBtn_Click(object sender, EventArgs e)
        {
            DB.Close();
            Application.Exit();
            var thread = new Thread(OpenListTeacherForm);
            thread.Start();
        }
        public void OpenListTeacherForm()
        {
            Application.Run(new ListTeacherForm());
        }

        private void listExamBtn_Click(object sender, EventArgs e)
        {
            DB.Close();
            Application.Exit();
            var thread = new Thread(OpenListExamForm);
            thread.Start();
        }
        public void OpenListExamForm()
        {
            Application.Run(new ListExamForm());
        }

        private void zapros9Btn_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteCommand create = new SQLiteCommand(@"
                CREATE TABLE Abiturienty_1988 AS 
                SELECT * 
                FROM Abiturienty 
                WHERE God_Rozhdenia = 1988", DB);
                create.ExecuteNonQuery();
                MessageBox.Show("Таблица создана");
            }
            catch(Exception)
            {
                MessageBox.Show("Таблица уже была ранее создана");
            }
        }

        private void zapros10Btn_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteCommand create = new SQLiteCommand(@"
                CREATE TABLE Copy_Examenatory AS
                SELECT * 
                FROM Examenatory", DB);
                create.ExecuteNonQuery();
                MessageBox.Show("Таблица создана");
            }
            catch (Exception)
            {
                MessageBox.Show("Таблица уже была ранее создана");
            }
        }

        private void listStud1988Btn_Click(object sender, EventArgs e)
        {
            DB.Close();
            Application.Exit();
            var thread = new Thread(OpenListStud1988Form);
            thread.Start();
        }
        public void OpenListStud1988Form()
        {
            Application.Run(new ListStud1988Form());
        }

        private void listCopyTeacherBtn_Click(object sender, EventArgs e)
        {
            DB.Close();
            Application.Exit();
            var thread = new Thread(OpenCopyListTeacherForm);
            thread.Start();
        }
        public void OpenCopyListTeacherForm()
        {
            Application.Run(new CopyListTeacherForm());
        }
    }
}
