using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IGuardar<T> where T:class
    {
        public static bool GuardarXML(List<T> lista)
        {
            if (Archivos<T>.SerializeXML(lista))
            {
                return true;
            }
            return false;
        }

        public static List<T> CargarXML()
        {
            return Archivos<T>.DeserializeXML();
        }             
    }
}
