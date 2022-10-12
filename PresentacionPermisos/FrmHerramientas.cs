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
    public partial class FrmHerramientas : Form
    {
        ManejadorHerramienta mh;
        ManejadorPermisos mp;
        public static Herramientas herramientas = new Herramientas(0, "", 0.0, "", "");
        int fila = 0, col = 0;
        public static int Opc;
        public FrmHerramientas()
        {
            InitializeComponent();
            mh = new ManejadorHerramienta();
            mp = new ManejadorPermisos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmHerramientas_Load(object sender, EventArgs e)
        {
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Taller) == "LecturaEliminacionModificacion" || mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Taller) == "Lectura" || mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Taller) == "LecturaEliminacion" || mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Taller) == "LecturaEscritura" || mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Taller) == "LecturaEscrituraEliminacion" || mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Taller) == "LecturaModificacion" || mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Taller) == "Administrador")
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

        private void dtgHerramienta_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            herramientas.CodigoHerramienta = -1;
            FrmAddHerramientas addH = new FrmAddHerramientas();
            addH.ShowDialog();
        }

        private void dtgHerramienta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            herramientas.CodigoHerramienta = int.Parse(dtgHerramienta.Rows[fila].Cells[0].Value.ToString());
            herramientas.Nombre = dtgHerramienta.Rows[fila].Cells[1].Value.ToString();
            herramientas.Medida = Convert.ToDouble(dtgHerramienta.Rows[fila].Cells[2].Value.ToString());
            herramientas.Marca = dtgHerramienta.Rows[fila].Cells[3].Value.ToString();
            herramientas.Descripcion = dtgHerramienta.Rows[fila].Cells[4].Value.ToString();
            switch (col)
            {
                case 5:
                    {
                        Opc = int.Parse(dtgHerramienta.Rows[fila].Cells[0].Value.ToString());
                        herramientas.CodigoHerramienta = 1;
                        FrmAddHerramientas addh = new FrmAddHerramientas();
                        addh.ShowDialog();
                        txtBuscar.Text = "-1";
                        txtBuscar.Clear();
                        Actualizar();
                    }
                    break;
                case 6:
                    {
                        mh.Borrar(herramientas);
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
            mh.Mostrar(dtgHerramienta, txtBuscar.Text);
            Condicionantes();
        }

        public void Condicionantes()
        {
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Taller) == "Lectura")
            {
                
                btnAgregar.Visible = false;
                dtgHerramienta.Columns[5].Visible = false;
                dtgHerramienta.Columns[4].Visible = false;
                
            }
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Taller) == "Escritura")
            {
                btnAgregar.Visible = true;
                dtgHerramienta.Columns[4].Visible = false;
                dtgHerramienta.Columns[5].Visible = false;
            }
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Taller) == "Eliminacion" || mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Taller) == "LecturaEliminacion")
            {
                btnAgregar.Visible = false;
                dtgHerramienta.Columns[4].Visible = false;
                dtgHerramienta.Columns[5].Visible = true;
            }
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Taller) == "Modificacion")
            {
                btnAgregar.Visible = false;
                dtgHerramienta.Columns[4].Visible = true;
                dtgHerramienta.Columns[5].Visible = false;
            }
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Taller) == "LecturaEscritura")
            {
                btnAgregar.Visible = true;
                dtgHerramienta.Columns[4].Visible = false;
                dtgHerramienta.Columns[5].Visible = false;
            }
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Taller) == "LecturaEscrituraEliminacion" || mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Taller) == "EscrituraEliminacion")
            {
                btnAgregar.Visible = true;
                dtgHerramienta.Columns[4].Visible = false;
                dtgHerramienta.Columns[5].Visible = true;
            }
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Taller) == "EscrituraModificacion")
            {
                btnAgregar.Visible = true;
                dtgHerramienta.Columns[4].Visible = true;
                dtgHerramienta.Columns[5].Visible = false;
            }
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Taller) == "EliminacionModificacion")
            {
                btnAgregar.Visible = false;
                dtgHerramienta.Columns[4].Visible = true;
                dtgHerramienta.Columns[5].Visible = true;
            }
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Taller) == "EscrituraEliminacionModificacion" || mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Taller) == "LecturaModificacion")
            {
                btnAgregar.Visible = true;
                dtgHerramienta.Columns[4].Visible = true;
                dtgHerramienta.Columns[5].Visible = true;
            }
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.Taller) == "LecturaEliminacionModificacion")
            {
                btnAgregar.Visible = false;
                dtgHerramienta.Columns[4].Visible = true;
                dtgHerramienta.Columns[5].Visible = true;
            }
        }

    }
}
