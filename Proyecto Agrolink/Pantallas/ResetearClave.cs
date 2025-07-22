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

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(nuevaClave) || string.IsNullOrEmpty(confirmarClave))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            if (nuevaClave != confirmarClave)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            UsuarioSQL usuarioSQL = new UsuarioSQL();
            bool exito = usuarioSQL.ResetearClave(usuario, nuevaClave);

            if (exito)
            {
                MessageBox.Show("Contraseña actualizada correctamente.");
                this.Close(); // Cierra este form
            }
            else
            {
                MessageBox.Show("Error al actualizar la contraseña.");
            }
        }
    }
}
