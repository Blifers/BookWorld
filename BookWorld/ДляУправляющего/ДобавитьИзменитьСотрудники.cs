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

namespace BookWorld.ДляУправляющего
{
    public partial class ДобавитьИзменитьСотрудники : Form
    {
        private bool isChange;
        private string Fio;
        private string Hired;
        private string DateOfBirth;
        private string PhoneNumber;
        private string Title;
        private int CodeOfWorker;

        private string CommandForAdding="Insert Into Сотрудники (ФИО,Принят,Дата_Рождения,Телефон,Должность) VALUES (@fio,@hired,@dateOfBirth,@phoneNumber,@title)";
        private string CommandForUpdating="Update Сотрудники SET ФИО=@fio,Принят=@hired,Дата_Рождения=@dateOfBirth,Телефон=@phoneNumber,Должность=@title WHERE Код_Сотрудника=@codeOfWorker";

        public ДобавитьИзменитьСотрудники(int codeOfWorker,string fio,string hired,string dateOfBirth,string phoneNumber,string title)
        {
            isChange = true;
            CodeOfWorker = codeOfWorker;
            Fio = fio;
            Hired = hired;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Title = title;
            InitializeComponent();
        }
        public ДобавитьИзменитьСотрудники()
        {
            isChange = false;
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ДобавитьИзменитьСотрудники_Load(object sender, EventArgs e)
        {
            if (isChange)
            {
                FioTextBox.Text = Fio;
                HiredDatePicker.Value = Convert.ToDateTime(Hired);
                BirthDatePicker.Value = Convert.ToDateTime(DateOfBirth);
                NumberTextBox.Text = PhoneNumber;
                TitleTextBox.Text = Title;
                AddEditButton.Text = "Изменить";
                this.Text = "Изменить данные сотрудника";
            }
            else
            {
                AddEditButton.Text = "Добавить";
                this.Text="Добавить нового сотрудника";
            }
        }

        private void AddEditButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlParameter fio = new SqlParameter("fio", FioTextBox.Text);
                SqlParameter hired = new SqlParameter("hired", HiredDatePicker.Value.ToShortDateString());
                SqlParameter dateOfBirth = new SqlParameter("dateOfBirth", BirthDatePicker.Value.ToShortDateString());
                SqlParameter phoneNumber = new SqlParameter("phoneNumber", NumberTextBox.Text);
                SqlParameter title = new SqlParameter("title", TitleTextBox.Text);

                if (isChange)
                {
                    SqlParameter codeOfWorker = new SqlParameter("codeOfWorker", CodeOfWorker);
                    StaticProcesser.ExecuteCommand(CommandForUpdating, fio, hired, dateOfBirth, phoneNumber, title,codeOfWorker);
                }
                else
                    StaticProcesser.ExecuteCommand(CommandForAdding, fio, hired, dateOfBirth, phoneNumber, title);
                this.Dispose();
            }
            catch(Exception ex)
            {
                StaticHelper.ErrorNotifier(ex);
            }
        }
    }
}
