using BookWorld.Base;
using BookWorld.Base.Classes;
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
        private string comForListOfGoods = "Select Код_Товара AS [Код товара], Тип_Товара.Наименование AS [Тип товара],Жанры.Наименование AS Жанр,Товары.Наименование,Цена,Остаток FROM Товары inner join Тип_Товара ON Тип_Товара.Код_Типа = Товары.Тип_Товара left join Жанры ON Жанры.Код_Жанра = Товары.Жанр";
        private DataTable cheque = new DataTable();
        private int CodeOfGood;
        private int Amount;
        private int Status;
        private bool Discount = false;
        public НоваяПродажа()
        {
            Status = 0;
            InitializeComponent();
        }

        public НоваяПродажа(int codeOfGood,int amount)
        {
            Status = 1;
            this.CodeOfGood = codeOfGood;
            this.Amount = amount;
            InitializeComponent();
        }





        

        private void НоваяПродажа_Load(object sender, EventArgs e)
        {
            //Код товара, Тип,Жанр, Наименование,Цена, Остаток
            //При загрузке формы создаём и заполняем 2 таблицы, одна с товарами другая - чек.
            StaticProcesser.FillDataGrid(comForListOfGoods, this.товарыdataGridView);

            cheque.Columns.Add("Код товара", typeof(int));
            cheque.Columns.Add("Наименование", typeof(string));
            cheque.Columns.Add("Цена без скидки", typeof(double));
            cheque.Columns.Add("Цена со скидкой",typeof(double));
            cheque.Columns.Add("Количество", typeof(int));
            //если был использован параметризованный конструктор, добавляем строку в чек.
            if (Status == 1)
            {
                SqlParameter p1 = new SqlParameter("codeOfGood", CodeOfGood);
                SqlDataReader reader = StaticProcesser.GetReader("Select Код_Товара,Наименование,Цена From Товары Where Код_Товара = @codeOfGood",p1);
                reader.Read();
                string title = reader.GetString(1);
                double price = reader.GetDouble(2);
                addRow(CodeOfGood, title, price, price, Amount);
            }
        }
        
        private void addRow (int codeOfGood,string title,double fullPrice,double discountPrice,int amount)
        {
            try
            {
                cheque.Rows.Add(codeOfGood, title, fullPrice, discountPrice, amount);
                чекdataGridView.DataSource = cheque;
            }
            catch(Exception ex)
            {
                StaticHelper.ErrorNotifier(ex);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //Добавление строка в чек
            AddLineToCheque();
        }

        private void AddLineToCheque()
        {
            try
            {
                int amount = Convert.ToInt32(товарыdataGridView.CurrentRow.Cells[5].Value);
                //Проверка остатков на 0
                if (amount == 0)
                {
                    MessageBox.Show("Этого товара больше нет");
                }
                //Проверка заполненности поля с желаемым количеством товара
                else if (AmountTextBox.Text == "" || AmountTextBox.Text == " ")
                {
                    MessageBox.Show("Введите количество товара к покупке");
                }
                else
                {
                    int sellAmount = Convert.ToInt32(AmountTextBox.Text);
                    //Проверка на то что желаемое количество больше имеющегося
                    if (sellAmount > amount)
                    {
                        MessageBox.Show("Недостаточно товаров на складе");
                    }
                    //Если все проверки пройдены успешно,формируется и добавляется строка в чек.
                    else
                    {
                        int codeOfGood = Convert.ToInt32(товарыdataGridView.CurrentRow.Cells[0].Value);
                        string title = Convert.ToString(товарыdataGridView.CurrentRow.Cells[3].Value);
                        double price = Convert.ToDouble(товарыdataGridView.CurrentRow.Cells[4].Value);
                        if (Discount)
                        {
                            double discPrice = price * Data.Discount;
                            addRow(codeOfGood, title, price, discPrice, sellAmount);
                        }
                        addRow(codeOfGood, title, price, price, sellAmount);
                    }
                }
            }
            catch (Exception ex)
            {
                StaticHelper.ErrorNotifier(ex);
            }
        }

        private void ChooseCardOfClient()
        {
            
        }
    }
}
