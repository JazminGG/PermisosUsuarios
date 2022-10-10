using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Permisos
{
    public class Productos
    {
        public Productos(string codigoBarras, string nombre, string descripcion, string marca, int op)
        {
            CodigoBarras = codigoBarras;
            Nombre = nombre;
            Descripcion = descripcion;
            Marca = marca;
            Op = op;
        }

        public string CodigoBarras { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public int Op { get; set; }
    }
}
