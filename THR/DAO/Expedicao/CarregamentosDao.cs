using Npgsql;
using System;
using System.Data;
using System.Data.OleDb;
using THR.DAO.Connection;
using THR.Model.Expedicao;
using THR.Service.CustonException;

namespace THR.DAO.Expedicao
{
    internal class CarregamentosDao
    {
        //Conexoes Access
        private OleDbCommand cmd;
        private OleDbDataReader dr;
        private ConnectionDao con;
        private OleDbDataAdapter da;

        //Conexoes  Postegres
        //private NpgsqlCommand cmd;
        //private NpgsqlDataReader dr;
        //private NpgsqlDataAdapter da;
        private DataTable dt;

        public CarregamentosDao()
        {
            this.con = new ConnectionDao();
        }
        public void Insert(CarregamentosModel model)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Insert into tab_Carregamentos (NumeroRomaneio, NomeMotorista, Regiao, Periodo, Bolha, " +
                                "Ondulado, UsuarioLancamento, DataHoraLancamento, Status, PesoTotal) Values (@NumeroRomaneio," +
                                "@NomeMotorista ,@Regiao, @Periodo, @Bolha, @Ondulado, @UsuarioLancamento, @DataHoraLancamento, " +
                                "@Status, @PesoTotal)";
            cmd.Parameters.AddWithValue("", model.NumeroRomaneio);
            cmd.Parameters.AddWithValue("", model.NomeMotorista);
            cmd.Parameters.AddWithValue("", model.Regiao);
            cmd.Parameters.AddWithValue("", model.Periodo);
            cmd.Parameters.AddWithValue("", model.Bolha);
            cmd.Parameters.AddWithValue("", model.Ondulado);
            cmd.Parameters.AddWithValue("", model.UsuarioLancamento);
            cmd.Parameters.AddWithValue("", model.DataHoraLancamento);
            cmd.Parameters.AddWithValue("", model.Status);
            cmd.Parameters.AddWithValue("", model.PesoTotal);
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
        public void Update(CarregamentosModel model)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Update tab_Carregamentos set NumeroRomaneio = @NumeroRomaneio," +
                                                        "NomeMotorista = @NomeMotorista ," +
                                                        "Regiao = @Regiao," +
                                                        "Periodo = @Periodo," +
                                                        "Bolha = @Bolha," +
                                                        "Ondulado = @Ondulado," +
                                                        "PesoTotal = @PesoTotal," +
                                                        "Status = @Status," +
                                                        "UsuarioFim = @UsuarioFim," +
                                                        "DataHoraFim = @DataHoraFim," +
                                                        "TempoEspera = @TempoEspera where " +
                                                        "NumeroCarregamento = @NumeroCarregamento";
            cmd.Parameters.AddWithValue("", model.NumeroRomaneio);
            cmd.Parameters.AddWithValue("", model.NomeMotorista);
            cmd.Parameters.AddWithValue("", model.Regiao);
            cmd.Parameters.AddWithValue("", model.Periodo);
            cmd.Parameters.AddWithValue("", model.Bolha);
            cmd.Parameters.AddWithValue("", model.Ondulado);
            cmd.Parameters.AddWithValue("", model.PesoTotal);
            cmd.Parameters.AddWithValue("", model.Status);
            cmd.Parameters.AddWithValue("", model.UsuarioFinalizacao);
            cmd.Parameters.AddWithValue("", model.DataHoraFinalizacao);
            cmd.Parameters.AddWithValue("", model.TempoEspera);
            cmd.Parameters.AddWithValue("", model.NumeroCarregamento);


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

        public string VerificarStatus(CarregamentosModel model)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "SELECT * FROM tab_Carregamentos WHERE NumeroCarregamento = @NumeroCarregamento";
            cmd.Parameters.AddWithValue("", model.NumeroCarregamento);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        return dr["status"].ToString();
                    }
                }
                return "";
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

        public DataTable SelectTable()
        {
            DateTime hoje = DateTime.Now;
            DateTime ontem = hoje.AddDays(-1);

            cmd = new OleDbCommand();
            cmd.CommandText = $"Select * from tab_Carregamentos WHERE DataHoraLancamento BETWEEN '{ontem}' " +
                               $"AND '{hoje}' order by numeroCarregamento asc";
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
