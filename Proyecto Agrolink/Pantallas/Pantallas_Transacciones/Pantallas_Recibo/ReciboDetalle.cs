using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroLink.Pantallas.Pantallas_Transacciones.Pantallas_Recibo
{
    public partial class ReciboDetalle : Form
    {
        public Form FormPadre { get; set; }  //Formulario Padre

        public int reciboID { get; set; }

        public int compraID { get; set; }

        public ReciboDetalle()
        {
            InitializeComponent();
        }

        private void ReciboDetalle_Load(object sender, EventArgs e)
        {

        }
    }
}
