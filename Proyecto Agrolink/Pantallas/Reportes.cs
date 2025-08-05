using AgroLink.Modelos;
using AgroLink.Recursos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroLink.Pantallas
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }


        Recursos_SQL recSQL = new Recursos_SQL();
        MetodosGlobales metodosGlobales = new MetodosGlobales();


        private void Reportes_Load(object sender, EventArgs e)
        {
           
            
            lbBienvenida.Text = $"¡Bienvenido, {MetodosGlobales.SesionGlobal.nombreUsuario}!";


            DataTable totales = recSQL.EjecutarSPDataTable("spTotalesUtilidad");

            lblTotIngresos.Text = totales.Rows[0][0].ToString();
            lblTotGastos.Text = totales.Rows[0][1].ToString();
            lblTotUtilidad.Text = totales.Rows[0][2].ToString();

            tablaTopCompra.DataSource = recSQL.EjecutarSPDataTable("spTop3ProductoComprado");
            tablaTopCompra.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            tablaTopVenta.DataSource = recSQL.EjecutarSPDataTable("spTop3ProductoVendido");
            tablaTopVenta.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }




        #region Inventario

        #region Metodos

        public void LlenaTablaInventario(DataTable? resultado)
        {

            tablaInventario.DataSource = resultado;
            tablaInventario.Columns["Agricultor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tablaInventario.Columns["Producto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        #endregion

        private void tabInventario_Enter(object sender, EventArgs e)
        {
            DataTable totales = recSQL.EjecutarSPDataTable("spTotalesReporteInventario");

            lblTotalProdAdqu.Text = totales.Rows[0][0].ToString();
            lblComprasdelAño.Text = totales.Rows[0][1].ToString();
            lblInsumosVendidos.Text = totales.Rows[0][2].ToString();
            lblTotalVentasInsumos.Text = totales.Rows[0][3].ToString();
        }

        private void radioProdxProducto_CheckedChanged(object sender, EventArgs e)
        {
            LlenaTablaInventario(recSQL.EjecutarVista(radioProdxProducto.Checked ? "vProdRecibidaxProductor" : "vInsumosEntrxProductor"));
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> filtro = new Dictionary<string, object>()
            {
                {"filtro", tbBuscar.Text }
            };

            if (radioInsumosxProducto.Checked || radioProdxProducto.Checked)
                LlenaTablaInventario(recSQL.EjecutarSPDataTable(radioProdxProducto.Checked ? "spBuscarProdxProductor" : "spBuscarProdxProductor", filtro));


        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            if (radioInsumosxProducto.Checked || radioProdxProducto.Checked)
                LlenaTablaInventario(recSQL.EjecutarVista(radioProdxProducto.Checked ? "vProdRecibidaxProductor" : "vInsumosEntrxProductor"));
        }




        #endregion



        #region Saldo

        #region Metodos

        public void LlenaTablaSaldo(DataTable? resultado)
        {

            tablaSaldo.DataSource = resultado;
            tablaSaldo.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        #endregion




        string? tipoSaldo = null;

        private void tabSaldo_Enter(object sender, EventArgs e)
        {

            DataTable totales = recSQL.EjecutarSPDataTable("spTotalesReporteSaldo");

            lblSaldoTotProv.Text = totales.Rows[0][0].ToString();
            lblSaldoTotAgr.Text = totales.Rows[0][1].ToString();
            lblSaldoTot.Text = totales.Rows[0][2].ToString();

        }


        private void radioTodo_CheckedChanged(object sender, EventArgs e)
        {

            if (radioTodo.Checked)
            {
                LlenaTablaSaldo(recSQL.EjecutarSPDataTable("spReporteSaldos"));
                tipoSaldo = null;
            }

        }


        private void radioSaldoProveedor_CheckedChanged(object sender, EventArgs e)
        {

            if (radioSaldoProveedor.Checked)
            {
                tipoSaldo = "Proveedor";
            }

            Dictionary<string, object> param = new Dictionary<string, object>() {
            { "filtro", tipoSaldo }
            };

            LlenaTablaSaldo(recSQL.EjecutarSPDataTable("spReporteSaldos", param));



        }

        private void radioSaldoAgricultor_CheckedChanged(object sender, EventArgs e)
        {

            if (radioSaldoAgricultor.Checked)
            {
                tipoSaldo = "Agricultor";
            }

            Dictionary<string, object?> param = new Dictionary<string, object?>() {
            { "filtro", tipoSaldo }
            };

            LlenaTablaSaldo(recSQL.EjecutarSPDataTable("spReporteSaldos", param));

        }


        private void btnBuscarSaldo_Click(object sender, EventArgs e)
        {



            Dictionary<string, object?> filtro = new Dictionary<string, object?>()
            {
                {"busqueda", tbBuscarSaldo.Text },
                {"filtro", tipoSaldo}

            };

            LlenaTablaSaldo(recSQL.EjecutarSPDataTable("spBuscarSaldo", filtro));

        }



        private void btnRecargarSaldo_Click(object sender, EventArgs e)
        {

            Dictionary<string, object?> param = new Dictionary<string, object?>() {
            { "filtro", tipoSaldo }
            };

            LlenaTablaSaldo(recSQL.EjecutarSPDataTable("spReporteSaldos", param));
        }



        #endregion





        #region Utilidad


        private void tabUtilidad_Enter(object sender, EventArgs e)
        {
            DataTable totales = recSQL.EjecutarSPDataTable("spTotalesUtilidad");

            lblTotIngresos.Text = totales.Rows[0][0].ToString();
            lblTotGastos.Text = totales.Rows[0][1].ToString();
            lblTotUtilidad.Text = totales.Rows[0][2].ToString();



            tablaTopCompra.DataSource = recSQL.EjecutarSPDataTable("spTop3ProductoComprado");
            tablaTopCompra.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            tablaTopVenta.DataSource = recSQL.EjecutarSPDataTable("spTop3ProductoVendido");
            tablaTopVenta.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;





        }



        #endregion




       
    }
}
