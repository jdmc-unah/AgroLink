using AgroLink.Recursos;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AgroLink.Pantallas.Pantallas_Transacciones.Pantallas_Venta
{

    

    public partial class VentasDetalle : Form
    {
        public Venta ventaForm { get; set; }  //Formulario Padre

        public int ventaID { get; set; }    //si esto es 0 es porque es una nueva venta, de lo contrario toma el dato de la venta a editar

        public VentasDetalle()
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
            comboSocio.Enabled = !esSoloLectura;
            comboTipoPago.Enabled = !esSoloLectura;
            comboListaPrecio.Enabled = !esSoloLectura;
            dateTimePicker1.Enabled = !esSoloLectura;

            tablaDetalle.ReadOnly = esSoloLectura;
            tablaDetalle.AllowUserToDeleteRows = !esSoloLectura;

            btnAceptar.Visible = !esSoloLectura;
            btnCancelar.Visible = !esSoloLectura;
            btnEditar.Visible = esSoloLectura;

            if (ventaID != 0)
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


        public void ObtenerDatos(int id)
        {

            //Trae Campos Superiores

            Dictionary<string, object> parametros = new Dictionary<string, object>() {
                {"ventID", id }
            };

            DataTable ventaFiltrada = recSQL.EjecutarSPDataTable("spTraeVentaFiltrada", parametros);


            //Llena Campos superiores

            tbCodigo.Text = ventaFiltrada.Rows[0]["CodigoVenta"].ToString();

            dateTimePicker1.Value = Convert.ToDateTime(ventaFiltrada.Rows[0]["Fecha"]);

            LlenaCombosSuperiores();
            comboSocio.SelectedValue = Convert.ToInt32(ventaFiltrada.Rows[0]["SocioID"]);
            comboListaPrecio.SelectedValue = Convert.ToInt32(ventaFiltrada.Rows[0]["ListaPreciosID"]);

            comboTipoPago.SelectedItem = ventaFiltrada.Rows[0]["TipoPago"].ToString();

            comboEstado.SelectedItem = (ventaFiltrada.Rows[0]["Estado"]).ToString();



            //Trae y configura datos de venta detalle
            DataTable dt = recSQL.EjecutarSPDataTable("spTraeVentaDetalle", parametros);
            dt.Columns["VentaID"].AutoIncrement = false;

            dt.Columns["VentaID"].DefaultValue = 0;
            dt.Columns["CodigoProducto"].DefaultValue = "PRO";
            dt.Columns["Subtotal"].DefaultValue = 0;
            dt.Columns["SubTotal"].ReadOnly = false;

            tablaDetalle.AutoGenerateColumns = false; //esto es para que le haga caso al orden de columnas del datagridview

            tablaDetalle.DataSource = dt;

            LlenaComboDetalle();

            /* OJO Si por defecto los campos dentro de una vista o sp que sean de 
             * otra tabla que no sea la tabla principal son solo lectura asi que cuidado con eso  */

        }


        #endregion



        private void VentasDetalle_Load(object sender, EventArgs e)
        {

            //Valida si es para actualizar una venta o crear una nueva venta
            if (ventaID != 0)
            {
                //carga los datos de la venta a actualizar
                ObtenerDatos(ventaID);
            }
            else
            {
                //carga la pantalla para agregar una nueva venta
                LlenaCombosSuperiores();
                comboEstado.SelectedItem = "Abierto";

                LlenaComboDetalle();
                ToggleReadOnly(false);
            }

        }



        #region Botones

        private void btnVolver_Click(object sender, EventArgs e)
        {

            PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(ventaForm, this);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (comboEstado.SelectedItem == "Abierto"  )
            {
                ToggleReadOnly(false);
            }
            else
            {
                MessageBox.Show("Las ventas Cerradas o Canceladas no pueden editarse");
            }

            
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ToggleReadOnly(true);



            DataTable tbDet = metodosGlobales.CrearDataTable(tablaDetalle);
            DataTable validacion = recSQL.EjecutarFuncion("dbo.fValidaVenta", "detalle", "TipoVentaDetalle", tbDet);

            //este if valida si devolvio un error la validacion usando la funcion que esta arriba
            if (validacion.Rows[0][0].ToString() == "")
            {


                //Toma los datos de la parte superior y los asigna a los parametros del sp

                Dictionary<string, object> paramsVent = new Dictionary<string, object>() {
                {"ventID" , ventaID  },
                {"fecha"  , dateTimePicker1.Value.ToString("yyyy/MM/dd") },
                {"socID"  , comboSocio.SelectedValue     },
                {"listPrecID", comboListaPrecio.SelectedValue  },
                {"tipoPago" , comboTipoPago.SelectedItem },
                {"estado" , comboEstado.SelectedItem }
            };

                //Agrega o actualiza la venta
                DataTable tablaResultante = recSQL.EjecutarSPDataTable("spAddUpdateVenta", paramsVent);

                if (tablaResultante != null)
                {
                    //Actualiza la propiedad ventaid con el resultado de la operacion anterior
                    ventaID = ventaID == 0 ? Convert.ToInt32(tablaResultante.Rows[0][0]) : ventaID;


                    Dictionary<string, object> paramsDet = new Dictionary<string, object>() {
                {"ventID" , ventaID  }
                };

                    //Agrega o actualiza la ventadetalle
                    if (recSQL.EjecutarSPBool("spAddUpdateVentaDet", "detalle", "TipoVentaDetalle", tbDet, paramsDet))
                    {
                        //MessageBox.Show("Cambios guardados con exito");

                        if(metodosGlobales.MensajeConfirmacion("Confirmacion", "Cambios guardados \n ¿Desea crear una factura?"))
                        {
                            PantallaPrincipal.instanciaPantPrincipal.OpenChildForm( new Pantallas_Factura.Factura() );
                        }
                        else
                        {
                            ObtenerDatos(ventaID);
                        }

                        
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error inesperado");
                        //this.btnCancelar_Click(sender, e);
                    }

                }
                else
                {
                    MessageBox.Show("Ocurrio un error inesperado");
                    //this.btnCancelar_Click(sender, e);

                }

            }
            else
            {
                MessageBox.Show(validacion.Rows[0][0].ToString());

            }


        }




        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ToggleReadOnly(true);

            if (ventaID != 0)
            {
                ObtenerDatos(ventaID);
            }
            else
            {
                PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(ventaForm, this);
            }
        }




        #endregion



        #region Tabla Detalle


        private void tablaDetalle_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }



        //Hace calculos automaticos para reflejar cambios en subtotal y total
        private void tablaDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
            //Toma el indice de la fila seleccionada y el valor seleccionado 
            int row = tablaDetalle.CurrentRow.Index;
            int column = tablaDetalle.CurrentCell.ColumnIndex;

            int cant = 0; double precio = 0;  int impID = 0;

            //Trae los datos del datagridview
            object celdaCant = tablaDetalle.Rows[row].Cells["Cantidad"].Value;
            object celdaPrecio = tablaDetalle.Rows[row].Cells["Precio"].Value;
            object celdaImpID = tablaDetalle.Rows[row].Cells["ImpuestoID"].Value;

                       
            if (celdaCant != null && celdaCant.GetType() != typeof(DBNull)  )       
                cant = Convert.ToInt32(celdaCant);

            if (celdaPrecio != null && celdaPrecio.GetType() != typeof(DBNull) )    
                precio = Convert.ToDouble(celdaPrecio);

            if (celdaImpID != null && celdaImpID.GetType() != typeof(DBNull)  )     
                impID = Convert.ToInt32(celdaImpID);



            //Prepara y ejecuta la funcion sql
            Dictionary<string, object> parametros = new Dictionary<string, object>() {
                { "cant", cant  },
                { "precio", precio },
                { "impID", impID }
            };
            
            DataTable totales =  recSQL.EjecutarFuncion("dbo.fCalcularTotales", parametros);


            //Edita los datos en el datagridview
            tablaDetalle.Rows[row].Cells["Subtotal"].Value = totales.Rows[0][0];
            tablaDetalle.Rows[row].Cells["Total"].Value = totales.Rows[0][1];


        }







        #endregion




    }
}
