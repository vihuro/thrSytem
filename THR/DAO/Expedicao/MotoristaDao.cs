using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THR.DAO.Connection;
using THR.Service.CustonException;

namespace THR.DAO.Expedicao
{
    internal class MotoristaDao
    {
        //Conexoes Access
        private OleDbCommand cmd;
        private OleDbDataReader dr;
        private ConnectionDao con;
        private OleDbDataAdapter da;

        
        //Conexoes Postgres
        //private NpgsqlCommand cmd;
        //private NpgsqlDataReader dr;
        //private NpgsqlDataAdapter da;
        private DataTable dt;

        public MotoristaDao()
        {
            con = new ConnectionDao();
        }
        public List<string> Motorista()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "SELECT * FROM tab_Motoristas ORDER BY NOME ASC";
            try
            {
                List<string> Motoristas = new List<string>();
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Motoristas.Add(dr["Nome"].ToString());
                    }
                }
                return Motoristas;
            }
            catch (Exception ex)
            {

                throw new ServiceException(ex.Message);
            }
            finally
            {
                con.Desconectar();
            }
        }
    }
}
