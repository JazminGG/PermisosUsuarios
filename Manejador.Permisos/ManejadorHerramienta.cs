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
    public class ManejadorHerramienta
    {
        AccesoHerramientas ah = new AccesoHerramientas();
        Grafico g = new Grafico();

        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(string.Format("¿Esta seguro de borrar: {0}", Entidad.CodigoHerramienta), "!Atencion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                ah.Borrar(Entidad);
            }
        }
        public void Guardar(dynamic Entidad)
        {
            ah.Guardar(Entidad);
            g.MensajeAlerta("Herramienta guardada", "!Atencion",
                    MessageBoxIcon.Information);
        }
        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.AutoSize = true;
            tabla.AutoResizeColumns();
            tabla.DataSource = ah.Mostrar(filtro).Tables["Herramientas"];
            tabla.Columns.Insert(5, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(6, g.Boton("Borrar", Color.Red));
            tabla.Columns[0].Visible = true;
        }
    }
}
