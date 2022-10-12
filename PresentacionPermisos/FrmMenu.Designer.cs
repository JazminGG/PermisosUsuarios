
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgregarUsuarios = new System.Windows.Forms.ToolStripButton();
            this.btnAsignarPermisos = new System.Windows.Forms.ToolStripButton();
            this.btnAgregarHerramientas = new System.Windows.Forms.ToolStripButton();
            this.btnAgregarProductos = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
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
            this.toolStrip1.Size = new System.Drawing.Size(626, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAgregarUsuarios
            // 
            this.btnAgregarUsuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgregarUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarUsuarios.Image")));
            this.btnAgregarUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregarUsuarios.Name = "btnAgregarUsuarios";
            this.btnAgregarUsuarios.Size = new System.Drawing.Size(23, 22);
            this.btnAgregarUsuarios.Text = "USUARIOS";
            this.btnAgregarUsuarios.Click += new System.EventHandler(this.btnAgregarUsuarios_Click);
            // 
            // btnAsignarPermisos
            // 
            this.btnAsignarPermisos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAsignarPermisos.Image = ((System.Drawing.Image)(resources.GetObject("btnAsignarPermisos.Image")));
            this.btnAsignarPermisos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAsignarPermisos.Name = "btnAsignarPermisos";
            this.btnAsignarPermisos.Size = new System.Drawing.Size(23, 22);
            this.btnAsignarPermisos.Text = "PERMISOS";
            this.btnAsignarPermisos.Click += new System.EventHandler(this.btnAsignarPermisos_Click);
            // 
            // btnAgregarHerramientas
            // 
            this.btnAgregarHerramientas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgregarHerramientas.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarHerramientas.Image")));
            this.btnAgregarHerramientas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregarHerramientas.Name = "btnAgregarHerramientas";
            this.btnAgregarHerramientas.Size = new System.Drawing.Size(23, 22);
            this.btnAgregarHerramientas.Text = "HERRAMIENTAS";
            this.btnAgregarHerramientas.Click += new System.EventHandler(this.btnAgregarHerramientas_Click);
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgregarProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProductos.Image")));
            this.btnAgregarProductos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(23, 22);
            this.btnAgregarProductos.Text = "PRODUCTOS";
            this.btnAgregarProductos.Click += new System.EventHandler(this.btnAgregarProductos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(23, 22);
            this.btnSalir.Text = "SALIR";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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