using AgroLink.Pantallas.Pantallas_Transacciones.Pantalla_SalidaProducto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroLink.Pantallas.Pantallas_Transacciones.Pantallas_Entrega
{
    public partial class Entrega : Form
    {
        public Entrega()
        {
            InitializeComponent();
        }



        #region Variables Globales

        Recursos.Recursos_SQL recSQL = new Recursos.Recursos_SQL();

        #endregion




        private void Entrega_Load(object sender, EventArgs e)
        {
            tablaEntrega.DataSource = recSQL.EjecutarVista("vTraeEntrega");

        }

        private void btnRecargarEntrega_Click(object sender, EventArgs e)
        {
            tablaEntrega.DataSource = recSQL.EjecutarVista("vTraeEntrega");

        }

        private void btnBuscarEntrega_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                { "cod", tbBuscarEntrega.Text.Trim() }
            };

            tablaEntrega.DataSource = recSQL.EjecutarSPDataTable("spBuscarEntrega", parametros);
        }

        private void tablaEntrega_DoubleClick(object sender, EventArgs e)
        {
            //Crea una nueva instancia de VentaDetalle y le pasa este form junto con el id de la venta
            Pantallas_Entrega.EntregaDetalle detalle = new EntregaDetalle();
            detalle.FormPadre = this;

            //Toma el indice de la fila seleccionada y el valor seleccionado 
            int row = tablaEntrega.CurrentRow.Index;

            detalle.entregaID = (int)tablaEntrega.Rows[row].Cells["EntregaID"].Value;
            detalle.ventaID = (int)tablaEntrega.Rows[row].Cells["VentaID"].Value;
            //Llama al metodo de la pantalla principal para mostrar detalle
            PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(this, detalle);
        }

        private void btnNuevaEntrega_Click(object sender, EventArgs e)
        {

            //Crea una nueva instancia de VentaDetalle y le pasa este form junto con el id de la venta
            Pantallas_Entrega.EntregaDetalle detalle = new EntregaDetalle();
            detalle.FormPadre = this;

            detalle.entregaID = 0;
            detalle.ventaID = 0;

            //Llama al metodo de la pantalla principal para mostrar VentaDetalle
            PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(this, detalle);
        }

        private void Entrega_VisibleChanged(object sender, EventArgs e)
        {
            tablaEntrega.DataSource = recSQL.EjecutarVista("vTraeEntrega");

        }




    }
}
