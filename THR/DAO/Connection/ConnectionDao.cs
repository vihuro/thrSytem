using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THR.DAO.Connection
{
    internal class ConnectionDao
    {
        private OleDbConnection conn = new OleDbConnection();
        private string connection;

        public ConnectionDao()
        {
            connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\thr\\source\\repos\\THR\\bd_THR.accdb";

            conn.ConnectionString = connection;
        }
        public OleDbConnection conectar()
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
