using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroLink.Pantallas.Pantallas_Socios
{
    public partial class SociosDetalle : Form
    {
        public SociosDetalle()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PantallaPrincipal.instanciaPantPrincipal.OpenChildForm(new Pantallas_Socios.Socios());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }




    }
}
