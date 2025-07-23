using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroLink.Modelos
{
    public class InfoUsuario
    {
        public int UsuarioID { get; set; }
        public string Usuario { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public string TipoUsuario { get; set; }
    }
}