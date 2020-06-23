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
    public partial class Пользователи : Form
    {
        public Пользователи()
        {
            InitializeComponent();
        }

        private void Пользователи_Load(object sender, EventArgs e)
        {
            this.пользователиTableAdapter.Fill(this.bookWorldDataSet.Пользователи);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ДобавитьИзменитьПользователей f = new ДобавитьИзменитьПользователей();
            f.ShowDialog();
            this.пользователиTableAdapter.Fill(this.bookWorldDataSet.Пользователи);
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            ДобавитьИзменитьПользователей f = new ДобавитьИзменитьПользователей(Convert.ToString(пользователиDataGridView.CurrentRow.Cells[0].Value), Convert.ToString(пользователиDataGridView.CurrentRow.Cells[1].Value));
            f.ShowDialog();
            this.пользователиTableAdapter.Fill(this.bookWorldDataSet.Пользователи);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
