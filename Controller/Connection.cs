using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace SisVendas.Controller
{
    internal class Connection
    {
        static string Server = "localhost";
        static string Port = "5432";
        static string User = "postgres";
        static string Password = "123";
        static string Database = "sisVendasDB";

        NpgsqlConnection conn = null;

        string connString = "Server=" + Server + ";Port=" + Port + ";UserID=" + User + ";password=" + Password + ";Database=" + Database + ";";

        public NpgsqlConnection conectaPG()
        {
            try
            {
                conn = new NpgsqlConnection(connString);
                conn.Open();
                return conn;
            }
            catch (NpgsqlException erro)
            {
                return null;
            }

        }

        public NpgsqlConnection desconectaPG()
        {
            try
            {
                conn = new NpgsqlConnection(connString);
                conn.Close();
                return conn;
            }
            catch (NpgsqlException erro)
            {
                return null;
            }
        }
    }
}
