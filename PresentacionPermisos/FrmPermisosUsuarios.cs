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
using Entidades.Permisos;

namespace PresentacionPermisos
{
    public partial class FrmPermisosUsuarios : Form
    {
        ManejadorPermisos mp;
        public static PermisosUsuario permisou = new PermisosUsuario(0, 0, "", true, true, true, true);
        int columna = 0, fila = 0;
        public static int idmodificador = 0;
        public static string nombreusu = "";
        public FrmPermisosUsuarios()
        {
            InitializeComponent();
            mp = new ManejadorPermisos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            permisou.IdPu = -1;
            FrmAddPermisosUsuarios u = new FrmAddPermisosUsuarios();
            u.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPermisosUsuarios_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dtgPermisos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            permisou.IdPu = int.Parse(dtgPermisos.Rows[fila].Cells[0].Value.ToString());
            nombreusu = dtgPermisos.Rows[fila].Cells[1].Value.ToString();
            permisou.Modulo = dtgPermisos.Rows[fila].Cells[2].Value.ToString();
            permisou.PermisoLectura = bool.Parse(dtgPermisos.Rows[fila].Cells[3].Value.ToString());
            permisou.PermisoEscritura = bool.Parse(dtgPermisos.Rows[fila].Cells[4].Value.ToString());
            permisou.PermisoEliminacion = bool.Parse(dtgPermisos.Rows[fila].Cells[5].Value.ToString());
            permisou.PermisoActualizacion = bool.Parse(dtgPermisos.Rows[fila].Cells[6].Value.ToString());
            switch (columna)
            {
                case 7:
                    {
                        permisou.IdPu = 1;
                        idmodificador = int.Parse(dtgPermisos.Rows[fila].Cells[0].Value.ToString());
                        FrmAddPermisosUsuarios pu = new FrmAddPermisosUsuarios();
                        pu.Show();
                        txtBuscar.Text = "-1";
                        txtBuscar.Clear();
                        Actualizar();
                    }
                    break;
                case 8:
                    {
                        mp.Borrar(permisou);
                        txtBuscar.Text = "";
                        Actualizar();
                    }
                    break;
            }
        }

        private void dtgPermisos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

        public void Actualizar()
        {
            mp.Mostrar(dtgPermisos, txtBuscar.Text);
        }
    }
}
