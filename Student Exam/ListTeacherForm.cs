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
    public partial class ListTeacherForm : Form
    {
        public ListTeacherForm()
        {
            InitializeComponent();
            DB.Open();
            ListExamenators();
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
        public async void ListExamenators()
        {
            SQLiteCommand copy = new SQLiteCommand(@"SELECT * FROM Examenatory", DB);
            copy.ExecuteNonQuery();
            SQLiteDataReader reader = copy.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            listExamenatorsData.DataSource = table;
        }

        private void zapros2Btn_Click(object sender, EventArgs e)
        {
            if (startTxt.Text != "" && endTxt.Text != "")
            {
                listExamenatorsData.DataSource = null;
                SQLiteCommand godrozh = new SQLiteCommand($@"
                    SELECT *
                    FROM Examenatory
                    WHERE Razmer_Oplaty >= {startTxt.Text} AND Razmer_Oplaty <= {endTxt.Text}", DB);
                godrozh.ExecuteNonQuery();
                SQLiteDataReader reader = godrozh.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                listExamenatorsData.DataSource = table;
            }
            else
            {
                MessageBox.Show("Вы не все строки заполнили");
            }
        }

        private void zapros4Btn_Click(object sender, EventArgs e)
        {
            if (searchTxt.Text != "")
            {
                listExamenatorsData.DataSource = null;
                SQLiteCommand search = new SQLiteCommand($@"
                    SELECT *                
                    FROM Examenatory 
                    WHERE Familiya_Exam LIKE '{searchTxt.Text}'", DB);
                search.ExecuteNonQuery();
                SQLiteDataReader reader = search.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                listExamenatorsData.DataSource = table;
            }
            else
            {
                MessageBox.Show("Для начала заполните строку поиска (находящейся над кнопкой)");
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            listExamenatorsData.DataSource = null;
            ListExamenators();
            searchTxt.Text = "";
            startTxt.Text = "";
            endTxt.Text = "";
        }

        private void zapros6Btn_Click(object sender, EventArgs e)
        {
            listExamenatorsData.DataSource = null;
            SQLiteCommand zarplata = new SQLiteCommand(@"
                    SELECT Familiya_Exam, Imya_Exam, Otchestvo_Exam, Razmer_Oplaty, Exameny.Data_Sdachi_Examena, Exameny.Nazvanie_Examena, Razmer_Oplaty * 0.13 AS Nalog, Razmer_Oplaty - (Razmer_Oplaty * 0.13) AS Zarplata
                    FROM Examenatory 
                    INNER JOIN Exameny ON Examenatory.ID_Examenatora = Exameny.ID_Examenatora", DB);
            zarplata.ExecuteNonQuery();
            SQLiteDataReader reader = zarplata.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            listExamenatorsData.DataSource = table;
        }
    }
}
