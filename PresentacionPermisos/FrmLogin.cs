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
    public partial class FrmLogin : Form
    {
        ManejadorUsuarios mu;
        public FrmLogin()
        {
            InitializeComponent();
            mu = new ManejadorUsuarios();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (mu.Comprobar(txtUsuario.Text, txtContrasena.Text) == true)
            {
                    FrmMenu m = new FrmMenu();
                    m.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta, verifica tus datos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
