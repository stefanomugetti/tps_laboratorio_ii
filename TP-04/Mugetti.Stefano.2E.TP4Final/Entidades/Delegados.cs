﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Delegados
    {
        public delegate void HoraDelMenu();
        public delegate void CargaDeDatosJugadores();
        public delegate void AumentarValorEquipo(double valorAgregar);
    }
}
