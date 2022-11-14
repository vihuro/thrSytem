using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THR.Dto.Expedicao;
using THR.Service.Expedicao;
using THR.Dto.Login;
using System.Data;

namespace THR.Controller.Expedicao
{
    internal class CarregamentosController
    {
        public LoginDto logingDto;
        public CarregamentosService service;
        public CarregamentosController(LoginDto logingDto, DataTable dt)
        {
            this.logingDto = logingDto;
            this.service = new CarregamentosService(logingDto,dt);

        }
        public void Insert(CarregamentosDto dto)
        {
            service.Insert(dto);
        }
        public void Update(CarregamentosDto dto)
        {
            service.Update(dto);
        }
        public DataTable SelectTable()
        {
            return service.SelectTable();
        }
    }
}
