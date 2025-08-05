using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using AgroLink.Recursos;

namespace AgroLink.Pantallas.Pantallas_Objetos
{
    public partial class NuevoTipoProducto : Form
    {
        public NuevoTipoProducto()
        {
            InitializeComponent();
        }

        #region Variables Globales
        Recursos_SQL recSQL = new Recursos_SQL();
        #endregion

        private void NuevoTipoProducto_Load(object sender, EventArgs e)
        {
            // Llenar el combo de Categoría con las opciones válidas
            comboCategoria.Items.Add("Insumo");
            comboCategoria.Items.Add("Producto Agricola");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos obligatorios no estén vacíos
                if (string.IsNullOrWhiteSpace(tbNombreTipo.Text))
                {
                    MessageBox.Show("Por favor, complete el nombre del tipo de producto.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (comboCategoria.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione una categoría.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Preparar los parámetros para la inserción
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    { "nom", tbNombreTipo.Text.Trim() },
                    { "cat", comboCategoria.SelectedItem.ToString() }
                };

                // Ejecutar el procedimiento almacenado para agregar el tipo de producto
                bool resultado = recSQL.EjecutarSPBool("spAddTipoProducto", parametros);

                if (resultado)
                {
                    MessageBox.Show("Tipo de producto guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar los campos después de guardar
                    tbNombreTipo.Clear();
                    comboCategoria.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el tipo de producto. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el tipo de producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (PantallaPrincipal.instanciaPantPrincipal != null)
            {
                PantallaPrincipal.instanciaPantPrincipal.OpenChildForm(new TipoProducto());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los campos
            tbNombreTipo.Clear();
            comboCategoria.SelectedIndex = -1;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario actual
            this.Close();
            // Volver a la pantalla anterior si es necesario
            //if (PantallaPrincipal.instanciaPantPrincipal != null)
            //{
            //    PantallaPrincipal.instanciaPantPrincipal.OpenChildForm(new TipoProducto());
            //}
        }
    }
}
