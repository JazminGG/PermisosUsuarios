using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Permisos
{
    class Usuarios
    {
        public Usuarios(int idusuario, string contrasena, string nombre, string apellidop, string apellidom, string fechanacimiento, string rfc)
        {
            this.idusuario = idusuario;
            this.contrasena = contrasena;
            this.nombre = nombre;
            this.apellidop = apellidop;
            this.apellidom = apellidom;
            this.fechanacimiento = fechanacimiento;
            this.rfc = rfc;
        }

        public int idusuario { get; set; }
        public string contrasena { get; set; }
        public string nombre { get; set; }
        public string apellidop { get; set; }
        public string apellidom { get; set; }
        public string fechanacimiento { get; set; }
        public string rfc { get; set; }
    }
}
