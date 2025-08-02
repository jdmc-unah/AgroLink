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



namespace AgroLink.Pantallas.Pantallas_Transacciones.Pantalla_SalidaProducto
{
    public partial class SalidaProductoDetalle : Form
    {

        public Form FormPadre { get; set; }  //Formulario Padre

        public int salidaID { get; set; }

        public int ventaID { get; set; }


        public SalidaProductoDetalle()
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

            dateTimePicker1.Enabled = !esSoloLectura;


            tablaDetalle.ReadOnly = esSoloLectura;


            btnAceptar.Visible = !esSoloLectura;
            btnCancelar.Visible = !esSoloLectura;
            btnEditar.Visible = esSoloLectura;

            btnBorrarSalProd.Visible = salidaID !=0 ?  !esSoloLectura : false ;

            if (salidaID != 0)
            {
                string estadoEdicion = esSoloLectura ? "desactivado" : "activado";
                MessageBox.Show($"El modo edicion esta {estadoEdicion} ");
            }

        }

        //cambia la visibilidad de los componentes si es una transferencia o no
        public void ToggleCheckVisibility(bool esTransferencia)
        {
            comboBodDestino.Visible = esTransferencia;
            labelBodDest.Visible = esTransferencia;

            labelVent.Visible = !esTransferencia;
            comboVenta.Visible = !esTransferencia;
            labelSocio.Visible = !esTransferencia;
            comboSocio.Visible = !esTransferencia;

            tablaDetalle.ReadOnly = !esTransferencia;

            groupTipoOperacion.Visible = false;

        }

        void LlenaCombosSuperiores()
        {
            comboSocio.DataSource = recSQL.EjecutarVista("vTraeSocio");  // Asignar el origen de datos
            comboSocio.DisplayMember = "Socio";         // Columna que se mostrará
            comboSocio.ValueMember = "SocioID";   // Valor interno que se usará

            Dictionary<string, object> filtroVentas = new Dictionary<string, object>() {
                {"ventID",   ventaID }
            };

            comboVenta.DataSource = salidaID != 0 ? recSQL.EjecutarSPDataTable("spTraeVentasCode", filtroVentas) : recSQL.EjecutarSPDataTable("spTraeVentasSalidaComp");
            comboVenta.DisplayMember = "CodigoVenta";
            comboVenta.ValueMember = "VentaID";


            comboBodDestino.DataSource = recSQL.EjecutarVista("vTraeBodega");
            comboBodDestino.DisplayMember = "Bodega";
            comboBodDestino.ValueMember = "BodegaID";





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

        }


        public void ObtenerDatos(int salID, int ventID)
        {

            //Trae Campos Superiores

            Dictionary<string, object> parametros = new Dictionary<string, object>() {
                {"salID", salID },
                {"ventID", ventID }
            };

            DataTable facturaFiltrada = recSQL.EjecutarSPDataTable("spTraeSalidaFiltrada", parametros);




            //Verifica si es una transferencia interna nueva
            if (facturaFiltrada.Rows.Count != 0)
            {
                //Llena Campos superiores

                tbCodigo.Text = facturaFiltrada.Rows[0]["CodigoSalida"].ToString();

                dateTimePicker1.Value = Convert.ToDateTime(facturaFiltrada.Rows[0]["Fecha"]);

                LlenaCombosSuperiores();
                comboSocio.SelectedValue = Convert.ToInt32(facturaFiltrada.Rows[0]["SocioID"]);
                comboVenta.SelectedValue = Convert.ToInt32(facturaFiltrada.Rows[0]["VentaID"]);
                comboBodDestino.SelectedValue = Convert.ToInt32(facturaFiltrada.Rows[0]["BodegaDestinoID"]);


                //Trae y configura datos de venta detalle
                DataTable dt = recSQL.EjecutarSPDataTable("spTraeSalidaDetalle", parametros);
                dt.Columns["SalidaID"].AutoIncrement = false;
                dt.Columns["SalidaID"].DefaultValue = 0;
                dt.Columns["CodigoProducto"].DefaultValue = "PRO";

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
                LlenaComboDetalle();
            }


        }



        #endregion



        private void SalidaProductoDetalle_Load(object sender, EventArgs e)
        {
            //Valida si es para actualizar una salida o crear una nueva salida
            if (salidaID == 0)
            {
                comboVenta.Enabled = true;
                comboBodDestino.Enabled = true;
                ToggleReadOnly(false);
            }
            else
            {
                if (ventaID == 0) radioTransfInterna.Checked = true;
            }

            //si la venta es distinto de cero es porque la salida es basada en una venta
            if (ventaID != 0)




            {
                comboVenta.Enabled = false;
                groupTipoOperacion.Visible = false;

            }


            //carga los datos 
            ObtenerDatos(salidaID, ventaID);
            tablaDetalle.AllowUserToDeleteRows = false;


        }


        private void comboVenta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ventaID = (int)comboVenta.SelectedValue;

            ToggleReadOnly(false);

            ObtenerDatos(salidaID, ventaID);

            groupTipoOperacion.Visible = false;

        }


        //controla el check para elegir si es salida por transferencia interna o basada en una venta
        private void radioTransfInterna_CheckedChanged(object sender, EventArgs e)
        {
            ToggleCheckVisibility(!comboBodDestino.Visible);
        }



        #region Botones

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ToggleReadOnly(false);

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(FormPadre, this);

        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ToggleReadOnly(true);

            //Toma datos de tablaDetalle 
            DataTable tbDet = metodosGlobales.CrearDataTable(tablaDetalle);


            //Toma los datos de la parte superior y los asigna a los parametros del sp
            Dictionary<string, object?> paramsSal = new Dictionary<string, object?>() {
                {"salID" , salidaID},
                {"ventID" , (ventaID == 0 && salidaID == 0)  ?  null : comboVenta.SelectedValue  }, //valida si es una transferencia interna
                {"socID"  , (ventaID == 0 && salidaID == 0)  ?  null : comboSocio.SelectedValue },
                {"fecha"  , dateTimePicker1.Value.ToString("yyyy/MM/dd") },
                {"bodDest", (ventaID == 0 || ventaID == null )  ? comboBodDestino.SelectedValue :  null }
            };



            //Agrega o actualiza la venta pasando los parametros anteriores
            DataTable? tablaResultante = recSQL.EjecutarSPDataTable("spAddUpdateSalProd", "detalle", "TipoSalidaProducto", tbDet, paramsSal);


            if (tablaResultante != null)
            {
                //si es una nueva venta, actualiza el valor con el de la tabla resultante
                salidaID = salidaID == 0 ? Convert.ToInt32(tablaResultante.Rows[0][0]) : salidaID;


                if (radioTransfInterna.Checked)
                {
                    MessageBox.Show("Cambios guardados con exito");
                    ObtenerDatos(salidaID, ventaID);
                }
                else
                {

                    if (metodosGlobales.MensajeConfirmacion("Confirmacion", "Cambios guardados \n ¿Desea crear una entrega?"))
                    {
                        Pantallas_Entrega.EntregaDetalle formEntrDet = new Pantallas_Entrega.EntregaDetalle();
                        formEntrDet.salidaID = salidaID;
                        formEntrDet.FormPadre = this;
                        PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(this, formEntrDet);
                    }
                    else
                    {
                        ObtenerDatos(salidaID, ventaID);
                    }
                }


            }

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {

            ToggleReadOnly(true);

            if (salidaID != 0)
            {
                ObtenerDatos(salidaID, ventaID);
            }
            else
            {
                PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(FormPadre, this);
            }
        }



        private void btnBorrarSalProd_Click(object sender, EventArgs e)
        {
            if (metodosGlobales.MensajeConfirmacion("Confirmar Eliminación", $"¿Está seguro que desea borrar la salida de producto {tbCodigo.Text}? \nIMPORTANTE: Esta operación es irreversible!"))
            {
                Dictionary<string, object?> param = new Dictionary<string, object?>() {
                    {"salID", salidaID }
                };

                DataTable? resultado = recSQL.EjecutarSPDataTable("spBorrarSalProd", param) ;

                MessageBox.Show(resultado != null ? resultado.Rows[0][0].ToString() : "Operación cancelada" );

                PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(FormPadre, this);

            }
        }

        #endregion



        #region Tabla Detalle
        private void tablaDetalle_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void tablaDetalle_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {

            if (tablaDetalle.Rows.Count <= 2)
            {
                tablaDetalle.AllowUserToDeleteRows = false;
            }
        }

        private void tablaDetalle_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if ( (tablaDetalle.Columns[e.ColumnIndex].Name != "Cantidad" && radioTransfInterna.Checked && salidaID !=0 ) ||  radioSalidaVenta.Checked )
            {
                e.Cancel = true; // Cancela la edición para otras columnas que no sea cantidad
            }
        }
        #endregion








    }
}
