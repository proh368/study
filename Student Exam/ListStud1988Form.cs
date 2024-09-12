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
    public partial class ListStud1988Form : Form
    {
        public ListStud1988Form()
        {
            InitializeComponent();
            DB.Open();
            listStud1988();
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
        public async void listStud1988()
        {
            SQLiteCommand copy = new SQLiteCommand(@"SELECT * FROM Abiturienty_1988", DB);
            copy.ExecuteNonQuery();
            SQLiteDataReader reader = copy.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            listStudents1988Data.DataSource = table;
        }
    }
}
