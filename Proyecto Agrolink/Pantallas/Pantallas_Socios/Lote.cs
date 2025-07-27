using AgroLink.Pantallas.Pantallas_Transacciones.Pantallas_Factura;
using AgroLink.Pantallas.Pantallas_Transacciones;
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



        #region Metodos
        void LlenaComboFincaySuelo()
        {
            comboBox_Finca.DataSource = recSQL.EjecutarVista("vTraerFinca");  // Asignar el origen de datos
            comboBox_Finca.DisplayMember = "Finca";         // Columna que se mostrará
            comboBox_Finca.ValueMember = "FincaID";   // Valor interno que se usará

            comboBox_TipoSuelo.DataSource = recSQL.EjecutarVista("vTraerTipoSuelo");
            comboBox_TipoSuelo.DisplayMember = "TipoSuelo";
            comboBox_TipoSuelo.ValueMember = "TipoSueloID";


        }


        #endregion



        private void Lote_Load(object sender, EventArgs e)
        {
            this.LoteTabla.DataSource = recSQL.EjecutarVista("vMostrarLotes");
            LlenaComboFincaySuelo();
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarLote_Click(object sender, EventArgs e)
        {
            //agarrar los datos de las otros componentes
            Dictionary<string, object?> paramsLote = new Dictionary<string, object?>() {
                {"fechasiembra",dateTimePicker_siembra.Value.ToString("yyyy/MM/dd")},
                { "fechacosecha",dateTimePicker_cosecha.Value.ToString("yyyy/MM/dd")}
            };

        }
    }
}
