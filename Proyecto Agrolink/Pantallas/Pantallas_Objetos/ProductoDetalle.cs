using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroLink.Pantallas.Pantallas_Objetos
{
    public partial class ProductoDetalle : Form
    {

        public int prodID { get; set; }
        public string prodNombre { get; set; }

        public ProductoDetalle()
        {
            InitializeComponent();
        }


        Recursos.Recursos_SQL recSQL = new Recursos.Recursos_SQL();
        Recursos.MetodosGlobales metg = new Recursos.MetodosGlobales();

        private void btnAddUpdtPrecio_Click(object sender, EventArgs e)
        {
            panelAgregarPrecio.Visible = true;

            comboListaPrecios.DataSource = recSQL.EjecutarVista("vTraeListaPrecios");
            comboListaPrecios.DisplayMember = "ListPrecios";
            comboListaPrecios.ValueMember = "ListaPreciosID";

        }

        private void ProductoDetalle_Load(object sender, EventArgs e)
        {
            Dictionary<string, object> id = new Dictionary<string, object>()
            {
                {"prodID", prodID }
            };

            tablaPrecios.DataSource = recSQL.EjecutarSPDataTable("spTraeProdDet", id);
            lblProducto.Text = prodNombre;

        }



        #region Editar Precios

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (metg.MensajeConfirmacion("Confirmar Cambios", "¿Está seguro de querer guardar los cambios?")) {

                //guarda los cambios
                Dictionary<string, object> param = new Dictionary<string, object>()
                {
                    {"prodID", prodID },
                    {"listPrecID", comboListaPrecios.SelectedValue },
                    {"precio" , Convert.ToDouble( numericPrecio.Value )}
                };

                recSQL.EjecutarSPBool("spAddUpdtProdDet", param);
               
                //actualiza la tabla
                Dictionary<string, object> id = new Dictionary<string, object>()
                {
                    {"prodID", prodID }
                };

                tablaPrecios.DataSource = recSQL.EjecutarSPDataTable("spTraeProdDet", id);
                
                panelAgregarPrecio.Visible = false; 
                

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelAgregarPrecio.Visible = false;

        }

        #endregion


        private void comboListaPrecios_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Dictionary<string, object> param = new Dictionary<string, object>()
            {
                {"prodID", prodID },
                {"listPrecID", comboListaPrecios.SelectedValue }
            };

            DataTable precio = recSQL.EjecutarSPDataTable("spTraePrecioProd", param);

            if (precio.Rows.Count > 0)
            {
                numericPrecio.Value = Convert.ToDecimal(precio.Rows[0][0]);
            }
            else
            {
                numericPrecio.Value = 0;
            }


        }
    }
}
