using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormTPFinal
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
            try
            {
               Liga.Harcodeo();
            }
            catch (DniException)
            {
                MessageBox.Show("Error en DNI harcodeo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Frm_Liga formInicio = new Frm_Liga();
            this.AbrirForm(formInicio);
        }
        /// <summary>
        /// Pide confirmacion para salir
        /// </summary>
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro?", "Cerrar sesion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();

        }
        /// <summary>
        /// Abre el form "Frm_Jugadores" en el panel
        /// </summary>
        private void btn_Jugadores_Click(object sender, EventArgs e)
        {
            Frm_Jugadores form = new Frm_Jugadores();
            this.AbrirForm(form);
        }

        /// <summary>
        /// Abre el form "Frm_Liga" en el panel
        /// </summary>
        private void btn_Liga_Click(object sender, EventArgs e)
        {
            Frm_Liga formLiga = new Frm_Liga();
            this.AbrirForm(formLiga);
        }
        /// <summary>
        /// Abre el form "Frm_Equipos" en el panel
        /// </summary>
        private void btn_Equipos_Click(object sender, EventArgs e)
        {
            Frm_Equipo formEquipo = new Frm_Equipo();
            this.AbrirForm(formEquipo);
        }

        /// <summary>
        /// Abre el form "Frm_Informes" en el panel
        /// </summary>

        private void btn_Informes_Click(object sender, EventArgs e)
        {
            Frm_Informes form = new Frm_Informes();
            this.AbrirForm(form);
        }

        /// <summary>
        /// Metodo para abrir formularios dentro del panel
        /// </summary>
        /// <param name="formulario">formulario a abrir</param>
        private void AbrirForm(object formulario)
        {
            try
            {
                if (formulario != null)
                {
                    if (this.pnl_Formularios.Controls.Count > 0)
                        this.pnl_Formularios.Controls.RemoveAt(0);

                    Form form = (Form)formulario;
                    form.TopLevel = false;
                    form.Dock = DockStyle.Fill;
                    this.pnl_Formularios.Controls.Add(form);
                    this.pnl_Formularios.Tag = form;
                    form.Show();
                }
            }
            catch (Exception e)
            {
                string log = e.Message;
                Console.Beep();
            }
        }
    }
}
