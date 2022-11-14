using System;
using THR.Model.Expedicao;
using THR.Dto.Expedicao;
using THR.Service.CustonException;
using THR.DAO.Expedicao;
using THR.Dto.Login;
using System.Data;
using THR.Service.Login;

namespace THR.Service.Expedicao
{
    internal class CarregamentosService
    {
        private CarregamentosDao dao;
        private CarregamentosModel model;
        private LoginDto loginDto;
        private CarrosService carrosService;
        private DataTable dt;
        private ModuloService modulosService;
        public CarregamentosService(LoginDto loginDto, DataTable dt)
        {
            dao = new CarregamentosDao();
            carrosService = new CarrosService();
            this.loginDto = loginDto;
            this.dt = dt;
            this.modulosService = new ModuloService();
        }
        public void Insert(CarregamentosDto dto)
        {
            model = new CarregamentosModel();
            if (dto.NumeroRomaneio != null && dto.NomeMotorista != null &&  dto.Regiao != null && 
                dto.Regiao != null && dto.Periodo != null && dto.Bolha != null && dto.Ondulado != null &&
                dto.PesoTotal != null && dto.Caminhao != null && dto.PesoTotal != string.Empty)
            {

                double peso = Convert.ToDouble(dto.PesoTotal);

                model.NumeroRomaneio = dto.NumeroRomaneio;
                model.NomeMotorista = dto.NomeMotorista;
                model.Regiao = dto.Regiao;
                model.Periodo = dto.Periodo;
                model.Bolha = dto.Bolha;
                model.Ondulado = dto.Ondulado;
                model.Caminhao = dto.Caminhao;
                model.Capacidade = carrosService.BuscarCapacidade(dto.Caminhao);
                model.UsuarioLancamento = loginDto.NomeUsuario;
                model.DataHoraLancamento = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                model.Status = "EM ABERTO";
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
            //preciso buscar no banco de dados se o pedido já está finalizado antes de alterar
            //Se estiver finalizado, não posso fazer alteração nele
            model = new CarregamentosModel();
            if (dto.NumeroCarregamento != null && dto.NumeroRomaneio != null && dto.NomeMotorista != null && 
                dto.Regiao != null && dto.Periodo != null && dto.Bolha != null && dto.Ondulado != null && 
                dto.PesoTotal != null && dto.Caminhao != null && dto.PesoTotal != string.Empty)
            {
                model.NumeroCarregamento = dto.NumeroCarregamento;

                double peso = Convert.ToDouble(dto.PesoTotal);

                model.NumeroRomaneio = dto.NumeroRomaneio;
                model.NomeMotorista = dto.NomeMotorista;
                model.Regiao = dto.Regiao;
                model.Periodo = dto.Periodo;
                model.Bolha = dto.Bolha;
                model.Ondulado = dto.Ondulado;
                model.TempoEspera = TempoEspera(Convert.ToDateTime(dto.DataHoraLancamento), DateTime.Now);
                model.UsuarioFinalizacao = loginDto.NomeUsuario;
                model.DataHoraFinalizacao = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                model.Status = dto.Status;
                model.PesoTotal = Convert.ToString(peso.ToString("###,###.##"));

                var status = dao.VerificarStatus(model);

                var lista = modulosService.ListaAcessos();

                if (status != "FECHADO" || status != "BLOQUEADO")
                {
                    for(int i = 0; i < lista.Length; i++)
                    {
                        if (modulosService.DefinirAcessos(dt, lista[i]))
                        {
                            if (lista[i] == "Expedição - Admin" || lista[i] == "Expedição - Comunicador")
                            {
                                dao.Update(model);
                                break;
                            }
                            else if (i == lista.Length - 1)
                            {
                                throw new ServiceException("Esse usuário não tem acesso para fazer essa alteração!");
                                break;
                            }
                        }
                    }

                }
                else
                {
                    dao.Update(model);
                }

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

        internal string TempoEspera(DateTime dateTime, DateTime now)
        {
            TimeSpan Conta = dateTime - now;


            string Horas = Convert.ToString(Conta.ToString("hh"));
            string Minutos =  Convert.ToString(Conta.ToString("mm"));
            string Resultado = $"{Horas}:{Minutos}";

            return Resultado;
        }
        internal string Porcentagem(string QuantidadeEsperada, string QuantidadeCarregada)
        {
            double CapacidadeCarro = Convert.ToDouble(QuantidadeEsperada);
            double PesoTotal = CapacidadeCarro * 100 / Convert.ToDouble(QuantidadeCarregada);

            string Valor = Convert.ToString(PesoTotal.ToString("F")) + " %";

            return Valor;
        }
    }
}
