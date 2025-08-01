using System;
using System.Collections.Generic;
using System.Windows.Forms;
//using Recursos;

namespace AgroLink.Pantallas.Pantallas_Objetos
{
    public partial class TipoProducto : Form
    {
        Recursos.Recursos_SQL recSQL = new Recursos.Recursos_SQL();

        public TipoProducto()
        {
            InitializeComponent();
        }

        private void TipoProducto_Load(object sender, EventArgs e)
        {
            tablaTipoProducto.DataSource = recSQL.EjecutarVista("vPantallaTipoProducto");
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            tablaTipoProducto.DataSource = recSQL.EjecutarVista("vPantallaTipoProducto");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                { "cod", tbBuscar.Text.Trim() }
            };

            tablaTipoProducto.DataSource = recSQL.EjecutarSPDataTable("spBuscarTipoProducto", parametros);
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
