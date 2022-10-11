using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;
using Entidades.Permisos;

namespace AccesoDatos.Permisos
{
    public class AccesoUsuarios : iUsuarios
    {
        Base b = new Base("localhost", "root", "", "Permisos");

        public void Borrar(dynamic Entidad)
        {
            b.Comando(string.Format("CALL EliminarUsuario({0})", Entidad.idusuario));
        }

        public DataSet Comprobar(string usuario, string clave)
        {
            return b.Obtener(string.Format("select count(*) as Existe from usuarios where nombre = '{0}' and contrasena ='{1}'", usuario,clave),"usuarios");
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(string.Format("CALL InsertarOActualizarUsuario('{0}','{1}','{2}','{3}','{4}','{5}',{6})", Entidad.nombre, Entidad.apellidop, Entidad.apellidom, Entidad.fechanac, Entidad.rfc, Entidad.contrasena, Entidad.idusuario));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("CALL MostrarUsuario('%{0}%');", filtro), "usuarios");
        }
    }
}
