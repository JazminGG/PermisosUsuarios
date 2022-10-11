using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Permisos;
using Manejador.Permisos;

namespace PresentacionPermisos
{
    public partial class FrmAddPermisosUsuarios : Form
    {
        ManejadorPermisos mp;
        public FrmAddPermisosUsuarios()
        {
            InitializeComponent();
            mp = new ManejadorPermisos();
            mp.ExtraerUsuarioAPermisos(cmbUsuarios);
            if (FrmPermisosUsuarios.permisou.IdPu > 0)
            {
                cmbUsuarios.Text = FrmPermisosUsuarios.nombreusu.ToString();
                cmbModulo.Text = FrmPermisosUsuarios.permisou.Modulo.ToString();
                cmbModulo.Enabled = false;
                cmbLectura.Text = FrmPermisosUsuarios.permisou.PermisoLectura.ToString();
                cmbEscritura.Text = FrmPermisosUsuarios.permisou.PermisoEscritura.ToString();
                cmbEliminacion.Text = FrmPermisosUsuarios.permisou.PermisoEliminacion.ToString();
                cmbModificacion.Text = FrmPermisosUsuarios.permisou.PermisoActualizacion.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmPermisosUsuarios.permisou.IdPu != -1)
            {
                mp.Guardar(new PermisosUsuario(FrmPermisosUsuarios.idmodificador, int.Parse(cmbUsuarios.SelectedValue.ToString()), cmbModulo.Text, bool.Parse(cmbLectura.Text), bool.Parse(cmbEscritura.Text), bool.Parse(cmbEliminacion.Text), bool.Parse(cmbModificacion.Text)));
                Close();
            }
            else if (FrmPermisosUsuarios.permisou.IdPu == -1)
            {
                mp.Guardar(new PermisosUsuario(FrmPermisosUsuarios.permisou.IdPu, int.Parse(cmbUsuarios.SelectedValue.ToString()), cmbModulo.Text, bool.Parse(cmbLectura.Text), bool.Parse(cmbEscritura.Text), bool.Parse(cmbEliminacion.Text), bool.Parse(cmbModificacion.Text)));
                Close();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
