using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIN_JosePorozo
{
    public partial class FrmDigitoVerificador : Form
    {
        public FrmDigitoVerificador()
        {
            InitializeComponent();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            FrmPrincipal PN = new FrmPrincipal();
            this.Hide();
            PN.Show();
        }
    }
}
