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
    public class AccesoHerramientas : iEntidades
    {
        Base b = new Base("localhost", "root", "", "Permisos");
        public void Borrar(dynamic Entidad)
        {
            b.Comando(string.Format("CALL EliminarHerramientas({0})", Entidad.CodigoHerramienta));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(string.Format("CALL InsertarOActualizarHerramientas('{0}',{1},'{2}','{3}',{4})", Entidad.Nombre, Entidad.Medida, Entidad.Marca, Entidad.Descripcion, Entidad.CodigoHerramienta));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("CALL MostrarHerramientas('%{0}%');", filtro), "Herramientas");
 
        }
    }
}
