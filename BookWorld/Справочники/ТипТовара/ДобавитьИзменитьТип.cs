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

namespace BookWorld.Справочники.ТипТовара
{
    public partial class ДобавитьИзменитьТип : Form
    {
        private string Title;
        private int Status;
        private int ID;

        public ДобавитьИзменитьТип()
        {
            this.Status = 0;
            InitializeComponent();
        }

        public ДобавитьИзменитьТип(string title, int id)
        {
            this.Title = title;
            this.ID = id;
            this.Status = 1;
            InitializeComponent();
        }

        private void жанрыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.жанрыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bookWorldDataSet);

        }

        private void ДобавитьИзменитьТип_Load(object sender, EventArgs e)
        {
            this.жанрыTableAdapter.Fill(this.bookWorldDataSet.Жанры);
            TitleTextBox.Focus();
            if (this.Status == 1)
            {
                this.Text = "Изменить название типа";
                TitleTextBox.Text = Title;
                AddButton.Text = "Изменить";
            }
            else
            {
                this.Text = "Добавить название типа";
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
                DataRow dr = bookWorldDataSet.Tables["Тип_Товара"].NewRow();
                dr["Наименование"] = TitleTextBox.Text;
                if (Status == 0)
                {
                    try
                    {
                        bookWorldDataSet.Tables["Тип_Товара"].Rows.Add(dr);
                        this.Validate();
                        this.tableAdapterManager.UpdateAll(this.bookWorldDataSet);
                        MessageBox.Show("Запись успешно добавлена");
                        this.Dispose();
                    }
                    catch (Exception ex)
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
                        жанрыTableAdapter.Update(TitleTextBox.Text, ID, Title);
                        this.Validate();
                        this.tableAdapterManager.UpdateAll(bookWorldDataSet);
                        MessageBox.Show("Запись успешно изменена");
                        this.Dispose();
                    }
                    catch (Exception ex)
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
