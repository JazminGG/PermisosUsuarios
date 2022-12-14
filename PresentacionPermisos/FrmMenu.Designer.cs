
namespace PresentacionPermisos
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.btnAgregarUsuarios = new System.Windows.Forms.ToolStripButton();
            this.btnAsignarPermisos = new System.Windows.Forms.ToolStripButton();
            this.btnAgregarHerramientas = new System.Windows.Forms.ToolStripButton();
            this.btnAgregarProductos = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregarUsuarios,
            this.btnAsignarPermisos,
            this.btnAgregarHerramientas,
            this.btnAgregarProductos,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(626, 63);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = false;
            this.btnSalir.BackgroundImage = global::PresentacionPermisos.Properties.Resources.Cerrar;
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(60, 60);
            this.btnSalir.Text = "SALIR";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregarUsuarios
            // 
            this.btnAgregarUsuarios.AutoSize = false;
            this.btnAgregarUsuarios.BackgroundImage = global::PresentacionPermisos.Properties.Resources.Usuario__2_;
            this.btnAgregarUsuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgregarUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregarUsuarios.Name = "btnAgregarUsuarios";
            this.btnAgregarUsuarios.Size = new System.Drawing.Size(60, 60);
            this.btnAgregarUsuarios.Text = "USUARIOS";
            this.btnAgregarUsuarios.Click += new System.EventHandler(this.btnAgregarUsuarios_Click);
            // 
            // btnAsignarPermisos
            // 
            this.btnAsignarPermisos.AutoSize = false;
            this.btnAsignarPermisos.BackgroundImage = global::PresentacionPermisos.Properties.Resources.Permisos;
            this.btnAsignarPermisos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAsignarPermisos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAsignarPermisos.Name = "btnAsignarPermisos";
            this.btnAsignarPermisos.Size = new System.Drawing.Size(60, 60);
            this.btnAsignarPermisos.Text = "PERMISOS";
            this.btnAsignarPermisos.Click += new System.EventHandler(this.btnAsignarPermisos_Click);
            // 
            // btnAgregarHerramientas
            // 
            this.btnAgregarHerramientas.AutoSize = false;
            this.btnAgregarHerramientas.BackgroundImage = global::PresentacionPermisos.Properties.Resources.Herramientas;
            this.btnAgregarHerramientas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgregarHerramientas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregarHerramientas.Name = "btnAgregarHerramientas";
            this.btnAgregarHerramientas.Size = new System.Drawing.Size(60, 60);
            this.btnAgregarHerramientas.Text = "HERRAMIENTAS";
            this.btnAgregarHerramientas.Click += new System.EventHandler(this.btnAgregarHerramientas_Click);
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.AutoSize = false;
            this.btnAgregarProductos.BackgroundImage = global::PresentacionPermisos.Properties.Resources.Productos;
            this.btnAgregarProductos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgregarProductos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(60, 60);
            this.btnAgregarProductos.Text = "PRODUCTOS";
            this.btnAgregarProductos.Click += new System.EventHandler(this.btnAgregarProductos_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(626, 343);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAgregarUsuarios;
        private System.Windows.Forms.ToolStripButton btnAsignarPermisos;
        private System.Windows.Forms.ToolStripButton btnAgregarHerramientas;
        private System.Windows.Forms.ToolStripButton btnAgregarProductos;
        private System.Windows.Forms.ToolStripButton btnSalir;
    }
}