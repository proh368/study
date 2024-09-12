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
    public partial class CopyListTeacherForm : Form
    {
        public CopyListTeacherForm()
        {
            InitializeComponent();
            DB.Open();
            ListCopyExamenators();
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
        public async void ListCopyExamenators()
        {
            SQLiteCommand copy = new SQLiteCommand(@"SELECT * FROM Copy_Examenatory", DB);
            copy.ExecuteNonQuery();
            SQLiteDataReader reader = copy.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            listExamenatorsData.DataSource = table;
        }

        private void zapros11Btn_Click(object sender, EventArgs e)
        {
            if (oplataBoleeTxt.Text != "")
            {
                listExamenatorsData.DataSource = null;
                SQLiteCommand oplata = new SQLiteCommand($@"
                    DELETE FROM Copy_Examenatory
                    WHERE Razmer_Oplaty > {oplataBoleeTxt.Text}", DB);
                oplata.ExecuteNonQuery();
                ListCopyExamenators();
            }
            else
            {
                MessageBox.Show("Вы не заполнили строку справа");
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            listExamenatorsData.DataSource = null;
            ListCopyExamenators();
            oplataBoleeTxt.Text = "";
            oplataMeneeTxt.Text = "";
        }

        private void zapros12Btn_Click(object sender, EventArgs e)
        {
            if (oplataMeneeTxt.Text != "")
            {
                listExamenatorsData.DataSource = null;
                SQLiteCommand oplata = new SQLiteCommand($@"
                    UPDATE Copy_Examenatory SET Razmer_Oplaty = Razmer_Oplaty * 1.1
                    WHERE Razmer_Oplaty < {oplataMeneeTxt.Text}", DB);
                oplata.ExecuteNonQuery();
                ListCopyExamenators();
            }
            else
            {
                MessageBox.Show("Вы не заполнили строку справа");
            }
        }
    }
}
