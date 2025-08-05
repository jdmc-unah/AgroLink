using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using AgroLink.Recursos;
using AgroLink.Pantallas;

namespace AgroLink.Pantallas.Pantallas_Objetos
{
    public partial class NuevoPrecio : Form
    {
        #region Variables Globales

        Recursos_SQL recSQL = new Recursos_SQL();
        MetodosGlobales metodosGlobales = new MetodosGlobales();

        #endregion

        public NuevoPrecio()
        {
            InitializeComponent();
        }

        #region Métodos

        #endregion

        #region Eventos

        private void NuevoPrecio_Load(object sender, EventArgs e)
        {
            // Inicializar el combobox de activo con valores "si" y "no"
            cmbActivo.Items.Add("si");
            cmbActivo.Items.Add("no");
            cmbActivo.SelectedIndex = 0; // Seleccionar "si" por defecto
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos obligatorios no estén vacíos
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    cmbActivo.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Convertir "si"/"no" a 1/0 para la base de datos
                int activo = cmbActivo.SelectedItem.ToString() == "si" ? 1 : 0;

                // Preparar los parámetros para el procedimiento almacenado
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    { "nombre", txtNombre.Text.Trim() },
                    { "activo", activo }
                };

                // Ejecutar el procedimiento almacenado para agregar la lista de precios
                object result = recSQL.EjecutarSPDataTable("spAddListaPrecios", parametros);

                if (result != null)
                {
                    MessageBox.Show("Lista de precios guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar los campos después de guardar
                    txtNombre.Clear();
                    cmbActivo.SelectedIndex = 0; // Seleccionar "si" por defecto
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la lista de precios. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la lista de precios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            if (PantallaPrincipal.instanciaPantPrincipal != null)
            {
                PantallaPrincipal.instanciaPantPrincipal.OpenChildForm(new ListaPrecio());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los campos
            txtNombre.Clear();
            cmbActivo.SelectedIndex = 0; // Seleccionar "si" por defecto
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            // Cerrar esta pantalla y volver a la pantalla de lista de precios
            this.Close();
            
            // Abrir la pantalla de lista de precios
            //if (PantallaPrincipal.instanciaPantPrincipal != null)
            //{
            //    PantallaPrincipal.instanciaPantPrincipal.OpenChildForm(new ListaPrecio());
            //}
        }

        #endregion
    }
}
