namespace GeneradorClases
{
    partial class frmGeneradorForms
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
            this.lblTecnologia = new System.Windows.Forms.Label();
            this.txtNombreProyeco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCambiarDirectorio = new System.Windows.Forms.Button();
            this.txtDirectorioDestino = new System.Windows.Forms.TextBox();
            this.lblDireccionDatos = new System.Windows.Forms.Label();
            this.btnConfigurarListado = new System.Windows.Forms.Button();
            this.listOpciones = new System.Windows.Forms.CheckedListBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dtColumnas = new System.Windows.Forms.DataGridView();
            this.cmbTabla = new System.Windows.Forms.ComboBox();
            this.lblTablas = new System.Windows.Forms.Label();
            this.cmbConecciones = new System.Windows.Forms.ComboBox();
            this.lblNombreConeccion = new System.Windows.Forms.Label();
            this.fDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.cmbTecnologia = new System.Windows.Forms.ComboBox();
            this.nombreColumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDatoColumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esNulable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbTipoControl = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtColumnas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTecnologia
            // 
            this.lblTecnologia.AutoSize = true;
            this.lblTecnologia.Location = new System.Drawing.Point(8, 125);
            this.lblTecnologia.Name = "lblTecnologia";
            this.lblTecnologia.Size = new System.Drawing.Size(54, 13);
            this.lblTecnologia.TabIndex = 30;
            this.lblTecnologia.Text = "Tenologia";
            // 
            // txtNombreProyeco
            // 
            this.txtNombreProyeco.Location = new System.Drawing.Point(152, 96);
            this.txtNombreProyeco.Name = "txtNombreProyeco";
            this.txtNombreProyeco.Size = new System.Drawing.Size(523, 20);
            this.txtNombreProyeco.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nombre Proyecto";
            // 
            // btnCambiarDirectorio
            // 
            this.btnCambiarDirectorio.Location = new System.Drawing.Point(565, 66);
            this.btnCambiarDirectorio.Name = "btnCambiarDirectorio";
            this.btnCambiarDirectorio.Size = new System.Drawing.Size(116, 23);
            this.btnCambiarDirectorio.TabIndex = 27;
            this.btnCambiarDirectorio.Text = "Cambiar Directorio";
            this.btnCambiarDirectorio.UseVisualStyleBackColor = true;
            // 
            // txtDirectorioDestino
            // 
            this.txtDirectorioDestino.Location = new System.Drawing.Point(152, 67);
            this.txtDirectorioDestino.Name = "txtDirectorioDestino";
            this.txtDirectorioDestino.Size = new System.Drawing.Size(407, 20);
            this.txtDirectorioDestino.TabIndex = 26;
            this.txtDirectorioDestino.Text = "C:\\GeneradorClases";
            // 
            // lblDireccionDatos
            // 
            this.lblDireccionDatos.AutoSize = true;
            this.lblDireccionDatos.Location = new System.Drawing.Point(8, 68);
            this.lblDireccionDatos.Name = "lblDireccionDatos";
            this.lblDireccionDatos.Size = new System.Drawing.Size(105, 13);
            this.lblDireccionDatos.TabIndex = 25;
            this.lblDireccionDatos.Text = "Directorio a Guardar:";
            // 
            // btnConfigurarListado
            // 
            this.btnConfigurarListado.Location = new System.Drawing.Point(506, 381);
            this.btnConfigurarListado.Name = "btnConfigurarListado";
            this.btnConfigurarListado.Size = new System.Drawing.Size(172, 23);
            this.btnConfigurarListado.TabIndex = 24;
            this.btnConfigurarListado.Text = "Configurar Listar";
            this.btnConfigurarListado.UseVisualStyleBackColor = true;
            // 
            // listOpciones
            // 
            this.listOpciones.FormattingEnabled = true;
            this.listOpciones.Items.AddRange(new object[] {
            "Formulario",
            "Listar"});
            this.listOpciones.Location = new System.Drawing.Point(506, 161);
            this.listOpciones.Name = "listOpciones";
            this.listOpciones.Size = new System.Drawing.Size(172, 214);
            this.listOpciones.TabIndex = 23;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(506, 409);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(172, 23);
            this.btnGenerar.TabIndex = 22;
            this.btnGenerar.Text = "Generar Documentos";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click_1);
            // 
            // dtColumnas
            // 
            this.dtColumnas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtColumnas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreColumna,
            this.tipoDatoColumna,
            this.esNulable,
            this.cmbTipoControl,
            this.btnEditar});
            this.dtColumnas.Location = new System.Drawing.Point(8, 161);
            this.dtColumnas.Name = "dtColumnas";
            this.dtColumnas.Size = new System.Drawing.Size(492, 271);
            this.dtColumnas.TabIndex = 21;
            this.dtColumnas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtColumnas_CellClick);
            // 
            // cmbTabla
            // 
            this.cmbTabla.FormattingEnabled = true;
            this.cmbTabla.Location = new System.Drawing.Point(152, 40);
            this.cmbTabla.Name = "cmbTabla";
            this.cmbTabla.Size = new System.Drawing.Size(529, 21);
            this.cmbTabla.TabIndex = 20;
            this.cmbTabla.SelectedIndexChanged += new System.EventHandler(this.cmbTabla_SelectedIndexChanged);
            // 
            // lblTablas
            // 
            this.lblTablas.AutoSize = true;
            this.lblTablas.Location = new System.Drawing.Point(8, 43);
            this.lblTablas.Name = "lblTablas";
            this.lblTablas.Size = new System.Drawing.Size(100, 13);
            this.lblTablas.TabIndex = 19;
            this.lblTablas.Text = "Seleccione la tabla:";
            // 
            // cmbConecciones
            // 
            this.cmbConecciones.FormattingEnabled = true;
            this.cmbConecciones.Location = new System.Drawing.Point(152, 7);
            this.cmbConecciones.Name = "cmbConecciones";
            this.cmbConecciones.Size = new System.Drawing.Size(529, 21);
            this.cmbConecciones.TabIndex = 18;
            this.cmbConecciones.SelectedIndexChanged += new System.EventHandler(this.cmbConecciones_SelectedIndexChanged);
            // 
            // lblNombreConeccion
            // 
            this.lblNombreConeccion.AutoSize = true;
            this.lblNombreConeccion.Location = new System.Drawing.Point(8, 10);
            this.lblNombreConeccion.Name = "lblNombreConeccion";
            this.lblNombreConeccion.Size = new System.Drawing.Size(128, 13);
            this.lblNombreConeccion.TabIndex = 17;
            this.lblNombreConeccion.Text = "Seleccione la Conección:";
            // 
            // cmbTecnologia
            // 
            this.cmbTecnologia.FormattingEnabled = true;
            this.cmbTecnologia.Items.AddRange(new object[] {
            ".net + DevExpress",
            ".net + HTML5"});
            this.cmbTecnologia.Location = new System.Drawing.Point(152, 122);
            this.cmbTecnologia.Name = "cmbTecnologia";
            this.cmbTecnologia.Size = new System.Drawing.Size(526, 21);
            this.cmbTecnologia.TabIndex = 33;
            this.cmbTecnologia.SelectedIndexChanged += new System.EventHandler(this.cmbTecnologia_SelectedIndexChanged);
            // 
            // nombreColumna
            // 
            this.nombreColumna.DataPropertyName = "nombreColumna";
            this.nombreColumna.HeaderText = "Nombre Columna";
            this.nombreColumna.Name = "nombreColumna";
            // 
            // tipoDatoColumna
            // 
            this.tipoDatoColumna.DataPropertyName = "tipoDatoColumna";
            this.tipoDatoColumna.HeaderText = "Tipo Dato Columna";
            this.tipoDatoColumna.Name = "tipoDatoColumna";
            // 
            // esNulable
            // 
            this.esNulable.DataPropertyName = "esNulable";
            this.esNulable.HeaderText = "Es Nulable";
            this.esNulable.Name = "esNulable";
            // 
            // cmbTipoControl
            // 
            this.cmbTipoControl.DataPropertyName = "tipoControlId";
            this.cmbTipoControl.HeaderText = "Tipo Control";
            this.cmbTipoControl.Name = "cmbTipoControl";
            this.cmbTipoControl.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmbTipoControl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "Column5";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmGeneradorForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 445);
            this.Controls.Add(this.cmbTecnologia);
            this.Controls.Add(this.lblTecnologia);
            this.Controls.Add(this.txtNombreProyeco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCambiarDirectorio);
            this.Controls.Add(this.txtDirectorioDestino);
            this.Controls.Add(this.lblDireccionDatos);
            this.Controls.Add(this.btnConfigurarListado);
            this.Controls.Add(this.listOpciones);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dtColumnas);
            this.Controls.Add(this.cmbTabla);
            this.Controls.Add(this.lblTablas);
            this.Controls.Add(this.cmbConecciones);
            this.Controls.Add(this.lblNombreConeccion);
            this.Name = "frmGeneradorForms";
            this.Text = "Generador de Formularios y Listados";
            ((System.ComponentModel.ISupportInitialize)(this.dtColumnas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTecnologia;
        private System.Windows.Forms.TextBox txtNombreProyeco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCambiarDirectorio;
        private System.Windows.Forms.TextBox txtDirectorioDestino;
        private System.Windows.Forms.Label lblDireccionDatos;
        private System.Windows.Forms.Button btnConfigurarListado;
        private System.Windows.Forms.CheckedListBox listOpciones;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dtColumnas;
        private System.Windows.Forms.ComboBox cmbTabla;
        private System.Windows.Forms.Label lblTablas;
        private System.Windows.Forms.ComboBox cmbConecciones;
        private System.Windows.Forms.Label lblNombreConeccion;
        private System.Windows.Forms.FolderBrowserDialog fDialog;
        private System.Windows.Forms.ComboBox cmbTecnologia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreColumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDatoColumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn esNulable;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbTipoControl;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;

    }
}