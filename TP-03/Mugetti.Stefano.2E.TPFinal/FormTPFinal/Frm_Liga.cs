using Entidades;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FormTPFinal
{
    public partial class Frm_Liga : Form
    {
        public Frm_Liga()
        {
            InitializeComponent();
            CargarDatosMejoresEquipos();
            CargarDatosMejoresJugadores();
            this.lbl_NombreLiga.Text = Liga.Nombre.ToUpper();
            this.dtgv_ListaJdr.AllowUserToAddRows = false;
            this.dtvg_Equipos.AllowUserToAddRows = false;
        }
        /// <summary>
        /// Carga los datos de los equipos mejores valorados en el data grid
        /// </summary>
        public void CargarDatosMejoresEquipos()
        {
            List<Equipo> equipo = Liga.ObtenerLista();
            if (equipo != null)
            {
                List<Equipo> equipoOrdenado = equipo.OrderByDescending(p => p.Valor).ToList();

                foreach (Equipo item in equipoOrdenado)
                {
                    this.dtvg_Equipos.Rows.Add(item.Nombre, item.AñoCreacion.ToString(), item.Valor.ToString(), item.ObtenerCantJrs());
                }
            }
        }
        /// <summary>
        /// Carga los datos de los jugadores mejores valorados en el data grid
        /// </summary>
        public void CargarDatosMejoresJugadores()
        {
            List<Jugador> listaJugadores = Equipo.ObtenerTodosLosJugadores();
            int x = 0;
            if (listaJugadores != null)
            {
                List<Jugador> listaOrdenada = listaJugadores.OrderByDescending(p => p.Valor).ToList();
                foreach (Jugador jdr in listaOrdenada)
                {
                    if(x == 10)
                    {
                        break;
                    }
                    this.dtgv_ListaJdr.Rows.Add(jdr.Nombre, jdr.Posicion, jdr.Edad.ToString(), jdr.Club, jdr.Valor.ToString());
                    x++;
                }
            }
        }


    }
}
