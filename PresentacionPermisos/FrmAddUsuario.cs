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
    public partial class FrmAddUsuario : Form
    {
        ManejadorUsuarios mu;
        public FrmAddUsuario()
        {
            InitializeComponent();
            mu = new ManejadorUsuarios();
            if (FrmUsuarios.usuario.idusuario > 0)
            {
                txtNombre.Text = FrmUsuarios.usuario.nombre.ToString();
                txtApellidop.Text = FrmUsuarios.usuario.apellidop.ToString();
                txtApellidom.Text = FrmUsuarios.usuario.apellidom.ToString();
                dtpNacimiento.Text = FrmUsuarios.usuario.fechanac.ToString();
                txtRFC.Text = FrmUsuarios.usuario.rfc.ToString();
                txtContrasena.Text = FrmUsuarios.usuario.contrasena.ToString();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmUsuarios.usuario.idusuario != -1)
            {
                mu.Guardar(new Usuarios(FrmUsuarios.Modificador, txtNombre.Text, txtApellidop.Text, txtApellidom.Text, dtpNacimiento.Text, txtRFC.Text, txtContrasena.Text));
                Close();
            }
            else if (FrmUsuarios.usuario.idusuario == -1)
            {
                mu.Guardar(new Usuarios(FrmUsuarios.usuario.idusuario, txtNombre.Text, txtApellidop.Text, txtApellidom.Text, dtpNacimiento.Text, txtRFC.Text, txtContrasena.Text));
                Close();
            }
        }
    }
}
