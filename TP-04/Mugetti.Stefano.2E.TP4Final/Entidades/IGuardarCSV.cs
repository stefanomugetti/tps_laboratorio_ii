using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IGuardarCSV<T> where T:class
    {
        public bool GuardarListaCsv(List<T> list,string tipoFiltrado);
    }
}
