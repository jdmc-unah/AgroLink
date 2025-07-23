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
        public Compra compraForm { get; set; }  //Formulario Padre

        public int compraID { get; set; }
        public string codigo { get; set; }
        public DateTime fecha { get; set; }
        public int socioID { get; set; }
        public string socio { get; set; }
        public string tipoSocio { get; set; }
        public int listaPreciosID { get; set; }
        public string listaPrecios { get; set; }
        public string tipoPago { get; set; }
        public string estado { get; set; }

        public CompraDetalle()
        {
            InitializeComponent();
        }

        Recursos_SQL recSQL = new Recursos_SQL();
        MetodosGlobales metodosGlobales = new MetodosGlobales();

        DataTable comboImp;

        private void CompraDetalle_Load(object sender, EventArgs e)
        {
            ObtenerDatos(compraID);
        }

        int cant; double precio, imp = 0, subtotal;

        private void tablaCompraDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int row = tablaCompraDetalle.CurrentRow.Index;

            cant = Convert.ToInt32((this.tablaCompraDetalle.Rows[row].Cells["Cantidad"].Value.GetType() == typeof(DBNull)) ? 0 : this.tablaCompraDetalle.Rows[row].Cells["Cantidad"].Value);
            precio = Convert.ToDouble((this.tablaCompraDetalle.Rows[row].Cells["Precio"].Value.GetType() == typeof(DBNull)) ? 0 : this.tablaCompraDetalle.Rows[row].Cells["Precio"].Value);

            double impID = Convert.ToDouble((this.tablaCompraDetalle.Rows[row].Cells["ImpuestoID"].Value.GetType() == typeof(DBNull)) ? 0 : this.tablaCompraDetalle.Rows[row].Cells["ImpuestoID"].Value);

            if (impID != 0)
            {
                foreach (DataRow fila in comboImp.Rows)
                {
                    if ((int)fila["ImpuestoID"] == impID)
                    {
                        imp = Convert.ToDouble(fila["Impuesto"]);
                        break;
                    }
                }
            }

            if (cant != 0 && precio != 0)
            {
                subtotal = cant * precio;
                tablaCompraDetalle.Rows[row].Cells["Subtotal"].Value = subtotal;
            }

            if (imp != 0 && subtotal != 0)
            {
                tablaCompraDetalle.Rows[row].Cells["Total"].Value = subtotal * (imp + 1);
            }
        }

        #region Metodos

                public void ObtenerDatos(int id)
                {
                    tbCodigoCompra.Text = codigo;
                    dateTimePicker1.Value = fecha;

                    LlenaSocio();
                    cbSocioCompra.SelectedValue = socioID;

                    LlenaListaPrecios();
                    cbListaPrecioCompra.SelectedValue = listaPreciosID;

                    cbTipoPagoCompra.SelectedItem = tipoPago;
                    cbEstadoCompra.SelectedItem = estado;

                    // llenamos la tabla compra detalle 

                    Dictionary<string, object> parametros = new Dictionary<string, object>()
                    {
                        { "compraID", id }
                    };

                    DataTable dt = recSQL.EjecutarSPDataTable("spTraeCompraDetalle", parametros);

                    dt.Columns["CompraID"].AutoIncrement = false;

                    dt.Columns["CompraID"].DefaultValue = 0;
                    dt.Columns["CodigoProducto"].DefaultValue = "PRO";
                    dt.Columns["Subtotal"].DefaultValue = 0;
                    dt.Columns["SubTotal"].ReadOnly = false;

                    tablaCompraDetalle.AutoGenerateColumns = false;
                    tablaCompraDetalle.DataSource = dt;

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

                public void ToggleReadOnly(bool esSoloLectura)
                {

                    cbEstadoCompra.Enabled = !esSoloLectura;
                    cbSocioCompra.Enabled = !esSoloLectura;
                    cbTipoPagoCompra.Enabled = !esSoloLectura;
                    cbListaPrecioCompra.Enabled = !esSoloLectura;
                    dateTimePicker1.Enabled = !esSoloLectura;

                    tablaCompraDetalle.ReadOnly = esSoloLectura;

                    btnAceptarCompra.Visible = !esSoloLectura;
                    btnCancelarCompra.Visible = !esSoloLectura;

                }

                void LlenaSocio()
                {
                    cbSocioCompra.DataSource = recSQL.EjecutarVista("vTraeSocio");  // Origen de datos correcto
                    cbSocioCompra.DisplayMember = "Socio";                          // Muestra el nombre o alias del socio
                    cbSocioCompra.ValueMember = "SocioID";                          // Usa el ID del socio como valor
                }

                void LlenaListaPrecios()
                {
                    cbListaPrecioCompra.DataSource = recSQL.EjecutarVista("vTraeListaPrecios");
                    cbListaPrecioCompra.DisplayMember = "ListaPrecios";              // Lo que se muestra
                    cbListaPrecioCompra.ValueMember = "ListaPreciosID";             // Lo que se usa internamente
                }

                #endregion
        
        private void tbCodigoCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(compraForm, this);
        }

        private void btnCancelarCompra_Click(object sender, EventArgs e)
        {
            ToggleReadOnly(true);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ToggleReadOnly(false);
        }

        private void btnAceptarCompra_Click(object sender, EventArgs e)
        {
            ToggleReadOnly(true);

            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                { "compraid", compraID }
            };

            if (recSQL.EjecutarSPBool("spAgregarCompraDetalle", "detalle", "TipoCompraDetalle", metodosGlobales.CrearDataTable(tablaCompraDetalle), parametros))
            {
                ObtenerDatos(compraID);
            }
        }

        private void tablaCompraDetalle_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.ToString());
        }
    }
}
