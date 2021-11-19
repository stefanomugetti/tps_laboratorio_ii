using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTPFinal
{
    public partial class Frm_Informe : Form
    {
        public Frm_Informe(string informe)
        {
            InitializeComponent();
            this.lbl_Info.Text = informe;
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
