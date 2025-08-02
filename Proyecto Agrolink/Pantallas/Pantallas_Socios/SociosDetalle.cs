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
    public partial class SociosDetalle : Form
    {
        public SociosDetalle()
        {
            InitializeComponent();
        }


        #region Variables Globales

        Recursos.Recursos_SQL recSQL = new Recursos.Recursos_SQL();
        Recursos.MetodosGlobales metGlobales = new Recursos.MetodosGlobales();

        #endregion

        #region Metodos

        void llenarDepartamentYMunicipio()
        {
            comboBox_Departamento.DataSource = recSQL.EjecutarVista("vTraerDepartamento");
            comboBox_Departamento.DisplayMember = "Departamento";
            comboBox_Departamento.ValueMember = "DepartamentoID";
            comboBox_Departamento.DropDownStyle = ComboBoxStyle.DropDownList;

            //para que se llene al inicio ;-;
            Dictionary<string, object> parametros = new Dictionary<string, object>()
        {
            { "cod", comboBox_Departamento.SelectedValue }
        };

            comboBox_Municipio.DataSource = recSQL.EjecutarSPDataTable("spObtenerMunicipios", parametros);
            comboBox_Municipio.DisplayMember = "Municipios";
            comboBox_Municipio.ValueMember = "MunicipioID";
            comboBox_Municipio.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PantallaPrincipal.instanciaPantPrincipal.OpenChildForm(new Pantallas_Socios.Socios());
        }


        #region errorDedo
        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        #endregion




        private void SociosDetalle_Load(object sender, EventArgs e)
        {
            llenarDepartamentYMunicipio();
        }
    }




}
