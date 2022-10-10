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
    public partial class FrmAddHerramientas : Form
    {
        ManejadorHerramienta mh;
        public FrmAddHerramientas()
        {
            InitializeComponent();
            mh = new ManejadorHerramienta();
            if (FrmHerramientas.herramientas.CodigoHerramienta > 0)
            {
                txtNombre.Text = FrmHerramientas.herramientas.Nombre;
                txtMedida.Text = FrmHerramientas.herramientas.Medida.ToString();
                txtMarca.Text = FrmHerramientas.herramientas.Marca;
                txtDescripcion.Text = FrmHerramientas.herramientas.Descripcion;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmHerramientas.herramientas.CodigoHerramienta != -1)
            {
                mh.Guardar(new Herramientas(FrmHerramientas.Opc, txtNombre.Text, Convert.ToDouble(txtMedida.Text), txtMarca.Text, txtDescripcion.Text));
                Close();
            }
            else if(FrmHerramientas.herramientas.CodigoHerramienta == -1)
            {
                mh.Guardar(new Herramientas(FrmHerramientas.herramientas.CodigoHerramienta, txtNombre.Text, Convert.ToDouble(txtMedida.Text), txtMarca.Text, txtDescripcion.Text));
                Close();
            }
            
        }
    }
}
