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
    public static class StaticProcesser
    {
        public static string ComputeHash(string input,HashAlgorithm algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);
            
            return BitConverter.ToString(hashedBytes);
        }

        public static SqlConnection Connection = new SqlConnection(Data.ConnectionString);

        public static SqlDataReader ExecuteCommand(string commandText, SqlParameter p1)
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandText = commandText;
            SqlParameter par1 = p1;
            Command.Parameters.Add(par1);
            Connection.Open();
            SqlDataReader reader = Command.ExecuteReader();
            return reader;
        }
        public static void CloseConnection()
        {
            Connection.Close();
        }
    }
}
