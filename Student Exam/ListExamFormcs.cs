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
    public partial class ListExamForm : Form
    {
        public ListExamForm()
        {
            InitializeComponent();
            DB.Open();
            ListExams();
        }
        public static SQLiteConnection DB = new SQLiteConnection(DataBase.connection);
        private void backBtn_Click(object sender, EventArgs e)
        {
            DB.Close();
            Application.Exit();
            var thread = new Thread(OpenMainForm);
            thread.Start();
        }
        public void OpenMainForm()
        {
            Application.Run(new MainForm());
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            listExamsData.DataSource = null;
            ListExams();
        }
        public async void ListExams()
        {
            SQLiteCommand copy = new SQLiteCommand(@"SELECT * FROM Exameny", DB);
            copy.ExecuteNonQuery();
            SQLiteDataReader reader = copy.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            listExamsData.DataSource = table;
        }

        private void zapros8Btn_Click(object sender, EventArgs e)
        {
            listExamsData.DataSource = null;
            SQLiteCommand date = new SQLiteCommand(@"
                SELECT Nazvanie_Examena, AVG(Otsenka) AS [Avg Otsenka]
                FROM Exameny
                GROUP BY Nazvanie_Examena", DB);
            date.ExecuteNonQuery();
            SQLiteDataReader reader = date.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            listExamsData.DataSource = table;
        }
    }
}
