using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWorld.Base.Classes
{/// <summary>
/// Класс для постоянных данных
/// </summary>
    static class Data
    {

        /// <summary>
        /// Строка подключения к базе данных.
        /// </summary>
        public static string ConnectionString = @"Data Source=III\SQLEXPRESS01;Initial Catalog=BookWorld;Integrated Security=True";
        
        /// <summary>
        ///Размер наценки на поступающие товары. 
        /// </summary>
        public static decimal Percentage = 1.7M;

        /// <summary>
        /// Размер скидки для постоянных покупателей.
        /// </summary>
        public static double Discount = 0.95;
        /// <summary>
        /// Для передачи номера карты клиента обратно на форму.
        /// </summary>
        public static int numberOfCard=0;

        public static double priceOfBuy=0;
    }
}
