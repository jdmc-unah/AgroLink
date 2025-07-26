using AgroLink.Pantallas.Pantallas_Transacciones.Pantallas_Compra;
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

        public Compra FincaForm { get; set; }

        public Finca()
        {
            InitializeComponent();
        }

        private void btnVolverAgricultor_Click(object sender, EventArgs e)
        {
            PantallaPrincipal.instanciaPantPrincipal.OpenChildForm(new Pantallas.Pantallas_Socios.Agricultor());
        }
    }
}
