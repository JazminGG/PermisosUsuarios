using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionPermisos
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
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
    }
}
