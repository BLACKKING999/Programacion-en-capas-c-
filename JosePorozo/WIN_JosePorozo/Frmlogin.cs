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
    public partial class Frmlogin : Form
    {

        ClsLogin Login = new ClsLogin();


        public Frmlogin(){InitializeComponent();}

        private void Frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btbprocesar_Click(object sender, EventArgs e)
        {
            if (Login.autentificar(txtUsuario.Text, txtClave.Text) == true)
            {
                FrmPrincipal principal = new FrmPrincipal();

                this.Hide();
                principal.Show();

            }
            else { MessageBox.Show("Usuario no autentificado"); Close(); }
        }
    }
}
