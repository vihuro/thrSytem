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
using THR.Service.Expedicao;

namespace THR.DAO.Expedicao
{
    internal class RegiaoDao
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

        public RegiaoDao()
        {
            con = new ConnectionDao();
        }

        public List<string> Regiao()
        {
            List<string> Regiao = new List<string>();
            cmd = new OleDbCommand();
            cmd.CommandText = "SELECT * FROM tab_Regiao ORDER BY Regiao ASC";
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                       Regiao.Add(dr["Regiao"].ToString());
                    }
                }
                return Regiao;
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
