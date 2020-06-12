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
    public partial class СправочникТипТовара : Form
    {
        public СправочникТипТовара()
        {
            InitializeComponent();
        }

        private void тип_ТовараBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.тип_ТовараBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bookWorldDataSet);

        }

        private void СправочникТипТовара_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookWorldDataSet.Тип_Товара". При необходимости она может быть перемещена или удалена.
            this.тип_ТовараTableAdapter.Fill(this.bookWorldDataSet.Тип_Товара);

        }
    }
}
