using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Permisos
{
    public class PermisosUsuario
    {
        public PermisosUsuario(int idPu, int fkidusuario, string modulo, bool permisoLectura, bool permisoEscritura, bool permisoEliminacion, bool permisoActualizacion)
        {
            IdPu = idPu;
            Fkidusuario = fkidusuario;
            Modulo = modulo;
            PermisoLectura = permisoLectura;
            PermisoEscritura = permisoEscritura;
            PermisoEliminacion = permisoEliminacion;
            PermisoActualizacion = permisoActualizacion;
        }

        public int IdPu { get; set; }
        public int Fkidusuario { get; set; }
        public string Modulo { get; set; }
        public bool PermisoLectura { get; set; }
        public bool PermisoEscritura { get; set; }
        public bool PermisoEliminacion { get; set; }
        public bool PermisoActualizacion { get; set; }
    }
}
