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
    public partial class Управление : Form
    {
        Сотрудники Сотрудники;
        public Управление()
        {
            InitializeComponent();
        }

        private void Управление_Load(object sender, EventArgs e)
        {
            PercentageTextBox.Text = Convert.ToString(Properties.Settings.Default.Percentage);
            DiscountTextBox.Text = Convert.ToString(Properties.Settings.Default.Discount);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (PercentageCheckBox.Checked)
            {
                PercentageTextBox.Enabled = true;
            }
            else
            {
                PercentageTextBox.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (DiscountCheckBox.Checked)
            {
                DiscountTextBox.Enabled = true;
            }
            else
            {
                DiscountTextBox.Enabled = false;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Percentage = Convert.ToDecimal(PercentageTextBox.Text);
                Properties.Settings.Default.Discount = Convert.ToDouble(DiscountTextBox.Text);
                Properties.Settings.Default.Save();
                MessageBox.Show("Данные успешно изменены");
                PercentageCheckBox.Checked = false;
                DiscountCheckBox.Checked = false;
            }
            catch (Exception ex)
            {
                StaticHelper.ErrorNotifier(ex);
            }
        }

        private void WorkersButton_Click(object sender, EventArgs e)
        {
            if (Сотрудники == null || Сотрудники.IsDisposed)
            {
                Сотрудники = new Сотрудники()
                {
                    MdiParent = this.MdiParent
                };
                Сотрудники.Show();
            }
        }
    }
}
