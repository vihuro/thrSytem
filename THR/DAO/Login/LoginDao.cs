using System;
using System.Data.OleDb;
using THR.DAO.Connection;
using THR.Model.Login;
using THR.Service.CustonException;
using Npgsql;

namespace THR.DAO.Login
{
    public class LoginDao
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
                cmd.Connection = con.Conectar();
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
