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
    public partial class FrmOT : Form
    {
        public FrmOT()
        {
            InitializeComponent();
        }
        ClsOT OT = new ClsOT();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtAltura.Text = "";
            TxtBase.Text = "";
            TxtRadio.Text = "";
            TxtAltura.Focus();
        }

        private void BtnAreaTriangulo_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            FrmPrincipal PN = new FrmPrincipal();
            this.Hide();
            PN.Show();
        }
    }
}
