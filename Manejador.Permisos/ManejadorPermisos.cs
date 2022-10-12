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
        public string AsignacionPermisos(string usuario, string clave, string modulo)
        {
            bool lectura = bool.Parse(ap.ValidacionPermisos(usuario, clave, modulo).Tables[0].Rows[0]["permisolectura"].ToString());
            bool escritura = bool.Parse(ap.ValidacionPermisos(usuario, clave, modulo).Tables[0].Rows[0]["permisoescritura"].ToString());
            bool eliminacion = bool.Parse(ap.ValidacionPermisos(usuario, clave, modulo).Tables[0].Rows[0]["permisoeliminacion"].ToString());
            bool modificacion = bool.Parse(ap.ValidacionPermisos(usuario, clave, modulo).Tables[0].Rows[0]["permisoactualizacion"].ToString());


            if (lectura == true && escritura == true && eliminacion == true && modificacion == true)
            {
                return "Administrador";
            }
            if (lectura == true && escritura == false && eliminacion == false && modificacion == false)
            {
                return "Lectura";
            }
            if (lectura == false && escritura == true && eliminacion == false && modificacion == false)
            {
                return "Escritura";
            }
            if (lectura == false && escritura == false && eliminacion == true && modificacion == false)
            {
                return "Eliminacion";
            }
            if (lectura == false && escritura == false && eliminacion == false && modificacion == true)
            {
                return "Modificacion";
            }
            if (lectura == true && escritura == true && eliminacion == false && modificacion == false)
            {
                return "LecturaEscritura";
            }
            if (lectura == true && escritura == true && eliminacion == true && modificacion == false)
            {
                return "LecturaEscrituraEliminacion";
            }
            if (lectura == true && escritura == false && eliminacion == true && modificacion == false)
            {
                return "LecturaEliminacion";
            }
            if (lectura == false && escritura == true && eliminacion == false && modificacion == true)
            {
                return "EscrituraModificacion";
            }
            if (lectura == false && escritura == false && eliminacion == true && modificacion == true)
            {
                return "EliminacionModificacion";
            }
            if (lectura == false && escritura == true && eliminacion == true && modificacion == true)
            {
                return "EscrituraEliminacionModificacion";
            }
            if (lectura == false && escritura == true && eliminacion == true && modificacion == false)
            {
                return "EscrituraEliminacion";
            }
            if (lectura == true && escritura == false && eliminacion == false && modificacion == true)
            {
                return "LecturaModificacion";
            }
            if (lectura == true && escritura == false && eliminacion == true && modificacion == true)
            {
                return "LecturaEliminacionModificacion";
            }
            if (lectura == false && escritura == false && eliminacion == false && modificacion == false)
            {
                return "Ninguno";
            }
            else
            {
                return "Falta condicionar";
            }
        }
    }
}
