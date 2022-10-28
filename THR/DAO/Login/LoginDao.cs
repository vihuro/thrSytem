using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THR.DAO.Connection;
using THR.Model.Login;
using THR.Service.CustonException;

namespace THR.DAO.Login
{
    public class LoginDao
    {
        private OleDbCommand cmd;
        private OleDbDataReader dr;
        private ConnectionDao con;
        private OleDbDataAdapter da;

        public LoginDao()
        {
            this.con = new ConnectionDao();
        }

        public bool Verify(LoginModel model)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tab_Usuario where Apelido = @apelido and senha = @senha";
            cmd.Parameters.AddWithValue("",model.Apelido);
            cmd.Parameters.AddWithValue("",model.Senha);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {

                    while (dr.Read())
                    {
                        model.NomeUsuario = dr["nomeUsuario"].ToString();
                    }

                    return true;
                }

            }
            catch (Exception ex)
            {

                throw new ServiceException(ex.Message);
            }
            finally
            {
                con.Desconectar();
            }

            return false;
        }

    }
}
