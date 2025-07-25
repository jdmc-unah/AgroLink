﻿using AgroLink.Recursos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroLink.Pantallas.Pantallas_Transacciones.Pantallas_Factura
{
    public partial class FacturaDetalle : Form
    {

        public Factura FacturaForm { get; set; }  //Formulario Padre

        public int facturaID { get; set; }

        public int? ventaID { get; set; }

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
            comboSocio.Enabled = !esSoloLectura;
            comboMetodoPago.Enabled = !esSoloLectura;
            comboListaPrecio.Enabled = !esSoloLectura;
            comboEmpleado.Enabled = !esSoloLectura;
            comboVenta.Enabled = !esSoloLectura;

            dateTimePicker1.Enabled = !esSoloLectura;

            tablaDetalle.ReadOnly = esSoloLectura;
            tablaDetalle.AllowUserToDeleteRows = !esSoloLectura;

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


            if (facturaID != 0) 
            {
               //editar factura que ya tiene venta

                comboVenta.DataSource = recSQL.EjecutarSPDataTable("spTraeVentasCode");
                comboVenta.DisplayMember = "CodigoVenta";
                comboVenta.ValueMember = "VentaID";
            }
            else {

                Dictionary<string, object> filtro = new Dictionary<string, object>() {
                    {"filtro", "A" }
                };

                comboVenta.DataSource = recSQL.EjecutarSPDataTable("spTraeVentasCode", filtro);
                comboVenta.DisplayMember = "CodigoVenta";
                comboVenta.ValueMember = "VentaID";
            }



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




        public void ObtenerDatos(int id)
        {

            //Trae Campos Superiores

            Dictionary<string, object> parametros = new Dictionary<string, object>() {
                {"factID", id }
            };

            DataTable facturaFiltrada = recSQL.EjecutarSPDataTable("spTraeFacturaFiltrada", parametros);


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


        }


        #endregion



        private void FacturaDetalle_Load(object sender, EventArgs e)
        {
            //Valida si es para actualizar una venta o crear una nueva venta
            if (facturaID != 0)
            {
                //carga los datos de la venta a actualizar
                ObtenerDatos(facturaID);
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
            PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(FacturaForm, this);

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

            ToggleReadOnly(true);

            //Toma datos de tablaDetalle 
            DataTable tbDet = metodosGlobales.CrearDataTable(tablaDetalle);

            ventaID = (int) comboVenta.SelectedValue; 


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
                { "numFiscalID" , 1 },
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
                    //PantallaPrincipal.instanciaPantPrincipal.OpenChildForm(new Pantallas_Factura.FacturaDetalle());
                    //aqui habria que pasar la data a salida de producto

                }
                else
                {
                    ObtenerDatos(facturaID);
                }
            }


        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ToggleReadOnly(true);

            if (facturaID != 0)
            {
                ObtenerDatos(facturaID);
            }
            else
            {
                PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(FacturaForm, this);
            }
        }








        #endregion




        #region Tabla Detalle
        private void tablaDetalle_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }


        private void tablaDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Toma el indice de la fila seleccionada y el valor seleccionado 
            int row = tablaDetalle.CurrentRow.Index;

            int cant = 0; double precio = 0; int impID = 0;

            //Trae los datos del datagridview
            object celdaCant = tablaDetalle.Rows[row].Cells["Cantidad"].Value;
            object celdaPrecio = tablaDetalle.Rows[row].Cells["Precio"].Value;
            object celdaImpID = tablaDetalle.Rows[row].Cells["ImpuestoID"].Value;


            if (celdaCant != null && celdaCant.GetType() != typeof(DBNull))
                cant = Convert.ToInt32(celdaCant);

            if (celdaPrecio != null && celdaPrecio.GetType() != typeof(DBNull))
                precio = Convert.ToDouble(celdaPrecio);

            if (celdaImpID != null && celdaImpID.GetType() != typeof(DBNull))
                impID = Convert.ToInt32(celdaImpID);



            //Prepara y ejecuta la funcion sql
            Dictionary<string, object> parametros = new Dictionary<string, object>() {
                { "cant", cant  },
                { "precio", precio },
                { "impID", impID }
            };

            DataTable totales = recSQL.EjecutarFuncion("dbo.fCalcularTotales", parametros);


            //Edita los datos en el datagridview
            tablaDetalle.Rows[row].Cells["Subtotal"].Value = totales.Rows[0][0];
            tablaDetalle.Rows[row].Cells["Total"].Value = totales.Rows[0][1];

        }

        #endregion






    
    }
}
