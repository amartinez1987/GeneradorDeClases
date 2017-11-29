using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorClases.Entity.Model
{
    public class Control_ASPxComboBox:Control
    {
        private  const string alias = "cmb";
        public string nombreAtributo { get; set; }
        public string tabla { get; set; }
        public string textField { get; set; }
        public string valueField { get; set; }

        public Control_ASPxComboBox(string nombreAtributo, string tabla = "", string textField = "", string valueField = "")
        {
            this.id = 0;
            this.nombre = "ASPxComboBox";
            this.nombreAtributo = nombreAtributo;
            this.tabla = tabla;
            this.textField = textField;
            this.valueField = valueField;
        }

        public Control_ASPxComboBox()
        {
            // TODO: Complete member initialization
        }

        public List<string> GetCodeBehindForm()
        {
            List<string> lineasDocumento = new List<string>();

            lineasDocumento.Add(string.Format("public DevExpress.Web.ASPxEditors.ASPxLabel getlbl{0}", nombreAtributo));
            lineasDocumento.Add("{");
            lineasDocumento.Add("get");
            lineasDocumento.Add("{");
            lineasDocumento.Add(string.Format("return lbl{0};", nombreAtributo));
            lineasDocumento.Add("}");
            lineasDocumento.Add("}");
            lineasDocumento.Add(string.Format("public DevExpress.Web.ASPxEditors.ASPxComboBox get{1}{0}()", nombreAtributo, alias));
            lineasDocumento.Add("{");
            lineasDocumento.Add("get");
            lineasDocumento.Add("{");
            lineasDocumento.Add(string.Format("return {1}{0};", nombreAtributo, alias));
            lineasDocumento.Add("}");
            lineasDocumento.Add("}");

            lineasDocumento.Add(string.Format("public void cargar{0}()", nombreAtributo));
            lineasDocumento.Add("{");
            lineasDocumento.Add(string.Format("List<{0}ViewModel> lista = {0}Controller.getLista{0}();", this.tabla));
            lineasDocumento.Add(string.Format("{0}{1}.DataSource = lista;", alias, nombreAtributo));
            lineasDocumento.Add(string.Format("{0}{1}.TextField = \"{2}\";", alias, nombreAtributo, this.textField));
            lineasDocumento.Add(string.Format("{0}{1}.TextField = \"{2}\";", alias, nombreAtributo, this.valueField));
            lineasDocumento.Add("}");

            return lineasDocumento;
        }

        public List<string> GetCodeAspxForm()
        {
            List<string> lineasDocumento = new List<string>();
            lineasDocumento.Add(string.Format("<dx:ASPxLabel ID=\"lbl{0}\" runat=\"server\" ClientInstanceName=\"lbl{0}\" Text=\"{0}\" Theme=\"Moderno\">", nombreAtributo));
            lineasDocumento.Add("</dx:ASPxLabel>");
            lineasDocumento.Add(string.Format("<dx:ASPxComboBox ID=\"{1}{0}\" runat=\"server\" Theme=\"Moderno\" Width=\"100%\" ClientInstanceName=\"{1}{0}\" DropDownRows=\"1\">", nombreAtributo, alias));
            lineasDocumento.Add(string.Format("</dx:ASPxComboBox>"));
            return lineasDocumento;
        }
    }
}
