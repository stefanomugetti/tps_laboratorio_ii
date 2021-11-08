using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validaciones
    {
        #region Validaciones Solo Jugadores/Personas

        /// <summary>
        /// Valida que la cadena pasada por parametro sea un dni valido
        /// </summary>
        /// <param name="dni">Cadena a validar</param>
        /// <returns>true si es valido, de lo contario false</returns>
        public static bool DniValido(long dni)
        {
            string dniString = dni.ToString();
            char aux = 'x';
            if (dniString.Length > 6 && dniString.Length < 9)
            {
                for (int i = 0; i < dniString.Length; i++)
                {
                    aux = dniString[i];
                    if (!char.IsNumber(aux))
                        return false;
                }
            }
            else
                return false;

            return true;
        }
        /// <summary>
        /// Valida que la edad pasada por parametro sea una edad valida para un jugador profesional
        /// </summary>
        /// <param name="edad"> numero a validar </param>
        /// <returns>true si es valido, de lo contario false</returns>
        public static bool EdadValida(int edad)
        {
            if (edad > 14 && edad < 50)
                return true;

            return false;
        }

        /// <summary>
        /// Valida que la altura pasada por parametro sea una altura valida para un jugador profesional
        /// </summary>
        /// <param name="altura">numero a validar</param>
        /// <returns>true si es valido, de lo contario false</returns>
        public static bool AlturaValida(double altura)
        {
            if (altura > 1.5 && altura < 2.1)
                return true;

            return false;
        }
        /// <summary>
        /// Valida que el peso pasada por parametro sea una peso valida para un jugador profesional
        /// </summary>
        /// <param name="peso">numero a validar</param>
        /// <returns>true si es valido, de lo contario false</returns>
        public static bool PesoValida(double peso)
        {
           if (peso > 55.1 && peso < 100.1)
                return true;

            return false;
        }

        /// <summary>
        /// Valida que la cadena parsada por parametro sea un pie habil valido
        /// </summary>
        /// <param name="pieHabil">cadena a analizar</param>
        /// <returns>true si es valido, de lo contrario false</returns>
        public static bool PieHabilValido(string pieHabil)
        {
            if (pieHabil.ToLower() == "izquierdo" || pieHabil.ToLower() == "derecho")
                return true;

            return false;
        }
        /// <summary>
        /// Valida que la cadena pasada por parametr sea una posicion valida
        /// </summary>
        /// <param name="posicion">cadena a validar</param>
        /// <returns>true si es valido, de lo contrario false</returns>
        public static bool PosicionValida(string posicion)
        {
            if (posicion.ToLower() == "arquero" || posicion.ToLower() == "defensa" || posicion.ToLower() == "delantero" || posicion.ToLower() == "mediocampista")
                return true;

            return false;
        }
        /// <summary>
        /// Valida que el valor pasado por parametro del jugador sea valido
        /// </summary>
        /// <param name="valor">valor a validar</param>
        /// <returns>true si es valido, de lo contrario false</returns>
        public static bool ValorValido(double valor)
        {
            if (valor > 100.1 && valor < 900000000.1)
                return true;

            return false;
        }
        #endregion

        #region Validaciones solo Equipos
        /// <summary>
        /// Valida que el año de creacion pasado por parametro sea valido
        /// </summary>
        /// <param name="año">(int)año a validar</param>
        /// <returns>true si es valido, de lo contrario false</returns>
        public static bool AñoCreacionValido(int año)
        {
            if (año > 1820 && año < 2021)
                return true;

            return false;
        }
        /// <summary>
        /// Valida que el valor pasado por parametro del equipo sea valido
        /// </summary>
        /// <param name="valor">valor a validar</param>
        /// <returns>true si es valido, de lo contrario false</returns>
        public static bool ValorEquipoValido(double valor)
        {
            if (valor > 1000000.1 && valor < 30000000000.1)
                return true;

            return false;
        }
        /// <summary>
        /// Valida que el equipo pasado por parametro no se repita
        /// </summary>
        /// <param name="club">Equipo a validar</param>
        /// <returns>true si el equipo ya esta, de lo contrario false</returns>
        public static bool EquipoValido(Equipo club)
        {
            return Liga.ObtenerLista().Contains(club);
        }

        //usada para nombres y apellidos
        /// <summary>
        /// Valida que la cadena pasada por parametro sea un solo letras
        /// </summary>
        /// <param name="cadena">Cadena a validar</param>
        /// <returns>False si no es valido, true si es solo letras</returns>
        public static bool SoloString(string cadena)
        {
            char letra = 'x';
            for (int i = 0; i < cadena.Length; i++)
            {
                letra = cadena[i];
                if (!char.IsLetter(letra))
                    return false;
            }
            return true;
        }
        #endregion
    }
}
