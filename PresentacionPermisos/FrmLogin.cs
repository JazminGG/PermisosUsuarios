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
        ManejadorPermisos mp;
        public static string Refacciones = "Productos";
        public static string Taller = "Herramientas";
        public static string usuario = "";
        public static string clave = "";
        public FrmLogin()
        {
            InitializeComponent();
            mu = new ManejadorUsuarios();
            mp = new ManejadorPermisos();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            usuario = txtUsuario.Text; clave = txtContrasena.Text;
            if (mu.Comprobar(txtUsuario.Text, txtContrasena.Text) == true)
            {
                if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, Refacciones) == "Ninguno" && mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, Taller) == "Ninguno")
                {
                    MessageBox.Show("Lo sentimos, no puedes acceder al sistema por la asignación de tus permisos.", "¡FALTA DE PERMISOS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    FrmMenu m = new FrmMenu();
                    m.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta, verifica tus datos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
