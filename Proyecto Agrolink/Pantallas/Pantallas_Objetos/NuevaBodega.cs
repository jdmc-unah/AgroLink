using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using AgroLink.Recursos;
using AgroLink.Pantallas;

namespace AgroLink.Pantallas.Pantallas_Objetos
{
    public partial class NuevaBodega : Form
    {
        #region Variables Globales

        Recursos_SQL recSQL = new Recursos_SQL();
        MetodosGlobales metodosGlobales = new MetodosGlobales();

        #endregion

        public NuevaBodega()
        {
            InitializeComponent();
        }

        #region Métodos

        private void LlenarComboDirecciones()
        {
            try
            {
                // Llenar el combo de direcciones
                cmbDireccion.DataSource = recSQL.EjecutarVista("vDirecciones");
                cmbDireccion.DisplayMember = "DireccionCompleta";
                cmbDireccion.ValueMember = "DireccionID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar direcciones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Eventos

        private void NuevaBodega_Load(object sender, EventArgs e)
        {
            LlenarComboDirecciones();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos obligatorios no estén vacíos
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtCapacidad.Text) ||
                    cmbDireccion.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que la capacidad sea un número válido
                if (!decimal.TryParse(txtCapacidad.Text, out decimal capacidad))
                {
                    MessageBox.Show("Por favor ingrese una capacidad válida.", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCapacidad.Focus();
                    return;
                }

                // Preparar los parámetros para el procedimiento almacenado
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    { "nombre", txtNombre.Text.Trim() },
                    { "capacidad", capacidad },
                    { "direccionID", cmbDireccion.SelectedValue }
                };

                // Ejecutar el procedimiento almacenado para agregar la bodega
                object result = recSQL.EjecutarSPDataTable("spAddBodega", parametros);

                if (result != null)
                {
                    MessageBox.Show("Bodega guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar los campos después de guardar
                    txtNombre.Clear();
                    txtCapacidad.Clear();
                    cmbDireccion.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la bodega. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la bodega: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            if (PantallaPrincipal.instanciaPantPrincipal != null)
            {
                PantallaPrincipal.instanciaPantPrincipal.OpenChildForm(new Bodega());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los campos
            txtNombre.Clear();
            txtCapacidad.Clear();
            cmbDireccion.SelectedIndex = -1;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            // Cerrar esta pantalla y volver a la pantalla de bodegas
            this.Close();
            
            // Abrir la pantalla de bodegas
            //if (PantallaPrincipal.instanciaPantPrincipal != null)
            //{
            //    PantallaPrincipal.instanciaPantPrincipal.OpenChildForm(new Bodega());
            //}
        }

        private void txtCapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números, punto decimal y tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        #endregion
    }
}
