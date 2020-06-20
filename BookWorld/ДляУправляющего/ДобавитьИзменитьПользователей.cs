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

namespace BookWorld.ДляУправляющего
{
    public partial class ДобавитьИзменитьПользователей : Form
    {
        private string Login;
        private string HashedPass;
        private bool isChange;

        public ДобавитьИзменитьПользователей(string login,string hashedPass)
        {
            isChange = true;
            Login = login;
            HashedPass = hashedPass;
            InitializeComponent();
        }

        public ДобавитьИзменитьПользователей()
        {
            isChange = false;
            InitializeComponent();
        }

        private void ДобавитьИзменитьПользователей_Load(object sender, EventArgs e)
        {
            if (isChange)
            {
                this.Text = "Изменить данные пользователя";
                AddEditButton.Text = "Изменить";
                LoginTextBox.Text = Login;
                if (Login == "admin")
                {
                    LoginTextBox.Enabled = false;
                }
            }
            else
            {
                this.Text = "Добавить нового пользователя";
                AddEditButton.Text = "Добавить";
            }
        }

        private void AddEditButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (isChange)
                {
                    
                    if ((PassTextBox.Text == "" || PassTextBox.Text == " ") && (ConfPassTextBox.Text == "" || ConfPassTextBox.Text == " ") && (LoginTextBox.Text != "" || LoginTextBox.Text != " "))
                    {
                        string Command = "Update Пользователи SET Имя_Пользователя=@login Where Имя_Пользователя=@oldLogin";
                        SqlParameter newLogin = new SqlParameter("login", LoginTextBox.Text);
                        SqlParameter oldLogin = new SqlParameter("oldLogin", Login);
                        StaticProcesser.ExecuteCommand(Command, newLogin,oldLogin);
                        this.Dispose();
                    }
                    else
                    {
                        if (PassTextBox.Text == ConfPassTextBox.Text && LoginTextBox.Text != "" && LoginTextBox.Text != " ")
                        {
                            string newhashedPass = StaticProcesser.ComputeHash(PassTextBox.Text, new MD5CryptoServiceProvider());
                            SqlParameter newLogin = new SqlParameter("login", LoginTextBox.Text);
                            SqlParameter newHashedPass = new SqlParameter("newHashedPass", newhashedPass);
                            SqlParameter oldLogin = new SqlParameter("oldLogin", Login);
                            string Command = "Update Пользователи SET Имя_Пользователя=@login, Пароль=@newHashedPass Where Имя_Пользователя=@oldLogin";
                            StaticProcesser.ExecuteCommand(Command, newLogin, newHashedPass, oldLogin);
                            this.Dispose();
                        }
                    }
                }
                else
                {
                    if ((PassTextBox.Text == "" || PassTextBox.Text == " ") && (ConfPassTextBox.Text == "" || ConfPassTextBox.Text == " ") && (LoginTextBox.Text == "" || LoginTextBox.Text == " "))
                    {
                        MessageBox.Show("Заполните все поля!");
                        LoginTextBox.Focus();
                    }
                    else
                    {
                        if (PassTextBox.Text == ConfPassTextBox.Text)
                        {
                            string newhashedPass = StaticProcesser.ComputeHash(PassTextBox.Text, new MD5CryptoServiceProvider());
                            SqlParameter newLogin = new SqlParameter("login", LoginTextBox.Text);
                            SqlParameter newHashedPass = new SqlParameter("newHashedPass", newhashedPass);

                            string Command = "Insert INTO Пользователи (Имя_Пользователя,Пароль) VALUES (@login,@newHashedPass)";
                            StaticProcesser.ExecuteCommand(Command, newLogin, newHashedPass);
                            this.Dispose();
                        }
                        else
                        {
                            PassTextBox.Clear();
                            ConfPassTextBox.Clear();
                            PassTextBox.Focus();
                            MessageBox.Show("Пароли не совпадают!");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                StaticHelper.ErrorNotifier(ex);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
