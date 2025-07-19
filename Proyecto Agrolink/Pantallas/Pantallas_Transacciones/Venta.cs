using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroLink.Pantallas.Pantallas_Transacciones
{
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
        }

        #region Variables Globales

        Recursos.Recursos_SQL recSQL = new Recursos.Recursos_SQL();
        Recursos.MetodosGlobales metGlobales = new Recursos.MetodosGlobales();

        #endregion



        private void Venta_Load(object sender, EventArgs e)
        {


            this.tablaVenta.DataSource = recSQL.EjecutarVista("vTraeVentas");




        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            this.tablaVenta.DataSource = recSQL.EjecutarVista("vTraeVentas");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //tbBuscar.Text

            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                { "cod", tbBuscar.Text.Trim() }
            };

            this.tablaVenta.DataSource = recSQL.EjecutarSPDataTable("spBuscarVenta", parametros);

        }
    }
}
