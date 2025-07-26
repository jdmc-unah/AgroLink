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
    public partial class Lote : Form
    {
        public Lote()
        {
            InitializeComponent();
        }

        #region Variables Globales

        Recursos.Recursos_SQL recSQL = new Recursos.Recursos_SQL();
        Recursos.MetodosGlobales metGlobales = new Recursos.MetodosGlobales();

        #endregion

        private void Lote_Load(object sender, EventArgs e)
        {
            this.LoteTabla.DataSource = recSQL.EjecutarVista("vMostrarLotes");
        }

        private void btnBuscarLote_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                { "cod", tbBuscarLote.Text.Trim() }
            };

            LoteTabla.DataSource = recSQL.EjecutarSPDataTable("spBuscarLotes", parametros);
        }

        private void LoteTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegrsar_Click(object sender, EventArgs e)
        {
            PantallaPrincipal.instanciaPantPrincipal.OpenChildForm(new Pantallas.Pantallas_Socios.Agricultor());
        }
    }
}
