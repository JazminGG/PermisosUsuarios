using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Permisos
{
    class PermisosUsuario
    {
        public PermisosUsuario(int idpu, int fkidusuario, string modulo, bool pLectura, bool pEliminacion, bool pEscritura, bool pActualizacion)
        {
            this.idpu = idpu;
            this.fkidusuario = fkidusuario;
            this.modulo = modulo;
            PLectura = pLectura;
            PEliminacion = pEliminacion;
            PEscritura = pEscritura;
            PActualizacion = pActualizacion;
        }

        public int idpu { get; set; }
        public int fkidusuario { get; set; }
        public string modulo { get; set; }
        public bool PLectura { get; set; }
        public bool PEliminacion { get; set; }
        public bool PEscritura { get; set; }
        public bool PActualizacion { get; set; }


    }
}
