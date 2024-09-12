using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Exam
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public static SQLiteConnection DB = new SQLiteConnection(DataBase.connection);
        private void loginBtn_Click(object sender, EventArgs e)
        {
            DB.Open();
            SQLiteCommand log = new SQLiteCommand(@"SELECT Login, Password FROM User WHERE Login = @Login AND Password = @Password", DB);
            log.Parameters.AddWithValue("@Login", loginTxt.Text);
            log.Parameters.AddWithValue("@Password", passwordTxt.Text);
            SQLiteDataReader reader = log.ExecuteReader();
            bool logEnter = reader.HasRows;
            if (logEnter)
            {
                Application.Exit();
                var thread = new Thread(OpenMainForm);
                thread.Start();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
            DB.Close();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            var thread = new Thread(OpenRegisterForm);
            thread.Start();
        }
        public void OpenMainForm()
        {
            Application.Run(new MainForm());
        }
        public void OpenRegisterForm()
        {
            Application.Run(new RegisterForm());
        }
    }
}
