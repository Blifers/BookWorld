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

namespace BookWorld.Продажа
{
    public partial class ПросмотрПродаж : Form
    {

        public ПросмотрПродаж()
        {
            InitializeComponent();
        }

        private void ПросмотрПродаж_Load(object sender, EventArgs e)
        {
            this.продажаTableAdapter.Fill(this.bookWorldDataSet.Продажа);
        }

        private void продажаDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int cheque = Convert.ToInt32(продажаDataGridView.CurrentRow.Cells[0].Value);
            string Command = "Select Товары.Наименование,Состав_Продажи.Цена,Количество FROM Состав_Продажи inner join Товары ON Товары.Код_Товара=Состав_Продажи.Код_Товара Where Чек="+cheque;
            StaticProcesser.FillDataGrid(Command, GoodsDataGrid);
        }
    }
}
