using AgroLink.Pantallas.Pantallas_Objetos;
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
using static AgroLink.Pantallas.Pantallas_Objetos.NuevoProducto;
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



        public void ToggleReadOnly(bool esSoloLectura)
        {

            cbEstadoCompra.Enabled = !esSoloLectura;

            cbSocioCompra.Enabled = (compraID != 0) ? false : true;

            cbTipoPagoCompra.Enabled = !esSoloLectura;
            cbListaPrecioCompra.Enabled = !esSoloLectura;
            dateTimePicker1.Enabled = !esSoloLectura;

            tablaCompraDetalle.ReadOnly = esSoloLectura;
            tablaCompraDetalle.AllowUserToDeleteRows = (compraID != 0) ? false : true;

            btnAceptarCompra.Visible = !esSoloLectura;
            btnCancelarCompra.Visible = !esSoloLectura;
            btnEditarCompra.Visible = esSoloLectura;
            btnCrearRecibo.Visible = esSoloLectura;
            if (compraID != 0)
            {
                string estadoEdicion = esSoloLectura ? "desactivado" : "activado";
                MessageBox.Show($"El modo edición está {estadoEdicion}");
            }
        }



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

            CalculaTotalFinal();
        }

        public void CalculaTotalFinal()
        {
            DataTable tablaTotales = recSQL.EjecutarFuncion("dbo.fCalcularTotalesCompra", "tablaTotales", "TipoCompraDetalle", metodosGlobales.CrearDataTable(tablaCompraDetalle));
            tbSubtotal.Text = tablaTotales.Rows[0][0].ToString();
            tbTotal.Text = tablaTotales.Rows[0][1].ToString();
        }


        void LlenaCombosSuperiores()
        {
            cbSocioCompra.DataSource = recSQL.EjecutarVista("vTraeSocio");
            cbSocioCompra.DisplayMember = "Socio";
            cbSocioCompra.ValueMember = "SocioID";

            cbListaPrecioCompra.DataSource = recSQL.EjecutarVista("vTraeListaPrecios");
            cbListaPrecioCompra.DisplayMember = "ListPrecios";
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

            DataTable tbDet = metodosGlobales.CrearDataTable(tablaCompraDetalle);

            Dictionary<string, object> paramsCompra = new Dictionary<string, object>()
            {
                {"compraID" , compraID },
                {"fecha" , dateTimePicker1.Value.ToString("yyyy/MM/dd") },
                {"socID" , cbSocioCompra.SelectedValue },
                {"listPrecID" , cbListaPrecioCompra.SelectedValue },
                {"tipoPago" , cbTipoPagoCompra.SelectedItem },
                {"estado" , cbEstadoCompra.SelectedItem }
            };

            DataTable? tablaResultante = recSQL.EjecutarSPDataTable("spAddUpdateCompra", "detalle", "TipoCompraDetalle", tbDet, paramsCompra);

            if (tablaResultante != null && tablaResultante.Rows.Count > 0)
            {
                compraID = Convert.ToInt32(tablaResultante.Rows[0][0]);

                if (metodosGlobales.MensajeConfirmacion("Confirmación", "Cambios guardados \n ¿Desea crear un recibo?"))
                {
                    Pantallas_Recibo.ReciboDetalle formRecibo = new Pantallas_Recibo.ReciboDetalle();
                    formRecibo.compraID = compraID;
                    formRecibo.FormPadre = this;
                    PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(this, formRecibo);
                }

                ObtenerDatos(compraID);
                ToggleReadOnly(true);
            }
            else
            {
                MessageBox.Show("No se pudo guardar la compra. Verifique si ocurrió un error.");
            }
        }

        private void btnCancelarCompra_Click(object sender, EventArgs e)
        {
            if (compraID != 0)
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    { "compraID", compraID },
                    { "socID", cbSocioCompra.SelectedValue },
                    { "error", "" } // OUTPUT parametro
                };

                recSQL.EjecutarSPDataTable("spCancelarCompra", parametros);

                if (parametros["error"] != null && parametros["error"].ToString() != "")
                {
                    MessageBox.Show(parametros["error"].ToString());
                    return;
                }

                MessageBox.Show("Compra cancelada correctamente.");

                ObtenerDatos(compraID); // refresca pantalla
                ToggleReadOnly(true);   // deshabilita edición
            }
            else
            {
                PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(compraForm, this);
            }
        }

        private void btnCrearRecibo_Click(object sender, EventArgs e)
        {
            if (cbEstadoCompra.SelectedItem == "Abierto" && compraID != 0)
            {

                Pantallas_Recibo.ReciboDetalle formRecibo = new Pantallas_Recibo.ReciboDetalle();
                formRecibo.compraID = compraID;
                formRecibo.FormPadre = this;
                PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(this, formRecibo);
            }
            else
            {
                MessageBox.Show("No puede crear recibos si la compra ha sido cerrada");
            }

        }

        private void btnAdministrarProducto_Click(object sender, EventArgs e)
        {
            if (PantallaPrincipal.instanciaPantPrincipal != null)
            {
                PantallaPrincipal.instanciaPantPrincipal.OpenChildForm(new Producto());
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



        private void tablaCompraDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int row = tablaCompraDetalle.CurrentRow.Index;
            int column = tablaCompraDetalle.CurrentCell.ColumnIndex;

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

            CalculaTotalFinal();
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


        private void tablaCompraDetalle_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tablaCompraDetalle_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbListaPrecioCompra_SelectionChangeCommitted(object sender, EventArgs e)
        {


            Dictionary<string, object?> param = new Dictionary<string, object?>()
            {
                {"listPrecID", cbListaPrecioCompra.SelectedValue }
            };

            DataTable tablaPrecios = recSQL.EjecutarSPDataTable("spTraePrecioCompra", "detalle", "TipoCompraDetalle", metodosGlobales.CrearDataTable(tablaCompraDetalle), param);

            if (tablaPrecios != null && tablaPrecios.Rows.Count > 0)
            {
                for (int i = 0; i < tablaCompraDetalle.Rows.Count && i < tablaPrecios.Rows.Count; i++)
                {
                    var nuevoValor = tablaPrecios.Rows[i]["Precio"];
                    tablaCompraDetalle.Rows[i].Cells["Precio"].Value = nuevoValor;
                }
            }


        }
    }
}
