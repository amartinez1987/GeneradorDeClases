namespace GeneradorClases
{
    partial class administracionConeccion
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombreConeccion = new System.Windows.Forms.Label();
            this.lblServidor = new System.Windows.Forms.Label();
            this.txtNombreConeccion = new System.Windows.Forms.TextBox();
            this.txtNombreServidor = new System.Windows.Forms.TextBox();
            this.lblBaseDatos = new System.Windows.Forms.Label();
            this.cmbBaseDatos = new System.Windows.Forms.ComboBox();
            this.lblUsuarioConeccion = new System.Windows.Forms.Label();
            this.txtUsuarioConeccion = new System.Windows.Forms.TextBox();
            this.lblContrasenaConeccion = new System.Windows.Forms.Label();
            this.txtContrasenaConeccion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNombreConeccion
            // 
            this.lblNombreConeccion.AutoSize = true;
            this.lblNombreConeccion.Location = new System.Drawing.Point(3, 6);
            this.lblNombreConeccion.Name = "lblNombreConeccion";
            this.lblNombreConeccion.Size = new System.Drawing.Size(124, 13);
            this.lblNombreConeccion.TabIndex = 0;
            this.lblNombreConeccion.Text = "Nombre de la Conección";
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(3, 33);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(103, 13);
            this.lblServidor.TabIndex = 2;
            this.lblServidor.Text = "Nombre del Servidor";
            // 
            // txtNombreConeccion
            // 
            this.txtNombreConeccion.Location = new System.Drawing.Point(195, 6);
            this.txtNombreConeccion.Name = "txtNombreConeccion";
            this.txtNombreConeccion.Size = new System.Drawing.Size(306, 20);
            this.txtNombreConeccion.TabIndex = 1;
            // 
            // txtNombreServidor
            // 
            this.txtNombreServidor.Location = new System.Drawing.Point(195, 33);
            this.txtNombreServidor.Name = "txtNombreServidor";
            this.txtNombreServidor.Size = new System.Drawing.Size(306, 20);
            this.txtNombreServidor.TabIndex = 3;
            // 
            // lblBaseDatos
            // 
            this.lblBaseDatos.AutoSize = true;
            this.lblBaseDatos.Location = new System.Drawing.Point(3, 62);
            this.lblBaseDatos.Name = "lblBaseDatos";
            this.lblBaseDatos.Size = new System.Drawing.Size(77, 13);
            this.lblBaseDatos.TabIndex = 4;
            this.lblBaseDatos.Text = "Base de Datos";
            // 
            // cmbBaseDatos
            // 
            this.cmbBaseDatos.FormattingEnabled = true;
            this.cmbBaseDatos.Location = new System.Drawing.Point(195, 62);
            this.cmbBaseDatos.Name = "cmbBaseDatos";
            this.cmbBaseDatos.Size = new System.Drawing.Size(306, 21);
            this.cmbBaseDatos.TabIndex = 5;
            // 
            // lblUsuarioConeccion
            // 
            this.lblUsuarioConeccion.AutoSize = true;
            this.lblUsuarioConeccion.Location = new System.Drawing.Point(3, 90);
            this.lblUsuarioConeccion.Name = "lblUsuarioConeccion";
            this.lblUsuarioConeccion.Size = new System.Drawing.Size(112, 13);
            this.lblUsuarioConeccion.TabIndex = 6;
            this.lblUsuarioConeccion.Text = "Usuario de Conección";
            // 
            // txtUsuarioConeccion
            // 
            this.txtUsuarioConeccion.Location = new System.Drawing.Point(195, 89);
            this.txtUsuarioConeccion.Name = "txtUsuarioConeccion";
            this.txtUsuarioConeccion.Size = new System.Drawing.Size(306, 20);
            this.txtUsuarioConeccion.TabIndex = 7;
            // 
            // lblContrasenaConeccion
            // 
            this.lblContrasenaConeccion.AutoSize = true;
            this.lblContrasenaConeccion.Location = new System.Drawing.Point(3, 116);
            this.lblContrasenaConeccion.Name = "lblContrasenaConeccion";
            this.lblContrasenaConeccion.Size = new System.Drawing.Size(186, 13);
            this.lblContrasenaConeccion.TabIndex = 8;
            this.lblContrasenaConeccion.Text = "Contraseña del Usuario de Conección";
            // 
            // txtContrasenaConeccion
            // 
            this.txtContrasenaConeccion.Location = new System.Drawing.Point(195, 116);
            this.txtContrasenaConeccion.Name = "txtContrasenaConeccion";
            this.txtContrasenaConeccion.PasswordChar = '*';
            this.txtContrasenaConeccion.Size = new System.Drawing.Size(306, 20);
            this.txtContrasenaConeccion.TabIndex = 9;
            this.txtContrasenaConeccion.UseSystemPasswordChar = true;
            // 
            // administracionConeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtContrasenaConeccion);
            this.Controls.Add(this.lblContrasenaConeccion);
            this.Controls.Add(this.txtUsuarioConeccion);
            this.Controls.Add(this.lblUsuarioConeccion);
            this.Controls.Add(this.cmbBaseDatos);
            this.Controls.Add(this.lblBaseDatos);
            this.Controls.Add(this.txtNombreServidor);
            this.Controls.Add(this.lblServidor);
            this.Controls.Add(this.txtNombreConeccion);
            this.Controls.Add(this.lblNombreConeccion);
            this.Name = "administracionConeccion";
            this.Size = new System.Drawing.Size(508, 144);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreConeccion;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.TextBox txtNombreConeccion;
        private System.Windows.Forms.TextBox txtNombreServidor;
        private System.Windows.Forms.Label lblBaseDatos;
        private System.Windows.Forms.ComboBox cmbBaseDatos;
        private System.Windows.Forms.Label lblUsuarioConeccion;
        private System.Windows.Forms.TextBox txtUsuarioConeccion;
        private System.Windows.Forms.Label lblContrasenaConeccion;
        private System.Windows.Forms.TextBox txtContrasenaConeccion;
    }
}
