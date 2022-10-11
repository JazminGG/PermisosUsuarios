using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;

namespace AccesoDatos.Permisos
{
    class AccesoPermisosUsuario : iPermisos
    {
        Base b = new Base("localhost", "root", "", "Permisos");
        public void Borrar(dynamic Entidad)
        {
            throw new NotImplementedException();
        }

        public void Guardar(dynamic Entidad)
        {
            throw new NotImplementedException();
        }

        public DataSet Mostrar(string filtro)
        {
            throw new NotImplementedException();
        }

        public DataSet ValidacionPermisos(string usuario, string clave, string modulo)
        {
            throw new NotImplementedException();
        }
    }
}
