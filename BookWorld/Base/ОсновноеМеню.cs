using BookWorld.Base.Classes;
using BookWorld.ДляУправляющего;
using BookWorld.Приход;
using BookWorld.Продажа;
using BookWorld.Справочники;
using BookWorld.Справочники.Постоянные_клиенты;
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
        Приход.Приход Приход;
        СправочникКлиенты СправочникКлиенты;
        НоваяПродажа НоваяПродажа;
        Отчеты Отчеты;
        ПросмотрПродаж ПросмотрПродаж;
        ПросмотрПриходов ПросмотрПриходов;
        Управление Управление;

        public ОсновноеМеню()
        {
            InitializeComponent();

        }

        private void ОсновноеМеню_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            timer1.Enabled = true;
            label1.Text = "Сегодня " + DateTime.Now.ToLongDateString();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;

            if (User.Access == 1)
            {
                отчётыToolStripMenuItem.Visible = false;
                управлениеToolStripMenuItem.Visible = false;
            }
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = "Время: " + DateTime.Now.ToLongTimeString();
        }

        private void постоянныеКлиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (СправочникКлиенты == null || СправочникКлиенты.IsDisposed)
            {
                СправочникКлиенты = new СправочникКлиенты()
                {
                    MdiParent = this
                };
                СправочникКлиенты.Show();
            }
        }

        private void новаяПродажаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (НоваяПродажа == null || НоваяПродажа.IsDisposed)
            {
                НоваяПродажа = new НоваяПродажа()
                {
                    MdiParent = this
                };
                НоваяПродажа.Show();
            }
        }

        private void новыйПриходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Приход == null || Приход.IsDisposed)
            {
                Приход = new Приход.Приход()
                {
                    MdiParent = this
                };
                Приход.Show();
            }
        }

        private void отчётыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Отчеты == null || Отчеты.IsDisposed)
            {
                Отчеты = new Отчеты()
                {
                    MdiParent = this
                };
                Отчеты.Show();
            }
        }

        private void управлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Управление == null || Управление.IsDisposed)
            {
                Управление = new Управление()
                {
                    MdiParent = this
                };
                Управление.Show();
            }
        }
        private void просмотрДокументовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ПросмотрПродаж == null || ПросмотрПродаж.IsDisposed)
            {
                ПросмотрПродаж = new ПросмотрПродаж()
                {
                    MdiParent = this
                };
                ПросмотрПродаж.Show();
            }
        }

        private void просмотрДокументовToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ПросмотрПриходов == null || ПросмотрПриходов.IsDisposed)
            {
                ПросмотрПриходов = new ПросмотрПриходов()
                {
                    MdiParent = this
                };
                ПросмотрПриходов.Show();
            }
        }
    }
}
