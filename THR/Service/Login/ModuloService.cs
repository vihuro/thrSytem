using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THR.DAO.Login;
using THR.Service.CustonException;
using THR.Controller.Login;
using THR.Model.Login;
using THR.Dto.Login;
using System.Data;

namespace THR.Service.Login
{
    internal class ModuloService
    {
        private ModuloDao dao;
        private ModuloModel model;
        private List<string> access;

        public ModuloService()
        {
            this.dao = new ModuloDao();
        }

        public DataTable Access(ModuloDto dto)
        {
            model = new ModuloModel();
            model.Apelido = dto.Apelido;
            return dao.Access(model);
        }


        public bool DefinirAcessos(DataTable dt,string modulo)
        {
            access = new List<string>();


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                access.Add(dt.Rows[i]["Modulo"].ToString());
            }



            foreach (var teste in access)
            {

                if (teste == modulo)
                {
                    return true;

                }

            }
            return false;
        }
        public string[] ListaAcessos()
        {
            string[] Permissoes = new string[]
            {
            "Expedição - Admin",
            "Expedição - Externo",
            "Expedição - Planejador",
            "Expedição - Comunicador",
            "Expedição - Painel",
            "Estoque - Admin",
            "Manutenção - Admin"
            };

            return Permissoes;
        }
    }

}
