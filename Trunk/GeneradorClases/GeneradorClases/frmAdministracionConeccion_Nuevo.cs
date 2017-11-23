using GeneradorClases.Entity.Controller;
using GeneradorClases.Entity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneradorClases
{
    public partial class frmAdministracionConeccion_Nuevo : Form
    {
        public frmAdministracionConeccion_Nuevo()
        {
            InitializeComponent();
            administracionConeccion1.getTxtNombreServidor().Leave += txtNombreServidor_Leave;

        }

        private void frmAdministracionConeccion_Nuevo_Load(object sender, EventArgs e)
        {
            
        }

        private void txtNombreServidor_Leave(object sender, EventArgs e)
        {
            string error = "";
            try
            {
                List<vSysDataBaseViewModel> listBaseDatos = MetodosGeneralesController.getListaBaseDatos(administracionConeccion1.getTxtNombreServidor().Text, administracionConeccion1.getTxtUsuarioConeccion().Text, administracionConeccion1.getTxtContrasenaConeccion().Text, ref error);
                administracionConeccion1.getCmbBaseDatos().DataSource = listBaseDatos;
                administracionConeccion1.getCmbBaseDatos().ValueMember = "database_id";
                administracionConeccion1.getCmbBaseDatos().DisplayMember = "name";
            }
            catch (Exception)
            {
                
                MessageBox.Show(error,"Administracion de Conecciones", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
          
                 
        }
    }
}
