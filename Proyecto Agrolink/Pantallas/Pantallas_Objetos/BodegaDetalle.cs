using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using AgroLink.Pantallas;

namespace AgroLink.Pantallas.Pantallas_Objetos
{
    public partial class BodegaDetalle : Form
    {
        #region Variables Globales

        Recursos.Recursos_SQL recSQL = new Recursos.Recursos_SQL();
        Recursos.MetodosGlobales metGlobales = new Recursos.MetodosGlobales();
        private int bodegaID;

        #endregion

        public BodegaDetalle(int bodegaID)
        {
            InitializeComponent();
            this.bodegaID = bodegaID;
        }

        private void BodegaDetalle_Load(object sender, EventArgs e)
        {
            CargarDatosBodega();
            CargarDetallesBodega();
        }

        private void CargarDatosBodega()
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                { "bodegaID", bodegaID }
            };

            DataTable dt = recSQL.EjecutarSPDataTable("spObtenerBodegaPorID", parametros);
            
            if (dt.Rows.Count > 0)
            {
                lblCodigoBodega.Text = dt.Rows[0]["CodigoBodega"].ToString();
                lblNombreBodega.Text = dt.Rows[0]["Nombre"].ToString();
                lblCapacidad.Text = dt.Rows[0]["Capacidad"].ToString();
                lblDireccion.Text = dt.Rows[0]["Direccion"].ToString();
            }
        }

        private void CargarDetallesBodega()
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                { "bodegaID", bodegaID }
            };

            tablaBodegaDetalle.DataSource = recSQL.EjecutarSPDataTable("spObtenerDetalleBodegaPorID", parametros);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();

            if (PantallaPrincipal.instanciaPantPrincipal != null)
            {
                PantallaPrincipal.instanciaPantPrincipal.OpenChildForm(new Bodega());
            }
        }

    }
}
