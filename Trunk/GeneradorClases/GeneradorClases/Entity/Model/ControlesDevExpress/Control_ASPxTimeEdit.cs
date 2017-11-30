using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorClases.Entity.Model
{
    public class Control_ASPxTimeEdit:Control
    {
                private const string alias = "txt";
        public string nombreAtributo { get; set; }
        bool sinSpinButton { get; set; }
        public Control_ASPxTimeEdit(string nombreAtributo)
        {
            this.id = 9;
            this.nombre = "ASPxTimeEdit";
            this.nombreAtributo = nombreAtributo;
        }

        public Control_ASPxTimeEdit()
        {
            // TODO: Complete member initialization
            this.id = 9;
            this.nombre = "ASPxTimeEdit";
        }

        public List<string> GetCodeBehindForm()
        {
            List<string> lineasDocumento = new List<string>();
            lineasDocumento.Add(string.Format("public DevExpress.Web.ASPxEditors.ASPxTimeEdit getlbl{0}", nombreAtributo));
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
            lineasDocumento.Add(string.Format("<dx:ASPxTimeEdit ID=\"{1}{0}\" ClientInstanceName=\"{1}{0}\" runat=\"server\">", nombreAtributo, alias));
            lineasDocumento.Add("</dx:ASPxTimeEdit>");
            return lineasDocumento;
        }
    }
}
