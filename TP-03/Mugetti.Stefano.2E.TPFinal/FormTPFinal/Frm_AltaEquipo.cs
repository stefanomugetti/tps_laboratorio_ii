using Entidades;
using System;
using System.Windows.Forms;

namespace FormTPFinal
{
    public partial class Frm_AltaEquipo : Form
    {
        public Frm_AltaEquipo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Instancia un equipo con datos valido y lo agrega a la liga
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Crear_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(this.txt_Valor.Text, out double valor) && int.TryParse(this.txt_AñoCreacion.Text, out int añoCreacion))
                {
                    string nombre = this.txt_Nombre.Text;
                    if (Validaciones.SoloString(nombre))
                    {
                        if (Validaciones.ValorEquipoValido(valor))
                        {
                            if (Validaciones.AñoCreacionValido(añoCreacion))
                            {
                                if (!Liga.EquipoRepetido(nombre))
                                {
                                    if (Liga.AgregarEquipo(new Equipo(nombre, valor, añoCreacion)))
                                    {
                                        Console.Beep();
                                        this.Close();
                                    }
                                }
                                else
                                    MessageBox.Show($"El equipo con el nombre {this.txt_Nombre.Text} ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MessageBox.Show("Año de creacion invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show($"Valor invalido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Nombre invalido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Datos invalidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al crear.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
