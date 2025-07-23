using AgroLink.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroLink.Pantallas
{
    public partial class ResetearClave : Form
    {
        public ResetearClave()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreRC.Text.Trim();
            string usuario = txtUsuarioRC.Text.Trim();
            string nuevaClave = txtClaveRC.Text.Trim();
            string confirmarClave = txtConfirmarClaveRC.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(nuevaClave) || string.IsNullOrEmpty(confirmarClave))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            UsuarioSQL usuarioSQL = new UsuarioSQL();
            bool coincide = usuarioSQL.VerificarUsuarioYNombre(usuario, nombre);
            bool exito = usuarioSQL.ResetearClave(usuario, nuevaClave);

            if (!coincide)
            {
                MessageBox.Show("El nombre no coincide con el usuario ingresado.");
                return;
            }

            if (nuevaClave != confirmarClave)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }


            if (exito)
            {
                MessageBox.Show("Contraseña actualizada correctamente.");
                this.Close(); // cierra este form
            }
            else
            {
                MessageBox.Show("Error al actualizar la contraseña.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombreRC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
