namespace GeneradorClases
{
    partial class frmGeneradorCodigos
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
            this.lblNombreConeccion = new System.Windows.Forms.Label();
            this.cmbConecciones = new System.Windows.Forms.ComboBox();
            this.lblTablas = new System.Windows.Forms.Label();
            this.cmbTabla = new System.Windows.Forms.ComboBox();
            this.dtColumnas = new System.Windows.Forms.DataGridView();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.listOpciones = new System.Windows.Forms.CheckedListBox();
            this.btnConfiguracionListar = new System.Windows.Forms.Button();
            this.lblDireccionDatos = new System.Windows.Forms.Label();
            this.txtDirectorioDestino = new System.Windows.Forms.TextBox();
            this.btnCambiarDirectorio = new System.Windows.Forms.Button();
            this.fDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreProyeco = new System.Windows.Forms.TextBox();
            this.lblTecnologia = new System.Windows.Forms.Label();
            this.Column4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreEntidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtColumnas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreConeccion
            // 
            this.lblNombreConeccion.AutoSize = true;
            this.lblNombreConeccion.Location = new System.Drawing.Point(12, 12);
            this.lblNombreConeccion.Name = "lblNombreConeccion";
            this.lblNombreConeccion.Size = new System.Drawing.Size(128, 13);
            this.lblNombreConeccion.TabIndex = 0;
            this.lblNombreConeccion.Text = "Seleccione la Conección:";
            // 
            // cmbConecciones
            // 
            this.cmbConecciones.FormattingEnabled = true;
            this.cmbConecciones.Location = new System.Drawing.Point(156, 9);
            this.cmbConecciones.Name = "cmbConecciones";
            this.cmbConecciones.Size = new System.Drawing.Size(529, 21);
            this.cmbConecciones.TabIndex = 1;
            this.cmbConecciones.SelectedIndexChanged += new System.EventHandler(this.cmbConecciones_SelectedIndexChanged);
            // 
            // lblTablas
            // 
            this.lblTablas.AutoSize = true;
            this.lblTablas.Location = new System.Drawing.Point(12, 45);
            this.lblTablas.Name = "lblTablas";
            this.lblTablas.Size = new System.Drawing.Size(100, 13);
            this.lblTablas.TabIndex = 2;
            this.lblTablas.Text = "Seleccione la tabla:";
            // 
            // cmbTabla
            // 
            this.cmbTabla.FormattingEnabled = true;
            this.cmbTabla.Location = new System.Drawing.Point(156, 42);
            this.cmbTabla.Name = "cmbTabla";
            this.cmbTabla.Size = new System.Drawing.Size(529, 21);
            this.cmbTabla.TabIndex = 3;
            this.cmbTabla.SelectedIndexChanged += new System.EventHandler(this.cmbTabla_SelectedIndexChanged);
            // 
            // dtColumnas
            // 
            this.dtColumnas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtColumnas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtColumnas.Location = new System.Drawing.Point(12, 163);
            this.dtColumnas.Name = "dtColumnas";
            this.dtColumnas.Size = new System.Drawing.Size(492, 271);
            this.dtColumnas.TabIndex = 4;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(510, 411);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(172, 23);
            this.btnGenerar.TabIndex = 6;
            this.btnGenerar.Text = "Generar Documentos";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // listOpciones
            // 
            this.listOpciones.FormattingEnabled = true;
            this.listOpciones.Items.AddRange(new object[] {
            "ascx",
            "listar"});
            this.listOpciones.Location = new System.Drawing.Point(510, 163);
            this.listOpciones.Name = "listOpciones";
            this.listOpciones.Size = new System.Drawing.Size(172, 214);
            this.listOpciones.TabIndex = 7;
            this.listOpciones.SelectedIndexChanged += new System.EventHandler(this.listOpciones_SelectedIndexChanged);
            // 
            // btnConfiguracionListar
            // 
            this.btnConfiguracionListar.Location = new System.Drawing.Point(510, 383);
            this.btnConfiguracionListar.Name = "btnConfiguracionListar";
            this.btnConfiguracionListar.Size = new System.Drawing.Size(172, 23);
            this.btnConfiguracionListar.TabIndex = 8;
            this.btnConfiguracionListar.Text = "Configuración Listar";
            this.btnConfiguracionListar.UseVisualStyleBackColor = true;
            // 
            // lblDireccionDatos
            // 
            this.lblDireccionDatos.AutoSize = true;
            this.lblDireccionDatos.Location = new System.Drawing.Point(12, 70);
            this.lblDireccionDatos.Name = "lblDireccionDatos";
            this.lblDireccionDatos.Size = new System.Drawing.Size(105, 13);
            this.lblDireccionDatos.TabIndex = 9;
            this.lblDireccionDatos.Text = "Directorio a Guardar:";
            this.lblDireccionDatos.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDirectorioDestino
            // 
            this.txtDirectorioDestino.Location = new System.Drawing.Point(156, 69);
            this.txtDirectorioDestino.Name = "txtDirectorioDestino";
            this.txtDirectorioDestino.Size = new System.Drawing.Size(407, 20);
            this.txtDirectorioDestino.TabIndex = 10;
            this.txtDirectorioDestino.Text = "C:\\GeneradorClases";
            // 
            // btnCambiarDirectorio
            // 
            this.btnCambiarDirectorio.Location = new System.Drawing.Point(569, 68);
            this.btnCambiarDirectorio.Name = "btnCambiarDirectorio";
            this.btnCambiarDirectorio.Size = new System.Drawing.Size(116, 23);
            this.btnCambiarDirectorio.TabIndex = 11;
            this.btnCambiarDirectorio.Text = "Cambiar Directorio";
            this.btnCambiarDirectorio.UseVisualStyleBackColor = true;
            this.btnCambiarDirectorio.Click += new System.EventHandler(this.btnCambiarDirectorio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre Proyecto";
            // 
            // txtNombreProyeco
            // 
            this.txtNombreProyeco.Location = new System.Drawing.Point(156, 98);
            this.txtNombreProyeco.Name = "txtNombreProyeco";
            this.txtNombreProyeco.Size = new System.Drawing.Size(523, 20);
            this.txtNombreProyeco.TabIndex = 13;
            // 
            // lblTecnologia
            // 
            this.lblTecnologia.AutoSize = true;
            this.lblTecnologia.Location = new System.Drawing.Point(12, 127);
            this.lblTecnologia.Name = "lblTecnologia";
            this.lblTecnologia.Size = new System.Drawing.Size(73, 13);
            this.lblTecnologia.TabIndex = 14;
            this.lblTecnologia.Text = "Nombre Entity";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tipo Control";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "esNulable";
            this.Column3.HeaderText = "Es Nulable";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tipoDatoColumna";
            this.Column2.HeaderText = "Tipo Dato Columna";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "nombreColumna";
            this.Column1.HeaderText = "Nombre Columna";
            this.Column1.Name = "Column1";
            // 
            // txtNombreEntidad
            // 
            this.txtNombreEntidad.Location = new System.Drawing.Point(156, 124);
            this.txtNombreEntidad.Name = "txtNombreEntidad";
            this.txtNombreEntidad.Size = new System.Drawing.Size(523, 20);
            this.txtNombreEntidad.TabIndex = 15;
            // 
            // frmGeneradorCodigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 443);
            this.Controls.Add(this.txtNombreEntidad);
            this.Controls.Add(this.lblTecnologia);
            this.Controls.Add(this.txtNombreProyeco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCambiarDirectorio);
            this.Controls.Add(this.txtDirectorioDestino);
            this.Controls.Add(this.lblDireccionDatos);
            this.Controls.Add(this.btnConfiguracionListar);
            this.Controls.Add(this.listOpciones);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dtColumnas);
            this.Controls.Add(this.cmbTabla);
            this.Controls.Add(this.lblTablas);
            this.Controls.Add(this.cmbConecciones);
            this.Controls.Add(this.lblNombreConeccion);
            this.Name = "frmGeneradorCodigos";
            this.Text = "Generador de Patrones";
            ((System.ComponentModel.ISupportInitialize)(this.dtColumnas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreConeccion;
        private System.Windows.Forms.ComboBox cmbConecciones;
        private System.Windows.Forms.Label lblTablas;
        private System.Windows.Forms.ComboBox cmbTabla;
        private System.Windows.Forms.DataGridView dtColumnas;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.CheckedListBox listOpciones;
        private System.Windows.Forms.Button btnConfiguracionListar;
        private System.Windows.Forms.Label lblDireccionDatos;
        private System.Windows.Forms.TextBox txtDirectorioDestino;
        private System.Windows.Forms.Button btnCambiarDirectorio;
        private System.Windows.Forms.FolderBrowserDialog fDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreProyeco;
        private System.Windows.Forms.Label lblTecnologia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column4;
        private System.Windows.Forms.TextBox txtNombreEntidad;
    }
}