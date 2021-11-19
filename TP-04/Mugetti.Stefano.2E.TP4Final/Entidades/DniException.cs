using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DniException:Exception
    {
        public DniException(string msj):base(msj)
        {
            
        }
    }
}