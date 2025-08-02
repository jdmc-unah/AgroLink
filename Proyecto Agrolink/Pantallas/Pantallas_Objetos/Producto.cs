using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AgroLink.Pantallas.Pantallas_Objetos;

namespace AgroLink.Pantallas.Pantallas_Objetos
{
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
            btnNuevoProducto.Click += btnNuevoProducto_Click;
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            if (PantallaPrincipal.instanciaPantPrincipal != null)
            {
                PantallaPrincipal.instanciaPantPrincipal.OpenChildForm(new NuevoProducto());
            }
        }

        #region Variables Globales

        Recursos.Recursos_SQL recSQL = new Recursos.Recursos_SQL();
        Recursos.MetodosGlobales metGlobales = new Recursos.MetodosGlobales();

        #endregion

        private void Producto_Load(object sender, EventArgs e)
        {
            tablaProducto.DataSource = recSQL.EjecutarVista("vPantallaProductos");
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            tablaProducto.DataSource = recSQL.EjecutarVista("vPantallaProductos");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cod = tbBuscar.Text.Trim();
            
            // Si el campo de búsqueda está vacío, mostrar todos los productos
            if (string.IsNullOrEmpty(cod))
            {
                tablaProducto.DataSource = recSQL.EjecutarVista("vPantallaProductos");
                return;
            }
            
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                { "cod", cod }
            };

            tablaProducto.DataSource = recSQL.EjecutarSPDataTable("spBuscarProducto", parametros);
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            // Si el campo de búsqueda está vacío, mostrar todos los productos
            if (string.IsNullOrEmpty(tbBuscar.Text.Trim()))
            {
                tablaProducto.DataSource = recSQL.EjecutarVista("vPantallaProductos");
            }
        }

    }
}
