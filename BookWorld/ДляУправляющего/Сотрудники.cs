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
                f.ShowDialog();
                сотрудникиTableAdapter.Fill(this.bookWorldDataSet.Сотрудники);
            }
            catch (Exception ex)
            {
                StaticHelper.ErrorNotifier(ex);
            } 
        }

        private void FireButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (label1.Visible == false)
                {
                    ControlExtraControls(true);
                }
                else
                {
                    var result = MessageBox.Show("Вы уверены, что хотите уволить этого сотрудника?", "Подтверждение увольнения", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        string Command = "Update Сотрудники SET Уволен=@fired Where Код_Сотрудника=codeOfWorker";
                        SqlParameter fired = new SqlParameter("fired", FiredDatePicker.Value.ToShortDateString());
                        SqlParameter codeOfWorker = new SqlParameter("codeOfWorker", Convert.ToString(сотрудникиDataGridView.CurrentRow.Cells[0].Value));
                        StaticProcesser.ExecuteCommand(Command, fired, codeOfWorker);
                        сотрудникиTableAdapter.Fill(this.bookWorldDataSet.Сотрудники);
                    }
                    else
                    {
                        ControlExtraControls(false);
                    }
                }
            }
            catch (Exception ex)
            {
                StaticHelper.ErrorNotifier(ex);
            }
        }
        private void ControlExtraControls(bool what)
        {
            label1.Visible = what;
            label2.Visible = what;
            FiredDatePicker.Visible = what;
        }
    }
}
