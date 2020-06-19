using BookWorld.Base;
using BookWorld.Base.Classes;
using BookWorld.Справочники.Постоянные_клиенты;
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

namespace BookWorld.Продажа
{
    public partial class НоваяПродажа : Form
    {
        private string comForListOfGoods = "Select Код_Товара AS [Код], Тип_Товара.Наименование AS [Тип],Жанры.Наименование AS Жанр,Товары.Наименование,Цена,Остаток FROM Товары inner join Тип_Товара ON Тип_Товара.Код_Типа = Товары.Тип_Товара left join Жанры ON Жанры.Код_Жанра = Товары.Жанр";
        private DataTable cheque = new DataTable();
        private double fullcost = 0;
        public НоваяПродажа()
        {
            InitializeComponent();
        }


        private void НоваяПродажа_Load(object sender, EventArgs e)
        {
            StaticProcesser.FillDataGrid(comForListOfGoods, this.товарыdataGridView);

            товарыdataGridView.Columns[0].Width = 28;
            товарыdataGridView.Columns[1].Width = 80;
            товарыdataGridView.Columns[2].Width = 80;
            товарыdataGridView.Columns[3].Width = 300;
            товарыdataGridView.Columns[4].Width = 50;
            товарыdataGridView.Columns[5].Width = 60;

            cheque.Columns.Add("Код товара", typeof(int));
            cheque.Columns.Add("Наименование", typeof(string));
            cheque.Columns.Add("Цена", typeof(double));
            cheque.Columns.Add("Количество", typeof(int));
            cheque.Columns.Add("Стоимость", typeof(double));
            чекdataGridView.DataSource = cheque;
            чекdataGridView.Columns[0].Width = 60;
            чекdataGridView.Columns[1].Width = 300;
            чекdataGridView.Columns[2].Width = 80;
            чекdataGridView.Columns[3].Width = 79;
            чекdataGridView.Columns[4].Width = 79;
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchTextBox.Text != "" && SearchTextBox.Text != " ")
            {
                string Command = "Select Код_Товара AS [Код], Тип_Товара.Наименование AS [Тип],Жанры.Наименование AS Жанр,Товары.Наименование,Цена,Остаток FROM Товары inner join Тип_Товара ON Тип_Товара.Код_Типа = Товары.Тип_Товара left join Жанры ON Жанры.Код_Жанра = Товары.Жанр Where Товары.Наименование LIKE '%" + SearchTextBox.Text + "%'";

                StaticProcesser.FillDataGrid(Command, товарыdataGridView);
            }
            else
            {
                StaticProcesser.FillDataGrid(comForListOfGoods, товарыdataGridView);
            }
        }



        private void ClearButton_Click(object sender, EventArgs e)
        {
            SearchTextBox.Clear();
            SearchTextBox.Focus();
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            if (AmountNumericUpDown.Value == 0)
            {
                MessageBox.Show("Укажите количество товара");
            }
            else if (товарыdataGridView.CurrentRow == null)
            {
                MessageBox.Show("Выберите товар");
            }
            else
            {
                AddLineToCheque();
                GetFullCost();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void товарыdataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToInt32(товарыdataGridView.CurrentRow.Cells[5].Value) > 0)
            {
                ВыборКоличестваТовара f = new ВыборКоличестваТовара(Convert.ToInt32(товарыdataGridView.CurrentRow.Cells[5].Value), AmountNumericUpDown);
                f.ShowDialog();
                if (AmountNumericUpDown.Value != 0)
                {
                    AddLineToCheque();
                    GetFullCost();
                }
            }
            else
            {
                MessageBox.Show("Этот товар закончился");
            }
        }

        private void AmountNumericUpDown_Enter(object sender, EventArgs e)
        {

            AmountNumericUpDown.Select(0, AmountNumericUpDown.Text.Length);
        }

        private void AddLineToCheque()
        {
            try
            {
                int codeOfGood = Convert.ToInt32(товарыdataGridView.CurrentRow.Cells[0].Value);
                string title = Convert.ToString(товарыdataGridView.CurrentRow.Cells[3].Value);
                decimal price = Convert.ToDecimal(товарыdataGridView.CurrentRow.Cells[4].Value);
                int amount = Convert.ToInt32(AmountNumericUpDown.Value);

                cheque.Rows.Add(codeOfGood, title, price, amount, price * amount);
                чекdataGridView.DataSource = cheque;
            }
            catch (Exception ex)
            {
                StaticHelper.ErrorNotifier(ex);
            }
        }

        private void GetFullCost()
        {
            fullcost=0;
            for (int i = 0; i < чекdataGridView.Rows.Count; i++)
            {
                fullcost += Convert.ToDouble(чекdataGridView.Rows[i].Cells[4].Value);
            }
            CostLabel.Text = "Стоимость: " + fullcost.ToString();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            cheque.Clear();
            GetFullCost();
        }

        private void DelRowButton_Click(object sender, EventArgs e)
        {
            try
            {
                int numberOfRow = чекdataGridView.CurrentRow.Index;

                DataTable tempDT = new DataTable();
                tempDT.Columns.Add("Код товара", typeof(int));
                tempDT.Columns.Add("Наименование", typeof(string));
                tempDT.Columns.Add("Цена", typeof(double));
                tempDT.Columns.Add("Количество", typeof(int));
                tempDT.Columns.Add("Стоимость", typeof(double));

                for (int i = 0; i < чекdataGridView.Rows.Count; i++)
                {
                    if (i != numberOfRow)
                    {
                        tempDT.Rows.Add(Convert.ToInt32(чекdataGridView.Rows[i].Cells[0].Value),Convert.ToString(чекdataGridView.Rows[i].Cells[1].Value),Convert.ToDouble(чекdataGridView.Rows[i].Cells[2].Value), Convert.ToInt32(чекdataGridView.Rows[i].Cells[3].Value), Convert.ToDouble(чекdataGridView.Rows[i].Cells[4].Value));
                    }
                    else
                    {

                    }
                }
                cheque = tempDT;
                чекdataGridView.DataSource = cheque;
                GetFullCost();
            }
            catch(Exception ex)
            {
                StaticHelper.ErrorNotifier(ex);
            }
        }

        private void ApplyDiscount()
        {
            GetFullCost();
            fullcost = fullcost * Data.Discount;
        }

        private void FormDocButton_Click(object sender, EventArgs e)
        {
            try
            {
                string place = "beginning";
                bool hasCard;
                string Command = "INSERT INTO Продажа (Дата,Сумма_Чека) VALUES (@date,@chequeSum)";
                Data.numberOfCard = 0;
                var result = MessageBox.Show("Спросите есть ли у клиента карта", "Наличие карты", MessageBoxButtons.YesNo);

                SqlParameter cardNumber = new SqlParameter();
                if (result == DialogResult.No)
                {
                    hasCard = false;
                }
                else
                {
                    СправочникКлиенты f = new СправочникКлиенты();
                    f.ShowDialog();

                    if (Data.numberOfCard > 0)
                    {
                        hasCard = true;
                        ApplyDiscount();
                        Command = "INSERT INTO Продажа (Дата,Номер_Карты,Сумма_Чека) VALUES (@date,@cardNumber,@chequeSum)";
                        cardNumber = new SqlParameter("cardNumber", Data.numberOfCard);
                    }
                    else
                    {
                        hasCard = false;
                    }
                }
                MessageBox.Show("Итоговая стоимость = " + fullcost + " рублей");
                SqlParameter date = new SqlParameter("date", DateTime.Now.ToShortDateString());
                SqlParameter chequeSum = new SqlParameter("chequeSum", fullcost);
                if (hasCard)
                    StaticProcesser.ExecuteCommand(Command, date, cardNumber, chequeSum);
                else
                    StaticProcesser.ExecuteCommand(Command, date, chequeSum);
                place = "added head";

                Command = "With SRC AS (Select TOP(1) Чек From Продажа ORDER BY Чек DESC) Select Чек FROM SRC";
                SqlDataReader reader = StaticProcesser.GetReader(Command);
                reader.Read();
                int chequeNumber = reader.GetInt32(0);
                StaticProcesser.CloseConnection();
                place = "got chequeNumber";

                double codeOfGood;
                double priceOfSell;
                int amount;

                string updCommand = "Update Товары SET Остаток=Остаток-@amount Where Код_Товара = @codeOfGood";

                Command = "Insert INTO Состав_Продажи (Чек,Код_Товара,Цена,Количество) VALUES (@chequeNumber,@codeOfGood,@priceOfSell,@amount)";

                SqlParameter PchequeNumber = new SqlParameter("chequeNumber", chequeNumber);
                SqlParameter PcodeOfGood;
                SqlParameter PpriceOfSell;
                SqlParameter Pamount;

                for (int i = 0; i < чекdataGridView.Rows.Count; i++)
                {
                    codeOfGood = Convert.ToInt32(чекdataGridView.Rows[i].Cells[0].Value);
                    PcodeOfGood = new SqlParameter("codeOfGood", codeOfGood);

                    if (hasCard)
                        priceOfSell = Convert.ToDouble(чекdataGridView.Rows[i].Cells[2].Value) * Data.Discount;
                    else
                        priceOfSell = Convert.ToDouble(чекdataGridView.Rows[i].Cells[2].Value);
                    PpriceOfSell = new SqlParameter("priceOfSell", priceOfSell);

                    amount = Convert.ToInt32(чекdataGridView.Rows[i].Cells[3].Value);
                    Pamount = new SqlParameter("amount", amount);

                    StaticProcesser.ExecuteCommand(updCommand, Pamount, PcodeOfGood);

                    StaticProcesser.ExecuteCommand(Command, PchequeNumber, PcodeOfGood, PpriceOfSell, Pamount);
                    place = "Command executed " + i + " times";
                }
                MessageBox.Show("Документ успешно сформирован");
                StaticProcesser.FillDataGrid(comForListOfGoods, товарыdataGridView);
                cheque.Clear();
                чекdataGridView.DataSource = cheque;
                GetFullCost();
                Data.numberOfCard = 0;
            }
            catch(Exception ex)
            {
                StaticHelper.ErrorNotifier(ex);
            }
        }
    }
}


   

