using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THR.Service.CustonException
{
    internal class ServiceException : Exception
    {
        public ServiceException(String msg) : base(msg)
        {

        }
    }
}
