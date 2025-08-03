using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroLink.Pantallas.Pantallas_Transacciones.Pantallas_Recibo
{
    public partial class Recibo : Form
    {


        public Recibo()
        {
            InitializeComponent();
        }

        #region Variables Globales

        Recursos.Recursos_SQL recSQL = new Recursos.Recursos_SQL();

        #endregion

        private void Recibo_Load(object sender, EventArgs e)
        {
            tablaRecibo.DataSource = recSQL.EjecutarVista("vTraeRecibos");
        }

        private void tablaRecibo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Pantallas_Recibo.ReciboDetalle detalle = new ReciboDetalle();
            detalle.FormPadre = this;

            int row = tablaRecibo.CurrentRow.Index;

            detalle.reciboID = (int)tablaRecibo.Rows[row].Cells[0].Value;

            PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(this, detalle);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                { "cod", tbBuscar.Text.Trim() }
            };

            tablaRecibo.DataSource = recSQL.EjecutarSPDataTable("spBuscarRecibo", parametros);
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            tablaRecibo.DataSource = recSQL.EjecutarVista("vTraeRecibos");
        }

        private void btnNuevoRecibo_Click(object sender, EventArgs e)
        {
            Pantallas_Recibo.ReciboDetalle detalle = new ReciboDetalle();
            detalle.FormPadre = this;

            detalle.reciboID = 0;
            detalle.compraID = 0;

            PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(this, detalle);
        }

        private void btnRecargar_VisibleChanged(object sender, EventArgs e)
        {
            tablaRecibo.DataSource = recSQL.EjecutarVista("vTraeRecibos");
        }
    }
}
