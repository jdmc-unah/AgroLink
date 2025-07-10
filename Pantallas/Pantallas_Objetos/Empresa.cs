using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AgroLink.Pantallas.Pantallas_Objetos
{
    public partial class Empresa : Form
    {
        public Empresa()
        {
            InitializeComponent();

        }

        Recursos_SQL.Recursos_SQL recSQL = new Recursos_SQL.Recursos_SQL();

        #region Metodos

        //Metodo para activar o desactivar readonly en los campos de texto
        void ToggleReadOnly(bool esSoloLectura)
        {
            this.textBox1.ReadOnly = esSoloLectura;
            this.textBox2.ReadOnly = esSoloLectura;
            this.textBox3.ReadOnly = esSoloLectura;
            this.textBox4.ReadOnly = esSoloLectura;
            this.richTextBox1.ReadOnly = esSoloLectura;
            this.button1.Visible = esSoloLectura;
            this.button2.Visible = !esSoloLectura;
            this.button3.Visible = !esSoloLectura;
        }

        #endregion
        private void Empresa_Load(object sender, EventArgs e)
        {
            //Trae  Datos Empresa y llena campos de formulario
            DataRow valores = recSQL.ejecutarVista("vDatosEmpresa").Rows[0];

            this.textBox1.Text = valores["Nombre"].ToString();
            this.textBox2.Text = valores["RTN"].ToString();
            this.textBox3.Text = valores["Correo"].ToString();
            this.textBox4.Text = valores["Telefono"].ToString();
            this.richTextBox1.Text = $"{valores["Detalle"].ToString()}, {valores["Colonia"].ToString()}, {valores["Municipio"].ToString()}, {valores["Departamento"].ToString()}   ";



            //Trae Numeros Fiscales y llena datagridview 1
            this.dataGridView1.DataSource = recSQL.ejecutarVista("vNumerosFiscales");

            //Trae Impuesto y llena datagridview 2
            this.dataGridView2.DataSource = recSQL.ejecutarVista("Pruebas.Impuesto");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToggleReadOnly(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToggleReadOnly(true);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ToggleReadOnly(true);

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView1.ReadOnly = false;
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
