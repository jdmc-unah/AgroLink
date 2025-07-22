using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgroLink.Modelos;

namespace AgroLink.Pantallas.Pantallas_Objetos
{
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
            this.Load += RegistroUsuario_Load;
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {
            cmbTipoUsuario.Items.Clear();
            cmbTipoUsuario.Items.Add("Administrador");
            cmbTipoUsuario.Items.Add("Estandar");
            cmbTipoUsuario.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuarioNuevo.Text.Trim();
            string nombre = txtNombreNuevo.Text.Trim();
            string clave = txtClaveNuevo.Text.Trim();
            string confirmarclave = txtConfirmarClaveNuevo.Text.Trim();
            string tipo = cmbTipoUsuario.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(usuario) ||
                string.IsNullOrEmpty(clave) ||
                string.IsNullOrEmpty(confirmarclave) ||
                string.IsNullOrEmpty(nombre) ||
                string.IsNullOrEmpty(tipo))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (clave != confirmarclave)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UsuarioSQL usuarioSQL = new UsuarioSQL();
            var resultado = usuarioSQL.AgregarUsuario(usuario, clave, nombre, tipo);

            if (resultado.Exito)
            {
                MessageBox.Show("Usuario registrado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error: " + resultado.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
