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
    public partial class frmGeneradorCodigos : Form
    {
        List<string> listaEstados = new List<string>();
        public frmGeneradorCodigos()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listOpciones_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            foreach (string item in listaEstados)
            {

            }
        }

        private void listOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEstados_Click(object sender, EventArgs e)
        {
            foreach (string item in listOpciones.SelectedItems)
            {
                if (item == "PatterState")
                {
                    frmEstadosPatron frmEstados = new frmEstadosPatron(ref listaEstados);
                    DialogResult res = frmEstados.ShowDialog();
                }
            }
        }
    }
}
