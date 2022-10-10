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
        public static Herramientas herramientas = new Herramientas(0, "", 0.0, "", "");
        int fila = 0, col = 0;
        public static int Opc;
        public FrmHerramientas()
        {
            InitializeComponent();
            mh = new ManejadorHerramienta();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmHerramientas_Load(object sender, EventArgs e)
        {
            Actualizar();
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
        }

        
    }
}
