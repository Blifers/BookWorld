using BookWorld.Base;
using BookWorld.Base.Classes;
using BookWorld.Справочники.Товары;
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

namespace BookWorld.Приход
{
    public partial class Приход : Form
    {

        private DataTable IncomingGoodsDataTable = new DataTable();
        private string GoodsSelectCommand = "Select Код_Товара, Тип_Товара, Жанр, Наименование, Цена,Остаток FROM Товары";
        public Приход()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Написать сохранение сессии???
            //Or at least ask before closing...
            this.Dispose();
        }

        private void Приход_Load(object sender, EventArgs e)
        {            
            StaticProcesser.FillDataGrid(GoodsSelectCommand, dataGridView1);

            dataGridView1.Columns[0].Width = 28;
            dataGridView1.Columns[1].Width = 30;
            dataGridView1.Columns[2].Width = 30;
            dataGridView1.Columns[3].Width = 300;
            dataGridView1.Columns[4].Width = 70;
            dataGridView1.Columns[5].Width = 70;
            //Создание таблицы для состава прихода
            IncomingGoodsDataTable.Columns.Add("Код товара", typeof(int));
            IncomingGoodsDataTable.Columns.Add("Тип товара", typeof(int));
            IncomingGoodsDataTable.Columns.Add("Жанр", typeof(int));
            IncomingGoodsDataTable.Columns.Add("Наименование", typeof(string));
            IncomingGoodsDataTable.Columns.Add("Цена закупки", typeof(double));
            IncomingGoodsDataTable.Columns.Add("Цена продажи", typeof(double));
            IncomingGoodsDataTable.Columns.Add("Количество", typeof(int));
        }


        //Должна быть проверка на существование такого товара!!!!!
        //Check it later please!
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchTextBox.Text !="" && SearchTextBox.Text!=" ")
            {
                string Command = "Select Код_Товара,Тип_Товара,Жанр,Наименование, Цена, Остаток From Товары Where Наименование LIKE '%"+SearchTextBox.Text+"%'";

                StaticProcesser.FillDataGrid(Command, dataGridView1);
            }
            else
            {
                string Command = "Select Код_Товара,Тип_Товара,Жанр, Наименование, Цена,Остаток FROM Товары";
                StaticProcesser.FillDataGrid(Command, dataGridView1);
            }
        }

        

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SearchTextBox.Text = "";
        }

        private void AddGood_Click(object sender, EventArgs e)
        {
            ДобавитьТовар f = new ДобавитьТовар();
            f.ShowDialog();
            StaticProcesser.FillDataGrid(GoodsSelectCommand, dataGridView1);
            BuyPriceNumericUpDown.Value = (decimal)Data.priceOfBuy;
            Data.priceOfBuy = 0;
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count-1].Cells[0];
        }

        private void AddRow(int codeOfGood,int typeOfGood,int genre,string title,double priceOfBuy,double priceOfSell,int amount)
        {
            try
            {
                IncomingGoodsDataTable.Rows.Add(codeOfGood, typeOfGood, genre, title, priceOfBuy,priceOfSell,amount);
                dataGridView2.DataSource = IncomingGoodsDataTable;
            }
            catch(Exception ex)
            {
                StaticHelper.ErrorNotifier(ex);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                int codeOfGood = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                int typeOfGood = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
                int genre = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
                string title = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
                double priceOfBuy = Convert.ToDouble(BuyPriceNumericUpDown.Value);
                double priceOfSell = Convert.ToDouble(dataGridView1.CurrentRow.Cells[4].Value);
                int amount = Convert.ToInt32(AmountNumericUpDown.Value);

                AddRow(codeOfGood, typeOfGood, genre, title, priceOfBuy, priceOfSell, amount);

                
                AmountNumericUpDown.Value = 1;
                BuyPriceNumericUpDown.Value = 0;
            }
            catch(Exception ex)
            {
                StaticHelper.ErrorNotifier(ex);
            }
        }

        private void BuyPriceNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            double sellPrice = (double)(BuyPriceNumericUpDown.Value * Data.Percentage);
            int c = (int)sellPrice;
            c = c / 10;
            c = c * 10;
            SellPriceNumericUpDown.Value = (decimal)c;

        }

        private void FormDocButton_Click(object sender, EventArgs e)
        {
            string place = "beginning";
            try
            {

                string Command = "Insert Into Приход (Дата,Комментарий) VALUES (@date,@comment)";
                SqlParameter p1 = new SqlParameter("date", DateTime.Now.ToShortDateString());
                SqlParameter p2 = new SqlParameter("comment", CommentRichTextBox.Text);
                StaticProcesser.ExecuteCommand(Command, p1, p2);
                place = "added head";

                Command = "With SRC AS (Select TOP(1) Номер_Прихода From Приход ORDER BY Номер_Прихода DESC) Select Номер_Прихода FROM SRC";
                SqlDataReader reader = StaticProcesser.GetReader(Command);
                reader.Read();
                int incID = reader.GetInt32(0);
                StaticProcesser.CloseConnection();
                place = "got ID";

                int codeOfGood;
                double priceOfBuy;
                double priceOfSell;
                int amount;

                string updCommand = "Update Товары SET Остаток=Остаток + @amount Where Код_Товара = @codeOfGood";

                Command = "Insert Into Состав_Прихода (Номер_Прихода,Код_Товара,Количество,Цена_Закупки,Цена_Продажи) VALUES (@id,@codeOfGood,@amount,@priceOfBuy,@priceOfSell)";
                SqlParameter id = new SqlParameter("id", incID);
                SqlParameter PcodeOfGood;
                SqlParameter PpriceOfBuy;
                SqlParameter PpriceOfSell;
                SqlParameter Pamount;
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    codeOfGood = Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value);
                    PcodeOfGood = new SqlParameter("codeOfGood", codeOfGood);

                    priceOfBuy = Convert.ToDouble(dataGridView2.Rows[i].Cells[4].Value);
                    PpriceOfBuy = new SqlParameter("priceOfBuy", priceOfBuy);

                    priceOfSell = Convert.ToDouble(dataGridView2.Rows[i].Cells[5].Value);
                    PpriceOfSell = new SqlParameter("priceOfSell", priceOfSell);

                    amount = Convert.ToInt32(dataGridView2.Rows[i].Cells[6].Value);
                    Pamount = new SqlParameter("amount", amount);

                    StaticProcesser.ExecuteCommand(updCommand, Pamount, PcodeOfGood);

                    StaticProcesser.ExecuteCommand(Command, id, PcodeOfGood, Pamount, PpriceOfBuy, PpriceOfSell);
                    place = "Command executed " + i  +" times";
                }
                
                MessageBox.Show("Документ успешно сформирован");
                StaticProcesser.FillDataGrid(GoodsSelectCommand, dataGridView1);
                IncomingGoodsDataTable.Clear();
                dataGridView2.DataSource = IncomingGoodsDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(place);
                StaticHelper.ErrorNotifier(ex);
            }
        }
    }
}
