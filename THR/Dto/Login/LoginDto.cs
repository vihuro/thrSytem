using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THR.Dto.Login
{
    public class LoginDto
    {
        private string id;
        private string nomeUsuario;
        private string apelido;
        private string senha;

        public string Id { get => id; set => id = value; }
        public string NomeUsuario { get => nomeUsuario; set => nomeUsuario = value; }
        public string Apelido { get => apelido; set => apelido = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
