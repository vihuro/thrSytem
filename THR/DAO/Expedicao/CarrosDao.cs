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
    internal class CarrosDao
    {
        private OleDbCommand cmd;
        private OleDbDataReader dr;
        private ConnectionDao con;
        private OleDbDataAdapter da;
        private DataTable dt;


        public CarrosDao()
        {
            con = new ConnectionDao();
        }

        public List<string> Carros()
        {
            cmd = new OleDbCommand();
            List<string> carros = new List<string>();
            cmd.CommandText = "Select * from tab_Carros order by TipoCarro asc";
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        carros.Add(dr["TipoCarro"].ToString());
                    }
                }
                return carros;
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

        internal string BuscarCapacidade(string caminhao)
        {
            cmd = new OleDbCommand();
            string Capacidade = "";
            cmd.CommandText = "SELECT * FROM tab_Carros where tipoCarro = @Capacidade";
            cmd.Parameters.AddWithValue("", caminhao);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Capacidade = dr["CapacidadeCarro"].ToString();
                    }
                }
                return Capacidade;
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
