using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;

namespace AccesoDatos.Permisos
{
    public class AccesoPermisosUsuario : iPermisos
    {
        Base b = new Base("localhost", "root", "", "Permisos");
        public void Borrar(dynamic Entidad)
        {
            b.Comando(String.Format("call EliminarPermisos({0})", Entidad.IdPu));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(String.Format("call InsertarOActualizarPermisos({0},'{1}',{2},{3},{4},{5},{6})", Entidad.Fkidusuario, Entidad.Modulo, Entidad.PermisoLectura, Entidad.PermisoEscritura, Entidad.PermisoEliminacion, Entidad.PermisoActualizacion, Entidad.IdPu));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("call MostrarPermisos('%{0}%')", filtro), "PermisosUsuario");
        }

        public DataSet ValidacionPermisos(string usuario, string clave, string modulo)
        {
            return b.Obtener(String.Format("SELECT permisolectura,permisoescritura,permisoeliminacion,permisoactualizacion FROM PermisosUsuario JOIN usuarios ON usuarios.idusuario=PermisosUsuario.fkidusuario WHERE usuarios.nombre='{0}' AND usuarios.contrasena='{1}' AND PermisosUsuario.modulo='{2}'", usuario, clave, modulo), "PermisosUsuario");
        }
    }
}
