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
    public class AccesoProductos : iEntidades
    {
        Base b = new Base("localhost", "root", "", "Permisos");
        public void Borrar(dynamic Entidad)
        {
            b.Comando(string.Format("CALL EliminarProductos('{0}')", Entidad.CodigoBarras));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(string.Format("CALL InsertarOActualizarProductos('{0}','{1}','{2}','{3}',{4})", Entidad.CodigoBarras, Entidad.Nombre, Entidad.Descripcion, Entidad.Marca, Entidad.Op));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("CALL MostrarProductos('%{0}%');", filtro), "Productos");
        }
    }
}
