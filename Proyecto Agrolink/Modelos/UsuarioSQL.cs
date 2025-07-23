using AgroLink.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroLink.Modelos
{
    public class UsuarioSQL
    {
        Recursos_SQL recSQL = new Recursos_SQL();

        public AgregarNuevoUsuario AgregarUsuario(string usuario, string clave, string nombre, string tipo)
        {
            AgregarNuevoUsuario resultado = new AgregarNuevoUsuario();

            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                { "Usuario", usuario },
                { "Clave", clave },
                { "Nombre", nombre },
                { "TipoUsuario", tipo }
            };

            try
            {
                var tabla = recSQL.EjecutarSPDataTable("spAgregarUsuario", parametros);

                if (tabla.Rows.Count > 0)
                {
                    var fila = tabla.Rows[0];
                    resultado.Exito = Convert.ToInt32(fila["Exito"]) == 1;
                    resultado.Mensaje = fila["Mensaje"].ToString();

                    if (fila.Table.Columns.Contains("UsuarioID") && fila["UsuarioID"] != DBNull.Value)
                    {
                        resultado.UsuarioID = Convert.ToInt32(fila["UsuarioID"]);
                    }
                }
                else
                {
                    resultado.Exito = false;
                    resultado.Mensaje = "No se obtuvo respuesta del procedimiento almacenado.";
                }
            }
            catch (Exception ex)
            {
                resultado.Exito = false;
                resultado.Mensaje = "Error: " + ex.Message;
            }

            return resultado;
        }

        public bool VerificarUsuarioYNombre(string usuario, string nombre)
        {
            try
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    { "Usuario", usuario }
                };

                var tabla = recSQL.EjecutarSPDataTable("spObtenerUsuarioPorNombreUsuario", parametros);

                if (tabla.Rows.Count > 0)
                {
                    var fila = tabla.Rows[0];
                    string nombreRegistrado = fila["Nombre"].ToString().Trim();

                    return string.Equals(nombreRegistrado, nombre, StringComparison.OrdinalIgnoreCase);
                }
            }
            catch
            {

            }

            return false;
        }


        public bool ResetearClave(string usuario, string nuevaClave)
        {
            try
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    { "Usuario", usuario },
                    { "NuevaClave", nuevaClave }
                };

                Recursos_SQL recSQL = new Recursos_SQL();
                recSQL.EjecutarSPDataTable("spResetearClave", parametros); 

                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}

