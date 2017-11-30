using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorClases.Entity.Model
{
    public class Control_ASPxDateEdit:Control
    {
        private  const string alias = "txt";
        public string nombreAtributo { get; set; }        

        public Control_ASPxDateEdit(string nombreAtributo, string formatoFecha = "")
        {
            this.id = 3;
            this.nombre = "ASPxDateEdit";
            this.nombreAtributo = nombreAtributo;
            this.formatoFecha = formatoFecha;
        }

        public Control_ASPxDateEdit()
        {
            // TODO: Complete member initialization
            this.id = 3;
            this.nombre = "ASPxDateEdit";
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
            lineasDocumento.Add(string.Format("public DevExpress.Web.ASPxEditors.ASPxDateEdit get{1}{0}()", nombreAtributo, alias));
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
            lineasDocumento.Add(string.Format("<dx:ASPxDateEdit ID=\"{2}{0}\" ClientInstanceName=\"{2}{0}\" Width=\"100%\" {1} runat=\"server\">", nombreAtributo, formatoFecha != "" ? "DisplayFormatString=\"yyyy/MM/dd\" UseMaskBehavior=\"True\" EditFormat=\"Custom\" " : "", alias));
            lineasDocumento.Add("</dx:ASPxDateEdit>");
            return lineasDocumento;
        }
    }
}
