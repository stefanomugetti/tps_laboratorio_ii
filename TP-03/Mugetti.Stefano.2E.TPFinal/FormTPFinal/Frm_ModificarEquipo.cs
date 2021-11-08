using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Windows.Forms;

namespace FormTPFinal
{
    public partial class Frm_ModificarEquipo : Form
    {
        Equipo equipoAModificar;
        public Frm_ModificarEquipo(Equipo equipoAModif)
        {
            InitializeComponent();
            equipoAModificar = equipoAModif;
            this.txt_Nombre.Text = equipoAModif.Nombre;
            this.txt_Valor.Text = equipoAModif.Valor.ToString();
            this.txt_AñoCreacion.Text = equipoAModif.AñoCreacion.ToString();
        }
        /// <summary>
        /// Se encarga de modificar el equipo del atributo con datos validos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(this.txt_Valor.Text, out double valor) && int.TryParse(this.txt_AñoCreacion.Text, out int añoCreacion))
            {
                string nombre = this.txt_Nombre.Text;
                if (Validaciones.SoloString(nombre) && Validaciones.ValorEquipoValido(valor) && Validaciones.AñoCreacionValido(añoCreacion))
                {
                    if (!Liga.EquipoRepetido(nombre) || nombre.ToLower() == equipoAModificar.Nombre.ToLower())
                    {
                        equipoAModificar.Nombre = nombre;
                        equipoAModificar.Valor = valor;
                        equipoAModificar.AñoCreacion = añoCreacion;
                        Console.Beep();
                    }
                    else
                        MessageBox.Show($"El equipo con el nombre {this.txt_Nombre.Text} ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Datos invalidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Valor o año de creacion invalidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
