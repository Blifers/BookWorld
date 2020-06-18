using BookWorld.Base;
using BookWorld.Справочники.Товары;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWorld.Справочники
{
    public partial class СправочникТовары : Form
    {
        //TODO
        //CheckBox - показывать с нулём?
        //Давать вообще возможность удалять или нет?
        //
        public СправочникТовары()
        {
            InitializeComponent();
        }

        private void СправочникТовары_Load(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchTextBox.Text != "" && SearchTextBox.Text != " ")
            {
                string Command = "Select Код_Товара AS [Код товара], Тип_Товара.Наименование AS [Тип товара],Жанры.Наименование AS Жанр,Товары.Наименование,Цена,Остаток FROM Товары inner join Тип_Товара ON Тип_Товара.Код_Типа = Товары.Тип_Товара left join Жанры ON Жанры.Код_Жанра = Товары.Жанр Where Товары.Наименование LIKE '%" + SearchTextBox.Text + "%'";

                StaticProcesser.FillDataGrid(Command, товарыDataGridView);
            }
            else
            {
                UpdateDataGrid();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SearchTextBox.Clear();
        }

        private void ChangePriceButton_Click(object sender, EventArgs e)
        {
            int codeOfGood = Convert.ToInt32(товарыDataGridView.CurrentRow.Cells[0].Value);
            double price = Convert.ToDouble(товарыDataGridView.CurrentRow.Cells[4].Value);
            ИзменитьЦенуНазваниеТовара f = new ИзменитьЦенуНазваниеТовара(codeOfGood,(decimal)price);
            f.ShowDialog();

            UpdateDataGrid();
        }

        private void ChangeTitleButton_Click(object sender, EventArgs e)
        {
            int codeOfGood = Convert.ToInt32(товарыDataGridView.CurrentRow.Cells[0].Value);
            string title = Convert.ToString(товарыDataGridView.CurrentRow.Cells[3].Value);
            ИзменитьЦенуНазваниеТовара f = new ИзменитьЦенуНазваниеТовара(codeOfGood,title);
            f.ShowDialog();

            UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            string Command = "Select Код_Товара AS [Код товара], Тип_Товара.Наименование AS [Тип товара],Жанры.Наименование AS Жанр,Товары.Наименование,Цена,Остаток FROM Товары inner join Тип_Товара ON Тип_Товара.Код_Типа = Товары.Тип_Товара left join Жанры ON Жанры.Код_Жанра = Товары.Жанр";
            StaticProcesser.FillDataGrid(Command, this.товарыDataGridView);
        }
    }
}
