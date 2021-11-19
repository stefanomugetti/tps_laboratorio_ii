using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FormTPFinal
{
    public partial class Frm_Equipo : Form
    {
        public Frm_Equipo()
        {
            InitializeComponent();
            this.dtgv_Lista.AllowUserToAddRows = false;
            this.CargarLista();
        }

        /// <summary>
        /// Abre el formulario modal para crear un equipo.
        /// </summary>
        private void btn_Crear_Click(object sender, EventArgs e)
        {
            Frm_AltaEquipo form = new Frm_AltaEquipo();
            form.ShowDialog();
            this.LimpiarLista();
            this.CargarLista();
        }
        /// <summary>
        /// Carga toda la lista completa
        /// </summary>
        private void btn_RestaurarLista_Click(object sender, EventArgs e)
        {
            this.LimpiarLista();
            this.CargarLista();
        }
        /// <summary>
        /// Abre el formulario modal de modificacion de equipo con los datos cargados
        /// </summary>
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (ObtenerEquipoElegido() != null)
            {
                Frm_ModificarEquipo form = new Frm_ModificarEquipo(ObtenerEquipoElegido());
                form.ShowDialog();
                this.LimpiarLista();
                this.CargarLista();
            }
        }

        /// <summary>
        /// Elimina el equipo y todos sus jugadores(seleccionado en el dtgv) 
        /// </summary>
        private void btn_Elimina_Click(object sender, EventArgs e)
        {
            Equipo equipo = ObtenerEquipoElegido();
            if (equipo != null)
            {
                if (MessageBox.Show($"¿Esta seguro que desea eliminar el equipo {equipo.Nombre}?\n No se recuperaran los datos.", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    equipo.EliminarJugadores();
                    Liga.EliminarEquipo(equipo);
                    DBConnection.EliminarEquipo(equipo.Nombre);
                    this.LimpiarLista();
                    this.CargarLista();
                }
            }
        }
        /// <summary>
        /// Guarda los equipos existentes en el dtgv
        /// </summary>
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string nombre;
            List<Equipo> EquiposFiltrados = new List<Equipo>();
            Equipo equipo = new Equipo();
            for (int i = 0; i < dtgv_Lista.Rows.Count; i++)
            {
                nombre = dtgv_Lista.Rows[i].Cells[0].Value.ToString();
                if (nombre != null)
                {
                    equipo = Liga.ObtenerEquipo(nombre);
                    if (equipo != null)
                    {
                        EquiposFiltrados.Add(equipo);
                    }
                }
            }
            if (EquiposFiltrados.Count > 0)
                equipo.GuardarListaCsv(EquiposFiltrados, this.cmb_FiltrarPor.Text);

        }
        /// <summary>
        /// Limpia todo el dtgv
        /// </summary>
        private void LimpiarLista()
        {
            this.dtgv_Lista.Rows.Clear();
        }
        #region Funcionalidad filtrados

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
            string filtrarPor = this.cmb_FiltrarPor.Text;
            switch (filtrarPor.ToLower())
            {
                case "valor":
                    this.DesactivarComboBox();
                    this.cmb_FiltrarPorValor.Visible = true;
                    break;
                case "jugadores":
                    this.DesactivarComboBox();
                    this.cmb_FiltrarPorCantJdr.Visible = true;
                    break;
                case "año de fundacion":
                    this.DesactivarComboBox();
                    this.cmb_FiltrarPorFundacion.Visible = true;
                    break;
            }
        }
        /// <summary>
        /// Se encarga de desactivar la visilidad de los combo box 
        /// </summary>
        public void DesactivarComboBox()
        {
            this.cmb_FiltrarPorFundacion.Visible = false;
            this.cmb_FiltrarPorCantJdr.Visible = false;
            this.cmb_FiltrarPorValor.Visible = false;
        }
        private void cmb_FiltrarPorCantJdr_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.FiltrarPorCantJdr();
        }
        private void cmb_FiltrarPorFundacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FiltrarPorFundacion();
        }
        private void cmb_FiltrarPorValor_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FiltrarPorValor();
        }
        /// <summary>
        /// Filtra por lo elegido en el combo box y lo muestra en el dtgv
        /// </summary>
        private void FiltrarPorCantJdr()
        {
            List<Equipo> equipos = Liga.ObtenerLista();
            if (equipos != null)
            {
                this.LimpiarLista();
                int.TryParse(this.cmb_FiltrarPorCantJdr.Text, out int cantJdr);
                foreach (Equipo item in equipos)
                {
                    if (item.ObtenerCantJrs() >= cantJdr)
                    {
                        ; this.dtgv_Lista.Rows.Add(item.Nombre, item.Valor.ToString(), item.AñoCreacion.ToString(), item.ObtenerListaJugadores().Count().ToString());
                    }
                }
            }
        }
        /// <summary>
        /// Filtra por lo elegido en el combo box y lo muestra en el dtgv
        /// </summary>
        private void FiltrarPorValor()
        {
            List<Equipo> equipos = Liga.ObtenerLista();
            if (equipos != null)
            {
                this.LimpiarLista();
                double.TryParse(this.cmb_FiltrarPorValor.Text.Trim(), out double valor);
                foreach (Equipo item in equipos)
                {
                    if (item.Valor >= valor)
                    {
                        this.dtgv_Lista.Rows.Add(item.Nombre, item.Valor.ToString(), item.AñoCreacion.ToString(), item.ObtenerListaJugadores().Count().ToString());
                    }
                }
            }
        }
        /// <summary>
        /// Filtra por lo elegido en el combo box y lo muestra en el dtgv
        /// </summary>
        private void FiltrarPorFundacion()
        {
            List<Equipo> equipos = Liga.ObtenerLista();
            if (equipos != null)
            {
                this.LimpiarLista();
                int.TryParse(this.cmb_FiltrarPorFundacion.Text, out int añoCreacion);
                foreach (Equipo item in equipos)
                {
                    if (item.AñoCreacion >= añoCreacion)
                    {
                        this.dtgv_Lista.Rows.Add(item.Nombre, item.Valor.ToString(), item.AñoCreacion.ToString(), item.ObtenerListaJugadores().Count().ToString());
                    }
                }
            }
        }
        #endregion
        /// <summary>
        /// Carga el dtgv con los datos de los equipos
        /// </summary>
        private void CargarLista()
        {
            List<Equipo> equipos = Liga.ObtenerLista();
            if (equipos != null)
            {
                foreach (Equipo item in equipos)
                {
                    this.dtgv_Lista.Rows.Add(item.Nombre, item.Valor.ToString(), item.AñoCreacion.ToString(), item.ObtenerCantJrs());
                }
            }
        }
        /// <summary>
        /// Busca el equipo elegido en el dtgv
        /// </summary>
        /// <returns>El equipo elegido, de lo contrario null</returns>
        private Equipo ObtenerEquipoElegido()
        {
            if (Liga.ObtenerLista() != null && dtgv_Lista.Rows.Count > 0)
            {
                string nombre = this.dtgv_Lista.CurrentRow.Cells[0].Value.ToString();//TOMA EL ID DEL RENGLON QUE SE SELECCIONE ([0])
                Equipo equipo = Liga.ObtenerEquipo(nombre);
                if (equipo != null)
                {
                    return equipo;
                }
            }
            return null;
        }
    }
}
