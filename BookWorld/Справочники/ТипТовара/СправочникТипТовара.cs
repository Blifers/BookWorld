using BookWorld.Base;
using BookWorld.Base.Classes;
using BookWorld.Справочники.ТипТовара;
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

namespace BookWorld.Справочники
{
    public partial class СправочникТипТовара : Form
    {
        public СправочникТипТовара()
        {
            InitializeComponent();
        }
        private void СправочникТипТовара_Load(object sender, EventArgs e)
        {
            this.тип_ТовараTableAdapter.Fill(this.bookWorldDataSet.Тип_Товара);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string Command = "Select Код_Товара From Товары Where Тип_Товара=@type";
                SqlParameter p1 = new SqlParameter("type", this.тип_ТовараDataGridView.CurrentRow.Cells[0].Value);
                int amount = StaticProcesser.GetAmountOfRecords(Command, p1);
                if (amount > 0)
                {
                    MessageBox.Show("Сначало нужно избавиться от всех товаров с этим типом");
                }
                else
                {
                    тип_ТовараBindingSource.RemoveCurrent();
                    this.Validate();
                    this.tableAdapterManager.UpdateAll(bookWorldDataSet);
                    MessageBox.Show("Запись успешно удалена");
                }
            }
            catch(Exception ex)
            {
                StaticHelper.ErrorNotifier(ex);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                string title = Convert.ToString(this.тип_ТовараDataGridView.CurrentRow.Cells[1].Value);
                int id = Convert.ToInt32(this.тип_ТовараDataGridView.CurrentRow.Cells[0].Value);
                ДобавитьИзменитьТип f = new ДобавитьИзменитьТип(title, id);
                f.ShowDialog();
                this.тип_ТовараTableAdapter.Fill(this.bookWorldDataSet.Тип_Товара);
            }
            catch (Exception ex)
            {
                StaticHelper.ErrorNotifier(ex);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                ДобавитьИзменитьТип f = new ДобавитьИзменитьТип();
                f.ShowDialog();
                this.тип_ТовараTableAdapter.Fill(this.bookWorldDataSet.Тип_Товара);
            }
            catch(Exception ex)
            {
                StaticHelper.ErrorNotifier(ex);
            }
        }
    }
}
