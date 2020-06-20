using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWorld.Приход
{
    public partial class Данные_для_прихода : Form
    {
        private NumericUpDown Price;
        private NumericUpDown Amount;

        public Данные_для_прихода(NumericUpDown price,NumericUpDown amount)
        {
            Price = price;
            Amount = amount;
            InitializeComponent();
        }

        private void numericUpDown1_Enter(object sender, EventArgs e)
        {
            numericUpDown1.Select(0, numericUpDown1.Text.Length);
        }

        private void PriceOfBuyNumeric_Enter(object sender, EventArgs e)
        {
            PriceOfBuyNumeric.Select(0, PriceOfBuyNumeric.Text.Length);
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            Amount.Value = numericUpDown1.Value;
            Price.Value = PriceOfBuyNumeric.Value;
            this.Dispose();
        }

        private void Данные_для_прихода_Load(object sender, EventArgs e)
        {
            numericUpDown1.Focus();
        }
    }
}
