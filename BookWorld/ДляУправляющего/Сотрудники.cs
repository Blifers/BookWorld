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

namespace BookWorld.ДляУправляющего
{
    public partial class Сотрудники : Form
    {
        public Сотрудники()
        {
            InitializeComponent();
        }

        private void Сотрудники_Load(object sender, EventArgs e)
        {
            this.сотрудникиTableAdapter.Fill(this.bookWorldDataSet.Сотрудники);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ДобавитьИзменитьСотрудники f = new ДобавитьИзменитьСотрудники();
            f.ShowDialog();
            сотрудникиTableAdapter.Fill(this.bookWorldDataSet.Сотрудники);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                int codeOfWorker = Convert.ToInt32(сотрудникиDataGridView.CurrentRow.Cells[0].Value);
                string fio = Convert.ToString(сотрудникиDataGridView.CurrentRow.Cells[1].Value);
                string hired = Convert.ToString(сотрудникиDataGridView.CurrentRow.Cells[2].Value);
                string dateOfBirth = Convert.ToString(сотрудникиDataGridView.CurrentRow.Cells[4].Value);
                string phoneNumber = Convert.ToString(сотрудникиDataGridView.CurrentRow.Cells[5].Value);
                string title = Convert.ToString(сотрудникиDataGridView.CurrentRow.Cells[6].Value);
                ДобавитьИзменитьСотрудники f = new ДобавитьИзменитьСотрудники(codeOfWorker, fio, hired, dateOfBirth, phoneNumber, title);
            }
            catch(Exception ex)
            {
                StaticHelper.ErrorNotifier(ex);
            } 
        }
    }
}
