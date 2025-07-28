using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AgroLink.Pantallas.Pantallas_Objetos;

namespace AgroLink.Pantallas.Pantallas_Objetos
{
    public partial class Bodega : Form
    {
        #region Variables Globales

        Recursos.Recursos_SQL recSQL = new Recursos.Recursos_SQL();
        Recursos.MetodosGlobales metGlobales = new Recursos.MetodosGlobales();

        #endregion

        public Bodega()
        {
            InitializeComponent();
        }

        private void Bodega_Load(object sender, EventArgs e)
        {
            tablaBodega.DataSource = recSQL.EjecutarVista("vTraeBodega");
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            tablaBodega.DataSource = recSQL.EjecutarVista("vTraeBodega");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                { "cod", tbBuscar.Text.Trim() }
            };

            tablaBodega.DataSource = recSQL.EjecutarSPDataTable("spBuscarBodega", parametros);
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}