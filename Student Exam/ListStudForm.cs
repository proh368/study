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
    public partial class ListStudForm : Form
    {
        public ListStudForm()
        {
            InitializeComponent();
            DB.Open();
            ListStudents();
        }
        public static SQLiteConnection DB = new SQLiteConnection(DataBase.connection);
        public async void ListStudents()
        {
            SQLiteCommand copy = new SQLiteCommand(@"SELECT * FROM Abiturienty", DB);
            copy.ExecuteNonQuery();
            SQLiteDataReader reader = copy.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            listStudentsData.DataSource = table;
        }

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
            listStudentsData.DataSource = null;
            ListStudents();
            searchTxt.Text = "";
            startTxt.Text = "";
            endTxt.Text = "";
            firstDateTxt.Text = "";
            secondDateTxt.Text = "";
        }

        private void zapros1Btn_Click(object sender, EventArgs e)
        {
            if (searchTxt.Text != "")
            {
                listStudentsData.DataSource = null;
                SQLiteCommand search = new SQLiteCommand($@"
                    SELECT *                
                    FROM Abiturienty 
                    WHERE Familiya LIKE '{searchTxt.Text}%'", DB);
                search.ExecuteNonQuery();
                SQLiteDataReader reader = search.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                listStudentsData.DataSource = table;
            }
            else
            {
                MessageBox.Show("Для начала заполните строку поиска (находящейся над кнопкой)");
            }
        }

        private void zapros3Btn_Click(object sender, EventArgs e)
        {
            if (startTxt.Text != "" && endTxt.Text != "")
            {
                listStudentsData.DataSource = null;
                SQLiteCommand godrozh = new SQLiteCommand($@"
                    SELECT *
                    FROM Abiturienty
                    WHERE God_Rozhdenia >= '{startTxt.Text}' AND God_Rozhdenia <= '{endTxt.Text}'", DB);
                godrozh.ExecuteNonQuery();
                SQLiteDataReader reader = godrozh.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                listStudentsData.DataSource = table;
            }
            else
            {
                MessageBox.Show("Вы не все строки заполнили");
            }
        }

        private void zapros5Btn_Click(object sender, EventArgs e)
        {
            if (firstDateTxt.Text != "" && secondDateTxt.Text != "")
            {
                listStudentsData.DataSource = null;
                SQLiteCommand date = new SQLiteCommand($@"
                    SELECT Abiturienty.Familiya, Abiturienty.Imya, Abiturienty.Otchestvo, Examenatory.Familiya_Exam, Examenatory.Imya_Exam, Examenatory.Otchestvo_Exam, Exameny.Nazvanie_Examena, Exameny.Data_Sdachi_Examena, Exameny.Otsenka
                    FROM Abiturienty
                    INNER JOIN Exameny ON Abiturienty.ID_Abiturienta = Exameny.ID_Abiturienta  
                    INNER JOIN Examenatory ON Exameny.ID_Examenatora = Examenatory.ID_Examenatora
                    WHERE Data_Sdachi_Examena >= '{firstDateTxt.Text}' AND Data_Sdachi_Examena <= '{secondDateTxt.Text}'", DB);
                date.ExecuteNonQuery();
                SQLiteDataReader reader = date.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                listStudentsData.DataSource = table;
            }
            else
            {
                MessageBox.Show("Вы не все строки заполнили");
            }
        }

        private void zapros7Btn_Click(object sender, EventArgs e)
        {
            listStudentsData.DataSource = null;
            SQLiteCommand date = new SQLiteCommand(@"
                SELECT Count(ID_Abiturienta) AS [Count], God_Rozhdenia
                FROM Abiturienty
                GROUP BY God_Rozhdenia", DB);
            date.ExecuteNonQuery();
            SQLiteDataReader reader = date.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            listStudentsData.DataSource = table;
        }
    }
}
