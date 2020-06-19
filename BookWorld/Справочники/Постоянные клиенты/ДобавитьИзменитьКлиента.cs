using BookWorld.Base;
using BookWorld.Base.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWorld.Справочники.Постоянные_клиенты
{
    public partial class ДобавитьИзменитьКлиента : Form
    {
        private bool isChange;
        private int CardNumber;
        private string Fio;
        private string PhoneNumber;

        public ДобавитьИзменитьКлиента(int cardNumber,string fio,string phoneNumber)
        {
            isChange = true;
            CardNumber = cardNumber;
            Fio = fio;
            PhoneNumber = phoneNumber;
            InitializeComponent();
            
        }

        public ДобавитьИзменитьКлиента()
        {
            isChange = false;
            
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((FioTextBox.Text != "" || FioTextBox.Text != " ") && (PhoneNumberTextBox.Text != "" || PhoneNumberTextBox.Text != " "))
                {
                    SqlParameter fio = new SqlParameter("fio", FioTextBox.Text);
                    SqlParameter phoneNumber = new SqlParameter("phoneNumber", PhoneNumberTextBox.Text);
                    string Command;
                    if (isChange)
                    {
                        Command = "Update Постоянные_Клиенты SET ФИО = @fio, Телефон = @phoneNumber WHERE Номер_Карты = @cardNumber";
                        SqlParameter cardNumber = new SqlParameter("cardNumber", CardNumber);
                        StaticProcesser.ExecuteCommand(Command, fio, phoneNumber, cardNumber);
                        this.Dispose();
                    }
                    else
                    {
                        Command = "Insert Into Постоянные_Клиенты (ФИО,Дата_Вручения,Телефон) VALUES (@fio,@date,@phoneNumber)";
                        SqlParameter date = new SqlParameter("date", DateTime.Now.ToShortDateString());
                        StaticProcesser.ExecuteCommand(Command, fio, date, phoneNumber);
                        this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля!");
                }
            }
            catch (Exception ex)
            {
                StaticHelper.ErrorNotifier(ex);
            }
        }

        private void ДобавитьИзменитьКлиента_Load(object sender, EventArgs e)
        {
            if (isChange)
            {
                this.Text = "Изменить данные клиента";
                this.EnterButton.Text = "Изменить";
                this.FioTextBox.Text = Fio;
                this.PhoneNumberTextBox.Text = PhoneNumber;
            }
            else
            {
                this.Text = "Добавить клиента";
                this.EnterButton.Text = "Добавить";
            }
        }
    }
}
