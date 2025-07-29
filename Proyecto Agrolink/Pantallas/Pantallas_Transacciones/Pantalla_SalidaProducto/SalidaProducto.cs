using AgroLink.Modelos;
using AgroLink.Pantallas.Pantallas_Transacciones.Pantallas_Factura;
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
    public partial class SalidaProducto : Form
    {
        public SalidaProducto()
        {
            InitializeComponent();
        }


        #region Variables Globales

        Recursos.Recursos_SQL recSQL = new Recursos.Recursos_SQL();

        #endregion

        private void SalidaProducto_Load(object sender, EventArgs e)
        {
            tablaSalida.DataSource = recSQL.EjecutarVista("vTraeSalidaProducto");
        }

        private void btnRecargarSal_Click(object sender, EventArgs e)
        {
            tablaSalida.DataSource = recSQL.EjecutarVista("vTraeSalidaProducto");
        }

        private void btnBuscarSal_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                { "cod", tbBuscarSal.Text.Trim() }
            };

            tablaSalida.DataSource = recSQL.EjecutarSPDataTable("spBuscarSalidaProd", parametros);
        }


        private void tablaSalida_DoubleClick(object sender, EventArgs e)
        {
            //Crea una nueva instancia de VentaDetalle y le pasa este form junto con el id de la venta
            Pantalla_SalidaProducto.SalidaProductoDetalle detalle = new SalidaProductoDetalle();
            detalle.FormPadre = this;

            //Toma el indice de la fila seleccionada y el valor seleccionado 
            int row = tablaSalida.CurrentRow.Index;

            detalle.salidaID = (int) tablaSalida.Rows[row].Cells["SalidaID"].Value;
            detalle.ventaID = (int) tablaSalida.Rows[row].Cells["VentaID"].Value;
            //Llama al metodo de la pantalla principal para mostrar detalle
            PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(this, detalle);
        }

        private void btnNuevaSalProd_Click(object sender, EventArgs e)
        {

            //Crea una nueva instancia de VentaDetalle y le pasa este form junto con el id de la venta
            Pantalla_SalidaProducto.SalidaProductoDetalle detalle = new SalidaProductoDetalle();
            detalle.FormPadre = this;

            detalle.salidaID = 0;
            detalle.ventaID = 0;

            //Llama al metodo de la pantalla principal para mostrar VentaDetalle
            PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(this, detalle);

        }

        private void SalidaProducto_VisibleChanged(object sender, EventArgs e)
        {
            tablaSalida.DataSource = recSQL.EjecutarVista("vTraeSalidaProducto");

        }



    }
}
