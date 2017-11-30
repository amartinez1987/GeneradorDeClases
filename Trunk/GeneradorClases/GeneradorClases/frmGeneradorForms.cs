using GeneradorClases.Entity.Controller;
using GeneradorClases.Entity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneradorClases
{
    public partial class frmGeneradorForms : Form
    {
        ConecionServidorViewModel model = null;

        public frmGeneradorForms()
        {
            InitializeComponent();
            cargarConecciones();
        }



        private void cargarConecciones()
        {
            cmbConecciones.DataSource = ConecionServidorController.getListConeccionesServidor();
            cmbConecciones.ValueMember = "id";
            cmbConecciones.DisplayMember = "nombreConeccion";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listOpciones_Click(object sender, EventArgs e)
        {

        }

        private void listOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEstados_Click(object sender, EventArgs e)
        {
        }

        private void cmbConecciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConecionServidorViewModel model = (cmbConecciones.SelectedItem as ConecionServidorViewModel);

            string error = "";
            cmbTabla.DataSource = MetodosGeneralesController.getListaTablasBaseDatos(model.servidor, model.baseDatos, model.usuario, model.contrasena, ref error);
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCambiarDirectorio_Click(object sender, EventArgs e)
        {
            DialogResult result = fDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fDialog.SelectedPath))
            {
                txtDirectorioDestino.Text = fDialog.SelectedPath;
            }
        }

        private void cmbTabla_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOperacionesPatronState_Click(object sender, EventArgs e)
        {

        }

        private void cmbTecnologia_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cargarTipoElementosPorLenguaje(string item)
        {
            switch (item)
            {
                case ".net + DevExpress":
                    cmbTipoControl.DataSource = MetodosGeneralesController.getElementosDevExpres();
                    cmbTipoControl.ValueMember = "id";
                    cmbTipoControl.DisplayMember = "nombre";
                    break;
            }
        }

        private void dtColumnas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks that are not on button cells. 
            List<DatosColumna> ldc = (dtColumnas.DataSource as List<DatosColumna>);
            if (e.RowIndex > -1 && e.ColumnIndex == dtColumnas.Columns["btnEditar"].Index)
            {
                DataGridViewComboBoxCell c = (dtColumnas.Rows[e.RowIndex].Cells["cmbTipoControl"] as DataGridViewComboBoxCell);
                string cnombreColumna = dtColumnas.Rows[e.RowIndex].Cells["nombreColumna"].Value.ToString();

                GeneradorClases.Entity.Model.Control cDx = null;
                foreach (GeneradorClases.Entity.Model.Control item in c.Items)
                {
                    cDx = item.id == int.Parse(c.Value.ToString()) ? item : cDx;
                }

                if (cDx != null)
                {
                    frmConfiguracionControlDevExpress childForm = new frmConfiguracionControlDevExpress(ref cDx, (cmbTabla.DataSource as List<string>), model);
                    childForm.Text = "Configurar Control";
                  DialogResult res =  childForm.ShowDialog();
                  if (res == DialogResult.Cancel) 
                  {
                      ldc.SingleOrDefault(x => x.nombreColumna == cnombreColumna).tipoControl = cDx;
                  }
                }


            }


        }

        private void btnGenerar_Click_1(object sender, EventArgs e)
        {
            string error = "";
            foreach (string op in listOpciones.CheckedItems)
            {
                switch (cmbTecnologia.SelectedItem.ToString())
                {
                    case ".net + DevExpress":

                        if (op == "Formulario")
                        {
                            List<DatosColumna> l = (dtColumnas.DataSource as List<DatosColumna>);
                            foreach (DatosColumna item in l)
                            {
                                if (item.tipoControlId != item.tipoControl.id) 
                                {
                                    item.tipoControl = GenerarFormulariosDevExpress.getControlDevExprex(item.tipoControlId, item.tipoControl);
                                }
                            }
                            GenerarFormulariosDevExpress.generarFormularioAscx(l, txtDirectorioDestino.Text, cmbTabla.SelectedItem.ToString(), txtNombreProyeco.Text);
                            GenerarFormulariosDevExpress.generarFormularioAscxCs(l, txtDirectorioDestino.Text, cmbTabla.SelectedItem.ToString(), txtNombreProyeco.Text);

                        }

                        break;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarTipoElementosPorLenguaje(cmbTecnologia.SelectedItem.ToString());
            ConecionServidorViewModel model = (cmbConecciones.SelectedItem as ConecionServidorViewModel);
            this.model = model;
            string error = "";
            dtColumnas.DataSource = MetodosGeneralesController.getColumnasTablaBaseDato(model.servidor, model.baseDatos, model.usuario, model.contrasena, cmbTabla.SelectedItem.ToString(), ref error, cmbTecnologia.SelectedItem.ToString());

        }

        private void dtColumnas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
