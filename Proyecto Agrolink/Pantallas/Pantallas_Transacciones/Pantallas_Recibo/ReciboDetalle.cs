using AgroLink.Pantallas.Pantallas_Transacciones.Pantallas_Factura;
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

namespace AgroLink.Pantallas.Pantallas_Transacciones.Pantallas_Recibo
{
    public partial class ReciboDetalle : Form
    {
        public Form FormPadre { get; set; }  //Formulario Padre

        public int reciboID { get; set; }

        public int compraID { get; set; }

        public ReciboDetalle()
        {
            InitializeComponent();
        }

        #region Variables Globales
        Recursos_SQL recSQL = new Recursos_SQL();
        MetodosGlobales metodosGlobales = new MetodosGlobales();
        #endregion


        #region Metodos

        public void ToggleReadOnly(bool esSoloLectura)
        {

            cbEstado.Enabled = !esSoloLectura;
            cbMetodoPago.Enabled = !esSoloLectura;
            cbEmpleado.Enabled = !esSoloLectura;

            cbCompra.Enabled = reciboID == 0 ? !esSoloLectura : esSoloLectura;

            dateTimePicker1.Enabled = !esSoloLectura;

            btnAceptar.Visible = !esSoloLectura;
            btnCancelar.Visible = !esSoloLectura;
            btnEditar.Visible = esSoloLectura;

            if (reciboID != 0)
            {
                string estadoEdicion = esSoloLectura ? "desactivado" : "activado";
                MessageBox.Show($"El modo edicion esta {estadoEdicion} ");
            }

        }

        void LlenaCombosSuperiores()
        {
            cbSocio.DataSource = recSQL.EjecutarVista("vTraeSocio");
            cbSocio.DisplayMember = "Socio";
            cbSocio.ValueMember = "SocioID";

            cbListaPrecio.DataSource = recSQL.EjecutarVista("vTraeListaPrecios");
            cbListaPrecio.DisplayMember = "ListPrecios";
            cbListaPrecio.ValueMember = "ListaPreciosID";

            cbEmpleado.DataSource = recSQL.EjecutarVista("vTraeEmpleado");
            cbEmpleado.DisplayMember = "Empleado";
            cbEmpleado.ValueMember = "EmpleadoID";

            Dictionary<string, object> filtroComprasAbiertas = new Dictionary<string, object>() {
                {"reciboID", reciboID}
            };

            cbCompra.DataSource = recSQL.EjecutarSPDataTable("spTraeComprasCode", filtroComprasAbiertas);
            cbCompra.DisplayMember = "CodigoCompra";
            cbCompra.ValueMember = "CompraID";
        }

        void LlenaComboDetalle()
        {

            //Llena los comboboxes de tabla detalle con las vistas
            DataGridViewComboBoxColumn colProducto = (DataGridViewComboBoxColumn)tablaReciboDetalle.Columns["ProductoID"];
            colProducto.DataSource = recSQL.EjecutarVista("vTraeProductos");
            colProducto.DisplayMember = "Producto";
            colProducto.ValueMember = "ProductoID";

            DataGridViewComboBoxColumn colBodega = (DataGridViewComboBoxColumn)tablaReciboDetalle.Columns["BodegaID"];
            colBodega.DataSource = recSQL.EjecutarVista("vTraeBodega");
            colBodega.DisplayMember = "Bodega";
            colBodega.ValueMember = "BodegaID";

            DataGridViewComboBoxColumn colImpuesto = (DataGridViewComboBoxColumn)tablaReciboDetalle.Columns["ImpuestoID"];
            colImpuesto.DataSource = recSQL.EjecutarVista("vTraeImpuesto");
            colImpuesto.DisplayMember = "Impuesto";
            colImpuesto.ValueMember = "ImpuestoID";
        }

        void ObtenerDatos(int recID, int compID)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                {"reciboid", recID },
                {"compraid", compID }
            };

            DataTable reciboFiltrado = recSQL.EjecutarSPDataTable("spTraeReciboFiltrado", parametros);

            if (reciboFiltrado.Rows.Count != 0)
            {
                tbCodigo.Text = reciboFiltrado.Rows[0]["CodigoRecibo"].ToString();

                dateTimePicker1.Value = Convert.ToDateTime(reciboFiltrado.Rows[0]["Fecha"]);

                LlenaCombosSuperiores();
                cbSocio.SelectedValue = Convert.ToInt32(reciboFiltrado.Rows[0]["SocioID"]);
                cbListaPrecio.SelectedValue = Convert.ToInt32(reciboFiltrado.Rows[0]["ListaPreciosID"]);
                cbEmpleado.SelectedValue = Convert.ToInt32(reciboFiltrado.Rows[0]["EmpleadoID"]);
                cbCompra.SelectedValue = Convert.ToInt32(reciboFiltrado.Rows[0]["CompraID"]);

                cbMetodoPago.SelectedItem = reciboFiltrado.Rows[0]["MetodoPago"].ToString();
                cbEstado.SelectedItem = reciboFiltrado.Rows[0]["Estado"].ToString();

                DataTable dt = recSQL.EjecutarSPDataTable("spTraeReciboDetalle", parametros);

                dt.Columns["ReciboID"].AutoIncrement = false;

                dt.Columns["ReciboID"].DefaultValue = 0;
                dt.Columns["CodigoProducto"].DefaultValue = "PRO";
                dt.Columns["Subtotal"].DefaultValue = 0;
                dt.Columns["Subtotal"].ReadOnly = false;

                tablaReciboDetalle.AutoGenerateColumns = false;

                tablaReciboDetalle.DataSource = dt;

                LlenaComboDetalle();

                if (tablaReciboDetalle.Rows.Count <= 2)
                {
                    tablaReciboDetalle.AllowUserToDeleteRows = false;
                }
                else
                {
                    tablaReciboDetalle.AllowUserToDeleteRows = true;
                }
            }
            else
            {
                LlenaCombosSuperiores();
                cbEstado.SelectedItem = "Abierto";
                LlenaComboDetalle();
            }

            CalculaTotalFinal();

        }

        public void CalculaTotalFinal()
        {
            DataTable tablaTotales = recSQL.EjecutarFuncion("dbo.fCalcularTotalesRecibo", "tablaTotales", "TipoReciboDetalle", metodosGlobales.CrearDataTable(tablaReciboDetalle));
            tbSubtotal.Text = tablaTotales.Rows[0][0].ToString();
            tbTotal.Text = tablaTotales.Rows[0][1].ToString();
        }

        #endregion

        private void ReciboDetalle_Load(object sender, EventArgs e)
        {
            if (reciboID == 0)
            {
                cbCompra.Enabled = true;

                ToggleReadOnly(false);
            }

            //carga los datos 
            ObtenerDatos(reciboID, compraID);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(FormPadre, this);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cbEstado.SelectedItem == "Abierto")
            {
                ToggleReadOnly(false);
            }
            else
            {
                MessageBox.Show("Los recibos Cerrados o Cancelados no pueden editarse");
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ToggleReadOnly(true);

            DataTable tbDet = metodosGlobales.CrearDataTable(tablaReciboDetalle);

            compraID = (int)cbCompra.SelectedValue;

            Dictionary<string, object?> paramsRecibo = new Dictionary<string, object?>()
            {
                {"reciboID" , reciboID  },
                {"compraID" , cbCompra.SelectedValue  },

                {"socID"  ,  cbSocio.SelectedValue },
                {"listPrecID", cbListaPrecio.SelectedValue  },
                {"fecha"  , dateTimePicker1.Value.ToString("yyyy/MM/dd") },
                {"metodoPago" , cbMetodoPago.SelectedItem },
                {"empleadoID" , cbEmpleado.SelectedValue  },
                {"estado" , cbEstado.SelectedItem }
            };

            DataTable? tablaResultante = recSQL.EjecutarSPDataTable("spAddUpdateRecibo", "detalle", "TipoReciboDetalle", tbDet, paramsRecibo);

            if (tablaResultante != null)
            {
                reciboID = reciboID == 0 ? Convert.ToInt32(tablaResultante.Rows[0][0]) : reciboID;

                MessageBox.Show("Recibo guardado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ObtenerDatos(reciboID, compraID);
            }
            else
            {
                MessageBox.Show("Ocurrió un error al guardar el recibo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tablaReciboDetalle_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (tablaReciboDetalle.Rows.Count <= 2)
            {
                tablaReciboDetalle.AllowUserToDeleteRows = false;
            }

            CalculaTotalFinal();
        }

        private void tablaReciboDetalle_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void cbCompra_SelectionChangeCommitted(object sender, EventArgs e)
        {
            compraID = (int)cbCompra.SelectedValue;

            ToggleReadOnly(false);

            ObtenerDatos(reciboID, compraID);
        }

        private void tablaReciboDetalle_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void tablaReciboDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
