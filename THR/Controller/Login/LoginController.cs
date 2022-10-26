using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THR.Service;
using THR.Dto.Login;
using THR.Service.CustonException;
using THR.Service.Login;
using System.Data;

namespace THR.Controller.Login
{
    public class LoginController
    {
        private LoginService service;

        public LoginController()
        {
            service = new LoginService();

        }
        public DataTable Verify(LoginDto dto)
        {
            var usuario = service.Verify(dto);

            return usuario;
        }
    }
}
