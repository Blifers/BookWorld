using BookWorld.Base;
using BookWorld.Base.Classes;
using BookWorld.Справочники.Жанры;
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
    public partial class СправочникЖанры : Form
    {
        public СправочникЖанры()
        {
            InitializeComponent();
        }

        private void СправочникЖанры_Load(object sender, EventArgs e)
        {
            this.жанрыTableAdapter.Fill(this.bookWorldDataSet.Жанры);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                ДобавитьИзменитьЖанр f = new ДобавитьИзменитьЖанр();
                f.ShowDialog();
                this.жанрыTableAdapter.Fill(this.bookWorldDataSet.Жанры);
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
                string title = Convert.ToString(this.жанрыDataGridView.CurrentRow.Cells[1].Value);
                int no = Convert.ToInt32(this.жанрыDataGridView.CurrentRow.Cells[0].Value);
                ДобавитьИзменитьЖанр f = new ДобавитьИзменитьЖанр(title, no);
                f.ShowDialog();
                this.жанрыTableAdapter.Fill(this.bookWorldDataSet.Жанры);
            }
            catch(Exception ex)
            {
                StaticHelper.ErrorNotifier(ex);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string command = "Select Код_Товара FROM Товары Where Жанр=@id";
                SqlParameter p1 = new SqlParameter("id", this.жанрыDataGridView.CurrentRow.Cells[0].Value);
                int amount = StaticProcesser.GetAmountOfRecords(command, p1);
                if (amount > 0)
                {
                    MessageBox.Show("Сначала нужно избавиться от всех товаров с этим жанром");
                }
                else
                {
                    жанрыBindingSource.RemoveCurrent();
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
    }
}
