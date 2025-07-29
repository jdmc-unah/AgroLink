using AgroLink.Modelos;
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
    public partial class SalidaProducto : Form
    {
        public SalidaProducto()
        {
            InitializeComponent();
        }


        #region Variables Globales

        Recursos.Recursos_SQL recSQL = new Recursos.Recursos_SQL();

        #endregion

        private void SalidaProducto_Load(object sender, EventArgs e)
        {
            tablaSalida.DataSource = recSQL.EjecutarVista("vTraeSalidaProducto");
        }













    }
}
