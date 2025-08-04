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

            comboBox_tipo.Items.Clear();
            comboBox_tipo.Items.Add("Agricultor");
            comboBox_tipo.Items.Add("Proveedor");
            comboBox_tipo.Items.Add("Consumidor");
            comboBox_tipo.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        #endregion



        #region botones
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PantallaPrincipal.instanciaPantPrincipal.OpenChildForm(new Pantallas_Socios.Socios());
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            try
            {

                //verificamos si el usuario selecciono un tipo de socio
                if (comboBox_tipo.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, seleccione un tipo de socio", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //verificamos si se puso nombre a Nombre RTN, correo, telefono e identidad
                if (string.IsNullOrWhiteSpace(tbnombre.Text))
                {
                    MessageBox.Show("Ingrese su nombre", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // del rtn
                if (string.IsNullOrWhiteSpace(tbRTN.Text))
                {
                    MessageBox.Show("Debe Ingresar su RTN", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //identidad
                if (string.IsNullOrWhiteSpace(tbIdentidad.Text))
                {
                    MessageBox.Show("Ingrese su identidad", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //correo

                if (string.IsNullOrWhiteSpace(tbCorreo.Text))
                {
                    MessageBox.Show("Ingrese su correo", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Telefono

                if (string.IsNullOrWhiteSpace(textBox_telefono.Text))
                {
                    MessageBox.Show("Debe Ingresar un numero telefonico", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //convertimos el saldo a un double
                double saldo = Convert.ToDouble(tbsaldoInicial.Text);


                //lenar una tabla con los datos de el informe

                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"Nombre",tbnombre.Text.Trim()},
                    {"TipoSocio",comboBox_tipo.SelectedItem.ToString() },
                    {"identidad",tbIdentidad.Text.Trim() },
                    {"RTN",tbRTN.Text.Trim()},
                    {"correo",tbCorreo.Text.Trim() },
                    {"telefono",textBox_telefono.Text.Trim() },
                    {"MunicipioID",comboBox_Municipio.SelectedValue },
                    { "Colonia", string.IsNullOrWhiteSpace(tbColonia.Text) ? DBNull.Value : tbColonia.Text.Trim() },
                    { "Detalle", string.IsNullOrWhiteSpace(tbDetalleUbicacion.Text) ? DBNull.Value : tbDetalleUbicacion.Text.Trim() },//validacion si vienen nulos
                    {"Notas", string.IsNullOrWhiteSpace(tbNotas.Text) ? DBNull.Value : tbNotas.Text.Trim() },
                    {"saldo",saldo }

                };

                //ejecutamos el proceso almacenado
                DataTable resultado = recSQL.EjecutarSPDataTable("spAgrearSocio", parametros);


                if (resultado != null && resultado.Rows.Count > 0)
                {
                    MessageBox.Show("Se a agregado el socio correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //si se ingreso la finca regresamos a la pantalla de agricultor 
                    PantallaPrincipal.instanciaPantPrincipal.OpenChildForm(new Pantallas_Socios.Socios());

                }
                else
                {
                    MessageBox.Show("No se pudo agregar la finca correctamente; Intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al agregar Socio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }


        #endregion



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

        private void comboBox_Departamento_SelectedIndexChanged(object sender, EventArgs e)
        {

            
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
    }




}
