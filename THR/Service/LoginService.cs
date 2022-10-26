using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THR.DAO;
using THR.Service.CustonException;
using THR.Dto.Login;
using THR.Controller.Login;
using THR.Model.Login;
using System.Data;

namespace THR.Service.Login
{
    internal class LoginService
    {
        private LoginDao dao;
        private LoginModel model;
        private ModuloDto moduloDto;
        private ModuloService moduloService;
        public LoginService()
        {
            dao = new LoginDao();
            model = new LoginModel();
            moduloService = new ModuloService();
        }
        public DataTable Verify(LoginDto dto)
        {
            model.Apelido = dto.Apelido;
            model.Senha = dto.Senha;
            if (dao.Verify(model))
            {
                moduloDto = new ModuloDto();
                moduloDto.Apelido = model.Apelido;

                dto.NomeUsuario = model.NomeUsuario;

                return moduloService.Access(moduloDto);

            }
            else
            {
                throw new ServiceException("Usuário ou senha inválidos!");
            }
        }
    }
}
