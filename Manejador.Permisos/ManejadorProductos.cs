using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Permisos;
using Entidades.Permisos;
using Crud;
using System.Windows.Forms;
using System.Drawing;

namespace Manejador.Permisos
{
    public class ManejadorProductos
    {
        AccesoProductos ap = new AccesoProductos();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(string.Format("¿Esta seguro de borrar: {0}", Entidad.CodigoBarras), "!Atencion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                ap.Borrar(Entidad);
            }
        }
        public void Guardar(dynamic Entidad)
        {
            ap.Guardar(Entidad);
            g.MensajeAlerta("Producto guardado", "!Atencion",
                    MessageBoxIcon.Information);
        }
        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.AutoSize = true;
            tabla.AutoResizeColumns();
            tabla.DataSource = ap.Mostrar(filtro).Tables["Productos"];
            tabla.Columns.Insert(4, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(5, g.Boton("Borrar", Color.Red));
            tabla.Columns[0].Visible = true;
        }
    }
}
