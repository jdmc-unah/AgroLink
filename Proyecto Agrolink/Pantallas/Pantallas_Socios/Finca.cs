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
    public partial class Finca : Form
    {
        public Finca()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PantallaPrincipal.instanciaPantPrincipal.OpenChildForm(new Pantallas_Socios.Agricultor());
        }


    }
}
