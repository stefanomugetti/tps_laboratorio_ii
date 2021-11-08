﻿using Entidades;
using System;
using System.Windows.Forms;

namespace FormTPFinal
{
    public partial class Frm_AltaJugador : Form
    {
        public Frm_AltaJugador()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Instancia un jugador con datos validos y lo agrega al equipo ingresado en el text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Crear_Click(object sender, EventArgs e)
        {
            try
            {
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
                        if (!Liga.JugadorRepetido(dni))
                        {
                            Equipo equipoElegido = Liga.ObtenerEquipo(this.txt_Equipo.Text);
                            if (equipoElegido != null)
                            {
                                Jugador jugador = new Jugador(this.txt_Nombre.Text, this.txt_Apellido.Text, (int)this.nud_Edad.Value,
                                                                altura, peso, this.txt_Nacionalidad.Text, this.cmb_PieHabil.Text,
                                                                equipoElegido.Nombre, valor, this.cmb_Posicion.Text, dni);

                                if (equipoElegido.AgregarJugador(jugador))
                                {

                                    MessageBox.Show($"Jugador agregado.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show($"El equipo {this.txt_Equipo.Text} no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Ya existe un jugador con el dni {this.txt_Dni.Text}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Datos invalidos. Vuelta a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"Datos numericos invalidos. Vuelta a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (DniException)
            {
                MessageBox.Show($"Error al ingresar DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
