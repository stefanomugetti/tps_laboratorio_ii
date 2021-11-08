using Entidades;
using System;
using System.Windows.Forms;

namespace FormTPFinal
{
    public partial class Frm_ModificarJdr : Form
    {
        private Jugador jugadorAModificar;
        public Frm_ModificarJdr(Jugador jdr)
        {
            InitializeComponent();
            if (jdr != null)
            {
                this.CargarDatos(jdr);
                jugadorAModificar = jdr;
            }
        }
        /// <summary>
        /// Se encarga de modificar al jugador con datos validos
        /// </summary>
        /// <param name="jugadorAModificar"></param>
        private void ModificarJugador(Jugador jugadorAModificar)
        {
            try
            {
                #region Validaciones
                if (double.TryParse(this.txt_Peso.Text, out double peso) &&
                   double.TryParse(this.txt_Altura.Text, out double altura) &&
                   long.TryParse(this.txt_Dni.Text, out long dni) &&
                   double.TryParse(this.txt_Valor.Text, out double valor))
                {
                    if (Validaciones.SoloString(this.txt_Nombre.Text) &&
                        Validaciones.SoloString(this.txt_Apellido.Text) &&
                        Validaciones.EdadValida((int)this.nud_Edad.Value) &&
                        Validaciones.PesoValida(peso) &&
                        Validaciones.AlturaValida(altura) &&
                        Validaciones.PieHabilValido(this.cmb_PieHabil.Text) &&
                        Validaciones.SoloString(this.txt_Nacionalidad.Text) &&
                        Validaciones.ValorValido(valor) &&
                        Validaciones.DniValido(dni) &&
                        Validaciones.PosicionValida(this.cmb_Posicion.Text))
                    {
                        #endregion
                        Equipo equipoElegido = Liga.ObtenerEquipo(this.txt_Equipo.Text);
                        if (equipoElegido != null)
                        {
                            if (this.txt_Dni.Text == jugadorAModificar.Dni.ToString())
                            {
                                this.Modificar(altura, valor, peso, dni, false);
                                Console.Beep();
                            }
                            else if (!Liga.JugadorRepetido(dni))
                            {
                                this.Modificar(altura, valor, peso, dni, true);
                                Console.Beep();
                            }
                            if (equipoElegido.Nombre != jugadorAModificar.Club)
                            {
                                Equipo equipoAnterior = Liga.ObtenerEquipo(jugadorAModificar.Club);
                                equipoAnterior.EliminarJugador(jugadorAModificar);

                                jugadorAModificar.Club = equipoElegido.Nombre;
                                if (equipoElegido.AgregarJugador(jugadorAModificar))
                                {                                    
                                    Console.Beep();
                                }
                            }
                        }
                        #region Errores
                        else
                        {
                            MessageBox.Show($"El equipo {this.txt_Equipo.Text} no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Datos invalidos. Vuelta a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    #endregion
                }

            }
            catch (DniException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            this.ModificarJugador(jugadorAModificar);
        }

        /// <summary>
        /// Carga los datos del jugador pasado por parametros
        /// </summary>
        /// <param name="jdr"></param>
        private void CargarDatos(Jugador jdr)
        {
            this.txt_Nombre.Text = jdr.Nombre;
            this.txt_Apellido.Text = jdr.Apellido;
            this.txt_Dni.Text = jdr.Dni.ToString();
            this.txt_Peso.Text = jdr.Peso.ToString();
            this.txt_Valor.Text = jdr.Valor.ToString();
            this.txt_Altura.Text = jdr.Altura.ToString();
            this.txt_Nacionalidad.Text = jdr.Nacionalidad;
            this.nud_Edad.Value = jdr.Edad;
            this.cmb_PieHabil.Text = jdr.PieHabil;
            this.cmb_Posicion.Text = jdr.Posicion;
            this.txt_Equipo.Text = jdr.Club;
        }

        private void Modificar(double altura, double valor, double peso, long dni, bool modifDni)
        {
            if (modifDni)
            {
                jugadorAModificar.Dni = dni;
            }
            jugadorAModificar.Nombre = this.txt_Nombre.Text;
            jugadorAModificar.Apellido = this.txt_Apellido.Text;
            jugadorAModificar.Nacionalidad = this.txt_Nacionalidad.Text;
            jugadorAModificar.PieHabil = this.cmb_PieHabil.Text;
            jugadorAModificar.Posicion = this.cmb_Posicion.Text;
            jugadorAModificar.Altura = altura;
            jugadorAModificar.Valor = valor;
            jugadorAModificar.Peso = peso;
            jugadorAModificar.Edad = (int)nud_Edad.Value;
        }
    }
}
