using BookWorld.Base;
using BookWorld.Base.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWorld.ДляУправляющего
{
    public partial class Отчеты : Form
    {
        private string CommandForReportAboutSupply = "Select Тип_Товара.Наименование AS Тип,Жанры.Наименование AS Жанр,Товары.Наименование,Цена,Остаток FROM Товары left join Жанры ON Жанры.Код_Жанра = Товары.Жанр inner join Тип_Товара ON Тип_Товара.Код_Типа = Товары.Тип_Товара WHERE Остаток = 0 or Остаток = 1";

        private string CommandForReportAboutGenres;

        private string CommandForReportAboutTypes;

        private string CommandForReportAboutFinance;

        public Отчеты()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Отчеты_Load(object sender, EventArgs e)
        {

        }

        private void FormReportButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ReportsComboBox.SelectedIndex == 0)
                {
                    StaticProcesser.FillDataGrid(CommandForReportAboutSupply, ReportDataGrid);
                }
                if (ReportsComboBox.SelectedIndex == 1)
                {
                    CommandForReportAboutGenres = "Select Жанры.Наименование, SUM(Количество) AS Количество  FROM Товары right join Состав_Продажи ON Состав_Продажи.Код_Товара = Товары.Код_Товара inner join Жанры ON Код_Жанра = Товары.Жанр inner join Продажа ON Продажа.Чек = Состав_Продажи.Чек Where Продажа.Дата>='" + StartDatePicker.Value.ToShortDateString() + "' And Продажа.Дата<='" + EndDatePicker.Value.ToShortDateString() + "' GROUP BY Жанры.Наименование";
                    StaticProcesser.FillDataGrid(CommandForReportAboutGenres, ReportDataGrid);
                }
                if (ReportsComboBox.SelectedIndex == 2)
                {
                    CommandForReportAboutTypes = "Select Тип_Товара.Наименование, SUM(Количество) AS Количество FROM Товары right join Состав_Продажи ON Состав_Продажи.Код_Товара = Товары.Код_Товара inner join Тип_Товара ON Тип_Товара.Код_Типа=Товары.Тип_Товара inner join Продажа ON Продажа.Чек=Состав_Продажи.Чек Where Продажа.Дата>='" + StartDatePicker.Value.ToShortDateString() + "' and Продажа.Дата<='" + EndDatePicker.Value.ToShortDateString() + "' GROUP BY Тип_Товара.Наименование";
                    StaticProcesser.FillDataGrid(CommandForReportAboutTypes, ReportDataGrid);
                }
                if (ReportsComboBox.SelectedIndex == 3)
                {
                    CommandForReportAboutFinance = "SELECT (Select SUM(Цена_Закупки*Количество)From Состав_Прихода left join Приход ON Приход.Номер_Прихода=Состав_Прихода.Номер_Прихода Where Приход.Дата>='" + StartDatePicker.Value.ToShortDateString() + "' and Приход.Дата<='" + EndDatePicker.Value.ToShortDateString() + "') AS [Сумма затрат на товары],(Select SUM(Сумма_Чека) FROM Продажа Where Дата>='" + StartDatePicker.Value.ToShortDateString() + "' and Дата<='" + EndDatePicker.Value.ToShortDateString() + "') AS [Выручка от продаж]";
                    StaticProcesser.FillDataGrid(CommandForReportAboutFinance, ReportDataGrid);
                }
            }
            catch(Exception ex)
            {
                StaticHelper.ErrorNotifier(ex);
            }
        }

        private void CreateExcelButton_Click(object sender, EventArgs e)
        {
            StaticProcesser.WriteExcel(ReportDataGrid);
        }
    }
}
