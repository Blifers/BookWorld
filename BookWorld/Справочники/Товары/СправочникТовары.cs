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
            string Command = "Select Код_Товара AS [Код товара], Тип_Товара.Наименование AS [Тип товара],Жанры.Наименование AS Жанр,Товары.Наименование,Цена,Остаток FROM Товары inner join Тип_Товара ON Тип_Товара.Код_Типа = Товары.Тип_Товара left join Жанры ON Жанры.Код_Жанра = Товары.Жанр";

            StaticProcesser.FillDataGrid(Command, this.товарыDataGridView);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
