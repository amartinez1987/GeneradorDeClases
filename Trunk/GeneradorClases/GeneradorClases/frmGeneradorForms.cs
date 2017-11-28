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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string error = "";
            foreach (string item in listOpciones.CheckedItems)
            {
                if (item == "")
                {

                }

                if (item == "")
                {

                }

                if (item == "")
                {
                }

                if (item == "")
                {
                }
            }

            MessageBox.Show("Proceso de Generación Completado.");
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
            ConecionServidorViewModel model = (cmbConecciones.SelectedItem as ConecionServidorViewModel);
            this.model = model;
            string error = "";

            dtColumnas.DataSource = MetodosGeneralesController.getColumnasTablaBaseDato(model.servidor, model.baseDatos, model.usuario, model.contrasena, cmbTabla.SelectedItem.ToString(), ref error);

        }

        private void btnOperacionesPatronState_Click(object sender, EventArgs e)
        {

        }

        private void cmbTecnologia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarTipoElementosPorLenguaje(cmbTecnologia.SelectedItem.ToString());
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
            if (e.RowIndex > -1 && e.ColumnIndex == dtColumnas.Columns["btnEditar"].Index)
            {
                DataGridViewComboBoxCell c = (dtColumnas.Rows[e.RowIndex].Cells["cmbTipoControl"] as DataGridViewComboBoxCell);

                ControlesDevExpress cDx = null;
                foreach (ControlesDevExpress item in c.Items)
                {
                    cDx = item.id == int.Parse(c.Value.ToString()) ? item : cDx;
                }

                if (cDx != null)
                {
                    frmConfiguracionControlDevExpress childForm = new frmConfiguracionControlDevExpress(ref cDx, (cmbTabla.DataSource as List<string>), model);

                    childForm.Text = "Configurar Control";
                    childForm.Show();
                }

            }


        }

        private void btnGenerar_Click_1(object sender, EventArgs e)
        {
            string error = "";
            foreach (string op in listOpciones.CheckedItems)
            {
                if (op == "Formulario")
                {

                    List<DatosColumna> l = (dtColumnas.DataSource as List<DatosColumna>);
                    foreach (DataGridViewRow item in dtColumnas.Rows)
                    {
                        DataGridViewComboBoxCell c = (item.Cells["cmbTipoControl"] as DataGridViewComboBoxCell);
                        try
                        {
                            ControlesDevExpress cDx = null;
                            foreach (ControlesDevExpress i in c.Items)
                            {
                                cDx = i.id == int.Parse(c.Value.ToString()) ? i : cDx;
                            }
                            DatosColumna dtc = l.Find(x => x.nombreColumna == item.Cells["nombreColumna"].Value.ToString());
                            dtc.tipoControl = cDx;
                        }
                        catch
                        {                        }

                    }


                }
            }
        }

    }
}
