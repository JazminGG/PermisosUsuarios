
namespace PresentacionPermisos
{
    partial class FrmAddHerramientas
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
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMedida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(240, 142);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(197, 26);
            this.txtMarca.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 36;
            this.label5.Text = "Marca";
            // 
            // txtMedida
            // 
            this.txtMedida.Location = new System.Drawing.Point(15, 142);
            this.txtMedida.Name = "txtMedida";
            this.txtMedida.Size = new System.Drawing.Size(219, 26);
            this.txtMedida.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 35;
            this.label4.Text = "Medida";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(15, 92);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(422, 26);
            this.txtNombre.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nombre de la herramienta";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 51);
            this.panel1.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Agregar Herramienta";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(15, 192);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(422, 66);
            this.txtDescripcion.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "Descripción";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::PresentacionPermisos.Properties.Resources.Save;
            this.btnGuardar.Location = new System.Drawing.Point(464, 136);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(60, 60);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRegresar.BackgroundImage = global::PresentacionPermisos.Properties.Resources.Cancel;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(521, 3);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(40, 40);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FrmAddHerramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 270);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMedida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAddHerramientas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddHerramientas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMedida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label6;
    }
}