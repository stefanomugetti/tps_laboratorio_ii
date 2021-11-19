using Entidades;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTPFinal
{
    public partial class Frm_Menu : Form
    {
        private CancellationTokenSource cts;
        public Frm_Menu()
        {
            InitializeComponent();
            try
            {
                Liga.HarcodeoDatos();
                Task horaMenu = new Task(CambiarHora);
                horaMenu.Start();
                cts = new CancellationTokenSource();
            }
            catch (Exception ex)
            {
                Archivos<bool>.InformarError(ex.Message);
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
            {
                cts.Cancel();
                Liga.GuardarCambios();
                Application.Exit();
            }
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
                Archivos<string>.InformarError(e.Message);
            }
        }
        /// <summary>
        /// Actualiza la hora del formulario principal constantemente
        /// </summary>
        private void CambiarHora()
        {
            while (!this.cts.IsCancellationRequested)
            {
                if (this.lbl_Hora.InvokeRequired)
                {
                    this.lbl_Hora.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.lbl_Hora.Text = DateTime.Now.ToString();
                    });
                }
                else
                    this.lbl_Hora.Text = DateTime.Now.ToString();

                Thread.Sleep(1000);
            }
        }
        /// <summary>
        /// Activa la hora
        /// </summary>

        private void btn_Activar_Click(object sender, EventArgs e)
        {
            if(cts is null || cts.IsCancellationRequested)
            {
                cts = new CancellationTokenSource();
                Task horaMenu = new Task(CambiarHora);
                horaMenu.Start();
                this.btn_Activar.Visible = false;
                this.btn_Frenar.Visible = true;
            }
        }
        /// <summary>
        /// Frena la hora
        /// </summary>
        private void btn_Frenar_Click(object sender, EventArgs e)
        {
            this.cts.Cancel();
            this.btn_Frenar.Visible = false;
            this.btn_Activar.Visible = true;
        }
    }
}
