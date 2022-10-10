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
    public partial class FrmProductos : Form
    {
        ManejadorProductos mp;
        public static Productos Productos = new Productos("", "", "", "", 0);
        int fila = 0, col = 0;
        public static string Opc;
        public FrmProductos()
        {
            InitializeComponent();
            mp = new ManejadorProductos();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dtgProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Productos.Op= -1;
            FrmAddProducto addP = new FrmAddProducto();
            addP.ShowDialog();
        }

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Productos.CodigoBarras = dtgProductos.Rows[fila].Cells[0].Value.ToString();
            Productos.Nombre = dtgProductos.Rows[fila].Cells[1].Value.ToString();
            Productos.Descripcion = dtgProductos.Rows[fila].Cells[2].Value.ToString();
            Productos.Marca = dtgProductos.Rows[fila].Cells[3].Value.ToString();
            switch (col)
            {
                case 4:
                    {
                        Opc = dtgProductos.Rows[fila].Cells[0].Value.ToString();
                        Productos.Op = 1;
                        FrmAddProducto addp = new FrmAddProducto();
                        addp.ShowDialog();
                        txtBuscar.Text = "-1";
                        txtBuscar.Clear();
                        Actualizar();
                    }
                    break;
                case 5:
                    {
                        mp.Borrar(Productos);
                        txtBuscar.Text = "";
                        Actualizar();
                    }
                    break;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }
        void Actualizar()
        {
            mp.Mostrar(dtgProductos, txtBuscar.Text);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
