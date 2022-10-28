using System;
using THR.Model.Expedicao;
using THR.Dto.Expedicao;
using THR.Service.CustonException;
using THR.DAO.Expedicao;
using THR.Dto.Login;
using System.Data;

namespace THR.Service.Expedicao
{
    internal class CarregamentosService
    {
        private CarregamentosDao dao;
        private CarregamentosModel model;
        private LoginDto loginDto;
        public CarregamentosService(LoginDto loginDto)
        {
            dao = new CarregamentosDao();
            this.loginDto = loginDto;
        }
        public void Insert(CarregamentosDto dto)
        {
            model = new CarregamentosModel();
            if (dto.NumeroRomaneio != null && dto.NomeMotorista != null &&  dto.Regiao != null && dto.Regiao != null &&
                dto.Periodo != null && dto.Bolha != null && dto.Ondulado != null && dto.Status != null && dto.PesoTotal != null)
            {

                double peso = Convert.ToDouble(dto.PesoTotal);

                model.NumeroRomaneio = dto.NumeroRomaneio;
                model.NomeMotorista = dto.NomeMotorista;
                model.Regiao = dto.Regiao;
                model.Periodo = dto.Periodo;
                model.Bolha = dto.Bolha;
                model.Ondulado = dto.Ondulado;
                model.UsuarioLancamento = loginDto.NomeUsuario;
                model.DataHoraLancamento = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                model.Status = dto.Status;
                model.PesoTotal = Convert.ToString(peso.ToString("###,###.##"));
                dao.Insert(model);
            }
            else
            {
                throw new ServiceException("Campo(s) obrigatório(s) vazio(s)!");
            }

        }

        public void Update(CarregamentosDto dto)
        {
            model = new CarregamentosModel();
            if (dto.NumeroCarregamento != null && dto.NumeroRomaneio != null && dto.NomeMotorista != null && dto.Regiao != null && 
                dto.Regiao != null &&
                dto.Periodo != null && dto.Bolha != null && dto.Ondulado != null && dto.Status != null && dto.PesoTotal != null)
            {

                double peso = Convert.ToDouble(dto.PesoTotal);

                model.NumeroCarregamento = dto.NumeroCarregamento;
                model.NumeroRomaneio = dto.NumeroRomaneio;
                model.NomeMotorista = dto.NomeMotorista;
                model.Regiao = dto.Regiao;
                model.Periodo = dto.Periodo;
                model.Bolha = dto.Bolha;
                model.Ondulado = dto.Ondulado;
                model.UsuarioFinalizacao = loginDto.NomeUsuario;
                model.DataHoraFinalizacao = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                model.Status = dto.Status;
                model.PesoTotal = Convert.ToString(peso.ToString("###,###.##"));
                dao.Update(model);
            }
            else
            {
                throw new ServiceException("Campo(s) obrigatório(s) vazio(s)!");
            }

        }

        public DataTable SelectTable()
        {
            return dao.SelectTable();
        }
     
    }
}
