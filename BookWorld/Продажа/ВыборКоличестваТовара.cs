using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWorld.Продажа
{
    public partial class ВыборКоличестваТовара : Form
    {
        private int MaxAmount;
        NumericUpDown Amount;

        public ВыборКоличестваТовара(int maxAmount, NumericUpDown amount)
        {
            MaxAmount = maxAmount;
            Amount = amount;
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Amount.Value = 0;
            this.Dispose();
        }

        private void ВыборКоличестваТовара_Load(object sender, EventArgs e)
        {
            numericUpDown1.Focus();
            label2.Text += MaxAmount.ToString();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > MaxAmount)
            {
                MessageBox.Show("Недостаточно товаров");
                numericUpDown1.Value = 0;
                numericUpDown1.Focus();
            }
            else
            {
                Amount.Value = numericUpDown1.Value;
                this.Dispose();
            }
        }

        private void numericUpDown1_Enter(object sender, EventArgs e)
        {
            numericUpDown1.Select(0, numericUpDown1.Text.Length);
        }
    }
}
