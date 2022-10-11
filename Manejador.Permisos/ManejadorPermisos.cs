using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Permisos;
using AccesoDatos.Permisos;
using Crud;
using System.Windows.Forms;
using System.Drawing;

namespace Manejador.Permisos
{
    public class ManejadorPermisos
    {
        AccesoPermisosUsuario ap = new AccesoPermisosUsuario();
        AccesoUsuarios au = new AccesoUsuarios();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(string.Format("Está seguro de borrar el permiso del modulo '{0}'", Entidad.Modulo), "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                ap.Borrar(Entidad);
            }
        }

        public void Guardar(dynamic Entidad)
        {
            ap.Guardar(Entidad);
            g.MensajeAlerta ("Permiso Guardado", "¡ATENCIÓN!", MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = ap.Mostrar(filtro).Tables["PermisosUsuario"];
            tabla.Columns.Insert(7, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(8, g.Boton("Borrar", Color.Red));
            tabla.AutoResizeColumns();
            tabla.Columns[0].Visible = false;
        }
        public void ExtraerUsuarioAPermisos(ComboBox caja)
        {
            caja.DataSource = au.Mostrar("").Tables["usuarios"];
            caja.DisplayMember = "Nombre del usuario";
            caja.ValueMember = "ID";
        }
    }
}
