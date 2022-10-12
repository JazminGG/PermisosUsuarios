using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejador.Permisos;

namespace PresentacionPermisos
{
    public partial class FrmMenu : Form
    {
        ManejadorPermisos mp;
        public FrmMenu()
        {
            InitializeComponent();
            mp = new ManejadorPermisos();
        }

        private void btnAgregarUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios u = new FrmUsuarios();
            u.ShowDialog();
        }

        private void btnAgregarHerramientas_Click(object sender, EventArgs e)
        {
            FrmHerramientas he = new FrmHerramientas();
            he.ShowDialog();
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            FrmProductos p = new FrmProductos();
            p.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAsignarPermisos_Click(object sender, EventArgs e)
        {
            FrmPermisosUsuarios pu = new FrmPermisosUsuarios();
            pu.ShowDialog();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Taller) != "Administrador" && mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Refacciones) != "Administrador")
            {
                btnAgregarUsuarios.Visible = false;
                btnAsignarPermisos.Visible = false;
            }
        }
    }
}
