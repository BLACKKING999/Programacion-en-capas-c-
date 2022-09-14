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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void oPERACIONESMATEMÁTICASBÁSICASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOMB omb = new FrmOMB();
            this.Hide();
            omb.Show();
        }
    }
}
