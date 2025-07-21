using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AgroLink.Pantallas.Pantallas_Transacciones.Pantallas_Venta
{
    public partial class VentasDetalle : Form
    {
        public int ventaID { get; set; }

        public Venta ventaForm { get; set; }



        public VentasDetalle( )
        {
            InitializeComponent();
            ObtenerDatos(ventaID);
        }


        #region Metodos


        public void ObtenerDatos(int ventaID)
        {

            MessageBox.Show($"{ventaID}");


        }



        #endregion



        private void btnVolver_Click(object sender, EventArgs e)
        {

            //ventaForm.Show();
            //this.Close();
            PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(ventaForm, this);

        }
    }
}
