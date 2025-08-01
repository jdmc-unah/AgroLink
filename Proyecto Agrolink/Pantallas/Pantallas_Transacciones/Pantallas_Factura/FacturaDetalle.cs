using AgroLink.Pantallas.Pantallas_Transacciones.Pantallas_Venta;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AgroLink.Pantallas.Pantallas_Transacciones.Pantallas_Factura
{
    public partial class FacturaDetalle : Form
    {

        public Form FormPadre { get; set; }  //Formulario Padre

        public int facturaID { get; set; }

        public int ventaID { get; set; }

        public FacturaDetalle()
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

            comboEstado.Enabled = !esSoloLectura;
            comboMetodoPago.Enabled = !esSoloLectura;
            comboEmpleado.Enabled = !esSoloLectura;

            comboVenta.Enabled = facturaID != 0 ? false : true;
            comboNumFiscalID.Enabled = facturaID == 0 ? !esSoloLectura : esSoloLectura;

            dateTimePicker1.Enabled = !esSoloLectura;

            btnAceptar.Visible = !esSoloLectura;
            btnCancelar.Visible = !esSoloLectura;
            btnEditar.Visible = esSoloLectura;

            if (facturaID != 0)
            {
                string estadoEdicion = esSoloLectura ? "desactivado" : "activado";
                MessageBox.Show($"El modo edicion esta {estadoEdicion} ");
            }

        }




        void LlenaCombosSuperiores()
        {
            comboSocio.DataSource = recSQL.EjecutarVista("vTraeSocio");  // Asignar el origen de datos
            comboSocio.DisplayMember = "Socio";         // Columna que se mostrará
            comboSocio.ValueMember = "SocioID";   // Valor interno que se usará

            comboListaPrecio.DataSource = recSQL.EjecutarVista("vTraeListaPrecios");
            comboListaPrecio.DisplayMember = "ListPrecios";
            comboListaPrecio.ValueMember = "ListaPreciosID";

            comboEmpleado.DataSource = recSQL.EjecutarVista("vTraeEmpleado");
            comboEmpleado.DisplayMember = "Empleado";
            comboEmpleado.ValueMember = "EmpleadoID";



            Dictionary<string, object> filtroVentasAbiertas = new Dictionary<string, object>() {
                {"ventID",  ventaID}
            };



            comboVenta.DataSource = recSQL.EjecutarSPDataTable("spTraeVentasCode", filtroVentasAbiertas);
            comboVenta.DisplayMember = "CodigoVenta";
            comboVenta.ValueMember = "VentaID";



            comboNumFiscalID.DataSource = recSQL.EjecutarVista("vTraeNumFiscal");
            comboNumFiscalID.DisplayMember = "NumFiscalID";
            comboNumFiscalID.ValueMember = "NumFiscalID";



        }



        void LlenaComboDetalle()
        {

            //Llena los comboboxes de tabla detalle con las vistas
            DataGridViewComboBoxColumn colProducto = (DataGridViewComboBoxColumn)tablaDetalle.Columns["ProductoID"];
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




        public void ObtenerDatos(int factID, int ventID)
        {

            //Trae Campos Superiores

            Dictionary<string, object> parametros = new Dictionary<string, object>() {
                {"factID", factID },
                {"ventID", ventID }
            };

            DataTable facturaFiltrada = recSQL.EjecutarSPDataTable("spTraeFacturaFiltrada", parametros);

            //Verifica si es una factura que no esta vinculada a ninguna venta
            if (facturaFiltrada.Rows.Count != 0)
            {
                //Llena Campos superiores

                tbCodigo.Text = facturaFiltrada.Rows[0]["CodigoFactura"].ToString();
                tbCAI.Text = facturaFiltrada.Rows[0]["CAI"].ToString();

                dateTimePicker1.Value = Convert.ToDateTime(facturaFiltrada.Rows[0]["Fecha"]);

                LlenaCombosSuperiores();
                comboSocio.SelectedValue = Convert.ToInt32(facturaFiltrada.Rows[0]["SocioID"]);
                comboListaPrecio.SelectedValue = Convert.ToInt32(facturaFiltrada.Rows[0]["ListaPreciosID"]);
                comboEmpleado.SelectedValue = Convert.ToInt32(facturaFiltrada.Rows[0]["EmpleadoID"]);
                comboVenta.SelectedValue = Convert.ToInt32(facturaFiltrada.Rows[0]["VentaID"]);
                comboNumFiscalID.SelectedValue = Convert.ToInt32(facturaFiltrada.Rows[0]["NumFiscalID"]);

                comboMetodoPago.SelectedItem = facturaFiltrada.Rows[0]["MetodoPago"].ToString();
                comboEstado.SelectedItem = (facturaFiltrada.Rows[0]["Estado"]).ToString();


                //Trae y configura datos de venta detalle
                DataTable dt = recSQL.EjecutarSPDataTable("spTraeFacturaDetalle", parametros);
                dt.Columns["FacturaID"].AutoIncrement = false;

                dt.Columns["FacturaID"].DefaultValue = 0;
                dt.Columns["CodigoProducto"].DefaultValue = "PRO";
                dt.Columns["Subtotal"].DefaultValue = 0;
                dt.Columns["SubTotal"].ReadOnly = false;

                tablaDetalle.AutoGenerateColumns = false; //esto es para que le haga caso al orden de columnas del datagridview

                tablaDetalle.DataSource = dt;

                LlenaComboDetalle();


                if (tablaDetalle.Rows.Count <= 2)
                {
                    tablaDetalle.AllowUserToDeleteRows = false;
                }
                else
                {
                    tablaDetalle.AllowUserToDeleteRows = true;
                }

            }
            else
            {
                LlenaCombosSuperiores();
                comboEstado.SelectedItem = "Abierto";
                LlenaComboDetalle();
            }

            CalculaTotalFinal();

        }



        public void CalculaTotalFinal()
        {
            DataTable tablaTotales = recSQL.EjecutarFuncion("dbo.fCalcularTotalesFact", "tablaTotales", "TipoFacturaDetalle", metodosGlobales.CrearDataTable(tablaDetalle));
            tbSubtotal.Text = tablaTotales.Rows[0][0].ToString();
            tbTotal.Text = tablaTotales.Rows[0][1].ToString();
        }

        #endregion



        private void FacturaDetalle_Load(object sender, EventArgs e)
        {
            //Valida si es para actualizar una venta o crear una nueva venta
            if (facturaID == 0)
            {
                comboVenta.Enabled = true;

                ToggleReadOnly(false);
            }

            //carga los datos 
            ObtenerDatos(facturaID, ventaID);


        }



        private void comboVenta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ventaID = (int)comboVenta.SelectedValue;

            ToggleReadOnly(false);

            ObtenerDatos(facturaID, ventaID);
        }


        #region Botones

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(FormPadre, this);

        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (comboEstado.SelectedItem == "Abierto")
            {
                ToggleReadOnly(false);
            }
            else
            {
                MessageBox.Show("Las facturas Cerradas o Canceladas no pueden editarse");
            }



        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {

            //ToggleReadOnly(true);

            //Toma datos de tablaDetalle 
            DataTable tbDet = metodosGlobales.CrearDataTable(tablaDetalle);

            ventaID = Convert.ToInt32(comboVenta.SelectedValue != null ? comboVenta.SelectedValue : 0);


            //Toma los datos de la parte superior y los asigna a los parametros del sp
            Dictionary<string, object?> paramsFact = new Dictionary<string, object?>() {
                {"factID" , facturaID  },
                {"ventID" , ventaID  },

                {"socID"  ,  comboSocio.SelectedValue },
                {"listPrecID", comboListaPrecio.SelectedValue  },
                {"fecha"  , dateTimePicker1.Value.ToString("yyyy/MM/dd") },
                {"metodoPago" , comboMetodoPago.SelectedItem },
                { "cai" , tbCAI.Text },
                { "empleadoID" , comboEmpleado.SelectedValue  },
                { "numFiscalID" , comboNumFiscalID.SelectedValue },
                {"estado" , comboEstado.SelectedItem }
            };

            //Agrega o actualiza la venta pasando los parametros anteriores
            DataTable? tablaResultante = recSQL.EjecutarSPDataTable("spAddUpdateFactura", "detalle", "TipoFacturaDetalle", tbDet, paramsFact);


            if (tablaResultante != null)
            {
                //si es una nueva venta, actualiza el valor con el de la tabla resultante
                facturaID = facturaID == 0 ? Convert.ToInt32(tablaResultante.Rows[0][0]) : facturaID;


                if (metodosGlobales.MensajeConfirmacion("Confirmacion", "Cambios guardados \n ¿Desea crear una salida de producto?"))
                {

                    Pantalla_SalidaProducto.SalidaProductoDetalle formSalidaDet = new Pantalla_SalidaProducto.SalidaProductoDetalle();
                    formSalidaDet.ventaID = ventaID;
                    formSalidaDet.FormPadre = this;
                    PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(this, formSalidaDet);
                }
                else
                {
                    ObtenerDatos(facturaID, ventaID);
                }
            }


        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ToggleReadOnly(true);

            if (facturaID != 0)
            {
                ObtenerDatos(facturaID, ventaID);
            }
            else
            {
                PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(FormPadre, this);
            }
        }


        private void btnNuevaSalProd_Click(object sender, EventArgs e)
        {

            Pantalla_SalidaProducto.SalidaProductoDetalle formSalidaDet = new Pantalla_SalidaProducto.SalidaProductoDetalle();
            formSalidaDet.ventaID = ventaID;
            formSalidaDet.FormPadre = this;
            PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(this, formSalidaDet);

        }


        #endregion




        #region Tabla Detalle
        private void tablaDetalle_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }


        private void tablaDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {


        }



        private void tablaDetalle_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {

            if (tablaDetalle.Rows.Count <= 2)
            {
                tablaDetalle.AllowUserToDeleteRows = false;
            }

            CalculaTotalFinal();

        }



        #endregion







        
    }
}
