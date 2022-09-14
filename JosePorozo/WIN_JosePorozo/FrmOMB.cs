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
    public partial class FrmOMB : Form
    {
        public FrmOMB()
        {
            InitializeComponent();
        }
        ClsOMB omb = new ClsOMB();

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtNumeroUno.Text = "";
            TxtNumeroDos.Text = "";
            TxtNumeroUno.Focus();
        }

        private void TxtNumeroUno_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSumar_Click(object sender, EventArgs e)
        {
            omb.N11 = Convert.ToDouble(TxtNumeroUno.Text);
            omb.N21 = Convert.ToDouble(TxtNumeroDos.Text);

            MessageBox.Show("El resultado de la suma es:");
        }

        private void BtnRestar_Click(object sender, EventArgs e)
        {
            omb.N11 = Convert.ToDouble(TxtNumeroUno.Text);
            omb.N21 = Convert.ToDouble(TxtNumeroDos.Text);

            MessageBox.Show("El resultado de la resta es:");
        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            omb.N11 = Convert.ToDouble(TxtNumeroUno.Text);
            omb.N21 = Convert.ToDouble(TxtNumeroDos.Text);

            MessageBox.Show("El resultado de la multiplicasion es:");
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            omb.N11 = Convert.ToDouble(TxtNumeroUno.Text);
            omb.N21 = Convert.ToDouble(TxtNumeroDos.Text);

            MessageBox.Show("El resultado de la dividir es:");
        }
    }
}
