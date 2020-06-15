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

namespace BookWorld.Продажа
{
    public partial class ПостоянныеКлиенты : Form
    {
        public ПостоянныеКлиенты()
        {
            InitializeComponent();
        }

        private void постоянные_КлиентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.постоянные_КлиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bookWorldDataSet);

        }

        private void ПостоянныеКлиенты_Load(object sender, EventArgs e)
        {
            this.постоянные_КлиентыTableAdapter.Fill(this.bookWorldDataSet.Постоянные_Клиенты);
        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            int numberOfCard = Convert.ToInt32(постоянные_КлиентыDataGridView.CurrentRow.Cells[0].Value);
            Data.numberOfCard = numberOfCard;
            this.Dispose();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Data.numberOfCard = 0 ;
            this.Dispose();
        }
    }
}
