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

            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 60;
            dataGridView1.Columns[2].Width = 40;
            dataGridView1.Columns[3].Width = 270;
            dataGridView1.Columns[4].Width = 50;
            dataGridView1.Columns[5].Width = 56;
            //Создание таблицы для состава прихода
            IncomingGoodsDataTable.Columns.Add("Код товара", typeof(int));
            IncomingGoodsDataTable.Columns.Add("Наименование", typeof(string));
            IncomingGoodsDataTable.Columns.Add("Цена закупки", typeof(double));
            IncomingGoodsDataTable.Columns.Add("Цена продажи", typeof(double));
            IncomingGoodsDataTable.Columns.Add("Количество", typeof(int));
            
            dataGridView2.DataSource = IncomingGoodsDataTable;

            dataGridView2.Columns[0].Width = 75;
            dataGridView2.Columns[1].Width = 320;
            dataGridView2.Columns[2].Width = 90;
            dataGridView2.Columns[3].Width = 90;
            dataGridView2.Columns[4].Width = 80;
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

        private void AddRow(int codeOfGood,string title,double priceOfBuy,double priceOfSell,int amount)
        {
            try
            {
                IncomingGoodsDataTable.Rows.Add(codeOfGood, title, priceOfBuy,priceOfSell,amount);
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
                string title = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
                double priceOfBuy = Convert.ToDouble(BuyPriceNumericUpDown.Value);
                double priceOfSell = Convert.ToDouble(dataGridView1.CurrentRow.Cells[4].Value);
                int amount = Convert.ToInt32(AmountNumericUpDown.Value);

                AddRow(codeOfGood, title, priceOfBuy, priceOfSell, amount);

                
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
            SellPriceNumericUpDown.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value);
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

                    priceOfBuy = Convert.ToDouble(dataGridView2.Rows[i].Cells[2].Value);
                    PpriceOfBuy = new SqlParameter("priceOfBuy", priceOfBuy);

                    priceOfSell = Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value);
                    PpriceOfSell = new SqlParameter("priceOfSell", priceOfSell);

                    amount = Convert.ToInt32(dataGridView2.Rows[i].Cells[4].Value);
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

        private void AmountNumericUpDown_Enter(object sender, EventArgs e)
        {
            AmountNumericUpDown.Select(0, AmountNumericUpDown.Text.Length);
        }

        private void BuyPriceNumericUpDown_Enter(object sender, EventArgs e)
        {
            BuyPriceNumericUpDown.Select(0, BuyPriceNumericUpDown.Text.Length);
        }

        private void SellPriceNumericUpDown_Enter(object sender, EventArgs e)
        {
            SellPriceNumericUpDown.Select(0, SellPriceNumericUpDown.Text.Length);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AmountNumericUpDown.Value = 0;
            BuyPriceNumericUpDown.Value = 0;
            SellPriceNumericUpDown.Value = 0;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Данные_для_прихода f = new Данные_для_прихода(BuyPriceNumericUpDown, AmountNumericUpDown);
                f.ShowDialog();
                if (AmountNumericUpDown.Value != 0)
                {
                    int codeOfGood = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    string title = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
                    double priceOfBuy = Convert.ToDouble(BuyPriceNumericUpDown.Value);
                    double priceOfSell = Convert.ToDouble(dataGridView1.CurrentRow.Cells[4].Value);
                    int amount = Convert.ToInt32(AmountNumericUpDown.Value);

                    AddRow(codeOfGood, title, priceOfBuy, priceOfSell, amount);


                    AmountNumericUpDown.Value = 1;
                    BuyPriceNumericUpDown.Value = 0;
                    SellPriceNumericUpDown.Value = 0;
                }
            }
            catch(Exception ex)
            {
                StaticHelper.ErrorNotifier(ex);
            }
        }

        private void DeleteRowButton_Click(object sender, EventArgs e)
        {
            try
            {
                int numberOfRow = dataGridView2.CurrentRow.Index;

                DataTable tempDT = new DataTable();
                tempDT.Columns.Add("Код товара", typeof(int));
                tempDT.Columns.Add("Наименование", typeof(string));
                tempDT.Columns.Add("Цена закупки", typeof(double));
                tempDT.Columns.Add("Цена продажи", typeof(double));
                tempDT.Columns.Add("Количество", typeof(int));
                
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    if (i != numberOfRow)
                    {
                        tempDT.Rows.Add(Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value), Convert.ToString(dataGridView2.Rows[i].Cells[1].Value), Convert.ToDouble(dataGridView2.Rows[i].Cells[2].Value), Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value), Convert.ToDouble(dataGridView2.Rows[i].Cells[4].Value));
                    }
                    else
                    {

                    }
                }
                IncomingGoodsDataTable = tempDT;
                dataGridView2.DataSource = IncomingGoodsDataTable;
            }
            catch (Exception ex)
            {
                StaticHelper.ErrorNotifier(ex);
            }
        }

        private void ClearTableButton_Click(object sender, EventArgs e)
        {
            IncomingGoodsDataTable.Clear();
        }
    }
}
