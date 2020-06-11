using BookWorld.Base.Classes;
using BookWorld.Справочники;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWorld
{
    public partial class ОсновноеМеню : Form
    {
        СправочникЖанры СправочникЖанры;
        СправочникТипТовара СправочникТипТовара;
        СправочникТовары СправочникТовары;

        public ОсновноеМеню()
        {
            InitializeComponent();

        }

        private void ОсновноеМеню_Load(object sender, EventArgs e)
        {
            //реализовать часы в интерфейсе
            timer1.Interval = 10;
            timer1.Enabled = true;
            
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            //Убираем авторизацию пока не нужна
            //this.Enabled = false;

            //Авторизация f = new Авторизация();
            //f.ShowDialog();
            //if (User.Access == 0)
            //{
            //    try
            //    {
            //        this.Dispose();
            //    }
            //    catch (Exception ex)
            //    {
            //        StaticHelper.ErrorNotifier(ex);
            //    }
            //}
            //else if (User.Access == 1 || User.Access == 2)
            //{
            //    this.Enabled = true;
            //}
        }

        private void жанрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(СправочникЖанры==null || СправочникЖанры.IsDisposed)
            {
                СправочникЖанры = new СправочникЖанры()
                {
                    MdiParent = this
                };
                СправочникЖанры.Show();
            }
        }

        private void типТовараToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (СправочникТипТовара == null || СправочникТипТовара.IsDisposed)
            {
                СправочникТипТовара = new СправочникТипТовара()
                {
                    MdiParent = this
                };
                СправочникТипТовара.Show();
            }
        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (СправочникТовары == null || СправочникТовары.IsDisposed)
            {
                СправочникТовары = new СправочникТовары()
                {
                    MdiParent = this
                };
                СправочникТовары.Show();
            }
        }
    }
}
