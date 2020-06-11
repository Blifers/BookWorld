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

namespace BookWorld
{
    public partial class ОсновноеМеню : Form
    {
        public ОсновноеМеню()
        {
            InitializeComponent();

        }

        private void ОсновноеМеню_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            timer1.Enabled = true;
            
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;

            this.Enabled = false;

            Авторизация f = new Авторизация();
            f.ShowDialog();
            if(User.Access==0)
            {
                try
                {
                    this.Dispose();
                }
                catch(Exception ex)
                {
                    StaticHelper.ErrorNotifier(ex);
                }
            }
            else if (User.Access == 1 || User.Access==2)
            {
                this.Enabled = true;
            }
        }
    }
}
