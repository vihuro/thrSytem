
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace THR.DAO.Connection
{
    internal class ConnectionDao
    {
        private OleDbConnection conn = new OleDbConnection();
        //private NpgsqlConnection conn = new NpgsqlConnection();
        private string connection;

        public ConnectionDao()
        {
            //connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\thr\\source\\repos\\THR\\bd_THR.accdb";

            connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=//192.168.1.238/carregamento/bd/bd_THR.accdb";

            /*connection =
                "Server=192.168.1.227;" +
                "Port=5432;" +
                "Database=THR;" +
                "UserName=postgres;" +
                "Password=teste;";*/

            conn.ConnectionString = connection;
        }
       /* public NpgsqlConnection Conectar()
        {
            conn.Open();

            return conn;
        }
        public void Desconectar()
        {
            conn.Close();
        }*/

        public OleDbConnection Conectar()
        {
            conn.Open();

            return conn;
        }
        public void Desconectar()
        {
            conn.Close();
        }
    }
}
