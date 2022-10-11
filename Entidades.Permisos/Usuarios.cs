using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Permisos
{
    public class Usuarios
    {
        public Usuarios(int idusuario, string nombre, string apellidop, string apellidom, string fechanac, string rfc, string contrasena)
        {
            this.idusuario = idusuario;
            this.nombre = nombre;
            this.apellidop = apellidop;
            this.apellidom = apellidom;
            this.fechanac = fechanac;
            this.rfc = rfc;
            this.contrasena = contrasena;
        }

        public int idusuario { get; set; }
        public string nombre { get; set; }
        public string apellidop { get; set; }
        public string apellidom { get; set; }
        public string fechanac { get; set; }
        public string rfc { get; set; }
        public string contrasena { get; set; }
    }
}
