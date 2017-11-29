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
    public partial class frmConfiguracionControlDevExpress : Form
    {
        private ControlesDevExpress cDx;
        private List<string> list;
        private ConecionServidorViewModel model;



        public frmConfiguracionControlDevExpress()
        {
            InitializeComponent();
        }



        public frmConfiguracionControlDevExpress(ref ControlesDevExpress cDx, List<string> list, ConecionServidorViewModel model)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.cDx = cDx;
            this.list = list;
            this.model = model;
            switch (cDx.nombre)
            {
                case "ASPxComboBox":
                    cmbTabla.DataSource = list;
                    string error = "";
                    cmbValorCampo.DataSource = MetodosGeneralesController.getColumnasTablaBaseDato(model.servidor, model.baseDatos, model.usuario, model.contrasena, cmbTabla.SelectedItem.ToString(), ref error);
                    cmbValorCampo.ValueMember = "nombreColumna";
                    cmbValorCampo.DisplayMember = "nombreColumna";
                    cmbTextoCampo.DataSource = MetodosGeneralesController.getColumnasTablaBaseDato(model.servidor, model.baseDatos, model.usuario, model.contrasena, cmbTabla.SelectedItem.ToString(), ref error);
                    cmbTextoCampo.ValueMember = "nombreColumna";
                    cmbTextoCampo.DisplayMember = "nombreColumna";

                    chSinSpinButton.Enabled = false;
                    txtFormatoFecha.Enabled = false;



                    break;
                case "ASPxSpinEdit":
                    txtFormatoFecha.Enabled = false;
                    cmbValorCampo.Enabled = false;
                    cmbTextoCampo.Enabled = false;
                    cmbTabla.Enabled = false;
                    break;
                case "ASPxDateEdit":
                    cmbTabla.Enabled = false;
                    cmbValorCampo.Enabled = false;
                    cmbTextoCampo.Enabled = false;
                    chSinSpinButton.Enabled = false;
                    break;

                default:
                    cmbTabla.Enabled = false;
                    cmbValorCampo.Enabled = false;
                    cmbTextoCampo.Enabled = false;
                    chSinSpinButton.Enabled = false;
                    txtFormatoFecha.Enabled = false;
                    break;
            }


        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTabla.SelectedItem != null)
                {
                    cDx.tabla = cmbTabla.SelectedItem.ToString();
                    cDx.dataSource = cDx.tabla + "Controller.get" + cDx.tabla + "();";
                }
                cDx.sinSpinButton = chSinSpinButton.Checked;
                cDx.textField = (cmbTextoCampo.SelectedItem as DatosColumna).nombreColumna;
                cDx.valueField = (cmbValorCampo.SelectedItem as DatosColumna).nombreColumna;
            }
            catch 
            {

            }

            MessageBox.Show("Datos almacenados");
        }

        private void cmbTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            string error = "";
            try
            {
                
            cmbValorCampo.DataSource = MetodosGeneralesController.getColumnasTablaBaseDato(this.model.servidor, this.model.baseDatos, this.model.usuario, this.model.contrasena, cmbTabla.SelectedItem.ToString(), ref error);
            cmbValorCampo.ValueMember = "nombreColumna";
            cmbValorCampo.DisplayMember = "nombreColumna";
            cmbTextoCampo.DataSource = MetodosGeneralesController.getColumnasTablaBaseDato(this.model.servidor, this.model.baseDatos, this.model.usuario, this.model.contrasena, cmbTabla.SelectedItem.ToString(), ref error);
            cmbTextoCampo.ValueMember = "nombreColumna";
            cmbTextoCampo.DisplayMember = "nombreColumna";
            }
            catch 
            {
                
            }

        }




    }
}
