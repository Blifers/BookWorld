using BookWorld.Base;
using BookWorld.Base.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWorld
{
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string password = "";
            if (LoginTextBox.Text==" " ||PasswordTextBox.Text == " ")
            {
                MessageBox.Show("Не все поля заполнены");
                LoginTextBox.Focus();
            }
            int count = 0;
            string command = "Select Пароль from Пользователи Where Имя_Пользователя = @login";
            SqlParameter p1 = new SqlParameter("login", LoginTextBox.Text);
            var reader = StaticProcesser.GetReader(command, p1);
            while (reader.Read())
            {
                count++;
                try
                {
                    password = reader.GetString(0);
                    password = password.Replace(Environment.NewLine, "");
                }
                catch (Exception ex)
                {
                    StaticHelper.ErrorNotifier(ex);
                }
            }
            if (count == 0)
            {
                MessageBox.Show("Такого пользователя не существует");
                LoginTextBox.Clear();
                LoginTextBox.Focus();
                PasswordTextBox.Clear();
                reader.Close();
                StaticProcesser.CloseConnection();
            }
            else if (count == 1)
            {
                
                reader.Close();
                StaticProcesser.CloseConnection();
                string inputedPass = StaticProcesser.ComputeHash(PasswordTextBox.Text, new MD5CryptoServiceProvider());
                if (password == inputedPass)
                {
                    User.Login = LoginTextBox.Text;
                    User.Access = 1;
                    if (User.Login == "admin")
                    {
                        User.Access = 2;
                    }
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Пароль введён не верно");
                    PasswordTextBox.Clear();
                    PasswordTextBox.Focus();
                }
            }
        }
    }
}
