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
using AgroLink.Pantallas.Pantallas_Objetos;

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
            comboBox_Finca.DropDownStyle = ComboBoxStyle.DropDownList;



            comboBox_TipoSuelo.DataSource = recSQL.EjecutarVista("vTraerTipoSuelo");
            comboBox_TipoSuelo.DisplayMember = "TipoSuelo";
            comboBox_TipoSuelo.ValueMember = "TipoSueloID";
            comboBox_TipoSuelo.DropDownStyle = ComboBoxStyle.DropDownList;


            //llenar tipo de riego
            comboBox_TipoRiego.DataSource = recSQL.EjecutarVista("vTraerTipoRiego");
            comboBox_TipoRiego.DisplayMember = "TipoRiego";
            comboBox_TipoRiego.ValueMember = "TipoRiegoID";
            comboBox_TipoRiego.DropDownStyle = ComboBoxStyle.DropDownList;

            //llebar tipo de semilla o cosecha no se como llamarlo
            comboBox_productocosecha.DataSource = recSQL.EjecutarVista("vTraerSiembra");
            comboBox_productocosecha.DisplayMember = "ProductoSiembra";
            comboBox_productocosecha.ValueMember = "ProductoID";
            comboBox_productocosecha.DropDownStyle = ComboBoxStyle.DropDownList;

        }



        public void ToggleReadOnly(bool esSoloLectura)
        {

            comboBox_TipoRiego.Enabled = esSoloLectura;


        }



        #endregion



        private void Lote_Load(object sender, EventArgs e)
        {
            this.LoteTabla.DataSource = recSQL.EjecutarVista("vMostrarLotes");
            LlenaComboFincaySuelo();


        }

        private void btnBuscarLote_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parametrosLote = new Dictionary<string, object>()
            {
                { "cod", tbBuscarLote.Text.Trim() }
            };

            LoteTabla.DataSource = recSQL.EjecutarSPDataTable("spBuscarLotes", parametrosLote);
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



        #region botones_Importantes
        private void btnAgregarLote_Click(object sender, EventArgs e)
        {

            decimal extensionDecimal;
            // un try por cualquier error que pueda surgir 
            try
            {
                //validamos si se lleno el campo de extencion, ya que es el unico que puede quedar vacio
                if (string.IsNullOrWhiteSpace(tbExtencion.Text))
                {
                    MessageBox.Show("Por favor, llene el campo de extencion.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (!decimal.TryParse(tbExtencion.Text.Trim(), out extensionDecimal)) //validamos si la extencion que ingreso es un decimal
                {
                    MessageBox.Show("Ingrese un valor decimal válido para la extensión.");
                    return;
                }



                //llenamos una tabla con los datos selecionados 

                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"FincaID",comboBox_Finca.SelectedValue },
                    {"productoID",comboBox_productocosecha.SelectedValue },
                    {"TipoSuelo",comboBox_TipoSuelo.SelectedValue },
                    {"tiporiego",comboBox_TipoRiego.SelectedValue },
                    {"fechaSiembra",dateTimePicker_siembra.Value.ToString("yyyy/MM/dd") },
                    {"FechCosecha",dateTimePicker_cosecha.Value.ToString("yyyy/MM/dd") },
                    {"exs",extensionDecimal }
                }; 

                DataTable resultado = recSQL.EjecutarSPDataTable("spAgregarLote", parametros);


                if (resultado != null && resultado.Rows.Count > 0)
                {
                    MessageBox.Show("lote agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar los campos después de guardar
                    tbExtencion.Clear();
                    comboBox_Finca.SelectedIndex = -1;
                    comboBox_productocosecha.SelectedIndex = -1;
                    comboBox_TipoSuelo.SelectedIndex = -1;
                    comboBox_TipoRiego.SelectedIndex = -1;


                    // Volver a llenar los combos por si hay nuevos valores y recargar la tabla 
                    LlenaComboFincaySuelo();
                    this.LoteTabla.DataSource = recSQL.EjecutarVista("vMostrarLotes");
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el producto. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al guardar nuevo lote: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            this.LoteTabla.DataSource = recSQL.EjecutarVista("vMostrarLotes");
        }
#endregion

        private void comboBox_TipoRiego_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }



}
