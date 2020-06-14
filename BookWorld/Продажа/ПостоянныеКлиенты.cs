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
            // TODO: This line of code loads data into the 'bookWorldDataSet.Постоянные_Клиенты' table. You can move, or remove it, as needed.
            this.постоянные_КлиентыTableAdapter.Fill(this.bookWorldDataSet.Постоянные_Клиенты);

        }
    }
}
