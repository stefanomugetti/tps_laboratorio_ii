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
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        //Al apretar el boton cerrar se mostrara un Pop up para confirmar su salida, al aceptar, se cerrara
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      //Al apretar el boton Operar del formulario, se realizara la operacion elegida y se mostrara en el listBox de operaciones
       
        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero1.Text, out double auxNum) && double.TryParse(this.txtNumero2.Text, out double auxNum2))
            {
                double resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
                this.lblResultado.Text = resultado.ToString(); //si es neg muestra el menos despues del numero, no encontre solucion.
                this.lstOperaciones.Items.Add($"{txtNumero1.Text} {this.cmbOperador.Text} {txtNumero2.Text} = {resultado}");
            }
            else
                this.lstOperaciones.Items.Add("Valores incorrectos. Vuelva a intentarlo");
        }
        //Al clickear sobre Limpiar en el formulario, se limpiara el Label, los Text box y el list box
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        //Limpia el formulario
        private void Limpiar()
        {
            lstOperaciones.Items.Clear();
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            lblResultado.Text = "0";
        }
        //Al apretar Cerrar, aparecera una ventana para confirmar la eleccion, si apreta cancel podra seguir operando, sino, saldra
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                e.Cancel = true;
        }
        /// <summary>
        /// Llama al metodo Operar de la clase Calculadora
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

            if (char.TryParse(operacion, out char operador))
                resultado = Calculadora.Operar(num1, num2, operador);

            return resultado;
        }

        //Al presionar Convertir a binario, se intentara convertir el resultado de la operacion, a un numero binario
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lblResultado.Text, out double auxNum))
            {
                Operando num = new Operando(auxNum);
                this.lstOperaciones.Items.Add($"{num.DecimalBinario(auxNum.ToString())}");
            }
        }
        //Al presionar Convertir a binario, se intentara convertir el resultado de la operacion, a un numero decimal
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
