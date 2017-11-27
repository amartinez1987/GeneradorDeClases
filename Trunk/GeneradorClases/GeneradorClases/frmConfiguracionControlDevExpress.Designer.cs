namespace GeneradorClases
{
    partial class frmConfiguracionControlDevExpress
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
            this.lblTabla = new System.Windows.Forms.Label();
            this.cmbTabla = new System.Windows.Forms.ComboBox();
            this.lblValueField = new System.Windows.Forms.Label();
            this.cmbValorCampo = new System.Windows.Forms.ComboBox();
            this.cmbTextoCampo = new System.Windows.Forms.ComboBox();
            this.lblTextoCampo = new System.Windows.Forms.Label();
            this.lblFormatoFecha = new System.Windows.Forms.Label();
            this.txtFormatoFecha = new System.Windows.Forms.TextBox();
            this.chSinSpinButton = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Location = new System.Drawing.Point(12, 9);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(34, 13);
            this.lblTabla.TabIndex = 0;
            this.lblTabla.Text = "Tabla";
            // 
            // cmbTabla
            // 
            this.cmbTabla.FormattingEnabled = true;
            this.cmbTabla.Location = new System.Drawing.Point(101, 6);
            this.cmbTabla.Name = "cmbTabla";
            this.cmbTabla.Size = new System.Drawing.Size(274, 21);
            this.cmbTabla.TabIndex = 1;
            this.cmbTabla.SelectedIndexChanged += new System.EventHandler(this.cmbTabla_SelectedIndexChanged);
            // 
            // lblValueField
            // 
            this.lblValueField.AutoSize = true;
            this.lblValueField.Location = new System.Drawing.Point(12, 37);
            this.lblValueField.Name = "lblValueField";
            this.lblValueField.Size = new System.Drawing.Size(67, 13);
            this.lblValueField.TabIndex = 2;
            this.lblValueField.Text = "Valor Campo";
            // 
            // cmbValorCampo
            // 
            this.cmbValorCampo.FormattingEnabled = true;
            this.cmbValorCampo.Location = new System.Drawing.Point(101, 34);
            this.cmbValorCampo.Name = "cmbValorCampo";
            this.cmbValorCampo.Size = new System.Drawing.Size(274, 21);
            this.cmbValorCampo.TabIndex = 3;
            // 
            // cmbTextoCampo
            // 
            this.cmbTextoCampo.FormattingEnabled = true;
            this.cmbTextoCampo.Location = new System.Drawing.Point(101, 61);
            this.cmbTextoCampo.Name = "cmbTextoCampo";
            this.cmbTextoCampo.Size = new System.Drawing.Size(274, 21);
            this.cmbTextoCampo.TabIndex = 5;
            // 
            // lblTextoCampo
            // 
            this.lblTextoCampo.AutoSize = true;
            this.lblTextoCampo.Location = new System.Drawing.Point(12, 64);
            this.lblTextoCampo.Name = "lblTextoCampo";
            this.lblTextoCampo.Size = new System.Drawing.Size(61, 13);
            this.lblTextoCampo.TabIndex = 4;
            this.lblTextoCampo.Text = "Valor Texto";
            // 
            // lblFormatoFecha
            // 
            this.lblFormatoFecha.AutoSize = true;
            this.lblFormatoFecha.Location = new System.Drawing.Point(12, 91);
            this.lblFormatoFecha.Name = "lblFormatoFecha";
            this.lblFormatoFecha.Size = new System.Drawing.Size(78, 13);
            this.lblFormatoFecha.TabIndex = 6;
            this.lblFormatoFecha.Text = "Formato Fecha";
            // 
            // txtFormatoFecha
            // 
            this.txtFormatoFecha.Location = new System.Drawing.Point(101, 88);
            this.txtFormatoFecha.Name = "txtFormatoFecha";
            this.txtFormatoFecha.Size = new System.Drawing.Size(274, 20);
            this.txtFormatoFecha.TabIndex = 7;
            // 
            // chSinSpinButton
            // 
            this.chSinSpinButton.AutoSize = true;
            this.chSinSpinButton.Location = new System.Drawing.Point(15, 121);
            this.chSinSpinButton.Name = "chSinSpinButton";
            this.chSinSpinButton.Size = new System.Drawing.Size(99, 17);
            this.chSinSpinButton.TabIndex = 8;
            this.chSinSpinButton.Text = "Sin Spin Button";
            this.chSinSpinButton.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(15, 144);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmConfiguracionControlDevExpress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 179);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.chSinSpinButton);
            this.Controls.Add(this.txtFormatoFecha);
            this.Controls.Add(this.lblFormatoFecha);
            this.Controls.Add(this.cmbTextoCampo);
            this.Controls.Add(this.lblTextoCampo);
            this.Controls.Add(this.cmbValorCampo);
            this.Controls.Add(this.lblValueField);
            this.Controls.Add(this.cmbTabla);
            this.Controls.Add(this.lblTabla);
            this.Name = "frmConfiguracionControlDevExpress";
            this.Text = "Configuracion Controles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTabla;
        private System.Windows.Forms.ComboBox cmbTabla;
        private System.Windows.Forms.Label lblValueField;
        private System.Windows.Forms.ComboBox cmbValorCampo;
        private System.Windows.Forms.ComboBox cmbTextoCampo;
        private System.Windows.Forms.Label lblTextoCampo;
        private System.Windows.Forms.Label lblFormatoFecha;
        private System.Windows.Forms.TextBox txtFormatoFecha;
        private System.Windows.Forms.CheckBox chSinSpinButton;
        private System.Windows.Forms.Button btnGuardar;
    }
}