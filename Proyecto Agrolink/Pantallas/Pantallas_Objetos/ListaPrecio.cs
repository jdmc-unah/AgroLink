using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AgroLink.Pantallas.Pantallas_Objetos
{
    public partial class ListaPrecio : Form
    {
        Recursos.Recursos_SQL recSQL = new Recursos.Recursos_SQL();

        public ListaPrecio()
        {
            InitializeComponent();
        }

        private void ListaPrecio_Load(object sender, EventArgs e)
        {
            tablaListaPrecio.DataSource = recSQL.EjecutarVista("vPantallaListaPrecio");
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            tablaListaPrecio.DataSource = recSQL.EjecutarVista("vPantallaListaPrecio");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void btnNuevoPrecio_Click(object sender, EventArgs e)
        {
            // Abrir la pantalla para agregar un nuevo precio
            if (PantallaPrincipal.instanciaPantPrincipal != null)
            {
                PantallaPrincipal.instanciaPantPrincipal.OpenChildForm(new NuevoPrecio());
            }
        }
    }
}
