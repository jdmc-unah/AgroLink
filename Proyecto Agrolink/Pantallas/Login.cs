using AgroLink.Pantallas;

namespace AgroLink
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            //si el usuario y contra es correcto que ejecute estas dos lineas para pasar a la pantalla principal
            PantallaPrincipal.instanciaPantPrincipal.TogglePanelMain();
            this.Close();



        }
    }
}
