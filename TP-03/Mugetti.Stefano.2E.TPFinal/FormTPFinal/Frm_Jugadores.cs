using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormTPFinal
{
    public partial class Frm_Jugadores : Form
    {
        public Frm_Jugadores()
        {
            InitializeComponent();
            this.CargarLista();
            this.dtgv_Lista.AllowUserToAddRows = false;
            this.DesactivarComboBox();
        }
        /// <summary>
        /// Abre el formulario modal para crear un jugador
        /// </summary>
        private void btn_Alta_Click(object sender, EventArgs e)
        {
            Frm_AltaJugador form = new Frm_AltaJugador();
            form.ShowDialog();
            this.LimpiarLista();
            this.CargarLista();
        }
        /// <summary>
        /// Guarda los jugadores existentes en el dtgv
        /// </summary>
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string dniString;
            List<Jugador> jugadoresFiltrados = new List<Jugador>();
            Jugador jdr;
            for (int i = 0; i < dtgv_Lista.Rows.Count; i++)
            {
                dniString = dtgv_Lista.Rows[i].Cells[3].Value.ToString();
                if (dniString != null)
                {
                    jdr = Equipo.BuscarJdrPorDni(dniString);
                    if (jdr != null)
                    {
                        jugadoresFiltrados.Add(jdr);
                    }
                }
            }
            Archivos<Jugador>.ListaJdrCsv(jugadoresFiltrados, this.cmb_FiltrarPor.Text);
        }
        /// <summary>
        /// Elimina el jugador seleccionado en el dtgv
        /// </summary>
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Jugador jdr = this.ObtenerJugadorElegido();
            if (jdr != null)
            {
                if (MessageBox.Show($"¿Esta seguro que desea eliminar al jugador {jdr.Nombre}?\n No se recuperaran los datos.", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Equipo equipoDelJugador = Liga.ObtenerEquipo(jdr.Club);
                    if (equipoDelJugador != null)
                    {
                        equipoDelJugador.EliminarJugador(jdr);
                        Liga.GuardarCambios();
                        this.LimpiarLista();
                        this.CargarLista();
                    }
                }
            }
        }
        /// <summary>
        /// Abre el formulario de modificacion con los datos del jugador elegido en el dtgv
        /// </summary>
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Jugador jugadorAModif = ObtenerJugadorElegido();
            if (jugadorAModif != null)
            {
                Frm_ModificarJdr form = new Frm_ModificarJdr(jugadorAModif);
                form.ShowDialog();
                this.LimpiarLista();
                this.CargarLista();
            }
        }
        /// <summary>
        /// Restaura la lista al estado original(sin filtrados)
        /// </summary>
        private void btn_Restaurar_Click(object sender, EventArgs e)
        {
            this.LimpiarLista();
            this.CargarLista();
        }

        #region Funcionalidad de filtrados
        private void cmb_FiltrarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FiltrarPor();
        }
        /// <summary>
        /// Se encarga de activar la visilidad de los combo box segun lo elegido para filtrar
        /// </summary>
        public void FiltrarPor()
        {
            this.lbl_Max.Visible = true;
            switch (this.cmb_FiltrarPor.Text.ToLower())
            {
                case "peso":
                    this.DesactivarComboBox();
                    this.cmb_FiltrarPorPeso.Visible = true;
                    break;
                case "altura":
                    this.DesactivarComboBox();
                    this.cmb_FiltrarPorAltura.Visible = true;
                    break;
                case "pie habil":
                    this.DesactivarComboBox();
                    this.lbl_Max.Visible = false;
                    this.cmb_FiltrarPorPie.Visible = true;
                    break;
                case "valor":
                    this.DesactivarComboBox();
                    this.cmb_FiltrarPorValor.Visible = true;
                    break;
                case "edad":
                    this.DesactivarComboBox();
                    this.cmb_FiltrarPorEdad.Visible = true;
                    break;
                case "equipo":
                    this.lbl_Max.Visible = false;
                    this.DesactivarComboBox();
                    this.CargarEquipos();
                    this.cmb_Equipos.Visible = true;
                    break;
                case "nacionalidad":
                    this.lbl_Max.Visible = false;
                    this.DesactivarComboBox();
                    this.CargarNacionalidades();
                    this.cmb_FiltrarPorNacionalidad.Visible = true;
                    break;
            }
        }
        
        /// <summary>
        /// Filtra por lo elegido en el combo box y lo muestra en el dtgv
        /// </summary>
        public void FiltrarPorNacionalidad()
        {
            List<Jugador> jugadores = Equipo.ObtenerTodosLosJugadores();
            if (jugadores.Count > 0)
            {
                this.LimpiarLista();
                foreach (Jugador jdr in jugadores)
                {
                    if (jdr.Nacionalidad == cmb_FiltrarPorNacionalidad.Text)
                    {
                        this.dtgv_Lista.Rows.Add(jdr.Nombre, jdr.Apellido, jdr.Edad.ToString(), jdr.Dni.ToString(), jdr.PieHabil, jdr.Peso.ToString(), jdr.Altura.ToString(), jdr.Club, jdr.Valor.ToString(), jdr.Nacionalidad);
                    }
                }
            }
        }
        /// <summary>
        /// Filtra por lo elegido en el combo box y lo muestra en el dtgv
        /// </summary>
        public void FiltrarPorEquipo()
        {
            List<Equipo> equipos = Liga.ObtenerLista();
            if (equipos != null)
            {
                this.LimpiarLista();
                foreach (Equipo item in equipos)
                {
                    if (item.Nombre == cmb_Equipos.Text)
                    {
                        List<Jugador> jugadores = item.ObtenerListaJugadores();
                        if (jugadores != null)
                        {
                            foreach (Jugador jdr in jugadores)
                            {
                                this.dtgv_Lista.Rows.Add(jdr.Nombre, jdr.Apellido, jdr.Edad.ToString(), jdr.Dni.ToString(), jdr.PieHabil, jdr.Peso.ToString(), jdr.Altura.ToString(), item.Nombre, jdr.Valor.ToString(), jdr.Nacionalidad);
                            }
                        }
                    }
                }
            }
        }  
        /// <summary>
            /// Filtra por lo elegido en el combo box y lo muestra en el dtgv
            /// </summary>
        public void FiltrarPorPie()
        {
            List<Equipo> equipos = Liga.ObtenerLista();
            if (equipos != null)
            {
                this.LimpiarLista();
                foreach (Equipo item in equipos)
                {
                    foreach (Jugador jdr in item.ObtenerListaJugadores())
                    {
                        if (jdr.PieHabil.ToLower() == cmb_FiltrarPorPie.Text.ToLower())
                        {
                            this.dtgv_Lista.Rows.Add(jdr.Nombre, jdr.Apellido, jdr.Edad.ToString(), jdr.Dni.ToString(), jdr.PieHabil, jdr.Peso.ToString(), jdr.Altura.ToString(), item.Nombre, jdr.Valor.ToString(), jdr.Nacionalidad);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Filtra por lo elegido en el combo box y lo muestra en el dtgv
        /// </summary>
        public void FiltrarPorPeso()
        {
            List<Equipo> equipos = Liga.ObtenerLista();
            if (equipos != null)
            {
                this.LimpiarLista();
                double.TryParse(this.cmb_FiltrarPorPeso.Text, out double peso);
                foreach (Equipo item in equipos)
                {
                    foreach (Jugador jdr in item.ObtenerListaJugadores())
                    {
                        if (jdr.Peso >= peso)
                        {
                            this.dtgv_Lista.Rows.Add(jdr.Nombre, jdr.Apellido, jdr.Edad.ToString(), jdr.Dni.ToString(), jdr.PieHabil, jdr.Peso.ToString(), jdr.Altura.ToString(), item.Nombre, jdr.Valor.ToString(), jdr.Nacionalidad);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Filtra por lo elegido en el combo box y lo muestra en el dtgv
        /// </summary>
        public void FiltrarPorAltura()
        {
            List<Equipo> equipos = Liga.ObtenerLista();
            if (equipos != null)
            {
                this.LimpiarLista();
                double.TryParse(this.cmb_FiltrarPorAltura.Text, out double altura);
                foreach (Equipo item in equipos)
                {
                    foreach (Jugador jdr in item.ObtenerListaJugadores())
                    {
                        if (jdr.Altura >= altura)
                        {
                            this.dtgv_Lista.Rows.Add(jdr.Nombre, jdr.Apellido, jdr.Edad.ToString(), jdr.Dni.ToString(), jdr.PieHabil, jdr.Peso.ToString(), jdr.Altura.ToString(), item.Nombre, jdr.Valor.ToString(), jdr.Nacionalidad);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Filtra por lo elegido en el combo box y lo muestra en el dtgv
        /// </summary>
        public void FiltrarPorValor()
        {
            List<Equipo> equipos = Liga.ObtenerLista();
            if (equipos != null)
            {
                this.LimpiarLista();
                double.TryParse(this.cmb_FiltrarPorValor.Text, out double valor);
                foreach (Equipo item in equipos)
                {
                    foreach (Jugador jdr in item.ObtenerListaJugadores())
                    {
                        if (jdr.Valor >= valor)
                        {
                            this.dtgv_Lista.Rows.Add(jdr.Nombre, jdr.Apellido, jdr.Edad.ToString(), jdr.Dni.ToString(), jdr.PieHabil, jdr.Peso.ToString(), jdr.Altura.ToString(), item.Nombre, jdr.Valor.ToString(), jdr.Nacionalidad);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Filtra por lo elegido en el combo box y lo muestra en el dtgv
        /// </summary>
        public void FiltrarPorEdad()
        {
            List<Equipo> equipos = Liga.ObtenerLista();
            if (equipos != null)
            {
                this.LimpiarLista();
                int.TryParse(this.cmb_FiltrarPorEdad.Text, out int edad);

                foreach (Equipo item in equipos)
                {
                    foreach (Jugador jdr in item.ObtenerListaJugadores())
                    {
                        if (jdr.Edad >= edad)
                        {
                            this.dtgv_Lista.Rows.Add(jdr.Nombre, jdr.Apellido, jdr.Edad.ToString(), jdr.Dni.ToString(), jdr.PieHabil, jdr.Peso.ToString(), jdr.Altura.ToString(), item.Nombre, jdr.Valor.ToString(), jdr.Nacionalidad);
                        }
                    }
                }
            }
        }
        private void cmb_FiltrarPorPie_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FiltrarPorPie();
        }

        private void cmb_FiltrarPorPeso_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FiltrarPorPeso();
        }

        private void cmb_FiltrarPorAltura_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FiltrarPorAltura();
        }

        private void cmb_Equipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FiltrarPorEquipo();
        }
        private void cmb_FiltrarPorValor_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FiltrarPorValor();
        }

        private void cmb_FiltrarPorEdad_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FiltrarPorEdad();
        }

        private void cmb_FiltrarPorNacionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FiltrarPorNacionalidad();
        }
        /// <summary>
        /// Le quita la visibilidad a todos los combo box's
        /// </summary>
        public void DesactivarComboBox()
        {
            this.cmb_FiltrarPorPie.Visible = false;
            this.cmb_FiltrarPorPeso.Visible = false;
            this.cmb_FiltrarPorAltura.Visible = false;
            this.cmb_FiltrarPorValor.Visible = false;
            this.cmb_FiltrarPorEdad.Visible = false;
            this.cmb_FiltrarPorNacionalidad.Visible = false;
            this.cmb_Equipos.Visible = false;         
        }
        /// <summary>
        /// Carga todas las equipos distintas existentes en el combo box de filtrar por equipos
        /// </summary>
        public void CargarEquipos()
        {
            this.cmb_Equipos.Items.Clear();
            List<Equipo> equipos = Liga.ObtenerLista();
            if (equipos != null)
            {
                foreach (Equipo item in equipos)
                {
                    this.cmb_Equipos.Items.Add(item.Nombre);
                }
            }
        }
        /// <summary>
        /// Carga todas las nacionalidades distintas existentes en el combo box de filtrar por nacionalidad
        /// </summary>
        public void CargarNacionalidades()
        {
            this.cmb_FiltrarPorNacionalidad.Items.Clear();
            List<Jugador> jugadores = Equipo.ObtenerTodosLosJugadores();
            List<string> nacionalidadesNoRepetidas = new List<string>();
            foreach (Jugador item in jugadores)
            {
                if (!nacionalidadesNoRepetidas.Contains(item.Nacionalidad))
                {
                    nacionalidadesNoRepetidas.Add(item.Nacionalidad);
                    this.cmb_FiltrarPorNacionalidad.Items.Add(item.Nacionalidad);
                }
            }
        }
        #endregion

        /// <summary>
        /// Carga los datos de todos los jugadores al dtgv 
        /// </summary>
        public void CargarLista()
        {
            List<Equipo> equipos = Liga.ObtenerLista();
            if (equipos != null)
            {
                foreach (Equipo item in equipos)
                {
                    foreach (Jugador jdr in item.ObtenerListaJugadores())
                    {
                        this.dtgv_Lista.Rows.Add(jdr.Nombre, jdr.Apellido, jdr.Edad.ToString(), jdr.Dni.ToString(), jdr.PieHabil, jdr.Peso.ToString(), jdr.Altura.ToString(), item.Nombre, jdr.Valor.ToString(), jdr.Nacionalidad);
                    }
                }
            }
        }

        /// <summary>
        /// Elimina todos los datos de la lista
        /// </summary>
        private void LimpiarLista()
        {
            this.dtgv_Lista.Rows.Clear();
        }

       /// <summary>
        /// Obtiene el jugador elegido en el data griew list de la lista
        /// </summary>
        /// <returns>null si no es valido o el jugador si es valido</returns>
        private Jugador ObtenerJugadorElegido()
        {
            if (dtgv_Lista.RowCount > 0)
            {
                string dniElegidoString = this.dtgv_Lista.CurrentRow.Cells[3].Value.ToString();//TOMA EL ID DEL RENGLON QUE SE SELECCIONE ([0])
                if (dniElegidoString != null)
                {
                    Jugador jdr = Equipo.BuscarJdrPorDni(dniElegidoString);
                    if (jdr != null)
                    {
                        return jdr;
                    }
                }
            }
            return null;
        }
    }
}
