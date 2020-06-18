using BookWorld.Base.Classes;
using System;
using System.Collections.Generic;
using System.Data;
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
            Command.Parameters.Clear();
            return reader;
        }
        public static SqlDataReader GetReader(string commandText)
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandText = commandText;
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
            Command.Parameters.Clear();
            return amount;
        }

        public static void ExecuteCommand (string commandText,SqlParameter p1, SqlParameter p2, SqlParameter p3, SqlParameter p4, SqlParameter p5)
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandText = commandText;
            Command.Parameters.Add(p1);
            Command.Parameters.Add(p2);
            Command.Parameters.Add(p3);
            Command.Parameters.Add(p4);
            Command.Parameters.Add(p5);
            Connection.Open();
            Command.ExecuteNonQuery();
            Connection.Close();
            Command.Parameters.Clear();
        }
        public static void ExecuteCommand(string commandText, SqlParameter p1, SqlParameter p2)
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandText = commandText;
            Command.Parameters.Add(p1);
            Command.Parameters.Add(p2);
            Connection.Open();
            Command.ExecuteNonQuery();
            Connection.Close();
            Command.Parameters.Clear();
        }
        public static void ExecuteCommand(string commandText, SqlParameter p1, SqlParameter p2, SqlParameter p3, SqlParameter p4)
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandText = commandText;
            Command.Parameters.Add(p1);
            Command.Parameters.Add(p2);
            Command.Parameters.Add(p3);
            Command.Parameters.Add(p4);
            Connection.Open();
            Command.ExecuteNonQuery();
            Connection.Close();
            Command.Parameters.Clear();
        }
        public static void ExecuteCommand(string commandText, SqlParameter p1, SqlParameter p2, SqlParameter p3)
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandText = commandText;
            Command.Parameters.Add(p1);
            Command.Parameters.Add(p2);
            Command.Parameters.Add(p3);
            Connection.Open();
            Command.ExecuteNonQuery();
            Connection.Close();
            Command.Parameters.Clear();
        }

        public static void FillDataGrid(string command,DataGridView dataGrid)
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandText = command;
            SqlDataAdapter Adapter = new SqlDataAdapter(Command);
            DataTable dt = new DataTable();
            Adapter.Fill(dt);
            dataGrid.DataSource = dt;
        }

        public static void FillDataGrid(string command,SqlParameter p1, DataGridView dataGrid)
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandText = command;
            Command.Parameters.Add(p1);
            SqlDataAdapter Adapter = new SqlDataAdapter(Command);
            DataTable dt = new DataTable();
            Adapter.Fill(dt);
            dataGrid.DataSource = dt;
            Command.Parameters.Clear();
        }

        public static void CloseConnection()
        {
            Connection.Close();
        }
    }
}
