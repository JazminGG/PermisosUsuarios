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
    public partial class FrmAddProducto : Form
    {
        ManejadorProductos mp;
        public FrmAddProducto()
        {
            InitializeComponent();
            mp = new ManejadorProductos();
            if (FrmProductos.Productos.Op> 0)
            {
                txtCodigoBarras.Text = FrmProductos.Productos.CodigoBarras.ToString();
                txtNombre.Text = FrmProductos.Productos.Nombre;
                txtDescripcion.Text = FrmProductos.Productos.Descripcion;
                txtMarca.Text = FrmProductos.Productos.Marca;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmProductos.Productos.Op != -1)
            {
                mp.Guardar(new Productos(txtCodigoBarras.Text, txtNombre.Text,txtDescripcion.Text, txtMarca.Text, FrmProductos.Productos.Op));
                Close();
            }
            else if (FrmProductos.Productos.Op == -1)
            {
                mp.Guardar(new Productos(txtCodigoBarras.Text, txtNombre.Text, txtDescripcion.Text, txtMarca.Text, FrmProductos.Productos.Op));
                Close();
            }
        }
    }
}
