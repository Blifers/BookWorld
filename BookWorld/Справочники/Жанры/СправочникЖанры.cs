using BookWorld.Справочники.Жанры;
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
    public partial class СправочникЖанры : Form
    {
        public СправочникЖанры()
        {
            InitializeComponent();
        }

        private void СправочникЖанры_Load(object sender, EventArgs e)
        {
            this.жанрыTableAdapter.Fill(this.bookWorldDataSet.Жанры);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ДобавитьИзменитьЖанр f = new ДобавитьИзменитьЖанр();
            f.ShowDialog();
            this.жанрыTableAdapter.Fill(this.bookWorldDataSet.Жанры);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            string title = Convert.ToString(this.жанрыDataGridView.CurrentRow.Cells[1].Value);
            int no = Convert.ToInt32(this.жанрыDataGridView.CurrentRow.Cells[0].Value);
            ДобавитьИзменитьЖанр f = new ДобавитьИзменитьЖанр(title,no);
            f.ShowDialog();
            this.жанрыTableAdapter.Fill(this.bookWorldDataSet.Жанры);
        }
    }
}
