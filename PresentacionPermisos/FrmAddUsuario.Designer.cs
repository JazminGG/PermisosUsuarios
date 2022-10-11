
namespace PresentacionPermisos
{
    partial class FrmAddUsuario
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtApellidom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 18);
            this.label6.TabIndex = 59;
            this.label6.Text = "Fecha de nacimiento";
            // 
            // txtApellidom
            // 
            this.txtApellidom.Location = new System.Drawing.Point(222, 136);
            this.txtApellidom.Name = "txtApellidom";
            this.txtApellidom.Size = new System.Drawing.Size(212, 26);
            this.txtApellidom.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 18);
            this.label5.TabIndex = 56;
            this.label5.Text = "Apellido materno";
            // 
            // txtApellidop
            // 
            this.txtApellidop.Location = new System.Drawing.Point(12, 136);
            this.txtApellidop.Name = "txtApellidop";
            this.txtApellidop.Size = new System.Drawing.Size(204, 26);
            this.txtApellidop.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 18);
            this.label4.TabIndex = 55;
            this.label4.Text = "Apellido paterno";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 86);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(422, 26);
            this.txtNombre.TabIndex = 53;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(461, 130);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(82, 36);
            this.btnGuardar.TabIndex = 50;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 52;
            this.label3.Text = "Nombre";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 51);
            this.panel1.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Agregar Usuario";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(521, 3);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(44, 44);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.Text = "X";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.CustomFormat = "yyyy-MM-dd";
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNacimiento.Location = new System.Drawing.Point(12, 186);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(166, 26);
            this.dtpNacimiento.TabIndex = 60;
            this.dtpNacimiento.Value = new System.DateTime(2022, 4, 7, 0, 0, 0, 0);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(178, 238);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(256, 26);
            this.txtContrasena.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 18);
            this.label7.TabIndex = 64;
            this.label7.Text = "Contraseña:";
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(13, 238);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(159, 26);
            this.txtRFC.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 63;
            this.label1.Text = "RFC:";
            // 
            // FrmAddUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 270);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtApellidom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtApellidop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAddUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddUsuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtApellidom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellidop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Label label1;
    }
}