using BookWorld.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWorld.Приход
{
    public partial class ПросмотрПриходов : Form
    {
        public ПросмотрПриходов()
        {
            InitializeComponent();
        }

        private void ПросмотрПриходов_Load(object sender, EventArgs e)
        {
            this.приходTableAdapter.Fill(this.bookWorldDataSet.Приход);
        }

        private void приходDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int income = Convert.ToInt32(приходDataGridView.CurrentRow.Cells[0].Value);
            string Command = "Select Товары.Наименование, Цена_Закупки, Цена_Продажи, Количество FROM Состав_Прихода inner join Товары ON Товары.Код_Товара=Состав_Прихода.Код_Товара WHERE Номер_Прихода=" + income;
            StaticProcesser.FillDataGrid(Command, GoodsDataGrid);
        }
    }
}
