using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWorld.Base.Classes
{
    public static class StaticHelper
    {
        public static void ErrorNotifier(Exception ex)
        {
            MessageBox.Show("Что-то пошло не так \n\n" + ex.Message);
        }
    }
}
