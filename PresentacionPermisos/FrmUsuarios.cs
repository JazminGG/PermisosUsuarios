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
    public partial class FrmUsuarios : Form
    {
        ManejadorUsuarios mu;
        public static Usuarios usuario = new Usuarios(0,"", "", "", "", "","");
        int fila = 0, col = 0;
        public static int Modificador = 0;
        public FrmUsuarios()
        {
            InitializeComponent();
            mu = new ManejadorUsuarios();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dtgUsuarios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            usuario.idusuario = -1;
            FrmAddUsuario addU = new FrmAddUsuario();
            addU.ShowDialog();
        }

        private void dtgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            usuario.idusuario = Convert.ToInt32(dtgUsuarios.Rows[fila].Cells[0].Value);
            usuario.nombre = dtgUsuarios.Rows[fila].Cells[1].Value.ToString();
            usuario.apellidop = dtgUsuarios.Rows[fila].Cells[2].Value.ToString();
            usuario.apellidom = dtgUsuarios.Rows[fila].Cells[3].Value.ToString();
            usuario.fechanac = dtgUsuarios.Rows[fila].Cells[4].Value.ToString();
            usuario.rfc = dtgUsuarios.Rows[fila].Cells[5].Value.ToString();
            usuario.contrasena = dtgUsuarios.Rows[fila].Cells[6].Value.ToString();
            switch (col)
            {
                case 7:
                    {
                        Modificador = Convert.ToInt32(dtgUsuarios.Rows[fila].Cells[0].Value);
                        usuario.idusuario = 1;
                        FrmAddUsuario addu = new FrmAddUsuario();
                        addu.Show();
                        txtBuscar.Text = "-1";
                        txtBuscar.Clear();
                        Actualizar();
                    }
                    break;
                case 8:
                    {
                        mu.Borrar(usuario);
                        txtBuscar.Text = "";
                        Actualizar();
                    }
                    break;
            }
        }

        void Actualizar()
        {
            mu.Mostrar(dtgUsuarios, txtBuscar.Text);
        }
    }
}
