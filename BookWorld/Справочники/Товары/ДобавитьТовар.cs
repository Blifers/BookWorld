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

namespace BookWorld.Справочники.Товары
{
    public partial class ДобавитьТовар : Form
    {
        private bool aBook;
        
        public ДобавитьТовар()
        {
            InitializeComponent();
        }

        private void ДобавитьИзменитьТовар_Load(object sender, EventArgs e)
        {
            this.жанрыTableAdapter.Fill(this.bookWorldDataSet.Жанры);
            this.тип_ТовараTableAdapter.Fill(this.bookWorldDataSet.Тип_Товара);
            TypeComboBox.SelectedIndex = 0;
            GenreComboBox.SelectedIndex = 0;
        }

        private void BuyPriceNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            double sellPrice = (double)(BuyPriceNumericUpDown.Value * Data.Percentage);
            int c = (int)sellPrice;
            c = c / 10;
            c =c* 10;
            SellPriceNumericUpDown.Value =(decimal)c;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                //
                //Добавить проверку на заполненность полей.
                //


                SqlParameter type = new SqlParameter("type", TypeComboBox.SelectedValue);
                SqlParameter title = new SqlParameter("title", TitleTextBox.Text);
                SqlParameter price = new SqlParameter("price", SellPriceNumericUpDown.Value);
                string Command;
                if (aBook)
                {
                    SqlParameter genre = new SqlParameter("genre", GenreComboBox.SelectedValue);
                    Command = "Insert Into Товары (Тип_Товара,Жанр,Наименование,Цена, Остаток) VALUES (@type,@genre,@title,@price,0)";
                    StaticProcesser.ExecuteCommand(Command, type, genre, title, price);
                    Data.priceOfBuy = (double)BuyPriceNumericUpDown.Value;
                    this.Dispose();
                }
                else
                {
                    Command = "Insert Into Товары (Тип_Товара, Наименование, Цена, Остаток) VALUES (@type,@title,@price,0)";
                    StaticProcesser.ExecuteCommand(Command, type, title, price);
                    Data.priceOfBuy = (double)BuyPriceNumericUpDown.Value;
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                StaticHelper.ErrorNotifier(ex);
            }
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TypeComboBox.SelectedValue) == 1)
            {
                GenreComboBox.SelectedIndex = 0;
                GenreComboBox.Enabled = true;
                aBook = true;
            }
            else
            {
                GenreComboBox.Text = "";
                GenreComboBox.Enabled = false;
                aBook = false;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
