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
        ManejadorPermisos mpe;
        public static Productos Productos = new Productos("", "", "", "", 0);
        int fila = 0, col = 0;
        public static string Opc;
        public FrmProductos()
        {
            InitializeComponent();
            mp = new ManejadorProductos();
            mpe = new ManejadorPermisos();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            if (mpe.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Refacciones) == "Lectura" || mpe.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Refacciones) == "LecturaEliminacion" || mpe.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Refacciones) == "LecturaEscritura" || mpe.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Refacciones) == "LecturaEscrituraEliminacion" || mpe.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Refacciones) == "LecturaModificacion" || mpe.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Refacciones) == "Administrador")
            {
                DialogResult rs = MessageBox.Show("¿Quiere cargar los registros actualmente existentes en la base de datos?", "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    Actualizar();
                    Condicionantes();
                }
            }
            else
            {
                MessageBox.Show("No cuentas con los permisos adecuados para acceder al formulario.", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
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
            Condicionantes();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void Condicionantes()
        {
            if (mpe.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Refacciones) == "Lectura")
            {
                btnAgregar.Enabled = false;
                dtgProductos.Columns[4].Visible = false;
                dtgProductos.Columns[5].Visible = false;
            }
            if (mpe.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Refacciones) == "Escritura")
            {
                btnAgregar.Enabled = true;
                dtgProductos.Columns[4].Visible = false;
                dtgProductos.Columns[5].Visible = false;
            }
            if (mpe.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Refacciones) == "Eliminacion" || mpe.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Refacciones) == "LecturaEliminacion")
            {
                btnAgregar.Enabled = false;
                dtgProductos.Columns[4].Visible = false;
                dtgProductos.Columns[5].Visible = true;
            }
            if (mpe.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Refacciones) == "Modificacion")
            {
                btnAgregar.Enabled = false;
                dtgProductos.Columns[4].Visible = true;
                dtgProductos.Columns[5].Visible = false;
            }
            if (mpe.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Refacciones) == "LecturaEscritura")
            {
                btnAgregar.Enabled = true;
                dtgProductos.Columns[4].Visible = false;
                dtgProductos.Columns[5].Visible = false;
            }
            if (mpe.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Refacciones) == "LecturaEscrituraEliminacion" || mpe.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Refacciones) == "EscrituraEliminacion")
            {
                btnAgregar.Enabled = true;
                dtgProductos.Columns[4].Visible = false;
                dtgProductos.Columns[5].Visible = true;
            }
            if (mpe.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Refacciones) == "EscrituraModificacion")
            {
                btnAgregar.Enabled = true;
                dtgProductos.Columns[4].Visible = true;
                dtgProductos.Columns[5].Visible = false;
            }
            if (mpe.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Refacciones) == "EliminacionModificacion")
            {
                btnAgregar.Enabled = false;
                dtgProductos.Columns[4].Visible = true;
                dtgProductos.Columns[5].Visible = true;
            }
            if (mpe.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Refacciones) == "EscrituraEliminacionModificacion" || mpe.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Refacciones) == "LecturaModificacion")
            {
                btnAgregar.Enabled = true;
                dtgProductos.Columns[4].Visible = true;
                dtgProductos.Columns[5].Visible = true;
            }
        }
    }
}
