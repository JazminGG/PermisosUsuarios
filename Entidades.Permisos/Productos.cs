using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Permisos
{
    public class Productos
    {
        public Productos(int codigobarras, string nombre, string descripcion, string marca)
        {
            this.codigobarras = codigobarras;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.marca = marca;
        }

        public int codigobarras { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string marca { get; set; }
    }
}
