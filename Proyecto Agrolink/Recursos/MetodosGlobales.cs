using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroLink.Recursos
{
    public class MetodosGlobales
    {

        public bool MensajeConfirmacion(string titulo, string mensaje)
        {
            DialogResult resultado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                return true;

            }

            return false;
        }



        public DataTable CrearDataTable(DataGridView myDataGrid)
        {

            DataTable myDataTable = new DataTable();

            // Crear columnas
            foreach (DataGridViewColumn col in myDataGrid.Columns)
            {
                myDataTable.Columns.Add(col.Name, col.ValueType ?? typeof(string));
            }

            // Agregar filas
            foreach (DataGridViewRow row in myDataGrid.Rows)
            {
                if (!row.IsNewRow)
                {
                    DataRow dr = myDataTable.NewRow();
                    foreach (DataGridViewColumn col in myDataGrid.Columns)
                    {
                        dr[col.Name] = row.Cells[col.Name].Value ?? DBNull.Value;
                    }
                    myDataTable.Rows.Add(dr);
                }
            }

            return myDataTable;
        }











    }
}
