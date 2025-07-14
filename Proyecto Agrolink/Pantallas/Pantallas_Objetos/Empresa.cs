using AgroLink.Recursos;
using System.Data;

namespace AgroLink.Pantallas.Pantallas_Objetos
{
    public partial class Empresa : Form
    {
        public Empresa()
        {
            InitializeComponent();

        }

        Recursos_SQL recSQL = new Recursos.Recursos_SQL();
        MetodosGlobales metGlobales = new Recursos.MetodosGlobales();

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
            DataRow valores = recSQL.EjecutarVista("vDatosEmpresa").Rows[0];

            this.textBox1.Text = valores["Nombre"].ToString();
            this.textBox2.Text = valores["RTN"].ToString();
            this.textBox3.Text = valores["Correo"].ToString();
            this.textBox4.Text = valores["Telefono"].ToString();
            // this.richTextBox1.Text = $"{valores["Detalle"].ToString()}, {valores["Colonia"].ToString()}, {valores["Municipio"].ToString()}, {valores["Departamento"].ToString()}   ";



            //Trae Numeros Fiscales y llena datagridview 1
            this.dataGridView1.DataSource = recSQL.EjecutarVista("vNumerosFiscales");

            //Trae Impuesto y llena datagridview 2
            this.dataGridView2.DataSource = recSQL.EjecutarVista("vImpuesto");


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
            //Toma el indice de la fila seleccionada y el valor seleccionado 
            int row = this.dataGridView1.CurrentRow.Index;
            int numFiscalID = (int)this.dataGridView1.Rows[row].Cells[0].Value;

            //Confirma la decision del usuario y procede con lo demas
            if (metGlobales.MensajeConfirmacion("Confirmar", $"Esta seguro de borrar el Numero Fiscal con ID {numFiscalID}"))
            {
                //se crea diccionario para poner el paramemtro del id
                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    {"id", numFiscalID },
                    {"tabla", "NumFiscal" }
                };

                //validar la ejecucion de spBorrarNumFiscal
                if (recSQL.EjecutarSPBool("spBorrarRegistro", parametros))
                {
                    MessageBox.Show($"Se borro el numero fiscal con el id {numFiscalID}");
                    this.dataGridView1.DataSource = recSQL.EjecutarVista("vNumerosFiscales");

                }
                else
                {
                    MessageBox.Show($"Ocurrio un error al borrar el numero fiscal {numFiscalID}");
                }

            }




        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            //Toma el indice de la fila seleccionada y el valor seleccionado 
            int row = this.dataGridView2.CurrentRow.Index;
            int impuestoID = (int)this.dataGridView2.Rows[row].Cells[0].Value;

            //Confirma la decision del usuario y procede con lo demas
            if (metGlobales.MensajeConfirmacion("Confirmar", $"Esta seguro de borrar el Impuesto con ID {impuestoID}"))
            {
                //se crea diccionario para poner el paramemtro del id
                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    {"id", impuestoID },
                    {"tabla", "Impuesto" }
                };

                //validar la ejecucion de spBorrarNumFiscal
                if (recSQL.EjecutarSPBool("spBorrarRegistro", parametros))
                {
                    MessageBox.Show($"Se borro el Impuesto con el id {impuestoID}");
                    this.dataGridView2.DataSource = recSQL.EjecutarVista("vImpuesto");

                }
                else
                {
                    MessageBox.Show($"Ocurrio un error al borrar el Impuesto {impuestoID}");
                }

            }

        }
    }
}
