using AgroLink.Recursos;
using System.Data;
using System.Windows.Forms;

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


            //Llena tabla detalle
            Dictionary<string, object> parametros = new Dictionary<string, object>() {
                {"ventID", id }
            };

            tablaDetalle.AutoGenerateColumns = false;
            tablaDetalle.DataSource = recSQL.EjecutarSPDataTable("spTraeVentaDetalle", parametros);


            //Llena los comboboxes de tabla detalle
            DataGridViewComboBoxColumn colProducto = (DataGridViewComboBoxColumn) tablaDetalle.Columns["ProductoID"];
            colProducto.DataSource = recSQL.EjecutarVista("vTraeProductos");
            colProducto.DisplayMember = "Producto";
            colProducto.ValueMember = "ProductoID";

            DataGridViewComboBoxColumn colBodega = (DataGridViewComboBoxColumn)tablaDetalle.Columns["BodegaID"];
            colBodega.DataSource = recSQL.EjecutarVista("vTraeBodega");
            colBodega.DisplayMember = "Bodega";
            colBodega.ValueMember = "BodegaID";

            DataGridViewComboBoxColumn colImpuesto = (DataGridViewComboBoxColumn)tablaDetalle.Columns["ImpuestoID"];
            colImpuesto.DataSource = recSQL.EjecutarVista("vTraeImpuesto");
            colImpuesto.DisplayMember = "Impuesto";
            colImpuesto.ValueMember = "ImpuestoID";




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



        private void tablaDetalle_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;

        }


    }
}
