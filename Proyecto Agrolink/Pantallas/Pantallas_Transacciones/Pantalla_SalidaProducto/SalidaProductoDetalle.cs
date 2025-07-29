using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroLink.Pantallas.Pantallas_Transacciones.Pantalla_SalidaProducto
{
    public partial class SalidaProductoDetalle : Form
    {

        public Form FormPadre { get; set; }  //Formulario Padre

        public int salidaID { get; set; }

        public int ventaID { get; set; }


        public SalidaProductoDetalle()
        {
            InitializeComponent();
        }





    }
}
