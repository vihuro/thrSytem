using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THR.DAO.Connection;
using THR.Service.Expedicao;
using THR.Model.Expedicao;
using THR.Service.CustonException;
using Npgsql;

namespace THR.DAO.Expedicao
{
    internal class CoresPainelControleCarregamentosDao
    {
        //Conexoes Access
        private OleDbCommand cmd;
        private OleDbDataReader dr;
        private ConnectionDao con;
        private OleDbDataAdapter da;

        //Concoes Postgres
        //private NpgsqlCommand cmd;
        //private NpgsqlDataReader dr;
        //private NpgsqlDataAdapter da;
        private DataTable dt;

        public CoresPainelControleCarregamentosDao()
        {
            con = new ConnectionDao();
        }

        public bool Exits(CoresPainelControleCarregamentosModel model)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "SELECT * FROM tab_CoresPainelControleCarregamentos WHERE Coluna = @Coluna AND" +
                " PalavraChave = @PalavraChave";
            cmd.Parameters.AddWithValue("", model.Coluna);
            cmd.Parameters.AddWithValue("", model.PalavraChave);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
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
        }

        internal void UpdateCondicao(CoresPainelControleCarregamentosModel model)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "UPDATE tab_CoresPainelControleCarregamentos SET PalavraChave = @PalavraChave," +
                                                                                "RCelula = @RCelula," +
                                                                                "GCelula = @GCelula," +
                                                                                "BCelula = @BCelula," +
                                                                                "RLetra = @RLetra," +
                                                                                "GLetra = @GLetra," +
                                                                                "BLetra = @Bletra," +
                                                                                "Condicao = @Condicao," +
                                                                                "Valor = @Valor," +
                                                                                "UsuarioCadastro = @UsuarioCadastro," +
                                                                                "DataHoraCadastro = @DataHoraCadastro " +
                                                                                "WHERE " +
                                                                                "id = @id";
            cmd.Parameters.AddWithValue("", model.PalavraChave);
            cmd.Parameters.AddWithValue("", model.RCelula);
            cmd.Parameters.AddWithValue("", model.GCelula);
            cmd.Parameters.AddWithValue("", model.BCelula);
            cmd.Parameters.AddWithValue("", model.RLetra);
            cmd.Parameters.AddWithValue("", model.GLetra);
            cmd.Parameters.AddWithValue("", model.BLetra);
            cmd.Parameters.AddWithValue("", model.Condicao);
            cmd.Parameters.AddWithValue("", model.Valor);
            cmd.Parameters.AddWithValue("", model.UsuarioCadastro);
            cmd.Parameters.AddWithValue("", model.DataHoraCadastro);
            cmd.Parameters.AddWithValue("", model.Id);
            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (ServiceException ex)
            {

                throw new ServiceException(ex.Message);
            }
            finally
            {
                con.Desconectar();
            }
        }

        public void Update(CoresPainelControleCarregamentosModel model)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "UPDATE tab_CoresPainelControleCarregamentos SET RCelula = @RCelula," +
                                                                                "GCelula = @GCelula," +
                                                                                "BCelula = @BCelula," +
                                                                                "RLetra = @RLetra," +
                                                                                "GLetra = @GLetra," +
                                                                                "BLetra = @Bletra," +
                                                                                "Condicao = @Condicao," +
                                                                                "Valor = @Valor," +
                                                                                "UsuarioCadastro = @UsuarioCadastro," +
                                                                                "DataHoraCadastro = @DataHoraCadastro " +
                                                                                "WHERE " +
                                                                                "PalavraChave = @PalavraChave AND " +
                                                                                "Coluna = @Coluna";
            cmd.Parameters.AddWithValue("", model.RCelula);
            cmd.Parameters.AddWithValue("", model.GCelula);
            cmd.Parameters.AddWithValue("", model.BCelula);
            cmd.Parameters.AddWithValue("", model.RLetra);
            cmd.Parameters.AddWithValue("", model.GLetra);
            cmd.Parameters.AddWithValue("", model.BLetra);
            cmd.Parameters.AddWithValue("", model.Condicao);
            cmd.Parameters.AddWithValue("", model.Valor);
            cmd.Parameters.AddWithValue("", model.UsuarioCadastro);
            cmd.Parameters.AddWithValue("", model.DataHoraCadastro);
            cmd.Parameters.AddWithValue("", model.PalavraChave);
            cmd.Parameters.AddWithValue("", model.Coluna);
            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (ServiceException ex)
            {

                throw new ServiceException(ex.ToString());
            }
            finally
            {
                con.Desconectar();
            }
        }
        public void Insert(CoresPainelControleCarregamentosModel model)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "INSERT INTO tab_CoresPainelControleCarregamentos (RCelula, GCelula, BCelula, PalavraChave," +
                                                                                "Condicao, Valor," +
                                                                                "RLetra, GLetra, BLetra, Coluna,UsuarioCadastro, DataHoraCadastro) " +
                                                                                "VALUES " +
                                                                                "(@RCelula, @GCelula, @BCelula, @PalavraChave," +
                                                                                "@Condicao, @Valor," +
                                                                                "@RLetra, @Gletra, @BLetra, @Coluna, @UsuarioCadastro, DataHoraCadastro)";
            cmd.Parameters.AddWithValue("", model.RCelula);
            cmd.Parameters.AddWithValue("", model.GCelula);
            cmd.Parameters.AddWithValue("", model.BCelula);
            cmd.Parameters.AddWithValue("", model.PalavraChave);
            cmd.Parameters.AddWithValue("", model.Condicao);
            cmd.Parameters.AddWithValue("", model.Valor);
            cmd.Parameters.AddWithValue("", model.RLetra);
            cmd.Parameters.AddWithValue("", model.GLetra);
            cmd.Parameters.AddWithValue("", model.BLetra);
            cmd.Parameters.AddWithValue("", model.Coluna);
            cmd.Parameters.AddWithValue("", model.UsuarioCadastro);
            cmd.Parameters.AddWithValue("", model.DataHoraCadastro);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
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

        public DataTable SelectTableColors()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "SELECT * FROM tab_CoresPainelControleCarregamentos ORDER BY ID ASC";
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
