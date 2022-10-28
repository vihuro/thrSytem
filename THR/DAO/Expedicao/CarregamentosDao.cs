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
        private OleDbCommand cmd;
        private OleDbDataReader dr;
        private ConnectionDao con;
        private OleDbDataAdapter da;
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
                cmd.Connection = con.conectar();
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
                                                        "DataHoraFim = @DataHoraFim where " +
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
            cmd.Parameters.AddWithValue("", model.NumeroCarregamento);


            try
            {
                cmd.Connection = con.conectar();
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

        public DataTable SelectTable()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tab_Carregamentos order by numeroCarregamento asc";
            try
            {
                cmd.Connection = con.conectar();
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
