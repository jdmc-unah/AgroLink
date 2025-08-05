using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using AgroLink.Recursos;

namespace AgroLink.Pantallas.Pantallas_Objetos
{
    public partial class NuevoProducto : Form
    {
        public int productoID { get; set; }



        public NuevoProducto()
        {
            InitializeComponent();
        }

        #region Variables Globales
        Recursos_SQL recSQL = new Recursos_SQL();
        MetodosGlobales metodosGlobales = new MetodosGlobales();
        #endregion

        private void NuevoProducto_Load(object sender, EventArgs e)
        {
            LlenaCombos();

        }

        void LlenaCombos()
        {
            //Llena el combo de Tipo de Producto
            comboTipoProducto.DataSource = recSQL.EjecutarVista("vTraeTipoProducto");
            comboTipoProducto.DisplayMember = "TipoProducto";
            comboTipoProducto.ValueMember = "TipoID";

            //Llena el combo de Unidad de Medida
            comboUnidadMedida.DataSource = recSQL.EjecutarVista("vTraeUnidadMedida");
            comboUnidadMedida.DisplayMember = "UnidadMedida";
            comboUnidadMedida.ValueMember = "UnidadMedidaID";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos obligatorios no estén vacíos
                if (string.IsNullOrWhiteSpace(tbNombre.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Preparar los parámetros para el procedimiento almacenado
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    { "nom", tbNombre.Text.Trim() },
                    { "tipProdID", comboTipoProducto.SelectedValue },
                    { "uniMedID", comboUnidadMedida.SelectedValue }
                };

                // Ejecutar el procedimiento almacenado para agregar el producto
                DataTable resultado = recSQL.EjecutarSPDataTable("spAddProducto", parametros);

                if (resultado != null && resultado.Rows.Count > 0)
                {

                    MessageBox.Show("Producto guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar los campos después de guardar
                    tbNombre.Clear();
                    comboTipoProducto.SelectedIndex = -1;
                    comboUnidadMedida.SelectedIndex = -1;

                    // Volver a llenar los combos por si hay nuevos valores
                    LlenaCombos();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el producto. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            if (PantallaPrincipal.instanciaPantPrincipal != null)
            {
                PantallaPrincipal.instanciaPantPrincipal.OpenChildForm(new Bodega());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los campos
            tbNombre.Clear();
            comboTipoProducto.SelectedIndex = -1;
            comboUnidadMedida.SelectedIndex = -1;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            // Cerrar esta pantalla y volver a la pantalla de productos
            this.Close();

            //if (PantallaPrincipal.instanciaPantPrincipal != null)
            //{
            //    PantallaPrincipal.instanciaPantPrincipal.OpenChildForm(new Producto());
            //}
        }
    }
}
