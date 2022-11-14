using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THR.DAO.Expedicao;
using THR.Model.Expedicao;
using THR.Dto.Expedicao;
using THR.Service.CustonException;
using System.Data;
using THR.Dto.Login;

namespace THR.Service.Expedicao
{
    internal class CoresPainelControleCarregamentosService
    {
        private CoresPainelControleCarregamentosDao dao;
        private CoresPainelControleCarregamentosModel model;
        private LoginDto loginDto;
        public CoresPainelControleCarregamentosService(LoginDto loginDto)
        {
            dao = new CoresPainelControleCarregamentosDao();
            this.loginDto = loginDto;
        }

        public void BuscarCores(CoresPainelControleCarregamentosDto dto, string idVariavel)
        {
            model = new CoresPainelControleCarregamentosModel();
            model.Coluna = dto.Coluna;
            model.PalavraChave = dto.PalavraChave;
            model.RCelula = dto.RCelula;
            model.GCelula = dto.GCelula;
            model.BCelula = dto.BCelula;
            model.RLetra = dto.RLetra;
            model.GLetra = dto.GLetra;
            model.BLetra = dto.BLetra;
            model.Condicao = dto.Condicao;
            model.Valor = dto.Valor;
            model.Id = dto.Id;
            model.UsuarioCadastro = loginDto.NomeUsuario;
            model.DataHoraCadastro = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));

            if (idVariavel != "")
            {
                dao.UpdateCondicao(model);
            }
            else
            {
                if(dto.Coluna != "Capacidade" && 
                   dto.Coluna != "PorcentagemCarregada" && 
                   dto.Coluna != "PesoTotal" && 
                   dto.Coluna != "DataHoraLancamento")
                {
                    if (dao.Exits(model))
                    {
                        dao.Update(model);
                    }
                    else
                    {
                        dao.Insert(model);
                    }
                }
                else
                {
                    dao.Insert(model);
                }

            }
        }

        public DataTable SelectTableColors()
        {
            return dao.SelectTableColors();
        }
    }
}
