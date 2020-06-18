using BookWorld.Base;
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

namespace BookWorld.Справочники.Товары
{
    public partial class ИзменитьЦенуНазваниеТовара : Form
    {
        private bool isPrice;
        private string Title;
        private double Price;
        private int CodeOfGood;


        public ИзменитьЦенуНазваниеТовара(int codeOfGood,string title)
        {
            isPrice = false;
            Title = title;
            CodeOfGood = codeOfGood;
            InitializeComponent();
        }

        public ИзменитьЦенуНазваниеТовара(int codeOfGood,decimal price)
        {
            isPrice = true;
            Price =(double) price;
            CodeOfGood = codeOfGood;
            InitializeComponent();
        }

        private void ИзменитьЦенуНазваниеТовара_Load(object sender, EventArgs e)
        {
            if (isPrice)
            {
                this.Text = "Изменить цену ";
                TitleLabel.Visible = false;
                TitleTextBox.Visible = false;
                numericUpDown1.Value = (decimal)Price;
            }
            else
            {
                this.Text = "Изменить название";
                numericUpDown1.Visible = false;
                PriceLabel.Visible = false;
                TitleTextBox.Text = Title;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string Command;
            SqlParameter codeOfGood = new SqlParameter("codeOfGood", CodeOfGood);
            if (isPrice)
            {
                if (numericUpDown1.Value == 0)
                {
                    MessageBox.Show("Не возможная цена!");
                }
                else
                {
                    Price = (double)numericUpDown1.Value;
                    Command = "Update Товары Set Цена = @price WHERE Код_Товара=@codeOfGood";
                    SqlParameter price = new SqlParameter("price", Price);
                    StaticProcesser.ExecuteCommand(Command, price, codeOfGood);
                    this.Dispose();
                }
            }
            else
            {
                if (TitleTextBox.Text !="" && TitleTextBox.Text != " ")
                { 
                    Title = TitleTextBox.Text;
                    Command = "Update Товары SET Наименование = @title WHERE Код_Товара = @codeOfGood";
                    SqlParameter title = new SqlParameter("title", Title);
                    StaticProcesser.ExecuteCommand(Command, title, codeOfGood);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Не оставляйте поле пустым!");
                }
            }
        }
    }
}
