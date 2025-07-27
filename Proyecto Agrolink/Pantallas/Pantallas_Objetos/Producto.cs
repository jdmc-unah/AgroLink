using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AgroLink.Pantallas.Pantallas_Transacciones
{
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        #region Variables Globales

        Recursos.Recursos_SQL recSQL = new Recursos.Recursos_SQL();
        Recursos.MetodosGlobales metGlobales = new Recursos.MetodosGlobales();

        #endregion

        private void Producto_Load(object sender, EventArgs e)
        {
            this.tablaProducto.DataSource = recSQL.EjecutarVista("vTraeProductos");
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            this.tablaProducto.DataSource = recSQL.EjecutarVista("vTraeProductos");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                { "cod", tbBuscar.Text.Trim() }
            };

            this.tablaProducto.DataSource = recSQL.EjecutarSPDataTable("spBuscarProducto", parametros);
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
