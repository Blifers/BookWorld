using BookWorld.Base.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWorld.Base
{
    /// <summary>
    /// Осуществляет выполнение базовых операций
    /// </summary>
    public static class StaticProcesser
    {
        /// <summary>
        /// Хеширование строки
        /// </summary>
        /// <param name="input">Текст для хеширования</param>
        /// <param name="algorithm">Алгоритм</param>
        /// <returns>Возвращает захешированную строку</returns>
        public static string ComputeHash(string input,HashAlgorithm algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);
            
            return BitConverter.ToString(hashedBytes);
        }

        public static SqlConnection Connection = new SqlConnection(Data.ConnectionString);

        /// <summary>
        /// Получение массива данных из запроса
        /// </summary>
        /// <param name="commandText">Текст запроса</param>
        /// <param name="p1">Первый параметр</param>
        /// <returns>Объект SqlReader с данными</returns>
        public static SqlDataReader GetReader(string commandText, SqlParameter p1)
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandText = commandText;
            Command.Parameters.Add(p1);
            Connection.Open();
            SqlDataReader reader = Command.ExecuteReader();
            return reader;
        }

        public static int GetAmountOfRecords(string commandText)
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandText = commandText;
            Connection.Open();
            int amount = Command.ExecuteNonQuery();
            Connection.Close();
            return amount;
        }
        public static int GetAmountOfRecords(string commandText,SqlParameter p1)
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandText = commandText;
            Command.Parameters.Add(p1);
            Connection.Open();
            int amount = Command.ExecuteNonQuery();
            Connection.Close();
            return amount;
        }
        public static void CloseConnection()
        {
            Connection.Close();
        }
    }
}
