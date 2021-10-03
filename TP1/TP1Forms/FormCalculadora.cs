using LaCalculadora;
using System;
using System.Windows.Forms;

namespace MiCalculadora
{
    public partial class FormCalculadora : System.Windows.Forms.Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Limpia los datos del formulario al cargarse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       /// <summary>
       /// Llama a los metodos para resolver la operacion elegida.
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero1.Text, out double auxNum) && double.TryParse(this.txtNumero2.Text, out double auxNum2))
            {
                double resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
                this.lblResultado.Text = resultado.ToString(); 
                this.lstOperaciones.Items.Add($"{txtNumero1.Text} {this.cmbOperador.Text} {txtNumero2.Text} = {resultado}");
            }
            else
                this.lstOperaciones.Items.Add("Valores incorrectos. Vuelva a intentarlo");
        }
       /// <summary>
       /// Limpia los datos del formulario
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        /// <summary>
        /// Limpia los text box, la lista y el label de resultado
        /// </summary>
        private void Limpiar()
        {
            lstOperaciones.Items.Clear();
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            lblResultado.Text = "0";
        }
       /// <summary>
       /// Mensaje de confirmacion para salir.
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                e.Cancel = true;
        }
        /// <summary>
        /// Resuelve la operacion elegida entre los operandos
        /// </summary>
        /// <param name="numero1">primer numero para la operacion</param>
        /// <param name="numero2">segundo numero para la operacion</param>
        /// <param name="operacion">operador elegido</param>
        /// <returns>Retorna el resultado de la operacion o -1 si hubo un error</returns>
        private static double Operar(string numero1, string numero2, string operacion)
        {
            double resultado = -1;

            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);

            char.TryParse(operacion, out char operador);
            resultado = Calculadora.Operar(num1, num2, operador);

            return resultado;
        }

        /// <summary>
        /// Convierte el resultado de la operacion a binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lblResultado.Text, out double auxNum))
            {
                Operando num = new Operando(auxNum);
                this.lstOperaciones.Items.Add($"{num.DecimalBinario(auxNum.ToString())}");
            }
        }
       /// <summary>
       /// Convierte el resultado de la operacion a decimal
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lblResultado.Text, out double auxNum))
            {
                Operando num = new Operando(auxNum);
                this.lstOperaciones.Items.Add($"{num.BinarioDecimal(auxNum.ToString())}");
            }
        }
    }
}
