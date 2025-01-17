﻿
using THR.Controller.Login;
using THR.Service.Login;
using THR.Service.CustonException;
using System.Data.OleDb;
using THR.DAO.Connection;
using System.Data;
using THR.Model.Login;
using System;
using Npgsql;

namespace THR.DAO.Login
{
    internal class ModuloDao
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
        public ModuloDao()
        {
            this.con = new ConnectionDao();
        }

        public DataTable Access(ModuloModel model)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tab_Modulos where Apelido = @Apelido order by id asc";
            cmd.Parameters.AddWithValue("", model.Apelido);
            try
            {
                cmd.Connection = con.Conectar();
                da = new OleDbDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);

                return dt;
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
