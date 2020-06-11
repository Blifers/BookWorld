using BookWorld.Base.Classes;
using BookWorld.BookWorldDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWorld.Справочники.Жанры
{
    public partial class ДобавитьИзменитьЖанр : Form
    {
        public string Title;
        public int Status;
        public int NO;
        public ДобавитьИзменитьЖанр(string title,int no)
        {
            this.NO = no;
            this.Title = title;
            this.Status = 1;
            InitializeComponent();
        }
        public ДобавитьИзменитьЖанр()
        {
            this.Status = 0;
            InitializeComponent();
        }

        private void ДобавитьИзменитьЖанр_Load(object sender, EventArgs e)
        {
            this.жанрыTableAdapter.Fill(this.bookWorldDataSet.Жанры);
            жанрыTableAdapter.Fill(bookWorldDataSet.Жанры);
            TitleTextBox.Focus();
            if (this.Status == 1)
            {
                this.Text = "Изменить название жанра";
                TitleTextBox.Text = Title;
                AddButton.Text = "Изменить";
            }
            else
            {
                this.Text = "Добавить название жанра";
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (TitleTextBox.Text.Length < 2)
            {
                MessageBox.Show("Слишком короткое название");
            }
            else
            {
                DataRow dr = bookWorldDataSet.Tables["Жанры"].NewRow();
                dr["Наименование"] = TitleTextBox.Text;
                if (Status == 0)
                {
                    try
                    {
                        bookWorldDataSet.Tables["Жанры"].Rows.Add(dr);
                        this.Validate();
                        this.tableAdapterManager.UpdateAll(this.bookWorldDataSet);
                        MessageBox.Show("Запись успешно добавлена");
                        this.Dispose();
                    }
                    catch(Exception ex)
                    {
                        StaticHelper.ErrorNotifier(ex);
                        TitleTextBox.Clear();
                        TitleTextBox.Focus();
                    }
                }
                else
                {
                    try
                    {
                        жанрыTableAdapter.Update(TitleTextBox.Text, NO, Title);
                        this.Validate();
                        this.tableAdapterManager.UpdateAll(bookWorldDataSet);
                        MessageBox.Show("Запись успешно изменена");
                        this.Dispose();
                    }
                    catch(Exception ex)
                    {
                        StaticHelper.ErrorNotifier(ex);
                    }

                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
