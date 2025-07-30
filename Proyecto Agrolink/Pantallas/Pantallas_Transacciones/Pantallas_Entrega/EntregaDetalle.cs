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

        public int ventaID { get; set; }


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

            tbColonia.Enabled = !esSoloLectura;
            tbDetalle.Enabled = !esSoloLectura;

            comboVenta.Enabled = !esSoloLectura;
            comboRepartidor.Enabled = !esSoloLectura;
            comboDep.Enabled = !esSoloLectura;
            comboMuni.Enabled = !esSoloLectura;


            dateTimePicker1.Enabled = !esSoloLectura;

            tablaDetalle.AllowUserToDeleteRows = !esSoloLectura;

            btnAceptar.Visible = !esSoloLectura;
            btnCancelar.Visible = !esSoloLectura;
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


            Dictionary<string, object> filtroVentasAC = new Dictionary<string, object>() {
                {"filtro",   "AC" }
            };

            comboVenta.DataSource = recSQL.EjecutarSPDataTable("spTraeVentasCode", filtroVentasAC);
            comboVenta.DisplayMember = "CodigoVenta";
            comboVenta.ValueMember = "VentaID";


            comboDep.DataSource = recSQL.EjecutarVista("Pruebas.Departamento");
            comboDep.DisplayMember = "Nombre";
            comboDep.ValueMember = "DepartamentoID";

        }


        void LlenaMuni(int depto)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
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

        public void ObtenerDatos(int entrID, int ventID)
        {

            //Trae Campos Superiores

            Dictionary<string, object> parametros = new Dictionary<string, object>() {
                {"entrID", entrID },
                {"ventID", ventID }
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
                comboVenta.SelectedValue = Convert.ToInt32(entregaFiltrada.Rows[0]["VentaID"]);
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


        private void EntregaDetalle_Load(object sender, EventArgs e)
        {
            //Valida si es para actualizar una salida o crear una nueva salida
            if (entregaID == 0)
            {
                comboVenta.Enabled = true;
                ToggleReadOnly(false);
            }
           
            //carga los datos 
            ObtenerDatos(entregaID, ventaID);
        }


        private void comboDep_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LlenaMuni((int)comboDep.SelectedValue);

        }

     
    }
}
