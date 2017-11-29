using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorClases.Entity.Model
{
    public class Control_ASPxTextBox:Control
    {
        private const string alias = "txt";
        public string nombreAtributo { get; set; }
        bool sinSpinButton { get; set; }
        public Control_ASPxTextBox(string nombreAtributo)
        {
            this.id = 2;
            this.nombre = "ASPxTextBox";
            this.nombreAtributo = nombreAtributo;
        }

        public Control_ASPxTextBox()
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
            lineasDocumento.Add(string.Format("public DevExpress.Web.ASPxEditors.ASPxTextBox get{1}{0}()", nombreAtributo, alias));
            lineasDocumento.Add("{");
            lineasDocumento.Add("get");
            lineasDocumento.Add("{");
            lineasDocumento.Add(string.Format("return {1}{0};", nombreAtributo, alias));
            lineasDocumento.Add("}");
            lineasDocumento.Add("}");

            return lineasDocumento;
        }

        public List<string> GetCodeAspxForm()
        {
            List<string> lineasDocumento = new List<string>();
            lineasDocumento.Add(string.Format("<dx:ASPxLabel ID=\"lbl{0}\" runat=\"server\" ClientInstanceName=\"lbl{0}\" Text=\"{0}\" Theme=\"Moderno\">", nombreAtributo));
            lineasDocumento.Add("</dx:ASPxLabel>");
            lineasDocumento.Add(string.Format("<dx:ASPxTextBox ID=\"{1}{0}\" ClientInstanceName=\"{1}{0}\" runat=\"server\" Width=\"100%\">", nombreAtributo, alias));
            lineasDocumento.Add("</dx:ASPxTextBox>");
            return lineasDocumento;
        }
    }
}
