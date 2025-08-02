using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroLink.Pantallas.Pantallas_Socios
{
    public partial class Socios : Form
    {
        public Socios()
        {
            InitializeComponent();
        }

        #region Variables Globales

        Recursos.Recursos_SQL recSQL = new Recursos.Recursos_SQL();
        Recursos.MetodosGlobales metGlobales = new Recursos.MetodosGlobales();

        #endregion


        private void Socios_Load(object sender, EventArgs e)
        {
            this.TablaSocio.DataSource = recSQL.EjecutarVista("vTraerSocios");
        }

        private void btnBuscarSocio_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                { "cod", tbBuscarSocio.Text.Trim() }
            };

            TablaSocio.DataSource = recSQL.EjecutarSPDataTable("spBuscarSocio", parametros);
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            // la misma cosa
            this.TablaSocio.DataSource = recSQL.EjecutarVista("vTraerSocios");
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            //va la pantalla detalle de socio por llamarla asi

            PantallaPrincipal.instanciaPantPrincipal.OpenChildForm(new Pantallas_Socios.SociosDetalle());
        }
    }
}
