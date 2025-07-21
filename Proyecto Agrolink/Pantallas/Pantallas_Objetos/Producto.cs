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
            btnEliminar.BringToFront();
            btnEliminar.Visible = true;

            if (!panel1.Controls.Contains(btnEliminar))
            {
                panel1.Controls.Add(btnEliminar);
                btnEliminar.BringToFront();
                btnEliminar.Visible = true;
            }
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tablaProducto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int productoID = Convert.ToInt32(tablaProducto.SelectedRows[0].Cells["ProductoID"].Value);

            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                { "ProductoID", productoID }
            };

            try
            {
                bool success = recSQL.EjecutarSPBool("spEliminarProducto", parametros);
                if (success)
                {
                    MessageBox.Show("Producto eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tablaProducto.DataSource = recSQL.EjecutarVista("vTraeProductos");
                }
                else
                {
                    MessageBox.Show("Error al eliminar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
