using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWorld.Base.Classes
{
    static class Data
    {

        /// <summary>
        /// Строка подключения к базе данных.
        /// </summary>
        public static string ConnectionString = @"Data Source=III\SQLEXPRESS01;Initial Catalog=BookWorld;Integrated Security=True";
 
        /// <summary>
        /// Для передачи номера карты клиента обратно на форму.
        /// </summary>
        public static int numberOfCard=0;

        public static double priceOfBuy=0;
    }
}
