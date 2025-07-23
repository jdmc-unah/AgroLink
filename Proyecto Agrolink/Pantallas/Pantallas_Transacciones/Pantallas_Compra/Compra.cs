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

            if (tablaCompra.CurrentRow.Cells[0].Value == null)
                return; 

            try
            { 
            Pantallas_Compra.CompraDetalle detalle = new Pantallas_Compra.CompraDetalle();
            detalle.compraForm = this;

            int row = tablaCompra.CurrentRow.Index;

            detalle.compraID = (int)this.tablaCompra.Rows[row].Cells[0].Value;
            detalle.codigo = (string)this.tablaCompra.Rows[row].Cells[1].Value;
            detalle.fecha = (DateTime)this.tablaCompra.Rows[row].Cells[2].Value;
            detalle.socioID = (int)this.tablaCompra.Rows[row].Cells[3].Value;
            detalle.socio = (string)this.tablaCompra.Rows[row].Cells[4].Value;
            detalle.tipoSocio = (string)this.tablaCompra.Rows[row].Cells[5].Value;
            detalle.listaPreciosID = (int)this.tablaCompra.Rows[row].Cells[6].Value;
            detalle.listaPrecios = (string)this.tablaCompra.Rows[row].Cells[7].Value;
            detalle.tipoPago = (string)this.tablaCompra.Rows[row].Cells[8].Value;
            detalle.estado = (string)this.tablaCompra.Rows[row].Cells[9].Value;

            PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(this, detalle);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Compra_Load(object sender, EventArgs e)
        {
            tablaCompra.Columns.Clear(); // limpia columnas manuales
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
    }
}
