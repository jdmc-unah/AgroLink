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

namespace AgroLink.Pantallas.Pantallas_Transacciones.Pantallas_Entrega
{
    public partial class EntregaDetalle : Form
    {


        public Form FormPadre { get; set; }  //Formulario Padre

        public int entregaID { get; set; }

        public int salidaID { get; set; }


        public EntregaDetalle()
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

            tbColonia.ReadOnly = esSoloLectura;
            tbDetalle.ReadOnly = esSoloLectura;

            comboSalida.Enabled = salidaID != 0 && entregaID != 0 ? false : !esSoloLectura;
            comboRepartidor.Enabled = !esSoloLectura;
            comboDep.Enabled = !esSoloLectura;
            comboMuni.Enabled = !esSoloLectura;


            dateTimePicker1.Enabled = !esSoloLectura;



            btnAceptar.Visible = !esSoloLectura;
            btnCancelar.Visible = !esSoloLectura;
            btnBorrarEntr.Visible = !esSoloLectura;
            btnEditar.Visible = esSoloLectura;


            if (entregaID != 0)
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

            comboRepartidor.DataSource = recSQL.EjecutarVista("vTraeRepartidor");
            comboRepartidor.DisplayMember = "Repartidor";
            comboRepartidor.ValueMember = "EmpleadoID";


            Dictionary<string, object> filtro = new Dictionary<string, object>(){
                {"filtro", entregaID != 0 ? "E" : "P" }

            };

            comboSalida.DataSource = recSQL.EjecutarSPDataTable("spTraeSalidasCode", filtro);
            comboSalida.DisplayMember = "CodigoSalida";
            comboSalida.ValueMember = "SalidaID";


            comboDep.DataSource = recSQL.EjecutarVista("Pruebas.Departamento");
            comboDep.DisplayMember = "Nombre";
            comboDep.ValueMember = "DepartamentoID";

        }


        void LlenaMuni(int? depto)
        {
            Dictionary<string, object?> parametros = new Dictionary<string, object>
            {
                {"depto",  depto }
            };

            comboMuni.DataSource = recSQL.EjecutarSPDataTable("spTraeDeptoMunicipio", parametros);
            comboMuni.DisplayMember = "Nombre";
            comboMuni.ValueMember = "MunicipioID";
        }


        void LlenaComboDetalle()
        {

            //Llena los comboboxes de tabla detalle con las vistas
            DataGridViewComboBoxColumn colProducto = (DataGridViewComboBoxColumn)tablaDetalle.Columns["ProductoID"];
            colProducto.DataSource = recSQL.EjecutarVista("vTraeProductos");
            colProducto.DisplayMember = "Producto";
            colProducto.ValueMember = "ProductoID";



        }

        public void ObtenerDatos(int entrID, int salID)
        {

            //Trae Campos Superiores

            Dictionary<string, object> parametros = new Dictionary<string, object>() {
                {"entrID", entrID },
                {"salID", salID }
            };

            DataTable entregaFiltrada = recSQL.EjecutarSPDataTable("spTraeEntregaFiltrada", parametros);




            //Verifica si es una transferencia interna nueva
            if (entregaFiltrada.Rows.Count != 0)
            {
                //Llena Campos superiores

                tbCodigo.Text = entregaFiltrada.Rows[0]["CodigoEntrega"].ToString();

                dateTimePicker1.Value = Convert.ToDateTime(entregaFiltrada.Rows[0]["Fecha"]);

                LlenaCombosSuperiores();
                comboSocio.SelectedValue = Convert.ToInt32(entregaFiltrada.Rows[0]["SocioID"]);
                comboSalida.SelectedValue = Convert.ToInt32(entregaFiltrada.Rows[0]["SalidaID"]);
                comboRepartidor.SelectedValue = Convert.ToInt32(entregaFiltrada.Rows[0]["Repartidor"]);

                comboDep.SelectedValue = Convert.ToInt32(entregaFiltrada.Rows[0]["DepartamentoID"]);

                LlenaMuni((int)comboDep.SelectedValue);
                comboMuni.SelectedValue = Convert.ToInt32(entregaFiltrada.Rows[0]["MunicipioID"]);

                tbColonia.Text = entregaFiltrada.Rows[0]["Colonia"].ToString();
                tbDetalle.Text = entregaFiltrada.Rows[0]["Detalle"].ToString();



                //Trae y configura datos de venta detalle
                DataTable dt = recSQL.EjecutarSPDataTable("spTraeEntregaDetalle", parametros);
                dt.Columns["EntregaID"].AutoIncrement = false;
                dt.Columns["EntregaID"].DefaultValue = 0;
                dt.Columns["CodigoProducto"].DefaultValue = "PRO";

                tablaDetalle.AutoGenerateColumns = false; //esto es para que le haga caso al orden de columnas del datagridview

                tablaDetalle.DataSource = dt;

                LlenaComboDetalle();


            }
            else
            {
                LlenaCombosSuperiores();
                LlenaComboDetalle();
            }


        }




        #endregion


        private void EntregaDetalle_Load(object sender, EventArgs e)
        {
            //Valida si es para actualizar una salida o crear una nueva salida
            if (entregaID == 0)
            {
                comboSalida.Enabled = true;
                ToggleReadOnly(false);
            }

            //carga los datos 
            ObtenerDatos(entregaID, salidaID);
        }


        private void comboDep_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LlenaMuni((int)comboDep.SelectedValue);

        }

        private void comboVenta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            salidaID = (int)comboSalida.SelectedValue;

            ToggleReadOnly(false);

            ObtenerDatos(entregaID, salidaID);

        }










        #region Botones
        private void btnEditar_Click(object sender, EventArgs e)
        {
            ToggleReadOnly(false);


        }




        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ToggleReadOnly(true);

            //Toma datos de tablaDetalle 
            DataTable tbDet = metodosGlobales.CrearDataTable(tablaDetalle);


            ////Toma los datos de la parte superior y los asigna a los parametros del sp
            Dictionary<string, object?> paramsEntr = new Dictionary<string, object?>() {
                {"entrID" , entregaID},
                {"salID" ,  comboSalida.SelectedValue},
                {"socID"  ,comboSocio.SelectedValue },
                {"fecha"  , dateTimePicker1.Value.ToString("yyyy/MM/dd") },
                {"repID", comboRepartidor.SelectedValue },
                {"depID", comboDep.SelectedValue },
                {"munID",  comboMuni.SelectedValue},
                {"col", tbColonia.Text },
                {"det", tbDetalle.Text }
            };



            ////Agrega o actualiza la operacion pasando los parametros anteriores
            DataTable? tablaResultante = recSQL.EjecutarSPDataTable("spAddUpdateEntrega", "detalle", "TipoEntrega", tbDet, paramsEntr);


            if (tablaResultante != null)
            {
                entregaID = entregaID == 0 ? Convert.ToInt32(tablaResultante.Rows[0][0]) : entregaID;

                MessageBox.Show("Cambios Guardados con exito");

                ObtenerDatos(entregaID, salidaID);
            }




        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ToggleReadOnly(true);

            if (entregaID != 0)
            {
                ObtenerDatos(entregaID, salidaID);
            }
            else
            {
                PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(FormPadre, this);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(FormPadre, this);

        }





        private void btnBorrarEntr_Click(object sender, EventArgs e)
        {
            if( metodosGlobales.MensajeConfirmacion("Confirmar Eliminación", $"¿Está seguro que desea borrar la entrega {tbCodigo.Text}"))
            {
                Dictionary<string, object?> paramsEntr = new Dictionary<string, object?>() {
                    {"entrID", entregaID }
                };

                if (recSQL.EjecutarSPBool("spBorrarEntrega", paramsEntr))
                {
                    MessageBox.Show("Entrega Borrada");
                    PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(FormPadre, this);
                }

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

        }

        #endregion







    }
}
