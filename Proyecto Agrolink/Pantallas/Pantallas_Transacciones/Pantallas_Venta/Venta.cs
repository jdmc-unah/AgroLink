using AgroLink.Pantallas.Pantallas_Transacciones.Pantallas_Venta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroLink.Pantallas.Pantallas_Transacciones
{

    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
        }

        #region Variables Globales

        Recursos.Recursos_SQL recSQL = new Recursos.Recursos_SQL();
        Recursos.MetodosGlobales metGlobales = new Recursos.MetodosGlobales();

        #endregion


        private void Venta_Load(object sender, EventArgs e)
        {
            tablaVenta.DataSource = recSQL.EjecutarVista("vTraeVentas");
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            tablaVenta.DataSource = recSQL.EjecutarVista("vTraeVentas");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                { "cod", tbBuscar.Text.Trim() }
            };

            tablaVenta.DataSource = recSQL.EjecutarSPDataTable("spBuscarVenta", parametros);

        }


        private void tablaVenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //Crea una nueva instancia de VentaDetalle y le pasa este form junto con el id de la venta
            Pantallas_Venta.VentasDetalle detalle = new Pantallas_Venta.VentasDetalle();
            detalle.ventaForm = this;


            //Toma el indice de la fila seleccionada y el valor seleccionado 
            int row = tablaVenta.CurrentRow.Index;
                            
            detalle.ventaID =   (int) this.tablaVenta.Rows[row].Cells[0].Value;
            detalle.codigo =    (string) this.tablaVenta.Rows[row].Cells[1].Value;
            detalle.fecha =     (DateTime) this.tablaVenta.Rows[row].Cells[2].Value;
            detalle.socioID =   (int) this.tablaVenta.Rows[row].Cells[3].Value;
            detalle.socio =     (string)this.tablaVenta.Rows[row].Cells[4].Value;
            detalle.tipoSocio = (string)this.tablaVenta.Rows[row].Cells[5].Value;
            detalle.listaPreID= (int)this.tablaVenta.Rows[row].Cells[6].Value;
            detalle.listaPrecio=(string)this.tablaVenta.Rows[row].Cells[7].Value;
            detalle.tipoPago =  (string)this.tablaVenta.Rows[row].Cells[8].Value;
            detalle.estado =    (string)this.tablaVenta.Rows[row].Cells[9].Value;


            //Llama al metodo de la pantalla principal para mostrar VentaDetalle
            PantallaPrincipal.instanciaPantPrincipal.ToggleDetailForms(this, detalle);

        }




    }
}
