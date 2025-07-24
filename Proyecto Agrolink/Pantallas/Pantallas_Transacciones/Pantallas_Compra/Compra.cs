using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroLink.Pantallas.Pantallas_Transacciones.Pantallas_Compra
{
    public partial class Compra : Form
    {
        public Compra()
        {
            InitializeComponent();
        }

        #region Variables Globales
        Recursos.Recursos_SQL recSQL = new Recursos.Recursos_SQL();
        Recursos.MetodosGlobales metGlobales = new Recursos.MetodosGlobales();
        #endregion


        private void tablaCompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaCompra.CurrentRow == null || tablaCompra.CurrentRow.Index < 0)
                return;

            Pantallas_Compra.CompraDetalle detalle = new Pantallas_Compra.CompraDetalle();
            detalle.compraForm = this;

            // Toma el ID de la compra seleccionada
            int row = tablaCompra.CurrentRow.Index;
            detalle.compraID = (int)this.tablaCompra.Rows[row].Cells["CompraID"].Value;

            // Muestra la pantalla detalle
            PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(this, detalle);
        }

        private void Compra_Load(object sender, EventArgs e)
        {
            tablaCompra.DataSource = recSQL.EjecutarVista("vTraeCompras");
        }

        private void btnRecargarCompra_Click(object sender, EventArgs e)
        {
            tablaCompra.DataSource = recSQL.EjecutarVista("vTraeCompras");
        }

        private void btnBuscarCompra_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                { "codigo", tbBuscarCompra.Text.Trim() }
            };

            tablaCompra.DataSource = recSQL.EjecutarSPDataTable("spBuscarCompra", parametros);
        }

        private void btnNuevaCompra_Click(object sender, EventArgs e)
        {
            Pantallas_Compra.CompraDetalle nuevaCompra = new Pantallas_Compra.CompraDetalle();
            nuevaCompra.compraForm = this;

            nuevaCompra.compraID = 0;

            PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(this, nuevaCompra);
        }

        private void Compra_VisibleChanged(object sender, EventArgs e)
        {
            tablaCompra.DataSource = recSQL.EjecutarVista("vTraeCompras");
        }
    }
}
