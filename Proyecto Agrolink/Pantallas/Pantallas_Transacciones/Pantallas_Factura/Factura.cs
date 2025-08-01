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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }



        #region Variables Globales

        Recursos.Recursos_SQL recSQL = new Recursos.Recursos_SQL();

        #endregion


        private void Factura_Load(object sender, EventArgs e)
        {
            tablaFactura.DataSource = recSQL.EjecutarVista("vTraeFacturas");
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            tablaFactura.DataSource = recSQL.EjecutarVista("vTraeFacturas");

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                { "cod", tbBuscar.Text.Trim() }
            };

            tablaFactura.DataSource = recSQL.EjecutarSPDataTable("spBuscarFactura", parametros);
        }

        private void tablaFactura_DoubleClick(object sender, EventArgs e)
        {

            //Crea una nueva instancia de VentaDetalle y le pasa este form junto con el id de la venta
            Pantallas_Factura.FacturaDetalle detalle = new FacturaDetalle();
            detalle.FormPadre = this;

            //Toma el indice de la fila seleccionada y el valor seleccionado 
            int row = tablaFactura.CurrentRow.Index;

            detalle.facturaID = (int) tablaFactura.Rows[row].Cells[0].Value;
            detalle.ventaID = (int)tablaFactura.Rows[row].Cells["VentaID"].Value;

            //Llama al metodo de la pantalla principal para mostrar VentaDetalle
            PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(this, detalle);
        }




        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {

            //Crea una nueva instancia de VentaDetalle y le pasa este form junto con el id de la venta
            Pantallas_Factura.FacturaDetalle detalle = new FacturaDetalle();
            detalle.FormPadre = this;

            detalle.facturaID = 0;
            detalle.ventaID = 0;

            //Llama al metodo de la pantalla principal para mostrar VentaDetalle
            PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(this, detalle);
        }



        private void Factura_VisibleChanged(object sender, EventArgs e)
        {
            tablaFactura.DataSource = recSQL.EjecutarVista("vTraeFacturas");

        }

    }
}
