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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            DB.Open();
        }
        public static SQLiteConnection DB = new SQLiteConnection(DataBase.connection);
        private void backBtn_Click(object sender, EventArgs e)
        {
            DB.Close();
            Application.Exit();
            var thread = new Thread(openLoginForm);
            thread.Start();
        }
        public void openLoginForm()
        {
            Application.Run(new LoginForm());
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (loginTxt.Text != "" && passwordTxt.Text != "")
            {
                SQLiteCommand adduser = new SQLiteCommand(@"
                INSERT INTO User (Login, Password)
                VALUES (@Login, @Password)", DB);
                adduser.Parameters.AddWithValue("@Login", loginTxt.Text);
                adduser.Parameters.AddWithValue("@Password", passwordTxt.Text);
                adduser.ExecuteNonQuery();
                DB.Close();
                Application.Exit();
                var thread = new Thread(openMainForm);
                thread.Start();
            }
            else
            {
                MessageBox.Show("Вы оставили кое-какие поля пустыми");
            }
        }
        public void openMainForm()
        {
            Application.Run(new MainForm());
        }
    }
}
