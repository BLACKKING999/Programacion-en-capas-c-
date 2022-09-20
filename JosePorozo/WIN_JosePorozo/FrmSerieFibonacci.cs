using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_JosePorozo;

namespace WIN_JosePorozo
{
    public partial class FrmSerieFibonacci : Form
    {
        public FrmSerieFibonacci()
        {
            InitializeComponent();
        }
        ClsSF SF = new ClsSF();

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtValor.Text = "";
            TxtListaFibnacci.Text = "";
            TxtValor.Focus();
        }

        private void BtnProcesar_Click(object sender, EventArgs e)
        {
            int n =int.Parse(TxtValor.Text);
            TxtListaFibnacci.Text = SF.SEF(n).ToString();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            FrmPrincipal PN = new FrmPrincipal();
            this.Hide();
            PN.Show();
        }
    }
}
