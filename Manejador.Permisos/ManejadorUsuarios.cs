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
    public class ManejadorUsuarios
    {
        AccesoUsuarios au = new AccesoUsuarios();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(string.Format("¿Esta seguro de borrar: '{0}'", Entidad.nombre), "!Atencion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                au.Borrar(Entidad);
            }
        }
        public void Guardar(dynamic Entidad)
        {
            au.Guardar(Entidad);
            g.MensajeAlerta("Usuario guardado", "!Atencion",
                    MessageBoxIcon.Information);
        }
        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.AutoSize = true;
            tabla.AutoResizeColumns();
            tabla.DataSource = au.Mostrar(filtro).Tables["usuarios"];
            tabla.Columns.Insert(7, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(8, g.Boton("Borrar", Color.Red));
            tabla.Columns[0].Visible = true;
        }
        /*public bool Comprobar(string usuario, string clave)
        {
            int c = Convert.ToInt32(au.Comprobar(usuario, clave).Tables[0].Rows[0]["EXISTE"]);
            if (c == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/

    }
}
