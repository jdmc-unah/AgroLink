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

namespace AgroLink.Pantallas.Pantallas_Transacciones.Pantallas_Venta
{
    public partial class VentasDetalle : Form
    {
        public Venta ventaForm { get; set; }  //Formulario Padre

        public int ventaID { get; set; }
        public string codigo     {get; set;}

        //public  string  fecha   {get; set;}
        
        public int socioID       {get; set;}
        public string socio      {get; set;}
        public string tipoSocio  {get; set;}
        public int listaPreID    {get; set;}
        public string listaPrecio{get; set;}
        public string tipoPago   {get; set;}
        public string estado     {get; set;}



        public VentasDetalle()
        {
            InitializeComponent();
        }


        Recursos_SQL recSQL = new Recursos_SQL();

        #region Metodos

        public void ObtenerDatos()
        {
            //Llena campos superiores
            tbCodigo.Text = codigo;
            tbEstado.Text = estado;


            //Llena tabla detalle
            Dictionary<string, object> parametros = new Dictionary<string, object>() {
                {"ventID", ventaID }
            };

            tablaDetalle.DataSource = recSQL.EjecutarSPDataTable("spTraeVentaDetalle", parametros);

            
        
        }


        #endregion

        private void VentasDetalle_Load(object sender, EventArgs e)
        {
            ObtenerDatos();
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {

            PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(ventaForm, this);

        }

      
    }
}
