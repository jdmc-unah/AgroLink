using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroLink.Pantallas.Pantallas_Transacciones.Pantallas_Factura
{
    public partial class FacturaDetalle : Form
    {

        public Factura FacturaForm { get; set; }  //Formulario Padre

        public int facturaID { get; set; }

        public FacturaDetalle()
        {
            InitializeComponent();
        }
    }
}
