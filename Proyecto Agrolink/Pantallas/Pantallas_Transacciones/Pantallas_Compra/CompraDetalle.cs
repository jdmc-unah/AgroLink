using AgroLink.Recursos;
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

namespace AgroLink.Pantallas.Pantallas_Transacciones.Pantallas_Compra
{
    public partial class CompraDetalle : Form
    {
        public Compra compraForm { get; set; }
        public int compraID { get; set; }

        public CompraDetalle()
        {
            InitializeComponent();
        }


        #region Variables Globales
        Recursos_SQL recSQL = new Recursos_SQL();
        MetodosGlobales metodosGlobales = new MetodosGlobales();
        DataTable comboImp;
        #endregion

        #region Metodos

        public void ObtenerDatos(int id)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                { "compraID", id }
            };

            DataTable compraFiltrada = recSQL.EjecutarSPDataTable("spTraeCompraFiltrada", parametros);

            tbCodigoCompra.Text = compraFiltrada.Rows[0]["CodigoCompra"].ToString();
            dateTimePicker1.Value = Convert.ToDateTime(compraFiltrada.Rows[0]["Fecha"]);

            LlenaCombosSuperiores();

            cbSocioCompra.SelectedValue = Convert.ToInt32(compraFiltrada.Rows[0]["SocioID"]);
            cbListaPrecioCompra.SelectedValue = Convert.ToInt32(compraFiltrada.Rows[0]["ListaPreciosID"]);

            cbTipoPagoCompra.SelectedItem = compraFiltrada.Rows[0]["TipoPago"].ToString();
            cbEstadoCompra.SelectedItem = compraFiltrada.Rows[0]["Estado"].ToString();

            DataTable dt = recSQL.EjecutarSPDataTable("spTraeCompraDetalle", parametros);
            dt.Columns["CompraID"].AutoIncrement = false;
            dt.Columns["CompraID"].DefaultValue = 0;
            dt.Columns["CodigoProducto"].DefaultValue = "PRO";
            dt.Columns["Subtotal"].DefaultValue = 0;
            dt.Columns["Subtotal"].ReadOnly = false;

            tablaCompraDetalle.AutoGenerateColumns = false;
            tablaCompraDetalle.DataSource = dt;

            LlenaComboDetalle();
        }

        public void ToggleReadOnly(bool esSoloLectura)
        {

            cbEstadoCompra.Enabled = !esSoloLectura;
            cbSocioCompra.Enabled = !esSoloLectura;
            cbTipoPagoCompra.Enabled = !esSoloLectura;
            cbListaPrecioCompra.Enabled = !esSoloLectura;
            dateTimePicker1.Enabled = !esSoloLectura;

            tablaCompraDetalle.ReadOnly = esSoloLectura;
            tablaCompraDetalle.AllowUserToDeleteRows = !esSoloLectura;

            btnAceptarCompra.Visible = !esSoloLectura;
            btnCancelarCompra.Visible = !esSoloLectura;
            btnEditarCompra.Visible = esSoloLectura;

            if (compraID != 0)
            {
                string estadoEdicion = esSoloLectura ? "desactivado" : "activado";
                MessageBox.Show($"El modo edición está {estadoEdicion}");
            }
        }

        void LlenaCombosSuperiores()
        {
            cbSocioCompra.DataSource = recSQL.EjecutarVista("vTraeSocio");
            cbSocioCompra.DisplayMember = "Socio";
            cbSocioCompra.ValueMember = "SocioID";

            cbListaPrecioCompra.DataSource = recSQL.EjecutarVista("vTraeListaPrecios");
            cbListaPrecioCompra.DisplayMember = "ListaPrecios";
            cbListaPrecioCompra.ValueMember = "ListaPreciosID";
        }

        void LlenaComboDetalle()
        {
            DataGridViewComboBoxColumn colProducto = (DataGridViewComboBoxColumn)tablaCompraDetalle.Columns["ProductoID"];
            colProducto.DataSource = recSQL.EjecutarVista("vTraeProductos");
            colProducto.DisplayMember = "Producto";
            colProducto.ValueMember = "ProductoID";

            DataGridViewComboBoxColumn colBodega = (DataGridViewComboBoxColumn)tablaCompraDetalle.Columns["BodegaID"];
            colBodega.DataSource = recSQL.EjecutarVista("vTraeBodega");
            colBodega.DisplayMember = "Bodega";
            colBodega.ValueMember = "BodegaID";

            DataGridViewComboBoxColumn colImpuesto = (DataGridViewComboBoxColumn)tablaCompraDetalle.Columns["ImpuestoID"];
            comboImp = recSQL.EjecutarVista("vTraeImpuesto");
            colImpuesto.DataSource = comboImp;
            colImpuesto.DisplayMember = "Impuesto";
            colImpuesto.ValueMember = "ImpuestoID";
        }

        #endregion

        #region Botones

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(compraForm, this);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cbEstadoCompra.SelectedItem.ToString() == "Abierto")
            {
                ToggleReadOnly(false);
            }
            else
            {
                MessageBox.Show("Las compras Cerradas o Canceladas no pueden editarse");
            }
        }

        private void btnAceptarCompra_Click(object sender, EventArgs e)
        {
            ToggleReadOnly(true);

            Dictionary<string, object> paramsCompra = new Dictionary<string, object>() {
                {"compraID" , compraID },
                {"fecha" , dateTimePicker1.Value.ToString("yyyy/MM/dd") },
                {"socID" , cbSocioCompra.SelectedValue },
                {"listPrecID" , cbListaPrecioCompra.SelectedValue },
                {"tipoPago" , cbTipoPagoCompra.SelectedItem },
                {"estado" , cbEstadoCompra.SelectedItem }
            };

            DataTable tablaResultante = recSQL.EjecutarSPDataTable("spAddUpdateCompra", paramsCompra);

            if (tablaResultante != null)
            {
                compraID = compraID == 0 ? Convert.ToInt32(tablaResultante.Rows[0][0]) : compraID;

                Dictionary<string, object> paramsDet = new Dictionary<string, object>() {
                    {"compraID" , compraID }
                };

                if (recSQL.EjecutarSPBool("spAgregarCompraDetalle", "detalle", "TipoCompraDetalle", metodosGlobales.CrearDataTable(tablaCompraDetalle), paramsDet))
                {
                    MessageBox.Show("Cambios guardados con éxito");
                    ObtenerDatos(compraID);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error inesperado");
                }
            }
            else
            {
                MessageBox.Show("Ocurrió un error inesperado");
            }
        }

        private void btnCancelarCompra_Click(object sender, EventArgs e)
        {
            ToggleReadOnly(true);

            if (compraID != 0)
            {
                ObtenerDatos(compraID);
            }
            else
            {
                PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(compraForm, this);
            }
        }


        #endregion


        private void CompraDetalle_Load(object sender, EventArgs e)
        {
            if (compraID != 0)
            {
                ObtenerDatos(compraID);
            }
            else
            {
                LlenaCombosSuperiores();
                cbEstadoCompra.SelectedItem = "Abierto";
                LlenaComboDetalle();
                ToggleReadOnly(false);
            }
        }

        int cant; double precio, imp = 0, subtotal;

        private void tablaCompraDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int row = tablaCompraDetalle.CurrentRow.Index;

            int cant = 0; double precio = 0; int impID = 0;

            object celdaCant = tablaCompraDetalle.Rows[row].Cells["Cantidad"].Value;
            object celdaPrecio = tablaCompraDetalle.Rows[row].Cells["Precio"].Value;
            object celdaImpID = tablaCompraDetalle.Rows[row].Cells["ImpuestoID"].Value;

            if (celdaCant != null && celdaCant.GetType() != typeof(DBNull))
                cant = Convert.ToInt32(celdaCant);

            if (celdaPrecio != null && celdaPrecio.GetType() != typeof(DBNull))
                precio = Convert.ToDouble(celdaPrecio);

            if (celdaImpID != null && celdaImpID.GetType() != typeof(DBNull))
                impID = Convert.ToInt32(celdaImpID);

            Dictionary<string, object> parametros = new Dictionary<string, object>() {
                {"cant", cant },
                {"precio", precio },
                {"impID", impID }
            };

            DataTable totales = recSQL.EjecutarFuncion("dbo.fCalcularTotales", parametros);

            tablaCompraDetalle.Rows[row].Cells["Subtotal"].Value = totales.Rows[0][0];
            tablaCompraDetalle.Rows[row].Cells["Total"].Value = totales.Rows[0][1];
        }

        private void tablaCompraDetalle_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void tbCodigoCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void tablaCompraDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
