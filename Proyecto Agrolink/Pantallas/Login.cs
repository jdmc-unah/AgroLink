using AgroLink.Pantallas;
using AgroLink.Recursos;
using AgroLink.Modelos;
using AgroLink.Pantallas.Pantallas_Objetos;

namespace AgroLink
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        #region Variables Globales
        Recursos_SQL recSQL = new Recursos_SQL();
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text.Trim();
                string clave = txtClave.Text.Trim();

                if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave))
                {
                    MessageBox.Show("Ingrese su usuario y clave.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    { "Usuario", usuario },
                    { "Clave", clave }
                };

                var dt = recSQL.EjecutarSPDataTable("spValidarUsuario", parametros);

                if (dt.Rows.Count > 0)
                {
                    InfoUsuario usuarioActual = new InfoUsuario()
                    {
                        Usuario = dt.Rows[0]["Usuario"].ToString(),
                        Nombre = dt.Rows[0]["Nombre"].ToString(),
                        TipoUsuario = dt.Rows[0]["TipoUsuario"].ToString()
                    };

                    Sesion.usuarioActual = usuarioActual;

                    //si todo esta bien continue
                    PantallaPrincipal.instanciaPantPrincipal.TogglePanelMain();
                    this.Close();
                }
                else
                {
                    //usuario o clave incorrectos
                    MessageBox.Show("Usuario o clave incorrectos.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistroUsuario registro = new RegistroUsuario();
            registro.ShowDialog();


        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetearClave reestablecer = new ResetearClave();
            reestablecer.StartPosition = FormStartPosition.CenterScreen;
            reestablecer.ShowDialog();
        }
    }
}
