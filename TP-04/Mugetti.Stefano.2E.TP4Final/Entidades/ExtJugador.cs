using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ExtJugador
    {
        /// <summary>
        /// Si el jugador juega en boca, se le aumentara el valor
        /// </summary>
        /// <param name="jdr">Jugador a aumentar el valor</param>
        /// <param name="valor">Valor a aumentar</param>
        public static void AumentarValorJugadorBoca(this Jugador jdr)
        {
            jdr.Valor += 1000001;
        }
    }
}
