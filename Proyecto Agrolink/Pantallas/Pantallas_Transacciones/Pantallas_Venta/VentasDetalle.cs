using AgroLink.Recursos;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AgroLink.Pantallas.Pantallas_Transacciones.Pantallas_Venta
{
    public partial class VentasDetalle : Form
    {
        public Venta ventaForm { get; set; }  //Formulario Padre

        public int ventaID { get; set; }
        public string codigo { get; set; }
        public DateTime fecha { get; set; }
        public int socioID { get; set; }
        public string socio { get; set; }
        public string tipoSocio { get; set; }
        public int listaPreID { get; set; }
        public string listaPrecio { get; set; }
        public string tipoPago { get; set; }
        public string estado { get; set; }



        public VentasDetalle()
        {
            InitializeComponent();
        }


        Recursos_SQL recSQL = new Recursos_SQL();

        DataTable comboImp;


        #region Metodos

        public void ObtenerDatos(int id)
        {

            //Llena Campos Superiores

            tbCodigo.Text = codigo;

            dateTimePicker1.Value = fecha;

            LlenaSocio();
            comboSocio.SelectedValue = socioID;

            LlenaListaPrecios();
            comboListaPrecio.SelectedValue = listaPreID;

            comboTipoPago.SelectedItem = tipoPago;

            comboEstado.SelectedItem = estado;


            //Trae y configura datos de venta detalle
            Dictionary<string, object> parametros = new Dictionary<string, object>() {
                {"ventID", id }
            };

            DataTable dt = recSQL.EjecutarSPDataTable("spTraeVentaDetalle", parametros);
            dt.Columns["VentaID"].AutoIncrement = false;

            dt.Columns["VentaID"].DefaultValue = 0;
            dt.Columns["CodigoProducto"].DefaultValue = "PRO";
            dt.Columns["Subtotal"].DefaultValue = 0;
            dt.Columns["SubTotal"].ReadOnly = false;

            tablaDetalle.AutoGenerateColumns = false; //esto es para que le haga caso al orden de columnas del datagridview

            tablaDetalle.DataSource = dt;


            //Llena los comboboxes de tabla detalle
            DataGridViewComboBoxColumn colProducto = (DataGridViewComboBoxColumn)tablaDetalle.Columns["ProductoID"];
            colProducto.DataSource = recSQL.EjecutarVista("vTraeProductos");
            colProducto.DisplayMember = "Producto";
            colProducto.ValueMember = "ProductoID";

            DataGridViewComboBoxColumn colBodega = (DataGridViewComboBoxColumn)tablaDetalle.Columns["BodegaID"];
            colBodega.DataSource = recSQL.EjecutarVista("vTraeBodega");
            colBodega.DisplayMember = "Bodega";
            colBodega.ValueMember = "BodegaID";

            DataGridViewComboBoxColumn colImpuesto = (DataGridViewComboBoxColumn)tablaDetalle.Columns["ImpuestoID"];
            comboImp = recSQL.EjecutarVista("vTraeImpuesto");
            colImpuesto.DataSource = comboImp;
            colImpuesto.DisplayMember = "Impuesto";
            colImpuesto.ValueMember = "ImpuestoID";


            /* OJO Si por defecto los campos dentro de una vista o sp que sean de 
             * otra tabla que no sea la tabla principal son solo lectura asi que cuidado con eso  */

        }


        public void ToggleReadOnly(bool esSoloLectura)
        {

            comboEstado.Enabled = !esSoloLectura;
            comboSocio.Enabled = !esSoloLectura;
            comboTipoPago.Enabled = !esSoloLectura;
            comboListaPrecio.Enabled = !esSoloLectura;
            dateTimePicker1.Enabled = !esSoloLectura;

            tablaDetalle.ReadOnly = esSoloLectura;

            btnAceptar.Visible = !esSoloLectura;
            btnCancelar.Visible = !esSoloLectura;

        }


        void LlenaSocio()
        {
            comboSocio.DataSource = recSQL.EjecutarVista("vTraeSocio");  // Asignar el origen de datos
            comboSocio.DisplayMember = "Socio";         // Columna que se mostrará
            comboSocio.ValueMember = "SocioID";   // Valor interno que se usará

        }


        void LlenaListaPrecios()
        {
            comboListaPrecio.DataSource = recSQL.EjecutarVista("vTraeListaPrecios");  // Asignar el origen de datos
            comboListaPrecio.DisplayMember = "ListPrecios";         // Columna que se mostrará
            comboListaPrecio.ValueMember = "ListaPreciosID";   // Valor interno que se usará

        }

        #endregion



        private void VentasDetalle_Load(object sender, EventArgs e)
        {
            ObtenerDatos(ventaID);

        }



        #region Botones

        private void btnVolver_Click(object sender, EventArgs e)
        {

            PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(ventaForm, this);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ToggleReadOnly(false);



        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ToggleReadOnly(true);




        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ToggleReadOnly(true);

        }




        #endregion



        #region Tabla Venta


        private void tablaDetalle_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.ToString());
            //e.Cancel = true;
        }



        //Hace calculos automaticos para reflejar cambios en subtotal y total

        int cant; double precio, imp = 0 , subtotal;

        private void tablaDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            //Toma el indice de la fila seleccionada y el valor seleccionado 
            int row = tablaDetalle.CurrentRow.Index;
            int column = tablaDetalle.CurrentCell.ColumnIndex;

            cant = Convert.ToInt32((this.tablaDetalle.Rows[row].Cells["Cantidad"].Value.GetType() == typeof(DBNull)) ? 0 : this.tablaDetalle.Rows[row].Cells["Cantidad"].Value);
            precio = Convert.ToDouble((this.tablaDetalle.Rows[row].Cells["Precio"].Value.GetType() == typeof(DBNull)) ? 0 : this.tablaDetalle.Rows[row].Cells["Precio"].Value);
            
            double impID = Convert.ToDouble((this.tablaDetalle.Rows[row].Cells["ImpuestoID"].Value.GetType() == typeof(DBNull)) ? 0 : this.tablaDetalle.Rows[row].Cells["ImpuestoID"].Value);

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
                tablaDetalle.Rows[row].Cells["Subtotal"].Value = subtotal;
            }

            if (imp != 0 && subtotal != 0)
            {
                tablaDetalle.Rows[row].Cells["Total"].Value = subtotal * (imp +1);
            }








        }

        #endregion

    }
}
