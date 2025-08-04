using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AgroLink.Pantallas.Pantallas_Socios
{
    public partial class Finca : Form
    {
        public Finca()
        {
            InitializeComponent();
        }


        #region Variables Globales

        Recursos.Recursos_SQL recSQL = new Recursos.Recursos_SQL();
        Recursos.MetodosGlobales metGlobales = new Recursos.MetodosGlobales();

        #endregion



        #region Metodos
        void llenar_comboboxs()
        {
            comboBox_Socio.DataSource = recSQL.EjecutarVista("vTraerAgricultores");  // Asignar el origen de datos
            comboBox_Socio.DisplayMember = "NombreAgricultor";         // Columna que se mostrará
            comboBox_Socio.ValueMember = "SocioID";   // Valor interno que se usará
            comboBox_Socio.DropDownStyle = ComboBoxStyle.DropDownList;// ya no lo pueden editar


            comboBox_CapacidadAgua.Items.Clear();
            comboBox_CapacidadAgua.Items.Add("Alta");
            comboBox_CapacidadAgua.Items.Add("Media");
            comboBox_CapacidadAgua.Items.Add("Baja");
            comboBox_CapacidadAgua.DropDownStyle = ComboBoxStyle.DropDownList; //esto para que nadie edite el tipo de agua ya que no hay un id en si ;-;



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



        private void Finca_Load(object sender, EventArgs e)
        {
            llenar_comboboxs();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_Departamento_SelectedIndexChanged(object sender, EventArgs e)
        {

            //llenamos las combobox de municipio segun su departamento ;-; NOTA: deberiamos agregar aunque sea un municipoio por depa
            if (comboBox_Departamento.SelectedValue != null && comboBox_Departamento.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>()
        {
            { "cod", comboBox_Departamento.SelectedValue }
        };

                comboBox_Municipio.DataSource = recSQL.EjecutarSPDataTable("spObtenerMunicipios", parametros);
                comboBox_Municipio.DisplayMember = "Municipios";
                comboBox_Municipio.ValueMember = "MunicipioID";
                comboBox_Municipio.DropDownStyle = ComboBoxStyle.DropDownList;
            }

        }

        #region Botones
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PantallaPrincipal.instanciaPantPrincipal.OpenChildForm(new Pantallas_Socios.Agricultor());

        }


       
        //se pudo ingresar exitosamente
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //verificamos si el usuario selecciono una capacidad de agua
                if (comboBox_CapacidadAgua.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, seleccione una capacidad de agua.", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //verificamos si le puso nombre a la finca ;-;
                if(string.IsNullOrWhiteSpace(tbNombreFinca.Text))
                {
                    MessageBox.Show("Debe Ingresar Un nombre a la Finca", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                // lenar una tabla con los datos que hay en el formulario
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"socioID",comboBox_Socio.SelectedValue },
                    {"NombreFinca",tbNombreFinca.Text },
                    {"MunicipioID",comboBox_Municipio.SelectedValue },
                    { "Colonia", string.IsNullOrWhiteSpace(tbColonia.Text) ? DBNull.Value : tbColonia.Text.Trim() },
                    { "Detalle", string.IsNullOrWhiteSpace(tbDetalleUbicacion.Text) ? DBNull.Value : tbDetalleUbicacion.Text.Trim() },//validacion si vienen nulos
                    { "CapacidadAgua", comboBox_CapacidadAgua.SelectedItem.ToString() },
                    
                };

                DataTable resultado = recSQL.EjecutarSPDataTable("spCrearFinca",parametros);


                if (resultado != null && resultado.Rows.Count > 0)
                {
                    MessageBox.Show("lote agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //si se ingreso la finca regresamos a la pantalla de agricultor 
                    PantallaPrincipal.instanciaPantPrincipal.OpenChildForm(new Pantallas_Socios.Agricultor());

                }
                else
                {
                    MessageBox.Show("No se pudo agregar la finca correctamente; Intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al guardar Crear Finca: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        #endregion
    }
}
