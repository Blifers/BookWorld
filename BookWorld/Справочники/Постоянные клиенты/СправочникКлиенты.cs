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
    public partial class СправочникКлиенты : Form
    {
        private string CommandForSearch;
        public СправочникКлиенты()
        {
            InitializeComponent();
        }

        private void СправочникКлиенты_Load(object sender, EventArgs e)
        {
            this.постоянные_КлиентыTableAdapter.Fill(this.bookWorldDataSet.Постоянные_Клиенты);
            постоянные_КлиентыDataGridView.Columns[0].Width = 30;
            постоянные_КлиентыDataGridView.Columns[1].Width = 220;
            постоянные_КлиентыDataGridView.Columns[2].Width = 70;
            постоянные_КлиентыDataGridView.Columns[3].Width = 80;
            comboBox1.SelectedIndex = 0 ;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ДобавитьИзменитьКлиента f = new ДобавитьИзменитьКлиента();
            f.ShowDialog();
            this.постоянные_КлиентыTableAdapter.Fill(this.bookWorldDataSet.Постоянные_Клиенты);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                int cardNumber = Convert.ToInt32(постоянные_КлиентыDataGridView.CurrentRow.Cells[0].Value);
                string fio = Convert.ToString(постоянные_КлиентыDataGridView.CurrentRow.Cells[1].Value);
                string phoneNumber = Convert.ToString(постоянные_КлиентыDataGridView.CurrentRow.Cells[3].Value);
                ДобавитьИзменитьКлиента f = new ДобавитьИзменитьКлиента(cardNumber,fio,phoneNumber);
                f.ShowDialog();
                this.постоянные_КлиентыTableAdapter.Fill(this.bookWorldDataSet.Постоянные_Клиенты);
            }
            catch (Exception ex)
            {
                StaticHelper.ErrorNotifier(ex);
            }
        }

        private void SearchByFioTextBox_TextChanged(object sender, EventArgs e)
        {
            //"Select Код_Товара,Тип_Товара,Жанр,Наименование, Цена, Остаток From Товары Where Наименование LIKE '%"+SearchTextBox.Text+"%'";
            try
            {
                string FullCommandForSearch;
                if (SearchByFioTextBox.Text == "" || SearchByFioTextBox.Text == " ")
                {
                    постоянные_КлиентыDataGridView.DataSource = постоянные_КлиентыBindingSource;
                }
                else
                {
                    FullCommandForSearch = CommandForSearch + SearchByFioTextBox.Text+"%'";
                    StaticProcesser.FillDataGrid(FullCommandForSearch, постоянные_КлиентыDataGridView);

                }
            }
            catch (Exception ex)
            {
                StaticHelper.ErrorNotifier(ex);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchByFioTextBox.Clear();
            if (comboBox1.SelectedIndex == 0)
                CommandForSearch = "Select * from Постоянные_Клиенты Where ФИО LIKE '%";
            else if (comboBox1.SelectedIndex==1)
                CommandForSearch = "Select * from Постоянные_Клиенты Where Телефон LIKE '%";
            else if (comboBox1.SelectedIndex==2)
                CommandForSearch = "Select * from Постоянные_Клиенты Where Номер_Карты LIKE '%";
            SearchByFioTextBox.Focus();
        }

        private void постоянные_КлиентыDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Data.numberOfCard =Convert.ToInt32(постоянные_КлиентыDataGridView.CurrentRow.Cells[0].Value);
            //smth else

        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            Data.numberOfCard = Convert.ToInt32(постоянные_КлиентыDataGridView.CurrentRow.Cells[0].Value);
            this.Dispose();
        }
    }
}
