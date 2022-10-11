using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Permisos
{
    interface iUsuarios
    {
        DataSet Comprobar(string usuario, string clave);
        void Guardar(dynamic Entidad);
        void Borrar(dynamic Entidad);
        DataSet Mostrar(string filtro);
    }
}
